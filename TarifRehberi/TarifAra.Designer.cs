﻿namespace TarifRehberi
{
    partial class TarifAra
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.malzemeyeGöreTarifAraButonu = new System.Windows.Forms.Button();
            this.aramayıBitirButonu = new System.Windows.Forms.Button();
            this.filtreEkleButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aradığınız tarifin adını girin:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(47, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(643, 260);
            this.listBox1.TabIndex = 2;
            // 
            // malzemeyeGöreTarifAraButonu
            // 
            this.malzemeyeGöreTarifAraButonu.Location = new System.Drawing.Point(469, 66);
            this.malzemeyeGöreTarifAraButonu.Name = "malzemeyeGöreTarifAraButonu";
            this.malzemeyeGöreTarifAraButonu.Size = new System.Drawing.Size(221, 32);
            this.malzemeyeGöreTarifAraButonu.TabIndex = 3;
            this.malzemeyeGöreTarifAraButonu.Text = "Malzemeye göre tarif ara";
            this.malzemeyeGöreTarifAraButonu.UseVisualStyleBackColor = true;
            this.malzemeyeGöreTarifAraButonu.Click += new System.EventHandler(this.malzemeyeGöreTarifAraButonu_Click);
            // 
            // aramayıBitirButonu
            // 
            this.aramayıBitirButonu.Location = new System.Drawing.Point(568, 377);
            this.aramayıBitirButonu.Name = "aramayıBitirButonu";
            this.aramayıBitirButonu.Size = new System.Drawing.Size(122, 40);
            this.aramayıBitirButonu.TabIndex = 4;
            this.aramayıBitirButonu.Text = "Aramayı bitir";
            this.aramayıBitirButonu.UseVisualStyleBackColor = true;
            this.aramayıBitirButonu.Click += new System.EventHandler(this.aramayıBitirButonu_Click);
            // 
            // filtreEkleButonu
            // 
            this.filtreEkleButonu.Location = new System.Drawing.Point(706, 111);
            this.filtreEkleButonu.Name = "filtreEkleButonu";
            this.filtreEkleButonu.Size = new System.Drawing.Size(58, 55);
            this.filtreEkleButonu.TabIndex = 5;
            this.filtreEkleButonu.Text = "Filtre ekle";
            this.filtreEkleButonu.UseVisualStyleBackColor = true;
            this.filtreEkleButonu.Click += new System.EventHandler(this.filtreEkleButonu_Click);
            // 
            // TarifAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filtreEkleButonu);
            this.Controls.Add(this.aramayıBitirButonu);
            this.Controls.Add(this.malzemeyeGöreTarifAraButonu);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "TarifAra";
            this.Text = "Tarif Ara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button malzemeyeGöreTarifAraButonu;
        private System.Windows.Forms.Button aramayıBitirButonu;
        private System.Windows.Forms.Button filtreEkleButonu;
    }
}