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

namespace TGMTparking.UI
{
    public partial class FormUser : Form
    {
        User m_currentUser;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormUser()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormUser_Load(object sender, EventArgs e)
        {
            LoadUserList();
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

        public void LoadUserList()
        {
            UserMgr.LoadUserList();

            if(UserMgr.Users.Count > 0)
            {
                gird_data.DataSource = null;
                gird_data.DataSource = UserMgr.Users;
            }
            else
            {
                PrintError("Không tìm thấy user");
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void timerClear_Tick(object sender, EventArgs e)
        {
            PrintError("");
            timerClear.Stop();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSave_Click(object sender, EventArgs e)
        {
            m_currentUser.Username = txt_username.Text;
            m_currentUser.FullName = txt_fullname.Text;
            m_currentUser.Phone = txt_phone.Text;

            if (txt_password1.Text != "" && txt_password2.Text != "")
            {
                if (txt_password1.Text != txt_password2.Text)
                {
                    MsgBox.Show("2 ô password không giống nhau");
                    return;
                }
                else
                {
                    m_currentUser.Password = TGMTcrypto.HashMd5(txt_password1.Text);
                }
            }

            
            m_currentUser.Update();
           

            LoadUserList();
            ClearInput();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void grd_data_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = gird_data.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow < 0)
            {
                return;
            }

            
            m_currentUser = UserMgr.Users[currentMouseOverRow];
            
            txt_username.Text = m_currentUser.Username;
            txt_fullname.Text = m_currentUser.FullName;
            txt_phone.Text = m_currentUser.Phone;

            btn_add.Enabled = false;
            btnSave.Enabled = true;
            btn_delete.Enabled = true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_delete_Click(object sender, EventArgs e)
        {
            m_currentUser.IsDeleted = true;
            m_currentUser.Update();
            LoadUserList();
            ClearInput();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void ClearInput()
        {
            txt_phone.Text = "";
            txt_fullname.Text = "";
            txt_username.Text = "";
            txt_password1.Text = "";
            txt_password2.Text = "";

            btn_add.Enabled = true;
            btnSave.Enabled = false;
            btn_delete.Enabled = false;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_phone.Text == "")
            {
                MsgBox.Show("Chưa nhập số điện thoại");
                return;
            }

            if (txt_phone.Text == "")
            {
                MsgBox.Show("Chưa nhập họ tên");
                return;
            }

            if (txt_password1.Text != "" && txt_password2.Text != "")
            {
                if(txt_password1.Text != txt_password2.Text)
                {
                    MsgBox.Show("2 ô password không giống nhau");
                    return;
                }
                
            }


            User user = new User();
            user.Phone = txt_phone.Text;
            user.Username = txt_username.Text;
            user.FullName = txt_fullname.Text;
            user.Password = TGMTcrypto.HashMd5(txt_password1.Text);
            
            user.Insert();

            LoadUserList();
            ClearInput();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormPlate_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                ClearInput();
                m_currentUser = null;
            }
        }
    }
}
