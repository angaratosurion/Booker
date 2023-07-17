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
    public class ControlDB:CollectionBase 
    {
       
        List<Control.ControlCollection> List= new List<Control.ControlCollection>();
       public void Add(Control.ControlCollection col)
       {
           try
           {
               if (col != null)
               {

                   List.Add(col);
               }

           }
             catch (Exception e)
            {

                program.errorreport(e);


            }


       }
       public void AddRange (Control.ControlCollection [] col)
       {
           try
           {
               if (col != null)
               {

                   List.AddRange(col);
               }

           }
           catch (Exception e)
           {

               program.errorreport(e);


           }


       }
       public void Remove(Control.ControlCollection col)
       {

         
           try
           {
               if (col != null)
               {

                   List.Remove(col);
                              }
           }
             catch (Exception e)
            {

                program.errorreport(e);


            }


       }
        public Control.ControlCollection  GetItem(int index)
        {

           try
           {
                Control.ControlCollection ap = null;
               if (index >=0)
               {

                   ap= (Control.ControlCollection) List[index];
               }
               return ap;
           }
             catch (Exception e)
            {

                program.errorreport(e);

                 return null;
            }


       }
        /*public ControlDB RetutnColections()
        {
           
           try
           {
               return (List < Control.ControlCollection > )List;

           }
             catch (Exception e)
            {

                program.errorreport(e);
                 return null;

            }


       }
        */

        }

        

       
    }


