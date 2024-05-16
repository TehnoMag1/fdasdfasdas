using fdasdfasdas.WindowsFormsApplication11;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fdasdfasdas
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            DataTable data = DbConnection.select(@"SELECT * FROM HistroySales");
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Shown(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            ///
            DataTable data = DbConnection.select("SELECT * FROM tovar");
            comboBox1.DataSource = data;
            comboBox1.DisplayMember = "название";
            comboBox1.SelectedIndex = -1;
            ///
            data = DbConnection.select("SELECT * FROM Klients");
            comboBox2.DataSource = data;
            comboBox2.DisplayMember = "фио";
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // idKlients
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if ((dateTimePicker1.Text == "") || (comboBox1.Text == "") || (comboBox2.Text == ""))
                {
                    MessageBox.Show("Заполните ВСЕ поля");
                }
                else
                {
                    DataTable data = DbConnection.select(@"INSERT INTO HistroySales (`DataVidachi`, `idProdavecy`,`idKnigi`,`idKlients`) VALUES ('" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "');");

                    data = DbConnection.select(@"SELECT * FROM HistroySales");
                    dataGridView1.DataSource = data;



                }
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // idKnigi
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable data = DbConnection.select(@" DELETE FROM HistroySales WHERE номер_з=" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            data = DbConnection.select(@"SELECT * FROM HistroySales");
            dataGridView1.DataSource = data;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // idProdavecy
            DataTable data = DbConnection.select("SELECT * FROM `ISPr24-39_NurgaleevDA_Praktika`.polzovateli");
            comboBox3.DataSource = data;
            comboBox3.DisplayMember = "login";
            comboBox3.ValueMember = "id_t";
        }
    }
}
