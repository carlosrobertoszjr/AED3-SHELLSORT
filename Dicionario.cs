using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace shellsort_project
{
    //public var time;
    public partial class Form1 : Form
    {
        DicionarioCall dicionarioCall = new DicionarioCall();
        public string opcao = " ";
        Color colorRed = Color.Red;
        Color colorWhite = Color.White;
        public string resultado = " ";



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void teste_Click(object sender, EventArgs e)
        {

        }

        private void btGravar_Click(object sender, EventArgs e)

        {

        }

        private void teste_Click_1(object sender, EventArgs e)
        {

        }

        private void outputTempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btFinalizar_Click(object sender, EventArgs e)

        {

            if (inputPalavra.Text == null || inputPalavra.Text.Equals(""))
            {
                MessageBox.Show("Insira uma palavra!");
                return;
            }

            if (rbtnBubble.Checked || rbtnSsort.Checked)
            {


                if (rbtnBubble.Checked)
                {

                    opcao = "B";

                    //inputPalavra.BackColor = color;

                }
                else if (rbtnSsort.Checked)
                {

                    opcao = "S";
                    //inputPalavra.Text = V;
                }
                else
                {
                    //MessageBox.Show("olá");
                }

                string resultado = dicionarioCall.recordDicionario(inputPalavra.Text, opcao);
                if (resultado == "vermelho")
                {
                    inputPalavra.BackColor = colorRed;
                }
                else
                {

                    outputTempo.Text = resultado;
                    inputPalavra.BackColor = colorWhite;
                    MessageBox.Show("Palavra gravada com sucesso!");
                }



                //outputTempo. = tempo;
            }
            else
            {
                MessageBox.Show("É necessário selecionar um tipo de ordenação");
            }

        }

    }
}