namespace PROJETO_MATEMÁTICA
{
    partial class frm_dobro
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
            this.lbl_texto = new System.Windows.Forms.Label();
            this.lbl_digite = new System.Windows.Forms.Label();
            this.txt_valorN = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto.ForeColor = System.Drawing.Color.Red;
            this.lbl_texto.Location = new System.Drawing.Point(132, 89);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(514, 31);
            this.lbl_texto.TabIndex = 0;
            this.lbl_texto.Text = "MOSTRA O DOBRO DE UM NÚMERO";
            // 
            // lbl_digite
            // 
            this.lbl_digite.AutoSize = true;
            this.lbl_digite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_digite.Location = new System.Drawing.Point(171, 187);
            this.lbl_digite.Name = "lbl_digite";
            this.lbl_digite.Size = new System.Drawing.Size(234, 25);
            this.lbl_digite.TabIndex = 1;
            this.lbl_digite.Text = "DIGITE UM NÚMERO";
            // 
            // txt_valorN
            // 
            this.txt_valorN.Location = new System.Drawing.Point(411, 187);
            this.txt_valorN.Name = "txt_valorN";
            this.txt_valorN.Size = new System.Drawing.Size(145, 20);
            this.txt_valorN.TabIndex = 2;
            this.txt_valorN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valorN_KeyPress);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(627, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(145, 31);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.Btn_voltar_Click);
            // 
            // frm_dobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.caderneta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_valorN);
            this.Controls.Add(this.lbl_digite);
            this.Controls.Add(this.lbl_texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_dobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dobro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.Label lbl_digite;
        private System.Windows.Forms.TextBox txt_valorN;
        private System.Windows.Forms.Button btn_voltar;
    }
}