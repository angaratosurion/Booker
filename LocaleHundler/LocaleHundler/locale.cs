using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Collections;
using System.Xml;
using System.Configuration;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Data;

using Hydrobase;
using WareForms;
//using Ini;



namespace LocaleHundler
{
    public class LocaleHundlerCore
    { 
        public static CultureInfo   SelectedCulture=null;
       
        public const string configfile="locale_config.xml";
        public const string langfileext = "xlng";
        /*public const string langtag = "Language";
        public const string GenetalSec="General";
        public const string externallangtag = "External_Lang";*/
        public static  string[] cells = { "Language","External_Lang"};
        ExternalLocaleFilesHandler exlocalHandler = new ExternalLocaleFilesHandler();
       static  hydrobaseADO ado = new hydrobaseADO();

        DataSet set = new DataSet();
        
        public LocaleHundlerCore()
		{
		}

        /*public object Create(object parent, object configContext, System.Xml.XmlNode section)
		{
            try
            {
                foreach (XmlNode node in section.ChildNodes)
                {
                    SelectedCulture = new CultureInfo(node.Value);

                }
                return SelectedCulture;


            }
            catch(Exception e)
            {
                return null;

            }
        }*/

        public void SaveLangconfigXml(string langcode,bool useextlang)
        {
            try
            {


                if (langcode != null)
                {
                    /*StreamWriter writer = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile);
                    writer.WriteLine(langtag + langcode);
                    writer.Flush();
                    writer.Close();*/
                    if (File.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile) == true)
                    {
                       // IniFile filecont = new IniFile(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile);
                        //filecont.IniWriteValue(GenetalSec, langtag, langcode);
                        if ((set.Tables.Count > 0) || (set.Tables[0] != null))
                        {
                            object[] vals = set.Tables[0].Rows[0].ItemArray;
                            vals[0] = langcode;
                            vals[1] = Convert.ToString(useextlang);
                            
                            set.Tables[0].Rows[0].ItemArray = vals;

                            ado.SaveTable(set, Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile, 0, "LocaleHundler " + LocaleHundlerCore.GetVersion());
                        }
                    }
                    else
                    {
                        ado.TableCreation(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile, cells, "LocaleHundler " + LocaleHundlerCore.GetVersion());
                        DataSet tset = new DataSet();

                        ado.AttachDataBaseinDataSet(tset, Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile);
                        if ((tset.Tables.Count > 0) || (tset.Tables[0] != null))
                        {
                            object[] vals = tset.Tables[0].Rows[0].ItemArray;
                            vals[0] = "en";
                            vals[1] = Convert.ToString(useextlang);
                            tset.Tables[0].Rows[0].ItemArray = vals;
                            //value = new LocaleSettings();
                           // this.SaveLangconfigIni("en");
                           // value.LanguageCode = "en";


                        }
                    }
                }


            }
            catch (Exception e)
            {

                program.errorreport(e);


            }



        }
        
        public LocaleSettings  ReadconfigXml()
        {
            try
            {
                LocaleSettings  value = null;
                //System.Windows.Forms.MessageBox.Show(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + configfile );
               /* StreamReader strmRead = new StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\"+configfile,Encoding.UTF8 );
                while (strmRead.EndOfStream == false)
                {
                    command = strmRead.ReadLine();
                    if (command.StartsWith(langtag) == true)
                    {
                        
                        value = command.Substring(langtag.Length, command.Length - langtag.Length);
                        //System.Windows.Forms.MessageBox.Show(value);
                        break;
                        

                    }

                }
                strmRead.Close();
                strmRead.Dispose();*/
             if (File.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile) == true)
                {
                    value = new LocaleSettings();
                    /*IniFile filecont = new IniFile(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile);
                    value.LanguageCode = filecont.IniReadValue(GenetalSec, langtag);
                    value.ExternalLanguageFileEnabled = filecont.IniReadValue(GenetalSec, externallangtag);
                 */
                    ado.AttachDataBaseinDataSet(set, Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile);

                    if ((set.Tables.Count > 0) || (set.Tables[0] != null))
                    {
                        object[] vals = set.Tables[0].Rows[0].ItemArray;
                        value.LanguageCode = Convert.ToString(vals[0]);
                        value.ExternalLanguageFileEnabled = Convert.ToBoolean(vals[1]);


                    }
                }
                else
                {

                    ado.TableCreation(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile, cells, "LocaleHundler " + LocaleHundlerCore.GetVersion());
                 DataSet tset = new DataSet();

                 ado.AttachDataBaseinDataSet(tset, Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile);
                 if((tset.Tables.Count >0) ||(tset.Tables[0]!=null ))
                 {
                     object[] vals = tset.Tables[0].Rows[0].ItemArray;
                     vals[0] = "en";
                     vals[1] = Convert.ToString(true);
                     tset.Tables[0].Rows[0].ItemArray = vals;
                     value = new LocaleSettings();
                     this.SaveLangconfigXml("en",false);
                     value.LanguageCode = "en";
                     value.ExternalLanguageFileEnabled = false;


                 }
                   

                }
                return value;

            }
            catch (Exception e)
            {
                  program.errorreport(e);
                return null;
            }


        }

        
        
        public void Translate()
            {
                try
                {
                   string langcode = this.ReadconfigXml().LanguageCode;
                   if (langcode != null)
                    {
                        SelectedCulture = new CultureInfo(langcode );
                        //SelectedCulture = new CultureInfo("en");
                        if (SelectedCulture != null)
                        {

                            Thread.CurrentThread.CurrentUICulture = SelectedCulture;
                           // MessageBox.Show("hi" + this.ReadconfigIni().LanguageCode);
                        }
                    }
                    else
                    {
                        SelectedCulture = new CultureInfo("en");
                        if (SelectedCulture != null)
                        {

                            Thread.CurrentThread.CurrentUICulture = SelectedCulture;

                        }


                    }
                }
                catch (Exception e)
                {
                    program.errorreport(e);

                }



            }
        public void Translate(string formname,WareForm form)
        {
            try
            {
                string langcode = this.ReadconfigXml().LanguageCode;
                if (this.ReadconfigXml().ExternalLanguageFileEnabled == false)
                {
                    if (langcode != null)
                    {
                        SelectedCulture = new CultureInfo(langcode);
                        //SelectedCulture = new CultureInfo("en");
                        if (SelectedCulture != null)
                        {

                            Thread.CurrentThread.CurrentUICulture = SelectedCulture;

                            // MessageBox.Show("hi" + this.ReadconfigIni().LanguageCode);
                        }
                    }
                    else
                    {
                        SelectedCulture = new CultureInfo("en");
                        if (SelectedCulture != null)
                        {

                            Thread.CurrentThread.CurrentUICulture = SelectedCulture;

                        }


                    }
                }
                else
                {
                    if ((formname != null) || (form != null) || (langcode != null))
                    {
                        SelectedCulture = new CultureInfo(langcode);

                        this.exlocalHandler.ReadLocaleFileAndTranslate2(langcode, formname, form);
                        

                    }
                }
            }
            catch (Exception e)
            {
                program.errorreport(e);

            }



        }
        public void Translate(string formname, Form form)
        {
            try
            {
                string langcode = this.ReadconfigXml().LanguageCode;
                if (this.ReadconfigXml().ExternalLanguageFileEnabled == false)
                {
                    if (langcode != null)
                    {
                        SelectedCulture = new CultureInfo(langcode);
                        //SelectedCulture = new CultureInfo("en");
                        if (SelectedCulture != null)
                        {

                            Thread.CurrentThread.CurrentUICulture = SelectedCulture;

                            // MessageBox.Show("hi" + this.ReadconfigIni().LanguageCode);
                        }
                    }
                    else
                    {
                        SelectedCulture = new CultureInfo("en");
                        if (SelectedCulture != null)
                        {

                            Thread.CurrentThread.CurrentUICulture = SelectedCulture;

                        }


                    }
                }
                else
                {
                    if ((formname != null) || (form != null) || (langcode != null))
                    {
                        SelectedCulture = new CultureInfo(langcode);

                        this.exlocalHandler.ReadLocaleFileAndTranslate2(langcode, formname,form );


                    }
                }
            }
            catch (Exception e)
            {
                program.errorreport(e);

            }



        }
        public static string GetVersion()
        {
            try
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();


            }

            catch (Exception e)
            {
                //hdBugger.TakeTheException2XmlLog(e, "LocaleHundler", LocaleHundlerCore.GetVersion());
                return null;
            }


        }
        
        
        
        
        
        }
    }

