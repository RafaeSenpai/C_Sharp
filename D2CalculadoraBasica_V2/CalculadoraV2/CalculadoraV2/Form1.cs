using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraV2
{
    public partial class Form1 : Form
    {
        double valor_1;
        double valor_2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void operacao_click(object sender, EventArgs e)
        {
            //defini-se o valor de valor1 e valor2
            valor_1 = Double.Parse(txtb_val1.Text);
            valor_2 = Double.Parse(txtb_val2.Text);
            /* ou
            * valor1 = Convert.ToInt32(txtb_val1.Text);
            * valor1 = Convert.ToInt32(txtb_val2.Text);
            */

            //abaixo uma forma de saber qual é o tipo de operação (vai buscar o texto do butao clicado) consoante o que estiver no "Text" de cada botao clicado
            string operacao = (sender as Button).Text;//<---"sender" é o parametro passado a FromMaquina_Load


            //abaixo uma forma de saber qual é o tipo de operação (vai buscar o texto do butao clicado) consoante o que estiver no "Text" de cada botao clicado
            //            string operacao = (sender as Button).Text;//<---"sender" é o parametro passado a FromMaquina_Load
            /*
             {0} - valor de txtb_val1
             {1} - sinal da peração a ser feita
             {2} - valor de txtb_val2
             {3} - resultado da operação feita
             */
            lbl_resultado.Text = String.Format("{0} {1} {2} = {3}", valor_1.ToString(), operacao, valor_2.ToString(),calculo(operacao));
        }

        //O metodo a baixo vai ler o tipo de operação a fazer, i é, ler o caracter do botao clicado(propriedade "Text" de cada botao, e consoante o carater lido fazer entao a operação pretendida pelo utilizador
        private string calculo(string tipo)
        {
            double resultado = 0;

            switch (tipo)
            {
                case "+":
                    resultado = valor_1 + valor_2;
                    break;
                case "-":
                    resultado = valor_1 - valor_2;
                    break;
                case "X":
                    resultado = valor_1 * valor_2;
                    break;
                case ":":
                    resultado = valor_1 / valor_2;
                    break;
            }

            return resultado.ToString();
        }
    }
}
