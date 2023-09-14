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
    public partial class YöneticiDoktor : Form
    {
        public YöneticiDoktor()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "doktorList";
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
        }

        SqlConnection coon = new SqlConnection("Server=MEHMETAKSOY\\SQLMHMT;Database=Hastane;Integrated Security=true;");
        private void button1_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = coon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "doktorEkle";
            cmd.Parameters.AddWithValue("doktorAdı", textBox1.Text);
            cmd.Parameters.AddWithValue("doktorOdaNo", textBox2.Text);
            cmd.ExecuteNonQuery();
            coon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = coon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "doktorUp";
            cmd.Parameters.AddWithValue("doktorID", textBox3.Text);
            cmd.Parameters.AddWithValue("doktorAdı", textBox1.Text);
            cmd.Parameters.AddWithValue("doktorOdaNo", textBox2.Text);
            cmd.ExecuteNonQuery();
            coon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = coon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "doktorSil";
            cmd.Parameters.AddWithValue("doktorID", textBox3.Text);
            cmd.ExecuteNonQuery();
            coon.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "doktorAra";
            command.Parameters.AddWithValue("doktorAdı", textBox1.Text);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            coon.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox3.Text = satir.Cells["doktorID"].Value.ToString();
            textBox1.Text = satir.Cells["doktorOdaNo"].Value.ToString();
            textBox2.Text = satir.Cells["doktorOdaNo"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reçete go = new Reçete();
            go.Show();
            this.Hide();
        }
    }
}
