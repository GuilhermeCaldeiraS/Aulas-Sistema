namespace PROJETO_MATEMÁTICA
{
    partial class frm_matematica
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
            this.lbl_projetos = new System.Windows.Forms.Label();
            this.rad_dobro = new System.Windows.Forms.RadioButton();
            this.rad_parimpar = new System.Windows.Forms.RadioButton();
            this.rad_positivoNN = new System.Windows.Forms.RadioButton();
            this.rad_positivo = new System.Windows.Forms.RadioButton();
            this.rad_op = new System.Windows.Forms.RadioButton();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_projetos
            // 
            this.lbl_projetos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_projetos.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_projetos.Location = new System.Drawing.Point(-4, -4);
            this.lbl_projetos.Name = "lbl_projetos";
            this.lbl_projetos.Size = new System.Drawing.Size(808, 79);
            this.lbl_projetos.TabIndex = 0;
            this.lbl_projetos.Text = "PROJETOS";
            this.lbl_projetos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rad_dobro
            // 
            this.rad_dobro.BackColor = System.Drawing.Color.Transparent;
            this.rad_dobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_dobro.ForeColor = System.Drawing.Color.Red;
            this.rad_dobro.Location = new System.Drawing.Point(222, 123);
            this.rad_dobro.Name = "rad_dobro";
            this.rad_dobro.Size = new System.Drawing.Size(112, 31);
            this.rad_dobro.TabIndex = 1;
            this.rad_dobro.TabStop = true;
            this.rad_dobro.Text = "DOBRO";
            this.rad_dobro.UseVisualStyleBackColor = false;
            // 
            // rad_parimpar
            // 
            this.rad_parimpar.BackColor = System.Drawing.Color.Transparent;
            this.rad_parimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_parimpar.ForeColor = System.Drawing.Color.DarkOrange;
            this.rad_parimpar.Location = new System.Drawing.Point(222, 160);
            this.rad_parimpar.Name = "rad_parimpar";
            this.rad_parimpar.Size = new System.Drawing.Size(401, 24);
            this.rad_parimpar.TabIndex = 2;
            this.rad_parimpar.TabStop = true;
            this.rad_parimpar.Text = "PAR OU IMPAR";
            this.rad_parimpar.UseVisualStyleBackColor = false;
            // 
            // rad_positivoNN
            // 
            this.rad_positivoNN.BackColor = System.Drawing.Color.Transparent;
            this.rad_positivoNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_positivoNN.ForeColor = System.Drawing.Color.DarkViolet;
            this.rad_positivoNN.Location = new System.Drawing.Point(222, 197);
            this.rad_positivoNN.Name = "rad_positivoNN";
            this.rad_positivoNN.Size = new System.Drawing.Size(499, 24);
            this.rad_positivoNN.TabIndex = 3;
            this.rad_positivoNN.TabStop = true;
            this.rad_positivoNN.Text = "ANTECESSOR OU SUCESSOR";
            this.rad_positivoNN.UseVisualStyleBackColor = false;
            // 
            // rad_positivo
            // 
            this.rad_positivo.BackColor = System.Drawing.Color.Transparent;
            this.rad_positivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_positivo.ForeColor = System.Drawing.Color.Green;
            this.rad_positivo.Location = new System.Drawing.Point(222, 238);
            this.rad_positivo.Name = "rad_positivo";
            this.rad_positivo.Size = new System.Drawing.Size(401, 24);
            this.rad_positivo.TabIndex = 4;
            this.rad_positivo.TabStop = true;
            this.rad_positivo.Text = "POSITIVO, NEGATIVO OU NEUTRO";
            this.rad_positivo.UseVisualStyleBackColor = false;
            // 
            // rad_op
            // 
            this.rad_op.BackColor = System.Drawing.Color.Transparent;
            this.rad_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_op.ForeColor = System.Drawing.Color.Blue;
            this.rad_op.Location = new System.Drawing.Point(222, 268);
            this.rad_op.Name = "rad_op";
            this.rad_op.Size = new System.Drawing.Size(401, 24);
            this.rad_op.TabIndex = 5;
            this.rad_op.TabStop = true;
            this.rad_op.Text = "OPERAÇÕES ARITMETICAS";
            this.rad_op.UseVisualStyleBackColor = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.Transparent_X;
            this.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fechar.Location = new System.Drawing.Point(687, 12);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(80, 44);
            this.btn_fechar.TabIndex = 6;
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // frm_matematica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJETO_MATEMÁTICA.Properties.Resources.lousa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.rad_op);
            this.Controls.Add(this.rad_positivo);
            this.Controls.Add(this.rad_positivoNN);
            this.Controls.Add(this.rad_parimpar);
            this.Controls.Add(this.rad_dobro);
            this.Controls.Add(this.lbl_projetos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_matematica";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_projetos;
        private System.Windows.Forms.RadioButton rad_dobro;
        private System.Windows.Forms.RadioButton rad_parimpar;
        private System.Windows.Forms.RadioButton rad_positivoNN;
        private System.Windows.Forms.RadioButton rad_positivo;
        private System.Windows.Forms.RadioButton rad_op;
        private System.Windows.Forms.Button btn_fechar;
    }
}

