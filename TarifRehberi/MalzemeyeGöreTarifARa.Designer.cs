namespace TarifRehberi
{
    partial class MalzemeyeGöreTarifARa
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
            this.aramayıBitirButonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ekleButonu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.araButonu = new System.Windows.Forms.Button();
            this.filtreEkleButonu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aramayıBitirButonu
            // 
            this.aramayıBitirButonu.Location = new System.Drawing.Point(636, 347);
            this.aramayıBitirButonu.Name = "aramayıBitirButonu";
            this.aramayıBitirButonu.Size = new System.Drawing.Size(103, 70);
            this.aramayıBitirButonu.TabIndex = 0;
            this.aramayıBitirButonu.Text = "Aramayı bitir";
            this.aramayıBitirButonu.UseVisualStyleBackColor = true;
            this.aramayıBitirButonu.Click += new System.EventHandler(this.aramayıBitirButonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aranacak malzemeleri girin:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(389, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 84);
            this.listBox1.TabIndex = 3;
            // 
            // ekleButonu
            // 
            this.ekleButonu.Location = new System.Drawing.Point(293, 67);
            this.ekleButonu.Name = "ekleButonu";
            this.ekleButonu.Size = new System.Drawing.Size(75, 23);
            this.ekleButonu.TabIndex = 4;
            this.ekleButonu.Text = "Ekle";
            this.ekleButonu.UseVisualStyleBackColor = true;
            this.ekleButonu.Click += new System.EventHandler(this.ekleButonu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aranacak Malzemeler:";
            // 
            // araButonu
            // 
            this.araButonu.Location = new System.Drawing.Point(293, 112);
            this.araButonu.Name = "araButonu";
            this.araButonu.Size = new System.Drawing.Size(74, 38);
            this.araButonu.TabIndex = 7;
            this.araButonu.Text = "Ara";
            this.araButonu.UseVisualStyleBackColor = true;
            this.araButonu.Click += new System.EventHandler(this.araButonu_Click);
            // 
            // filtreEkleButonu
            // 
            this.filtreEkleButonu.Location = new System.Drawing.Point(636, 194);
            this.filtreEkleButonu.Name = "filtreEkleButonu";
            this.filtreEkleButonu.Size = new System.Drawing.Size(103, 64);
            this.filtreEkleButonu.TabIndex = 8;
            this.filtreEkleButonu.Text = "Filtre ekle";
            this.filtreEkleButonu.UseVisualStyleBackColor = true;
            this.filtreEkleButonu.Click += new System.EventHandler(this.filtreEkleButonu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(474, 223);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MalzemeyeGöreTarifARa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filtreEkleButonu);
            this.Controls.Add(this.araButonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ekleButonu);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aramayıBitirButonu);
            this.Name = "MalzemeyeGöreTarifARa";
            this.Text = "Malzemeye Göre Tarif Ara";
            this.Load += new System.EventHandler(this.MalzemeyeGöreTarifARa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aramayıBitirButonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ekleButonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button araButonu;
        private System.Windows.Forms.Button filtreEkleButonu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}