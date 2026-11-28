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

        private void Chk_P2_CheckedChanged(object sender, EventArgs e)
        {

            calculadora = (decimal)50.00;
            e2 = 09;

            if (Chk_P2.Checked == true)
            {
                Chk_P2.Text = "calculadora";
                pic2.BackgroundImage = Properties.Resources.calculadora;
                List_Produtos.Items.Add("Calculadora");
                List_Compras.Items.Add("Calculadora");
                List_Precos.Items.Add(calculadora);
                Num_P2.Visible = true;
                Num_P2.Maximum = e2;
            }
            else
            {
                Chk_P2.Text = "calculadora";
                pic2.BackgroundImage = Properties.Resources.carrinho_png;
                List_Produtos.Items.Remove("Calculadora");
                List_Compras.Items.Remove("Calculadora");
                List_Precos.Items.Remove(calculadora);
                Num_P2.Visible = false;
                Num_P2.Maximum = 0;
            }
        }

        private void Chk_P3_CheckedChanged(object sender, EventArgs e)
        {

            camera = (decimal)3000.00;
            e3 = 07;

            if (Chk_P3.Checked == true)
            {
                Chk_P3.Text = "câmera";
                pic3.BackgroundImage = Properties.Resources.p1100_camera;
                List_Produtos.Items.Add("Nikon Compacta");
                List_Compras.Items.Add("Nikon Compacta");
                List_Precos.Items.Add(camera);
                Num_P3.Visible = true;
                Num_P3.Maximum = e3;
            }
            else
            {
                Chk_P3.Text = "câmera";
                pic3.BackgroundImage = Properties.Resources.carrinho_png;
                List_Produtos.Items.Remove("Nikon Compacta");
                List_Compras.Items.Remove("Nikon Compacta");
                List_Precos.Items.Remove(camera);
                Num_P3.Visible = true;
                Num_P3.Maximum = 0;
            }
        }

        private void Chk_P4_CheckedChanged(object sender, EventArgs e)
        {
            cd = (decimal)5.00;
            e4 = 65;

            if (Chk_P4.Checked == true)
            {
                Chk_P4.Text = "MaxPrint 700 MB";
                pic4.BackgroundImage = Properties.Resources.cd;
                List_Produtos.Items.Add("MaxPrint 700 MB");
                List_Compras.Items.Add("MaxPrint 700 MB");
                List_Precos.Items.Add(cd);
                Num_P4.Visible = true;
                Num_P4.Maximum = e4;
            }
            else
            {
                Chk_P4.Text = "MaxPrint 700 MB";
                pic4.BackgroundImage = Properties.Resources.carrinho_png;
                List_Produtos.Items.Remove("MaxPrint 700 MB");
                List_Compras.Items.Remove("MaxPrint 700 MB");
                List_Precos.Items.Remove(cd);
                Num_P4.Visible = true;
                Num_P4.Maximum = 0;
            }
        }

        private void Chk_P5_CheckedChanged(object sender, EventArgs e)
        {
            celular = (decimal)2500.00;
            e5 = 15;

            if (Chk_P5.Checked == true)
            {
                Chk_P5.Text = "64GB – iOS";
                pic5.BackgroundImage = Properties.Resources.iphone;
                List_Produtos.Items.Add("64GB – iOS");
                List_Compras.Items.Add("64GB – iOS");
                List_Precos.Items.Add(celular);
                Num_P5.Visible = true;
                Num_P5.Maximum = e5;
            }
            else
            {
                Chk_P5.Text = "64GB – iOS";
                pic5.BackgroundImage = Properties.Resources.carrinho_png;
                List_Produtos.Items.Remove("64GB – iOS");
                List_Compras.Items.Remove("64GB – iOS");
                List_Precos.Items.Remove(celular);
                Num_P5.Visible = true;
                Num_P5.Maximum = 0;
            }
        }

        private void Chk_P6_CheckedChanged(object sender, EventArgs e)
        {
            churrasqueira = (decimal)160.00;
            e6 = 08;

            if (Chk_P6.Checked == true)
            {
                Chk_P6.Text = "churrasqueira portaiil";
                pic6.BackgroundImage = Properties.Resources.churrasqueira;
                List_Produtos.Items.Add("churrasqueira");
                List_Compras.Items.Add("churrasqueira");
                List_Precos.Items.Add(churrasqueira);
                Num_P6.Visible = true;
                Num_P6.Maximum = e6;
            }
            else
            {
                Chk_P6.Text = "churrasqueira portaiil";
                pic6.BackgroundImage = Properties.Resources.carrinho_png;
                List_Produtos.Items.Remove("churrasqueira");
                List_Compras.Items.Remove("churrasqueira");
                List_Precos.Items.Remove(churrasqueira);
                Num_P6.Visible = true;
                Num_P6.Maximum = 0;
            }
        }

        private void Chk_P7_CheckedChanged(object sender, EventArgs e)
        {
            despertador = (decimal)50.00;
            e7 = 08;

            if (Chk_P7.Checked == true)
            {
                Chk_P7.Text = "Despertador";
                pic7.BackgroundImage = Properties.Resources.relogio;
                List_Produtos.Items.Add("Despertador");
                List_Compras.Items.Add("Despertador"); 
                List_Precos.Items.Add(despertador);
                Num_P7.Visible = true;
                Num_P7.Maximum = e6;
            }
            else
            {
                Chk_P7.Text = "Despertador";
                pic7.BackgroundImage = Properties.Resources.carrinho_png;
                List_Produtos.Items.Remove("Despertador");
                List_Compras.Items.Remove("Despertador");
                List_Precos.Items.Remove(despertador);
                Num_P7.Visible = true;
                Num_P7.Maximum = 0;
            }
        }

        private void Chk_P8_CheckedChanged(object sender, EventArgs e)
        {
            micro = (decimal)2000.00;
            e8 = 06;

            if (Chk_P8.Checked == true)
            {
                Chk_P8.Text = "Micro PC";
                pic8.BackgroundImage = Properties.Resources.mini_pc;
                List_Produtos.Items.Add("Micro PC");
                List_Compras.Items.Add("Micro PC");
                List_Precos.Items.Add(micro);
                Num_P8.Visible = true;
                Num_P8.Maximum = e6;
            }
            else
            {
                Chk_P8.Text = "Micro PC";
                pic8.BackgroundImage = Properties.Resources.carrinho_png;
                List_Produtos.Items.Remove("Micro PC");
                List_Compras.Items.Remove("Micro PC");
                List_Precos.Items.Remove(micro);
                Num_P8.Visible = true;
                Num_P8.Maximum = 0;
            }
        }

        private void Num_P1_ValueChanged(object sender, EventArgs e)
        {
            q1 = (decimal)Num_P1.Value;
            lbl_E1.Text = "Disponivel:" + (e1 - q1);
            total();
        }

        private void Num_P2_ValueChanged(object sender, EventArgs e)
        {
            q2 = (decimal)Num_P2.Value;
            lbl_E2.Text = "Disponivel:" + (e2 - q2);
            total();
        }

        private void Num_P3_ValueChanged(object sender, EventArgs e)
        {
            q3 = (decimal)Num_P3.Value;
            lbl_E3.Text = "Disponivel:" + (e3 - q3);
            total();
        }

        private void Num_P4_ValueChanged(object sender, EventArgs e)
        {
            q4 = (decimal)Num_P4.Value;
            lbl_E4.Text = "Disponivel:" + (e4 - q4);
            total();
        }

        private void Num_P5_ValueChanged(object sender, EventArgs e)
        {
            q5 = (decimal)Num_P5.Value;
            lbl_E5.Text = "Disponivel:" + (e5 - q5);
            total();
        }

        private void Num_P6_ValueChanged(object sender, EventArgs e)
        {
            q6 = (decimal)Num_P6.Value;
            lbl_E6.Text = "Disponivel:" + (e6 - q6);
            total();
        }

        private void Num_P7_ValueChanged(object sender, EventArgs e)
        {
            q7 = (decimal)Num_P7.Value;
            lbl_E7.Text = "Disponivel:" + (e7 - q7);
            total();
        }

        private void Num_P8_ValueChanged(object sender, EventArgs e)
        {
            q8 = (decimal)Num_P8.Value;
            lbl_E8.Text = "Disponivel:" + (e8 - q8);
            total();
        }

        private void lbl_total2_Click(object sender, EventArgs e)
        {

        }

        int e1, e2, e3, e4, e5, e6, e7, e8;
        decimal q1, q2, q3, q4, q5, q6, q7, q8;

        private void total()
        {
            lbl_total2.Text = ((bicicleta * q1) + (calculadora * q2) + (camera * q3) + (cd * q4) + (celular * q5) + (churrasqueira * q6) + (despertador * q7) + (micro * q8)).ToString();
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
            bicicleta = (decimal)500.00;
            e1 = 20;

            if (Chk_P1.Checked == true)
            {
                Chk_P1.Text = "bicicleta";
                pic1.BackgroundImage = Properties.Resources.caloi;
                List_Produtos.Items.Add("Bicicleta");
                List_Compras.Items.Add("Aro 26 Caloi");
                List_Precos.Items.Add(bicicleta);
                Num_P1.Visible = true;
                Num_P1.Maximum = e1;
            }
            else
            {
                Chk_P1.Text = "bicicleta";
                pic1.BackgroundImage = Properties.Resources.carrinho_png;
                List_Produtos.Items.Remove("Bicicleta");
                List_Compras.Items.Remove("Aro 26 Caloi");
                List_Precos.Items.Remove(bicicleta);
                Num_P1.Visible = true;
                Num_P1.Maximum = 0;
            }
        }
    }
}
