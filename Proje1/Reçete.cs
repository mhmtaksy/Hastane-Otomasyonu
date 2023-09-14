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
using System.Data.SqlClient;

namespace Proje1
{
    public partial class Reçete : Form
    {
        public Reçete()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "receteList";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
        }

        SqlConnection coon = new SqlConnection("Server=MEHMETAKSOY\\SQLMHMT;Database=Hastane;Integrated Security=true;");

        private void button1_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "receteEkle";
            command.Parameters.AddWithValue("receteAdi", textBox1.Text);
            command.Parameters.AddWithValue("receteTanimi", textBox2.Text);
            command.Parameters.AddWithValue("receteTarihi", textBox3.Text);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "receteUp";
            command.Parameters.AddWithValue("receteNo", textBox1.Tag);
            command.Parameters.AddWithValue("receteAdi", textBox1.Text);
            command.Parameters.AddWithValue("receteTanimi", textBox2.Text);
            command.Parameters.AddWithValue("receteTarihi", textBox3.Text);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "receteSil";
            command.Parameters.AddWithValue("receteNo", textBox1.Tag);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["receteNo"].Value.ToString();
            textBox1.Text = satir.Cells["receteAdi"].Value.ToString();
            textBox2.Text = satir.Cells["receteTanimi"].Value.ToString();
            textBox3.Text = satir.Cells["receteTarihi"].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["receteNo"].Value.ToString();
            textBox1.Text = satir.Cells["receteAdi"].Value.ToString();
            textBox2.Text = satir.Cells["receteTanimi"].Value.ToString();
            textBox3.Text = satir.Cells["receteTarihi"].Value.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Listele();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "receteSil";
            command.Parameters.AddWithValue("receteNo", textBox1.Tag);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "receteUp";
            command.Parameters.AddWithValue("receteNo", textBox1.Tag);
            command.Parameters.AddWithValue("receteAdi", textBox1.Text);
            command.Parameters.AddWithValue("receteTanimi", textBox2.Text);
            command.Parameters.AddWithValue("receteTarihi", textBox3.Text);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "receteAra";
            command.Parameters.AddWithValue("receteAdi", textBox1.Text);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            coon.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "receteEkle";
            command.Parameters.AddWithValue("receteAdi", textBox1.Text);
            command.Parameters.AddWithValue("receteTanimi", textBox2.Text);
            command.Parameters.AddWithValue("receteTarihi", textBox3.Text);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "receteUp";
            command.Parameters.AddWithValue("receteNo", textBox1.Tag);
            command.Parameters.AddWithValue("receteAdi", textBox1.Text);
            command.Parameters.AddWithValue("receteTanimi", textBox2.Text);
            command.Parameters.AddWithValue("receteTarihi", textBox3.Text);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "receteSil";
            command.Parameters.AddWithValue("receteNo", textBox1.Tag);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Listele();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "receteAra";
            command.Parameters.AddWithValue("receteAdı", textBox1.Text);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            coon.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reçetenizi Not Etmeyi Unutmayınız.");
            MessageBox.Show("Reçetenizi Eczaneye Veriniz.");
            Raporlama go = new Raporlama();
            go.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Raporlama go = new Raporlama();
            go.Show();
            this.Hide();
        }
    }
}
