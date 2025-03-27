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

namespace LibraryManagementPOS
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ALCAEUSANDREA\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into booktab values(@id,@book,@number,@author,@publisher)", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Book", textBox2.Text);

            cnn.Parameters.AddWithValue("@Number", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Author", textBox4.Text);

            cnn.Parameters.AddWithValue("@Publisher", textBox5.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ALCAEUSANDREA\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from booktab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e) //When updated, just click the "update" button then click "display" button
        {
            SqlConnection con = new SqlConnection(@"Data Source=ALCAEUSANDREA\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("Update booktab set book=@book,number=@number,author=@author,publisher=@publisher where id=@id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Book", textBox2.Text);

            cnn.Parameters.AddWithValue("@Number", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Author", textBox4.Text);

            cnn.Parameters.AddWithValue("@Publisher", textBox5.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ALCAEUSANDREA\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Delete booktab where id=@id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ALCAEUSANDREA\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from booktab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}
