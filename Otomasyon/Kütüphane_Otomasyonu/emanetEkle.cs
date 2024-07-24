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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kütüphane_Otomasyonu
{
    public partial class emanetEkle : Form
    {
        public emanetEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True;");

        private void txttemizle()
        {
            emanetuyenoTxt.Clear();
            emanetnoTxt.Clear();
            emanetktpadTxt.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
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
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void emanetekleBtn_Click(object sender, EventArgs e)
        {
            kelime();
            kontrol();
            if (emanetuyenoTxt.Text == string.Empty || emanetnoTxt.Text == string.Empty || emanetktpadTxt.Text == string.Empty || textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Bilgiler Eksiksiz Doldurulmalıdır.");
            }
            else
            {
                if (durum == false)
                {
                    MessageBox.Show("böyle bir kayıt var!");
                }
                else
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("insert into EmanetEkle(id,EmanetNo,KitapAdi,Baslangic,Bitis) values('" + emanetuyenoTxt.Text + "','" + emanetnoTxt.Text + "','" + emanetktpadTxt.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')", baglan);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    txttemizle();
                    MessageBox.Show("Emanet Eklendi");
                }

            }
        }

        private void emanetiptalBtn_Click(object sender, EventArgs e)
        {
            if (emanetuyenoTxt.Text != string.Empty || emanetnoTxt.Text != string.Empty || emanetktpadTxt.Text != string.Empty || textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                if (MessageBox.Show("Devam Eden İşleminiz Var! Çıkmak İstiyor musunuz?", "Emin Misiniz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Form frm = new anaSayfa();
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            else
            {
                Form frm = new anaSayfa();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void emanettemizleBtn_Click(object sender, EventArgs e)
        {
            txttemizle();
        }
        private void kontrol()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from EmanetEkle where EmanetNo=@p1", baglan);
            cmd.Parameters.AddWithValue("@p1", emanetnoTxt.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglan.Close();
        }
        bool durum;

        private void qrİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new KitapQr();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetEkle_Load(object sender, EventArgs e)
        {

        }
        
        private void kelime()
        {
            emanetktpadTxt.Text = emanetktpadTxt.Text.ToLower().Trim();

        }

        private void emanetuyenoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void emanetnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void emanetktpadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
