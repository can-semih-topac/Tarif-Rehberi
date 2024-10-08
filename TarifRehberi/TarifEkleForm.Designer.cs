namespace TarifRehberi
{
    partial class TarifEkleForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.malzemeeklebutonu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tarifitamamlabutonu = new System.Windows.Forms.Button();
            this.yeniKategoriEkleButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 156);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarifin Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hazırlanma Süresi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 116);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Talimatlar: (Tarifin nasıl uygulanacağını giriniz)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(484, 119);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(539, 357);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // malzemeeklebutonu
            // 
            this.malzemeeklebutonu.Location = new System.Drawing.Point(319, 229);
            this.malzemeeklebutonu.Margin = new System.Windows.Forms.Padding(4);
            this.malzemeeklebutonu.Name = "malzemeeklebutonu";
            this.malzemeeklebutonu.Size = new System.Drawing.Size(121, 28);
            this.malzemeeklebutonu.TabIndex = 9;
            this.malzemeeklebutonu.Text = "Malzeme Ekle";
            this.malzemeeklebutonu.UseVisualStyleBackColor = true;
            this.malzemeeklebutonu.Click += new System.EventHandler(this.malzemeeklebutonu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "dk";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(81, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(359, 212);
            this.listBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Eklenen malzemeler:";
            // 
            // tarifitamamlabutonu
            // 
            this.tarifitamamlabutonu.Location = new System.Drawing.Point(845, 485);
            this.tarifitamamlabutonu.Name = "tarifitamamlabutonu";
            this.tarifitamamlabutonu.Size = new System.Drawing.Size(178, 38);
            this.tarifitamamlabutonu.TabIndex = 13;
            this.tarifitamamlabutonu.Text = "Tarifi Tamamla";
            this.tarifitamamlabutonu.UseVisualStyleBackColor = true;
            this.tarifitamamlabutonu.Click += new System.EventHandler(this.tarifitamamlabutonu_Click);
            // 
            // yeniKategoriEkleButonu
            // 
            this.yeniKategoriEkleButonu.Location = new System.Drawing.Point(299, 188);
            this.yeniKategoriEkleButonu.Margin = new System.Windows.Forms.Padding(4);
            this.yeniKategoriEkleButonu.Name = "yeniKategoriEkleButonu";
            this.yeniKategoriEkleButonu.Size = new System.Drawing.Size(141, 28);
            this.yeniKategoriEkleButonu.TabIndex = 14;
            this.yeniKategoriEkleButonu.Text = "Yeni kategori ekle";
            this.yeniKategoriEkleButonu.UseVisualStyleBackColor = true;
            this.yeniKategoriEkleButonu.Click += new System.EventHandler(this.yeniKategoriEkleButonu_Click);
            // 
            // TarifEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.yeniKategoriEkleButonu);
            this.Controls.Add(this.tarifitamamlabutonu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.malzemeeklebutonu);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TarifEkleForm";
            this.Text = "Tarif Ekle";
            this.Load += new System.EventHandler(this.TarifEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button malzemeeklebutonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tarifitamamlabutonu;
        private System.Windows.Forms.Button yeniKategoriEkleButonu;
    }
}