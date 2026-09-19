using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro1
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void Rad_tema1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Imagen_2;
        }

        private void Rad_tema2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.imagem4;
        }

        private void Rad_Tema3_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.imagen6;
        }

        private void Grp_Temas_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Ativar_Click(object sender, EventArgs e)
        {
            Btn_Desativar.Enabled = true; // ativando o desativar 
            Btn_Limpar.Enabled = true; // ativando o limpar
            btn_Enviar.Enabled = true; // ativando o enviar
            Btn_Bairro.Enabled = true; // ativando o bairro
            Btn_Celular.Enabled = true; // ativando o celular
            Btn_Dcompleto.Enabled = true;   //ativando os dados completos   
            Btn_email.Enabled = true; // ativando o email
            Btn_Idade.Enabled = true; // ativando o idade
            Btn_Nome.Enabled = true; // ativando o nome
            Btn_Sobrenome.Enabled = true; // ativando o sobrenome
            lbl_resultado.Enabled = true; // ativando a lbl resultado 
            Lbl_Bairro.Enabled = true; // ativando a lbl bairro 
            Lbl_Celular.Enabled=true; // ativando a lbl celular
            Lbl_DadosP.Enabled = true; // ativando a lbl dadosP
            Lbl_email.Enabled = true; // ativando a lbl email
            Lbl_idade.Enabled = true; // ativando a lbl idade  
            Lbl_Nome.Enabled = true; // ativando a lbl nome
            Lbl_Sobrenome.Enabled=true; // ativando a lbl sobrenome
            lbl_confirmaD.Enabled = true; // ativando a lbl confirmacção de dados
            Grp_Temas.Enabled = true; // ativando o grupo de troca de temas
            Txt_nome.Enabled = true; // ativando o txt nome
            Txt_Sobrenome.Enabled = true; // ativando o txt sobrenome
            Txt_Idade.Enabled = true; // ativando o txt idade
            Txt_email.Enabled = true; // ativando o txt email
            Txt_Celular.Enabled = true; // ativando o txt celular
            Txt_Bairro.Enabled=true; // ativando o txt bairro

        }

        private void Btn_Nome_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Txt_nome.Text; // faz o botão nome receber o texto que será escrito no campo de nome. 
        }

        private void Btn_Sobrenome_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Txt_Sobrenome.Text; // faz o botão sobrenome receber o texto que será escrito no campo de sobrenome.
        }

        private void Btn_Idade_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text += Txt_Idade.Text; 
        }

        private void Btn_Bairro_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Txt_Bairro.Text;
        }

        private void Lbl_idade_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Celular_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Txt_Celular.Text; 
        }

        private void Btn_email_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Txt_email.Text;
        }

        private void Btn_Dcompleto_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Txt_nome.Text + " " + Txt_Sobrenome.Text+ "\n" + Txt_Idade.Text + "\n" + 
                Txt_Celular.Text + "\n" + Txt_Bairro.Text + "\n" + Txt_email.Text;
            // + Concatenar (Juntar) "\n" Quebra de linha (descer).
        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_nome.Clear();  Txt_Sobrenome.Clear();  Txt_Idade.Clear();  Txt_Celular.Clear();  Txt_Bairro.Clear();  Txt_email.Clear();
        }

        private void Btn_Desativar_Click(object sender, EventArgs e)
        {
            Btn_Desativar.Enabled = false; 
            Btn_Limpar.Enabled = false;//desaativando o limpar
            btn_Enviar.Enabled = false; // desaativando o enviar
            Btn_Bairro.Enabled = false; // desaativando o bairro
            Btn_Celular.Enabled = false; // desaativando o celular
            Btn_Dcompleto.Enabled = false;   //desaativando os dados completos   
            Btn_email.Enabled = false; // desaativando o email
            Btn_Idade.Enabled = false; // desaativando o idade
            Btn_Nome.Enabled = false; // desaativando o nome
            Btn_Sobrenome.Enabled = false; // desaativando o sobrenome
            lbl_resultado.Enabled = false; // desaativando a lbl resultado 
            Lbl_Bairro.Enabled = false; // desaativando a lbl bairro 
            Lbl_Celular.Enabled = false; // desaativando a lbl celular
            Lbl_DadosP.Enabled = false; // desaativando a lbl dadosP
            Lbl_email.Enabled = false; // desaativando a lbl email
            Lbl_idade.Enabled = false; // desaativando a lbl idade  
            Lbl_Nome.Enabled = false; // desaativando a lbl nome
            Lbl_Sobrenome.Enabled = false; // desaativando a lbl sobrenome
            lbl_confirmaD.Enabled = false; // desaativando a lbl confirmacção de dados
            Grp_Temas.Enabled = false; // desaativando o grupo de troca de temas
            Txt_nome.Enabled = false; // ativando o txt nome
            Txt_Sobrenome.Enabled = false; // ativando o txt sobrenome
            Txt_Idade.Enabled = false; // ativando o txt idade
            Txt_email.Enabled = false; // ativando o txt email
            Txt_Celular.Enabled = false; // ativando o txt celular
            Txt_Bairro.Enabled = false; // ativando o txt bairro
        }
    }
}
