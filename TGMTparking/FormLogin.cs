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
using Newtonsoft.Json;
using TGMTparking.DBmgr;

namespace TGMTparking.UI
{
    public partial class FormLogin : Form
    {
        public delegate void SuKien(object sender);
        public event SuKien onLoginSuccess;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormLogin()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if(UserMgr.Users == null)
            {
                UserMgr.LoadUserList();
            }

#if DEBUG
            txt_username.Text = "admin";
            txt_password.Text = "admin";
            Login();
#endif
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void Login()
        {
            if (txt_username.Text == "")
            {
                MsgBox.Show("Vui lòng nhập Tên Đăng Nhập", MsgBox.MsgBoxType.Close);
                return;
            }
            if (txt_password.Text == "")
            {
                MsgBox.Show("Vui lòng nhập Mật Khẩu", MsgBox.MsgBoxType.Close);
                return;
            }


            try
            {
                User user = UserMgr.GetUser("admin");
                if (user == null)
                {
                    MsgBox.Show("User không tồn tại", MsgBox.MsgBoxType.Close);
                    return;
                }


                string passwordHashed = TGMTcrypto.HashMd5(txt_password.Text);


                if (user.Password == passwordHashed)
                {
                    ParkingUtil.CurrentUser = user;

                    onLoginSuccess?.Invoke(this);

                    Close();
                }
                else
                {
                    MsgBox.Show("Sai mật khẩu", MsgBox.MsgBoxType.Close);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
