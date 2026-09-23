namespace Estações
{
    partial class frm_estacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_estacoes));
            this.grp_estacoes = new System.Windows.Forms.GroupBox();
            this.rad_primavera = new System.Windows.Forms.RadioButton();
            this.rad_verao = new System.Windows.Forms.RadioButton();
            this.rad_outono = new System.Windows.Forms.RadioButton();
            this.rad_inverno = new System.Windows.Forms.RadioButton();
            this.pic_estacoes = new System.Windows.Forms.PictureBox();
            this.lbl_informacao = new System.Windows.Forms.Label();
            this.txt_informacao = new System.Windows.Forms.TextBox();
            this.grp_estacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_estacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_estacoes
            // 
            this.grp_estacoes.Controls.Add(this.rad_inverno);
            this.grp_estacoes.Controls.Add(this.rad_outono);
            this.grp_estacoes.Controls.Add(this.rad_verao);
            this.grp_estacoes.Controls.Add(this.rad_primavera);
            this.grp_estacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_estacoes.Location = new System.Drawing.Point(39, 138);
            this.grp_estacoes.Name = "grp_estacoes";
            this.grp_estacoes.Size = new System.Drawing.Size(200, 232);
            this.grp_estacoes.TabIndex = 0;
            this.grp_estacoes.TabStop = false;
            this.grp_estacoes.Text = "Estações";
            this.grp_estacoes.Enter += new System.EventHandler(this.grp_estacoes_Enter);
            // 
            // rad_primavera
            // 
            this.rad_primavera.AutoSize = true;
            this.rad_primavera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_primavera.Location = new System.Drawing.Point(24, 45);
            this.rad_primavera.Name = "rad_primavera";
            this.rad_primavera.Size = new System.Drawing.Size(106, 24);
            this.rad_primavera.TabIndex = 0;
            this.rad_primavera.Text = "Primavera";
            this.rad_primavera.UseVisualStyleBackColor = true;
            this.rad_primavera.CheckedChanged += new System.EventHandler(this.rad_primavera_CheckedChanged);
            // 
            // rad_verao
            // 
            this.rad_verao.AutoSize = true;
            this.rad_verao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_verao.Location = new System.Drawing.Point(24, 69);
            this.rad_verao.Name = "rad_verao";
            this.rad_verao.Size = new System.Drawing.Size(75, 24);
            this.rad_verao.TabIndex = 1;
            this.rad_verao.Text = "Verão";
            this.rad_verao.UseVisualStyleBackColor = true;
            this.rad_verao.CheckedChanged += new System.EventHandler(this.rad_verao_CheckedChanged);
            // 
            // rad_outono
            // 
            this.rad_outono.AutoSize = true;
            this.rad_outono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_outono.Location = new System.Drawing.Point(24, 93);
            this.rad_outono.Name = "rad_outono";
            this.rad_outono.Size = new System.Drawing.Size(86, 24);
            this.rad_outono.TabIndex = 2;
            this.rad_outono.Text = "Outono";
            this.rad_outono.UseVisualStyleBackColor = true;
            this.rad_outono.CheckedChanged += new System.EventHandler(this.rad_outono_CheckedChanged);
            // 
            // rad_inverno
            // 
            this.rad_inverno.AutoSize = true;
            this.rad_inverno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_inverno.Location = new System.Drawing.Point(24, 117);
            this.rad_inverno.Name = "rad_inverno";
            this.rad_inverno.Size = new System.Drawing.Size(87, 24);
            this.rad_inverno.TabIndex = 3;
            this.rad_inverno.Text = "Inverno";
            this.rad_inverno.UseVisualStyleBackColor = true;
            this.rad_inverno.CheckedChanged += new System.EventHandler(this.rad_inverno_CheckedChanged);
            // 
            // pic_estacoes
            // 
            this.pic_estacoes.Location = new System.Drawing.Point(398, 138);
            this.pic_estacoes.Name = "pic_estacoes";
            this.pic_estacoes.Size = new System.Drawing.Size(334, 231);
            this.pic_estacoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_estacoes.TabIndex = 1;
            this.pic_estacoes.TabStop = false;
            // 
            // lbl_informacao
            // 
            this.lbl_informacao.AutoSize = true;
            this.lbl_informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacao.Location = new System.Drawing.Point(398, 71);
            this.lbl_informacao.Name = "lbl_informacao";
            this.lbl_informacao.Size = new System.Drawing.Size(130, 24);
            this.lbl_informacao.TabIndex = 2;
            this.lbl_informacao.Text = "Informações:";
            // 
            // txt_informacao
            // 
            this.txt_informacao.Enabled = false;
            this.txt_informacao.Location = new System.Drawing.Point(535, 74);
            this.txt_informacao.Name = "txt_informacao";
            this.txt_informacao.Size = new System.Drawing.Size(197, 20);
            this.txt_informacao.TabIndex = 3;
            this.txt_informacao.TextChanged += new System.EventHandler(this.txt_informacao_TextChanged);
            // 
            // frm_estacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_informacao);
            this.Controls.Add(this.lbl_informacao);
            this.Controls.Add(this.pic_estacoes);
            this.Controls.Add(this.grp_estacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_estacoes";
            this.Text = "Estações";
            this.grp_estacoes.ResumeLayout(false);
            this.grp_estacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_estacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_estacoes;
        private System.Windows.Forms.RadioButton rad_inverno;
        private System.Windows.Forms.RadioButton rad_outono;
        private System.Windows.Forms.RadioButton rad_verao;
        private System.Windows.Forms.RadioButton rad_primavera;
        private System.Windows.Forms.Label lbl_informacao;
        private System.Windows.Forms.TextBox txt_informacao;
        private System.Windows.Forms.PictureBox pic_estacoes;
    }
}

