using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro1
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void Rad_tema1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Imagen_2;
        }

        private void Rad_tema2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.imagem4;
        }

        private void Rad_Tema3_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.imagen6;
        }

        private void Grp_Temas_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Ativar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Nome_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Txt_nome.Text; // faz o botão nome receber o texto que será escrito no campo de nome. 
        }

        private void Btn_Sobrenome_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Txt_Sobrenome.Text; // faz o botão sobrenome receber o texto que será escrito no campo de sobrenome.
        }
    }
}
