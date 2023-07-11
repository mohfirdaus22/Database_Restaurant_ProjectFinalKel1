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

        public Koki()
        {
            InitializeComponent();
        }

        private void Koki_Load(object sender, EventArgs e)
        {

        }
    }
}
