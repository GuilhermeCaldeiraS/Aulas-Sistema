using System;
using System.Windows.Forms;

namespace PROJETO_MATEMÁTICA
{
    public partial class frm_dobro : Form
    {
        int numerodobro; // CRIANDO A VARIAVEL (GUARDAR INFORMAÇÃO)


        public frm_dobro()
        {
            InitializeComponent();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            frm_matematica matematica = new frm_matematica();
            matematica.Show();
            Hide();
        }

        private void txt_valorN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) // criando Condição para aceitar Somente Numeros
            {
                e.Handled = true; // Verificando e confirmando se a informação pressionada foi numero
                MessageBox.Show("Só é permitido números!!!" , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13) //Condição se a tecla ENTER foi pressionda
            {
                if (txt_valorN.Text != "") //Condição para verificar se foi Digitado um numero
                {
                    numerodobro = int.Parse(txt_valorN.Text);// A variavel está recebendo o numero que foi digitado e convertido
                    numerodobro = numerodobro * 2; //Cálculo do Dobro
                    MessageBox.Show("O Dobro é: " + numerodobro, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_valorN.Clear();// Limpando o Numero que foi digitado
                    txt_valorN.Focus(); // deixar o cursor para digitar o proximo numero.
                }
                else // se não for digitado nada - Inverso de IF (Condição verdadeira)
                {
                    MessageBox.Show("Digite um Número! ! ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
