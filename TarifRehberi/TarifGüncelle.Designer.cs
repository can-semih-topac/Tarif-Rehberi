namespace TarifRehberi
{
    partial class TarifGüncelleForm
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
            this.tarifAdiBox = new System.Windows.Forms.TextBox();
            this.kategoriComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hazirlanmaSuresiBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.talimatlarBox = new System.Windows.Forms.RichTextBox();
            this.yeniMalzemeEkleButonu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tarifiGüncelleButonu = new System.Windows.Forms.Button();
            this.yeniKategoriEkleButonu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.malzemeEkleComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.malzemeMiktariBox = new System.Windows.Forms.TextBox();
            this.malzemeEkleButonu = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.eklenenmazemelergridwiew = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.eklenenmazemelergridwiew)).BeginInit();
            this.SuspendLayout();
            // 
            // tarifAdiBox
            // 
            this.tarifAdiBox.Location = new System.Drawing.Point(183, 78);
            this.tarifAdiBox.Margin = new System.Windows.Forms.Padding(4);
            this.tarifAdiBox.Name = "tarifAdiBox";
            this.tarifAdiBox.Size = new System.Drawing.Size(240, 22);
            this.tarifAdiBox.TabIndex = 0;
            this.tarifAdiBox.TextChanged += new System.EventHandler(this.tarifAdiBox_TextChanged);
            // 
            // kategoriComboBox
            // 
            this.kategoriComboBox.FormattingEnabled = true;
            this.kategoriComboBox.Location = new System.Drawing.Point(183, 156);
            this.kategoriComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.kategoriComboBox.Name = "kategoriComboBox";
            this.kategoriComboBox.Size = new System.Drawing.Size(240, 24);
            this.kategoriComboBox.TabIndex = 1;
            this.kategoriComboBox.SelectedIndexChanged += new System.EventHandler(this.kategoriComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarifin Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hazırlanma Süresi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // hazirlanmaSuresiBox
            // 
            this.hazirlanmaSuresiBox.Location = new System.Drawing.Point(183, 116);
            this.hazirlanmaSuresiBox.Margin = new System.Windows.Forms.Padding(4);
            this.hazirlanmaSuresiBox.Name = "hazirlanmaSuresiBox";
            this.hazirlanmaSuresiBox.Size = new System.Drawing.Size(203, 22);
            this.hazirlanmaSuresiBox.TabIndex = 5;
            this.hazirlanmaSuresiBox.TextChanged += new System.EventHandler(this.hazirlanmaSuresiBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Talimatlar: (Tarifin nasıl uygulanacağını giriniz)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // talimatlarBox
            // 
            this.talimatlarBox.Location = new System.Drawing.Point(484, 119);
            this.talimatlarBox.Margin = new System.Windows.Forms.Padding(4);
            this.talimatlarBox.Name = "talimatlarBox";
            this.talimatlarBox.Size = new System.Drawing.Size(539, 357);
            this.talimatlarBox.TabIndex = 8;
            this.talimatlarBox.Text = "";
            this.talimatlarBox.TextChanged += new System.EventHandler(this.talimatlarBox_TextChanged);
            // 
            // yeniMalzemeEkleButonu
            // 
            this.yeniMalzemeEkleButonu.Location = new System.Drawing.Point(923, 68);
            this.yeniMalzemeEkleButonu.Margin = new System.Windows.Forms.Padding(4);
            this.yeniMalzemeEkleButonu.Name = "yeniMalzemeEkleButonu";
            this.yeniMalzemeEkleButonu.Size = new System.Drawing.Size(100, 43);
            this.yeniMalzemeEkleButonu.TabIndex = 9;
            this.yeniMalzemeEkleButonu.Text = "Yeni Malzeme Ekle";
            this.yeniMalzemeEkleButonu.UseVisualStyleBackColor = true;
            this.yeniMalzemeEkleButonu.Click += new System.EventHandler(this.yeniMalzemeEkleButonu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "dk";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Eklenen malzemeler:";
            // 
            // tarifiGüncelleButonu
            // 
            this.tarifiGüncelleButonu.Location = new System.Drawing.Point(845, 485);
            this.tarifiGüncelleButonu.Name = "tarifiGüncelleButonu";
            this.tarifiGüncelleButonu.Size = new System.Drawing.Size(178, 38);
            this.tarifiGüncelleButonu.TabIndex = 13;
            this.tarifiGüncelleButonu.Text = "Tarifi Güncelle";
            this.tarifiGüncelleButonu.UseVisualStyleBackColor = true;
            this.tarifiGüncelleButonu.Click += new System.EventHandler(this.tarifitamamlabutonu_Click);
            // 
            // yeniKategoriEkleButonu
            // 
            this.yeniKategoriEkleButonu.Location = new System.Drawing.Point(812, 68);
            this.yeniKategoriEkleButonu.Margin = new System.Windows.Forms.Padding(4);
            this.yeniKategoriEkleButonu.Name = "yeniKategoriEkleButonu";
            this.yeniKategoriEkleButonu.Size = new System.Drawing.Size(103, 43);
            this.yeniKategoriEkleButonu.TabIndex = 14;
            this.yeniKategoriEkleButonu.Text = "Yeni kategori ekle";
            this.yeniKategoriEkleButonu.UseVisualStyleBackColor = true;
            this.yeniKategoriEkleButonu.Click += new System.EventHandler(this.yeniKategoriEkleButonu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Malzeme ekle:";
            // 
            // malzemeEkleComboBox
            // 
            this.malzemeEkleComboBox.FormattingEnabled = true;
            this.malzemeEkleComboBox.Location = new System.Drawing.Point(183, 195);
            this.malzemeEkleComboBox.Name = "malzemeEkleComboBox";
            this.malzemeEkleComboBox.Size = new System.Drawing.Size(240, 24);
            this.malzemeEkleComboBox.TabIndex = 16;
            this.malzemeEkleComboBox.SelectedIndexChanged += new System.EventHandler(this.malzemeEkleComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Malzeme miktarı:";
            // 
            // malzemeMiktariBox
            // 
            this.malzemeMiktariBox.Location = new System.Drawing.Point(183, 230);
            this.malzemeMiktariBox.Name = "malzemeMiktariBox";
            this.malzemeMiktariBox.Size = new System.Drawing.Size(85, 22);
            this.malzemeMiktariBox.TabIndex = 18;
            this.malzemeMiktariBox.TextChanged += new System.EventHandler(this.malzemeMiktariBox_TextChanged);
            // 
            // malzemeEkleButonu
            // 
            this.malzemeEkleButonu.Location = new System.Drawing.Point(348, 229);
            this.malzemeEkleButonu.Name = "malzemeEkleButonu";
            this.malzemeEkleButonu.Size = new System.Drawing.Size(75, 23);
            this.malzemeEkleButonu.TabIndex = 19;
            this.malzemeEkleButonu.Text = "Ekle";
            this.malzemeEkleButonu.UseVisualStyleBackColor = true;
            this.malzemeEkleButonu.Click += new System.EventHandler(this.malzemeEkleButonu_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(274, 232);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(68, 20);
            this.listBox2.TabIndex = 20;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // eklenenmazemelergridwiew
            // 
            this.eklenenmazemelergridwiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eklenenmazemelergridwiew.Location = new System.Drawing.Point(56, 324);
            this.eklenenmazemelergridwiew.Name = "eklenenmazemelergridwiew";
            this.eklenenmazemelergridwiew.RowHeadersWidth = 51;
            this.eklenenmazemelergridwiew.RowTemplate.Height = 24;
            this.eklenenmazemelergridwiew.Size = new System.Drawing.Size(367, 152);
            this.eklenenmazemelergridwiew.TabIndex = 21;
            this.eklenenmazemelergridwiew.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eklenenmazemelergridwiew_CellContentClick);
            // 
            // TarifGüncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.eklenenmazemelergridwiew);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.malzemeEkleButonu);
            this.Controls.Add(this.malzemeMiktariBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.malzemeEkleComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yeniKategoriEkleButonu);
            this.Controls.Add(this.tarifiGüncelleButonu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yeniMalzemeEkleButonu);
            this.Controls.Add(this.talimatlarBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hazirlanmaSuresiBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kategoriComboBox);
            this.Controls.Add(this.tarifAdiBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TarifGüncelleForm";
            this.Text = "Tarif Güncelle";
            this.Load += new System.EventHandler(this.TarifGüncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eklenenmazemelergridwiew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tarifAdiBox;
        private System.Windows.Forms.ComboBox kategoriComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hazirlanmaSuresiBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox talimatlarBox;
        private System.Windows.Forms.Button yeniMalzemeEkleButonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tarifiGüncelleButonu;
        private System.Windows.Forms.Button yeniKategoriEkleButonu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox malzemeEkleComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox malzemeMiktariBox;
        private System.Windows.Forms.Button malzemeEkleButonu;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DataGridView eklenenmazemelergridwiew;
    }
}