using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shellsort_project.Utils;

namespace shellsort_project
{
    internal class DicionarioCall
    {
        static BubbleSort bubbleSort = new BubbleSort();

        static ShellSort shellSort = new ShellSort();

        static Reader arquivoReader = new Reader();

        static Writer arquivoWriter = new Writer();

        static WordUtils wordUtils = new WordUtils();
        public string recordDicionario(string word, string opcao)
        {

            //Inicializa variável para contar o tempo
            var tempo = new Stopwatch();

            List<string> dictionary = new List<string>();

            try
            {
                //Ler o arquivo e transforma em uma lista
                dictionary = arquivoReader.reader();
            }
            catch(IOException io)
            {
                StreamWriter sw = new StreamWriter("Dicionario.txt");

            }
            //Instancia uma lista para guardar em memória o que o usuário está colocando no dicionario
            List<string> dictionaryPlaceHolder = new List<string>();

            //Transforma o dicionario em array
            string[] words = stringListToStringArray(dictionary);

            string[] wordsPlaceHolder;

            //Coloca a primeira letra da palavra em upper case
            word = wordUtils.firstCharToUpperCase(word);


            //Verifica se existe a palavra tanto no arquivo quanto na lista em memória
            bool containsInDictionaryArchive = dictionary.Exists(x => x.Equals(word));

            bool containsInDictionaryHolder = dictionaryPlaceHolder.Exists(x => x.Equals(word));

            //Valida se Contém a palavra
            if (containsInDictionaryArchive || containsInDictionaryHolder)
            {
                MessageBox.Show("Palavra já existe");
                return "vermelho";
            }
            else
            {

                //Algoritmo para adicionar uma palavra no vetor, faz uma nova instância de um vetor com o tamanho do vetor antigo + 1 e faz a palavra digitada ir para 
                //a próxima posição do vetor, também adiciona no diciónario em memória 
                if (words.Length == 0)
                {
                    words = new string[1];

                    words[0] = word;
                }
                else
                {
                    wordsPlaceHolder = new string[words.Length];
                    for (int i = 0; i < words.Length; i++)
                    {

                        wordsPlaceHolder[i] = words[i];
                    }
                    words = new string[words.Length + 1];
                    for (int i = 0; i < wordsPlaceHolder.Length; i++)
                    {
                        words[i] = wordsPlaceHolder[i];
                    }
                    words[words.Length - 1] = word;

                }
                dictionaryPlaceHolder.Add(word);

                Console.WriteLine("Palavra Adicionada");

            }

            //Começa o tempo para ordena~r as palavras e escrever no dicionario
            //Realiza as funções de ordenação, dependendo da opção escolhida ira utilizar um algoritmo diferente
            if (opcao == "B")
            {
                tempo.Start();
                string[] bubbleSortArray = bubbleSort.bubbleSort(words);
                tempo.Stop();
                arquivoWriter.write(bubbleSortArray);

            }
            else if (opcao == "S")
            {
                tempo.Start();
                string[] shellSortArray = shellSort.shellSort(words);
                tempo.Stop();
                arquivoWriter.write(shellSortArray);

            }

            string tempoTotal = "";

            //MessageBox.Show(tempo.Elapsed);
            //int tempoContado = tempo.Elapsed.Milliseconds;
            if (tempo.Elapsed.Milliseconds.ToString().Length == 1) {
                tempoTotal = tempo.Elapsed.Minutes.ToString() + ":" + tempo.Elapsed.Seconds.ToString() + ":00" + tempo.Elapsed.Milliseconds.ToString();
            } else if (tempo.Elapsed.Milliseconds.ToString().Length == 2) {
                tempoTotal = tempo.Elapsed.Minutes.ToString() + ":" + tempo.Elapsed.Seconds.ToString() + ":0" + tempo.Elapsed.Milliseconds.ToString();
            } else {
                tempoTotal = tempo.Elapsed.Minutes.ToString() + ":" + tempo.Elapsed.Seconds.ToString() + ":" + tempo.Elapsed.Milliseconds.ToString();
            }
            //Console.WriteLine(tempoTotal);
            tempoTotal = tempo.Elapsed.ToString();
            return tempoTotal;
        }
        //Função para converter list para array
        public static string[] stringListToStringArray(List<string> dictionaryArchive)
        {
            string[] words = new string[dictionaryArchive.Count];

            int i = 0;

            foreach (string word in dictionaryArchive)
            {
                words[i] = word;

                i++;
            }
            return words;
        }
    }
}

