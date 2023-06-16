using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGMTcs;
using TGMTparking.DBmgr;

namespace TGMTparking
{
    class ParkingUtil
    {
        public static User CurrentUser = null;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        static string _saveDir = "";
        public static string SaveDir
        {
            get
            {
                if (_saveDir == "")
                {
                    _saveDir = TGMTini.GetInstance().Read("save_dir", "Common", _saveDir);
                }
                return _saveDir;
            }
            set
            {
                _saveDir = value;
                TGMTini.GetInstance().Write("save_dir", _saveDir, "Common");
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string GenFilePath(string IN_or_OUT)
        {
            DateTime now = DateTime.Now;
            string dirPath = String.Format(@"{0}\{1}\{2}\{3}\", ParkingUtil.SaveDir, now.Year, now.ToString("MM"), now.ToString("dd"));
            Directory.CreateDirectory(String.Format(@"{0}\{1}", ParkingUtil.SaveDir, now.Year));
            Directory.CreateDirectory(String.Format(@"{0}\{1}\{2}", ParkingUtil.SaveDir, now.Year, now.ToString("MM")));
            Directory.CreateDirectory(dirPath);

            string filePath = dirPath + DateTime.Now.ToString("yyyyMMdd_HHmmss_") + IN_or_OUT + ".jpg";
            return filePath;
        }
    }
}
