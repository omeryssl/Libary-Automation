using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class emanetGuncelle : Form
    {
        public emanetGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");
        int id = 0;
        private void verigoruntule()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("select * from EmanetEkle", baglan);
            SqlDataReader oku = komut1.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["EmanetNo"].ToString());
                ekle.SubItems.Add(oku["KitapAdi"].ToString());
                ekle.SubItems.Add(oku["Baslangic"].ToString());
                ekle.SubItems.Add(oku["Bitis"].ToString());
                listView1.Items.Add(ekle);


            }
            baglan.Close();


        }

        private void emanetEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new emanetEkle();
            this.Hide();
            frm.ShowDialog();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
            this.Hide();
            frm.ShowDialog();
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
            frm.ShowDialog();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new uyeSil();
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

        private void emanetEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new emanetEkle();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new emanetListele();
            this.Hide();
            frm.ShowDialog();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new emanetGuncelle();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new emanetSil();
            this.Hide();
            frm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            guncelemtuyenoTxt.Text = listView1.SelectedItems[0].SubItems[0].Text;
            guncelemtnoTxt.Text = listView1.SelectedItems[0].SubItems[1].Text;
            guncelemtkitapadTxt.Text = listView1.SelectedItems[0].SubItems[2].Text;
            guncelemtbaslaTxt.Text = listView1.SelectedItems[0].SubItems[3].Text;
            guncelemtbitisTxt.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }
        private void txttemizle()
        {
            guncelemtuyenoTxt.Clear();
            guncelemtnoTxt.Clear();
            guncelemtkitapadTxt.Clear();
            guncelemtbaslaTxt.Clear();
            guncelemtbitisTxt.Clear();
        }

        private void guncelemtBtn_Click(object sender, EventArgs e)
        {
            kelime();
            baglan.Open();
            SqlCommand komut = new SqlCommand("update EmanetEkle set id='" + guncelemtuyenoTxt.Text + "',EmanetNo='" + guncelemtnoTxt.Text + "',KitapAdi='" + guncelemtkitapadTxt.Text + "',Baslangic='" + guncelemtbaslaTxt.Text + "',Bitis='" + guncelemtbitisTxt.Text + "' where id = " + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verigoruntule();
            txttemizle();
        }

        private void emanetGuncelle_Load(object sender, EventArgs e)
        {
            verigoruntule();
        }

        private void guncelemttemizleBtn_Click(object sender, EventArgs e)
        {
            txttemizle();
        }

        private void guncelemtiptalBtn_Click(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void qrİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new KitapQr();
            this.Hide();
            frm.ShowDialog();
        }

        private void guncelemtkitapadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void guncelemtnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void guncelemtuyenoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kelime()
        {
            guncelemtkitapadTxt.Text = guncelemtkitapadTxt.Text.ToLower().Trim();

        }

        private void guncelemtuyenoTxt_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from EmanetEkle where id like'" + guncelemtuyenoTxt.Text + "'", baglan);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guncelemtnoTxt.Text = reader["EmanetNo"].ToString();
                guncelemtkitapadTxt.Text = reader[2].ToString();
                guncelemtbaslaTxt.Text = reader[3].ToString();
                guncelemtbitisTxt.Text = reader[4].ToString();

            }
            baglan.Close();
        }
    }
}
