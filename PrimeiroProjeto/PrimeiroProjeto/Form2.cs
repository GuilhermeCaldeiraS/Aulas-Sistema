using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void pnlCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           string nome = txtNome.Text.Trim();
           string email = txtEmail.Text .Trim();
            string senhha = txtSenha.Text;
            if (nome == "" || email ==  ||  senhha == "") 
        }

        MessageBox.Show (
            "Preencha todos os campos.",
            "Atenção"
            )

       
}
