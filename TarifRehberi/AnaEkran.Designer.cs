using System;

namespace TarifRehberi
{
    partial class AnaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tarifeklebutonu = new System.Windows.Forms.Button();
            this.tarifAraButonu = new System.Windows.Forms.Button();
            this.oneriAlButonu = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarifeklebutonu
            // 
            this.tarifeklebutonu.Location = new System.Drawing.Point(31, 200);
            this.tarifeklebutonu.Margin = new System.Windows.Forms.Padding(4);
            this.tarifeklebutonu.Name = "tarifeklebutonu";
            this.tarifeklebutonu.Size = new System.Drawing.Size(174, 50);
            this.tarifeklebutonu.TabIndex = 1;
            this.tarifeklebutonu.Text = "Yeni Tarif Ekle";
            this.tarifeklebutonu.UseVisualStyleBackColor = true;
            this.tarifeklebutonu.Click += new System.EventHandler(this.tarifeklebutonu_Click);
            // 
            // tarifAraButonu
            // 
            this.tarifAraButonu.Location = new System.Drawing.Point(31, 267);
            this.tarifAraButonu.Name = "tarifAraButonu";
            this.tarifAraButonu.Size = new System.Drawing.Size(174, 51);
            this.tarifAraButonu.TabIndex = 4;
            this.tarifAraButonu.Text = "Tarif Ara";
            this.tarifAraButonu.UseVisualStyleBackColor = true;
            this.tarifAraButonu.Click += new System.EventHandler(this.tarifAraButonu_Click);
            // 
            // oneriAlButonu
            // 
            this.oneriAlButonu.Location = new System.Drawing.Point(31, 338);
            this.oneriAlButonu.Name = "oneriAlButonu";
            this.oneriAlButonu.Size = new System.Drawing.Size(174, 51);
            this.oneriAlButonu.TabIndex = 5;
            this.oneriAlButonu.Text = "Öneri Al";
            this.oneriAlButonu.UseVisualStyleBackColor = true;
            this.oneriAlButonu.Click += new System.EventHandler(this.oneriAlButonu_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(497, 477);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(392, 36);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 110);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tarif rehberine\r\nhosgeldiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tarif Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hazırlanma Süresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Maliyet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 268);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.oneriAlButonu);
            this.Controls.Add(this.tarifAraButonu);
            this.Controls.Add(this.tarifeklebutonu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaEkran";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Button tarifeklebutonu;
        private System.Windows.Forms.Button tarifAraButonu;
        private System.Windows.Forms.Button oneriAlButonu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}