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
           
        }
    }
}
