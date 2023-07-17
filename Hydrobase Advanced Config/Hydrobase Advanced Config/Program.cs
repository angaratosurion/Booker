using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using NLog;

namespace Hydrobase_Advanced_Config
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        internal static Logger logman = NLog.LogManager.GetCurrentClassLogger();
        public static void errorhandling(Exception e)
        {
            NoNullAllowedException nonullallowedext = new NoNullAllowedException();
            //MessageBox.Show(nonullallowedext.GetType().ToString ());

            //   MessageBox.Show(e.GetType().ToString());
            if (e.GetType() != nonullallowedext.GetType())
            {
                logman.Fatal(e.Message, e);

            }



        }
        [STAThread]
        static void Main(string [] args)
        {
            if ((args.Length >0)&&(args[0] != null))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmGui(Convert.ToBoolean(args[0])));
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmGui());

            }
        }
    }
}
