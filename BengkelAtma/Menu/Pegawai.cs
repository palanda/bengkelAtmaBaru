using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BengkelAtma.Menu;

namespace BengkelAtma.Menu
{
    public partial class Pegawai : UserControl
    {
        public Pegawai()
        {
            InitializeComponent();
        }

        private void submenuPegawai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Akun acc = new Akun();
            Pegawai peg = new Pegawai();
            if (submenuPegawai.SelectedItem.Equals("Akun"))
            {
                
                peg.Hide();
                acc.Show();
                acc.BringToFront();

            }
            else 
            {

                this.Show();
            }

        }
    }
}
