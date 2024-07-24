using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class UyeAnaSayfa : Form
    {
        public UyeAnaSayfa()
        {
            InitializeComponent();
        }

        private void UyeAnaSayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new UyeKitap();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form frm = new UyeEmanet();
            frm.ShowDialog();
        }

        private void kitapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new UyeKitap();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new UyeEmanet();
            this.Hide();
            frm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
