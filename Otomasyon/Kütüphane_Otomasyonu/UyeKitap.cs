using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyonu
{
    public partial class UyeKitap : Form
    {
        public UyeKitap()
        {
            InitializeComponent();
        }
        SqlConnection baglan1 = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");
        private void verigoruntule()
        {
            listView1.Items.Clear();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from KitapEkle", baglan1);
            SqlDataReader oku = komut1.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["KitapAdi"].ToString());
                ekle.SubItems.Add(oku["YazarAdi"].ToString());
                ekle.SubItems.Add(oku["YayinEvi"].ToString());
                ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                ekle.SubItems.Add(oku["YayimYili"].ToString());
                ekle.SubItems.Add(oku["Dil"].ToString());
                ekle.SubItems.Add(oku["Tur"].ToString());
                listView1.Items.Add(ekle);

            }
            baglan1.Close();
        }

        private void kitaplisteleBtn_Click(object sender, EventArgs e)
        {
            verigoruntule();
        }
        private void txttemizle()
        {
            textBox1.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label3.Text = "Kitap Adını Giriniz:";

            }
            else
            {
                label3.Text = "Yazar Adını Giriniz:";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where Tur='Klasikler'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where Tur='Edebiyat'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where Tur='Bilim Kurgu'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where Tur='Korku'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where Tur='Din'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
            else
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where Tur='Şiir'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == -1)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where KitapAdi like'" + textBox1.Text + "%'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where KitapAdi like'" + textBox1.Text + "%' and Tur='Klasikler'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where KitapAdi like'" + textBox1.Text + "%' and Tur='Edebiyat'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where KitapAdi like'" + textBox1.Text + "%' and Tur='Bilim Kurgu'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where KitapAdi like'" + textBox1.Text + "%' and Tur='Korku'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 4)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where KitapAdi like'" + textBox1.Text + "%' and Tur='Din'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 5)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where KitapAdi like'" + textBox1.Text + "%' and Tur='Şiir'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }

            else if(comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == -1)
            {
                listView1.Items.Clear();
                baglan1.Open();
                SqlCommand komut = new SqlCommand("select * from KitapEkle where YazarAdi like'" + textBox1.Text + "%'", baglan1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["YazarAdi"].ToString());
                    ekle.SubItems.Add(oku["YayinEvi"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                    ekle.SubItems.Add(oku["YayimYili"].ToString());
                    ekle.SubItems.Add(oku["Dil"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan1.Close();
                txttemizle();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new UyeAnaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new UyeAnaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new UyeEmanet();
            this.Hide();
            form.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
