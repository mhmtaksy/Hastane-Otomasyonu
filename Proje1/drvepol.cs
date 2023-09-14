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
    public partial class drvepol : Form
    {
        public drvepol()
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox2.Tag = satir.Cells["poliklinikNo"].Value.ToString();
            textBox2.Text = satir.Cells["poliklinikAdı"].Value.ToString();
            textBox3.Text = satir.Cells["poliklinikBolum"].Value.ToString();
            textBox4.Text = satir.Cells["poliklinikCalisanSayisi"].Value.ToString();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void drvepol_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                
                Doktorlar go = new Doktorlar();
                go.Show();
                this.Hide();
           
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
    }
}
