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
    public partial class Form4 : Form
    {
        public static string str = @"Data Source=PK312-120;Initial Catalog=uslugi;Integrated Security=True";
        private SqlConnection con = new SqlConnection(str);
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uslugiDataSet2.usu". При необходимости она может быть перемещена или удалена.
            this.usuTableAdapter.Fill(this.uslugiDataSet2.usu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uslugiDataSet1.kli". При необходимости она может быть перемещена или удалена.
            this.kliTableAdapter.Fill(this.uslugiDataSet1.kli);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kl = comboBox1.Text;
            string na = comboBox2.Text;
            string st = comboBox3.Text;
            string dl = comboBox4.Text;
            string vr = dateTimePicker1.Text;
            string me = "26.05.2022";
            string Query2 = $"INSERT INTO [dbo].[sipaz]([Название],[Стоимость],[Длительность],[Клиент],[Время],[Дата]) " +
                $"values ('" + na + "','" + st + "','" + dl + "','" + kl + "','" + vr + "','" + me + "')";
            SqlCommand Command2 = new SqlCommand(Query2, con);
            Command2.ExecuteNonQuery();
            MessageBox.Show("Клиент записан на услугу‼");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }
    }
}
