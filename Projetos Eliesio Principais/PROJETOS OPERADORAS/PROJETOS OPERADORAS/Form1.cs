using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETOS_OPERADORAS
{
    public partial class frm_op : Form
    {
        public frm_op()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_Valor.Text = "R$100,00";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_Valor.Text = "R$45,00";
        }

        private void frm_op_Load(object sender, EventArgs e)
        {

        }

        private void btn_Recarga20_Click(object sender, EventArgs e)
        {
            txt_Valor.Text = "R$20,00";
        }

        private void btn_Recarga30_Click(object sender, EventArgs e)
        {
            txt_Valor.Text = "R$30,00";
        }

        private void btn_Recarga35_Click(object sender, EventArgs e)
        {
            txt_Valor.Text = "R$35,00";
        }

        private void btn_Recarga40_Click(object sender, EventArgs e)
        {
            txt_Valor.Text = "R$40,00";
        }

        private void btn_Recarga55_Click(object sender, EventArgs e)
        {
            txt_Valor.Text = "R$55,00";
        }

        private void btn_Recarga50_Click(object sender, EventArgs e)
        {
            txt_Valor.Text = "R$50,00";
        }

        private void rad_Vivo_CheckedChanged(object sender, EventArgs e)
        {
            txt_opSelec.Text = "VIVO";

            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled=true;
            lbl_dadosR.Enabled = true;
            lbl_DDD.Enabled = true;
            lbl_NumeroDoC.Enabled = true;
            lbl_operadoraS.Enabled = true;
            lbl_SelecioneoV.Enabled = true;
            lbl_ValorDaRec.Enabled = true;


            lbl_Validade.Enabled = true;
            lbl_Validade2.Enabled = true;
            lbl_Validade3.Enabled = true;
            lbl_Validade4.Enabled = true;
            lbl_Validade5.Enabled = true;
            lbl_Validade6.Enabled = true;
            lbl_Validade7.Enabled = true;
            lbl_Validade8.Enabled = true;


            txt_DDD.Enabled = true;
            txt_NumCell.Enabled = true;
            txt_opSelec.Enabled = false;
            txt_Valor.Enabled = false;
            txt_Nome.Enabled = true;

            btn_Recarga20.Enabled = true;
            btn_Recarga30.Enabled = true;
            btn_Recarga35.Enabled = true;
            btn_Recarga40.Enabled = true;
            btn_Recarga45.Enabled = true;
            btn_Recarga50.Enabled = true;
            btn_Recarga55.Enabled = true;
            btn_Recarga100.Enabled = true;



        }

        private void rad_Claro_CheckedChanged(object sender, EventArgs e)
        {

            txt_opSelec.Text = "CLARO";

            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled = true;
            lbl_dadosR.Enabled = true;
            lbl_DDD.Enabled = true;
            lbl_NumeroDoC.Enabled = true;
            lbl_operadoraS.Enabled = true;
            lbl_SelecioneoV.Enabled = true;
            lbl_ValorDaRec.Enabled = true;


            lbl_Validade.Enabled = true;
            lbl_Validade2.Enabled = true;
            lbl_Validade3.Enabled = true;
            lbl_Validade4.Enabled = true;
            lbl_Validade5.Enabled = true;
            lbl_Validade6.Enabled = true;
            lbl_Validade7.Enabled = true;
            lbl_Validade8.Enabled = true;


            txt_DDD.Enabled = true;
            txt_NumCell.Enabled = true;
            txt_opSelec.Enabled = false;
            txt_Valor.Enabled = false;
            txt_Nome.Enabled = true;

            btn_Recarga20.Enabled = true;
            btn_Recarga30.Enabled = true;
            btn_Recarga35.Enabled = true;
            btn_Recarga40.Enabled = true;
            btn_Recarga45.Enabled = true;
            btn_Recarga50.Enabled = true;
            btn_Recarga55.Enabled = true;
            btn_Recarga100.Enabled = true;

        }

        private void rad_Tim_CheckedChanged(object sender, EventArgs e)
        {
            txt_opSelec.Text = "TIM";

            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled = true;
            lbl_dadosR.Enabled = true;
            lbl_DDD.Enabled = true;
            lbl_NumeroDoC.Enabled = true;
            lbl_operadoraS.Enabled = true;
            lbl_SelecioneoV.Enabled = true;
            lbl_ValorDaRec.Enabled = true;


            lbl_Validade.Enabled = true;
            lbl_Validade2.Enabled = true;
            lbl_Validade3.Enabled = true;
            lbl_Validade4.Enabled = true;
            lbl_Validade5.Enabled = true;
            lbl_Validade6.Enabled = true;
            lbl_Validade7.Enabled = true;
            lbl_Validade8.Enabled = true;


            txt_DDD.Enabled = true;
            txt_NumCell.Enabled = true;
            txt_opSelec.Enabled = false;
            txt_Valor.Enabled = false;
            txt_Nome.Enabled = true;

            btn_Recarga20.Enabled = true;
            btn_Recarga30.Enabled = true;
            btn_Recarga35.Enabled = true;
            btn_Recarga40.Enabled = true;
            btn_Recarga45.Enabled = true;
            btn_Recarga50.Enabled = true;
            btn_Recarga55.Enabled = true;
            btn_Recarga100.Enabled = true;

        }

        private void rad_Oi_CheckedChanged(object sender, EventArgs e)
        {

            txt_opSelec.Text = "OI";
            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled = true;
            lbl_dadosR.Enabled = true;
            lbl_DDD.Enabled = true;
            lbl_NumeroDoC.Enabled = true;
            lbl_operadoraS.Enabled = true;
            lbl_SelecioneoV.Enabled = true;
            lbl_ValorDaRec.Enabled = true;


            lbl_Validade.Enabled = true;
            lbl_Validade2.Enabled = true;
            lbl_Validade3.Enabled = true;
            lbl_Validade4.Enabled = true;
            lbl_Validade5.Enabled = true;
            lbl_Validade6.Enabled = true;
            lbl_Validade7.Enabled = true;
            lbl_Validade8.Enabled = true;


            txt_DDD.Enabled = true;
            txt_NumCell.Enabled = true;
            txt_opSelec.Enabled = false;
            txt_Valor.Enabled = false;
            txt_Nome.Enabled = true;

            btn_Recarga20.Enabled = true;
            btn_Recarga30.Enabled = true;
            btn_Recarga35.Enabled = true;
            btn_Recarga40.Enabled = true;
            btn_Recarga45.Enabled = true;
            btn_Recarga50.Enabled = true;
            btn_Recarga55.Enabled = true;
            btn_Recarga100.Enabled = true;

        }

        private void txt_Valor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_opSelec_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_telefone_Click(object sender, EventArgs e)
        {
            
        }
    }
}
