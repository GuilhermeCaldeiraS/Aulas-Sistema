namespace Calculadora_Adição
{
    partial class frm_calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_calculadora));
            this.lbl_calculador = new System.Windows.Forms.Label();
            this.pic_mat1 = new System.Windows.Forms.PictureBox();
            this.pic_mat2 = new System.Windows.Forms.PictureBox();
            this.lbl_primeiroN = new System.Windows.Forms.Label();
            this.lbl_segundoN = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_subtração = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.txt_primeiroN = new System.Windows.Forms.TextBox();
            this.txt_segundoN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mat2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_calculador
            // 
            this.lbl_calculador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_calculador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calculador.Location = new System.Drawing.Point(2, 23);
            this.lbl_calculador.Name = "lbl_calculador";
            this.lbl_calculador.Size = new System.Drawing.Size(799, 67);
            this.lbl_calculador.TabIndex = 0;
            this.lbl_calculador.Text = "CALCULADOR +";
            this.lbl_calculador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_mat1
            // 
            this.pic_mat1.Image = global::Calculadora_Adição.Properties.Resources.calculadora;
            this.pic_mat1.Location = new System.Drawing.Point(38, 93);
            this.pic_mat1.Name = "pic_mat1";
            this.pic_mat1.Size = new System.Drawing.Size(164, 204);
            this.pic_mat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mat1.TabIndex = 1;
            this.pic_mat1.TabStop = false;
            // 
            // pic_mat2
            // 
            this.pic_mat2.Image = global::Calculadora_Adição.Properties.Resources.calculadora_2;
            this.pic_mat2.Location = new System.Drawing.Point(602, 234);
            this.pic_mat2.Name = "pic_mat2";
            this.pic_mat2.Size = new System.Drawing.Size(168, 204);
            this.pic_mat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mat2.TabIndex = 2;
            this.pic_mat2.TabStop = false;
            // 
            // lbl_primeiroN
            // 
            this.lbl_primeiroN.AutoSize = true;
            this.lbl_primeiroN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primeiroN.Location = new System.Drawing.Point(242, 124);
            this.lbl_primeiroN.Name = "lbl_primeiroN";
            this.lbl_primeiroN.Size = new System.Drawing.Size(112, 18);
            this.lbl_primeiroN.TabIndex = 3;
            this.lbl_primeiroN.Text = "PRIMEIRO Nº";
            // 
            // lbl_segundoN
            // 
            this.lbl_segundoN.AutoSize = true;
            this.lbl_segundoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segundoN.Location = new System.Drawing.Point(239, 188);
            this.lbl_segundoN.Name = "lbl_segundoN";
            this.lbl_segundoN.Size = new System.Drawing.Size(115, 18);
            this.lbl_segundoN.TabIndex = 4;
            this.lbl_segundoN.Text = "SEGUNDO Nº";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_limpar.Location = new System.Drawing.Point(389, 325);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(129, 32);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soma.Location = new System.Drawing.Point(250, 234);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(104, 23);
            this.btn_soma.TabIndex = 6;
            this.btn_soma.Text = "SOMA";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_subtração
            // 
            this.btn_subtração.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtração.Location = new System.Drawing.Point(390, 234);
            this.btn_subtração.Name = "btn_subtração";
            this.btn_subtração.Size = new System.Drawing.Size(128, 23);
            this.btn_subtração.TabIndex = 7;
            this.btn_subtração.Text = "SUBTRAÇÃO";
            this.btn_subtração.UseVisualStyleBackColor = true;
            this.btn_subtração.Click += new System.EventHandler(this.btn_subtração_Click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divisao.Location = new System.Drawing.Point(218, 263);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(104, 23);
            this.btn_divisao.TabIndex = 8;
            this.btn_divisao.Text = "DIVISÃO";
            this.btn_divisao.UseVisualStyleBackColor = true;
            this.btn_divisao.Click += new System.EventHandler(this.btn_divisao_Click);
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicacao.Location = new System.Drawing.Point(355, 263);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(139, 23);
            this.btn_multiplicacao.TabIndex = 9;
            this.btn_multiplicacao.Text = "MULTIPLICAÇÃO";
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            this.btn_multiplicacao.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // txt_primeiroN
            // 
            this.txt_primeiroN.Location = new System.Drawing.Point(360, 122);
            this.txt_primeiroN.Name = "txt_primeiroN";
            this.txt_primeiroN.Size = new System.Drawing.Size(124, 20);
            this.txt_primeiroN.TabIndex = 10;
            this.txt_primeiroN.TextChanged += new System.EventHandler(this.txt_primeiroN_TextChanged);
            // 
            // txt_segundoN
            // 
            this.txt_segundoN.Location = new System.Drawing.Point(360, 186);
            this.txt_segundoN.Name = "txt_segundoN";
            this.txt_segundoN.Size = new System.Drawing.Size(124, 20);
            this.txt_segundoN.TabIndex = 11;
            // 
            // frm_calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.txt_segundoN);
            this.Controls.Add(this.txt_primeiroN);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_subtração);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_segundoN);
            this.Controls.Add(this.lbl_primeiroN);
            this.Controls.Add(this.pic_mat2);
            this.Controls.Add(this.pic_mat1);
            this.Controls.Add(this.lbl_calculador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Adição";
            ((System.ComponentModel.ISupportInitialize)(this.pic_mat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mat2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_calculador;
        private System.Windows.Forms.PictureBox pic_mat1;
        private System.Windows.Forms.PictureBox pic_mat2;
        private System.Windows.Forms.Label lbl_primeiroN;
        private System.Windows.Forms.Label lbl_segundoN;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_subtração;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.TextBox txt_primeiroN;
        private System.Windows.Forms.TextBox txt_segundoN;
    }
}

