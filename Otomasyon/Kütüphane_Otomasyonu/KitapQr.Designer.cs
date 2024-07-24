namespace Kütüphane_Otomasyonu
{
    partial class KitapQr
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.qrİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetListeleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetGüncelleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetSilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap no giriniz:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.textBox1.Location = new System.Drawing.Point(276, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(861, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 341);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Qr oluştur",
            "Barkod oluştur"});
            this.comboBox1.Location = new System.Drawing.Point(276, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 37);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(37, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "İşlem Seçiniz:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(870, 534);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 73);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.üyeİşlemlerToolStripMenuItem,
            this.emanetİşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1429, 40);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 40);
            this.toolStripMenuItem1.Text = "Ana Sayfa";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.qrİşlemleriToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 38);
            this.toolStripMenuItem2.Text = "Kitap İşlemler";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(359, 44);
            this.toolStripMenuItem3.Text = "Kitap Ekle";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(359, 44);
            this.toolStripMenuItem4.Text = "Kitap Listele";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(359, 44);
            this.toolStripMenuItem5.Text = "Kitap Güncelle";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(359, 44);
            this.toolStripMenuItem6.Text = "Kitap Sil";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // qrİşlemleriToolStripMenuItem
            // 
            this.qrİşlemleriToolStripMenuItem.Name = "qrİşlemleriToolStripMenuItem";
            this.qrİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.qrİşlemleriToolStripMenuItem.Text = "Qr İşlemleri";
            this.qrİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.qrİşlemleriToolStripMenuItem_Click);
            // 
            // üyeİşlemlerToolStripMenuItem
            // 
            this.üyeİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeEkleToolStripMenuItem,
            this.üyeListeleToolStripMenuItem,
            this.üyeGüncelleToolStripMenuItem,
            this.üyeSilToolStripMenuItem});
            this.üyeİşlemlerToolStripMenuItem.Name = "üyeİşlemlerToolStripMenuItem";
            this.üyeİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(165, 38);
            this.üyeİşlemlerToolStripMenuItem.Text = "Üye İşlemler";
            // 
            // üyeEkleToolStripMenuItem
            // 
            this.üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            this.üyeEkleToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.üyeEkleToolStripMenuItem.Text = "Üye Ekle";
            this.üyeEkleToolStripMenuItem.Click += new System.EventHandler(this.üyeEkleToolStripMenuItem_Click);
            // 
            // üyeListeleToolStripMenuItem
            // 
            this.üyeListeleToolStripMenuItem.Name = "üyeListeleToolStripMenuItem";
            this.üyeListeleToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.üyeListeleToolStripMenuItem.Text = "Üye Listele";
            this.üyeListeleToolStripMenuItem.Click += new System.EventHandler(this.üyeListeleToolStripMenuItem_Click);
            // 
            // üyeGüncelleToolStripMenuItem
            // 
            this.üyeGüncelleToolStripMenuItem.Name = "üyeGüncelleToolStripMenuItem";
            this.üyeGüncelleToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.üyeGüncelleToolStripMenuItem.Text = "Üye Güncelle";
            this.üyeGüncelleToolStripMenuItem.Click += new System.EventHandler(this.üyeGüncelleToolStripMenuItem_Click);
            // 
            // üyeSilToolStripMenuItem
            // 
            this.üyeSilToolStripMenuItem.Name = "üyeSilToolStripMenuItem";
            this.üyeSilToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.üyeSilToolStripMenuItem.Text = "Üye Sil";
            this.üyeSilToolStripMenuItem.Click += new System.EventHandler(this.üyeSilToolStripMenuItem_Click);
            // 
            // emanetİşlemlerToolStripMenuItem
            // 
            this.emanetİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emanetEkleToolStripMenuItem1,
            this.emanetListeleToolStripMenuItem1,
            this.emanetGüncelleToolStripMenuItem1,
            this.emanetSilToolStripMenuItem1});
            this.emanetİşlemlerToolStripMenuItem.Name = "emanetİşlemlerToolStripMenuItem";
            this.emanetİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.emanetİşlemlerToolStripMenuItem.Text = "Emanet İşlemler";
            // 
            // emanetEkleToolStripMenuItem1
            // 
            this.emanetEkleToolStripMenuItem1.Name = "emanetEkleToolStripMenuItem1";
            this.emanetEkleToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.emanetEkleToolStripMenuItem1.Text = "Emanet Ekle";
            this.emanetEkleToolStripMenuItem1.Click += new System.EventHandler(this.emanetEkleToolStripMenuItem1_Click);
            // 
            // emanetListeleToolStripMenuItem1
            // 
            this.emanetListeleToolStripMenuItem1.Name = "emanetListeleToolStripMenuItem1";
            this.emanetListeleToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.emanetListeleToolStripMenuItem1.Text = "Emanet Listele";
            this.emanetListeleToolStripMenuItem1.Click += new System.EventHandler(this.emanetListeleToolStripMenuItem1_Click);
            // 
            // emanetGüncelleToolStripMenuItem1
            // 
            this.emanetGüncelleToolStripMenuItem1.Name = "emanetGüncelleToolStripMenuItem1";
            this.emanetGüncelleToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.emanetGüncelleToolStripMenuItem1.Text = "Emanet Güncelle";
            this.emanetGüncelleToolStripMenuItem1.Click += new System.EventHandler(this.emanetGüncelleToolStripMenuItem1_Click);
            // 
            // emanetSilToolStripMenuItem1
            // 
            this.emanetSilToolStripMenuItem1.Name = "emanetSilToolStripMenuItem1";
            this.emanetSilToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.emanetSilToolStripMenuItem1.Text = "Emanet Sil";
            this.emanetSilToolStripMenuItem1.Click += new System.EventHandler(this.emanetSilToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem,
            this.kitapListeleToolStripMenuItem,
            this.kitapGüncelleToolStripMenuItem,
            this.kitapSilToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(243, 194);
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // kitapListeleToolStripMenuItem
            // 
            this.kitapListeleToolStripMenuItem.Name = "kitapListeleToolStripMenuItem";
            this.kitapListeleToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.kitapListeleToolStripMenuItem.Text = "Kitap Listele";
            this.kitapListeleToolStripMenuItem.Click += new System.EventHandler(this.kitapListeleToolStripMenuItem_Click);
            // 
            // kitapGüncelleToolStripMenuItem
            // 
            this.kitapGüncelleToolStripMenuItem.Name = "kitapGüncelleToolStripMenuItem";
            this.kitapGüncelleToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.kitapGüncelleToolStripMenuItem.Text = "Kitap Güncelle";
            this.kitapGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kitapGüncelleToolStripMenuItem_Click);
            // 
            // kitapSilToolStripMenuItem
            // 
            this.kitapSilToolStripMenuItem.Name = "kitapSilToolStripMenuItem";
            this.kitapSilToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.kitapSilToolStripMenuItem.Text = "Kitap Sil";
            this.kitapSilToolStripMenuItem.Click += new System.EventHandler(this.kitapSilToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // KitapQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1429, 998);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "KitapQr";
            this.Text = "KitapQr";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem qrİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emanetListeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emanetGüncelleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emanetSilToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}