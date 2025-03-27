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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }


        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ALCAEUSANDREA\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into studentab values(@id,@studentname,@age,@phone,@email)", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Studentname", textBox2.Text);

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Phone", textBox4.Text);

            cnn.Parameters.AddWithValue("@Email", textBox5.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ALCAEUSANDREA\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from studentab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ALCAEUSANDREA\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from studentab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ALCAEUSANDREA\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("Update studentab set studentname=@studentname,age=@age,phone=@phone,email=@email where id=@id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Studentname", textBox2.Text);

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));



            cnn.Parameters.AddWithValue("@Roll", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Phone", textBox5.Text);

            cnn.Parameters.AddWithValue("@Email", textBox4.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");

        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=ALCAEUSANDREA\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Delete studentab where id=@id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }
    }
}