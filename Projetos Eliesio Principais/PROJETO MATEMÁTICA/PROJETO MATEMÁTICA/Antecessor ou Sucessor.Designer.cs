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
            this.lbl_antecessor = new System.Windows.Forms.Label();
            this.lbl_sucessor = new System.Windows.Forms.Label();
            this.lbl_limpar = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.pic_setaE = new System.Windows.Forms.PictureBox();
            this.pic_Sucessor = new System.Windows.Forms.PictureBox();
            this.pic_Lixo = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.txt_calc1 = new System.Windows.Forms.TextBox();
            this.txt_calc2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_setaE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sucessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lixo)).BeginInit();
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
            // lbl_antecessor
            // 
            this.lbl_antecessor.AutoSize = true;
            this.lbl_antecessor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_antecessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_antecessor.ForeColor = System.Drawing.Color.White;
            this.lbl_antecessor.Location = new System.Drawing.Point(90, 324);
            this.lbl_antecessor.Name = "lbl_antecessor";
            this.lbl_antecessor.Size = new System.Drawing.Size(110, 24);
            this.lbl_antecessor.TabIndex = 2;
            this.lbl_antecessor.Text = "Antecessor ";
            // 
            // lbl_sucessor
            // 
            this.lbl_sucessor.AutoSize = true;
            this.lbl_sucessor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sucessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sucessor.ForeColor = System.Drawing.Color.White;
            this.lbl_sucessor.Location = new System.Drawing.Point(300, 324);
            this.lbl_sucessor.Name = "lbl_sucessor";
            this.lbl_sucessor.Size = new System.Drawing.Size(94, 24);
            this.lbl_sucessor.TabIndex = 3;
            this.lbl_sucessor.Text = "Sucessor ";
            // 
            // lbl_limpar
            // 
            this.lbl_limpar.AutoSize = true;
            this.lbl_limpar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_limpar.ForeColor = System.Drawing.Color.White;
            this.lbl_limpar.Location = new System.Drawing.Point(498, 324);
            this.lbl_limpar.Name = "lbl_limpar";
            this.lbl_limpar.Size = new System.Drawing.Size(67, 24);
            this.lbl_limpar.TabIndex = 4;
            this.lbl_limpar.Text = "Limpar";
            this.lbl_limpar.Visible = false;
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
            // pic_setaE
            // 
            this.pic_setaE.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_go_previous_256;
            this.pic_setaE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_setaE.Location = new System.Drawing.Point(94, 234);
            this.pic_setaE.Name = "pic_setaE";
            this.pic_setaE.Size = new System.Drawing.Size(100, 74);
            this.pic_setaE.TabIndex = 6;
            this.pic_setaE.TabStop = false;
            this.pic_setaE.Click += new System.EventHandler(this.pic_setaE_Click);
            // 
            // pic_Sucessor
            // 
            this.pic_Sucessor.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_go_next_256;
            this.pic_Sucessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Sucessor.Location = new System.Drawing.Point(304, 234);
            this.pic_Sucessor.Name = "pic_Sucessor";
            this.pic_Sucessor.Size = new System.Drawing.Size(100, 74);
            this.pic_Sucessor.TabIndex = 7;
            this.pic_Sucessor.TabStop = false;
            this.pic_Sucessor.Click += new System.EventHandler(this.pic_Sucessor_Click);
            // 
            // pic_Lixo
            // 
            this.pic_Lixo.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.Iconshock_Vista_General_Trash_256;
            this.pic_Lixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Lixo.Location = new System.Drawing.Point(502, 221);
            this.pic_Lixo.Name = "pic_Lixo";
            this.pic_Lixo.Size = new System.Drawing.Size(100, 87);
            this.pic_Lixo.TabIndex = 8;
            this.pic_Lixo.TabStop = false;
            this.pic_Lixo.Visible = false;
            this.pic_Lixo.Click += new System.EventHandler(this.pic_Lixo_Click);
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
            // txt_calc1
            // 
            this.txt_calc1.Location = new System.Drawing.Point(94, 363);
            this.txt_calc1.Name = "txt_calc1";
            this.txt_calc1.Size = new System.Drawing.Size(100, 20);
            this.txt_calc1.TabIndex = 10;
            this.txt_calc1.Visible = false;
            this.txt_calc1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_calc2
            // 
            this.txt_calc2.Location = new System.Drawing.Point(304, 363);
            this.txt_calc2.Name = "txt_calc2";
            this.txt_calc2.Size = new System.Drawing.Size(100, 20);
            this.txt_calc2.TabIndex = 11;
            this.txt_calc2.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frm_ant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.matrmatica;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_calc2);
            this.Controls.Add(this.txt_calc1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.pic_Lixo);
            this.Controls.Add(this.pic_Sucessor);
            this.Controls.Add(this.pic_setaE);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.lbl_limpar);
            this.Controls.Add(this.lbl_sucessor);
            this.Controls.Add(this.lbl_antecessor);
            this.Controls.Add(this.lbl_digiteumN);
            this.Controls.Add(this.lbl_ant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antecessor_ou_Sucessor";
            ((System.ComponentModel.ISupportInitialize)(this.pic_setaE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sucessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lixo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ant;
        private System.Windows.Forms.Label lbl_digiteumN;
        private System.Windows.Forms.Label lbl_antecessor;
        private System.Windows.Forms.Label lbl_sucessor;
        private System.Windows.Forms.Label lbl_limpar;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.PictureBox pic_setaE;
        private System.Windows.Forms.PictureBox pic_Sucessor;
        private System.Windows.Forms.PictureBox pic_Lixo;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox txt_calc1;
        private System.Windows.Forms.TextBox txt_calc2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}