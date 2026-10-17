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
    public partial class frm_memoria : Form
    {
        public frm_memoria()
        {
            InitializeComponent();
            txt_memoria.Enabled = false;
            txt_memoria.Text = "A memória RAM Rise Mode Z possui capacidade de 16 GB, utiliza o padrão DDR4 e opera com frequência nominal de 3200 MHz. Sua função é armazenar temporariamente os dados e as instruções utilizados pelo sistema operacional e pelos programas em execução, permitindo que o processador acesse essas informações rapidamente.\r\n\r\n";
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_promocoes inicio = new frm_promocoes();
            inicio.Show();
            this.Hide();
        }
    }
}
