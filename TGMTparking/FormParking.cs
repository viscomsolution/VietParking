using IPSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TGMTcs;
using TGMTparking.DBmgr;
using TGMTparking.Module;
using TGMTparking.UI;
using TGMTplayer.Controls;

namespace TGMTparking
{
    public partial class FormParking : Form
    {
        private PerformanceCounter _cpuCounter, _cputotalCounter;

        private PerformanceCounter _pcMem;
        private System.Timers.Timer _houseKeepingTimer;
        private readonly List<float> _cpuAverages = new List<float>();
        public static float CpuUsage, CpuTotal;
        private static string _counters = "";
        public static bool HighCPU;

        int LANE_IN = 1;

        private bool _shuttingDown = false;
        CameraPanel m_currentCameraPanel;
        CameraPanel m_cameraPanelInFront; //camera chụp người làn vào
        CameraPanel m_cameraPanelInBack; //camera chụp biển số làn vào
        CameraPanel m_cameraPanelOutFront; //camera chụp người làn ra
        CameraPanel m_cameraPanelOutBack; //camera chụp biển số làn ra


        TextBox txtPlateIn;
        TextBox txtPlateOut;
        PictureBox picInFront;
        PictureBox picInBack;
        PictureBox picOutFront;
        PictureBox picOutBack;

        Session m_session;
        Card m_card;


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormParking()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormParking_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.Text = lblStatus.Text + " " + TGMTutil.GetVersion() + " " + TGMTutil.GetPlaform();
            int LANE_IN = TGMTini.GetInstance().ReadInt("LANE_IN", "Common");

            if (LANE_IN == 1)
            {
                label1.Text = "LÀN VÀO";
                label2.Text = "LÀN RA";
                txtPlateIn = txt_plate1;
                txtPlateOut = txt_plate2;
                picInFront = pictureBox1_1;
                picInBack = pictureBox1_2;
                picOutFront = pictureBox2_1;
                picOutBack = pictureBox2_2;
            }
            else
            {
                label1.Text = "LÀN RA";
                panel3.BackColor = Color.DarkOrange;
                label2.Text = "LÀN VÀO";
                panel4.BackColor = Color.DeepSkyBlue;
                txtPlateIn = txt_plate2;
                txtPlateOut = txt_plate1;
                picInFront = pictureBox2_1;
                picInBack = pictureBox2_2;
                picOutFront = pictureBox1_1;
                picOutBack = pictureBox1_2;
            }

            this.WindowState = FormWindowState.Maximized;

            _houseKeepingTimer = new System.Timers.Timer(1000);
            _houseKeepingTimer.Elapsed += HouseKeepingTimerElapsed;
            _houseKeepingTimer.AutoReset = true;
            _houseKeepingTimer.SynchronizingObject = this;
            _houseKeepingTimer.Start();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormParking_KeyUp(object sender, KeyEventArgs e)
        {
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void HouseKeepingTimerElapsed(object sender, ElapsedEventArgs e)
        {
            _houseKeepingTimer.Stop();


            if (_cputotalCounter != null)
            {
                try
                {
                    while (_cpuAverages.Count > 4)
                        _cpuAverages.RemoveAt(0);
                    _cpuAverages.Add(_cpuCounter.NextValue() / Environment.ProcessorCount);

                    CpuUsage = _cpuAverages.Sum() / _cpuAverages.Count;
                    CpuTotal = _cputotalCounter.NextValue();
                    _counters = $"CPU: {CpuUsage:0.00}%";

                    if (_pcMem != null)
                    {
                        _counters += " RAM: " + Convert.ToInt32(_pcMem.RawValue / 1048576) + "MB  |";
                    }
                    lbl_CPU.Text = _counters;
                }
                catch
                {
                }

                HighCPU = CpuTotal > 90;
            }
            else
            {
                _counters = "Stats Unavailable - See Log File";
            }


            if (!_shuttingDown)
                _houseKeepingTimer.Start();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormParking_Shown(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();

            string url1_1 = TGMTini.GetInstance().Read("url1_1", "LANE1");
            m_cameraPanelInFront = new CameraPanel(url1_1, "900x700");
            InitCameraPanel(m_cameraPanelInFront, LANE_IN == 1 ? pnVideo1_1 : pnVideo2_1);


            string url1_2 = TGMTini.GetInstance().Read("url1_2", "LANE1");
            m_cameraPanelInBack = new CameraPanel(url1_2, "900x700");
            InitCameraPanel(m_cameraPanelInBack, LANE_IN == 1 ? pnVideo1_2 : pnVideo2_2);


            string url2_1 = TGMTini.GetInstance().Read("url2_1", "LANE2");
            m_cameraPanelOutFront = new CameraPanel(url2_1, "900x700");
            InitCameraPanel(m_cameraPanelOutFront, LANE_IN == 1 ? pnVideo2_1 : pnVideo1_1);


            string url2_2 = TGMTini.GetInstance().Read("url2_2", "LANE2");
            m_cameraPanelOutBack = new CameraPanel(url2_2, "900x700");
            InitCameraPanel(m_cameraPanelOutBack, LANE_IN == 1 ? pnVideo2_2 : pnVideo1_2);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);
            Thread t3 = new Thread(new ThreadStart(LoadData));
            t3.Start();


            Thread.Sleep(500);
            Thread t4 = new Thread(new ThreadStart(ShowCPUusage));
            t4.Start();

            ANPRmgr.GetInstance();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ConnectCardReader();            
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void LoadData()
        {
            CardMgr.LoadCardList(true, true, true);
            this.Invoke(new Action(() => { lblCard.Text = "Thẻ chưa dùng: " + CardMgr.CountNotUisng().ToString() + "  |"; }));
            this.Invoke(new Action(() => { lblCountVehicle.Text = "Xe trong bãi: " + SessionMgr.CountInParkingSession(); }));
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ShowCPUusage()
        {
            try
            {
                _cputotalCounter = new PerformanceCounter("Processor", "% Processor Time", "_total", true);
                _cpuCounter = new PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName, true);
                try
                {
                    _pcMem = new PerformanceCounter("Process", "Working Set - Private", Process.GetCurrentProcess().ProcessName, true);
                }
                catch
                {
                    try
                    {
                        _pcMem = new PerformanceCounter("Memory", "Available MBytes");
                    }
                    catch (Exception ex2)
                    {
                        _pcMem = null;
                    }
                }
            }
            catch (Exception ex)
            {
                _cputotalCounter = null;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormParking_SizeChanged(object sender, EventArgs e)
        {
            int scaleW = 16;
            int scaleH = 9;

            panel1.Width = (this.Width - 16) / 2;
            pnVideo1_1.Width = panel1.Width / 2;
            pnVideo1_1.Height = pnVideo1_1.Width * scaleH / scaleW;

            pnVideo1_2.Location = new Point(pnVideo1_1.Location.X + pnVideo1_1.Width + 4, pnVideo1_2.Location.Y);
            pnVideo1_2.Width = (panel1.Width / 2) - 10;
            pnVideo1_2.Height = pnVideo1_1.Width * scaleH / scaleW;

            pnVideo2_1.Width = panel1.Width / 2;
            pnVideo2_1.Height = pnVideo2_1.Width * scaleH / scaleW;

            pnVideo2_2.Location = new Point(pnVideo2_1.Location.X + pnVideo1_1.Width + 4, pnVideo2_2.Location.Y);
            pnVideo2_2.Width = (panel2.Width / 2) - 10;
            pnVideo2_2.Height = pnVideo1_1.Width * scaleH / scaleW;


            label1.Location = new Point(panel1.Width / 2 - 80, label1.Location.Y);
            label2.Location = new Point(panel2.Width / 2 - 80, label2.Location.Y);

            pictureBox1_1.Location = new Point(pnVideo1_1.Location.X, pnVideo1_1.Location.Y + pnVideo1_1.Height + 4);
            pictureBox1_1.Width = pnVideo1_1.Width;
            pictureBox1_1.Height = pnVideo1_1.Height;
            pictureBox1_2.Location = new Point(pnVideo1_2.Location.X, pnVideo1_2.Location.Y + pnVideo1_1.Height + 4);
            pictureBox1_2.Width = pnVideo1_2.Width;
            pictureBox1_2.Height = pnVideo1_2.Height;

            pictureBox2_1.Location = new Point(pnVideo2_1.Location.X, pnVideo2_1.Location.Y + pnVideo1_1.Height + 4);
            pictureBox2_1.Width = pnVideo2_1.Width;
            pictureBox2_1.Height = pnVideo2_1.Height;
            pictureBox2_2.Location = new Point(pnVideo2_2.Location.X, pnVideo2_2.Location.Y + pnVideo1_1.Height + 4);
            pictureBox2_2.Width = pnVideo2_2.Width;
            pictureBox2_2.Height = pnVideo2_2.Height;

            txt_plate1.Location = new Point((panel1.Width / 2) - (txt_plate1.Width / 2),  pictureBox1_1.Location.Y + pictureBox1_1.Height + 10);
            txt_plate2.Location = new Point((panel2.Width / 2) - (txt_plate2.Width / 2), pictureBox2_1.Location.Y + pictureBox2_1.Height + 10);

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ConnectCardReader()
        {
            bool connected = CardReaderMgr.GetInstance().ConnectToCardReader();
            if(connected)
            {
                lbl_cardReader.Text = "Card reader: YES |";
                CardReaderMgr.GetInstance().onCardAppear += OnCardAppearHandler;
            }
            else
            {
                lbl_cardReader.Text = "Card reader: NO |";
                lbl_cardReader.ForeColor = Color.Red;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void OnCardAppearHandler(object sender, BoardEventArgs e)
        {
            this.Invoke(new Action(() => { OnCardAppear(e.cardID); }));
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void OnCardAppear(string cardID)
        {
            TGMTsound.PlaySound("sfx_counter_10_to_5.wav");

            //check card exist
            Card card = CardMgr.GetCard(cardID);
            if (card == null)
            {
                MsgBox.Show("Thẻ không tồn tại");
                return;
            }

            //check card status
            if (card.Status == "Bị mất")
            {
                MsgBox.Show("Thẻ này đang bị khóa, vui lòng báo lại quản lý");
                return;
            }
            else if (card.Status == "Đang dùng")
            {
                Session s = SessionMgr.QueryByCard(card.CardID);
                if (s == null)
                {
                    MsgBox.Show("Không tìm thấy lượt xe, vui lòng reset thẻ");
                    return;
                }
                if(m_session == null)
                {
                    PrepareCheckout(s, card);
                }
                else
                {
                    Checkout(m_session, card);
                }
            }
            else if (card.Status == "Chưa dùng")
            {
                Checkin(card);
            }
            else
            {
                MsgBox.Show("Trạng thái lỗi: " + card.Status);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void PrintError(string msg)
        {
            lblStatus.Text = msg;
            lblStatus.ForeColor = Color.Red;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void PrintSuccess(string msg)
        {
            lblStatus.Text = msg;
            lblStatus.ForeColor = Color.White;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void InitCameraPanel(CameraPanel camPanel, Panel parentPanel)
        {
            camPanel.parent = parentPanel;
            camPanel.Click += cameraWindows_Click;
            parentPanel.Controls.Add(camPanel);
            camPanel.Start();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void cameraWindows_Click(object sender, EventArgs e)
        {
            m_currentCameraPanel = (CameraPanel)sender;
            MouseEventArgs ee = (MouseEventArgs)e;

            if (ee.Button == MouseButtons.Right)
            {
                if(m_currentCameraPanel.parent.Name == "pnVideo1_1" || m_currentCameraPanel.parent.Name == "pnVideo1_2")
                {
                    ctxtMnu.Show(new Point(m_currentCameraPanel.parent.Location.X + ee.Location.X,
                        this.Location.Y + m_currentCameraPanel.parent.Location.Y + panel3.Height + ee.Location.Y));
                }
                else
                {
                    ctxtMnu.Show(new Point(m_currentCameraPanel.parent.Location.X + ee.Location.X + panel2.Location.X,
                        this.Location.Y + m_currentCameraPanel.parent.Location.Y + panel3.Height + ee.Location.Y));
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void lượtXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSession frm = new FormSession();
            frm.ShowDialog();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void danhSáchThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardReaderMgr.GetInstance().onCardAppear -= OnCardAppearHandler;
            FormCard frm = new FormCard();
            frm.ShowDialog();
            CardReaderMgr.GetInstance().onCardAppear += OnCardAppearHandler;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser frm = new FormUser();
            frm.ShowDialog();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfig frm = new FormConfig();
            frm.ShowDialog();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormParking_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_cameraPanelInFront != null)
            {
                m_cameraPanelInFront.Stop();
                m_cameraPanelInFront.Dispose();
            }
            if (m_cameraPanelInBack != null)
            {
                m_cameraPanelInBack.Stop();
                m_cameraPanelInBack.Dispose();
            }
            if (m_cameraPanelOutFront != null)
            {
                m_cameraPanelOutFront.Stop();
                m_cameraPanelOutFront.Dispose();
            }
            if (m_cameraPanelOutBack != null)
            {
                m_cameraPanelOutBack.Stop();
                m_cameraPanelOutBack.Dispose();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Checkin(Card card)
        {
            Bitmap bmpFront = null;
            Bitmap bmpBack = null;

            bmpFront = m_cameraPanelInFront.GetFrame();
            bmpBack = m_cameraPanelInBack.GetFrame();
        
            List<string> imagePaths = new List<string>();

            if (bmpFront != null)
            {
                string filePath = ParkingUtil.GenFilePath("IN1");
                bmpFront.Save(filePath, ImageFormat.Jpeg);
                imagePaths.Add(filePath);
                picInFront.Image = bmpFront;
            }

            if (bmpBack != null)
            {
                string filePath = ParkingUtil.GenFilePath("IN2");
                bmpBack.Save(filePath, ImageFormat.Jpeg);
                imagePaths.Add(filePath);
                picInBack.Image = bmpBack;


                //đọc biển số xe
                BikePlate plate = ANPRmgr.GetInstance().ReadBikePlate(bmpBack);
                if(plate != null)
                {
                    txtPlateIn.Text = plate.text;
                }                
            }


            Session s = new Session();
            s.ImagePaths = string.Join(";", imagePaths.ToArray());


            s.PlateCheckin = txtPlateIn.Text;
            if (ParkingUtil.CurrentUser != null)
            {
                s.StaffCheckin = ParkingUtil.CurrentUser.Username;
            }

            s.Status = "Trong bãi";
            s.CheckinTime = DateTime.Now;


            if (card != null)
            {
                card.Status = "Đang dùng";
                card.Update();

                s.CardID = card.CardID;
            }

            s.Insert();

            timerClear.Start();
            PrintSuccess("Cho xe vào thành công");

            lblCountVehicle.Text = "Xe trong bãi: " + SessionMgr.CountInParkingSession();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void timerClear_Tick(object sender, EventArgs e)
        {
            timerClear.Stop();
            txtPlateIn.Text = "";
            txtPlateOut.Text = "";
            picInFront.Image = Properties.Resources.logo_invoice;
            picInBack.Image = Properties.Resources.logo_invoice;
            picOutFront.Image = Properties.Resources.logo_invoice;
            picOutBack.Image = Properties.Resources.logo_invoice;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void PrepareCheckout(Session s, Card card)
        {
            if (s == null)
                return;

            string[] imagePaths;
            if (s.ImagePaths != null && s.ImagePaths != "")
            {
                imagePaths = s.ImagePaths.Split(';');
                if (imagePaths.Length == 2)
                {
                    picInFront.ImageLocation = Directory.GetCurrentDirectory() + "\\" + imagePaths[0];
                    picInBack.ImageLocation = Directory.GetCurrentDirectory() + "\\" + imagePaths[1];
                }
            }
            m_session = s;
            m_card = card;

            PrintSuccess("Load lượt xe vào thành công, quẹt thẻ lần nữa cho xe ra");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Checkout(Session s, Card card)
        {
            try
            {
                Bitmap bmpFront = null;
                Bitmap bmpBack = null;

                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        bmpFront = m_cameraPanelOutFront.GetFrame();
                        bmpBack = m_cameraPanelOutBack.GetFrame();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                    GC.Collect();
                });

                List<string> tempList = new List<string>();
                if (s.ImagePaths == null || s.ImagePaths.Length == 0)
                {
                    tempList = new List<string>();
                }
                else
                {
                    tempList = new List<string>(s.ImagePaths.Split(';'));
                }

                if (bmpFront != null)
                {
                    string filePath = ParkingUtil.GenFilePath("OUT1");
                    bmpFront.Save(filePath, ImageFormat.Jpeg);
                    tempList.Add(filePath);
                    picOutFront.Image = bmpFront;
                }

                if (bmpBack != null)
                {
                    string filePath = ParkingUtil.GenFilePath("OUT2");
                    bmpBack.Save(filePath, ImageFormat.Jpeg);
                    tempList.Add(filePath);
                    picOutBack.Image = bmpBack;

                    //đọc biển số xe
                    BikePlate plate = ANPRmgr.GetInstance().ReadBikePlate(bmpBack);
                    if (plate != null)
                    {
                        txtPlateOut.Text = plate.text;
                    }
                }


                s.PlateCheckout = txtPlateOut.Text;
                if (ParkingUtil.CurrentUser != null)
                {
                    s.StaffCheckout = ParkingUtil.CurrentUser.Username;
                }

                s.Status = "Đã về";
                s.CheckoutTime = DateTime.Now;



                s.ImagePaths = string.Join(";", tempList.ToArray());
                s.Update();


                if (card != null)
                {
                    card.Status = "Chưa dùng";
                    card.Update();

                    CardMgr.LoadCardList(true, true, true);
                }

                timerClear.Start();
                m_session = null;
                m_card = null;

                PrintSuccess("Cho xe ra thành công");

                lblCountVehicle.Text = "Xe trong bãi: " + SessionMgr.CountInParkingSession();
            }
            catch (Exception ex)
            {
                MsgBox.Show(ex.Message);
            }
        }
    }
}
