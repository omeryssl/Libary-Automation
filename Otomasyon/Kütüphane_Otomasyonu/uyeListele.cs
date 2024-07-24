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
using System.Data.SqlClient;

namespace Kütüphane_Otomasyonu
{
    public partial class uyeListele : Form
    {
        public uyeListele()
        {
            InitializeComponent();
        }
        SqlConnection baglan1 = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");
        private void uyelisteBtn_Click(object sender, EventArgs e)
        {
            verigoruntule();
        }
        private void verigoruntule()
        {
            listView1.Items.Clear();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from UyeEkle", baglan1);
            SqlDataReader oku = komut1.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["TcNo"].ToString());
                ekle.SubItems.Add(oku["UyeAdi"].ToString());
                ekle.SubItems.Add(oku["UyeSoyadi"].ToString());
                ekle.SubItems.Add(oku["TelNo"].ToString());
                ekle.SubItems.Add(oku["eposta"].ToString());
                ekle.SubItems.Add(oku["adres"].ToString());
                listView1.Items.Add(ekle);

            }
            baglan1.Close();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void anaSayfaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new kitapEkle();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new kitapListe();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapGüncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new kitapGuncelle();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new kitapSil();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new uyeEkle();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new uyeListele();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeGüncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new uyeGuncelle();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new uyeSil();
            this.Hide();
            frm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void emanetEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new emanetEkle();
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
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new uyeSil();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

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

        private void emanetGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form frm = new uyeEkle();
            this.Hide();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new uyeListele();
            this.Hide();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = new uyeGuncelle();
            this.Hide();
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form frm = new uyeSil();
            this.Hide();
            frm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label3.Text = "Üye No Giriniz:";

            }
            else
            {
                label3.Text = "Üye Adı Giriniz:";
            }
        }
        private void txttemizle()
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from UyeEkle where id='" + textBox1.Text + "'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["TcNo"].ToString());
                    ekle.SubItems.Add(oku["UyeAdi"].ToString());
                    ekle.SubItems.Add(oku["UyeSoyadi"].ToString());
                    ekle.SubItems.Add(oku["TelNo"].ToString());
                    ekle.SubItems.Add(oku["eposta"].ToString());
                    ekle.SubItems.Add(oku["adres"].ToString());
                    listView1.Items.Add(ekle);
                   

                }
                baglan1.Close();
                txttemizle();
            }
            else
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from UyeEkle where UyeAdi like'" + textBox1.Text + "%'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["TcNo"].ToString());
                    ekle.SubItems.Add(oku["UyeAdi"].ToString());
                    ekle.SubItems.Add(oku["UyeSoyadi"].ToString());
                    ekle.SubItems.Add(oku["TelNo"].ToString());
                    ekle.SubItems.Add(oku["eposta"].ToString());
                    ekle.SubItems.Add(oku["adres"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
        }

        private void qrİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new KitapQr();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
