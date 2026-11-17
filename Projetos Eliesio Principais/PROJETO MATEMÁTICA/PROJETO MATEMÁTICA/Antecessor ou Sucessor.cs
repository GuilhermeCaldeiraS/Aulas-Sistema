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
    public partial class frm_ant : Form
    {

        int numero;

        public frm_ant()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_matematica matematica = new frm_matematica();
            matematica.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Numero_TextChanged(object sender, EventArgs e)
        {
            if (txt_Numero.Text != "")
            {
                lbl_ant.Visible = true;
                lbl_digiteumN.Visible = true;
                pic_Sucessor.Visible = true;
                pic_setaE.Visible = true;
                pic_Lixo.Visible = true;
            }
            else
            {
               lbl_antecessor.Visible=false;
               lbl_digiteumN.Visible = false;
               pic_setaE.Visible=false;
               pic_Lixo.Visible=false;
            }
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Só é permitido Números");
            }
            if (e.KeyChar ==13)
            {
                if(txt_Numero.Text =="")
                {
                    MessageBox.Show("Digite um Número");
                }
            }
        }

        private void pic_Sucessor_Click(object sender, EventArgs e)
        {
            numero = int.Parse(txt_Numero.Text);
            numero = numero + 1;
            lbl_sucessor.Text = numero.ToString();
        }

        private void pic_setaE_Click(object sender, EventArgs e)
        {
            numero = int.Parse((string)txt_Numero.Text);
            numero = numero - 1;
            lbl_ant.Text = numero.ToString();
        }

        private void pic_Lixo_Click(object sender, EventArgs e)
        {
            txt_Numero.Clear();
            txt_calc1.Text = "";
            txt_calc2.Text = "";
        }
    }
}
