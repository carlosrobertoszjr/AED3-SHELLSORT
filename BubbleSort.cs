using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace shellsort_project
{
    class BubbleSort
    {
        public string[] bubbleSort(string[] stringArray)
        {
            string temp;

            int l = stringArray.Length;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    if (stringArray[j].CompareTo(stringArray[j + 1]) > 0)
                    {
                        temp = stringArray[j];
                        stringArray[j] = stringArray[j + 1];
                        stringArray[j + 1] = temp;
                    }
                }
            }
            return stringArray;
        }

    }
}
