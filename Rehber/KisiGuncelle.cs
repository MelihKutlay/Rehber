using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehber
{
    public partial class KisiGuncelle : Form
    {
        public KisiGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=Rehber;Integrated Security=True");

        void listele()
        {
            SqlCommand listele = new SqlCommand("select * from kisiler", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(listele);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update kisiler set ad=@p1,soyad=@p2,telefon=@p3,mail=@p4 where rehberid =@p5",baglanti);
            guncelle.Parameters.AddWithValue("@p1", txtad.Text);
            guncelle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", msktelefon.Text);
            guncelle.Parameters.AddWithValue("@p4", txtmail.Text);
            guncelle.Parameters.AddWithValue("@p5", txtid.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            listele();
            MessageBox.Show("KAYIT BAŞARILI BİR ŞEKİLDE GÜNCELLENMİŞTİR","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void KisiGuncelle_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            txtidbul.Visible = false;
            txtadbul.Visible = false;
            txtsoyadbul.Visible = false;
            listele();
           
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            msktelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtmail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void txtbul_TextChanged(object sender, EventArgs e)
        {
            txtidbul.Clear();
            txtsoyadbul.Clear();
            SqlCommand bul1 = new SqlCommand("select * from kisiler where ad=@p1 or ad like '%" + txtadbul.Text + "%'", baglanti);
            bul1.Parameters.AddWithValue("@p1", txtadbul.Text);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(bul1);
            da.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            txtadbul.Clear();
            txtsoyadbul.Clear();
            SqlCommand bul = new SqlCommand("select * from kisiler where rehberid=@p1 or rehberid like '%" + txtidbul.Text + "%'", baglanti);
            bul.Parameters.AddWithValue("@p1",txtidbul.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(bul);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private bool isVisible = false;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isVisible)
            {
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                txtidbul.Visible = true;
                txtadbul.Visible = true;
                txtsoyadbul.Visible = true;
            }
            else
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                txtidbul.Visible = false;
                txtadbul.Visible = false;
                txtsoyadbul.Visible = false;
            }
            isVisible = !isVisible;
        }

        private void txtsoyadbul_TextChanged(object sender, EventArgs e)
        {
            txtidbul.Clear();
            txtadbul.Clear();
            SqlCommand bul = new SqlCommand("select * from kisiler where soyad=@p1 or soyad like '%" + txtsoyadbul.Text + "%'", baglanti);
            bul.Parameters.AddWithValue("@p1", txtsoyadbul.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(bul);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label8.Text = "Filtrele";
            label8.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void lnkoncekisayfa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rehber git = new Rehber();
            this.Hide();
            git.Show();
        }
    }
}