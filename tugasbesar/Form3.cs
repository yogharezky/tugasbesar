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
	

namespace tugasbesar
{
    public partial class fm3 : Form
    {
        public fm3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logindbDataSet2.input_barang' table. You can move, or remove it, as needed.
            this.input_barangTableAdapter1.Fill(this.logindbDataSet2.input_barang);

        }

        private void brg_smpn_Click(object sender, EventArgs e)
        {
            string constring =(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Yogha Rezky Maulana\Documents\Visual Studio 2013\Projects\tugasbesar\tugasbesar\logindb.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into dbo.input_barang (id_barang,nama_brg,jenis_brg,harga_brg,jum_msk) values('" + this.id_box.Text + "','" + this.nama_brg.Text + "', '" + this.comboBox1.Text + "' ,'" + this.input_hrg.Text + "','" + this.jum_msk.Text + "');";
            SqlConnection logindb = new SqlConnection(constring);
            SqlCommand cmddatabase = new SqlCommand(query, logindb);
            SqlDataReader myreader;
            try
            {
                logindb.Open();
                myreader = cmddatabase.ExecuteReader();
                MessageBox.Show("saved");

                while (myreader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void cancel_brg_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 fm1 = new Form2();
            fm1.Show();
        }
    }
}
