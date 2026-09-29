namespace PROJETOS_OPERADORAS
{
    partial class frm_op
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_op));
            this.lbl_dadosR = new System.Windows.Forms.Label();
            this.grp_op = new System.Windows.Forms.GroupBox();
            this.rad_Vivo = new System.Windows.Forms.RadioButton();
            this.rad_Claro = new System.Windows.Forms.RadioButton();
            this.rad_Tim = new System.Windows.Forms.RadioButton();
            this.rad_Oi = new System.Windows.Forms.RadioButton();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_opSelec = new System.Windows.Forms.TextBox();
            this.txt_DDD = new System.Windows.Forms.TextBox();
            this.txt_NumCell = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_BemVindo = new System.Windows.Forms.Label();
            this.lbl_operadoraS = new System.Windows.Forms.Label();
            this.lbl_DDD = new System.Windows.Forms.Label();
            this.lbl_NumeroDoC = new System.Windows.Forms.Label();
            this.lbl_ValorDaRec = new System.Windows.Forms.Label();
            this.lbl_SelecioneoV = new System.Windows.Forms.Label();
            this.btn_Recarga20 = new System.Windows.Forms.Button();
            this.btn_Recarga30 = new System.Windows.Forms.Button();
            this.btn_Recarga35 = new System.Windows.Forms.Button();
            this.btn_Recarga40 = new System.Windows.Forms.Button();
            this.btn_Recarga45 = new System.Windows.Forms.Button();
            this.btn_Recarga50 = new System.Windows.Forms.Button();
            this.btn_Recarga55 = new System.Windows.Forms.Button();
            this.btn_Recarga100 = new System.Windows.Forms.Button();
            this.lbl_Validade = new System.Windows.Forms.Label();
            this.lbl_Validade2 = new System.Windows.Forms.Label();
            this.lbl_Validade3 = new System.Windows.Forms.Label();
            this.lbl_Validade4 = new System.Windows.Forms.Label();
            this.lbl_Validade5 = new System.Windows.Forms.Label();
            this.lbl_Validade6 = new System.Windows.Forms.Label();
            this.lbl_Validade7 = new System.Windows.Forms.Label();
            this.lbl_Validade8 = new System.Windows.Forms.Label();
            this.pic_telefone = new System.Windows.Forms.PictureBox();
            this.grp_op.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_telefone)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dadosR
            // 
            this.lbl_dadosR.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_dadosR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dadosR.Location = new System.Drawing.Point(106, 54);
            this.lbl_dadosR.Name = "lbl_dadosR";
            this.lbl_dadosR.Size = new System.Drawing.Size(603, 37);
            this.lbl_dadosR.TabIndex = 0;
            this.lbl_dadosR.Text = "Dados da Recarga";
            this.lbl_dadosR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_op
            // 
            this.grp_op.BackColor = System.Drawing.Color.Transparent;
            this.grp_op.Controls.Add(this.rad_Oi);
            this.grp_op.Controls.Add(this.rad_Tim);
            this.grp_op.Controls.Add(this.rad_Claro);
            this.grp_op.Controls.Add(this.rad_Vivo);
            this.grp_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_op.Location = new System.Drawing.Point(12, 135);
            this.grp_op.Name = "grp_op";
            this.grp_op.Size = new System.Drawing.Size(200, 237);
            this.grp_op.TabIndex = 1;
            this.grp_op.TabStop = false;
            this.grp_op.Text = "OPERADORAS";
            this.grp_op.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rad_Vivo
            // 
            this.rad_Vivo.AutoSize = true;
            this.rad_Vivo.Location = new System.Drawing.Point(24, 51);
            this.rad_Vivo.Name = "rad_Vivo";
            this.rad_Vivo.Size = new System.Drawing.Size(69, 28);
            this.rad_Vivo.TabIndex = 0;
            this.rad_Vivo.Text = "Vivo";
            this.rad_Vivo.UseVisualStyleBackColor = true;
            this.rad_Vivo.CheckedChanged += new System.EventHandler(this.rad_Vivo_CheckedChanged);
            // 
            // rad_Claro
            // 
            this.rad_Claro.AutoSize = true;
            this.rad_Claro.Location = new System.Drawing.Point(24, 86);
            this.rad_Claro.Name = "rad_Claro";
            this.rad_Claro.Size = new System.Drawing.Size(77, 28);
            this.rad_Claro.TabIndex = 1;
            this.rad_Claro.Text = "Claro";
            this.rad_Claro.UseVisualStyleBackColor = true;
            this.rad_Claro.CheckedChanged += new System.EventHandler(this.rad_Claro_CheckedChanged);
            // 
            // rad_Tim
            // 
            this.rad_Tim.AutoSize = true;
            this.rad_Tim.Location = new System.Drawing.Point(24, 121);
            this.rad_Tim.Name = "rad_Tim";
            this.rad_Tim.Size = new System.Drawing.Size(63, 28);
            this.rad_Tim.TabIndex = 2;
            this.rad_Tim.Text = "Tim";
            this.rad_Tim.UseVisualStyleBackColor = true;
            this.rad_Tim.CheckedChanged += new System.EventHandler(this.rad_Tim_CheckedChanged);
            // 
            // rad_Oi
            // 
            this.rad_Oi.AutoSize = true;
            this.rad_Oi.Location = new System.Drawing.Point(24, 156);
            this.rad_Oi.Name = "rad_Oi";
            this.rad_Oi.Size = new System.Drawing.Size(49, 28);
            this.rad_Oi.TabIndex = 3;
            this.rad_Oi.Text = "Oi";
            this.rad_Oi.UseVisualStyleBackColor = true;
            this.rad_Oi.CheckedChanged += new System.EventHandler(this.rad_Oi_CheckedChanged);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Enabled = false;
            this.txt_Nome.Location = new System.Drawing.Point(393, 150);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(351, 20);
            this.txt_Nome.TabIndex = 2;
            // 
            // txt_opSelec
            // 
            this.txt_opSelec.Enabled = false;
            this.txt_opSelec.Location = new System.Drawing.Point(393, 218);
            this.txt_opSelec.Name = "txt_opSelec";
            this.txt_opSelec.Size = new System.Drawing.Size(215, 20);
            this.txt_opSelec.TabIndex = 3;
            this.txt_opSelec.TextChanged += new System.EventHandler(this.txt_opSelec_TextChanged);
            // 
            // txt_DDD
            // 
            this.txt_DDD.Enabled = false;
            this.txt_DDD.Location = new System.Drawing.Point(391, 274);
            this.txt_DDD.Name = "txt_DDD";
            this.txt_DDD.Size = new System.Drawing.Size(52, 20);
            this.txt_DDD.TabIndex = 4;
            // 
            // txt_NumCell
            // 
            this.txt_NumCell.Enabled = false;
            this.txt_NumCell.Location = new System.Drawing.Point(469, 274);
            this.txt_NumCell.Name = "txt_NumCell";
            this.txt_NumCell.Size = new System.Drawing.Size(129, 20);
            this.txt_NumCell.TabIndex = 5;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Enabled = false;
            this.txt_Valor.Location = new System.Drawing.Point(634, 274);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(110, 20);
            this.txt_Valor.TabIndex = 6;
            this.txt_Valor.TextChanged += new System.EventHandler(this.txt_Valor_TextChanged);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Enabled = false;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(390, 129);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(53, 18);
            this.lbl_Nome.TabIndex = 7;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_BemVindo
            // 
            this.lbl_BemVindo.AutoSize = true;
            this.lbl_BemVindo.Enabled = false;
            this.lbl_BemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BemVindo.Location = new System.Drawing.Point(239, 151);
            this.lbl_BemVindo.Name = "lbl_BemVindo";
            this.lbl_BemVindo.Size = new System.Drawing.Size(141, 16);
            this.lbl_BemVindo.TabIndex = 8;
            this.lbl_BemVindo.Text = "Seja Bem Vindo(a):";
            // 
            // lbl_operadoraS
            // 
            this.lbl_operadoraS.AutoSize = true;
            this.lbl_operadoraS.Enabled = false;
            this.lbl_operadoraS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operadoraS.Location = new System.Drawing.Point(390, 202);
            this.lbl_operadoraS.Name = "lbl_operadoraS";
            this.lbl_operadoraS.Size = new System.Drawing.Size(174, 16);
            this.lbl_operadoraS.TabIndex = 9;
            this.lbl_operadoraS.Text = "Operadora Selecionada";
            // 
            // lbl_DDD
            // 
            this.lbl_DDD.AutoSize = true;
            this.lbl_DDD.Enabled = false;
            this.lbl_DDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DDD.Location = new System.Drawing.Point(390, 256);
            this.lbl_DDD.Name = "lbl_DDD";
            this.lbl_DDD.Size = new System.Drawing.Size(40, 16);
            this.lbl_DDD.TabIndex = 10;
            this.lbl_DDD.Text = "DDD";
            // 
            // lbl_NumeroDoC
            // 
            this.lbl_NumeroDoC.AutoSize = true;
            this.lbl_NumeroDoC.Enabled = false;
            this.lbl_NumeroDoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroDoC.Location = new System.Drawing.Point(466, 256);
            this.lbl_NumeroDoC.Name = "lbl_NumeroDoC";
            this.lbl_NumeroDoC.Size = new System.Drawing.Size(136, 16);
            this.lbl_NumeroDoC.TabIndex = 11;
            this.lbl_NumeroDoC.Text = "Número do Celular";
            // 
            // lbl_ValorDaRec
            // 
            this.lbl_ValorDaRec.AutoSize = true;
            this.lbl_ValorDaRec.Enabled = false;
            this.lbl_ValorDaRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorDaRec.Location = new System.Drawing.Point(631, 256);
            this.lbl_ValorDaRec.Name = "lbl_ValorDaRec";
            this.lbl_ValorDaRec.Size = new System.Drawing.Size(130, 16);
            this.lbl_ValorDaRec.TabIndex = 12;
            this.lbl_ValorDaRec.Text = "Valor da Recarga";
            // 
            // lbl_SelecioneoV
            // 
            this.lbl_SelecioneoV.AutoSize = true;
            this.lbl_SelecioneoV.Enabled = false;
            this.lbl_SelecioneoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelecioneoV.Location = new System.Drawing.Point(456, 342);
            this.lbl_SelecioneoV.Name = "lbl_SelecioneoV";
            this.lbl_SelecioneoV.Size = new System.Drawing.Size(217, 16);
            this.lbl_SelecioneoV.TabIndex = 13;
            this.lbl_SelecioneoV.Text = "Selecione o Valor da Recarga";
            // 
            // btn_Recarga20
            // 
            this.btn_Recarga20.BackColor = System.Drawing.Color.Transparent;
            this.btn_Recarga20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Recarga20.Enabled = false;
            this.btn_Recarga20.Location = new System.Drawing.Point(408, 371);
            this.btn_Recarga20.Name = "btn_Recarga20";
            this.btn_Recarga20.Size = new System.Drawing.Size(75, 74);
            this.btn_Recarga20.TabIndex = 14;
            this.btn_Recarga20.Text = "R$";
            this.btn_Recarga20.UseVisualStyleBackColor = false;
            this.btn_Recarga20.Click += new System.EventHandler(this.btn_Recarga20_Click);
            // 
            // btn_Recarga30
            // 
            this.btn_Recarga30.BackColor = System.Drawing.Color.Transparent;
            this.btn_Recarga30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Recarga30.Enabled = false;
            this.btn_Recarga30.Location = new System.Drawing.Point(489, 371);
            this.btn_Recarga30.Name = "btn_Recarga30";
            this.btn_Recarga30.Size = new System.Drawing.Size(75, 74);
            this.btn_Recarga30.TabIndex = 15;
            this.btn_Recarga30.Text = "R$ ";
            this.btn_Recarga30.UseVisualStyleBackColor = false;
            this.btn_Recarga30.Click += new System.EventHandler(this.btn_Recarga30_Click);
            // 
            // btn_Recarga35
            // 
            this.btn_Recarga35.BackColor = System.Drawing.Color.Transparent;
            this.btn_Recarga35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Recarga35.Enabled = false;
            this.btn_Recarga35.Location = new System.Drawing.Point(598, 371);
            this.btn_Recarga35.Name = "btn_Recarga35";
            this.btn_Recarga35.Size = new System.Drawing.Size(75, 74);
            this.btn_Recarga35.TabIndex = 16;
            this.btn_Recarga35.Text = "R$ ";
            this.btn_Recarga35.UseVisualStyleBackColor = false;
            this.btn_Recarga35.Click += new System.EventHandler(this.btn_Recarga35_Click);
            // 
            // btn_Recarga40
            // 
            this.btn_Recarga40.BackColor = System.Drawing.Color.Transparent;
            this.btn_Recarga40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Recarga40.Enabled = false;
            this.btn_Recarga40.Location = new System.Drawing.Point(686, 371);
            this.btn_Recarga40.Name = "btn_Recarga40";
            this.btn_Recarga40.Size = new System.Drawing.Size(75, 74);
            this.btn_Recarga40.TabIndex = 17;
            this.btn_Recarga40.Text = "R$ ";
            this.btn_Recarga40.UseVisualStyleBackColor = false;
            this.btn_Recarga40.Click += new System.EventHandler(this.btn_Recarga40_Click);
            // 
            // btn_Recarga45
            // 
            this.btn_Recarga45.BackColor = System.Drawing.Color.Transparent;
            this.btn_Recarga45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Recarga45.Enabled = false;
            this.btn_Recarga45.Location = new System.Drawing.Point(408, 479);
            this.btn_Recarga45.Name = "btn_Recarga45";
            this.btn_Recarga45.Size = new System.Drawing.Size(75, 74);
            this.btn_Recarga45.TabIndex = 18;
            this.btn_Recarga45.Text = "R$ ";
            this.btn_Recarga45.UseVisualStyleBackColor = false;
            this.btn_Recarga45.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Recarga50
            // 
            this.btn_Recarga50.BackColor = System.Drawing.Color.Transparent;
            this.btn_Recarga50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Recarga50.Enabled = false;
            this.btn_Recarga50.Location = new System.Drawing.Point(489, 479);
            this.btn_Recarga50.Name = "btn_Recarga50";
            this.btn_Recarga50.Size = new System.Drawing.Size(75, 74);
            this.btn_Recarga50.TabIndex = 19;
            this.btn_Recarga50.Text = "R$ ";
            this.btn_Recarga50.UseVisualStyleBackColor = false;
            this.btn_Recarga50.Click += new System.EventHandler(this.btn_Recarga50_Click);
            // 
            // btn_Recarga55
            // 
            this.btn_Recarga55.BackColor = System.Drawing.Color.Transparent;
            this.btn_Recarga55.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Recarga55.Enabled = false;
            this.btn_Recarga55.Location = new System.Drawing.Point(598, 479);
            this.btn_Recarga55.Name = "btn_Recarga55";
            this.btn_Recarga55.Size = new System.Drawing.Size(75, 74);
            this.btn_Recarga55.TabIndex = 20;
            this.btn_Recarga55.Text = "R$ ";
            this.btn_Recarga55.UseVisualStyleBackColor = false;
            this.btn_Recarga55.Click += new System.EventHandler(this.btn_Recarga55_Click);
            // 
            // btn_Recarga100
            // 
            this.btn_Recarga100.BackColor = System.Drawing.Color.Transparent;
            this.btn_Recarga100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Recarga100.Enabled = false;
            this.btn_Recarga100.Location = new System.Drawing.Point(686, 479);
            this.btn_Recarga100.Name = "btn_Recarga100";
            this.btn_Recarga100.Size = new System.Drawing.Size(75, 74);
            this.btn_Recarga100.TabIndex = 21;
            this.btn_Recarga100.Text = "R$ ";
            this.btn_Recarga100.UseVisualStyleBackColor = false;
            this.btn_Recarga100.Click += new System.EventHandler(this.button8_Click);
            // 
            // lbl_Validade
            // 
            this.lbl_Validade.AutoSize = true;
            this.lbl_Validade.Enabled = false;
            this.lbl_Validade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade.Location = new System.Drawing.Point(405, 448);
            this.lbl_Validade.Name = "lbl_Validade";
            this.lbl_Validade.Size = new System.Drawing.Size(70, 16);
            this.lbl_Validade.TabIndex = 22;
            this.lbl_Validade.Text = "Validade";
            // 
            // lbl_Validade2
            // 
            this.lbl_Validade2.AutoSize = true;
            this.lbl_Validade2.Enabled = false;
            this.lbl_Validade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade2.Location = new System.Drawing.Point(486, 448);
            this.lbl_Validade2.Name = "lbl_Validade2";
            this.lbl_Validade2.Size = new System.Drawing.Size(70, 16);
            this.lbl_Validade2.TabIndex = 23;
            this.lbl_Validade2.Text = "Validade";
            // 
            // lbl_Validade3
            // 
            this.lbl_Validade3.AutoSize = true;
            this.lbl_Validade3.Enabled = false;
            this.lbl_Validade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade3.Location = new System.Drawing.Point(595, 452);
            this.lbl_Validade3.Name = "lbl_Validade3";
            this.lbl_Validade3.Size = new System.Drawing.Size(70, 16);
            this.lbl_Validade3.TabIndex = 24;
            this.lbl_Validade3.Text = "Validade";
            // 
            // lbl_Validade4
            // 
            this.lbl_Validade4.AutoSize = true;
            this.lbl_Validade4.Enabled = false;
            this.lbl_Validade4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade4.Location = new System.Drawing.Point(683, 452);
            this.lbl_Validade4.Name = "lbl_Validade4";
            this.lbl_Validade4.Size = new System.Drawing.Size(70, 16);
            this.lbl_Validade4.TabIndex = 25;
            this.lbl_Validade4.Text = "Validade";
            // 
            // lbl_Validade5
            // 
            this.lbl_Validade5.AutoSize = true;
            this.lbl_Validade5.Enabled = false;
            this.lbl_Validade5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade5.Location = new System.Drawing.Point(405, 556);
            this.lbl_Validade5.Name = "lbl_Validade5";
            this.lbl_Validade5.Size = new System.Drawing.Size(70, 16);
            this.lbl_Validade5.TabIndex = 26;
            this.lbl_Validade5.Text = "Validade";
            // 
            // lbl_Validade6
            // 
            this.lbl_Validade6.AutoSize = true;
            this.lbl_Validade6.Enabled = false;
            this.lbl_Validade6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade6.Location = new System.Drawing.Point(486, 556);
            this.lbl_Validade6.Name = "lbl_Validade6";
            this.lbl_Validade6.Size = new System.Drawing.Size(70, 16);
            this.lbl_Validade6.TabIndex = 27;
            this.lbl_Validade6.Text = "Validade";
            // 
            // lbl_Validade7
            // 
            this.lbl_Validade7.AutoSize = true;
            this.lbl_Validade7.Enabled = false;
            this.lbl_Validade7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade7.Location = new System.Drawing.Point(595, 556);
            this.lbl_Validade7.Name = "lbl_Validade7";
            this.lbl_Validade7.Size = new System.Drawing.Size(70, 16);
            this.lbl_Validade7.TabIndex = 28;
            this.lbl_Validade7.Text = "Validade";
            // 
            // lbl_Validade8
            // 
            this.lbl_Validade8.AutoSize = true;
            this.lbl_Validade8.Enabled = false;
            this.lbl_Validade8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade8.Location = new System.Drawing.Point(683, 556);
            this.lbl_Validade8.Name = "lbl_Validade8";
            this.lbl_Validade8.Size = new System.Drawing.Size(70, 16);
            this.lbl_Validade8.TabIndex = 29;
            this.lbl_Validade8.Text = "Validade";
            // 
            // pic_telefone
            // 
            this.pic_telefone.Image = global::PROJETOS_OPERADORAS.Properties.Resources.A_Muppet_Family_Christmas_GIF;
            this.pic_telefone.Location = new System.Drawing.Point(12, 398);
            this.pic_telefone.Name = "pic_telefone";
            this.pic_telefone.Size = new System.Drawing.Size(200, 155);
            this.pic_telefone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_telefone.TabIndex = 30;
            this.pic_telefone.TabStop = false;
            this.pic_telefone.Click += new System.EventHandler(this.pic_telefone_Click);
            // 
            // frm_op
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(830, 593);
            this.Controls.Add(this.pic_telefone);
            this.Controls.Add(this.lbl_Validade8);
            this.Controls.Add(this.lbl_Validade7);
            this.Controls.Add(this.lbl_Validade6);
            this.Controls.Add(this.lbl_Validade5);
            this.Controls.Add(this.lbl_Validade4);
            this.Controls.Add(this.lbl_Validade3);
            this.Controls.Add(this.lbl_Validade2);
            this.Controls.Add(this.lbl_Validade);
            this.Controls.Add(this.btn_Recarga100);
            this.Controls.Add(this.btn_Recarga55);
            this.Controls.Add(this.btn_Recarga50);
            this.Controls.Add(this.btn_Recarga45);
            this.Controls.Add(this.btn_Recarga40);
            this.Controls.Add(this.btn_Recarga35);
            this.Controls.Add(this.btn_Recarga30);
            this.Controls.Add(this.btn_Recarga20);
            this.Controls.Add(this.lbl_SelecioneoV);
            this.Controls.Add(this.lbl_ValorDaRec);
            this.Controls.Add(this.lbl_NumeroDoC);
            this.Controls.Add(this.lbl_DDD);
            this.Controls.Add(this.lbl_operadoraS);
            this.Controls.Add(this.lbl_BemVindo);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.txt_NumCell);
            this.Controls.Add(this.txt_DDD);
            this.Controls.Add(this.txt_opSelec);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.grp_op);
            this.Controls.Add(this.lbl_dadosR);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_op";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROJETO OPERADORAS";
            this.Load += new System.EventHandler(this.frm_op_Load);
            this.grp_op.ResumeLayout(false);
            this.grp_op.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_telefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dadosR;
        private System.Windows.Forms.GroupBox grp_op;
        private System.Windows.Forms.RadioButton rad_Oi;
        private System.Windows.Forms.RadioButton rad_Tim;
        private System.Windows.Forms.RadioButton rad_Claro;
        private System.Windows.Forms.RadioButton rad_Vivo;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_opSelec;
        private System.Windows.Forms.TextBox txt_DDD;
        private System.Windows.Forms.TextBox txt_NumCell;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_BemVindo;
        private System.Windows.Forms.Label lbl_operadoraS;
        private System.Windows.Forms.Label lbl_DDD;
        private System.Windows.Forms.Label lbl_NumeroDoC;
        private System.Windows.Forms.Label lbl_ValorDaRec;
        private System.Windows.Forms.Label lbl_SelecioneoV;
        private System.Windows.Forms.Button btn_Recarga20;
        private System.Windows.Forms.Button btn_Recarga30;
        private System.Windows.Forms.Button btn_Recarga35;
        private System.Windows.Forms.Button btn_Recarga40;
        private System.Windows.Forms.Button btn_Recarga45;
        private System.Windows.Forms.Button btn_Recarga50;
        private System.Windows.Forms.Button btn_Recarga55;
        private System.Windows.Forms.Button btn_Recarga100;
        private System.Windows.Forms.Label lbl_Validade;
        private System.Windows.Forms.Label lbl_Validade2;
        private System.Windows.Forms.Label lbl_Validade3;
        private System.Windows.Forms.Label lbl_Validade4;
        private System.Windows.Forms.Label lbl_Validade5;
        private System.Windows.Forms.Label lbl_Validade6;
        private System.Windows.Forms.Label lbl_Validade7;
        private System.Windows.Forms.Label lbl_Validade8;
        private System.Windows.Forms.PictureBox pic_telefone;
    }
}

