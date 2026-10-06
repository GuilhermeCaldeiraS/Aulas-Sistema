namespace Trocar_Forms
{
    partial class frm_primeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_primeiro));
            this.tela2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tela2
            // 
            this.tela2.Location = new System.Drawing.Point(30, 159);
            this.tela2.Name = "tela2";
            this.tela2.Size = new System.Drawing.Size(160, 126);
            this.tela2.TabIndex = 0;
            this.tela2.Text = "Tela 02";
            this.tela2.UseVisualStyleBackColor = true;
            this.tela2.Click += new System.EventHandler(this.tela2_Click);
            // 
            // frm_primeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trocar_Forms.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tela2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_primeiro";
            this.Text = "Primeiro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_primeiro_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tela2;
    }
}

