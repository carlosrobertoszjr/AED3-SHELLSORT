using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace shellsort_project
{
    class ShellSort
    {
        public string[] shellSort(string[] stringArray)
        {
            int tamanho = stringArray.Length;

            //Gera h igual o tamanho do array divido por 2, e em cada laço divide o h por 2 novamente
            for (int h = tamanho / 2; h > 0; h /= 2)
            {
                for (int i = h; i < tamanho; i++)
                {
                    var valorAtual = stringArray[i];
                    var n = i;
                    //Verifica se o valor de comparação é menor ou maior (quando comparando uma string com outra retorna -1 ou 1 para menor e maior ) e se n é maior que h
                    //Troca a posição se for maior 
                    while (n >= h && stringArray[n - h].CompareTo(valorAtual) > 0)
                    {
                        stringArray[n] = stringArray[n - h];
                        n -= h;
                    }
                    stringArray[n] = valorAtual;
                }
            }
            return stringArray;
        }
    }
}
