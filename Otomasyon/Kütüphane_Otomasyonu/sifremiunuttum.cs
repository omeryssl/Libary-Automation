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
using System.Net;
using System.Net.Mail;


namespace Kütüphane_Otomasyonu
{
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sqlbaglantisi bgln = new sqlbaglantisi();
            SqlCommand komut = new SqlCommand("select * from UyeEkle where TcNo='" + textBox1.Text.ToString() + "'and eposta = '" + textBox2.Text.ToString() + "'", bgln.baglanti());

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if(bgln.baglanti().State == ConnectionState.Closed)
                    {
                        bgln.baglanti().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    string tarih = DateTime.Now.ToLongDateString();
                    string mailadresin = ("mertcanozbayy22@gmail.com");
                    string sifre = ("mertcan0569");
                    string smtpsrvr = "smtp.gmail.com";
                    string kime = (oku["espota"].ToString());
                    string konu = ("Şifre Hatırlatma Maili");
                    string yaz = ("Sayın, " + oku["UyeAdi"].ToString()+ "\n"+"Bizden"+tarih+" Tarihinde Şifre Hatırlatma Talebinde Bulundunuz."+"\n"+ "Parolanız:" + oku["id"].ToString()+ "\nİyi Günler.");
                    smtpserver.Credentials = new NetworkCredential(mailadresin, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Girmiş Oldugunuz Bilgiler Doğrudur. Şifreniz Mail Adresinize Gönderilmiştir.");
                    this.Hide();
                }
                catch(Exception Hata)
                {
                    MessageBox.Show("Mail Gönderme Hatası! ", Hata.Message);
                }
            }
        }

    }
}
