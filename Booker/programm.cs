using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;

//using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.IO;
using Scrabler;
using RSSApplicationUpdater;
using LocaleHundler;




namespace Booker
{
   public  class programm
    {
      
    
       [STAThread]
        static void Main()
        {
            try
            {
               // Bugger = new TheDarkOwlLogger.TheDarkOwlLogger(true, true, true, Application.ProductName);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                LocaleHundlerCore locale = new LocaleHundlerCore();
            // program.Bugger = new TheDarkOwlLogger.TheDarkOwlLogger(false, true, true, Application.ProductName);
                //   locale.Translate();*/
                if (locale.ReadconfigXml().ExternalLanguageFileEnabled != true)
                {
                    locale.Translate();
                }


                Application.Run(new BookerMain());

            }
                
            

            catch (Exception e)
            {
                //Bugger = new TheDarkOwlLogger.TheDarkOwlLogger(false  , true, true, Application.ProductName);
                program.errorreport(e);
            }
        }
       
    }
}
