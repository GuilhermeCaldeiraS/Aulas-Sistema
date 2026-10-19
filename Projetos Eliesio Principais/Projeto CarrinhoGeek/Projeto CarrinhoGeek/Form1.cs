using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_CarrinhoGeek
{
    public partial class frm_promocoes : Form
    {
        public frm_promocoes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_finalizarP_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\DB\Desktop\Aulas-Sistema\Projetos Eliesio Principais\Projeto CarrinhoGeek\Projeto CarrinhoGeek\Pedidos\" +   "Pedido.txt", txt_carrinho.Text);
            
            txt_carrinho.Clear();
            
            MessageBox.Show("Pedido realizado", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pic_ps5_Click(object sender, EventArgs e)
        {

            //AppendText() adiciona o texto sem apagar o anterior.

            // Environment.NewLine faz a quebra de linha.

            //Multiline = True permite exibir os produtos em várias linhas.

            txt_carrinho.AppendText("PLAYSTATION 5 825GB - R$ 3.500,00"
            + Environment.NewLine);

        }

        private void btn_maisInfo_Click(object sender, EventArgs e)
        {
            form_ps5 ps5 = new form_ps5(); // INSTACIAMENTO (CRIANDO) UM OBJETO
            ps5.Show(); //CHAMANDO A NOVA TELA RENOMEADA SEGUNDO
            Hide(); // ESCONDE A TELA ATUAL
        }

        private void lbl_fonte_Click(object sender, EventArgs e)
        {

        }

        private void btn_maisInfo4_Click(object sender, EventArgs e)
        {

            frm_xpg xpg = new frm_xpg();
            xpg.Show();
            Hide();
        }

        private void pic_fonte_Click(object sender, EventArgs e)
        {

            //AppendText() adiciona o texto sem apagar o anterior.

            // Environment.NewLine faz a quebra de linha.

            //Multiline = True permite exibir os produtos em várias linhas.

            txt_carrinho.AppendText("FONTE XPG CORE 850W R$530,00"
            + Environment.NewLine);
        }

        private void btn_maisInfo2_Click(object sender, EventArgs e)
        {
            frm_havit havit = new frm_havit();
            havit.Show();
            Hide();
        }

        private void btn_maisInfo3_Click(object sender, EventArgs e)
        {
            frm_rx7600 rx7600 = new frm_rx7600();
            rx7600.Show();
            Hide();

        }

        private void btn_maisInfo5_Click(object sender, EventArgs e)
        {
            frm_memoria risemode = new frm_memoria();
            risemode.Show();
            Hide() ;
        }

        private void pic_headset_Click(object sender, EventArgs e)
        {
            //AppendText() adiciona o texto sem apagar o anterior.

            // Environment.NewLine faz a quebra de linha.

            //Multiline = True permite exibir os produtos em várias linhas.

            txt_carrinho.AppendText("HEADSET S/F HAVIT FUXI H3 R$190,00"
            + Environment.NewLine);
        }

        private void pic_7600_Click(object sender, EventArgs e)
        {
            txt_carrinho.AppendText("PLACA DE VIDEO RX7600 ASROCK CHALLENGER DUAL FAN R$1.900,00" + Environment.NewLine);
        }

        private void pic_memoriar_Click(object sender, EventArgs e)
        {
            txt_carrinho.AppendText("MEMÓRIA RAM RISE MODE 16GB 3200MHZ R$ 912,00" + Environment.NewLine);
        }
    }
}
