using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olamundoFreamework
{
    public partial class Frm_Mundo : Form
    {
        public Frm_Mundo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //A orderm para aparecer as mensagens são, as primeias aspas sao a mensagem do meio, e a outra aspas sao a mensagem de cima.
            MessageBox.Show ("Ola Mundo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); // mensagem para aparecer a caixa de informação e os botões respectivos, apos os cliques 
            Application.Exit (); //fechando a Aplicação
        }

        private void Frm_Mundo_Load(object sender, EventArgs e)
        {

        }
    }
}
