namespace tugasbesar
{
    partial class fm3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.jum_msk = new System.Windows.Forms.TextBox();
            this.cancel_brg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.input_hrg = new System.Windows.Forms.TextBox();
            this.brg_smpn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nama_brg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logindbDataSet = new tugasbesar.logindbDataSet();
            this.logindbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logindbDataSet1 = new tugasbesar.logindbDataSet1();
            this.inputbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.input_barangTableAdapter = new tugasbesar.logindbDataSet1TableAdapters.input_barangTableAdapter();
            this.logindbDataSet2 = new tugasbesar.logindbDataSet2();
            this.inputbarangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.input_barangTableAdapter1 = new tugasbesar.logindbDataSet2TableAdapters.input_barangTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisbrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jummskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputbarangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.jum_msk);
            this.panel2.Controls.Add(this.cancel_brg);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.input_hrg);
            this.panel2.Controls.Add(this.brg_smpn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.nama_brg);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.id_box);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(28, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 165);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "makanan",
            "minuman"});
            this.comboBox1.Location = new System.Drawing.Point(95, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // jum_msk
            // 
            this.jum_msk.Location = new System.Drawing.Point(95, 133);
            this.jum_msk.Name = "jum_msk";
            this.jum_msk.Size = new System.Drawing.Size(34, 20);
            this.jum_msk.TabIndex = 17;
            // 
            // cancel_brg
            // 
            this.cancel_brg.BackColor = System.Drawing.Color.Brown;
            this.cancel_brg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_brg.ForeColor = System.Drawing.Color.White;
            this.cancel_brg.Location = new System.Drawing.Point(420, 129);
            this.cancel_brg.Name = "cancel_brg";
            this.cancel_brg.Size = new System.Drawing.Size(82, 31);
            this.cancel_brg.TabIndex = 9;
            this.cancel_brg.Text = "CANCEL";
            this.cancel_brg.UseVisualStyleBackColor = false;
            this.cancel_brg.Click += new System.EventHandler(this.cancel_brg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Jumlah Masuk :";
            // 
            // input_hrg
            // 
            this.input_hrg.Location = new System.Drawing.Point(95, 102);
            this.input_hrg.Name = "input_hrg";
            this.input_hrg.Size = new System.Drawing.Size(174, 20);
            this.input_hrg.TabIndex = 15;
            // 
            // brg_smpn
            // 
            this.brg_smpn.BackColor = System.Drawing.Color.Brown;
            this.brg_smpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brg_smpn.ForeColor = System.Drawing.Color.White;
            this.brg_smpn.Location = new System.Drawing.Point(316, 129);
            this.brg_smpn.Name = "brg_smpn";
            this.brg_smpn.Size = new System.Drawing.Size(82, 31);
            this.brg_smpn.TabIndex = 8;
            this.brg_smpn.Text = "SIMPAN";
            this.brg_smpn.UseVisualStyleBackColor = false;
            this.brg_smpn.Click += new System.EventHandler(this.brg_smpn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Harga :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Jenis Barang :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 10);
            this.panel3.TabIndex = 10;
            // 
            // nama_brg
            // 
            this.nama_brg.Location = new System.Drawing.Point(95, 42);
            this.nama_brg.Name = "nama_brg";
            this.nama_brg.Size = new System.Drawing.Size(174, 20);
            this.nama_brg.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nama Barang :";
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(95, 10);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(174, 20);
            this.id_box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Barang :";
            // 
            // logindbDataSet
            // 
            this.logindbDataSet.DataSetName = "logindbDataSet";
            this.logindbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logindbDataSetBindingSource
            // 
            this.logindbDataSetBindingSource.DataSource = this.logindbDataSet;
            this.logindbDataSetBindingSource.Position = 0;
            // 
            // logindbDataSet1
            // 
            this.logindbDataSet1.DataSetName = "logindbDataSet1";
            this.logindbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inputbarangBindingSource
            // 
            this.inputbarangBindingSource.DataMember = "input_barang";
            this.inputbarangBindingSource.DataSource = this.logindbDataSet1;
            // 
            // input_barangTableAdapter
            // 
            this.input_barangTableAdapter.ClearBeforeFill = true;
            // 
            // logindbDataSet2
            // 
            this.logindbDataSet2.DataSetName = "logindbDataSet2";
            this.logindbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inputbarangBindingSource1
            // 
            this.inputbarangBindingSource1.DataMember = "input_barang";
            this.inputbarangBindingSource1.DataSource = this.logindbDataSet2;
            // 
            // input_barangTableAdapter1
            // 
            this.input_barangTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.namabrgDataGridViewTextBoxColumn,
            this.jenisbrgDataGridViewTextBoxColumn,
            this.hargabrgDataGridViewTextBoxColumn,
            this.jummskDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inputbarangBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 205);
            this.dataGridView1.TabIndex = 17;
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            // 
            // namabrgDataGridViewTextBoxColumn
            // 
            this.namabrgDataGridViewTextBoxColumn.DataPropertyName = "nama_brg";
            this.namabrgDataGridViewTextBoxColumn.HeaderText = "nama_brg";
            this.namabrgDataGridViewTextBoxColumn.Name = "namabrgDataGridViewTextBoxColumn";
            // 
            // jenisbrgDataGridViewTextBoxColumn
            // 
            this.jenisbrgDataGridViewTextBoxColumn.DataPropertyName = "jenis_brg";
            this.jenisbrgDataGridViewTextBoxColumn.HeaderText = "jenis_brg";
            this.jenisbrgDataGridViewTextBoxColumn.Name = "jenisbrgDataGridViewTextBoxColumn";
            // 
            // hargabrgDataGridViewTextBoxColumn
            // 
            this.hargabrgDataGridViewTextBoxColumn.DataPropertyName = "harga_brg";
            this.hargabrgDataGridViewTextBoxColumn.HeaderText = "harga_brg";
            this.hargabrgDataGridViewTextBoxColumn.Name = "hargabrgDataGridViewTextBoxColumn";
            // 
            // jummskDataGridViewTextBoxColumn
            // 
            this.jummskDataGridViewTextBoxColumn.DataPropertyName = "jum_msk";
            this.jummskDataGridViewTextBoxColumn.HeaderText = "jum_msk";
            this.jummskDataGridViewTextBoxColumn.Name = "jummskDataGridViewTextBoxColumn";
            // 
            // fm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(593, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "fm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INPUT BARANG MASUK";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputbarangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox jum_msk;
        private System.Windows.Forms.Button cancel_brg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input_hrg;
        private System.Windows.Forms.Button brg_smpn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox nama_brg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label3;
        private logindbDataSet logindbDataSet;
        private System.Windows.Forms.BindingSource logindbDataSetBindingSource;
        private logindbDataSet1 logindbDataSet1;
        private System.Windows.Forms.BindingSource inputbarangBindingSource;
        private logindbDataSet1TableAdapters.input_barangTableAdapter input_barangTableAdapter;
        private logindbDataSet2 logindbDataSet2;
        private System.Windows.Forms.BindingSource inputbarangBindingSource1;
        private logindbDataSet2TableAdapters.input_barangTableAdapter input_barangTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisbrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jummskDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}