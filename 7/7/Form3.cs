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
    public partial class Form3 : Form
    {
        public static string str = @"Data Source=PK312-120;Initial Catalog=uslugi;Integrated Security=True";
        private SqlConnection con = new SqlConnection(str);
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            string s = textBox2.Text;
            string d = textBox3.Text;
            string Query2 = $"INSERT INTO [dbo].[usu]([Название],[Стоимость],[Длительность]) " +
                $"values ('" + n + "','" + s + "','" + d + "')";
            SqlCommand Command2 = new SqlCommand(Query2, con);
            Command2.ExecuteNonQuery();
            MessageBox.Show("Услуга добавлена в БД‼");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uslugiDataSet.usu". При необходимости она может быть перемещена или удалена.
            this.usuTableAdapter.Fill(this.uslugiDataSet.usu);
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query2 = $"delete from [dbo].[usu] WHERE [Название]"+comboBox1.Text+"";
            SqlCommand Command2 = new SqlCommand(Query2, con);
            Command2.ExecuteNonQuery();
            MessageBox.Show("Услуга удалена из БД‼");
        }
    }
}
