namespace TarifRehberi
{
    partial class TarifSil
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tarifiSilButonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(81, 84);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(336, 327);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tarifiSilButonu
            // 
            this.tarifiSilButonu.Location = new System.Drawing.Point(490, 355);
            this.tarifiSilButonu.Name = "tarifiSilButonu";
            this.tarifiSilButonu.Size = new System.Drawing.Size(232, 56);
            this.tarifiSilButonu.TabIndex = 1;
            this.tarifiSilButonu.Text = "Tarifi Sil";
            this.tarifiSilButonu.UseVisualStyleBackColor = true;
            this.tarifiSilButonu.Click += new System.EventHandler(this.tarifiSilButonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silinecek tarifi seçin:";
            // 
            // TarifSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarifiSilButonu);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "TarifSil";
            this.Text = "TarifSil";
            this.Load += new System.EventHandler(this.TarifSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button tarifiSilButonu;
        private System.Windows.Forms.Label label1;
    }
}