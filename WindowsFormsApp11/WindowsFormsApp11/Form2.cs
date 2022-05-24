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

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        public static string str = @"Data Source=WSR-SRV\SQLEXPRESS;Initial Catalog=klienti;Integrated Security=True";
        private SqlConnection con = new SqlConnection(str);
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fio = textBox1.Text;
            string pol = comboBox1.Text;
            string date = dateTimePicker1.Text;
            string serpas = textBox4.Text;
            string numpas = textBox3.Text;
            string Query2 = $"INSERT INTO [dbo].[K]([Фио],[дата_рождения],[пол],[серия_паспорта],[номер_паспорта]) " +
                $"values ('" + fio + "','" + pol + "','" + date + "','" + serpas + "','" + numpas + "')";
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
        }
    }
}
