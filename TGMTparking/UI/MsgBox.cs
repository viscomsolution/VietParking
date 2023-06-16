using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGMTparking.UI
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static MsgBox messageBox = null;
        public enum MsgBoxResult { Yes, No, Close }
        public enum MsgBoxType { Close, DongYKhong, DongYKhongDong }
        private static MsgBoxResult m_result;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static MsgBoxResult Show(string NoiDung, MsgBoxType msgBoxType = MsgBoxType.Close)
        {
            if(messageBox != null)
            {
                messageBox.Hide();
                messageBox.Close();
                messageBox = null;
            }
            messageBox = new MsgBox();
            messageBox.ShowInTaskbar = false;
            messageBox.lblNoiDung.Text = NoiDung;
            switch (msgBoxType)
            {
                case MsgBoxType.Close:
                    messageBox.btnDongY.Visible = false;
                    messageBox.btnKhong.Visible = false;
                    break;
                case MsgBoxType.DongYKhong:
                    messageBox.btnDongY.Left = messageBox.btnKhong.Left;
                    messageBox.btnKhong.Left = messageBox.btnDong.Left;
                    messageBox.btnDong.Visible = false;
                    break;
                case MsgBoxType.DongYKhongDong:
                    break;
            }
            messageBox.ShowDialog();
            return m_result;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnDongY_Click(object sender, EventArgs e)
        {
            m_result = MsgBoxResult.Yes;
            Close();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_02_Click(object sender, EventArgs e)
        {
            m_result = MsgBoxResult.No;
            Close();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_03_Click(object sender, EventArgs e)
        {
            m_result = MsgBoxResult.Close;
            Close();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ct_messagebox_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.Silver, 1), 0, 0, Width - 1, Height - 1);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                m_result = MsgBoxResult.Close;
                Close();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void lblCaption_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
