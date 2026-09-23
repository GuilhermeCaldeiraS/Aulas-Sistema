namespace Paralelo_Estações
{
    partial class Frm_ParaleloEstações
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
            this.pic_Primeiro = new System.Windows.Forms.PictureBox();
            this.rad_Primeiro = new System.Windows.Forms.RadioButton();
            this.txt_Primeiro = new System.Windows.Forms.TextBox();
            this.lbl_informacao = new System.Windows.Forms.Label();
            this.rad_segundo = new System.Windows.Forms.RadioButton();
            this.rad_terceiro = new System.Windows.Forms.RadioButton();
            this.rad_quarto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Primeiro)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Primeiro
            // 
            this.pic_Primeiro.Location = new System.Drawing.Point(370, 74);
            this.pic_Primeiro.Name = "pic_Primeiro";
            this.pic_Primeiro.Size = new System.Drawing.Size(609, 523);
            this.pic_Primeiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Primeiro.TabIndex = 0;
            this.pic_Primeiro.TabStop = false;
            this.pic_Primeiro.Click += new System.EventHandler(this.pic_Primeiro_Click);
            // 
            // rad_Primeiro
            // 
            this.rad_Primeiro.AutoSize = true;
            this.rad_Primeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Primeiro.Location = new System.Drawing.Point(127, 140);
            this.rad_Primeiro.Name = "rad_Primeiro";
            this.rad_Primeiro.Size = new System.Drawing.Size(106, 28);
            this.rad_Primeiro.TabIndex = 1;
            this.rad_Primeiro.Text = "Primeiro";
            this.rad_Primeiro.UseVisualStyleBackColor = true;
            this.rad_Primeiro.CheckedChanged += new System.EventHandler(this.rad_Primeiro_CheckedChanged);
            // 
            // txt_Primeiro
            // 
            this.txt_Primeiro.Enabled = false;
            this.txt_Primeiro.Location = new System.Drawing.Point(529, 38);
            this.txt_Primeiro.Name = "txt_Primeiro";
            this.txt_Primeiro.Size = new System.Drawing.Size(312, 20);
            this.txt_Primeiro.TabIndex = 2;
            this.txt_Primeiro.TextChanged += new System.EventHandler(this.txt_Primeiro_TextChanged);
            // 
            // lbl_informacao
            // 
            this.lbl_informacao.AutoSize = true;
            this.lbl_informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacao.Location = new System.Drawing.Point(393, 33);
            this.lbl_informacao.Name = "lbl_informacao";
            this.lbl_informacao.Size = new System.Drawing.Size(130, 24);
            this.lbl_informacao.TabIndex = 3;
            this.lbl_informacao.Text = "Informações:";
            // 
            // rad_segundo
            // 
            this.rad_segundo.AutoSize = true;
            this.rad_segundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_segundo.Location = new System.Drawing.Point(127, 185);
            this.rad_segundo.Name = "rad_segundo";
            this.rad_segundo.Size = new System.Drawing.Size(113, 28);
            this.rad_segundo.TabIndex = 4;
            this.rad_segundo.TabStop = true;
            this.rad_segundo.Text = "Segundo";
            this.rad_segundo.UseVisualStyleBackColor = true;
            this.rad_segundo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rad_terceiro
            // 
            this.rad_terceiro.AutoSize = true;
            this.rad_terceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_terceiro.Location = new System.Drawing.Point(127, 231);
            this.rad_terceiro.Name = "rad_terceiro";
            this.rad_terceiro.Size = new System.Drawing.Size(107, 28);
            this.rad_terceiro.TabIndex = 5;
            this.rad_terceiro.TabStop = true;
            this.rad_terceiro.Text = "Terceiro";
            this.rad_terceiro.UseVisualStyleBackColor = true;
            this.rad_terceiro.CheckedChanged += new System.EventHandler(this.rad_terceiro_CheckedChanged);
            // 
            // rad_quarto
            // 
            this.rad_quarto.AutoSize = true;
            this.rad_quarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_quarto.Location = new System.Drawing.Point(127, 269);
            this.rad_quarto.Name = "rad_quarto";
            this.rad_quarto.Size = new System.Drawing.Size(91, 28);
            this.rad_quarto.TabIndex = 6;
            this.rad_quarto.TabStop = true;
            this.rad_quarto.Text = "Quarto";
            this.rad_quarto.UseVisualStyleBackColor = true;
            // 
            // Frm_ParaleloEstações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 625);
            this.Controls.Add(this.rad_quarto);
            this.Controls.Add(this.rad_terceiro);
            this.Controls.Add(this.rad_segundo);
            this.Controls.Add(this.lbl_informacao);
            this.Controls.Add(this.txt_Primeiro);
            this.Controls.Add(this.rad_Primeiro);
            this.Controls.Add(this.pic_Primeiro);
            this.Name = "Frm_ParaleloEstações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParaleloEstações";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Primeiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Primeiro;
        private System.Windows.Forms.RadioButton rad_Primeiro;
        private System.Windows.Forms.TextBox txt_Primeiro;
        private System.Windows.Forms.Label lbl_informacao;
        private System.Windows.Forms.RadioButton rad_segundo;
        private System.Windows.Forms.RadioButton rad_terceiro;
        private System.Windows.Forms.RadioButton rad_quarto;
    }
}

