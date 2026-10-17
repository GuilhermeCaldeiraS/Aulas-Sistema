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
    public partial class frm_havit : Form
    {
        public frm_havit()
        {
            InitializeComponent();
            txt_havit.Enabled = false;
            txt_havit.Text = "O HAVIT Fuxi-H3 é um headset desenvolvido para o público gamer, com foco em conforto, qualidade sonora e comunicação durante as partidas. Por ser um modelo sem fio, proporciona maior liberdade de movimento e reduz a necessidade de cabos conectados diretamente ao dispositivo.\r\n";



        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
