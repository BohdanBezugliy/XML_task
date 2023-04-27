using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;

namespace Завдання__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[n].Cells[2].Value = numericUpDown1.Text;
                dataGridView1.Rows[n].Cells[3].Value = textBox3.Text;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Таблиця";
                dt.Columns.Add("Ім'я");
                dt.Columns.Add("Прізвище");
                dt.Columns.Add("Вік");
                dt.Columns.Add("Хобі");
                ds.Tables.Add(dt);
                foreach(DataGridViewRow r in dataGridView1.Rows)
                {
                    DataRow row = ds.Tables["Таблиця"].NewRow();
                    row["Ім'я"] = r.Cells[0].Value;
                    row["Прізвище"] = r.Cells[1].Value;
                    row["Вік"] = r.Cells[2].Value;
                    row["Хобі"] = r.Cells[3].Value;
                    ds.Tables["Таблиця"].Rows.Add(row);
                }
                ds.WriteXml("Data.xml");
            }
            catch
            {
                MessageBox.Show("Помилка запису у файл XML", "Помилка.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int n = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[n].Cells[2].Value = numericUpDown1.Text;
                dataGridView1.Rows[n].Cells[3].Value = textBox3.Text;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Таблиця";
                dt.Columns.Add("Ім'я");
                dt.Columns.Add("Прізвище");
                dt.Columns.Add("Вік");
                dt.Columns.Add("Хобі");
                ds.Tables.Add(dt);
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    DataRow row = ds.Tables["Таблиця"].NewRow();
                    row["Ім'я"] = r.Cells[0].Value;
                    row["Прізвище"] = r.Cells[1].Value;
                    row["Вік"] = r.Cells[2].Value;
                    row["Хобі"] = r.Cells[3].Value;
                    ds.Tables["Таблиця"].Rows.Add(row);
                }
                ds.WriteXml("Data.xml");
            }
            else
            {
                MessageBox.Show("Не обраний рядок!", "Помилка.");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Таблиця";
                dt.Columns.Add("Ім'я");
                dt.Columns.Add("Прізвище");
                dt.Columns.Add("Вік");
                dt.Columns.Add("Хобі");
                ds.Tables.Add(dt);
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    DataRow row = ds.Tables["Таблиця"].NewRow();
                    row["Ім'я"] = dataGridView1.Rows[i].Cells[0].Value;
                    row["Прізвище"] = dataGridView1.Rows[i].Cells[1].Value;
                    row["Вік"] = dataGridView1.Rows[i].Cells[2].Value;
                    row["Хобі"] = dataGridView1.Rows[i].Cells[3].Value;
                    ds.Tables["Таблиця"].Rows.Add(row);
                }
                ds.WriteXml("Data.xml");
            }
            else
            {
                MessageBox.Show("Не обраний рядок!", "Помилка.");
            }
        }
    }
}
