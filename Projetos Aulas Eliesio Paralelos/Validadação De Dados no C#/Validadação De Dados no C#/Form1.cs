using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validadação_De_Dados_no_C_
{
    public partial class frm_validadação : Form
    {
        public frm_validadação()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar)) 
                // verifica se o que foi digitad é letra, espaço na tela de controle (backspace, delete etc)
            {
                e.Handled = true; // verfica as teclas pressionadas
                MessageBox.Show("SÓ PERMITE LETRAS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }




            if (e.KeyChar ==13) // a tecla enter foi precionada 
            {
                if (txt_nome.Text != "") // verfica se o texto esta vazio
                {
                    txt_idade.Focus();  // Passa e vai para proximo campo TXT idade
                } 
            



                  else
                {
                   MessageBox.Show("O NOME NÃO FOI DIGITADO....", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   //Obs. : Deixe eles fazerem o cpf
                }
        
            }
        
        
        
        }




        private void txt_idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            // verifica se o que foi digitad é letra, espaço na tela de controle (backspace, delete etc)
            {
                e.Handled = true; // verfica as teclas pressionadas
                MessageBox.Show("SÓ PERMITE NÚMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            if (e.KeyChar == 13) // a tecla enter foi precionada 
            {
                if (txt_nome.Text != "") // verfica se o texto esta vazio
                {
                    txt_idade.Focus();  // Passa e vai para proximo campo TXT idade
                }




                else
                {
                    MessageBox.Show("A IDADE NÃO FOI DIGITADA....", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Obs. : Deixe eles fazerem o cpf
                }

            }

        }

        private void txt_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)  && !char.IsSeparator(e.KeyChar))
            // verifica se o que foi digitad é letra, espaço na tela de controle (backspace, delete etc)
            {
                e.Handled = true; // verfica as teclas pressionadas
                MessageBox.Show("SÓ PERMITE NÚMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            if (e.KeyChar == 13) // a tecla enter foi precionada 
            {
                if (txt_nome.Text != "") // verfica se o texto esta vazio
                {
                    txt_idade.Focus();  // Passa e vai para proximo campo TXT idade
                }




                else
                {
                    MessageBox.Show("O CPF NÃO FOI DIGITADO....", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Obs. : Deixe eles fazerem o cpf
                }

            }
        }
    }
}
