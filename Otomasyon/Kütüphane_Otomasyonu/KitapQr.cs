using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using Zen.Barcode;
using ZXing.QrCode.Internal;

namespace Kütüphane_Otomasyonu
{
    public partial class KitapQr : Form
    {
        public KitapQr()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Zen.Barcode.CodeQrBarcodeDraw qrkod = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pictureBox1.Image = qrkod.Draw(textBox1.Text, 60);
            }
            else
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox2.Image = barcode.Draw(textBox1.Text, 35);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = new kitapEkle();
            this.Hide();
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form frm = new kitapListe();
            this.Hide();
            frm.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form frm = new kitapGuncelle();
            this.Hide();
            frm.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form frm = new kitapSil();
            this.Hide();
            frm.ShowDialog();
        }

        private void qrİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new KitapQr();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new uyeEkle();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new uyeListele();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new uyeGuncelle();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new uyeSil();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new emanetEkle();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new emanetListele();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetGüncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new emanetGuncelle();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new emanetSil();
            this.Hide();
            frm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new kitapEkle();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new kitapListe();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new kitapGuncelle();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new kitapSil();
            this.Hide();
            frm.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
