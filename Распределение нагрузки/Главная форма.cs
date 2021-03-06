﻿using Microsoft.Reporting.WebForms;
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

namespace Распределение_нагрузки
{
    public partial class Form1 : Form
    {
        Преподаватели преподаватели = null;
        Группы группы = null;
        Предметы предметы = null;
        Бакалавры бакалавры = null;
        общийОтчетForm form3 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Преподаватели преподаватели = new Преподаватели();
            преподаватели.Show();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Группы группы = new Группы();
            группы.Show();
        }

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Предметы предметы = new Предметы();
            предметы.Show();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            общийОтчетForm form3 = new общийОтчетForm();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (преподаватели == null || преподаватели.IsDisposed)
            {
                преподаватели = new Преподаватели();
                преподаватели.Show();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (группы == null || группы.IsDisposed)
            {
                группы = new Группы();
                группы.Show();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (предметы == null || предметы.IsDisposed)
            {
                предметы = new Предметы();
                предметы.Show();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new общийОтчетForm();
                form3.Show();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void бакалаврыButton_Click(object sender, EventArgs e)
        {
            if (бакалавры == null || бакалавры.IsDisposed)
            {
                бакалавры = new Бакалавры();
                бакалавры.Show();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Нагрузка_кафедры нагрузка_Кафедры = new Нагрузка_кафедры();
            //нагрузка_Кафедры.Show();

            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            InitialData.Справочники справочники = new InitialData.Справочники();
            справочники.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.ВсеПреподаватели_ХП". При необходимости она может быть перемещена или удалена.
            this.всеПреподаватели_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ВсеПреподаватели_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Все_преподаватели_показать_ХП". При необходимости она может быть перемещена или удалена.
            this.все_преподаватели_показать_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.Все_преподаватели_показать_ХП);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Отчет_по_преподавателям отчет_По_Преподавателям = new Отчет_по_преподавателям((int)comboBox1.SelectedValue);
            отчет_По_Преподавателям.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    SqlCommand flowsAvailable = new SqlCommand("РасчетНагрузкиКафедры_ХП", MyConnection);
                    flowsAvailable.CommandType = CommandType.StoredProcedure;

                    MyConnection.Open();
                    flowsAvailable.ExecuteNonQuery();

                    MessageBox.Show("Нагрузка кафедры рассчитана");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
