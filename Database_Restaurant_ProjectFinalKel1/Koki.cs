﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Restaurant_ProjectFinalKel1
{
    public partial class Koki : Form
    {

        //connection ke sql
        private string stringConnection = "data source=Jorengezzz\\THEPASHTER;" + "database=Restaurant_K1;User ID=sa;password=Salahtompo22";
        private SqlConnection koneksi;


        //membuat sndiri refresh form
        private void refreshform()
        {
            txtidkoki.Text = "";
            txtnama.Text = "";
            txtnotelp.Text = "";
            txtalamat.Text = "";

            btnclear.Enabled = false;
            btnsave.Enabled = false;
            btnopen.Enabled = false;

        }


        //membuat datagrid
        private void dataGridView()
        {
            koneksi.Open();
            string query = "SELECT Id_koki, Nama, Alamat, No_telp FROM dbo.Koki";
            SqlDataAdapter da = new SqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        public Koki()
        {
            InitializeComponent();
        }

        private void Koki_Load(object sender, EventArgs e)
        {

        }

        //button open
        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }

        //button Add
        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidkoki.Enabled = true;
            txtnama.Enabled = true;
            txtnotelp.Enabled = true;
            txtalamat.Enabled = true;
            btnsave.Enabled = true;
            btnopen.Enabled = true;
            btnclear.Enabled = true;

        }

        //button Save
        private void btnsave_Click(object sender, EventArgs e)
        {
            string idkoki = txtidkoki.Text;
            string nama = txtnama.Text;
            string alamat = txtalamat.Text;
            string notelp = txtnotelp.Text;

            if (idkoki == "")
            {
                MessageBox.Show("Masukkan Id Pembeli", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nama == "")
            {
                MessageBox.Show("Masukkan Nama", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (notelp == "")
            {
                MessageBox.Show("Masukkan No Telp", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (alamat == "")
            {
                MessageBox.Show("Masukkan Alamat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO Koki (Id_koki, Nama, Alamat,No_telp) VALUES (@id_koki, @nama, @alamat, @No_telp)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Id_koki", idkoki));
                cmd.Parameters.Add(new SqlParameter("@Alamat", alamat));
                cmd.Parameters.Add(new SqlParameter("@No_telp", notelp));
                cmd.Parameters.Add(new SqlParameter("@Nama", nama));

                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        //button Clear
        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
