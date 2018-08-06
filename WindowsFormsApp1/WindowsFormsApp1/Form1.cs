using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Maquina : Form
    {
        //estas duas variaveis irão ser usadas para guardar os valores das txtboxs
        double valor1;
        double valor2;

        public Form_Maquina()
        {
            InitializeComponent();
        }

    
        private void  Minha_operacao_click(object sender,  EventArgs e)
        {
            //defini-se o valor de valor1 e valor2
            valor1 = Double.Parse(txtb_val1.Text);
            valor2 = Double.Parse(txtb_val2.Text);
            /* ou
            * valor1 = Convert.ToInt32(txtb_val1.Text);
            * valor1 = Convert.ToInt32(txtb_val2.Text);
            */
            
            //abaixo uma forma de saber qual é o tipo de operação (vai buscar o texto do butao clicado) consoante o que estiver no "Text" de cada botao clicado
            string operacao = (sender as Button).Text;//<---"sender" é o parametro passado a FromMaquina_Load
            
            /*
                {0} - valor de txtb_val1
                {1} - sinal da peração a ser feita
                {2} - valor de txtb_val2    
                {3} - resultado da operação feita
            */
            lbl_resultado.Text = String.Format("{0} {1} {2} = {3}", valor1.ToString(), operacao, valor2.ToString(), calculo(operacao));

        }
 /*
        private void Form_Maquina_Load(object sender, EventArgs e)
        {
            //defini-se o valor de valor1 e valor2
            valor1 = Double.Parse(txtb_val1.Text);
            valor2 = Double.Parse(txtb_val2.Text);

 */

            //abaixo uma forma de saber qual é o tipo de operação (vai buscar o texto do butao clicado) consoante o que estiver no "Text" de cada botao clicado
//            string operacao = (sender as Button).Text;//<---"sender" é o parametro passado a FromMaquina_Load
            /*
             {0} - valor de txtb_val1
             {1} - sinal da peração a ser feita
             {2} - valor de txtb_val2
             {3} - resultado da operação feita
             */
 //           lbl_resultado.Text = String.Format("{0} {1} {2} = {3}", valor1.ToString(), operacao, valor2.ToString(),calculo(operacao));
 //       }
    
        private string calculo(string tipo)
        {
            double resultado = 0;

            switch (tipo)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "X":
                    resultado = valor1 * valor2;
                    break;
                case ":":
                    resultado = valor1 / valor2;
                    break;
            }

            return resultado.ToString();
        }
    }
}
