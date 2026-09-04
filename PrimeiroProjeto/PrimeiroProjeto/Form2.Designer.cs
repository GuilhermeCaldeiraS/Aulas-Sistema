namespace PrimeiroProjeto
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(60, 83);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(60, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(60, 171);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Controls.Add(this.btnCadastrar);
            this.pnlCadastro.Controls.Add(this.txtSenha);
            this.pnlCadastro.Controls.Add(this.txtEmail);
            this.pnlCadastro.Controls.Add(this.txtNome);
            this.pnlCadastro.Controls.Add(this.lblnome);
            this.pnlCadastro.Controls.Add(this.lblSenha);
            this.pnlCadastro.Controls.Add(this.lblEmail);
            this.pnlCadastro.Location = new System.Drawing.Point(194, 29);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(450, 300);
            this.pnlCadastro.TabIndex = 3;
            this.pnlCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadastro_Paint);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(162, 229);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastra- Se";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(110, 168);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(231, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(231, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCadastro);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
    }
}