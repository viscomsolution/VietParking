using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTcs;
using TGMTparking.UI;

namespace TGMTparking
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_saveConfig_Click(object sender, EventArgs e)
        {
            PrintSuccess("Save success");
            timerClear.Start();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormConfig_Load(object sender, EventArgs e)
        {
            //LANE1
            txt_url1_1.Text = TGMTini.GetInstance().Read("url1_1", "LANE1");
            txt_url1_2.Text = TGMTini.GetInstance().Read("url1_2", "LANE1");

            //LANE1
            txt_url2_1.Text = TGMTini.GetInstance().Read("url2_1", "LANE2");
            txt_url2_2.Text = TGMTini.GetInstance().Read("url2_2", "LANE2");


            int LANE_IN = TGMTini.GetInstance().ReadInt("LANE_IN", "Common");
            if (LANE_IN == 1)
            {
                rd_lane1_in.Checked = true;
                rd_lane2_out.Checked = true;
            }
            else
            {
                rd_lane1_out.Checked = true;
                rd_lane2_in.Checked = true;
            }          
            chk_cropPlate.Checked = ANPRmgr.GetInstance().CropPlate;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void PrintError(string msg)
        {
            lbl_message.ForeColor = Color.Red;
            lbl_message.Text = msg;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void PrintSuccess(string msg)
        {
            lbl_message.ForeColor = Color.Green;
            lbl_message.Text = msg;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void PrintMessage(string msg)
        {
            lbl_message.ForeColor = Color.Black;
            lbl_message.Text = msg;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void timerClear_Tick(object sender, EventArgs e)
        {
            lbl_message.Text = "";
            timerClear.Stop();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_saveLane1_Click(object sender, EventArgs e)
        {
            if((rd_lane1_in.Checked && rd_lane2_in.Checked) || (rd_lane1_out.Checked && rd_lane2_out.Checked))
            {
                MsgBox.Show("Phải có 1 làn ra và 1 làn vào");
                return;
            }

            TGMTini.GetInstance().Write("LANE_IN", rd_lane1_in.Checked ? "1" : "2", "Common");

            //Lane 1
            TGMTini.GetInstance().Write("url1_1", txt_url1_1.Text, "LANE1");
            TGMTini.GetInstance().Write("url1_2", txt_url1_2.Text, "LANE1");



            //Lane 2
            TGMTini.GetInstance().Write("url2_1", txt_url2_1.Text, "LANE2");
            TGMTini.GetInstance().Write("url2_2", txt_url2_2.Text, "LANE2");



            //Common

            ANPRmgr.GetInstance().CropPlate = chk_cropPlate.Checked;
            TGMTini.GetInstance().Write("crop_plate", ANPRmgr.GetInstance().CropPlate, "Common");

            MsgBox.Show("Save thành công, vui lòng tắt chương trình và mở lại");

            timerClear.Stop();
            timerClear.Start();
        }        

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_interval_KeyPress(object sender, KeyPressEventArgs e)
        {
            TGMTform.OnlyInputNumber(sender, e);
        }
    }
}
