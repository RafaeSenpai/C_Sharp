using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soAlgarismosVSsoLetrasV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        /*
         * 1º primeira resolução e apenas para a txtbox dos algarismos
         * NOTA: Esta solução, quase funcional, não é a mais indicada pois não possibilita que a tecla backspace funcione,  que impossibilita a eliminação do conteudo 
         * das textbox. Apenas com recurso á tecla DEL é que é possivel eliminar o conteudo
         */

        /*
         * abaixo encontra-se um evento que contem dois paramatros. "sender" que é a identificação do proprio objeto, que neste
         * caso é a textBox ("txt_algarismos"); "e" que diz respeito a um consjunto de informações realacionadas com 
         * os eventos que vao acontecer;
        */

        /*
        private void txt_algarismos_KeyPress(object sender, KeyPressEventArgs e)
        {
            string chars = "0123456789";
            //keyChar: caracter que foi pressionado
            if (!chars.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            } 
        }
        */


        /*
         * ABAIXO A REOLUÇÃO MAIS INDICADA E COMPLETAMENTE FUNCIONAL E JÁ COM A VALIDAÇÃO DAS DUAS txtbox
         *
         * Abaixo encontra-se um evento que contem dois paramatros. 
         * - "sender" que é a identificação do proprio objeto, que neste caso é a textBox ("txt_algarismos"); 
         * - "e" que diz respeito a um consjunto de informações realacionadas com os eventos que vao acontecer;
         */

        /*
         * o metodo a baixo obtem-se selecionando o objeto em questão neste caso a textbox (txt_algarismos)e no menu evenos selecionar com duplo click 
         * a propriedade "keyPress"
         */
        private void txt_algarismos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //keyChar: caracter que foi pressionado
            { //se o caracter for diferente do controlo(BACKSPACE) e se o char for numero
                e.Handled = true; //Handled = manipulação; Neste caso, o evento de "inserção" é autorizado(true) 
            }
        }



        private void txt_letras_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && //caso não seja selecionado um backspace por exemplo
                !char.IsLetter(e.KeyChar) && //caso não seja uma letra
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}