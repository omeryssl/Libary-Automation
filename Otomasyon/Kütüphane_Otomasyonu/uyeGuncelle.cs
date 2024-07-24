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
using System.Security.Cryptography;

namespace Kütüphane_Otomasyonu
{
    public partial class uyeGuncelle : Form
    {
        public uyeGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");
        int id = 0;
        private void verigoruntule()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("select * from UyeEkle", baglan);
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
            baglan.Close();


        }
        private void txttemizle()
        {
            uyegunceluyenoTxt.Clear();
            uyegunceluyetcnoTxt.Clear();
            uyegunceluyeadTxt.Clear();
            uyegunceluyesoyadTxt.Clear();
            uyegunceluyetelnoTxt.Clear();
            uyegunceluyepostaTxt.Clear();
            uyegunceluyeadresTxt.Clear(); 
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            uyegunceluyenoTxt.Text = listView1.SelectedItems[0].SubItems[0].Text;
            uyegunceluyetcnoTxt.Text = listView1.SelectedItems[0].SubItems[1].Text;
            uyegunceluyeadTxt.Text = listView1.SelectedItems[0].SubItems[2].Text;
            uyegunceluyesoyadTxt.Text = listView1.SelectedItems[0].SubItems[3].Text;
            uyegunceluyetelnoTxt.Text = listView1.SelectedItems[0].SubItems[4].Text;
            uyegunceluyepostaTxt.Text = listView1.SelectedItems[0].SubItems[5].Text;
            uyegunceluyeadresTxt.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void uyegunceluyeekleBtn_Click(object sender, EventArgs e)
        {
            kelime();
            baglan.Open();
            SqlCommand komut = new SqlCommand("update UyeEkle set id='" + uyegunceluyenoTxt.Text + "',TcNo='" + uyegunceluyetcnoTxt.Text + "',UyeAdi='" + uyegunceluyeadTxt.Text + "',UyeSoyadi='" + uyegunceluyesoyadTxt.Text + "',TelNo='" + uyegunceluyetelnoTxt.Text + "',eposta='" + uyegunceluyepostaTxt.Text + "', adres='" + uyegunceluyeadresTxt.Text + "'where id = " + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verigoruntule();
            txttemizle();
        }

        private void uyegunceluyetemizleBtn_Click(object sender, EventArgs e)
        {
            txttemizle();
        }

        private void uyegunceliptalBtn_Click(object sender, EventArgs e)
        {
            Form frm = new anaSayfa();
            this.Hide();
            frm.ShowDialog();


        }

        private void üyeŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new uyeListele();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new uyeEkle();
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

        private void uyeGuncelle_Load(object sender, EventArgs e)
        {
            verigoruntule();
        }

        private void emanetEkleToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void qrİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new KitapQr();
            this.Hide();
            frm.ShowDialog();
        }

        private void uyegunceluyeadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void uyegunceluyesoyadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void uyegunceluyenoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void uyegunceluyetcnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void uyegunceluyetelnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void kelime()
        {
            uyegunceluyeadTxt.Text = uyegunceluyeadTxt.Text.ToLower().Trim();
            uyegunceluyesoyadTxt.Text = uyegunceluyesoyadTxt.Text.ToLower().Trim();
            uyegunceluyeadresTxt.Text = uyegunceluyeadresTxt.Text.ToLower().Trim();
        }

        private void uyegunceluyenoTxt_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from UyeEkle where id like'" + uyegunceluyenoTxt.Text + "'", baglan);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                uyegunceluyetcnoTxt.Text = reader["TcNo"].ToString();
                uyegunceluyeadTxt.Text = reader[2].ToString();
                uyegunceluyesoyadTxt.Text = reader[3].ToString();
                uyegunceluyetelnoTxt.Text = reader[4].ToString();
                uyegunceluyepostaTxt.Text = reader[5].ToString();
                uyegunceluyeadresTxt.Text = reader[6].ToString();
                
            }
            baglan.Close();
        }
    }
}
