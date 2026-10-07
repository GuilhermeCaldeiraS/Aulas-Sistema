using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Adição
{
    public partial class frm_calculadora : Form
    {
        public frm_calculadora()
        {
            InitializeComponent();
        }

        private void txt_primeiroN_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToInt32(txt_primeiroN.Text); // Double convertendo para numeros com casas decimais
            double valor2 = Convert.ToInt32(txt_segundoN.Text); // Double convertendo para numeros com casas decimais (

            double resultado = valor1 + valor2; // convertendo resultado (Numeros quebrados)
            MessageBox.Show(resultado.ToString()); // metodo ToString converte o valor Numeros em letras
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_primeiroN.Clear();
            txt_segundoN.Clear();
        }

        private void btn_subtração_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToInt32(txt_primeiroN.Text); // Double convertendo para numeros com casas decimais
            double valor2 = Convert.ToInt32(txt_segundoN.Text); // Double convertendo para numeros com casas decimais (

            double resultado = valor1 - valor2; // convertendo resultado (Numeros quebrados)
            MessageBox.Show(resultado.ToString()); // metodo ToString converte o valor Numeros em letras
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToInt32(txt_primeiroN.Text); // Double convertendo para numeros com casas decimais
            double valor2 = Convert.ToInt32(txt_segundoN.Text); // Double convertendo para numeros com casas decimais (

            double resultado = valor1 / valor2; // convertendo resultado (Numeros quebrados)
            MessageBox.Show(resultado.ToString()); // metodo ToString converte o valor Numeros em letras
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToInt32(txt_primeiroN.Text); // Double convertendo para numeros com casas decimais
            double valor2 = Convert.ToInt32(txt_segundoN.Text); // Double convertendo para numeros com casas decimais (

            double resultado = valor1 * valor2; // convertendo resultado (Numeros quebrados)
            MessageBox.Show(resultado.ToString()); // metodo ToString converte o valor Numeros em letras
        }
    }
}
