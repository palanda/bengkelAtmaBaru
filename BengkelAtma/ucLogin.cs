using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengkelAtma
{
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void tbMasuk_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            SplashScreen sp = new SplashScreen();
            main.Show();
            sp.Close();
            sp.Hide();
            
        }
    }
}
