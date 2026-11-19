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

        private void frm_ant_Load(object sender, EventArgs e)
        {

        }

        private void txt_calc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_Sucessor_Click(object sender, EventArgs e)
        {

        }

        private void lbl_limpar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_sucessor_Click(object sender, EventArgs e)
        {

        }

        private void txt_calc2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_antecessor_Click(object sender, EventArgs e)
        {

        }

        private void pic_setaE_Click(object sender, EventArgs e)
        {

        }

        private void txt_Numero_TextChanged(object sender, EventArgs e)
        {
            if (txt_Numero.Text !="")
            {
                lbl_antecessor.Visible = true;
                lbl_Sucessor.Visible = true;
                btn_direita.Visible = true;
                btn_esqueda.Visible = true;
                btn_lixeira.Visible = true;
            }
            else
            {
                lbl_antecessor.Visible=false;
                lbl_Sucessor.Visible=false;
                btn_direita.Visible=false;
                btn_esqueda.Visible=false;
                btn_lixeira.Visible=false;
            }
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Só é permitido Números");
            }
            if (e.KeyChar ==13)
            {
                MessageBox.Show("Digite um Número");
            }
        }

        private void btn_esqueda_Click(object sender, EventArgs e)
        {

            numero = int.Parse(txt_Numero.Text);
            numero = numero + 1;
            lbl_Sucessor.Text = numero.ToString();
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            numero = int.Parse(txt_Numero.Text);
            numero = numero - 1;
            lbl_antecessor.Text = numero.ToString();
        }

        private void btn_lixeira_Click(object sender, EventArgs e)
        {
            txt_Numero.Clear();
            lbl_Sucessor.Text = "";
            lbl_antecessor.Text = "";
        }
    }    }
