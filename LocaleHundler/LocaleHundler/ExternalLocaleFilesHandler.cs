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
using System.Resources;
using System.Globalization;
using System.Diagnostics;

using Hydrobase;
using WareForms;

namespace LocaleHundler
{
    public class ExternalLocaleFilesHandler
    {
        hydrobaseADO ado = new hydrobaseADO();
        //  DataSetCollection setCol = new DataSetCollection();
        DataSet set = new DataSet();
        Maintenance_Backup backup = new Maintenance_Backup();
        public static string[] tags = { "name", "value" };

      
        public static string LocaleFolder;
        public const string localefoldername = "locale";
        public void FindMainLocaleFolder()
        {
            try
            {
                backup.CreateFolder(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + localefoldername);
                LocaleFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " ") + "\\" + localefoldername;



            }

            catch (Exception e)
            {

                program.errorreport(e);


            }
        }
        public string GetLocaleFolder(string langcode)
        {
            try
            {
                string ap = null;
                this.FindMainLocaleFolder();
                //  MessageBox.Show(LocaleFolder +"\n"+ langcode );
                if ((LocaleFolder != null) || (langcode != null))
                {
                    if (Directory.Exists(LocaleFolder + "\\" + langcode) == true)
                    {


                        ap = LocaleFolder + "\\" + langcode;
                    }


                }
                return ap;

            }
            catch (Exception e)
            {

                program.errorreport(e);

                return null;
            }


        }
        public void ReadLocaleFileAndTranslate(string langCode, string formname, WareForm form)
        {

            try
            {
                // string ap = null;
                string tlocalefolder;
                int i;

                this.FindMainLocaleFolder();
                if ((LocaleFolder != null) || (langCode != null) || (formname != null) || (form != null))
                {
                    tlocalefolder = this.GetLocaleFolder(langCode);
                    string filename = tlocalefolder + "\\" + formname + "." + LocaleHundlerCore.langfileext;
                    // MessageBox.Show("hi\n" + filename +"\n\n" + tlocalefolder );

                    if ((tlocalefolder != null) || (Directory.Exists(tlocalefolder) == true) || (File.Exists(filename) == true))
                    {

                        // string [] files=Directory.GetFiles(tlocalefolder);
                        ado.AttachDataBaseinDataSet(set, filename);
                        if ((set.Tables != null) || (set.Tables[0] != null))
                        {

                            DataTable table = set.Tables[0];


                            foreach (DataRow row in table.Rows)
                            {
                                object[] vals = row.ItemArray;
                                string objname = Convert.ToString(vals[0]).Substring(0, Convert.ToString(vals[0]).IndexOf("."));
                                if ((objname == formname) || (objname == "$this"))
                                {

                                    form.Text = Convert.ToString(vals[1]);


                                }
                                else
                                {
                                    //MessageBox.Show(Convert.ToString(vals[1]));
                                    Control.ControlCollection col = new Control.ControlCollection(form);
                                   if (form.Controls.ContainsKey(objname) == true)
                                       if (col != null)
                                   {
                                       // form.Controls[objname].Text = Convert.ToString(vals[1]);
                                       
                                       
                                       Control[] controls = col.Find(objname, true);
                                       if (col != null)
                                       {
                                           if((controls !=null ) ||(controls.Length>0))
                                           {
                                               for (i = 0; i < controls.Length; i++)
                                               {
                                                   if (controls[i].Name == objname)
                                                   {
                                                       controls[i].Text = Convert.ToString(vals[1]);


                                                   }
                                               }

                                           }

                                       }
                                      
                                       
                                    
                                    }



                                    else if (form.MainMenuStrip != null)
                                    {
                                        //if (form.MainMenuStrip.Items.ContainsKey(objname) == true)
                                        {
                                            ToolStripItem[] tollstrip = form.MainMenuStrip.Items.Find(objname, true);
                                            if ((tollstrip != null) || (tollstrip.Length > 0))
                                            {
                                                //int i;


                                                ToolStripItemCollection tolcol = new ToolStripItemCollection(form.MainMenuStrip, tollstrip);
                                                if ((tolcol != null) || (tolcol.ContainsKey(objname) == true) || (tolcol[objname] != null) || (Convert.ToString(vals[1]) != null))
                                                {
                                                    //MessageBox.Show(Convert.ToString(vals[1]) );
                                                    tolcol[objname].Text = Convert.ToString(vals[1]);
                                                }

                                                // form.MainMenuStrip.Items[objname].Text = Convert.ToString(vals[1]); 

                                            }
                                        }
                                    }
                                    else if (form.Menu != null)
                                    {
                                        // Menu [] men= form.Menu.MenuItems.Find(objname, true);
                                        Menu.MenuItemCollection mencol = new Menu.MenuItemCollection(form.Menu);
                                        mencol[objname].Text = Convert.ToString(vals[1]);

                                    }
                                   else if (form.DefaultTabControl != null)
                                    {

                                        if (form.DefaultTabControl.Controls.ContainsKey(objname) == true)
                                        {

                                            //Control.ControlCollection col = new Control.ControlCollection(form.DefaultTabControl);


                                            //  col[objname].Text  = Convert.ToString(vals[1]);

                                            if (form.DefaultTabControl.TabPages.ContainsKey(objname) == true)
                                            {
                                                form.DefaultTabControl.TabPages[objname].Text = Convert.ToString(vals[1]);


                                            }
                                           foreach (TabPage page in form.DefaultTabControl.TabPages)
                                             {
                                                 if ((page.Controls != null) || (page.Controls.Count > 0)  )
                                                 {
                                                    Panel tpanel = new Panel();

                                                    if (page.Controls.ContainsKey(objname) == true)
                                                    {
                                                        page.Controls[objname].Text = Convert.ToString(vals[1]);
                                                    }
                                                    /* foreach (Control panel in page.Controls)
                                                     {
                                                         if (panel.GetType().ToString() == tpanel.GetType().ToString())
                                                         {
                                                             if (panel.Controls.ContainsKey(objname) == true)
                                                             {
                                                                 panel.Controls[objname].Text  = Convert.ToString(vals[1]);

                                                             }
                                                         }


                                                     }*/


                                                    


                                                 }
                                         }
                                              

                                               
                                               
                                            
                                            
                                            



                                           



                                        }

                                    }
                                    else if (form.ExistedPanels!=null )
                                    {
                                        
                                        for (i = 0; i < form.ExistedPanels.Length; i++)
                                        {
                                            //MessageBox.Show("hi");
                                            foreach (Control cotr in form.ExistedPanels[i].Controls)
                                            {
                                                
                                                if (cotr.Name == objname)
                                                {
                                                    cotr.Text = Convert.ToString(vals[1]);

                                                }

                                            }
                                           

                                        }
                                        
                                    }
                                    else if (form.ExistedGroupBox != null)
                                    {
                                        for (i = 0; i < form.ExistedGroupBox.Length; i++)
                                        {
                                            foreach (Control cotr in form.ExistedGroupBox[i].Controls)
                                            {
                                                if (cotr.Name == objname)
                                                {
                                                    cotr.Text = Convert.ToString(vals[1]);

                                                }

                                            }

                                        }

                                    }
                                    else if (form.ExistedFlowLayoutPanel != null)
                                    {
                                        for (i = 0; i < form.ExistedFlowLayoutPanel.Length; i++)
                                        {
                                            foreach (Control cotr in form.ExistedFlowLayoutPanel[i].Controls)
                                            {
                                                if (cotr.Name == objname)
                                                {
                                                    cotr.Text = Convert.ToString(vals[1]);

                                                }

                                            }

                                        }

                                    }
                                    else if (form.ExistedSplitContainer != null)
                                    {
                                        for (i = 0; i < form.ExistedSplitContainer.Length; i++)
                                        {
                                            foreach (Control cotr in form.ExistedSplitContainer[i].Controls)
                                            {
                                                if (cotr.Name == objname)
                                                {
                                                    cotr.Text = Convert.ToString(vals[1]);

                                                }

                                            }

                                        }

                                    }
                                    else if (form.ExistedTableLayoutPanel != null)
                                    {
                                        for (i = 0; i < form.ExistedTableLayoutPanel.Length; i++)
                                        {
                                            foreach (Control cotr in form.ExistedTableLayoutPanel[i].Controls)
                                            {
                                                if (cotr.Name == objname)
                                                {
                                                    cotr.Text = Convert.ToString(vals[1]);

                                                }

                                            }

                                        }
                                        
                                    }
                                    
                                    
                                    





                                }



                            }
                            //ado.CloseDataBase(set);








                        }

                    }



                }
                //return ap;

            }
            catch (Exception e)
            {

                program.errorreport(e);

                //return null;
            }

        }
        public void ReadLocaleFileAndTranslate2(string langCode, string formname, WareForm form)
        {

            try
            {
                // string ap = null;
                string tlocalefolder;
                int i;

                this.FindMainLocaleFolder();
                if ((LocaleFolder != null) || (langCode != null) || (formname != null) || (form != null))
                {
                    tlocalefolder = this.GetLocaleFolder(langCode);
                    string filename = tlocalefolder + "\\" + formname + "." + LocaleHundlerCore.langfileext;
                    // MessageBox.Show("hi\n" + filename +"\n\n" + tlocalefolder );

                    if ((tlocalefolder != null) || (Directory.Exists(tlocalefolder) == true) || (File.Exists(filename) == true))
                    {
                       // Process.Start("RESGEN " + filename + "");
                        ResourceManager rsmanager = ResourceManager.CreateFileBasedResourceManager("resource", filename,null);
                        Thread.CurrentThread.CurrentUICulture = LocaleHundlerCore.SelectedCulture;

                        foreach (Control contr in form.Controls)
                        {
                            contr.Text = rsmanager.GetString(contr.Name + ".Text", new CultureInfo(langCode));


                        }
                       
                           








                        

                    }



                }
                //return ap;

            }
            catch (Exception e)
            {

                program.errorreport(e);

                //return null;
            }

        }

        public void ReadLocaleFileAndTranslate2(string langCode, string formname, Form form)
        {

            try
            {
                // string ap = null;
                string tlocalefolder;
                int i;

                this.FindMainLocaleFolder();
                if ((LocaleFolder != null) || (langCode != null) || (formname != null) || (form != null))
                {
                    tlocalefolder = this.GetLocaleFolder(langCode);
                    string filename = tlocalefolder + "\\" + formname + "." + LocaleHundlerCore.langfileext;
                    // MessageBox.Show("hi\n" + filename +"\n\n" + tlocalefolder );

                    if ((tlocalefolder != null) || (Directory.Exists(tlocalefolder) == true) || (File.Exists(filename) == true))
                    {
                        // Process.Start("RESGEN " + filename + "");
                        ResourceManager rsmanager = ResourceManager.CreateFileBasedResourceManager("resource", filename, null);
                        Thread.CurrentThread.CurrentUICulture = LocaleHundlerCore.SelectedCulture;

                        foreach (Control contr in form.Controls)
                        {
                            contr.Text = rsmanager.GetString(contr.Name + ".Text", new CultureInfo(langCode));


                        }












                    }



                }
                //return ap;

            }
            catch (Exception e)
            {

                program.errorreport(e);

                //return null;
            }

        }
       
    }
}

