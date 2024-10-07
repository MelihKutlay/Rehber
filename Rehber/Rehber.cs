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

namespace Rehber
{
    public partial class Rehber : Form
    {
        public Rehber()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=Rehber;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand listele = new SqlCommand("select * from kisiler", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(listele);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnyenikisi_Click(object sender, EventArgs e)
        {
            KisiEkle git = new KisiEkle();
            this.Hide();
            git.Show();
        }

        private void btnkisiguncelle_Click(object sender, EventArgs e)
        {
            KisiGuncelle git = new KisiGuncelle();
            this.Hide();
            git.Show();
        }

        private void btnkisisil_Click(object sender, EventArgs e)
        {
            KisiSil git = new KisiSil();
            this.Hide();
            git.Show();
        }
    }
}
