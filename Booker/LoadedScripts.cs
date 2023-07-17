using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;
using System.IO;
using System.Configuration;
using System.Globalization;
//using System.Timers;
using Hydrobase;
using HydrobaseSDK;
using TheDarkOwlLogger;
using PluginHundler;
using TimeLimitedWindow;
using WareForms;
using HydroMultyUser;

using RSSApplicationUpdater;
using Scrabler;


namespace Booker
{
    public partial class LoadedScripts : WareForm
    {
        public LoadedScripts()
        {
            InitializeComponent();
        }
        List<ScriptInfo> scrinf = program.asscol.ScriptInfoCollection();
        private void LoadedScripts_Load(object sender, EventArgs e)
        {
            if (scrinf != null)
            {
                //version, description, copyright, LowerappVer, MaxappVer, scrablerVersion;

                dataScriptsInfo.Columns.Add("title", "Title");
                dataScriptsInfo.Columns.Add("description", "Description");
                dataScriptsInfo.Columns.Add("version","Version");
                dataScriptsInfo.Columns.Add("author","Athor");
                dataScriptsInfo.Columns.Add("copyright", "Copyright");
                foreach (ScriptInfo scr in scrinf)
                {
                    object[] val = new object[5];
                    val[0] = scr.Title;
                    val[1] = scr.Description;
                    val[2] = scr.Version;
                    val[3] = scr.Author;
                    val[4] = scr.Copyright;
                    dataScriptsInfo.Rows.Add(val);


                }
             


            }

        }
    }
}