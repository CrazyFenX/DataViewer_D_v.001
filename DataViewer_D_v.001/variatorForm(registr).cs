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
    public partial class variatorForm_registr_ : Form
    {
        public variatorForm_registr_()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            startWindow startWindow = new startWindow();
            this.Hide();
            startWindow.Show();
        }

        private void variatorForm_registr__FormClosing(object sender, FormClosingEventArgs e)
        {
            startWindow startWindow = new startWindow();
            this.Hide();
            startWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrFormSolo regFsolo = new registrFormSolo();
            this.Hide();
            regFsolo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
