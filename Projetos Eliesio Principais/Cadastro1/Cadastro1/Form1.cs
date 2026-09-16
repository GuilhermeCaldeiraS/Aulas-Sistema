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
    }
}
