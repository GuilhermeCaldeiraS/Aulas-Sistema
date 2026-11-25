using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_de_Itens
{
    public partial class frm_loja : Form
    {

        decimal bicicleta, calculadora, camera, cd, celular, churrasqueira, despertador, micro;
        int e1, e2, e3, e4, e5, e6, e7, e8;
        decimal q1, q2, q3, q4, q5, q6, q7, q8;

        private void total()
        {
            
        }


        public frm_loja()
        {
            InitializeComponent();
        }

        private void frm_loja_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" SEJAM BEM VINDOS A LOJA DAS VARIEADAES !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Chk_P1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
