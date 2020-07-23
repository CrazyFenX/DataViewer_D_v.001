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
    public partial class startWindow : Form
    {
        public startWindow()
        {
            InitializeComponent();
            backButton.Visible = false;
            solistButton.Visible = false;
            duetButton.Visible = false;
            sekwayButton.Visible = false;
            ansamblButton.Visible = false;
        }

        private void startForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD1DataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.bD1DataSet.Таблица1);
        }

        private void registratorButton_Click(object sender, EventArgs e)
        {
            registratorButton.Visible = false;
            secretaryButton.Visible = false;

            backButton.Visible = true;
            solistButton.Visible = true;
            duetButton.Visible = true;
            sekwayButton.Visible = true;
            ansamblButton.Visible = true;
        }

        private void startWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            registratorButton.Visible = true;
            secretaryButton.Visible = true;

            backButton.Visible = false;
            solistButton.Visible = false;
            duetButton.Visible = false;
            sekwayButton.Visible = false;
            ansamblButton.Visible = false;
        }

        private void solistButton_Click(object sender, EventArgs e)
        {
            registrFormSolo regFsolo = new registrFormSolo();
            this.Hide();
            regFsolo.Show();
        }

        private void duetButton_Click(object sender, EventArgs e)
        {
            registrFormDuet regFduet = new registrFormDuet();
            this.Hide();
            regFduet.Show();
        }
    }
}
