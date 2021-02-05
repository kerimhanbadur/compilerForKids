namespace programmingLanguage
{
    partial class examples
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
            this.toplama = new System.Windows.Forms.Button();
            this.cikarma = new System.Windows.Forms.Button();
            this.bolme = new System.Windows.Forms.Button();
            this.carpma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toplama
            // 
            this.toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.toplama.Location = new System.Drawing.Point(12, 12);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(166, 119);
            this.toplama.TabIndex = 0;
            this.toplama.Text = "Toplama";
            this.toplama.UseVisualStyleBackColor = true;
            this.toplama.Click += new System.EventHandler(this.toplama_Click);
            // 
            // cikarma
            // 
            this.cikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cikarma.Location = new System.Drawing.Point(236, 12);
            this.cikarma.Name = "cikarma";
            this.cikarma.Size = new System.Drawing.Size(166, 119);
            this.cikarma.TabIndex = 1;
            this.cikarma.Text = "Çıkartma";
            this.cikarma.UseVisualStyleBackColor = true;
            this.cikarma.Click += new System.EventHandler(this.cikarma_Click);
            // 
            // bolme
            // 
            this.bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bolme.Location = new System.Drawing.Point(236, 166);
            this.bolme.Name = "bolme";
            this.bolme.Size = new System.Drawing.Size(166, 119);
            this.bolme.TabIndex = 3;
            this.bolme.Text = "Bölme";
            this.bolme.UseVisualStyleBackColor = true;
            this.bolme.Click += new System.EventHandler(this.bolme_Click);
            // 
            // carpma
            // 
            this.carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.carpma.Location = new System.Drawing.Point(12, 166);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(166, 119);
            this.carpma.TabIndex = 2;
            this.carpma.Text = "Çarpma";
            this.carpma.UseVisualStyleBackColor = true;
            this.carpma.Click += new System.EventHandler(this.carpma_Click);
            // 
            // examples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(414, 297);
            this.Controls.Add(this.bolme);
            this.Controls.Add(this.carpma);
            this.Controls.Add(this.cikarma);
            this.Controls.Add(this.toplama);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "examples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Örnek Kodlamalar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toplama;
        private System.Windows.Forms.Button cikarma;
        private System.Windows.Forms.Button bolme;
        private System.Windows.Forms.Button carpma;
    }
}