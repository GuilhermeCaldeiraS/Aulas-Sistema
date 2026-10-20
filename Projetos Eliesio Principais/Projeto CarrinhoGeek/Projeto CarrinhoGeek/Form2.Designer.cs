namespace Projeto_CarrinhoGeek
{
    partial class frm_xpg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_xpg));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_xpgcore = new System.Windows.Forms.TextBox();
            this.pic_xpg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_xpg)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.Black;
            this.btn_voltar.Location = new System.Drawing.Point(95, 505);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(111, 50);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "VOLTAR AO INICIO";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "FONTE XPG CORE 850W";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_xpgcore
            // 
            this.txt_xpgcore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xpgcore.Location = new System.Drawing.Point(539, 101);
            this.txt_xpgcore.Multiline = true;
            this.txt_xpgcore.Name = "txt_xpgcore";
            this.txt_xpgcore.ReadOnly = true;
            this.txt_xpgcore.Size = new System.Drawing.Size(341, 336);
            this.txt_xpgcore.TabIndex = 5;
            this.txt_xpgcore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_xpgcore.TextChanged += new System.EventHandler(this.txt_xpgcore_TextChanged);
            // 
            // pic_xpg
            // 
            this.pic_xpg.BackgroundImage = global::Projeto_CarrinhoGeek.Properties.Resources.fonte_xpg_core_reactor_ii_ve_850w_75261436_1721238617_gg;
            this.pic_xpg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_xpg.Location = new System.Drawing.Point(184, 101);
            this.pic_xpg.Name = "pic_xpg";
            this.pic_xpg.Size = new System.Drawing.Size(325, 336);
            this.pic_xpg.TabIndex = 4;
            this.pic_xpg.TabStop = false;
            // 
            // frm_xpg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_CarrinhoGeek.Properties.Resources.xpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 607);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_xpgcore);
            this.Controls.Add(this.pic_xpg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_xpg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pic_xpg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_xpgcore;
        private System.Windows.Forms.PictureBox pic_xpg;
    }
}