using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Restaurant_ProjectFinalKel1
{
    public partial class Utama : Form
    {
        public Utama()
        {
            InitializeComponent();
        }

        //button Pembeli
        private void btnpembeli_Click(object sender, EventArgs e)
        {
            Pembeli fp = new Pembeli();
            fp.Show();
            this.Hide();
        }

        //button kasir
        private void btnkasir_Click(object sender, EventArgs e)
        {
            Kasir fk = new Kasir();
            fk.Show();
            this.Hide();
        }
    }
}
