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

namespace Распределение_нагрузки.InitialData
{
    public partial class Справочники : Form
    {
        int teacherHours, elderTeacherHours, docent, professor;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox25.Text = teacherHours.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox25.Text = elderTeacherHours.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox25.Text = docent.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox25.Text = professor.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Справочники()
        {
            InitializeComponent();
        }

        private void Справочники_Load(object sender, EventArgs e)
        {
            FillTextBoxes();
            comboBox1.SelectedIndex = 0;
        }

        private void FillTextBoxes()
        {
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    SqlCommand getParam1 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 1 + "'", MyConnection);
                    SqlCommand getParam2 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 2 + "'", MyConnection);
                    SqlCommand getParam3 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 3 + "'", MyConnection);
                    SqlCommand getParam4 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 4 + "'", MyConnection);
                    SqlCommand getParam5 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 5 + "'", MyConnection);
                    SqlCommand getParam6 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 6 + "'", MyConnection);
                    SqlCommand getParam7 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 7 + "'", MyConnection);
                    SqlCommand getParam8 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 8 + "'", MyConnection);
                    SqlCommand getParam9 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 9 + "'", MyConnection);
                    SqlCommand getParam10 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 10 + "'", MyConnection);
                    SqlCommand getParam11 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 11 + "'", MyConnection);
                    SqlCommand getParam12 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 12 + "'", MyConnection);
                    SqlCommand getParam13 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 13 + "'", MyConnection);
                    SqlCommand getParam14 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 14 + "'", MyConnection);
                    SqlCommand getParam15 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 15 + "'", MyConnection);
                    SqlCommand getParam16 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 16 + "'", MyConnection);
                    SqlCommand getParam17 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 17 + "'", MyConnection);
                    SqlCommand getParam18 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 18 + "'", MyConnection);
                    SqlCommand getParam19 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 19 + "'", MyConnection);
                    SqlCommand getParam20 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 20 + "'", MyConnection);
                    SqlCommand getParam21 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 21 + "'", MyConnection);
                    SqlCommand getParam22 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 22 + "'", MyConnection);
                    SqlCommand getParam23 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 23 + "'", MyConnection);
                    SqlCommand getParam24 = new SqlCommand("Select Значение from НормыВремени where ID = '" + 24 + "'", MyConnection);

                    SqlCommand _teacherHours = new SqlCommand("Select Часы from Должности where Должность = 'Преподаватель'", MyConnection);
                    SqlCommand _elderTeacherHours = new SqlCommand("Select Часы from Должности where Должность = 'Старший преподаватель'", MyConnection);
                    SqlCommand _docent = new SqlCommand("Select Часы from Должности where Должность = 'Доцент'", MyConnection);
                    SqlCommand _professor = new SqlCommand("Select Часы from Должности where Должность = 'Профессор'", MyConnection);

                    MyConnection.Open();

                    textBox4.Text = getParam5.ExecuteScalar().ToString();
                    textBox5.Text = getParam6.ExecuteScalar().ToString();
                    textBox6.Text = getParam7.ExecuteScalar().ToString();
                    textBox7.Text = getParam8.ExecuteScalar().ToString();
                    textBox8.Text = getParam9.ExecuteScalar().ToString();
                    textBox9.Text = getParam10.ExecuteScalar().ToString();
                    textBox10.Text = getParam18.ExecuteScalar().ToString();
                    textBox11.Text = getParam19.ExecuteScalar().ToString();
                    textBox12.Text = getParam20.ExecuteScalar().ToString();
                    textBox20.Text = getParam12.ExecuteScalar().ToString();
                    textBox21.Text = getParam13.ExecuteScalar().ToString();
                    textBox22.Text = getParam14.ExecuteScalar().ToString();
                    textBox23.Text = getParam15.ExecuteScalar().ToString();
                    textBox24.Text = getParam16.ExecuteScalar().ToString();
                    textBox1.Text = getParam1.ExecuteScalar().ToString();
                    textBox2.Text = getParam3.ExecuteScalar().ToString();
                    textBox3.Text = getParam4.ExecuteScalar().ToString();
                    textBox15.Text = getParam17.ExecuteScalar().ToString();
                    textBox16.Text = getParam21.ExecuteScalar().ToString();
                    textBox17.Text = getParam2.ExecuteScalar().ToString();
                    textBox18.Text = getParam5.ExecuteScalar().ToString();
                    textBox19.Text = getParam5.ExecuteScalar().ToString();
                    textBox13.Text = getParam24.ExecuteScalar().ToString();
                    textBox14.Text = getParam23.ExecuteScalar().ToString();

                    teacherHours = Convert.ToInt32(_teacherHours.ExecuteScalar());
                    elderTeacherHours = Convert.ToInt32(_elderTeacherHours.ExecuteScalar());
                    docent = Convert.ToInt32(_docent.ExecuteScalar());
                    professor = Convert.ToInt32(_professor.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
