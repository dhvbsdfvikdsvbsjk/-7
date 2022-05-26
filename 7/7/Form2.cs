using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form2 : Form
    {
        public static string str = @"Data Source=PK312-120;Initial Catalog=uslugi;Integrated Security=True";
        private SqlConnection con = new SqlConnection(str);
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fio = textBox1.Text;
            string pol = comboBox1.Text;
            string date = tme.Text;
            string serpas = textBox4.Text;
            string numpas = textBox5.Text;
            string Query2 = $"INSERT INTO [dbo].[kli]([fio],[dat],[po],[ser],[nom]) " +
                $"values ('" + fio + "','" + date + "','" + pol + "','" + serpas + "','" + numpas + "')";
            SqlCommand Command2 = new SqlCommand(Query2, con);
            Command2.ExecuteNonQuery();
            MessageBox.Show("Клиент добавлен в БД‼");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
