using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeSenhasV2
{
    public partial class Form1 : Form
    {
        int num_senhas = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd_gerarSenhas_Click(object sender, EventArgs e)
        {
            //string de caracteres que irao ser utilizados para gerar a password
            string chars = "abcdefghijklmnopqrstuwxyz";

            /*
             * se a checkbox de maiusculas estiver selecionada entao a pass deverá entao conter maiusculas e minusculas
             * object que implica que os caracteres maiusculos sejam incluidos na string chars que é a string que funciona 
             * como biblioteca de caracteres que podem ser usados para gerar passwords
             */
            if (chkbox_maiusculas.Checked)
            {
                chars += "ABCDEFGHIJKLMNOPQRSTUWXYZ";
            }

            if (chkbox_simbolos.Checked)
            {
                chars += "+*-_:;?«»&%$#!|<>";
            }
            
            lst_senhas.Items.Clear(); //para que cada vez que clicar no botão gerar, todas as senhas geradas anteriormente serão eliminadas

            Random aleatorio = new Random();/*<---esta definição de aleatorio tem que ser feita fora do ciclo seguinte, caso contrario serão 
                                                  geradas sempre o mesmo conjunto de senhas */

            //ciclo que permite construir cada uma das senhas
            for (int n = 1; n <= num_senhas; n++)
            {
                /*
                 o stringbuilder abaixo vai permitir criar um objecto str ao qual vou poder acrescentar caracteres e esses 
                 caracteres vao ser acrescentados no ciclo for seguinte
                 */
                StringBuilder str = new StringBuilder();

                for (int x = 1; x <= num_Caracteres.Value; x++)
                {
                    //pos vai ficar com o numero da posição obtida pelo gerador de numeros aleatorios entre(limite minimo, limite maximo)
                    int pos = aleatorio.Next(0, chars.Length);
                    /*
                     * vai adicionar á string "str" o caracter que está na posição 'x' da string "chars"
                     * obs: sendo que é capturado um char e que é diferente de uma string, este elemento capturado tem que ser convertido 
                     * numa string atravez do ToString()
                     */
                    str.Append(chars[pos].ToString());
                }
                //é adicionada a nova senha á lista de senhas
                lst_senhas.Items.Add(str.ToString());

            }
        }
    }
}
