namespace TarifRehberi
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
            this.tarifAdi = new System.Windows.Forms.TextBox();
            this.malzemeyeGöreTarifAraButonu = new System.Windows.Forms.Button();
            this.aramayıBitirButonu = new System.Windows.Forms.Button();
            this.filtreEkleButonu = new System.Windows.Forms.Button();
            this.adaGoreTarifAraButonu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aradığınız tarifin adını girin:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tarifAdi
            // 
            this.tarifAdi.Location = new System.Drawing.Point(213, 70);
            this.tarifAdi.Name = "tarifAdi";
            this.tarifAdi.Size = new System.Drawing.Size(138, 22);
            this.tarifAdi.TabIndex = 1;
            this.tarifAdi.TextChanged += new System.EventHandler(this.tarifAdi_TextChanged);
            // 
            // malzemeyeGöreTarifAraButonu
            // 
            this.malzemeyeGöreTarifAraButonu.Location = new System.Drawing.Point(510, 65);
            this.malzemeyeGöreTarifAraButonu.Name = "malzemeyeGöreTarifAraButonu";
            this.malzemeyeGöreTarifAraButonu.Size = new System.Drawing.Size(180, 32);
            this.malzemeyeGöreTarifAraButonu.TabIndex = 3;
            this.malzemeyeGöreTarifAraButonu.Text = "Malzemeye göre tarif ara";
            this.malzemeyeGöreTarifAraButonu.UseVisualStyleBackColor = true;
            this.malzemeyeGöreTarifAraButonu.Click += new System.EventHandler(this.malzemeyeGöreTarifAraButonu_Click);
            // 
            // aramayıBitirButonu
            // 
            this.aramayıBitirButonu.Location = new System.Drawing.Point(695, 306);
            this.aramayıBitirButonu.Name = "aramayıBitirButonu";
            this.aramayıBitirButonu.Size = new System.Drawing.Size(75, 65);
            this.aramayıBitirButonu.TabIndex = 4;
            this.aramayıBitirButonu.Text = "Aramayı bitir";
            this.aramayıBitirButonu.UseVisualStyleBackColor = true;
            this.aramayıBitirButonu.Click += new System.EventHandler(this.aramayıBitirButonu_Click);
            // 
            // filtreEkleButonu
            // 
            this.filtreEkleButonu.Location = new System.Drawing.Point(696, 111);
            this.filtreEkleButonu.Name = "filtreEkleButonu";
            this.filtreEkleButonu.Size = new System.Drawing.Size(74, 65);
            this.filtreEkleButonu.TabIndex = 5;
            this.filtreEkleButonu.Text = "Filtre ekle";
            this.filtreEkleButonu.UseVisualStyleBackColor = true;
            this.filtreEkleButonu.Click += new System.EventHandler(this.filtreEkleButonu_Click);
            // 
            // adaGoreTarifAraButonu
            // 
            this.adaGoreTarifAraButonu.Location = new System.Drawing.Point(358, 69);
            this.adaGoreTarifAraButonu.Name = "adaGoreTarifAraButonu";
            this.adaGoreTarifAraButonu.Size = new System.Drawing.Size(75, 23);
            this.adaGoreTarifAraButonu.TabIndex = 6;
            this.adaGoreTarifAraButonu.Text = "Ara";
            this.adaGoreTarifAraButonu.UseVisualStyleBackColor = true;
            this.adaGoreTarifAraButonu.Click += new System.EventHandler(this.adaGoreTarifAraButonu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 260);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TarifAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adaGoreTarifAraButonu);
            this.Controls.Add(this.filtreEkleButonu);
            this.Controls.Add(this.aramayıBitirButonu);
            this.Controls.Add(this.malzemeyeGöreTarifAraButonu);
            this.Controls.Add(this.tarifAdi);
            this.Controls.Add(this.label1);
            this.Name = "TarifAra";
            this.Text = "Tarif Ara";
            this.Load += new System.EventHandler(this.TarifAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tarifAdi;
        private System.Windows.Forms.Button malzemeyeGöreTarifAraButonu;
        private System.Windows.Forms.Button aramayıBitirButonu;
        private System.Windows.Forms.Button filtreEkleButonu;
        private System.Windows.Forms.Button adaGoreTarifAraButonu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}