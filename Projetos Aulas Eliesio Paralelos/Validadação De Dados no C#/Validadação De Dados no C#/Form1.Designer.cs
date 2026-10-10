namespace Validadação_De_Dados_no_C_
{
    partial class frm_validadação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_validadação));
            this.lbl_validação = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.pic_01 = new System.Windows.Forms.PictureBox();
            this.pic_02 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_02)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_validação
            // 
            this.lbl_validação.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_validação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_validação.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_validação.Location = new System.Drawing.Point(-26, 26);
            this.lbl_validação.Name = "lbl_validação";
            this.lbl_validação.Size = new System.Drawing.Size(844, 64);
            this.lbl_validação.TabIndex = 0;
            this.lbl_validação.Text = "VALIDAÇÃO DE DADOS EM C#";
            this.lbl_validação.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(112, 119);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(60, 20);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idade.Location = new System.Drawing.Point(112, 163);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(60, 20);
            this.lbl_idade.TabIndex = 2;
            this.lbl_idade.Text = "Idade:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(112, 209);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(48, 20);
            this.lbl_cpf.TabIndex = 3;
            this.lbl_cpf.Text = "CPF:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(199, 118);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(256, 20);
            this.txt_nome.TabIndex = 4;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(199, 162);
            this.txt_idade.MaxLength = 3;
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(100, 20);
            this.txt_idade.TabIndex = 5;
            this.txt_idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idade_KeyPress);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(199, 209);
            this.txt_cpf.MaxLength = 11;
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.PasswordChar = '*';
            this.txt_cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf.TabIndex = 6;
            this.txt_cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cpf_KeyPress);
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(524, 115);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(96, 40);
            this.btn_enviar.TabIndex = 7;
            this.btn_enviar.Text = "ENVIAR";
            this.btn_enviar.UseVisualStyleBackColor = true;
            // 
            // pic_01
            // 
            this.pic_01.BackgroundImage = global::Validadação_De_Dados_no_C_.Properties.Resources.homem_pensando_retrato_ilustracao_isolado_24911_115060;
            this.pic_01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_01.Location = new System.Drawing.Point(116, 247);
            this.pic_01.Name = "pic_01";
            this.pic_01.Size = new System.Drawing.Size(182, 191);
            this.pic_01.TabIndex = 8;
            this.pic_01.TabStop = false;
            // 
            // pic_02
            // 
            this.pic_02.BackgroundImage = global::Validadação_De_Dados_no_C_.Properties.Resources.vetor_plano_do_homem_pensando_ilustracao_de_personagem_de_desenho_animado_1271121_1095;
            this.pic_02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_02.Location = new System.Drawing.Point(479, 163);
            this.pic_02.Name = "pic_02";
            this.pic_02.Size = new System.Drawing.Size(309, 275);
            this.pic_02.TabIndex = 9;
            this.pic_02.TabStop = false;
            // 
            // frm_validadação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.pic_02);
            this.Controls.Add(this.pic_01);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_validação);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_validadação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de Dados C#";
            ((System.ComponentModel.ISupportInitialize)(this.pic_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_validação;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.PictureBox pic_01;
        private System.Windows.Forms.PictureBox pic_02;
    }
}

