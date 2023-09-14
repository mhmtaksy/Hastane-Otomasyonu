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

namespace Proje1
{
    public partial class YöneticiPol : Form
    {
        public YöneticiPol()
        {
            InitializeComponent();
        }
        SqlConnection coon = new SqlConnection("Server=MEHMETAKSOY\\SQLMHMT;Database=Hastane;Integrated Security=true;");

        public void Listele()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "polList";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "polEkle";
            command.Parameters.AddWithValue("poliklinikAdı", textBox2.Text);
            command.Parameters.AddWithValue("poliklinikBolum", textBox3.Text);
            command.Parameters.AddWithValue("poliklinikCalisanSayisi", textBox4.Text);

            command.ExecuteNonQuery();

            coon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "polUp";
            command.Parameters.AddWithValue("poliklinikNo", textBox2.Tag);
            command.Parameters.AddWithValue("poliklinikAdı", textBox2.Text);
            command.Parameters.AddWithValue("poliklinikBolum", textBox3.Text);
            command.Parameters.AddWithValue("poliklinikCalisanSayisi", textBox4.Text);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "polSil";
            command.Parameters.AddWithValue("poliklinikNo", textBox2.Tag);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "polAra";
            command.Parameters.AddWithValue("poliklinikAdı", textBox2.Text);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            coon.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YöneticiDoktor go = new YöneticiDoktor();
            go.Show();
            this.Hide();
        }
    }
}
