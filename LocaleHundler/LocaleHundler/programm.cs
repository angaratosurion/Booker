using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
 
//using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.IO;

using NLog;

namespace LocaleHundler
{
  public   class program
    {
        //public static TheDarkOwlLogger.TheDarkOwlLogger Bugger;
      internal static Logger logman = NLog.LogManager.GetCurrentClassLogger();
        
        string[] definedConstants ={"GUI","StatusBar", "MainMenu",
            "Grid" };
        string[] definedValues ={"program.Activewin",
            "program.Activewin.statusStrip1", 
            "program.Activewin.menuStrip1", "program.Activewin.dtgDataGrd" };
        public static void errorreport(Exception e)
        {
           // MessageBox.Show(e.ToString());

                logman.Fatal(e.Message, e);
        }
    }
}
