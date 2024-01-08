using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGMT;
using TGMTcs;

namespace TGMTparking
{
    class ANPRmgr
    {
        PlateReader ipss; //đọc biển số xe máy & xe hơi (oto) 

        static ANPRmgr m_instance;

        bool m_cropPlate = false;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static ANPRmgr GetInstance()
        {
            if (m_instance == null)
                m_instance = new ANPRmgr();
            return m_instance;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public ANPRmgr()
        {
            CropPlate = TGMTini.GetInstance().ReadBool("crop_plate", "Common");


            ipss = new PlateReader();
            //ipsscar.CropResultImage = CropPlate;            
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CropPlate
        {
            get
            {
                return m_cropPlate;
            }
            set
            {
                m_cropPlate = value;                
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public PlateInfo ReadPlate(Bitmap bmp)
        {
            if (bmp == null)
                return new PlateInfo();
            try
            {
                return ipss.Read(bmp);
            }
            catch
            {
                return new PlateInfo();
            }
        }

    }
}
