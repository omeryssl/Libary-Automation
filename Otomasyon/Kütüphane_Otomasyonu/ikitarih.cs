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
    public partial class ikitarih : Form
    {
        public ikitarih()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MENO460\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT EmanetNo,KitapAdi,Baslangic,Bitis FROM EmanetEkle WHERE Baslangic BETWEEN @tarih1 and @tarih2";
            SqlDataAdapter da = new SqlDataAdapter(sql,baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih1",dateTimePicker1.Value);
            da.SelectCommand.Parameters.AddWithValue("@tarih2",dateTimePicker2.Value);
            baglan.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void ikitarih_Load(object sender, EventArgs e)
        {
           

        }
    }
    
}
