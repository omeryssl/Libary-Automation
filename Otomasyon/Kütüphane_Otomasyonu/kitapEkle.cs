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
    public partial class kitapEkle : Form
    {
        public kitapEkle()
        {
            InitializeComponent();
        }
        bool durum;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True;");

        private void txttemizle()
        {
            textBox1.Clear();
            ktpekleadTxt.Clear();
            ktpekleyazaradTxt.Clear();
            ktpekleyayinevTxt.Clear();
            ktpeklesyfsayisiTxt.Clear();
            ktpekleyayimyiliTxt.Clear();
            ktpeklediliTxt.Clear();
            textBox2.Clear();
        }

        private void ktpekleBtn_Click(object sender, EventArgs e)
        {
            kelime();
            kontrol(); 
            if (textBox1.Text == string.Empty || ktpekleadTxt.Text == string.Empty || ktpekleyazaradTxt.Text == string.Empty || ktpekleyayinevTxt.Text == string.Empty || ktpeklesyfsayisiTxt.Text == string.Empty || ktpekleyayimyiliTxt.Text == string.Empty || ktpeklediliTxt.Text == string.Empty || textBox2.Text == string.Empty)
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
                    SqlCommand komut = new SqlCommand("insert into KitapEkle(id,KitapAdi,YazarAdi,YayinEvi,SayfaSayisi,YayimYili,Dil,Tur) values('" + textBox1.Text + "','" + ktpekleadTxt.Text + "','" + ktpekleyazaradTxt.Text + "','" + ktpekleyayinevTxt.Text + "','" + ktpeklesyfsayisiTxt.Text + "','" + ktpekleyayimyiliTxt.Text + "','" + ktpeklediliTxt.Text + "','" + textBox2.Text + "')", baglan);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    txttemizle();
                    MessageBox.Show("Kitap Eklendi");
                }
                
            }
            

        }

        private void ktpekleiptalBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || ktpekleadTxt.Text != string.Empty || ktpekleyazaradTxt.Text != string.Empty || ktpekleyayinevTxt.Text != string.Empty || ktpeklesyfsayisiTxt.Text != string.Empty || ktpekleyayimyiliTxt.Text != string.Empty || ktpeklediliTxt.Text != string.Empty)
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

        private void ktpekletemizleBtn_Click(object sender, EventArgs e)
        {
            txttemizle();
        }

        private void ktpekleadTxt_TextChanged(object sender, EventArgs e)
        {

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

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
            this.Hide();
            frm.ShowDialog();
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
        private void kontrol()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from KitapEkle where id=@p1",baglan);
            cmd.Parameters.AddWithValue("@p1",textBox1.Text);
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

        private void qrİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new KitapQr();
            this.Hide();
            frm.ShowDialog();
        }
        private void kelime()
        {
            ktpekleadTxt.Text = ktpekleadTxt.Text.ToLower();
            ktpekleyazaradTxt.Text= ktpekleyazaradTxt.Text.ToLower();
            ktpekleyayinevTxt.Text = ktpekleyayinevTxt.Text.ToLower();
            ktpeklediliTxt.Text = ktpeklediliTxt.Text.ToLower();
            textBox2.Text= textBox2.Text.ToLower().Trim();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ktpeklesyfsayisiTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ktpekleyayimyiliTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ktpekleadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ktpekleyazaradTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void ktpekleyayinevTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ktpeklediliTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
