using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryMngmt
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();    
            manageUserControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageUserControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            viewTableControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
