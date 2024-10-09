namespace TarifRehberi
{
    partial class MalzemeEkle
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.yeniMalzemeEkleButonu = new System.Windows.Forms.Button();
            this.malzemeeklemeyitamamlabutonu = new System.Windows.Forms.Button();
            this.secilenmalzemeyieklebutonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme seç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miktar gir";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seçili malzemeler";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 97);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(50, 237);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(434, 276);
            this.listBox1.TabIndex = 5;
            // 
            // yeniMalzemeEkleButonu
            // 
            this.yeniMalzemeEkleButonu.Location = new System.Drawing.Point(566, 97);
            this.yeniMalzemeEkleButonu.Name = "yeniMalzemeEkleButonu";
            this.yeniMalzemeEkleButonu.Size = new System.Drawing.Size(244, 66);
            this.yeniMalzemeEkleButonu.TabIndex = 6;
            this.yeniMalzemeEkleButonu.Text = "Yeni malzeme ekle";
            this.yeniMalzemeEkleButonu.UseVisualStyleBackColor = true;
            this.yeniMalzemeEkleButonu.Click += new System.EventHandler(this.yeniMalzemeEkleButonu_Click);
            // 
            // malzemeeklemeyitamamlabutonu
            // 
            this.malzemeeklemeyitamamlabutonu.Location = new System.Drawing.Point(566, 237);
            this.malzemeeklemeyitamamlabutonu.Name = "malzemeeklemeyitamamlabutonu";
            this.malzemeeklemeyitamamlabutonu.Size = new System.Drawing.Size(244, 57);
            this.malzemeeklemeyitamamlabutonu.TabIndex = 7;
            this.malzemeeklemeyitamamlabutonu.Text = "Malzeme Eklemeyi tamamla";
            this.malzemeeklemeyitamamlabutonu.UseVisualStyleBackColor = true;
            this.malzemeeklemeyitamamlabutonu.Click += new System.EventHandler(this.malzemeEklemeyiTamamlaButonu_Click);
            // 
            // secilenmalzemeyieklebutonu
            // 
            this.secilenmalzemeyieklebutonu.Location = new System.Drawing.Point(397, 97);
            this.secilenmalzemeyieklebutonu.Name = "secilenmalzemeyieklebutonu";
            this.secilenmalzemeyieklebutonu.Size = new System.Drawing.Size(87, 23);
            this.secilenmalzemeyieklebutonu.TabIndex = 8;
            this.secilenmalzemeyieklebutonu.Text = "Ekle";
            this.secilenmalzemeyieklebutonu.UseVisualStyleBackColor = true;
            this.secilenmalzemeyieklebutonu.Click += new System.EventHandler(this.secilenMalzemeyiEkleButonu_Click);
            // 
            // MalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.secilenmalzemeyieklebutonu);
            this.Controls.Add(this.malzemeeklemeyitamamlabutonu);
            this.Controls.Add(this.yeniMalzemeEkleButonu);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MalzemeEkle";
            this.Text = "MalzemeEkle";
            this.Load += new System.EventHandler(this.MalzemeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button yeniMalzemeEkleButonu;
        private System.Windows.Forms.Button malzemeeklemeyitamamlabutonu;
        private System.Windows.Forms.Button secilenmalzemeyieklebutonu;
    }
}