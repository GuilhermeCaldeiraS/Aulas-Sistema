using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensagem_em_C_
{
    public partial class frm_mensagem : Form
    {
        public frm_mensagem()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_simounao_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show ("VAMOS ESTUDAR C#?" , "SOU O TITULO DA MENSAGEM" , MessageBoxButtons.YesNo);

            if(retorno == DialogResult.Yes)
            {
                MessageBox.Show("CLICOU EM SIM");
            }

            else if (retorno == DialogResult.No)
            {
                MessageBox.Show("CLICOU EM NÃO");
            }
               
        }
    }
}
