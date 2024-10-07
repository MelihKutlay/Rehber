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

namespace Rehber
{
    public partial class KisiEkle : Form
    {
        public KisiEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=Rehber;Integrated Security=True");
        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into kisiler (ad,soyad,telefon,mail) values (@p1,@p2,@p3,@p4)", baglanti);
            ekle.Parameters.AddWithValue("@p1", txtad.Text);
            ekle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            ekle.Parameters.AddWithValue("@p3", msktelefon.Text);
            ekle.Parameters.AddWithValue("@p4", txtmail.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            txtad.Clear();
            txtsoyad.Clear();
            msktelefon.Clear();
            txtmail.Clear();
            MessageBox.Show("YENİ KİŞİ BAŞARILI BİR ŞEKİLDE EKLENMİŞTİR","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void lnkoncekisayfa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rehber git = new Rehber();
            this.Hide();
            git.Show();
        }
    }
}
