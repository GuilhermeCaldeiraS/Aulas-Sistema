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
    public partial class frm_segundo : Form
    {
        public frm_segundo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_terceiro terceiro = new frm_terceiro(); // INSTANCIAMENTO (CRIANDO UM OBJETO)
            terceiro.Show(); // CHAMANDO A NOVA TELA RENOMEADA
            Hide(); // ESCONDE A TELA QUANDO FECHADA
        }

        private void frm_segundo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
