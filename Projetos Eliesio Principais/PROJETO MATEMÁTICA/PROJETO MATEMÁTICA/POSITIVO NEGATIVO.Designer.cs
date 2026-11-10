namespace PROJETO_MATEMÁTICA
{
    partial class frm_positvo
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
            this.lbl_positivo = new System.Windows.Forms.Label();
            this.lbl_digiteumN = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_positivo
            // 
            this.lbl_positivo.AutoSize = true;
            this.lbl_positivo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_positivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_positivo.ForeColor = System.Drawing.Color.Red;
            this.lbl_positivo.Location = new System.Drawing.Point(158, 111);
            this.lbl_positivo.Name = "lbl_positivo";
            this.lbl_positivo.Size = new System.Drawing.Size(498, 31);
            this.lbl_positivo.TabIndex = 0;
            this.lbl_positivo.Text = "POSITIVO, NEGATIVO OU NEUTRO";
            // 
            // lbl_digiteumN
            // 
            this.lbl_digiteumN.AutoSize = true;
            this.lbl_digiteumN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_digiteumN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_digiteumN.ForeColor = System.Drawing.Color.White;
            this.lbl_digiteumN.Location = new System.Drawing.Point(288, 162);
            this.lbl_digiteumN.Name = "lbl_digiteumN";
            this.lbl_digiteumN.Size = new System.Drawing.Size(271, 29);
            this.lbl_digiteumN.TabIndex = 1;
            this.lbl_digiteumN.Text = "DIGITE UM NÚMERO:";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(365, 211);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero.TabIndex = 2;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(629, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(145, 31);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_positvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.lbl_digiteumN);
            this.Controls.Add(this.lbl_positivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_positvo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSITIVO_NEGATIVO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_positivo;
        private System.Windows.Forms.Label lbl_digiteumN;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Button btn_voltar;
    }
}