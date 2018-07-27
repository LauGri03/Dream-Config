using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Config
{
   public static class InstalledLanguages
    {
        
        public static List<String> GetLanguages(){
            var languages = new List<string>();
            foreach (InputLanguage c in System.Windows.Forms.InputLanguage.InstalledInputLanguages)
            {
                languages.Add(c.Culture.Name);
            }

            return languages;
        }
    }
}
