using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementPOS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student StudentInfo = new Student();
            StudentInfo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book BookInfo = new Book();
            BookInfo.Show();
            this.Hide();
        }
    }
}
