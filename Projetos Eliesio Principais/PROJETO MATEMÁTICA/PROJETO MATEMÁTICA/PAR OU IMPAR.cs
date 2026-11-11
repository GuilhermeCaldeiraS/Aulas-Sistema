using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_MATEMÁTICA
{
    public partial class frm_par : Form
    {
        int numeroparimpar;


        public frm_par()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_matematica matematica = new frm_matematica();
            matematica.Show();
            Hide();
        }

        private void frm_par_Load(object sender, EventArgs e)
        {

        }

        private void txt_numeroPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) // Condição para aceitar somente numeros
            {
                e.Handled = true; // verifica e confirma se a telca pressionada é ou não um numero
                MessageBox.Show("Só é permitido numeros!!!" , "Aviso" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyChar ==13) // Condição para habilitar a tecla ENTER
            {
                if(txt_numeroPI.Text != "") //Condição para verificar se tem numero digitado
                {
                    numeroparimpar = int.Parse(txt_numeroPI.Text); // variavel esta rescrevendo a convercao

                    if(numeroparimpar %2 ==0) //Condição para saber se o numero digitado é par ou nao
                    {
                        MessageBox.Show("O numero é par!!!!" , "Resultado" , MessageBoxButtons.OK, MessageBoxIcon.Information );
                    }
                    else // Caso contrario  -SENÃO o número é impar
                    {
                        MessageBox.Show("O número é impar", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txt_numeroPI.Clear();
                    txt_numeroPI.Focus();
                }
                else // Caso não tenha nenhum número digitado
                {
                    MessageBox.Show("Digite o Número!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }
    }
}
