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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kütüphane_Otomasyonu
{
    public partial class uyeEkle : Form
    {
        public uyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True;");

        private void uyeekleBtn_Click(object sender, EventArgs e)
        {
            kelime();
            kontrol();
            if(uyenoTxt.Text == string.Empty || uyetcnoTxt.Text == string.Empty || uyeadTxt.Text == string.Empty || uyesoyadTxt.Text == string.Empty || uyetelnoTxt.Text == string.Empty || uyepostaTxt.Text == string.Empty || uyeadresTxt.Text == string.Empty)
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
                    SqlCommand komut = new SqlCommand("insert into UyeEkle(id,TcNo,UyeAdi,UyeSoyadi,TelNo,eposta,adres) values('" + uyenoTxt.Text + "','" + uyetcnoTxt.Text + "','" + uyeadTxt.Text + "','" + uyesoyadTxt.Text + "','" + uyetelnoTxt.Text + "','" + uyepostaTxt.Text + "','" + uyeadresTxt.Text + "')", baglan);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    txttemizle();
                    MessageBox.Show("Üye Eklendi");
                }
                
            }
           
        }
        private void txttemizle()
        {
            uyenoTxt.Clear();
            uyeadresTxt.Clear();
            uyepostaTxt.Clear();
            uyesoyadTxt.Clear();
            uyetcnoTxt.Clear();
            uyeadTxt.Clear();
            uyetelnoTxt.Clear();
        }

        private void uyetemizleBtn_Click(object sender, EventArgs e)
        {
            txttemizle();
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            if (uyetcnoTxt.Text != string.Empty || uyenoTxt.Text != string.Empty || uyeadTxt.Text != string.Empty || uyesoyadTxt.Text != string.Empty || uyetelnoTxt.Text != string.Empty || uyepostaTxt.Text != string.Empty || uyeadresTxt.Text != string.Empty)
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
        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new anaSayfa();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void kitapEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form AnaSayfa = new uyeEkle();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void kitapListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new uyeListele();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void kitapGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new uyeGuncelle();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void kitapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new uyeSil();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anaSayfaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new anaSayfa();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void kitapEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new kitapEkle();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void kitapListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new kitapListe();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void kitapGüncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new kitapGuncelle();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void kitapSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new kitapSil();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new uyeEkle();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void üyeListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new uyeListele();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new uyeGuncelle();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void üyeSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new uyeSil();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void emanetEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new emanetEkle();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void emanetListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new emanetListele();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void emanetGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new emanetGuncelle();
            this.Hide();
            AnaSayfa.ShowDialog();
        }

        private void emanetListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form AnaSayfa = new emanetSil();
            this.Hide();
            AnaSayfa.ShowDialog();
        }
        private void kontrol()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from UyeEkle where id=@p1 or TcNo=@p2", baglan);
            cmd.Parameters.AddWithValue("@p1", uyenoTxt.Text);
            cmd.Parameters.AddWithValue("@p2", uyetcnoTxt.Text);
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

        private void kelime()
        {
            uyeadresTxt.Text = uyeadresTxt.Text.ToLower().Trim();
            uyeadTxt.Text = uyeadTxt.Text.ToLower().Trim();
            uyesoyadTxt.Text = uyesoyadTxt.Text.ToLower().Trim();
        }

        private void uyeadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void uyenoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void uyetcnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void uyesoyadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void uyetelnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        
    }
}
