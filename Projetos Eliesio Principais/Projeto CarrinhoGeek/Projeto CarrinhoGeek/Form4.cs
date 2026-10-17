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
    public partial class frm_rx7600 : Form
    {
        public frm_rx7600()
        {
            InitializeComponent();
            txt_rx7600.Enabled = false;
            txt_rx7600.Text = "A ASRock Radeon RX 7600 Challenger é uma placa de vídeo dedicada baseada na arquitetura AMD RDNA 3, desenvolvida principalmente para jogos em resolução Full HD (1920 × 1080). Ela possui processamento gráfico próprio, permitindo executar jogos e aplicações visuais com desempenho superior ao de muitas soluções gráficas integradas.\r\n";
        }

        private void txt_ps5_TextChanged(object sender, EventArgs e)
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
