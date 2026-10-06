using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trocar_Forms
{
    public partial class frm_terceiro : Form
    {
        public frm_terceiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_primeiro primeiro = new frm_primeiro(); // INSTANCIAMENTO (CRIANDO UM OBJETO)
            primeiro.Show(); // CHAMANDO A NOVA TELA RENOMEADA
            Hide(); // ESCONDE A TELA QUANDO FECHADA
        }

        private void frm_terceiro_Load(object sender, EventArgs e)
        {

        }

        private void frm_terceiro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
