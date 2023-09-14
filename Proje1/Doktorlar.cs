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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje1
{
    public partial class Doktorlar : Form
    {
        public Doktorlar()
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
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "doktorEkle";
            command.Parameters.AddWithValue("doktorAdı", textBox1.Text);
            command.Parameters.AddWithValue("doktorOdaNo", textBox2.Text);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "doktorUp";
            command.Parameters.AddWithValue("doktorID", textBox1.Tag);
            command.Parameters.AddWithValue("doktorAdı", textBox1.Text);
            command.Parameters.AddWithValue("doktorOdaNo", textBox2.Text);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = coon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "doktorSil";
            command.Parameters.AddWithValue("doktorID", textBox1.Tag);
            command.ExecuteNonQuery();
            coon.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["doktorID"].Value.ToString();
            textBox1.Text = satir.Cells["doktorAdı"].Value.ToString();
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

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = coon;
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "doktorSil";
            cmd.Parameters.AddWithValue("doktorID", textBox3.Text);
            cmd.ExecuteNonQuery();
            coon.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox3.Text = satir.Cells["doktorID"].Value.ToString();
            textBox1.Text = satir.Cells["doktorOdaNo"].Value.ToString();
            textBox2.Text = satir.Cells["doktorOdaNo"].Value.ToString();
            
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            Reçete go = new Reçete();
            go.Show();
            this.Hide();
        }
    }
}
