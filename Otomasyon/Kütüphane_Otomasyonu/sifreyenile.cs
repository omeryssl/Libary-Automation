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
using System.Data;
using System.Net;
using System.Net.Mail;

namespace Kütüphane_Otomasyonu
{
    public partial class sifreyenile: Form
    {
        public sifreyenile()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                string username = sifremiunuttum.to;
                baglan.Open();
                SqlCommand komut = new SqlCommand("update UyeEkle set id='" + textBox1.Text + "',where eposta= '"+username+"'", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor");
            }
        }
    }
}
