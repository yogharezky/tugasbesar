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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "No.Pesanan";
            dataGridView1.Columns[1].Name = "No. Meja";
            dataGridView1.Columns[2].Name = "Makanan";
            dataGridView1.Columns[3].Name = "Minuman";
            dataGridView1.Columns[4].Name = "Jumlah Bayar";
            dataGridView1.Columns[5].Name = "Bayar";
            dataGridView1.Columns[6].Name = "Kembalian";

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }

        string makanan;
        string minuman;

        private void add(String no_pesanan, String no_meja, string makanan,string minuman, string jumbay, string bayar, string kembalian)
        {
            dataGridView1.Rows.Add(no_pesanan, no_meja, makanan, minuman, jumbay, bayar, kembalian);

            //clearTxts();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void rb_makanan1_CheckedChanged(object sender, EventArgs e)
        {
            makanan = "Mie Goreng";
            lblmgr.Show();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();

            //tb_bajingan.Hide();
            //tb_flores.Hide();
            //tb_gayo.Hide();
            //tb_kentang.Hide();
            //tb_mendoan.Hide();
            //tb_merapi.Hide();
            //tb_miegr.Show();
            //tb_mierb.Hide();
            //tb_nasgor.Hide();
            //tb_sindoro.Hide();
            //tb_susu.Hide();
            //tb_teh.Hide();
            //tb_temanggung.Hide();
            //tb_toraja.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void rb_makanan2_CheckedChanged(object sender, EventArgs e)
        {
            makanan = "Mie Rebus";
            lblmgr.Hide();
            lblrbs.Show();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }

        private void rb_makanan3_CheckedChanged(object sender, EventArgs e)
        {
            makanan = "Nasi Goreng Spesial";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Show();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }

        private void rb_makanan4_CheckedChanged(object sender, EventArgs e)
        {
            makanan = "Mendoan";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Show();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }

        private void rb_makanan5_CheckedChanged(object sender, EventArgs e)
        {
            makanan = "Bajingan Temanggung";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Show();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }

        private void rb_makanan6_CheckedChanged(object sender, EventArgs e)
        {
            makanan = "Kentang Goreng";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Show();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }

        private void rb_minuman1_CheckedChanged(object sender, EventArgs e)
        {
            minuman = "Kopi Gayo";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Show();
            lbltrj.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }

        private void rb_minuman2_CheckedChanged(object sender, EventArgs e)
        {
            minuman = "Kopi Toraja";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Show();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }

        private void rb_minuman3_CheckedChanged(object sender, EventArgs e)
        {
            minuman = "Kopi Merapi";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Show();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }

        private void rb_minuman4_CheckedChanged(object sender, EventArgs e)
        {
            minuman = "Kopi Temanggung";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Hide();
            label8.Show();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }

        private void rb_minuman5_CheckedChanged(object sender, EventArgs e)
        {
            minuman = "Kopi Flores";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Hide();
            label8.Hide();
            label9.Show();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }

        private void rb_minuman6_CheckedChanged(object sender, EventArgs e)
        {
            minuman = "Kopi Sindoro";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Show();
            label11.Hide();
            label12.Hide();
        }

        private void rb_minuman7_CheckedChanged(object sender, EventArgs e)
        {
            minuman = "Susu Segar";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Show();
            label12.Hide();
        }

        private void rb_minuman8_CheckedChanged(object sender, EventArgs e)
        {
            minuman = "Teh(Es/Panas)";
            lblmgr.Hide();
            lblrbs.Hide();
            lblnasgor.Hide();
            lblmndn.Hide();
            lblbjgn.Hide();
            lblkntg.Hide();
            lblgyo.Hide();
            lbltrj.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Show();


        }

        private void tambah_menu_Click(object sender, EventArgs e)
        {
            if (rb_makanan1.Checked == true)
            {
                double jmlmgr = double.Parse(textBox3.Text);
                tb_miegr.Text = (jmlmgr * 8000).ToString();
            }
            else if (rb_makanan2.Checked == true)
            {
                double jmlmrb = double.Parse(textBox3.Text);
                tb_mierb.Text = (jmlmrb * 7500).ToString();
            }
            else if (rb_makanan3.Checked == true)
            {
                double jmlnasgor = double.Parse(textBox3.Text);
                tb_nasgor.Text = (jmlnasgor * 12000).ToString();
            }
            else if (rb_makanan4.Checked == true)
            {
                double jmlmdn = double.Parse(textBox3.Text);
                tb_mendoan.Text = (jmlmdn * 6000).ToString();
            }
            else if (rb_makanan5.Checked == true)
            {
                double jmlbjg = double.Parse(textBox3.Text);
                tb_bajingan.Text = (jmlbjg * 7000).ToString();
            }
            else if (rb_makanan6.Checked == true)
            {
                double jmlkentang = double.Parse(textBox3.Text);
                tb_kentang.Text = (jmlkentang * 9000).ToString();
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_miegr_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltrj_Click(object sender, EventArgs e)
        {

        }

        private void lblkntg_Click(object sender, EventArgs e)
        {

        }

        private void tot_bayar_Click(object sender, EventArgs e)
        {
            try
            {
                string a = tb_miegr.Text.Trim() != "" ? tb_miegr.Text.Trim() : "0";
                double jml1 = int.Parse(a);

                string b = tb_mierb.Text.Trim() != "" ? tb_mierb.Text.Trim() : "0";
                double jml2 = int.Parse(b);

                string c = tb_nasgor.Text.Trim() != "" ? tb_nasgor.Text.Trim() : "0";
                double jml3 = int.Parse(c);

                string d = tb_sindoro.Text.Trim() != "" ? tb_sindoro.Text.Trim() : "0";
                double jml4 = int.Parse(d);

                string f = tb_susu.Text.Trim() != "" ? tb_susu.Text.Trim() : "0";
                int jml5 = int.Parse(f);

                string g = tb_teh.Text.Trim() != "" ? tb_teh.Text.Trim() : "0";
                int jml6 = int.Parse(g);

                string h = tb_temanggung.Text.Trim() != "" ? tb_temanggung.Text.Trim() : "0";
                int jml7 = int.Parse(h);

                string i = tb_toraja.Text.Trim() != "" ? tb_toraja.Text.Trim() : "0";
                int jml8 = int.Parse(i);

                string j = tb_merapi.Text.Trim() != "" ? tb_merapi.Text.Trim() : "0";
                int jml9 = int.Parse(j);

                string k = tb_mendoan.Text.Trim() != "" ? tb_mendoan.Text.Trim() : "0";
                int jml10 = int.Parse(k);

                string l = tb_kentang.Text.Trim() != "" ? tb_kentang.Text.Trim() : "0";
                int jml11 = int.Parse(l);

                string m = tb_gayo.Text.Trim() != "" ? tb_gayo.Text.Trim() : "0";
                int jml12 = int.Parse(m);

                string n = tb_flores.Text.Trim() != "" ? tb_flores.Text.Trim() : "0";
                int jml13 = int.Parse(n);

                string o = tb_bajingan.Text.Trim() != "" ? tb_bajingan.Text.Trim() : "0";
                int jml14 = int.Parse(o);

                tb_jumbay.Text = (jml1 + jml2 + jml3 + jml4 + jml5 + jml6 + jml7 + jml8
                                 + jml9 + jml10 + jml11 + jml12 + jml13 + jml14).ToString();
            }
            catch (Exception eb)
            {
                MessageBox.Show(eb.Message);
            }

        }

        //private void btn_cetak_Click(object sender, EventArgs e)
        //{
        //    add(textBox1.Text, textBox2.Text, gb_makanan.Text, gb_minuman.Text, tb_jumbay.Text, tb_bayar.Text, tb_kembalian.Text);

        //    //this.Hide();
        //    //Form5 fm5 = new Form5();
        //    //fm5.Show();
        //}

        private void btn_minum_Click(object sender, EventArgs e)
        {
            if (rb_minuman1.Checked == true)
            {
                double jmlgayo = double.Parse(textBox3.Text);
                tb_gayo.Text = (jmlgayo * 15000).ToString();
            }
            else if (rb_minuman2.Checked == true)
            {
                double jmltoraja = double.Parse(textBox3.Text);
                tb_toraja.Text = (jmltoraja * 12000).ToString();
            }
            else if (rb_minuman3.Checked == true)
            {
                double jmlmerapi = double.Parse(textBox3.Text);
                tb_merapi.Text = (jmlmerapi * 12000).ToString();
            }
            else if (rb_minuman4.Checked == true)
            {
                double jmltmg = double.Parse(textBox3.Text);
                tb_temanggung.Text = (jmltmg * 16000).ToString();
            }
            else if (rb_minuman5.Checked == true)
            {
                double jmlfls = double.Parse(textBox3.Text);
                tb_flores.Text = (jmlfls * 16000).ToString();
            }
            else if (rb_minuman6.Checked == true)
            {
                double jmlsdr = double.Parse(textBox3.Text);
                tb_sindoro.Text = (jmlsdr * 15000).ToString();
            }
            else if (rb_minuman7.Checked == true)
            {
                double jmlsusu = double.Parse(textBox3.Text);
                tb_susu.Text = (jmlsusu * 10000).ToString();
            }
            else if (rb_minuman8.Checked == true)
            {
                double jmlteh = double.Parse(textBox3.Text);
                tb_teh.Text = (jmlteh * 4000).ToString();
            }
        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {
            double jumbay = int.Parse(tb_jumbay.Text);
            double bayar = int.Parse(tb_bayar.Text);

            tb_kembalian.Text = (bayar - jumbay).ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logindbDataSet4.input_barang' table. You can move, or remove it, as needed.
            this.input_barangTableAdapter.Fill(this.logindbDataSet4.input_barang);
            // TODO: This line of code loads data into the 'logindbDataSet3.input_menu' table. You can move, or remove it, as needed.
            this.input_menuTableAdapter.Fill(this.logindbDataSet3.input_menu);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            tb_bajingan.Text = " ";
            tb_bayar.Text = " ";
            tb_flores.Text = " ";
            tb_gayo.Text = " ";
            tb_jumbay.Text = " ";
            tb_kembalian.Text = " ";
            tb_kentang.Text = " ";
            tb_mendoan.Text = " ";
            tb_merapi.Text = " ";
            tb_miegr.Text = " ";
            tb_mierb.Text = " ";
            tb_nasgor.Text = " ";
            tb_sindoro.Text = " ";
            tb_susu.Text = " ";
            tb_teh.Text = " ";
            tb_temanggung.Text = " ";
            tb_toraja.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
           add(textBox1.Text, textBox2.Text, makanan, minuman, tb_jumbay.Text, tb_bayar.Text, tb_kembalian.Text);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 fm2 = new Form2();
            fm2.Show();
        }
     }
}
