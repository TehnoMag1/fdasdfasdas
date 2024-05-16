using fdasdfasdas.WindowsFormsApplication11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fdasdfasdas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            //Hide();
            DataTable data = DbConnection.select("SELECT * FROM `tovar`");


        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            //Hide();
            DataTable data = DbConnection.select("SELECT * FROM `Klients`");
        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            //Hide();
            DataTable data = DbConnection.select("SELECT * FROM `HistroySales`");
        }
    }
}
