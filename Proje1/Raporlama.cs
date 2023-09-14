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
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }

        SqlConnection coon = new SqlConnection("Server=MEHMETAKSOY\\SQLMHMT;Database=Hastane;Integrated Security=true;");
        private void button1_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "yassorgu";
            

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            coon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType= CommandType.StoredProcedure;
            command.CommandText = "kilosorgu";

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            coon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "boysorgu";

            SqlDataAdapter dr = new SqlDataAdapter( command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            coon.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "doktorsorgu";
            command.Parameters.AddWithValue("doktorAdı",textBox1.Text);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            coon.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hastadı";
            command.Parameters.AddWithValue("adsoyad",textBox2.Text);
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
                dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            coon.Close();
        }
    }
}
