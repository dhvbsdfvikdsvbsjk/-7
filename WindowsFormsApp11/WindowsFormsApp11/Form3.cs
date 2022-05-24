using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Добавить новую строку, добавляет в самый конец БД
            yBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // удаляет строку БД
            yBindingSource.RemoveCurrent();        
        }

        private void yBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.yBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.yclugiDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yclugiDataSet.Y". При необходимости она может быть перемещена или удалена.
            this.yTableAdapter.Fill(this.yclugiDataSet.Y);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // сохраняет значение текстбоксов и добавляет их в БД
            yBindingSource.EndEdit();
            yTableAdapter.Update(yclugiDataSet);
        }
    }
}
