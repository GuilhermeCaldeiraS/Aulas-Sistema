using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_CarrinhoGeek
{
    public partial class frm_xpg : Form
    {
        public frm_xpg()
        {
            InitializeComponent();
            txt_xpgcore.Enabled = false;
            txt_xpgcore.Text = "A XPG Core Reactor II VE de 850 W é uma fonte de alimentação desenvolvida para fornecer energia aos componentes de computadores de médio e alto desempenho. Sua potência permite atender a configurações com processadores modernos, placas de vídeo dedicadas, unidades de armazenamento e outros componentes internos.";
        }

        private void txt_xpgcore_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_promocoes inicio = new frm_promocoes();
            inicio.Show();
            this.Hide();
        }
    }
}
