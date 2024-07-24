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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kütüphane_Otomasyonu
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
            Init_Data();
            
        }
        public static string ad;
        
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-MENO460\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True;");
        private void Save_Data()
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.UserName = girisadBtn.Text;
                Properties.Settings.Default.Password = girissifreBtn.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    girisadBtn.Text = Properties.Settings.Default.UserName;
                    girissifreBtn.Text = Properties.Settings.Default.Password;
                    checkBox1.Checked = true;
                }
                else
                {
                    girisadBtn.Text= Properties.Settings.Default.UserName;
                }
            }
        }



        private void girisBtn_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(girissifreBtn.Text);
            String querry = "SELECT * FROM UyeEkle WHERE id='" + girissifreBtn.Text + "' AND TcNo='"+girisadBtn.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, baglan);
            DataTable da = new DataTable();
            sda.Fill(da);
         
            if (String.IsNullOrEmpty(girisadBtn.Text))
            {
                errorProvider1.SetError(girisadBtn, "gerekli alan");
            }
            else if (String.IsNullOrEmpty(girissifreBtn.Text))
            {
                errorProvider2.SetError(girissifreBtn, "gerekli alan");
            }
            

            else if (girisadBtn.Text == "admin" && girissifreBtn.Text == "1234")
            {
                Save_Data();
                Form frm = new anaSayfa();
                this.Hide();
                frm.ShowDialog();
                
            }
            else if (da.Rows.Count > 0)
            {
                ad = girissifreBtn.Text;
                Save_Data();
                Form frm = new UyeAnaSayfa();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           


        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void girisadBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form frm = new sifreUnuttum();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
