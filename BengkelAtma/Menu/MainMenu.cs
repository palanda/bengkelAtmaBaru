﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BengkelAtma.Menu;

namespace BengkelAtma
{
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        
        

        private void metroTabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            akun1.Hide();
        }

      
    }
}