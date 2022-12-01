using shellsort_project.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace shellsort_project
{
    class Reader
    {
        static WordUtils wordUtils = new WordUtils();

        public List<string> reader()
        {
            string line;

            List<string> dictionary = new List<string>();
            try
            {

                    StreamReader sr = new StreamReader("Dicionario.txt");


                    line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line != "")
                        {
                            dictionary.Add(wordUtils.firstCharToUpperCase(line));
                        }
                        line = sr.ReadLine();

                    }
                    sr.Close();

                    return dictionary;

                
            }
            catch (IOException io)
            {
                throw new IOException();
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e.Message);
            }
        }


    }

}
