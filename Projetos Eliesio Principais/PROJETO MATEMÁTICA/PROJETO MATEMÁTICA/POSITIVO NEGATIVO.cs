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
    public partial class frm_positvo : Form
    {
        int numeroPNN; //Declarando a variavel que recebe numeros

        public frm_positvo()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_matematica matematica = new frm_matematica();
            matematica.Show();
            Hide();
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && ! (e.KeyChar == '-'))
            {
                e.Handled = true;
                MessageBox.Show("Só é permitido números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(e.KeyChar == 13)
            {
                if(txt_Numero.Text != " ")
                {
                    if(txt_Numero.Text !="")
                    {
                        numeroPNN = int.Parse (txt_Numero.Text);

                        if (numeroPNN == 0)
                        {
                            MessageBox.Show("O número digitado é Neutro!!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (numeroPNN >0)
                        {
                            MessageBox.Show("O número digitado é Positivo!!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O número digitado é Negativo!!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        txt_Numero.Clear();
                        txt_Numero.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Digite o Número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }
                }
            }
        }
    }
}
