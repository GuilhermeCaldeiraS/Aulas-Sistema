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
    public partial class form_ps5 : Form
    {
        public form_ps5()
        {
            InitializeComponent();
            txt_ps5.Enabled=false;
            txt_ps5.Text = "Console de videogame da Sony, equipado com SSD de 825 GB, que proporciona carregamentos rápidos, gráficos de alta qualidade e uma experiência de jogo imersiva. É compatível com jogos da plataforma PlayStation 5 e oferece suporte a tecnologias modernas de áudio e vídeo.";
        }

        private void form_ps5_Load(object sender, EventArgs e)
        {
            
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
