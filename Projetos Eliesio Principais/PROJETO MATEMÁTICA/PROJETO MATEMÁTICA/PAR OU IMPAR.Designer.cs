namespace PROJETO_MATEMÁTICA
{
    partial class frm_par
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
            this.lbl_parouI = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.txt_numeroPI = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_parouI
            // 
            this.lbl_parouI.AutoSize = true;
            this.lbl_parouI.BackColor = System.Drawing.Color.Transparent;
            this.lbl_parouI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parouI.ForeColor = System.Drawing.Color.Red;
            this.lbl_parouI.Location = new System.Drawing.Point(263, 91);
            this.lbl_parouI.Name = "lbl_parouI";
            this.lbl_parouI.Size = new System.Drawing.Size(223, 31);
            this.lbl_parouI.TabIndex = 0;
            this.lbl_parouI.Text = "PAR OU ÍMPAR";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero.ForeColor = System.Drawing.Color.White;
            this.lbl_Numero.Location = new System.Drawing.Point(264, 156);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(234, 25);
            this.lbl_Numero.TabIndex = 1;
            this.lbl_Numero.Text = "DIGITE UM NÚMERO";
            // 
            // txt_numeroPI
            // 
            this.txt_numeroPI.Location = new System.Drawing.Point(310, 205);
            this.txt_numeroPI.Name = "txt_numeroPI";
            this.txt_numeroPI.Size = new System.Drawing.Size(131, 20);
            this.txt_numeroPI.TabIndex = 2;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(624, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(145, 31);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_par
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_numeroPI);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.lbl_parouI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_par";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAR_OU_IMPAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_parouI;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.TextBox txt_numeroPI;
        private System.Windows.Forms.Button btn_voltar;
    }
}