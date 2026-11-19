namespace PROJETO_MATEMÁTICA
{
    partial class frm_ant
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
            this.components = new System.ComponentModel.Container();
            this.lbl_ant = new System.Windows.Forms.Label();
            this.lbl_digiteumN = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btn_direita = new System.Windows.Forms.Button();
            this.btn_lixeira = new System.Windows.Forms.Button();
            this.btn_esqueda = new System.Windows.Forms.Button();
            this.lbl_antecessor = new System.Windows.Forms.Label();
            this.lbl_Sucessor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ant
            // 
            this.lbl_ant.AutoSize = true;
            this.lbl_ant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ant.ForeColor = System.Drawing.Color.Red;
            this.lbl_ant.Location = new System.Drawing.Point(157, 23);
            this.lbl_ant.Name = "lbl_ant";
            this.lbl_ant.Size = new System.Drawing.Size(331, 31);
            this.lbl_ant.TabIndex = 0;
            this.lbl_ant.Text = "Antecessor ou Sucessor";
            // 
            // lbl_digiteumN
            // 
            this.lbl_digiteumN.AutoSize = true;
            this.lbl_digiteumN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_digiteumN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_digiteumN.ForeColor = System.Drawing.Color.White;
            this.lbl_digiteumN.Location = new System.Drawing.Point(80, 140);
            this.lbl_digiteumN.Name = "lbl_digiteumN";
            this.lbl_digiteumN.Size = new System.Drawing.Size(282, 29);
            this.lbl_digiteumN.TabIndex = 1;
            this.lbl_digiteumN.Text = "Digite um número inteiro:";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(368, 149);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(120, 20);
            this.txt_Numero.TabIndex = 5;
            this.txt_Numero.TextChanged += new System.EventHandler(this.txt_Numero_TextChanged);
            this.txt_Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Numero_KeyPress);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(643, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(145, 31);
            this.btn_voltar.TabIndex = 9;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-15, -15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_direita
            // 
            this.btn_direita.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_go_next_256;
            this.btn_direita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_direita.Location = new System.Drawing.Point(277, 228);
            this.btn_direita.Name = "btn_direita";
            this.btn_direita.Size = new System.Drawing.Size(104, 65);
            this.btn_direita.TabIndex = 11;
            this.btn_direita.UseVisualStyleBackColor = true;
            this.btn_direita.Click += new System.EventHandler(this.btn_direita_Click);
            // 
            // btn_lixeira
            // 
            this.btn_lixeira.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.Iconshock_Vista_General_Trash_256;
            this.btn_lixeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lixeira.Location = new System.Drawing.Point(494, 249);
            this.btn_lixeira.Name = "btn_lixeira";
            this.btn_lixeira.Size = new System.Drawing.Size(86, 102);
            this.btn_lixeira.TabIndex = 12;
            this.btn_lixeira.UseVisualStyleBackColor = true;
            this.btn_lixeira.Click += new System.EventHandler(this.btn_lixeira_Click);
            // 
            // btn_esqueda
            // 
            this.btn_esqueda.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_go_previous_256;
            this.btn_esqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_esqueda.Location = new System.Drawing.Point(136, 228);
            this.btn_esqueda.Name = "btn_esqueda";
            this.btn_esqueda.Size = new System.Drawing.Size(104, 65);
            this.btn_esqueda.TabIndex = 13;
            this.btn_esqueda.UseVisualStyleBackColor = true;
            this.btn_esqueda.Click += new System.EventHandler(this.btn_esqueda_Click);
            // 
            // lbl_antecessor
            // 
            this.lbl_antecessor.Location = new System.Drawing.Point(140, 311);
            this.lbl_antecessor.Name = "lbl_antecessor";
            this.lbl_antecessor.Size = new System.Drawing.Size(100, 23);
            this.lbl_antecessor.TabIndex = 14;
            this.lbl_antecessor.Text = "?";
            this.lbl_antecessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Sucessor
            // 
            this.lbl_Sucessor.Location = new System.Drawing.Point(274, 311);
            this.lbl_Sucessor.Name = "lbl_Sucessor";
            this.lbl_Sucessor.Size = new System.Drawing.Size(100, 23);
            this.lbl_Sucessor.TabIndex = 15;
            this.lbl_Sucessor.Text = "?";
            this.lbl_Sucessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.matrmatica;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Sucessor);
            this.Controls.Add(this.lbl_antecessor);
            this.Controls.Add(this.btn_esqueda);
            this.Controls.Add(this.btn_lixeira);
            this.Controls.Add(this.btn_direita);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.lbl_digiteumN);
            this.Controls.Add(this.lbl_ant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antecessor_ou_Sucessor";
            this.Load += new System.EventHandler(this.frm_ant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ant;
        private System.Windows.Forms.Label lbl_digiteumN;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_direita;
        private System.Windows.Forms.Button btn_lixeira;
        private System.Windows.Forms.Button btn_esqueda;
        private System.Windows.Forms.Label lbl_antecessor;
        private System.Windows.Forms.Label lbl_Sucessor;
    }
}