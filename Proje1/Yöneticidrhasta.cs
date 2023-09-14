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
    public partial class Yöneticidrhasta : Form
    {
        public Yöneticidrhasta()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = coon;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "hastaList";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
        }
        public void textClear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        SqlConnection coon = new SqlConnection("Server=MEHMETAKSOY\\SQLMHMT;Database=Hastane;Integrated Security=true;");
        private void button1_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hastaEkle";
            command.Parameters.AddWithValue("adSoyad", textBox1.Text);
            command.Parameters.AddWithValue("yas", textBox2.Text);
            command.Parameters.AddWithValue("boy", textBox3.Text);
            command.Parameters.AddWithValue("kilo", textBox4.Text);

            command.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hastaUp";
            command.Parameters.AddWithValue("hastaNo", textBox1.Tag);
            command.Parameters.AddWithValue("adSoyad", textBox1.Text);
            command.Parameters.AddWithValue("yas", textBox2.Text);
            command.Parameters.AddWithValue("boy", textBox3.Text);
            command.Parameters.AddWithValue("kilo", textBox4.Text);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hastaSil";
            command.Parameters.AddWithValue("hastaNo", textBox1.Tag);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hastaAra";
            command.Parameters.AddWithValue("adSoyad", textBox1.Text);

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
            YöneticiPol go = new YöneticiPol();
            go.Show();
            this.Hide();
        }
    }
}
