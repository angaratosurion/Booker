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
using Scrabler;
using RSSApplicationUpdater;
using LocaleHundler;
using NLog;

namespace Booker
{
  public   class program
    {
        //public static TheDarkOwlLogger.TheDarkOwlLogger Bugger;
      internal static Logger logman = NLog.LogManager.GetCurrentClassLogger();
        public static string ScriptsFolder, ScriptsDLLFolder;
        ScrablerCore scarabler = new ScrablerCore();
        Scrabler.ScrablerV2 scrablerv2 = new ScrablerV2();
        public static BookerMain Activewin;
        public static ApplicationUpdater appupdater;
        public static AssemblyCollection asscol = ScrablerCore.AssemblyCol;

        string[] definedConstants ={"GUI","StatusBar", "MainMenu",
            "Grid" };
        string[] definedValues ={"program.Activewin",
            "program.Activewin.statusStrip1", 
            "program.Activewin.menuStrip1", "program.Activewin.dtgDataGrd" };
        public static void errorreport(Exception e)
        {
           // MessageBox.Show(e.ToString());

            NoNullAllowedException nonullallowedext = new NoNullAllowedException();

            System.Data.RowNotInTableException exrownotinTable = new RowNotInTableException();
            System.ArgumentOutOfRangeException excarg = new ArgumentOutOfRangeException();
            System.IO.FileNotFoundException filenotfound = new FileNotFoundException();
            System.Xml.XmlException xmlexc = new XmlException();
            if ((e.GetType() != nonullallowedext.GetType()) && (e.GetType() != exrownotinTable.GetType())
                && (e.GetType() != excarg.GetType()) && (e.GetType() != filenotfound.GetType()) &&
                (e.GetType() != xmlexc.GetType()))
            {
                logman.Fatal(e.Message, e);

            }
        }
        public static void FindScriptsFolder()
        {

            try
            {
                string tmppath, driveletter;
                //string[] tmpproffolder;
                tmppath = "C:\\Documents and Settings\\" + Environment.UserName + "\\Application Data\\" + Application.ProductName + "\\" + "Scripts";

                //    tmppath += "\\" + tmpproffolder;
                ScriptsFolder = tmppath;



            }
            catch (Exception ex)
            {

               program.errorreport(ex);

                //return null;
            }

        }
        public void createScriptsDirectory()
        {


            try
            {
                program.FindScriptsFolder();
                string path;
                if (program.ScriptsFolder != null)
                {
                    if (Directory.Exists(program.ScriptsFolder) == false)
                    {
                        // MessageBox.Show(program.ScriptsFolder + "\\" + ScrablerCore.ScriptsFolder);
                        Directory.CreateDirectory(program.ScriptsFolder);




                    }



                }
                // webBrowser.ScriptsFolder = program.ScriptsFolder + "\\" + ScrablerCore.ScriptsFolder;


            }
            catch (Exception ex)
            {


                  program.errorreport(ex);

            }



        }
        public static void FindScriptsDLLFolder()
        {

            try
            {
                string tmppath, driveletter;
                //string[] tmpproffolder;
                tmppath = "C:\\Documents and Settings\\" + Environment.UserName + "\\Application Data\\" + Application.ProductName + "\\" + ScrablerCore.ScriptsFolderDLL;

                //    tmppath += "\\" + tmpproffolder;
                ScriptsDLLFolder = tmppath;


            }
            catch (Exception ex)
            {

                  program.errorreport(ex);

                //return null;
            }

        }
        public void createScripts_DLLDirectory()
        {


            try
            {
                program.FindScriptsDLLFolder();
                string path;
                if (program.ScriptsDLLFolder != null)
                {
                    if (Directory.Exists(program.ScriptsDLLFolder) == false)
                    {
                        // MessageBox.Show(program.ScriptsFolder + "\\" + ScrablerCore.ScriptsFolder);
                        Directory.CreateDirectory(program.ScriptsDLLFolder);




                    }



                }
                // webBrowser.ScriptsFolder = program.ScriptsFolder + "\\" + ScrablerCore.ScriptsFolder;


            }
            catch (Exception ex)
            {


                  program.errorreport(ex);

            }



        }
        public void Autoexecutescripts()
        {
            try
            {

                string[] filelist = Directory.GetFiles(program.ScriptsFolder);
                scarabler.GetExeCutingApplicationVersion(Assembly.LoadFile(Application.ExecutablePath));
                string[] dirlist = Directory.GetDirectories(program.ScriptsFolder);
                if (filelist != null)
                {

                    // ScrablerCore.cp.ReferencedAssemblies.Add(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")) + "\\AxInterop.MOZILLACONTROLLib.dll");
                    // ScrablerCore.cp.ReferencedAssemblies.Add(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")) + "\\Interop.MOZILLACONTROLLib.dll");
                    ScrablerCore.cp.ReferencedAssemblies.Add(Application.ExecutablePath);
                    // ScrablerCore.definedConstants = definedConstants;
                    //   ScrablerCore.definedValues = definedValues;
                    ScrablerCore.definedConstants = definedConstants;
                    ScrablerCore.definedValues = definedValues;
                    //Interop.MOZILLACONTROLLib.dll

                    foreach (string file in filelist)
                    {
                        if (file != null)
                        {
                            scarabler.ReadScript(file);
                        }

                    }


                }
                if (dirlist != null)
                {

                    foreach (string dir in dirlist)
                    {
                        if (dir != null)
                        {
                            scrablerv2.ReadScript(dir);
                        }

                    }

                }





            }
            catch (Exception ex)
            {


                  program.errorreport(ex);

            }




        }
    }
}
