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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    DataTable data = DbConnection.select(@"INSERT INTO tovar (`название`, `цена`,`производитель`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "');");
                    data = DbConnection.select(@"SELECT * FROM tovar");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    dataGridView1.DataSource = data;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataTable data = DbConnection.select(@" DELETE FROM tovar WHERE номерт=" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            data = DbConnection.select(@"SELECT * FROM tovar");
            dataGridView1.DataSource = data;
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

        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable data = DbConnection.select("SELECT * FROM `tovar`");
            dataGridView1.DataSource = data;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Выберите колонку поиска");
            }
            else
            {
                DataTable data = DbConnection.select(@"SELECT * FROM tovar WHERE " + comboBox1.Text + " LIKE '" + "%" + textBox4.Text + "%" + "';");
                dataGridView1.DataSource = data;
            }
        }

    }
}
