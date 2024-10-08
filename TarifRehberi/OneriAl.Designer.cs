namespace TarifRehberi
{
    partial class OneriAl
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
            this.oneriAlmayıBitirButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oneriAlmayıBitirButonu
            // 
            this.oneriAlmayıBitirButonu.Location = new System.Drawing.Point(617, 369);
            this.oneriAlmayıBitirButonu.Name = "oneriAlmayıBitirButonu";
            this.oneriAlmayıBitirButonu.Size = new System.Drawing.Size(114, 44);
            this.oneriAlmayıBitirButonu.TabIndex = 0;
            this.oneriAlmayıBitirButonu.Text = "Öneri almayı bitir";
            this.oneriAlmayıBitirButonu.UseVisualStyleBackColor = true;
            this.oneriAlmayıBitirButonu.Click += new System.EventHandler(this.oneriAlmayıBitirButonu_Click);
            // 
            // OneriAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oneriAlmayıBitirButonu);
            this.Name = "OneriAl";
            this.Text = "Öneri Al";
            this.Load += new System.EventHandler(this.OneriAl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oneriAlmayıBitirButonu;
    }
}