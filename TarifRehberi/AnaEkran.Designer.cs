﻿using System;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tarifeklebutonu = new System.Windows.Forms.Button();
            this.tarifAraButonu = new System.Windows.Forms.Button();
            this.oneriAlButonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarifeklebutonu
            // 
            this.tarifeklebutonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarifeklebutonu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tarifeklebutonu.Location = new System.Drawing.Point(31, 177);
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
            this.tarifAraButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarifAraButonu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tarifAraButonu.Location = new System.Drawing.Point(31, 248);
            this.tarifAraButonu.Name = "tarifAraButonu";
            this.tarifAraButonu.Size = new System.Drawing.Size(174, 51);
            this.tarifAraButonu.TabIndex = 4;
            this.tarifAraButonu.Text = "Tarif Ara";
            this.tarifAraButonu.UseVisualStyleBackColor = true;
            this.tarifAraButonu.Click += new System.EventHandler(this.tarifAraButonu_Click);
            // 
            // oneriAlButonu
            // 
            this.oneriAlButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oneriAlButonu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oneriAlButonu.Location = new System.Drawing.Point(31, 320);
            this.oneriAlButonu.Name = "oneriAlButonu";
            this.oneriAlButonu.Size = new System.Drawing.Size(174, 51);
            this.oneriAlButonu.TabIndex = 5;
            this.oneriAlButonu.Text = "Öneri Al";
            this.oneriAlButonu.UseVisualStyleBackColor = true;
            this.oneriAlButonu.Click += new System.EventHandler(this.oneriAlButonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(930, 101);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tarif rehberine hosgeldiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(245, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 489);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(31, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "Seçilen tarifin detaylarını göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 807);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oneriAlButonu);
            this.Controls.Add(this.tarifAraButonu);
            this.Controls.Add(this.tarifeklebutonu);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}