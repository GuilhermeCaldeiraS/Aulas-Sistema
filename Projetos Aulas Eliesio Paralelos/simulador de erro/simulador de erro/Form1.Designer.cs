namespace simulador_de_erro
{
    partial class Form1
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
            this.lblgui = new System.Windows.Forms.Label();
            this.btn_pagode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgui
            // 
            this.lblgui.AutoSize = true;
            this.lblgui.Location = new System.Drawing.Point(294, 115);
            this.lblgui.Name = "lblgui";
            this.lblgui.Size = new System.Drawing.Size(35, 13);
            this.lblgui.TabIndex = 0;
            this.lblgui.Text = "label1";
            this.lblgui.Click += new System.EventHandler(this.lblgui_Click);
            // 
            // btn_pagode
            // 
            this.btn_pagode.Location = new System.Drawing.Point(414, 179);
            this.btn_pagode.Name = "btn_pagode";
            this.btn_pagode.Size = new System.Drawing.Size(75, 23);
            this.btn_pagode.TabIndex = 1;
            this.btn_pagode.Text = "button1";
            this.btn_pagode.UseVisualStyleBackColor = true;
            this.btn_pagode.Click += new System.EventHandler(this.btn_pagode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pagode);
            this.Controls.Add(this.lblgui);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgui;
        private System.Windows.Forms.Button btn_pagode;
    }
}

