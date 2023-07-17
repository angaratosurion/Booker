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
using HydroBugger;



namespace Booker
{
    public class LocaleHundler 
    {
        public static CultureInfo   SelectedCulture=null;
        HydroBugger.HydroBugger hdBugger = new HydroBugger.HydroBugger();
        public const string configfile="config.ini";
        public const string langtag = "lang=";
        public LocaleHundler()
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
            
        
        public string  ReadconfigIni()
        {
            try
            {
                string command, value = null;
                //System.Windows.Forms.MessageBox.Show(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + configfile );
                StreamReader strmRead = new StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\"+configfile,Encoding.UTF8 );
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
                strmRead.Dispose();
                return value;

            }
            catch (Exception e)
            {
                this.hdBugger.TakeTheException2(e, Application.ProductName, Application.ProductVersion);
                return null;
            }


        }

        public void SaveLangconfigIni(string langcode)
        {
            try
            {


                if (langcode != null)
                {
                    StreamWriter writer = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + configfile);
                    writer.WriteLine(langtag + langcode);
                    writer.Flush();
                    writer.Close();
                }


            }
            catch (Exception e)
            {

                hdBugger.TakeTheException2(e, Application.ProductName, Application.ProductVersion);


            }



        }
        
        public void Translate()
            {
                try
                {
                    SelectedCulture = new CultureInfo(this.ReadconfigIni());
                    //SelectedCulture = new CultureInfo("en");
                    //if (SelectedCulture != null)
                    {
                        
                        Thread.CurrentThread.CurrentUICulture = SelectedCulture; 

                    }
                }
                catch (Exception e)
                {
                    hdBugger.TakeTheException2(e, Application.ProductName, Application.ProductVersion);

                }



            }
        
        
        
        
        
        }
    }

