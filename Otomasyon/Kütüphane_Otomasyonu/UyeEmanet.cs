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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Kütüphane_Otomasyonu
{
    public partial class UyeEmanet : Form
    {
        public UyeEmanet()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");

        private void listeemtBtn_Click(object sender, EventArgs e)
        {
            string isim = giris.ad.ToString();
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from EmanetEkle where id='" + isim + "'", baglan);
            SqlDataReader oku = komut.ExecuteReader();
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

        private void kitapListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new UyeKitap();
            this.Hide();
            frm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
