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
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Kütüphane_Otomasyonu
{
    public partial class kitapListe : Form
    {
        public kitapListe()
        {
            InitializeComponent();
        }
        SqlConnection baglan1 = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");

        int saniye = 0;
        private void verigoruntule()
        {
            listView1.Items.Clear();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from KitapEkle",baglan1);
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

        private void ktplisteleanasayfaBtn_Click(object sender, EventArgs e)
        {

        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new kitapEkle();
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

        private void kitapListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new kitapListe();
            this.Hide();
            frm.ShowDialog();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            else 
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
        
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void anaSayfaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void üyeEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new uyeSil();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeListeleToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void üyeSilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new uyeSil();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new emanetEkle();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetListeleToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void kitapEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new kitapEkle();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapListeleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new kitapListe();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapGüncelleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new kitapGuncelle();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapSilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new kitapSil();
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

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void emanetListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new emanetSil();
            this.Hide();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox2.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
            saniye = 1;
            timer2.Start();
            
          

        }

        private void kitapListe_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            for (int i = 0; i < filterInfoCollection.Count; i++)
            {
                comboBox2.Items.Add(filterInfoCollection[i].Name);
            }
            baglan1.Open();
            SqlCommand komut = new SqlCommand("select * from Stok", baglan1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                
                label7.Text = oku["Sayi"].ToString();


            }
            baglan1.Close();

        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button2_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image != null)
            {
               
                BarcodeReader barkod = new BarcodeReader();
                Result result = barkod.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    textBox2.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }
        private void qrgoruntu()
        {
            listView1.Items.Clear();
            baglan1.Open();
            SqlCommand komut = new SqlCommand("select * from KitapEkle where id='" + textBox2.Text + "'", baglan1); ;
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
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye <0)
            {
                timer2.Stop();
                qrgoruntu();
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
