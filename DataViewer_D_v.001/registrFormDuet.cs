using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataViewer_D_v._001
{
    public partial class registrFormDuet : Form
    {
        startWindow startWindow = new startWindow();
        public registrFormDuet()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            startWindow.Show();
        }

        private void registrFormDuet_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            startWindow.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
