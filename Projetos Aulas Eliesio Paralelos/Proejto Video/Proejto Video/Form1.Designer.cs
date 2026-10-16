namespace Proejto_Video
{
    partial class frm_video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_video));
            this.pic_guns = new System.Windows.Forms.PictureBox();
            this.pic_mic = new System.Windows.Forms.PictureBox();
            this.pic_slipk = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pic_guns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_slipk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_guns
            // 
            this.pic_guns.BackgroundImage = global::Proejto_Video.Properties.Resources.guns;
            this.pic_guns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_guns.Location = new System.Drawing.Point(12, 230);
            this.pic_guns.Name = "pic_guns";
            this.pic_guns.Size = new System.Drawing.Size(196, 195);
            this.pic_guns.TabIndex = 0;
            this.pic_guns.TabStop = false;
            // 
            // pic_mic
            // 
            this.pic_mic.BackgroundImage = global::Proejto_Video.Properties.Resources.mic;
            this.pic_mic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_mic.Location = new System.Drawing.Point(865, 230);
            this.pic_mic.Name = "pic_mic";
            this.pic_mic.Size = new System.Drawing.Size(217, 187);
            this.pic_mic.TabIndex = 1;
            this.pic_mic.TabStop = false;
            // 
            // pic_slipk
            // 
            this.pic_slipk.BackgroundImage = global::Proejto_Video.Properties.Resources.slipk;
            this.pic_slipk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_slipk.Location = new System.Drawing.Point(391, 12);
            this.pic_slipk.Name = "pic_slipk";
            this.pic_slipk.Size = new System.Drawing.Size(242, 137);
            this.pic_slipk.TabIndex = 2;
            this.pic_slipk.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(220, 155);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(647, 459);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // frm_video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1149, 668);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pic_slipk);
            this.Controls.Add(this.pic_mic);
            this.Controls.Add(this.pic_guns);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proejto Video";
            this.Load += new System.EventHandler(this.frm_video_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_guns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_slipk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_guns;
        private System.Windows.Forms.PictureBox pic_mic;
        private System.Windows.Forms.PictureBox pic_slipk;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

