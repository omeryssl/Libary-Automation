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
    public partial class kitapGuncelle : Form
    {
        public kitapGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");
        int id = 0;
        private void verigoruntule()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("select * from KitapEkle", baglan);
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
            baglan.Close();
        }
        private void txttemizle()
        {
            textBox1.Clear();
            guncelkitapadTxt.Clear();
            guncelkitapyazaradTxt.Clear();
            guncelkitapyayinevTxt.Clear();
            guncelkitapsyfsayisiTxt.Clear();
            guncelkitapyayimyiliTxt.Clear();
            guncelkitapdiliTxt.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verigoruntule();
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            guncelkitapadTxt.Text = listView1.SelectedItems[0].SubItems[1].Text;
            guncelkitapyazaradTxt.Text = listView1.SelectedItems[0].SubItems[2].Text;
            guncelkitapyayinevTxt.Text = listView1.SelectedItems[0].SubItems[3].Text;
            guncelkitapsyfsayisiTxt.Text = listView1.SelectedItems[0].SubItems[4].Text;
            guncelkitapyayimyiliTxt.Text = listView1.SelectedItems[0].SubItems[5].Text;
            guncelkitapdiliTxt.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }

        private void guncelkitapBtn_Click(object sender, EventArgs e)
        {
            kelime();
            baglan.Open();
            SqlCommand komut = new SqlCommand("update KitapEkle set id='" + textBox1.Text + "',KitapAdi='" + guncelkitapadTxt.Text + "',YazarAdi='" + guncelkitapyazaradTxt.Text + "',YayinEvi='" + guncelkitapyayinevTxt.Text + "',SayfaSayisi='" + guncelkitapsyfsayisiTxt.Text + "',YayimYili='" + guncelkitapyayimyiliTxt.Text + "', Dil='" + guncelkitapdiliTxt.Text + "',Tur='"+textBox2.Text+"'where id = " + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verigoruntule();
            txttemizle();

        }

        private void guncelkitaptemizleBtn_Click(object sender, EventArgs e)
        {
            txttemizle();
        }

        private void guncelkitapiptalBtn_Click(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
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

        private void kitapGuncelle_Load(object sender, EventArgs e)
        {
            verigoruntule();
        }

        private void guncelkitapiptalBtn_Click_1(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
            this.Hide();
            frm.ShowDialog();
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

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void guncelkitapdiliTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void qrİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new KitapQr();
            this.Hide();
            frm.ShowDialog();
        }

        private void guncelkitapyazaradTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void guncelkitapdiliTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from KitapEkle where id like'" + textBox1.Text + "'",baglan);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                guncelkitapadTxt.Text = reader["KitapAdi"].ToString();
                guncelkitapyazaradTxt.Text = reader[2].ToString();
                guncelkitapyayinevTxt.Text = reader[3].ToString();
                guncelkitapsyfsayisiTxt.Text = reader[4].ToString();
                guncelkitapyayimyiliTxt.Text = reader[5].ToString();
                guncelkitapdiliTxt.Text = reader[6].ToString();
                textBox2.Text = reader[7].ToString();
            }
            baglan.Close();
            if (textBox1.Text == "")
            {
                guncelkitapadTxt.Text = "";
                guncelkitapyazaradTxt.Text = "";
                guncelkitapyayinevTxt.Text = "";
                guncelkitapsyfsayisiTxt.Text = "";
                guncelkitapyayimyiliTxt.Text = "";
                guncelkitapdiliTxt.Text = "";
                textBox2.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void guncelkitapsyfsayisiTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void guncelkitapyayimyiliTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kelime()
        {
            guncelkitapadTxt.Text = guncelkitapadTxt.Text.ToLower().Trim();
            guncelkitapyazaradTxt.Text = guncelkitapyazaradTxt.Text.ToLower().Trim();
            guncelkitapyayinevTxt.Text = guncelkitapyayinevTxt.Text.ToLower().Trim();
            guncelkitapdiliTxt.Text = guncelkitapdiliTxt.Text.ToLower().Trim();
            textBox2.Text = textBox2.Text.ToLower().Trim();
        }
    }
}
