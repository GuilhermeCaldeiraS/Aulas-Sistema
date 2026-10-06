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
    public partial class frm_primeiro : Form
    {
        public frm_primeiro()
        {
            InitializeComponent();
        }

        private void tela2_Click(object sender, EventArgs e)
        {
           frm_segundo segundo = new frm_segundo(); // INSTANCIAMENTO (CRIANDO UM OBJETO)
            segundo.Show(); // CHAMANDO A NOVA TELA RENOMEADA
            Hide(); // ESCONDE A TELA QUANDO FECHADA
        }

        private void frm_primeiro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
