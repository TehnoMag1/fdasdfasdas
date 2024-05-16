using fdasdfasdas.WindowsFormsApplication11;
using System.Data;

namespace fdasdfasdas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = DbConnection.select("select * from `polzovateli` where login = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "'");
            if (data.Rows.Count == 1)
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }


        }


    }
}