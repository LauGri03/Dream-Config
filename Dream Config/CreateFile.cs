using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream_Config
{
    public static class CreateFile
    {
        private static string path = @"c:\DreamConfig\";

        public static void Create(string appName,int sound,string language)
        {
            using (StreamWriter sw = File.CreateText(path + appName + ".txt"))
            {
                sw.WriteLine(sound);
                sw.WriteLine(language);
            }
        }

        public static void Create(string appName,int sound,int luminosity,string language)
        {
            using (StreamWriter sw = File.CreateText(path + appName + ".txt"))
            {
                sw.WriteLine(sound);
                sw.WriteLine(luminosity);
                sw.WriteLine(language);
            }
        }
    }
}
