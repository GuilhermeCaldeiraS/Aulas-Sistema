using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estações
{
    public partial class frm_estacoes : Form
    {
        public frm_estacoes()
        {
            InitializeComponent();
        }

        private void rad_primavera_CheckedChanged(object sender, EventArgs e)
        {
            pic_estacoes.Image = Properties.Resources.Primavera; //buscando a imagem para a primeira opção no pic
            txt_informacao.Text = "Primavera Inicio 22/09 a 20/12"; // aqui estamos colocando um texto para aparecer apos clicar no button
        }

        private void rad_verao_CheckedChanged(object sender, EventArgs e)
        {
            pic_estacoes.Image = Properties.Resources.verao; //buscando a imagem para a primeira opção no pic
            txt_informacao.Text = "Verão Inicio 21/12 a 20/03 "; // aqui estamos colocando um texto para aparecer apos clicar no button
        }

        private void rad_outono_CheckedChanged(object sender, EventArgs e)
        {
            pic_estacoes.Image = Properties.Resources.Outono; //buscando a imagem para a primeira opção no pic
            txt_informacao.Text = "Outono Inicio 20/03 a 20/06 "; // aqui estamos colocando um texto para aparecer apos clicar no button
        }

        private void rad_inverno_CheckedChanged(object sender, EventArgs e)
        {
            pic_estacoes.Image = Properties.Resources.Inverno; //buscando a imagem para a primeira opção no pic
            txt_informacao.Text = "Inverno Inicio 21/06 a 21/09"; // aqui estamos colocando um texto para aparecer apos clicar no button
        }

        private void txt_informacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void grp_estacoes_Enter(object sender, EventArgs e)
        {

        }
    }
}
