using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Распределение_нагрузки
{
    public partial class Добавить_преподавателя : Form
    {
        Преподаватели _owner;
        public Добавить_преподавателя(Преподаватели owner)
        {
            _owner = owner;
            InitializeComponent();
        }

        private void Добавить_преподавателя_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.распределениеНагрузкиDataSet.Должности);

        }

        private void добавитьButton_Click(object sender, EventArgs e)
        {
            string name, secondName, thirdName;
            string[] words = ФИОTextBox.Text.Split();
            DateTime laborActivity;
            int position;
            double rate;

            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    name = words[0];
                    secondName = words[1];
                    
                    laborActivity = началоТрудовойДеятельностиDateTimePicker.Value;
                    position = Convert.ToInt32(должностьComboBox.SelectedIndex + 1);

                    SqlCommand addTeacher = new SqlCommand("ДобавитьПреподавателя_ХП", MyConnection);
                    addTeacher.CommandType = CommandType.StoredProcedure;
                    addTeacher.Parameters.AddWithValue("@name", name);
                    addTeacher.Parameters.AddWithValue("@secondName", secondName);
                    if (words.Count() == 3)
                    {
                        if (words[2] == "" || words[2] == null)
                        {
                            thirdName = words[2];
                        }
                        else
                        {
                            thirdName = "";
                        }
                        addTeacher.Parameters.AddWithValue("@thirdName", thirdName);
                    }
                    else
                    {
                        addTeacher.Parameters.AddWithValue("@thirdName", "");
                    }
                    addTeacher.Parameters.AddWithValue("@laborActivity", laborActivity);
                    addTeacher.Parameters.AddWithValue("@position", position);

                    MyConnection.Open();
                    addTeacher.ExecuteReader();

                    MessageBox.Show("Преподаватель добавлен", "", MessageBoxButtons.OK);

                    ФИОTextBox.Text = "";
                    должностьComboBox.SelectedIndex = 0;
                    началоТрудовойДеятельностиDateTimePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

                    _owner.formRefresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Поле ФИО Преподавателя принимает два или три слова", "Исправьте ошибки", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ФИОTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != 32 && l != 45 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
