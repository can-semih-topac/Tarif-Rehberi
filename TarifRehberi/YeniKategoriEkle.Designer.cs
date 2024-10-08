namespace TarifRehberi
{
    partial class YeniKategoriEkle
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
            this.yeniKategoriEklemeyiTamamlaButonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kategoriAdiBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // yeniKategoriEklemeyiTamamlaButonu
            // 
            this.yeniKategoriEklemeyiTamamlaButonu.Location = new System.Drawing.Point(42, 236);
            this.yeniKategoriEklemeyiTamamlaButonu.Name = "yeniKategoriEklemeyiTamamlaButonu";
            this.yeniKategoriEklemeyiTamamlaButonu.Size = new System.Drawing.Size(197, 76);
            this.yeniKategoriEklemeyiTamamlaButonu.TabIndex = 0;
            this.yeniKategoriEklemeyiTamamlaButonu.Text = "Eklemeyi tamamla";
            this.yeniKategoriEklemeyiTamamlaButonu.UseVisualStyleBackColor = true;
            this.yeniKategoriEklemeyiTamamlaButonu.Click += new System.EventHandler(this.yeniKategoriEklemeyiTamamlaButonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni kategorinin adını girin:";
            // 
            // kategoriAdiBox
            // 
            this.kategoriAdiBox.Location = new System.Drawing.Point(42, 111);
            this.kategoriAdiBox.Name = "kategoriAdiBox";
            this.kategoriAdiBox.Size = new System.Drawing.Size(197, 22);
            this.kategoriAdiBox.TabIndex = 2;
            this.kategoriAdiBox.TextChanged += new System.EventHandler(this.kategoriAdiBox_TextChanged);
            // 
            // YeniKategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.kategoriAdiBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yeniKategoriEklemeyiTamamlaButonu);
            this.Name = "YeniKategoriEkle";
            this.Text = "Yeni Kategori Ekle";
            this.Load += new System.EventHandler(this.YeniKategoriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yeniKategoriEklemeyiTamamlaButonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kategoriAdiBox;
    }
}