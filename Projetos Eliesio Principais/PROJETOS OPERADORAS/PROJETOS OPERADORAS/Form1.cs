using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
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
            txt_Valor.Enabled = false;
        }

        private void btn_Recarga30_Click(object sender, EventArgs e)
        {
            txt_Valor.Enabled = false;
        }

        private void btn_Recarga35_Click(object sender, EventArgs e)
        {
            txt_Valor.Enabled = false;
        }

        private void btn_Recarga40_Click(object sender, EventArgs e)
        {
            txt_Valor.Enabled = false;
        }

        private void btn_Recarga55_Click(object sender, EventArgs e)
        {
            txt_Valor.Enabled = false;
        }

        private void btn_Recarga50_Click(object sender, EventArgs e)
        {
            txt_Valor.Enabled = false;
        }

        private void rad_Vivo_CheckedChanged(object sender, EventArgs e)
        {   
            
            //estilizando o botão
            btn_1.ForeColor = Color.Violet;
            
            btn_1.FlatAppearance.MouseOverBackColor = Color.White;
            btn_2.ForeColor = Color.Violet;
            
            btn_2.FlatAppearance.MouseOverBackColor = Color.White;
            btn_3.ForeColor = Color.Violet;
            
            btn_3.FlatAppearance.MouseOverBackColor = Color.White;
            btn_4.ForeColor = Color.Violet;
            
            btn_4.FlatAppearance.MouseOverBackColor = Color.White;
            btn_5.ForeColor = Color.Violet;
            
            btn_5.FlatAppearance.MouseOverBackColor = Color.White;
            btn_6.ForeColor = Color.Violet;
           
            btn_6.FlatAppearance.MouseOverBackColor = Color.White;
            btn_7.ForeColor = Color.Violet;
            
            btn_7.FlatAppearance.MouseOverBackColor = Color.White;
            btn_8.ForeColor = Color.Violet;
            
            btn_8.FlatAppearance.MouseOverBackColor = Color.White;





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

            
   


            BackColor = Color.Purple;

            pic_telefone.Image = Properties.Resources.vivo;


            //atribuição
            txt_opSelec.Text = "VIVO";


            //TEXTO DO BOTÃO
            btn_1.Text = "R$ 12,00";
            btn_2.Text = "R$ 15,00";
            btn_3.Text = "R$ 20,00";
            btn_4.Text = "R$ 30,00";
            btn_5.Text = "R$ 35,00";
            btn_6.Text = "R$ 40,00";
            btn_7.Text = "R$ 100,00";
            btn_8.Text = "R$ 200,00";


            //Evento click Botão = Atriubuir o valor da recarga ao textbox quando o botão for clicado
            btn_1.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 12,00";
            btn_2.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 15,00";
            btn_3.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 20,00";
            btn_4.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 30,00";
            btn_5.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 35,00";
            btn_6.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 40,00";
            btn_7.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 100,00";
            btn_8.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 200,00";

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
            txt_Valor.Enabled = true;
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

            //estilizando o botão
            btn_1.ForeColor = Color.Black;
       
            btn_1.FlatAppearance.MouseOverBackColor = Color.White;
            btn_2.ForeColor = Color.Black;
           
            btn_2.FlatAppearance.MouseOverBackColor = Color.White;
            btn_3.ForeColor = Color.Black;
            
            btn_3.FlatAppearance.MouseOverBackColor = Color.White;
            btn_4.ForeColor = Color.Black;
           
            btn_4.FlatAppearance.MouseOverBackColor = Color.White;
            btn_5.ForeColor = Color.Black;
            
            btn_5.FlatAppearance.MouseOverBackColor = Color.White;
            btn_6.ForeColor = Color.Black;
           
            btn_6.FlatAppearance.MouseOverBackColor = Color.White;
            btn_7.ForeColor = Color.Black;
            
            btn_7.FlatAppearance.MouseOverBackColor = Color.White;
            btn_8.ForeColor = Color.Black;
           
            btn_8.FlatAppearance.MouseOverBackColor = Color.White;


            //TEXTO DO BOTÃO
            btn_1.Text = "R$ 12,00";
            btn_2.Text = "R$ 15,00";
            btn_3.Text = "R$ 20,00";
            btn_4.Text = "R$ 25,00";
            btn_5.Text = "R$ 30,00";
            btn_6.Text = "R$ 35,00";
            btn_7.Text = "R$ 50,00";
            btn_8.Text = "R$ 100,00";


            //limpando os caracteres apos clicar em outra operadora
            txt_DDD.Text = "";
            txt_Nome.Text = string.Empty;
            txt_NumCell.Text = string.Empty;
            txt_Valor.Text = string.Empty;


            //Evento click Botão = Atriubuir o valor da recarga ao textbox quando o botão for clicado
            btn_1.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 12,00";
            btn_2.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 15,00";
            btn_3.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 20,00";
            btn_4.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 25,00";
            btn_5.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 30,00";
            btn_6.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 35,00";
            btn_7.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 50,00";
            btn_8.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 100,00";

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

            //estilizando o botão
            btn_1.ForeColor = Color.Black;
         
            btn_1.FlatAppearance.MouseOverBackColor = Color.White;
            btn_2.ForeColor = Color.Black;
          
            btn_2.FlatAppearance.MouseOverBackColor = Color.White;
            btn_3.ForeColor = Color.Black;
            
            btn_3.FlatAppearance.MouseOverBackColor = Color.White;
            btn_4.ForeColor = Color.Black;
            
            btn_4.FlatAppearance.MouseOverBackColor = Color.White;
            btn_5.ForeColor = Color.Black;
           
            btn_5.FlatAppearance.MouseOverBackColor = Color.White;
            btn_6.ForeColor = Color.Black;
         
            btn_6.FlatAppearance.MouseOverBackColor = Color.White;
            btn_7.ForeColor = Color.Black;
       
            btn_7.FlatAppearance.MouseOverBackColor = Color.White;
            btn_8.ForeColor = Color.Black;
         
            btn_8.FlatAppearance.MouseOverBackColor = Color.White;

            //TEXTO DO BOTÃO
            btn_1.Text = "R$ 10,00";
            btn_2.Text = "R$ 15,00";
            btn_3.Text = "R$ 20,00";
            btn_4.Text = "R$ 30,00";
            btn_5.Text = "R$ 40,00";
            btn_6.Text = "R$ 50,00";
            btn_7.Text = "R$ 60,00";
            btn_8.Text = "R$ 100,00";

            //limpando os caracteres apos clicar em outra operadora
            txt_DDD.Text = "";
            txt_Nome.Text = string.Empty;
            txt_NumCell.Text = string.Empty;
            txt_Valor.Text = string.Empty;


            //Evento click Botão = Atriubuir o valor da recarga ao textbox quando o botão for clicado
            btn_1.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 10,00";
            btn_2.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 15,00";
            btn_3.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 20,00";
            btn_4.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 30,00";
            btn_5.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 40,00";
            btn_6.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 50,00";
            btn_7.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 60,00";
            btn_8.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 100,00";


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

            //estilizando o botão
            btn_1.ForeColor = Color.Gold;
          
            btn_1.FlatAppearance.MouseOverBackColor = Color.White;

            btn_2.ForeColor = Color.Gold;
            
            btn_2.FlatAppearance.MouseOverBackColor = Color.White;

            btn_3.ForeColor = Color.Gold;
           
            btn_3.FlatAppearance.MouseOverBackColor = Color.White;

            btn_4.ForeColor = Color.Gold;
            
            btn_4.FlatAppearance.MouseOverBackColor = Color.White;

            btn_5.ForeColor = Color.Gold;
           
            btn_5.FlatAppearance.MouseOverBackColor = Color.White;

            btn_6.ForeColor = Color.Gold;
            
            btn_6.FlatAppearance.MouseOverBackColor = Color.White;

            btn_7.ForeColor = Color.Gold;
            
            btn_7.FlatAppearance.MouseOverBackColor = Color.White;

            btn_8.ForeColor = Color.Gold;
         
            btn_8.FlatAppearance.MouseOverBackColor = Color.White;


            //TEXTO DO BOTÃO
            btn_1.Text = "R$ 10,00";
            btn_2.Text = "R$ 15,00";
            btn_3.Text = "R$ 20,00";
            btn_4.Text = "R$ 25,00";
            btn_5.Text = "R$ 30,00";
            btn_6.Text = "R$ 35,00";
            btn_7.Text = "R$ 40,00";
            btn_8.Text = "R$ 50,00";


            //limpando os caracteres apos clicar em outra operadora
            txt_DDD.Text = "";
            txt_Nome.Text = string.Empty;
            txt_NumCell.Text = string.Empty;
            txt_Valor.Text = string.Empty;


            //Evento click Botão = Atriubuir o valor da recarga ao textbox quando o botão for clicado
            btn_1.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 10,00";
            btn_2.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 15,00";
            btn_3.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 20,00";
            btn_4.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 25,00";
            btn_5.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 30,00";
            btn_6.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 35,00";
            btn_7.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 40,00";
            btn_8.Click += (senderBtn, eventArgs) => txt_Valor.Text = "R$ 50,00";

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
