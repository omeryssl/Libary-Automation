﻿namespace Kütüphane_Otomasyonu
{
    partial class emanetListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetListele));
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.emanetEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listeemtBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1162, 707);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Emanet Listele";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(73, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1325, 412);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Üye No";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Emanet No";
            this.columnHeader2.Width = 207;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kitap Adı";
            this.columnHeader3.Width = 185;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Alınma Tarihi";
            this.columnHeader4.Width = 282;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bitiş Tarihi";
            this.columnHeader5.Width = 203;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emanetEkleToolStripMenuItem,
            this.emanetListeleToolStripMenuItem,
            this.eToolStripMenuItem,
            this.emanetSilToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(269, 194);
            // 
            // emanetEkleToolStripMenuItem
            // 
            this.emanetEkleToolStripMenuItem.Name = "emanetEkleToolStripMenuItem";
            this.emanetEkleToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.emanetEkleToolStripMenuItem.Text = "Emanet Ekle";
            this.emanetEkleToolStripMenuItem.Click += new System.EventHandler(this.emanetEkleToolStripMenuItem_Click);
            // 
            // emanetListeleToolStripMenuItem
            // 
            this.emanetListeleToolStripMenuItem.Name = "emanetListeleToolStripMenuItem";
            this.emanetListeleToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.emanetListeleToolStripMenuItem.Text = "Emanet Listele";
            this.emanetListeleToolStripMenuItem.Click += new System.EventHandler(this.emanetListeleToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.eToolStripMenuItem.Text = "Emanet Güncelle";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // emanetSilToolStripMenuItem
            // 
            this.emanetSilToolStripMenuItem.Name = "emanetSilToolStripMenuItem";
            this.emanetSilToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.emanetSilToolStripMenuItem.Text = "Emanet Sil";
            this.emanetSilToolStripMenuItem.Click += new System.EventHandler(this.emanetSilToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.kitapİşlemlerToolStripMenuItem,
            this.üyeİşlemlerToolStripMenuItem,
            this.emanetİşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1593, 40);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // kitapİşlemlerToolStripMenuItem
            // 
            this.kitapİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem,
            this.kitapListeleToolStripMenuItem,
            this.kitapGüncelleToolStripMenuItem,
            this.kitapSilToolStripMenuItem,
            this.qrİşlemleriToolStripMenuItem});
            this.kitapİşlemlerToolStripMenuItem.Name = "kitapİşlemlerToolStripMenuItem";
            this.kitapİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(178, 36);
            this.kitapİşlemlerToolStripMenuItem.Text = "Kitap İşlemler";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(301, 44);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // kitapListeleToolStripMenuItem
            // 
            this.kitapListeleToolStripMenuItem.Name = "kitapListeleToolStripMenuItem";
            this.kitapListeleToolStripMenuItem.Size = new System.Drawing.Size(301, 44);
            this.kitapListeleToolStripMenuItem.Text = "Kitap Listele";
            this.kitapListeleToolStripMenuItem.Click += new System.EventHandler(this.kitapListeleToolStripMenuItem_Click);
            // 
            // kitapGüncelleToolStripMenuItem
            // 
            this.kitapGüncelleToolStripMenuItem.Name = "kitapGüncelleToolStripMenuItem";
            this.kitapGüncelleToolStripMenuItem.Size = new System.Drawing.Size(301, 44);
            this.kitapGüncelleToolStripMenuItem.Text = "Kitap Güncelle";
            this.kitapGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kitapGüncelleToolStripMenuItem_Click);
            // 
            // kitapSilToolStripMenuItem
            // 
            this.kitapSilToolStripMenuItem.Name = "kitapSilToolStripMenuItem";
            this.kitapSilToolStripMenuItem.Size = new System.Drawing.Size(301, 44);
            this.kitapSilToolStripMenuItem.Text = "Kitap Sil";
            this.kitapSilToolStripMenuItem.Click += new System.EventHandler(this.kitapSilToolStripMenuItem_Click);
            // 
            // qrİşlemleriToolStripMenuItem
            // 
            this.qrİşlemleriToolStripMenuItem.Name = "qrİşlemleriToolStripMenuItem";
            this.qrİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(301, 44);
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
            this.üyeİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(165, 36);
            this.üyeİşlemlerToolStripMenuItem.Text = "Üye İşlemler";
            // 
            // üyeEkleToolStripMenuItem
            // 
            this.üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            this.üyeEkleToolStripMenuItem.Size = new System.Drawing.Size(288, 44);
            this.üyeEkleToolStripMenuItem.Text = "Üye Ekle";
            this.üyeEkleToolStripMenuItem.Click += new System.EventHandler(this.üyeEkleToolStripMenuItem_Click);
            // 
            // üyeListeleToolStripMenuItem
            // 
            this.üyeListeleToolStripMenuItem.Name = "üyeListeleToolStripMenuItem";
            this.üyeListeleToolStripMenuItem.Size = new System.Drawing.Size(288, 44);
            this.üyeListeleToolStripMenuItem.Text = "Üye Listele";
            this.üyeListeleToolStripMenuItem.Click += new System.EventHandler(this.üyeListeleToolStripMenuItem_Click);
            // 
            // üyeGüncelleToolStripMenuItem
            // 
            this.üyeGüncelleToolStripMenuItem.Name = "üyeGüncelleToolStripMenuItem";
            this.üyeGüncelleToolStripMenuItem.Size = new System.Drawing.Size(288, 44);
            this.üyeGüncelleToolStripMenuItem.Text = "Üye Güncelle";
            this.üyeGüncelleToolStripMenuItem.Click += new System.EventHandler(this.üyeGüncelleToolStripMenuItem_Click);
            // 
            // üyeSilToolStripMenuItem
            // 
            this.üyeSilToolStripMenuItem.Name = "üyeSilToolStripMenuItem";
            this.üyeSilToolStripMenuItem.Size = new System.Drawing.Size(288, 44);
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
            this.emanetİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(204, 36);
            this.emanetİşlemlerToolStripMenuItem.Text = "Emanet İşlemler";
            // 
            // emanetEkleToolStripMenuItem1
            // 
            this.emanetEkleToolStripMenuItem1.Name = "emanetEkleToolStripMenuItem1";
            this.emanetEkleToolStripMenuItem1.Size = new System.Drawing.Size(327, 44);
            this.emanetEkleToolStripMenuItem1.Text = "Emanet Ekle";
            this.emanetEkleToolStripMenuItem1.Click += new System.EventHandler(this.emanetEkleToolStripMenuItem1_Click);
            // 
            // emanetListeleToolStripMenuItem1
            // 
            this.emanetListeleToolStripMenuItem1.Name = "emanetListeleToolStripMenuItem1";
            this.emanetListeleToolStripMenuItem1.Size = new System.Drawing.Size(327, 44);
            this.emanetListeleToolStripMenuItem1.Text = "Emanet Listele";
            this.emanetListeleToolStripMenuItem1.Click += new System.EventHandler(this.emanetListeleToolStripMenuItem1_Click);
            // 
            // emanetGüncelleToolStripMenuItem1
            // 
            this.emanetGüncelleToolStripMenuItem1.Name = "emanetGüncelleToolStripMenuItem1";
            this.emanetGüncelleToolStripMenuItem1.Size = new System.Drawing.Size(327, 44);
            this.emanetGüncelleToolStripMenuItem1.Text = "Emanet Güncelle";
            this.emanetGüncelleToolStripMenuItem1.Click += new System.EventHandler(this.emanetGüncelleToolStripMenuItem1_Click);
            // 
            // emanetSilToolStripMenuItem1
            // 
            this.emanetSilToolStripMenuItem1.Name = "emanetSilToolStripMenuItem1";
            this.emanetSilToolStripMenuItem1.Size = new System.Drawing.Size(327, 44);
            this.emanetSilToolStripMenuItem1.Text = "Emanet Sil";
            this.emanetSilToolStripMenuItem1.Click += new System.EventHandler(this.emanetSilToolStripMenuItem1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(96, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 42);
            this.label3.TabIndex = 62;
            this.label3.Text = "Üye No:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(255, 578);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 40);
            this.textBox1.TabIndex = 64;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(563, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 40);
            this.button1.TabIndex = 65;
            this.button1.Text = "Emanet Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İki Tarih Arası Listele"});
            this.comboBox1.Location = new System.Drawing.Point(327, 695);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 33);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listeemtBtn
            // 
            this.listeemtBtn.Image = global::Kütüphane_Otomasyonu.Properties.Resources.group1;
            this.listeemtBtn.Location = new System.Drawing.Point(1155, 527);
            this.listeemtBtn.Name = "listeemtBtn";
            this.listeemtBtn.Size = new System.Drawing.Size(243, 153);
            this.listeemtBtn.TabIndex = 5;
            this.listeemtBtn.UseVisualStyleBackColor = true;
            this.listeemtBtn.Click += new System.EventHandler(this.listeemtBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.label2.Location = new System.Drawing.Point(105, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 39);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tarih Listele:";
            // 
            // emanetListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1593, 900);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeemtBtn);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "emanetListele";
            this.Text = "Emanet Listesi";
            this.Load += new System.EventHandler(this.emanetListele_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button listeemtBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem emanetEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapSilToolStripMenuItem;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem qrİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}