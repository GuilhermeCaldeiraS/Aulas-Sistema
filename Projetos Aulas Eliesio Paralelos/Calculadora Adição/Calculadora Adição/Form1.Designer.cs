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
            this.lbl_calculador.Location = new System.Drawing.Point(78, 23);
            this.lbl_calculador.Name = "lbl_calculador";
            this.lbl_calculador.Size = new System.Drawing.Size(622, 67);
            this.lbl_calculador.TabIndex = 0;
            this.lbl_calculador.Text = "CALCULADOR +";
            this.lbl_calculador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_mat1
            // 
            this.pic_mat1.Image = global::Calculadora_Adição.Properties.Resources.calculadora;
            this.pic_mat1.Location = new System.Drawing.Point(12, 165);
            this.pic_mat1.Name = "pic_mat1";
            this.pic_mat1.Size = new System.Drawing.Size(164, 204);
            this.pic_mat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mat1.TabIndex = 1;
            this.pic_mat1.TabStop = false;
            // 
            // pic_mat2
            // 
            this.pic_mat2.Image = global::Calculadora_Adição.Properties.Resources.calculadora_2;
            this.pic_mat2.Location = new System.Drawing.Point(620, 165);
            this.pic_mat2.Name = "pic_mat2";
            this.pic_mat2.Size = new System.Drawing.Size(168, 204);
            this.pic_mat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mat2.TabIndex = 2;
            this.pic_mat2.TabStop = false;
            // 
            // lbl_primeiroN
            // 
            this.lbl_primeiroN.AutoSize = true;
            this.lbl_primeiroN.Location = new System.Drawing.Point(252, 165);
            this.lbl_primeiroN.Name = "lbl_primeiroN";
            this.lbl_primeiroN.Size = new System.Drawing.Size(75, 13);
            this.lbl_primeiroN.TabIndex = 3;
            this.lbl_primeiroN.Text = "PRIMEIRO Nº";
            // 
            // lbl_segundoN
            // 
            this.lbl_segundoN.AutoSize = true;
            this.lbl_segundoN.Location = new System.Drawing.Point(252, 225);
            this.lbl_segundoN.Name = "lbl_segundoN";
            this.lbl_segundoN.Size = new System.Drawing.Size(76, 13);
            this.lbl_segundoN.TabIndex = 4;
            this.lbl_segundoN.Text = "SEGUNDO Nº";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(400, 346);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(99, 23);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(255, 257);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(104, 23);
            this.btn_soma.TabIndex = 6;
            this.btn_soma.Text = "SOMA";
            this.btn_soma.UseVisualStyleBackColor = true;
            // 
            // btn_subtração
            // 
            this.btn_subtração.Location = new System.Drawing.Point(371, 257);
            this.btn_subtração.Name = "btn_subtração";
            this.btn_subtração.Size = new System.Drawing.Size(128, 23);
            this.btn_subtração.TabIndex = 7;
            this.btn_subtração.Text = "SUBTRAÇÃO";
            this.btn_subtração.UseVisualStyleBackColor = true;
            // 
            // btn_divisao
            // 
            this.btn_divisao.Location = new System.Drawing.Point(255, 286);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(104, 23);
            this.btn_divisao.TabIndex = 8;
            this.btn_divisao.Text = "DIVISÃO";
            this.btn_divisao.UseVisualStyleBackColor = true;
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Location = new System.Drawing.Point(383, 285);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(116, 23);
            this.btn_multiplicacao.TabIndex = 9;
            this.btn_multiplicacao.Text = "MULTIPLICAÇÃO";
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            // 
            // txt_primeiroN
            // 
            this.txt_primeiroN.Location = new System.Drawing.Point(333, 158);
            this.txt_primeiroN.Name = "txt_primeiroN";
            this.txt_primeiroN.Size = new System.Drawing.Size(124, 20);
            this.txt_primeiroN.TabIndex = 10;
            // 
            // txt_segundoN
            // 
            this.txt_segundoN.Location = new System.Drawing.Point(333, 222);
            this.txt_segundoN.Name = "txt_segundoN";
            this.txt_segundoN.Size = new System.Drawing.Size(124, 20);
            this.txt_segundoN.TabIndex = 11;
            // 
            // frm_calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

