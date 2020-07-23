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
    public partial class registrFormSolo : Form
    {
        startWindow startWindow = new startWindow();

        public registrFormSolo()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            startWindow.Show();
        }
        ~registrFormSolo()
        {
            Application.Exit();
        }

        private void registrForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD1DataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.bD1DataSet.Таблица1);

        }

        private void registrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Application.Exit();

            this.Hide();
            startWindow.Show();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
