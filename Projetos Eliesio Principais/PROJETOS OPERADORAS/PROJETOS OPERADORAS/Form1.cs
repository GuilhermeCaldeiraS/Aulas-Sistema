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
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void frm_op_Load(object sender, EventArgs e)
        {

        }

        private void btn_Recarga20_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Recarga30_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Recarga35_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Recarga40_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Recarga55_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Recarga50_Click(object sender, EventArgs e)
        {
           
        }

        private void rad_Vivo_CheckedChanged(object sender, EventArgs e)
        {



            //formatação cor
            lbl_BemVindo.ForeColor = Color.White;
            lbl_Nome.ForeColor = Color.White;
            grp_op.ForeColor = Color.White;
            lbl_operadoraS.ForeColor = Color.White;
            lbl_DDD.ForeColor = Color.White;
            lbl_NumeroDoC.ForeColor = Color.White;
            lbl_SelecioneoV.ForeColor = Color.White;
            lbl_Validade.ForeColor = Color.White;
            lbl_Validade2.ForeColor = Color.White;
            lbl_Validade3.ForeColor = Color.White;
            lbl_Validade4.ForeColor = Color.White;
            lbl_Validade5.ForeColor = Color.White;
            lbl_Validade6.ForeColor = Color.White;
            lbl_Validade7.ForeColor = Color.White;
            lbl_Validade8.ForeColor = Color.White;
            lbl_ValorDaRec.ForeColor = Color.White;

            
            btn_1.Text = "12 REAIS";
            lbl_Validade.Text = "30 DIAS";

            btn_2.Text = "15 REAIS";
            lbl_Validade2.Text = "30 DIAS";


            btn_3.Text = "20 REAIS";
            lbl_Validade3.Text = "30 DIAS";

            btn_4.Text = "30 REAIS";
            lbl_Validade4.Text = "30 DIAS";

            btn_5.Text = "35 REAIS";
            lbl_Validade5.Text = "90 DIAS";

            btn_6.Text = "40 REAIS";
            lbl_Validade6.Text = "90 DIAS";

            btn_7.Text = "100 REAIS";
            lbl_Validade7.Text = "180 DIAS";

            btn_8.Text = "200 REAIS";
            lbl_Validade8.Text = "365 DIAS";




            BackColor = Color.Purple;

            pic_telefone.Image = Properties.Resources.vivo;


            //atribuição
            txt_opSelec.Text = "VIVO";
            txt_Valor.Text = btn_1.Text;
            txt_Valor.Text = btn_2.Text;

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

            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;



        }

        private void rad_Claro_CheckedChanged(object sender, EventArgs e)
        {


            //formatação cor
            lbl_BemVindo.ForeColor = Color.Black;
            lbl_Nome.ForeColor = Color.Black;
            grp_op.ForeColor = Color.Black;
            lbl_operadoraS.ForeColor = Color.Black;
            lbl_DDD.ForeColor = Color.Black;
            lbl_NumeroDoC.ForeColor = Color.Black;
            lbl_SelecioneoV.ForeColor = Color.Black;
            lbl_Validade.ForeColor = Color.Black;   
            lbl_Validade2.ForeColor = Color.Black;
            lbl_Validade3.ForeColor = Color.Black;
            lbl_Validade4.ForeColor = Color.Black;
            lbl_Validade5.ForeColor = Color.Black;
            lbl_Validade6.ForeColor = Color.Black;
            lbl_Validade7.ForeColor = Color.Black;
            lbl_Validade8.ForeColor = Color.Black;
            lbl_ValorDaRec.ForeColor = Color.Black;


            BackColor = Color.Red;

            pic_telefone.Image = Properties.Resources.claro;

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

            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;

        }

        private void rad_Tim_CheckedChanged(object sender, EventArgs e)
        {

            BackColor = Color.Blue;

            pic_telefone.Image = Properties.Resources.tim;


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

            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;

        }

        private void rad_Oi_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.DarkOrange;

            pic_telefone.Image = Properties.Resources.oi;


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

            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;

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
