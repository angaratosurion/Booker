using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;



using Hydrobase;
using HydrobaseSDK;
using WareForms;
using Booker;

using System.Windows.Forms;

namespace Booker.White_Tiger_Client
{
    public class WTClientCore
      {
        
         
         WhiteTigerCleint cl = new WhiteTigerCleint();
         ToolStripMenuItem conencttoWhitetiger = new ToolStripMenuItem();
         BookerMain Activewin;
         void menuitemclick(object o, EventArgs arg)
         {
             //cl.Load(program.Activewin);
             /*program.Activewin.WTbtnUpdate.Click += new EventHandler(//cl.Update);
             program.Activewin.WTbtnBackup.Click += new EventHandler(//cl.Backup);
             program.Activewin.WTbtnImportTable.Click += new EventHandler(//cl.ImportTable);*/
             program.Activewin.Text += WhiteTigerCleint.client.GetVersion();

         }
          public  void MakeAction(BookerMain  tForm)
          {
              try
              {
                  if (Activewin == null)
                  {


                      Activewin = tForm;
                  }
                  //cl.Load((BookerMain)tForm);
                  /*Activewin.WTbtnUpdate.Click += new EventHandler(//cl.Update);
                  Activewin.WTbtnBackup.Click += new EventHandler(//cl.Backup);
                  Activewin.WTbtnImportTable.Click += new EventHandler(//cl.ImportTable);*/
                  Activewin.Text += WhiteTigerCleint.client.GetVersion();
                  this.conencttoWhitetiger.Text = "Connect to White tiger Server";
                  this.conencttoWhitetiger.Click += new EventHandler(this.menuitemclick);
                  Activewin.additionalCommansToolStripMenuItem.DropDownItems.Add(this.conencttoWhitetiger);
                  // tForm.additionalCommansToolStripMenuItem.DropDownItems.Add(this.conencttoWhitetiger);
              }
              catch (Exception ex)
              {

                  program.errorreport(ex);
              }
            
            
           
    
          }
          
      }
  }

