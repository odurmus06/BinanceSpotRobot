namespace BinanceSpotRobot
{
    partial class frmSpot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_common = new System.Windows.Forms.Panel();
            this.lbl_satis_kar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_short = new System.Windows.Forms.Button();
            this.btn_long = new System.Windows.Forms.Button();
            this.lbl_k_z = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_kar_al = new System.Windows.Forms.CheckBox();
            this.txt_tp = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dg_emirler = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.chk_lissen = new System.Windows.Forms.CheckBox();
            this.chk_topmost = new System.Windows.Forms.CheckBox();
            this.lbl_symbol = new System.Windows.Forms.Label();
            this.group_wallet = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_cuzdan = new System.Windows.Forms.Label();
            this.pc_image = new System.Windows.Forms.PictureBox();
            this.pnl_common.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_emirler)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.group_wallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_common
            // 
            this.pnl_common.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_common.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_common.Controls.Add(this.lbl_satis_kar);
            this.pnl_common.Controls.Add(this.label2);
            this.pnl_common.Controls.Add(this.btn_short);
            this.pnl_common.Controls.Add(this.btn_long);
            this.pnl_common.Controls.Add(this.lbl_k_z);
            this.pnl_common.Controls.Add(this.label5);
            this.pnl_common.Controls.Add(this.chk_kar_al);
            this.pnl_common.Controls.Add(this.txt_tp);
            this.pnl_common.Controls.Add(this.lbl_price);
            this.pnl_common.Controls.Add(this.txt_miktar);
            this.pnl_common.Controls.Add(this.label4);
            this.pnl_common.Controls.Add(this.label3);
            this.pnl_common.Controls.Add(this.label1);
            this.pnl_common.Controls.Add(this.dataGridView1);
            this.pnl_common.Controls.Add(this.tab_main);
            this.pnl_common.Controls.Add(this.pnl_header);
            this.pnl_common.Location = new System.Drawing.Point(9, 2);
            this.pnl_common.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_common.Name = "pnl_common";
            this.pnl_common.Size = new System.Drawing.Size(742, 426);
            this.pnl_common.TabIndex = 0;
            // 
            // lbl_satis_kar
            // 
            this.lbl_satis_kar.AutoSize = true;
            this.lbl_satis_kar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_satis_kar.Location = new System.Drawing.Point(565, 158);
            this.lbl_satis_kar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_satis_kar.Name = "lbl_satis_kar";
            this.lbl_satis_kar.Size = new System.Drawing.Size(18, 20);
            this.lbl_satis_kar.TabIndex = 48;
            this.lbl_satis_kar.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(480, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Satarsam?";
            // 
            // btn_short
            // 
            this.btn_short.BackColor = System.Drawing.Color.Red;
            this.btn_short.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_short.Location = new System.Drawing.Point(660, 153);
            this.btn_short.Margin = new System.Windows.Forms.Padding(2);
            this.btn_short.Name = "btn_short";
            this.btn_short.Size = new System.Drawing.Size(65, 28);
            this.btn_short.TabIndex = 46;
            this.btn_short.Text = "SAT";
            this.btn_short.UseVisualStyleBackColor = false;
            this.btn_short.Click += new System.EventHandler(this.btn_short_Click);
            // 
            // btn_long
            // 
            this.btn_long.BackColor = System.Drawing.Color.Lime;
            this.btn_long.Location = new System.Drawing.Point(390, 152);
            this.btn_long.Margin = new System.Windows.Forms.Padding(2);
            this.btn_long.Name = "btn_long";
            this.btn_long.Size = new System.Drawing.Size(68, 26);
            this.btn_long.TabIndex = 45;
            this.btn_long.Text = "AL ";
            this.btn_long.UseVisualStyleBackColor = false;
            this.btn_long.Click += new System.EventHandler(this.btn_long_Click);
            // 
            // lbl_k_z
            // 
            this.lbl_k_z.AutoSize = true;
            this.lbl_k_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_k_z.Location = new System.Drawing.Point(336, 187);
            this.lbl_k_z.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_k_z.Name = "lbl_k_z";
            this.lbl_k_z.Size = new System.Drawing.Size(18, 20);
            this.lbl_k_z.TabIndex = 44;
            this.lbl_k_z.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(248, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "K/Z";
            // 
            // chk_kar_al
            // 
            this.chk_kar_al.AutoSize = true;
            this.chk_kar_al.Checked = true;
            this.chk_kar_al.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_kar_al.Location = new System.Drawing.Point(250, 129);
            this.chk_kar_al.Margin = new System.Windows.Forms.Padding(2);
            this.chk_kar_al.Name = "chk_kar_al";
            this.chk_kar_al.Size = new System.Drawing.Size(15, 14);
            this.chk_kar_al.TabIndex = 42;
            this.chk_kar_al.UseVisualStyleBackColor = true;
            // 
            // txt_tp
            // 
            this.txt_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tp.Location = new System.Drawing.Point(340, 122);
            this.txt_tp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tp.Name = "txt_tp";
            this.txt_tp.Size = new System.Drawing.Size(36, 23);
            this.txt_tp.TabIndex = 41;
            this.txt_tp.Text = "1";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_price.Location = new System.Drawing.Point(336, 95);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(18, 20);
            this.lbl_price.TabIndex = 36;
            this.lbl_price.Text = "0";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_miktar.Location = new System.Drawing.Point(340, 154);
            this.txt_miktar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(39, 23);
            this.txt_miktar.TabIndex = 40;
            this.txt_miktar.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(248, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(268, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Kar Al";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(246, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "İşlem Fiyatı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(229, 338);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tab_main
            // 
            this.tab_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_main.Controls.Add(this.tabPage1);
            this.tab_main.Controls.Add(this.tabPage2);
            this.tab_main.Controls.Add(this.tabPage3);
            this.tab_main.Controls.Add(this.tabPage4);
            this.tab_main.Location = new System.Drawing.Point(247, 220);
            this.tab_main.Margin = new System.Windows.Forms.Padding(2);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(482, 205);
            this.tab_main.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dg_emirler);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(474, 179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Açık Emirler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dg_emirler
            // 
            this.dg_emirler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_emirler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_emirler.Location = new System.Drawing.Point(2, 2);
            this.dg_emirler.Margin = new System.Windows.Forms.Padding(2);
            this.dg_emirler.Name = "dg_emirler";
            this.dg_emirler.RowTemplate.Height = 24;
            this.dg_emirler.Size = new System.Drawing.Size(470, 175);
            this.dg_emirler.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_log);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(474, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LOG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_log
            // 
            this.txt_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_log.Location = new System.Drawing.Point(2, 2);
            this.txt_log.Margin = new System.Windows.Forms.Padding(2);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(470, 175);
            this.txt_log.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(474, 179);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Geçmiş";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(474, 179);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manuel İşlemler";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pnl_header
            // 
            this.pnl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(198)))), ((int)(((byte)(254)))));
            this.pnl_header.Controls.Add(this.chk_lissen);
            this.pnl_header.Controls.Add(this.chk_topmost);
            this.pnl_header.Controls.Add(this.lbl_symbol);
            this.pnl_header.Controls.Add(this.group_wallet);
            this.pnl_header.Controls.Add(this.pc_image);
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(742, 84);
            this.pnl_header.TabIndex = 0;
            // 
            // chk_lissen
            // 
            this.chk_lissen.AutoSize = true;
            this.chk_lissen.Location = new System.Drawing.Point(622, 61);
            this.chk_lissen.Margin = new System.Windows.Forms.Padding(2);
            this.chk_lissen.Name = "chk_lissen";
            this.chk_lissen.Size = new System.Drawing.Size(118, 17);
            this.chk_lissen.TabIndex = 40;
            this.chk_lissen.Text = "Dinleme Modu Açık";
            this.chk_lissen.UseVisualStyleBackColor = true;
            // 
            // chk_topmost
            // 
            this.chk_topmost.AutoSize = true;
            this.chk_topmost.Location = new System.Drawing.Point(524, 61);
            this.chk_topmost.Margin = new System.Windows.Forms.Padding(2);
            this.chk_topmost.Name = "chk_topmost";
            this.chk_topmost.Size = new System.Drawing.Size(91, 17);
            this.chk_topmost.TabIndex = 39;
            this.chk_topmost.Text = "En Üstte Kal?";
            this.chk_topmost.UseVisualStyleBackColor = true;
            this.chk_topmost.CheckedChanged += new System.EventHandler(this.chk_topmost_CheckedChanged);
            // 
            // lbl_symbol
            // 
            this.lbl_symbol.AutoSize = true;
            this.lbl_symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_symbol.ForeColor = System.Drawing.Color.White;
            this.lbl_symbol.Location = new System.Drawing.Point(49, 28);
            this.lbl_symbol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_symbol.Name = "lbl_symbol";
            this.lbl_symbol.Size = new System.Drawing.Size(84, 20);
            this.lbl_symbol.TabIndex = 14;
            this.lbl_symbol.Text = "BTCUSDT";
            // 
            // group_wallet
            // 
            this.group_wallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_wallet.Controls.Add(this.btn_refresh);
            this.group_wallet.Controls.Add(this.lbl_cuzdan);
            this.group_wallet.Location = new System.Drawing.Point(524, 11);
            this.group_wallet.Margin = new System.Windows.Forms.Padding(2);
            this.group_wallet.Name = "group_wallet";
            this.group_wallet.Padding = new System.Windows.Forms.Padding(2);
            this.group_wallet.Size = new System.Drawing.Size(216, 46);
            this.group_wallet.TabIndex = 9;
            this.group_wallet.TabStop = false;
            this.group_wallet.Text = "Cüzdan";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(155, 15);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(56, 22);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Yenile";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_cuzdan
            // 
            this.lbl_cuzdan.AutoSize = true;
            this.lbl_cuzdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cuzdan.Location = new System.Drawing.Point(10, 17);
            this.lbl_cuzdan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cuzdan.Name = "lbl_cuzdan";
            this.lbl_cuzdan.Size = new System.Drawing.Size(18, 20);
            this.lbl_cuzdan.TabIndex = 0;
            this.lbl_cuzdan.Text = "0";
            // 
            // pc_image
            // 
            this.pc_image.Location = new System.Drawing.Point(2, 16);
            this.pc_image.Margin = new System.Windows.Forms.Padding(2);
            this.pc_image.Name = "pc_image";
            this.pc_image.Size = new System.Drawing.Size(42, 41);
            this.pc_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_image.TabIndex = 0;
            this.pc_image.TabStop = false;
            // 
            // frmSpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(173)))), ((int)(((byte)(246)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(760, 438);
            this.Controls.Add(this.pnl_common);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSpot";
            this.Text = "Spot Bot";
            this.Resize += new System.EventHandler(this.frmSpot_Resize);
            this.pnl_common.ResumeLayout(false);
            this.pnl_common.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_emirler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.group_wallet.ResumeLayout(false);
            this.group_wallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_common;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.PictureBox pc_image;
        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox group_wallet;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_cuzdan;
        private System.Windows.Forms.Label lbl_symbol;
        private System.Windows.Forms.CheckBox chk_lissen;
        private System.Windows.Forms.CheckBox chk_topmost;
        private System.Windows.Forms.Label lbl_satis_kar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_short;
        private System.Windows.Forms.Button btn_long;
        private System.Windows.Forms.Label lbl_k_z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_kar_al;
        private System.Windows.Forms.TextBox txt_tp;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_emirler;
        private System.Windows.Forms.TextBox txt_log;
    }
}

