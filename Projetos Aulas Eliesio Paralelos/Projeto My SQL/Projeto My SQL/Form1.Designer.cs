namespace Projeto_My_SQL
{
    partial class frm_Sql
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_instalação = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_notificação = new System.Windows.Forms.Label();
            this.txt_mensagem = new System.Windows.Forms.TextBox();
            this.btn_mensagem = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // lbl_instalação
            // 
            this.lbl_instalação.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instalação.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_instalação.Location = new System.Drawing.Point(153, 39);
            this.lbl_instalação.Name = "lbl_instalação";
            this.lbl_instalação.Size = new System.Drawing.Size(513, 62);
            this.lbl_instalação.TabIndex = 0;
            this.lbl_instalação.Text = "Instalação do MySql, Botão Direito no nome do Projeto, Nuget, Procurar, MySql, In" +
    "stalar";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_telefone.Location = new System.Drawing.Point(71, 147);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(129, 26);
            this.lbl_telefone.TabIndex = 1;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_notificação
            // 
            this.lbl_notificação.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notificação.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_notificação.Location = new System.Drawing.Point(90, 305);
            this.lbl_notificação.Name = "lbl_notificação";
            this.lbl_notificação.Size = new System.Drawing.Size(236, 26);
            this.lbl_notificação.TabIndex = 2;
            this.lbl_notificação.Text = "Digite a Notificação";
            // 
            // txt_mensagem
            // 
            this.txt_mensagem.Location = new System.Drawing.Point(332, 232);
            this.txt_mensagem.Multiline = true;
            this.txt_mensagem.Name = "txt_mensagem";
            this.txt_mensagem.Size = new System.Drawing.Size(439, 151);
            this.txt_mensagem.TabIndex = 3;
            // 
            // btn_mensagem
            // 
            this.btn_mensagem.BackColor = System.Drawing.Color.Black;
            this.btn_mensagem.ForeColor = System.Drawing.Color.White;
            this.btn_mensagem.Location = new System.Drawing.Point(693, 389);
            this.btn_mensagem.Name = "btn_mensagem";
            this.btn_mensagem.Size = new System.Drawing.Size(78, 55);
            this.btn_mensagem.TabIndex = 4;
            this.btn_mensagem.Text = "Mensagem";
            this.btn_mensagem.UseVisualStyleBackColor = false;
            this.btn_mensagem.Click += new System.EventHandler(this.btn_mensagem_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(201, 147);
            this.maskedTextBox1.Mask = "+00 (00)00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_cpf.Location = new System.Drawing.Point(71, 192);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(129, 26);
            this.lbl_cpf.TabIndex = 6;
            this.lbl_cpf.Text = "Cpf:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(140, 192);
            this.maskedTextBox2.Mask = "000.000.000-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 7;
            // 
            // lbl_rg
            // 
            this.lbl_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rg.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_rg.Location = new System.Drawing.Point(71, 232);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(129, 26);
            this.lbl_rg.TabIndex = 8;
            this.lbl_rg.Text = "RG";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(140, 238);
            this.maskedTextBox3.Mask = "00.000.000.0";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 9;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frm_Sql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 467);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.lbl_rg);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btn_mensagem);
            this.Controls.Add(this.txt_mensagem);
            this.Controls.Add(this.lbl_notificação);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_instalação);
            this.Name = "frm_Sql";
            this.Text = "Projeto MySql";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_instalação;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_notificação;
        private System.Windows.Forms.TextBox txt_mensagem;
        private System.Windows.Forms.Button btn_mensagem;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

