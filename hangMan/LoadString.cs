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
        private static String[] a_words; //List of all the words acquired from the file.

        /// <summary>
        /// This method returns all the words from the text file situated at the path passed by parameter.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static String[] loadFile(String path)
        {
            try
            {
                a_words = File.ReadAllLines(path);
            }
            catch (FileNotFoundException)
            {
                return new String[] { "File not found" };
            }
            return a_words;
        }

    }
}