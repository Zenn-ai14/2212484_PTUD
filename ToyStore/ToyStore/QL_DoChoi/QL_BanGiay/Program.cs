using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanGiay
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool Logined = false;
            bool re_login;
            do
            {
                re_login = false;
                frmLogin Login = new frmLogin();
                Application.Run(Login);
                if( Login.Thoat == true )   // Bấm thoát
                    break;
            
                if(Login.Logined == true)
                {
                    Logined = true;
                    frmMain Main = new frmMain(Login.username, Login.IsMananger);
                    Application.Run(Main);
                    if(Main.Logouted == true)
                    {
                        Logined = false;
                        re_login= true;
                    }    
                }    
            }while(!Logined && re_login);
        }
    }
}
