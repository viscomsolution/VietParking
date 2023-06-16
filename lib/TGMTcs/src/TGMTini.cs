using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TGMTcs
{
    public class TGMTini
    {
        string m_path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        static TGMTini m_instance;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);              

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static TGMTini GetInstance()
        {
            if (m_instance == null)
                m_instance = new TGMTini();
            return m_instance;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void LoadConfig(string iniPath = "config.ini")
        {
            m_path = new FileInfo(iniPath ?? EXE + ".ini").FullName;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Read(string Key, string Section = null, string defaultValue="")
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, m_path);
            string result = RetVal.ToString();
            if (result == "" && defaultValue != "")
                return defaultValue;
            return result;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public int ReadInt(string Key, string Section = null, int defaultValue = 0)
        {
            var retVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", retVal, 255, m_path);
            try
            {
                return Convert.ToInt32(retVal.ToString());
            }
            catch
            {
                return defaultValue;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool ReadBool(string Key, string Section = null, bool defaultValue = false)
        {
            var retVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", retVal, 255, m_path);
            try
            {
                string val = retVal.ToString().ToLower();
                return val == "1" || val == "true";
            }
            catch
            {
                return defaultValue;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, m_path);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Write(string Key, int Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value.ToString(), m_path);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Write(string Key, bool value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, value ? "1" : "0", m_path);
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
