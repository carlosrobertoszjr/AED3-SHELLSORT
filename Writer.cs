using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace shellsort_project
{
    class Writer
    {
        public void write(string[] stringArray)
        {
            try
            {

                StreamWriter sw = new StreamWriter("Dicionario.txt");

                for (int i = 0; i < stringArray.Length; i++)
                {
                    sw.WriteLine(stringArray[i]);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
