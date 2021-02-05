namespace programmingLanguage
{
    partial class Form1
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
            this.satirTB = new System.Windows.Forms.RichTextBox();
            this.kodTB = new System.Windows.Forms.RichTextBox();
            this.sonucTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasılÇalışırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.örnekKodlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derleyiciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // satirTB
            // 
            this.satirTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.satirTB.Location = new System.Drawing.Point(12, 46);
            this.satirTB.Name = "satirTB";
            this.satirTB.ReadOnly = true;
            this.satirTB.Size = new System.Drawing.Size(141, 433);
            this.satirTB.TabIndex = 0;
            this.satirTB.Text = "";
            // 
            // kodTB
            // 
            this.kodTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.kodTB.Location = new System.Drawing.Point(159, 46);
            this.kodTB.Name = "kodTB";
            this.kodTB.Size = new System.Drawing.Size(1211, 433);
            this.kodTB.TabIndex = 1;
            this.kodTB.Text = "";
            this.kodTB.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // sonucTB
            // 
            this.sonucTB.BackColor = System.Drawing.Color.Black;
            this.sonucTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sonucTB.ForeColor = System.Drawing.Color.White;
            this.sonucTB.Location = new System.Drawing.Point(12, 485);
            this.sonucTB.Name = "sonucTB";
            this.sonucTB.ReadOnly = true;
            this.sonucTB.Size = new System.Drawing.Size(1358, 207);
            this.sonucTB.TabIndex = 2;
            this.sonucTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(1233, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kod Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(1206, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sonuç Ekranı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem,
            this.nasılÇalışırToolStripMenuItem,
            this.örnekKodlamalarToolStripMenuItem,
            this.derleyiciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 43);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(130, 39);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // nasılÇalışırToolStripMenuItem
            // 
            this.nasılÇalışırToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.nasılÇalışırToolStripMenuItem.Name = "nasılÇalışırToolStripMenuItem";
            this.nasılÇalışırToolStripMenuItem.Size = new System.Drawing.Size(166, 39);
            this.nasılÇalışırToolStripMenuItem.Text = "Nasıl Çalışır?";
            this.nasılÇalışırToolStripMenuItem.Click += new System.EventHandler(this.nasılÇalışırToolStripMenuItem_Click);
            // 
            // örnekKodlamalarToolStripMenuItem
            // 
            this.örnekKodlamalarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.örnekKodlamalarToolStripMenuItem.Name = "örnekKodlamalarToolStripMenuItem";
            this.örnekKodlamalarToolStripMenuItem.Size = new System.Drawing.Size(227, 39);
            this.örnekKodlamalarToolStripMenuItem.Text = "Örnek Kodlamalar";
            this.örnekKodlamalarToolStripMenuItem.Click += new System.EventHandler(this.örnekKodlamalarToolStripMenuItem_Click);
            // 
            // derleyiciToolStripMenuItem
            // 
            this.derleyiciToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.derleyiciToolStripMenuItem.Name = "derleyiciToolStripMenuItem";
            this.derleyiciToolStripMenuItem.Size = new System.Drawing.Size(221, 39);
            this.derleyiciToolStripMenuItem.Text = "Derleyiciyi Çalıştır";
            this.derleyiciToolStripMenuItem.Click += new System.EventHandler(this.derleyiciToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Satır Sayısı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1382, 704);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sonucTB);
            this.Controls.Add(this.kodTB);
            this.Controls.Add(this.satirTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kodlama Öğreniyorum";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox satirTB;
        private System.Windows.Forms.RichTextBox kodTB;
        private System.Windows.Forms.RichTextBox sonucTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasılÇalışırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem örnekKodlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derleyiciToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

