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
    public partial class frm_matematica : Form
    {
        public frm_matematica()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rad_dobro_CheckedChanged(object sender, EventArgs e)
        {
            frm_dobro dobro = new frm_dobro();
            dobro.Show();
            Hide();
        }

        private void rad_op_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_positivo_CheckedChanged(object sender, EventArgs e)
        {
            frm_positvo positivo = new frm_positvo();
            positivo.Show();
            Hide();
        }

        private void rad_positivoNN_CheckedChanged(object sender, EventArgs e)
        {
            frm_ant antecessor = new frm_ant();
            antecessor.Show();
            Hide();
        }

        private void rad_parimpar_CheckedChanged(object sender, EventArgs e)
        {
            frm_par parimpar = new frm_par();
            parimpar.Show();
            Hide();
        }

        private void frm_matematica_Load(object sender, EventArgs e)
        {

        }
    }
}
