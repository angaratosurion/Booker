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

//using Ini;

namespace LocaleHundler
{
   public  class LocaleSettings
   {
       string langcode;
       bool  Enexternlangfile;
       public string LanguageCode
       {

           set { langcode = value; }
           get { return langcode; }

       }
       public bool ExternalLanguageFileEnabled
       {
           set { Enexternlangfile = value; }
           get { return Enexternlangfile; }

       }
    }
}
