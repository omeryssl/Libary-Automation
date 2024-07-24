namespace Kütüphane_Otomasyonu
{
    partial class UyeAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kitapListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetlerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(519, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 100);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kitap Listesi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "İşlemler";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.SaddleBrown;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(817, 366);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(262, 100);
            this.button11.TabIndex = 6;
            this.button11.Text = "Aldığım Emanetler";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapListesiToolStripMenuItem,
            this.emanetlerimToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 118);
            // 
            // kitapListesiToolStripMenuItem
            // 
            this.kitapListesiToolStripMenuItem.Name = "kitapListesiToolStripMenuItem";
            this.kitapListesiToolStripMenuItem.Size = new System.Drawing.Size(222, 38);
            this.kitapListesiToolStripMenuItem.Text = "Kitap Listesi";
            this.kitapListesiToolStripMenuItem.Click += new System.EventHandler(this.kitapListesiToolStripMenuItem_Click);
            // 
            // emanetlerimToolStripMenuItem
            // 
            this.emanetlerimToolStripMenuItem.Name = "emanetlerimToolStripMenuItem";
            this.emanetlerimToolStripMenuItem.Size = new System.Drawing.Size(222, 38);
            this.emanetlerimToolStripMenuItem.Text = "Emanetlerim";
            this.emanetlerimToolStripMenuItem.Click += new System.EventHandler(this.emanetlerimToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(222, 38);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // UyeAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kütüphane_Otomasyonu.Properties.Resources.anasayfa;
            this.ClientSize = new System.Drawing.Size(1610, 895);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Name = "UyeAnaSayfa";
            this.Text = "UyeAnaSayfa";
            this.Load += new System.EventHandler(this.UyeAnaSayfa_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetlerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}