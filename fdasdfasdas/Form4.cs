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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Выберите колонку поиска");
            }
            else
            {
                DataTable data = DbConnection.select(@"SELECT * FROM Klients WHERE " + comboBox1.Text + " LIKE '" + "%" + textBox4.Text + "%" + "';");
                dataGridView1.DataSource = data;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable data = DbConnection.select(@" DELETE FROM Klients WHERE номерт=" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            data = DbConnection.select(@"SELECT * FROM Klients");
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                {
                    MessageBox.Show("Заполните ВСЕ поля");
                }
                else
                {
                    DataTable data = DbConnection.select(@"INSERT INTO Klients (`Surname`, `Name`,`MiddleName`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "',  '" + textBox4.Text + "')");
                    data = DbConnection.select(@"SELECT * FROM Klients");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    dataGridView1.DataSource = data;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable data = DbConnection.select("SELECT * FROM `Klients`");
            dataGridView1.DataSource = data;
        }
    }
}
