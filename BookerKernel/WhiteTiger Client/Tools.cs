using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

using Booker;


using Hydrobase;
using HydrobaseSDK;
namespace Booker.WhiteTiger_Client
{
    public class Tools
    {
        public void  ReplaceNulls( DataRow row)
        {
            try
            {
              //  DataRow ap = null;
                if (row != null)
                {

                    int i = 0;
                    object[] vals = row.ItemArray;
                    for (i = 0; i < vals.Length; i++)
                    {
                        if ((vals[i] == null) || (Convert.ToString(vals[i]) == String.Empty))
                        {


                            vals[i] = BaseClass.emptycellChar;
                        }

                    }
                    row.ItemArray = vals;

                }


            }
            catch (Exception ex)
            {

                program.errorreport(ex);

            }



        }
   
    }
}
