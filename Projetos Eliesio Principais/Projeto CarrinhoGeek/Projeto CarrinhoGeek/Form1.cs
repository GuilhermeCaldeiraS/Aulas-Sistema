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
            File.WriteAllText(@"C:\Users\DB\Desktop\Aulas-Sistema\Projetos Eliesio Principais\Projeto 
            CarrinhoGeek\Pedidos\Pedido 01" + ".txt" , txt_carrinho.Text);
            
            txt_carrinho.Clear();
            
            MessageBox.Show("Pedido realizado");
        }

        private void pic_ps5_Click(object sender, EventArgs e)
        {

        }

        private void btn_maisInfo_Click(object sender, EventArgs e)
        {
            form_ps5 ps5 = new form_ps5(); // INSTACIAMENTO (CRIANDO) UM OBJETO
            ps5.Show(); //CHAMANDO A NOVA TELA RENOMEADA SEGUNDO
            Hide(); // ESCONDE A TELA ATUAL
        }
    }
}
