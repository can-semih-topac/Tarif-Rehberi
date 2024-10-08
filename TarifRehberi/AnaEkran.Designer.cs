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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tarifeklebutonu = new System.Windows.Forms.Button();
            this.tarifguncellebutonu = new System.Windows.Forms.Button();
            this.tarifsilbutonu = new System.Windows.Forms.Button();
            this.tarifAraButonu = new System.Windows.Forms.Button();
            this.oneriAlButonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(179, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(797, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // tarifeklebutonu
            // 
            this.tarifeklebutonu.Location = new System.Drawing.Point(16, 111);
            this.tarifeklebutonu.Margin = new System.Windows.Forms.Padding(4);
            this.tarifeklebutonu.Name = "tarifeklebutonu";
            this.tarifeklebutonu.Size = new System.Drawing.Size(121, 50);
            this.tarifeklebutonu.TabIndex = 1;
            this.tarifeklebutonu.Text = "Tarif Ekle";
            this.tarifeklebutonu.UseVisualStyleBackColor = true;
            this.tarifeklebutonu.Click += new System.EventHandler(this.tarifeklebutonu_Click);
            // 
            // tarifguncellebutonu
            // 
            this.tarifguncellebutonu.Location = new System.Drawing.Point(16, 186);
            this.tarifguncellebutonu.Margin = new System.Windows.Forms.Padding(4);
            this.tarifguncellebutonu.Name = "tarifguncellebutonu";
            this.tarifguncellebutonu.Size = new System.Drawing.Size(121, 49);
            this.tarifguncellebutonu.TabIndex = 2;
            this.tarifguncellebutonu.Text = "Tarif Güncelle";
            this.tarifguncellebutonu.UseVisualStyleBackColor = true;
            this.tarifguncellebutonu.Click += new System.EventHandler(this.tarifguncellebutonu_Click);
            // 
            // tarifsilbutonu
            // 
            this.tarifsilbutonu.Location = new System.Drawing.Point(16, 259);
            this.tarifsilbutonu.Name = "tarifsilbutonu";
            this.tarifsilbutonu.Size = new System.Drawing.Size(121, 48);
            this.tarifsilbutonu.TabIndex = 3;
            this.tarifsilbutonu.Text = "Tarif Sil";
            this.tarifsilbutonu.UseVisualStyleBackColor = true;
            this.tarifsilbutonu.Click += new System.EventHandler(this.tarifsilbutonu_Click);
            // 
            // tarifAraButonu
            // 
            this.tarifAraButonu.Location = new System.Drawing.Point(385, 44);
            this.tarifAraButonu.Name = "tarifAraButonu";
            this.tarifAraButonu.Size = new System.Drawing.Size(174, 51);
            this.tarifAraButonu.TabIndex = 4;
            this.tarifAraButonu.Text = "Tarif Ara";
            this.tarifAraButonu.UseVisualStyleBackColor = true;
            this.tarifAraButonu.Click += new System.EventHandler(this.tarifAraButonu_Click);
            // 
            // oneriAlButonu
            // 
            this.oneriAlButonu.Location = new System.Drawing.Point(603, 44);
            this.oneriAlButonu.Name = "oneriAlButonu";
            this.oneriAlButonu.Size = new System.Drawing.Size(153, 51);
            this.oneriAlButonu.TabIndex = 5;
            this.oneriAlButonu.Text = "Öneri Al";
            this.oneriAlButonu.UseVisualStyleBackColor = true;
            this.oneriAlButonu.Click += new System.EventHandler(this.oneriAlButonu_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.oneriAlButonu);
            this.Controls.Add(this.tarifAraButonu);
            this.Controls.Add(this.tarifsilbutonu);
            this.Controls.Add(this.tarifguncellebutonu);
            this.Controls.Add(this.tarifeklebutonu);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaEkran";
            this.Text = "Ana Ekran";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tarifeklebutonu;
        private System.Windows.Forms.Button tarifguncellebutonu;
        private System.Windows.Forms.Button tarifsilbutonu;
        private System.Windows.Forms.Button tarifAraButonu;
        private System.Windows.Forms.Button oneriAlButonu;
    }
}

