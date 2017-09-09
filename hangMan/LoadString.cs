using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangMan
{
    static class LoadString
    {
        private static String[] word;
        public static String[] loadFile(String path)
        {
            try
            {
                word = File.ReadAllLines(path);
            }
            catch (FileNotFoundException)
            {
                return new String[] { "File not found" };
            }
            return word;
        }

    }
}