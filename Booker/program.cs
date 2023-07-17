namespace Booker
{
    using LocaleHundler;
    using RSSApplicationUpdater;
    using Scrabler;
    using System;
    using System.Data;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using System.Xml;
    using TheDarkOwlLogger;

    public class program
    {
        public static BookerMain Activewin;
        public static ApplicationUpdater appupdater;
        public static AssemblyCollection asscol = ScrablerCore.AssemblyCol;
        public static TheDarkOwlLogger.TheDarkOwlLogger Bugger;
        private string[] definedConstants = new string[] { "GUI", "StatusBar", "MainMenu", "Grid" };
        private string[] definedValues = new string[] { "program.Activewin", "program.Activewin.statusStrip1", "program.Activewin.menuStrip1", "program.Activewin.dtgDataGrd" };
        private ScrablerCore scarabler = new ScrablerCore();
        public static string ScriptsDLLFolder;
        public static string ScriptsFolder;

        public void Autoexecutescripts()
        {
            try
            {
                string[] filelist = Directory.GetFiles(ScriptsFolder);
                this.scarabler.GetExeCutingApplicationVersion(Assembly.LoadFile(Application.ExecutablePath));
                if (filelist != null)
                {
                    ScrablerCore.cp.ReferencedAssemblies.Add(Application.ExecutablePath);
                    ScrablerCore.definedConstants = this.definedConstants;
                    ScrablerCore.definedValues = this.definedValues;
                    foreach (string file in filelist)
                    {
                        if (file != null)
                        {
                            this.scarabler.ReadScript(file);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Bugger.TakeTheException2XmlLog(ex, Application.ProductName, Application.ProductVersion);
            }
        }

        public void createScripts_DLLDirectory()
        {
            try
            {
                FindScriptsDLLFolder();
                if ((ScriptsDLLFolder != null) && !Directory.Exists(ScriptsDLLFolder))
                {
                    Directory.CreateDirectory(ScriptsDLLFolder);
                }
            }
            catch (Exception ex)
            {
                Bugger.TakeTheException2XmlLog(ex, Application.ProductName, Application.ProductVersion);
            }
        }

        public void createScriptsDirectory()
        {
            try
            {
                FindScriptsFolder();
                if ((ScriptsFolder != null) && !Directory.Exists(ScriptsFolder))
                {
                    Directory.CreateDirectory(ScriptsFolder);
                }
            }
            catch (Exception ex)
            {
                Bugger.TakeTheException2XmlLog(ex, Application.ProductName, Application.ProductVersion);
            }
        }

        public static void errorreport(Exception e)
        {
            NoNullAllowedException nonullallowedext = new NoNullAllowedException();
            RowNotInTableException exrownotinTable = new RowNotInTableException();
            ArgumentOutOfRangeException excarg = new ArgumentOutOfRangeException();
            FileNotFoundException filenotfound = new FileNotFoundException();
            XmlException xmlexc = new XmlException();
            DirectoryNotFoundException dirnotfound = new DirectoryNotFoundException();
            FormatException fex = new FormatException();
            if ((((e.GetType() != nonullallowedext.GetType()) && (e.GetType() != exrownotinTable.GetType())) && ((e.GetType() != excarg.GetType()) && (e.GetType() != filenotfound.GetType()))) && (((e.GetType() != xmlexc.GetType()) && (e.GetType() != dirnotfound.GetType())) && (e.GetType() != fex.GetType())))
            {
                Bugger.TakeTheException2XmlLog(e, Application.ProductName, Application.ProductVersion);
            }
            else if (e.GetType() == fex.GetType())
            {
                MessageBox.Show("Configure the application and restart it");
            }
        }

        public static void FindScriptsDLLFolder()
        {
            try
            {
                ScriptsDLLFolder = @"C:\Documents and Settings\" + Environment.UserName + @"\Application Data\" + Application.ProductName + @"\Scripts DLL";
            }
            catch (Exception ex)
            {
                Bugger.TakeTheException2XmlLog(ex, Application.ProductName, Application.ProductVersion);
            }
        }

        public static void FindScriptsFolder()
        {
            try
            {
                ScriptsFolder = @"C:\Documents and Settings\" + Environment.UserName + @"\Application Data\" + Application.ProductName + @"\Scripts";
            }
            catch (Exception ex)
            {
                Bugger.TakeTheException2XmlLog(ex, Application.ProductName, Application.ProductVersion);
            }
        }

        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                LocaleHundlerCore locale = new LocaleHundlerCore();
                Bugger = new TheDarkOwlLogger.TheDarkOwlLogger(false, true, true, Application.ProductName);
                if (!locale.ReadconfigXml().ExternalLanguageFileEnabled)
                {
                    locale.Translate();
                }
                Application.Run(new BookerMain());
            }
            catch (Exception e)
            {
                errorreport(e);
            }
        }
    }
}

