using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasbesar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void barang_Click(object sender, EventArgs e)
        {
            this.Close();
            fm3 fm3 = new fm3();
            fm3.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 fm4 = new Form4();
            fm4.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 fm1 = new Form1();
            fm1.Show();
        }
    }
}
