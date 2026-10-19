namespace Projeto_CarrinhoGeek
{
    partial class frm_promocoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_promocoes));
            this.btn_finalizarP = new System.Windows.Forms.Button();
            this.txt_carrinho = new System.Windows.Forms.TextBox();
            this.lbl_promoções = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ps5 = new System.Windows.Forms.Label();
            this.lbl_fonte = new System.Windows.Forms.Label();
            this.lbl_headset = new System.Windows.Forms.Label();
            this.lbl_memoria = new System.Windows.Forms.Label();
            this.lbl_7600 = new System.Windows.Forms.Label();
            this.btn_maisInfo = new System.Windows.Forms.Button();
            this.btn_maisInfo2 = new System.Windows.Forms.Button();
            this.btn_maisInfo3 = new System.Windows.Forms.Button();
            this.btn_maisInfo4 = new System.Windows.Forms.Button();
            this.btn_maisInfo5 = new System.Windows.Forms.Button();
            this.pic_memoriar = new System.Windows.Forms.PictureBox();
            this.pic_fonte = new System.Windows.Forms.PictureBox();
            this.pic_7600 = new System.Windows.Forms.PictureBox();
            this.pic_headset = new System.Windows.Forms.PictureBox();
            this.pic_ps5 = new System.Windows.Forms.PictureBox();
            this.pic_gif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_memoriar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fonte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_7600)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_headset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ps5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_finalizarP
            // 
            this.btn_finalizarP.Location = new System.Drawing.Point(628, 375);
            this.btn_finalizarP.Name = "btn_finalizarP";
            this.btn_finalizarP.Size = new System.Drawing.Size(175, 34);
            this.btn_finalizarP.TabIndex = 6;
            this.btn_finalizarP.Text = "FINALIZAR PEDIDO";
            this.btn_finalizarP.UseVisualStyleBackColor = true;
            this.btn_finalizarP.Click += new System.EventHandler(this.btn_finalizarP_Click);
            // 
            // txt_carrinho
            // 
            this.txt_carrinho.Location = new System.Drawing.Point(646, 89);
            this.txt_carrinho.Multiline = true;
            this.txt_carrinho.Name = "txt_carrinho";
            this.txt_carrinho.ReadOnly = true;
            this.txt_carrinho.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_carrinho.Size = new System.Drawing.Size(411, 262);
            this.txt_carrinho.TabIndex = 7;
            this.txt_carrinho.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_promoções
            // 
            this.lbl_promoções.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_promoções.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_promoções.Location = new System.Drawing.Point(644, 9);
            this.lbl_promoções.Name = "lbl_promoções";
            this.lbl_promoções.Size = new System.Drawing.Size(364, 61);
            this.lbl_promoções.TabIndex = 8;
            this.lbl_promoções.Text = "PROMOÇÕES DO DIA!!!";
            this.lbl_promoções.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // lbl_ps5
            // 
            this.lbl_ps5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ps5.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ps5.Location = new System.Drawing.Point(8, 143);
            this.lbl_ps5.Name = "lbl_ps5";
            this.lbl_ps5.Size = new System.Drawing.Size(171, 88);
            this.lbl_ps5.TabIndex = 11;
            this.lbl_ps5.Text = "PLAYSTATION 5 825GB R$3.500,00";
            this.lbl_ps5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fonte
            // 
            this.lbl_fonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fonte.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_fonte.Location = new System.Drawing.Point(436, 147);
            this.lbl_fonte.Name = "lbl_fonte";
            this.lbl_fonte.Size = new System.Drawing.Size(162, 78);
            this.lbl_fonte.TabIndex = 12;
            this.lbl_fonte.Text = "FONTE XPG CORE 850W R$ 530,00";
            this.lbl_fonte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_fonte.Click += new System.EventHandler(this.lbl_fonte_Click);
            // 
            // lbl_headset
            // 
            this.lbl_headset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headset.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_headset.Location = new System.Drawing.Point(12, 364);
            this.lbl_headset.Name = "lbl_headset";
            this.lbl_headset.Size = new System.Drawing.Size(156, 77);
            this.lbl_headset.TabIndex = 13;
            this.lbl_headset.Text = "HEADSET S/F HAVIT FUXI H3 R$ 190,00";
            this.lbl_headset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_memoria
            // 
            this.lbl_memoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_memoria.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_memoria.Location = new System.Drawing.Point(442, 444);
            this.lbl_memoria.Name = "lbl_memoria";
            this.lbl_memoria.Size = new System.Drawing.Size(158, 109);
            this.lbl_memoria.TabIndex = 14;
            this.lbl_memoria.Text = "MEMÓRIA RAM RISE MODE 16GB 3200MHZ R$ 912,00";
            this.lbl_memoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_7600
            // 
            this.lbl_7600.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_7600.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_7600.Location = new System.Drawing.Point(174, 482);
            this.lbl_7600.Name = "lbl_7600";
            this.lbl_7600.Size = new System.Drawing.Size(209, 78);
            this.lbl_7600.TabIndex = 15;
            this.lbl_7600.Text = "RX 7600 CHALENGER DUAL FAN R$1900,00";
            this.lbl_7600.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_maisInfo
            // 
            this.btn_maisInfo.Location = new System.Drawing.Point(190, 46);
            this.btn_maisInfo.Name = "btn_maisInfo";
            this.btn_maisInfo.Size = new System.Drawing.Size(112, 47);
            this.btn_maisInfo.TabIndex = 16;
            this.btn_maisInfo.Text = "MAIS INFORMAÇÕES";
            this.btn_maisInfo.UseVisualStyleBackColor = true;
            this.btn_maisInfo.Click += new System.EventHandler(this.btn_maisInfo_Click);
            // 
            // btn_maisInfo2
            // 
            this.btn_maisInfo2.Location = new System.Drawing.Point(190, 282);
            this.btn_maisInfo2.Name = "btn_maisInfo2";
            this.btn_maisInfo2.Size = new System.Drawing.Size(112, 49);
            this.btn_maisInfo2.TabIndex = 17;
            this.btn_maisInfo2.Text = "MAIS INFORMAÇÕES";
            this.btn_maisInfo2.UseVisualStyleBackColor = true;
            this.btn_maisInfo2.Click += new System.EventHandler(this.btn_maisInfo2_Click);
            // 
            // btn_maisInfo3
            // 
            this.btn_maisInfo3.Location = new System.Drawing.Point(199, 563);
            this.btn_maisInfo3.Name = "btn_maisInfo3";
            this.btn_maisInfo3.Size = new System.Drawing.Size(103, 34);
            this.btn_maisInfo3.TabIndex = 18;
            this.btn_maisInfo3.Text = "MAIS INFORMAÇÕES";
            this.btn_maisInfo3.UseVisualStyleBackColor = true;
            this.btn_maisInfo3.Click += new System.EventHandler(this.btn_maisInfo3_Click);
            // 
            // btn_maisInfo4
            // 
            this.btn_maisInfo4.Location = new System.Drawing.Point(461, 228);
            this.btn_maisInfo4.Name = "btn_maisInfo4";
            this.btn_maisInfo4.Size = new System.Drawing.Size(114, 43);
            this.btn_maisInfo4.TabIndex = 19;
            this.btn_maisInfo4.Text = "MAIS INFORMAÇÕES";
            this.btn_maisInfo4.UseVisualStyleBackColor = true;
            this.btn_maisInfo4.Click += new System.EventHandler(this.btn_maisInfo4_Click);
            // 
            // btn_maisInfo5
            // 
            this.btn_maisInfo5.Location = new System.Drawing.Point(461, 553);
            this.btn_maisInfo5.Name = "btn_maisInfo5";
            this.btn_maisInfo5.Size = new System.Drawing.Size(114, 44);
            this.btn_maisInfo5.TabIndex = 20;
            this.btn_maisInfo5.Text = "MAIS INFORMAÇÕES";
            this.btn_maisInfo5.UseVisualStyleBackColor = true;
            this.btn_maisInfo5.Click += new System.EventHandler(this.btn_maisInfo5_Click);
            // 
            // pic_memoriar
            // 
            this.pic_memoriar.BackgroundImage = global::Projeto_CarrinhoGeek.Properties.Resources.Mem_ria_RAM_Rise_Mode_Z_16GB_3200MHz_DDR4_CL19_Branco_RM_D4_16G_3200ZW_1783349620;
            this.pic_memoriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_memoriar.Location = new System.Drawing.Point(440, 326);
            this.pic_memoriar.Name = "pic_memoriar";
            this.pic_memoriar.Size = new System.Drawing.Size(156, 115);
            this.pic_memoriar.TabIndex = 5;
            this.pic_memoriar.TabStop = false;
            this.pic_memoriar.Click += new System.EventHandler(this.pic_memoriar_Click);
            // 
            // pic_fonte
            // 
            this.pic_fonte.BackgroundImage = global::Projeto_CarrinhoGeek.Properties.Resources.fonte_xpg_core_reactor_ii_ve_850w_75261436_1721238617_gg;
            this.pic_fonte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_fonte.Location = new System.Drawing.Point(442, 29);
            this.pic_fonte.Name = "pic_fonte";
            this.pic_fonte.Size = new System.Drawing.Size(156, 115);
            this.pic_fonte.TabIndex = 4;
            this.pic_fonte.TabStop = false;
            this.pic_fonte.Click += new System.EventHandler(this.pic_fonte_Click);
            // 
            // pic_7600
            // 
            this.pic_7600.BackgroundImage = global::Projeto_CarrinhoGeek.Properties.Resources.placa_de_video_rx_7600_challenger_asrock_amd_radeon_8gb_gddr6_90_ga41zz_00uanf_1685551526_gg;
            this.pic_7600.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_7600.Location = new System.Drawing.Point(16, 482);
            this.pic_7600.Name = "pic_7600";
            this.pic_7600.Size = new System.Drawing.Size(152, 115);
            this.pic_7600.TabIndex = 3;
            this.pic_7600.TabStop = false;
            this.pic_7600.Click += new System.EventHandler(this.pic_7600_Click);
            // 
            // pic_headset
            // 
            this.pic_headset.BackgroundImage = global::Projeto_CarrinhoGeek.Properties.Resources.headset_gamer_sem_fio_havit_fuxi_h3_7_1_surround_driver_40mm_bluetooth_e_usb_preto_fuxi_h3_black_1706888697_gg;
            this.pic_headset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_headset.Location = new System.Drawing.Point(12, 246);
            this.pic_headset.Name = "pic_headset";
            this.pic_headset.Size = new System.Drawing.Size(156, 115);
            this.pic_headset.TabIndex = 2;
            this.pic_headset.TabStop = false;
            this.pic_headset.Click += new System.EventHandler(this.pic_headset_Click);
            // 
            // pic_ps5
            // 
            this.pic_ps5.BackgroundImage = global::Projeto_CarrinhoGeek.Properties.Resources.console_sony_playstation_5_ssd_825gb_controle_sem_fio_dualsense_2_jogos_digitais_edicao_digital_1765487654_gg;
            this.pic_ps5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_ps5.Location = new System.Drawing.Point(12, 29);
            this.pic_ps5.Name = "pic_ps5";
            this.pic_ps5.Size = new System.Drawing.Size(156, 115);
            this.pic_ps5.TabIndex = 1;
            this.pic_ps5.TabStop = false;
            this.pic_ps5.Click += new System.EventHandler(this.pic_ps5_Click);
            // 
            // pic_gif
            // 
            this.pic_gif.BackgroundImage = global::Projeto_CarrinhoGeek.Properties.Resources.Terrenos_GIF_by_Terreno_Livre;
            this.pic_gif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_gif.Image = global::Projeto_CarrinhoGeek.Properties.Resources.Shopping_Tienda_GIF_by_Tottus_Perú;
            this.pic_gif.Location = new System.Drawing.Point(861, 501);
            this.pic_gif.Name = "pic_gif";
            this.pic_gif.Size = new System.Drawing.Size(165, 116);
            this.pic_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_gif.TabIndex = 0;
            this.pic_gif.TabStop = false;
            // 
            // frm_promocoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1130, 607);
            this.Controls.Add(this.btn_maisInfo5);
            this.Controls.Add(this.btn_maisInfo4);
            this.Controls.Add(this.btn_maisInfo3);
            this.Controls.Add(this.btn_maisInfo2);
            this.Controls.Add(this.btn_maisInfo);
            this.Controls.Add(this.lbl_7600);
            this.Controls.Add(this.lbl_memoria);
            this.Controls.Add(this.lbl_headset);
            this.Controls.Add(this.lbl_fonte);
            this.Controls.Add(this.lbl_ps5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_promoções);
            this.Controls.Add(this.txt_carrinho);
            this.Controls.Add(this.btn_finalizarP);
            this.Controls.Add(this.pic_memoriar);
            this.Controls.Add(this.pic_fonte);
            this.Controls.Add(this.pic_7600);
            this.Controls.Add(this.pic_headset);
            this.Controls.Add(this.pic_ps5);
            this.Controls.Add(this.pic_gif);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_promocoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistriGeek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_memoriar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fonte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_7600)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_headset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ps5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_gif;
        private System.Windows.Forms.PictureBox pic_ps5;
        private System.Windows.Forms.PictureBox pic_headset;
        private System.Windows.Forms.PictureBox pic_7600;
        private System.Windows.Forms.PictureBox pic_fonte;
        private System.Windows.Forms.PictureBox pic_memoriar;
        private System.Windows.Forms.Button btn_finalizarP;
        private System.Windows.Forms.TextBox txt_carrinho;
        private System.Windows.Forms.Label lbl_promoções;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ps5;
        private System.Windows.Forms.Label lbl_fonte;
        private System.Windows.Forms.Label lbl_headset;
        private System.Windows.Forms.Label lbl_memoria;
        private System.Windows.Forms.Label lbl_7600;
        private System.Windows.Forms.Button btn_maisInfo;
        private System.Windows.Forms.Button btn_maisInfo2;
        private System.Windows.Forms.Button btn_maisInfo3;
        private System.Windows.Forms.Button btn_maisInfo4;
        private System.Windows.Forms.Button btn_maisInfo5;
    }
}

