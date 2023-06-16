using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TGMTparking;
using TGMTplayer.Controls;
using TGMTcs;
using TGMTparking.UI;

internal static class Program
{
    //public static Mutex Mutex;
    private static string _apppath = "";
    public static WinFormsAppIdleHandler AppIdle;
    public static string phone = "0939.825.125";
    static bool loginSuccess = false;

    public static string AppPath
    {
        get
        {
            if (_apppath != "")
                return _apppath;
            _apppath = (Application.StartupPath.ToLower());
            _apppath = _apppath.Replace(@"\bin\debug", @"\").Replace(@"\bin\release", @"\");
            _apppath = _apppath.Replace(@"\bin\x86\debug", @"\").Replace(@"\bin\x86\release", @"\");
            _apppath = _apppath.Replace(@"\bin\x64\debug", @"\").Replace(@"\bin\x64\release", @"\");

            _apppath = _apppath.Replace(@"\\", @"\");

            if (!_apppath.EndsWith(@"\"))
                _apppath += @"\";
            Directory.SetCurrentDirectory(_apppath);
            return _apppath;
        }   
    }


    public static Mutex FfmpegMutex;
    
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main(string[] args)
    {
        try
        {
            Application.EnableVisualStyles();            
            Application.SetCompatibleTextRenderingDefault(false);


            bool firstInstance = true;

            var me = Process.GetCurrentProcess();
            var arrProcesses = Process.GetProcessesByName(me.ProcessName);

            //only want to do this if not passing in a command

            if (arrProcesses.Length > 1)
            {
                firstInstance = false;
            }
            
            string executableName = Application.ExecutablePath;
            var executableFileInfo = new FileInfo(executableName);


            if (!firstInstance)
            {
                MsgBox.Show("Chương trình đã chạy, vui lòng kiểm tra trong Task Manager");
                Application.Exit();
                return;
            }


            FfmpegMutex = new Mutex();
            

            TGMTregistry.GetInstance().Init("weighing");
            TGMTini.GetInstance().LoadConfig();

            //Database
            string databaseFileName = "db.sqlite3";
            string passwordDB = "viscom";
            TGMTsqlite.GetInstance().LoadDatabase(databaseFileName, passwordDB);
            

            AppIdle = new WinFormsAppIdleHandler();

            FormLogin frm = new FormLogin();
            frm.onLoginSuccess += FormLogin_Successful;
            frm.ShowDialog();

            if (!loginSuccess)
            {
                Application.Exit();
                return;
            }


            var mf = new FormParking();
            GC.KeepAlive(FfmpegMutex);
            
            Application.Run(mf);
            FfmpegMutex.Close();

        }
        catch (Exception ex)
        {
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
        }
        
    }

    private static void FormLogin_Successful(object sender)
    {
        loginSuccess = true;
    }
}