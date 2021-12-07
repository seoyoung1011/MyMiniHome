using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMiniHome
{
    static class Program
    {
        public static string _path = AppDomain.CurrentDomain.BaseDirectory + @"myminihome-2aa41-firebase-adminsdk-scn4y-881f01defd.json";
        public static string _firebaseDB = "myminihome-2aa41";

        public static string _userID;
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}
