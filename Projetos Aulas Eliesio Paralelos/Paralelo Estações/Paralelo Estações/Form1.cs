using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paralelo_Estações
{
    public partial class Frm_ParaleloEstações : Form
    {
        public Frm_ParaleloEstações()
        {
            InitializeComponent();
        }

        private void rad_Primeiro_CheckedChanged(object sender, EventArgs e)
        {
            pic_Primeiro.Image = Properties.Resources.gow; //buscando a imagem para a primeira opção no pic
            txt_Primeiro.Text = "God Of War Ragnarok"; // aqui estamos colocando um texto para aparecer apos clicar no button
        }

        private void txt_Primeiro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
