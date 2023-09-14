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

namespace Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection coon = new SqlConnection("Server=MEHMETAKSOY\\SQLMHMT;Database=Hastane;Integrated Security=true;");

        private void button1_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = coon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "kullaniciEkle";
            cmd.Parameters.AddWithValue("kullaniciAdi", textBox1.Text);
            cmd.Parameters.AddWithValue("kullaniciSifre", textBox2.Text);
            int sonuc = cmd.ExecuteNonQuery();
            if(sonuc > 0) 
            {
                MessageBox.Show("Hastanemize Hoşgeldiniz");
                drhastapol go = new drhastapol();
                go.Show();
                this.Hide();
            }
            coon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = coon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "yöneticiEkle";
            cmd.Parameters.AddWithValue("yöneticiAdi", textBox1.Text);
            cmd.Parameters.AddWithValue("yöneticiSifre", textBox2.Text);
            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("Hastanemize Hoşgeldiniz");
                drhastapol go = new drhastapol();
                go.Show();
                this.Hide();
            }
            coon.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = coon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "kullaniciEkle";
            cmd.Parameters.AddWithValue("kullaniciAdi", textBox1.Text);
            cmd.Parameters.AddWithValue("kullaniciSifre", textBox2.Text);
            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("Hastanemize Hoşgeldiniz");
                drhastapol go = new drhastapol();
                go.Show();
                this.Hide();
            }
            coon.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            groupBox1.Visible = true;
            
            
                
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            coon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = coon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "yöneticiEkle";
            cmd.Parameters.AddWithValue("yöneticiAdi", textBox1.Text);
            cmd.Parameters.AddWithValue("yöneticiSifre", textBox2.Text);
            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("Hoşgeldiniz");
                Yöneticidrhasta go = new Yöneticidrhasta();
                go.Show();
                this.Hide();
            }
            coon.Close();
        }
    }
}
