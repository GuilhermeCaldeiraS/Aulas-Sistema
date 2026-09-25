namespace Mensagem_em_C_
{
    partial class frm_mensagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mensagem));
            this.grp_mensagens = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_simounao = new System.Windows.Forms.Button();
            this.btn_simples = new System.Windows.Forms.Button();
            this.btn_comtitulo = new System.Windows.Forms.Button();
            this.btn_iconecritico = new System.Windows.Forms.Button();
            this.btn_alertaC = new System.Windows.Forms.Button();
            this.grp_mensagens.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_mensagens
            // 
            this.grp_mensagens.BackgroundImage = global::Mensagem_em_C_.Properties.Resources.balão;
            this.grp_mensagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_mensagens.Controls.Add(this.btn_alertaC);
            this.grp_mensagens.Controls.Add(this.btn_iconecritico);
            this.grp_mensagens.Controls.Add(this.btn_comtitulo);
            this.grp_mensagens.Controls.Add(this.btn_simples);
            this.grp_mensagens.Controls.Add(this.btn_simounao);
            this.grp_mensagens.Controls.Add(this.label1);
            this.grp_mensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_mensagens.Location = new System.Drawing.Point(58, 24);
            this.grp_mensagens.Name = "grp_mensagens";
            this.grp_mensagens.Size = new System.Drawing.Size(821, 488);
            this.grp_mensagens.TabIndex = 0;
            this.grp_mensagens.TabStop = false;
            this.grp_mensagens.Text = "MENSAGENS EM C#";
            this.grp_mensagens.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO DE MENSAGENS";
            // 
            // btn_simounao
            // 
            this.btn_simounao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simounao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simounao.Location = new System.Drawing.Point(20, 150);
            this.btn_simounao.Name = "btn_simounao";
            this.btn_simounao.Size = new System.Drawing.Size(133, 45);
            this.btn_simounao.TabIndex = 1;
            this.btn_simounao.Text = "ALERTA SIM OU NÃO";
            this.btn_simounao.UseVisualStyleBackColor = true;
            this.btn_simounao.Click += new System.EventHandler(this.btn_simounao_Click);
            // 
            // btn_simples
            // 
            this.btn_simples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simples.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simples.Location = new System.Drawing.Point(186, 44);
            this.btn_simples.Name = "btn_simples";
            this.btn_simples.Size = new System.Drawing.Size(136, 46);
            this.btn_simples.TabIndex = 2;
            this.btn_simples.Text = "ALERTA SIMPLES";
            this.btn_simples.UseVisualStyleBackColor = true;
            // 
            // btn_comtitulo
            // 
            this.btn_comtitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comtitulo.Location = new System.Drawing.Point(352, 121);
            this.btn_comtitulo.Name = "btn_comtitulo";
            this.btn_comtitulo.Size = new System.Drawing.Size(125, 74);
            this.btn_comtitulo.TabIndex = 3;
            this.btn_comtitulo.Text = "ALERTA SIMPLES COM TITULO";
            this.btn_comtitulo.UseVisualStyleBackColor = true;
            // 
            // btn_iconecritico
            // 
            this.btn_iconecritico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iconecritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iconecritico.Location = new System.Drawing.Point(511, 28);
            this.btn_iconecritico.Name = "btn_iconecritico";
            this.btn_iconecritico.Size = new System.Drawing.Size(104, 72);
            this.btn_iconecritico.TabIndex = 4;
            this.btn_iconecritico.Text = "ALERTA COM ICONE CRITICO";
            this.btn_iconecritico.UseVisualStyleBackColor = true;
            // 
            // btn_alertaC
            // 
            this.btn_alertaC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alertaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alertaC.Location = new System.Drawing.Point(678, 121);
            this.btn_alertaC.Name = "btn_alertaC";
            this.btn_alertaC.Size = new System.Drawing.Size(118, 74);
            this.btn_alertaC.TabIndex = 5;
            this.btn_alertaC.Text = "ALERTA COM S/N E CANCELAR";
            this.btn_alertaC.UseVisualStyleBackColor = true;
            this.btn_alertaC.Click += new System.EventHandler(this.button5_Click);
            // 
            // frm_mensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(891, 524);
            this.Controls.Add(this.grp_mensagens);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_mensagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIPO DE MENSAGEM ";
            this.grp_mensagens.ResumeLayout(false);
            this.grp_mensagens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_mensagens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_alertaC;
        private System.Windows.Forms.Button btn_iconecritico;
        private System.Windows.Forms.Button btn_comtitulo;
        private System.Windows.Forms.Button btn_simples;
        private System.Windows.Forms.Button btn_simounao;
    }
}

