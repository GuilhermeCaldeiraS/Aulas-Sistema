namespace Projeto_CarrinhoGeek
{
    partial class frm_memoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_memoria));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_risemode = new System.Windows.Forms.Label();
            this.txt_memoria = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.Black;
            this.btn_voltar.Location = new System.Drawing.Point(83, 511);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(111, 50);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "VOLTAR AO INICIO";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // lbl_risemode
            // 
            this.lbl_risemode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_risemode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_risemode.ForeColor = System.Drawing.Color.White;
            this.lbl_risemode.Location = new System.Drawing.Point(314, 22);
            this.lbl_risemode.Name = "lbl_risemode";
            this.lbl_risemode.Size = new System.Drawing.Size(432, 64);
            this.lbl_risemode.TabIndex = 6;
            this.lbl_risemode.Text = "MEMÓRIA RAM RISE MODE 16GB 3200MHZ";
            this.lbl_risemode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_memoria
            // 
            this.txt_memoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_memoria.Location = new System.Drawing.Point(572, 128);
            this.txt_memoria.Multiline = true;
            this.txt_memoria.Name = "txt_memoria";
            this.txt_memoria.ReadOnly = true;
            this.txt_memoria.Size = new System.Drawing.Size(382, 349);
            this.txt_memoria.TabIndex = 5;
            this.txt_memoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projeto_CarrinhoGeek.Properties.Resources.Mem_ria_RAM_Rise_Mode_Z_16GB_3200MHz_DDR4_CL19_Branco_RM_D4_16G_3200ZW_1783349620;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(139, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 349);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frm_memoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_CarrinhoGeek.Properties.Resources.rise_mdoe;
            this.ClientSize = new System.Drawing.Size(1130, 607);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_risemode);
            this.Controls.Add(this.txt_memoria);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_memoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_risemode;
        private System.Windows.Forms.TextBox txt_memoria;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}