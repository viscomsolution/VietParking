using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTparking.DBmgr;

namespace TGMTparking
{
    public partial class FormImage : Form
    {
        Session m_session;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormImage()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormImage(Session session)
        {
            InitializeComponent();

            m_session = session;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormImage_Load(object sender, EventArgs e)
        {
            string[] imagePaths = m_session.ImagePaths.Split(';');

            if (imagePaths.Length > 0)
                pic_checkinFront.ImageLocation = Program.AppPath + imagePaths[0];
            if (imagePaths.Length > 1)
                pic_checkinBack.ImageLocation = Program.AppPath + imagePaths[1];
            if (imagePaths.Length > 2)
                pic_checkoutFront.ImageLocation = Program.AppPath + imagePaths[2];
            if (imagePaths.Length > 3)
                pic_checkoutBack.ImageLocation = Program.AppPath + imagePaths[3];
        }
    }
}
