using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTcs;
using TGMTparking.DBmgr;
using System.Drawing.Printing;

namespace TGMTparking
{
    public partial class FormSession : Form
    {
        Session m_currentSession;
        List<Session> m_sessions;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormSession()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormSession_Load(object sender, EventArgs e)
        {           
            LoadSessionList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void PrintError(string msg)
        {
            lblMessage.Text = msg;
            lblMessage.ForeColor = Color.Red;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void PrintSuccess(string msg)
        {
            lblMessage.Text = msg;
            lblMessage.ForeColor = Color.White;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void LoadSessionList()
        {

            DateTime fromDate = dateTimePicker1.Value;
            fromDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day, 0, 0, 0);

            DateTime toDate = dateTimePicker2.Value;
            toDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59);
            SessionMgr.LoadSession(chk_checkin.Checked, chk_checkout.Checked, fromDate, toDate, true, txt_searchPlate.Text);
            

            m_sessions = new List<Session>();


            for (int i = 0; i < SessionMgr.Sessions.Count; i++)
            {
                Session session = SessionMgr.Sessions[i];

                m_sessions.Add(session);
            }



            if (m_sessions.Count > 0)
            {                
                grid_data.DataSource = m_sessions;
                PrintSuccess(String.Format("Tìm thấy {0} lượt xe", m_sessions.Count));
                TGMTform.UnselectDatagridview(grid_data);
                SetGridColor(grid_data);
            }
            else
            {
                grid_data.DataSource = null;
                PrintError("Không tìm thấy lượt xe");
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void timerClear_Tick(object sender, EventArgs e)
        {
            PrintError("");
            timerClear.Stop();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadSessionList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadSessionList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void chk_checkin_CheckedChanged(object sender, EventArgs e)
        {
            LoadSessionList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void chk_checkout_CheckedChanged(object sender, EventArgs e)
        {
            LoadSessionList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void grd_data_MouseClick(object sender, MouseEventArgs e)
        {
            if (m_sessions.Count == 0)
                return;

            int rowIndex = grid_data.HitTest(e.X, e.Y).RowIndex;
            if (rowIndex < 0)
            {
                TGMTform.UnselectDatagridview(grid_data);
                return;
            }

            m_currentSession = m_sessions[rowIndex];       
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void grid_data_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowImage();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_searchPlate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadSessionList();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_viewImage_Click(object sender, EventArgs e)
        {
            ShowImage();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void ShowImage()
        {
            if (grid_data.SelectedRows.Count == 0)
                return;
            if (m_currentSession == null)
                return;

            FormImage frm = new FormImage(m_currentSession);
            frm.ShowDialog();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void cb_purpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSessionList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void cb_good_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSessionList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void cb_seller_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSessionList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void cb_staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSessionList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void cb_buyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSessionList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void rd_desc_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_asc.Checked)
                m_sessions = m_sessions.OrderBy(o => o.CheckinTime).ToList();
            else
                m_sessions = m_sessions.OrderByDescending(o => o.CheckinTime).ToList();

            grid_data.DataSource = null;
            grid_data.DataSource = m_sessions;

            TGMTform.UnselectDatagridview(grid_data);
            SetGridColor(grid_data);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void SetGridColor(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells["Status"].Value.ToString() == "Đã về")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void choXeRaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_currentSession.Status = "Đã về";
            m_currentSession.CheckoutTime = DateTime.Now;
            m_currentSession.Update();

            LoadSessionList();

            if(m_currentSession.CardID != null && m_currentSession.CardID != "")
            {
                Card card = CardMgr.GetCard(m_currentSession.CardID);
                if(card != null)
                {
                    card.Reset();
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ctx_1_Opening(object sender, CancelEventArgs e)
        {
            if(m_currentSession.Status != "Trong bãi")
            {
                choXeRaToolStripMenuItem.Visible = false;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadSessionList();
        }
    }
}
