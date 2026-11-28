using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_My_SQL
{
    public partial class frm_Sql : Form
    {
        public frm_Sql()
        {
            InitializeComponent();
        }

        private void btn_mensagem_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(10, "Notificação", txt_mensagem.Text, ToolTipIcon.Warning);
            txt_mensagem.Clear(); //Comando para resposta do Notificação
        }
    }

    }
