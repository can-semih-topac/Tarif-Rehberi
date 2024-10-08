namespace TarifRehberi
{
    partial class FiltreEkle
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
            this.filtreEkleButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filtreEkleButonu
            // 
            this.filtreEkleButonu.Location = new System.Drawing.Point(279, 368);
            this.filtreEkleButonu.Name = "filtreEkleButonu";
            this.filtreEkleButonu.Size = new System.Drawing.Size(108, 49);
            this.filtreEkleButonu.TabIndex = 0;
            this.filtreEkleButonu.Text = "Ekle";
            this.filtreEkleButonu.UseVisualStyleBackColor = true;
            this.filtreEkleButonu.Click += new System.EventHandler(this.filtreEkleButonu_Click);
            // 
            // FiltreEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.filtreEkleButonu);
            this.Name = "FiltreEkle";
            this.Text = "Filtre Ekle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button filtreEkleButonu;
    }
}