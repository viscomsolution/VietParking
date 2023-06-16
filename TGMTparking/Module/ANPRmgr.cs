using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPSS;
using TGMTcs;

namespace TGMTparking
{
    class ANPRmgr
    {
        IPSSbike ipssbike; //đọc biển số xe máy
        IPSScar ipsscar;  //đọc biển số xe hơi (oto)

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


            ipssbike = new IPSSbike();
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

        public BikePlate ReadBikePlate(Bitmap bmp)
        {
            if (bmp == null)
                return new BikePlate();
            try
            {
                return ipssbike.ReadPlate(bmp);
            }
            catch
            {
                return new BikePlate();
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public CarPlate ReadCarPlate(Bitmap bmp)
        {
            if (bmp == null)
                return new CarPlate();
            try
            {
                return ipsscar.ReadPlate(bmp);
            }
            catch
            {
                return new CarPlate();
            }
        }

    }
}
