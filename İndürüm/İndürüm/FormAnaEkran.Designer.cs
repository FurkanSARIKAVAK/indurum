namespace İndürüm
{
    partial class FormAnaEkran
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaEkran));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageListSiparisim = new System.Windows.Forms.ImageList(this.components);
            this.btnGarsonCagır = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSiparisim = new System.Windows.Forms.Button();
            this.btnTatlilar = new System.Windows.Forms.Button();
            this.btnYanUrunler = new System.Windows.Forms.Button();
            this.btnIcecekler = new System.Windows.Forms.Button();
            this.btnDurumler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Dürümler.jpg");
            this.ımageList1.Images.SetKeyName(1, "İçecekler.jpg");
            this.ımageList1.Images.SetKeyName(2, "YanÜrünler.jpg");
            this.ımageList1.Images.SetKeyName(3, "Tatlılarr.jpg");
            // 
            // ımageListSiparisim
            // 
            this.ımageListSiparisim.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListSiparisim.ImageStream")));
            this.ımageListSiparisim.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListSiparisim.Images.SetKeyName(0, "Siparişim.jpg");
            this.ımageListSiparisim.Images.SetKeyName(1, "Siparişimm.png");
            // 
            // btnGarsonCagır
            // 
            this.btnGarsonCagır.BackColor = System.Drawing.SystemColors.Info;
            this.btnGarsonCagır.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarsonCagır.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGarsonCagır.Location = new System.Drawing.Point(294, 229);
            this.btnGarsonCagır.Margin = new System.Windows.Forms.Padding(4);
            this.btnGarsonCagır.Name = "btnGarsonCagır";
            this.btnGarsonCagır.Size = new System.Drawing.Size(205, 44);
            this.btnGarsonCagır.TabIndex = 5;
            this.btnGarsonCagır.Text = "Garson Çağır";
            this.btnGarsonCagır.UseVisualStyleBackColor = false;
            this.btnGarsonCagır.Click += new System.EventHandler(this.btnGarsonCagır_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::İndürüm.Properties.Resources.dürüm;
            this.pictureBox1.Location = new System.Drawing.Point(588, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSiparisim
            // 
            this.btnSiparisim.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisim.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSiparisim.ImageIndex = 1;
            this.btnSiparisim.ImageList = this.ımageListSiparisim;
            this.btnSiparisim.Location = new System.Drawing.Point(314, 382);
            this.btnSiparisim.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisim.Name = "btnSiparisim";
            this.btnSiparisim.Size = new System.Drawing.Size(170, 150);
            this.btnSiparisim.TabIndex = 4;
            this.btnSiparisim.Text = "Siparişim";
            this.btnSiparisim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiparisim.UseVisualStyleBackColor = true;
            this.btnSiparisim.Click += new System.EventHandler(this.btnSiparisim_Click);
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatlilar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTatlilar.ImageIndex = 3;
            this.btnTatlilar.ImageList = this.ımageList1;
            this.btnTatlilar.Location = new System.Drawing.Point(594, 52);
            this.btnTatlilar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.Size = new System.Drawing.Size(170, 150);
            this.btnTatlilar.TabIndex = 3;
            this.btnTatlilar.Text = "Tatlılar";
            this.btnTatlilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTatlilar.UseVisualStyleBackColor = true;
            this.btnTatlilar.Click += new System.EventHandler(this.btnTatlilar_Click);
            // 
            // btnYanUrunler
            // 
            this.btnYanUrunler.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYanUrunler.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnYanUrunler.ImageIndex = 2;
            this.btnYanUrunler.ImageList = this.ımageList1;
            this.btnYanUrunler.Location = new System.Drawing.Point(399, 52);
            this.btnYanUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.btnYanUrunler.Name = "btnYanUrunler";
            this.btnYanUrunler.Size = new System.Drawing.Size(170, 150);
            this.btnYanUrunler.TabIndex = 2;
            this.btnYanUrunler.Text = "Yan Ürünler";
            this.btnYanUrunler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYanUrunler.UseVisualStyleBackColor = true;
            this.btnYanUrunler.Click += new System.EventHandler(this.btnYanUrunler_Click);
            // 
            // btnIcecekler
            // 
            this.btnIcecekler.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIcecekler.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnIcecekler.ImageIndex = 1;
            this.btnIcecekler.ImageList = this.ımageList1;
            this.btnIcecekler.Location = new System.Drawing.Point(208, 52);
            this.btnIcecekler.Margin = new System.Windows.Forms.Padding(4);
            this.btnIcecekler.Name = "btnIcecekler";
            this.btnIcecekler.Size = new System.Drawing.Size(170, 150);
            this.btnIcecekler.TabIndex = 1;
            this.btnIcecekler.Text = "İçecekler";
            this.btnIcecekler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIcecekler.UseVisualStyleBackColor = true;
            this.btnIcecekler.Click += new System.EventHandler(this.btnIcecekler_Click);
            // 
            // btnDurumler
            // 
            this.btnDurumler.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDurumler.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDurumler.ImageIndex = 0;
            this.btnDurumler.ImageList = this.ımageList1;
            this.btnDurumler.Location = new System.Drawing.Point(16, 52);
            this.btnDurumler.Margin = new System.Windows.Forms.Padding(4);
            this.btnDurumler.Name = "btnDurumler";
            this.btnDurumler.Size = new System.Drawing.Size(170, 150);
            this.btnDurumler.TabIndex = 0;
            this.btnDurumler.Text = "Dürümler";
            this.btnDurumler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDurumler.UseVisualStyleBackColor = true;
            this.btnDurumler.Click += new System.EventHandler(this.btnDurumler_Click);
            // 
            // FormAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGarsonCagır);
            this.Controls.Add(this.btnSiparisim);
            this.Controls.Add(this.btnTatlilar);
            this.Controls.Add(this.btnYanUrunler);
            this.Controls.Add(this.btnIcecekler);
            this.Controls.Add(this.btnDurumler);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İndürüm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDurumler;
        private System.Windows.Forms.Button btnIcecekler;
        private System.Windows.Forms.Button btnYanUrunler;
        private System.Windows.Forms.Button btnTatlilar;
        private System.Windows.Forms.Button btnSiparisim;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageListSiparisim;
        private System.Windows.Forms.Button btnGarsonCagır;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

