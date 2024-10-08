namespace TarifRehberi
{
    partial class YeniMalzemeEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.malzemeAdıBox = new System.Windows.Forms.TextBox();
            this.malzemeBirimiBox = new System.Windows.Forms.TextBox();
            this.birimFiyatBox = new System.Windows.Forms.TextBox();
            this.yeniMalzemeEkleButonu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.depodakiMiktarBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzemenin adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birim Fiyatı:";
            // 
            // malzemeAdıBox
            // 
            this.malzemeAdıBox.Location = new System.Drawing.Point(179, 68);
            this.malzemeAdıBox.Name = "malzemeAdıBox";
            this.malzemeAdıBox.Size = new System.Drawing.Size(138, 22);
            this.malzemeAdıBox.TabIndex = 3;
            this.malzemeAdıBox.TextChanged += new System.EventHandler(this.malzemeAdıBox_TextChanged);
            // 
            // malzemeBirimiBox
            // 
            this.malzemeBirimiBox.Location = new System.Drawing.Point(179, 109);
            this.malzemeBirimiBox.Name = "malzemeBirimiBox";
            this.malzemeBirimiBox.Size = new System.Drawing.Size(138, 22);
            this.malzemeBirimiBox.TabIndex = 4;
            this.malzemeBirimiBox.TextChanged += new System.EventHandler(this.malzemeBirimiBox_TextChanged);
            // 
            // birimFiyatBox
            // 
            this.birimFiyatBox.Location = new System.Drawing.Point(179, 153);
            this.birimFiyatBox.Name = "birimFiyatBox";
            this.birimFiyatBox.Size = new System.Drawing.Size(138, 22);
            this.birimFiyatBox.TabIndex = 5;
            this.birimFiyatBox.TextChanged += new System.EventHandler(this.birimFiyatBox_TextChanged);
            // 
            // yeniMalzemeEkleButonu
            // 
            this.yeniMalzemeEkleButonu.Location = new System.Drawing.Point(66, 267);
            this.yeniMalzemeEkleButonu.Name = "yeniMalzemeEkleButonu";
            this.yeniMalzemeEkleButonu.Size = new System.Drawing.Size(251, 37);
            this.yeniMalzemeEkleButonu.TabIndex = 6;
            this.yeniMalzemeEkleButonu.Text = "Malzemeyi Ekle";
            this.yeniMalzemeEkleButonu.UseVisualStyleBackColor = true;
            this.yeniMalzemeEkleButonu.Click += new System.EventHandler(this.yeniMalzemeEkleButonu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Depodaki miktar:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // depodakiMiktarBox
            // 
            this.depodakiMiktarBox.Location = new System.Drawing.Point(179, 193);
            this.depodakiMiktarBox.Name = "depodakiMiktarBox";
            this.depodakiMiktarBox.Size = new System.Drawing.Size(138, 22);
            this.depodakiMiktarBox.TabIndex = 8;
            this.depodakiMiktarBox.TextChanged += new System.EventHandler(this.depodakiMiktarBox_TextChanged);
            // 
            // YeniMalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depodakiMiktarBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yeniMalzemeEkleButonu);
            this.Controls.Add(this.birimFiyatBox);
            this.Controls.Add(this.malzemeBirimiBox);
            this.Controls.Add(this.malzemeAdıBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniMalzemeEkle";
            this.Text = "YeniMalzemeEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox malzemeAdıBox;
        private System.Windows.Forms.TextBox malzemeBirimiBox;
        private System.Windows.Forms.TextBox birimFiyatBox;
        private System.Windows.Forms.Button yeniMalzemeEkleButonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox depodakiMiktarBox;
    }
}