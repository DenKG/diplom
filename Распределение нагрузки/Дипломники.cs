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
    public partial class Дипломники : Form
    {
        public Дипломники()
        {
            InitializeComponent();
        }

        private void Дипломники_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.ПоказатьДипломников_ХП". При необходимости она может быть перемещена или удалена.
            this.показатьДипломников_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ПоказатьДипломников_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.распределениеНагрузкиDataSet.Преподаватели);
            comboBox2.SelectedIndex = 0;
        }

        private void FillTable()
        {
            this.показатьДипломников_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ПоказатьДипломников_ХП);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0.5)
            {
                MessageBox.Show("Коэффициент не может превышать 0,5", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                {
                    try
                    {
                        SqlCommand addAcadCur = new SqlCommand("ДобавитьДипломников_ХП", MyConnection);
                        addAcadCur.CommandType = CommandType.StoredProcedure;

                        addAcadCur.Parameters.AddWithValue("@teacherID", (int)comboBox1.SelectedValue);
                        addAcadCur.Parameters.AddWithValue("@count", comboBox2.SelectedIndex + 1);
                        addAcadCur.Parameters.AddWithValue("@coeff", Convert.ToDecimal(textBox1.Text));

                        var returnValue = addAcadCur.Parameters.Add("@Return", SqlDbType.Int);

                        MyConnection.Open();

                        returnValue.Direction = ParameterDirection.ReturnValue;
                        addAcadCur.ExecuteReader();
                        var storedProcResult = (int)returnValue.Value;

                        if (storedProcResult == 1)
                        {
                            MessageBox.Show("Данному преподавателю уже назначены дипломники. Удалите назначенных дипломников и повторите операцию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            FillTable();
                            //Преподаватели.SelfRef.RefreshTable(teacherID);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            DialogResult dialogResult;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int rowNum;
                int teachersID;
                int subjID;

                rowNum = dataGridView1.CurrentCell.RowIndex;
                teachersID = Convert.ToInt32(dataGridView1.Rows[rowNum].Cells[0].Value);
                subjID = Convert.ToInt32(dataGridView1.Rows[rowNum].Cells[1].Value);

                using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                {
                    try
                    {
                        SqlCommand flowsAvailable = new SqlCommand($"DELETE FROM Преподаватель_предметы WHERE Преподаватель = {teachersID} AND Предмет = {subjID}", MyConnection);

                        MyConnection.Open();
                        flowsAvailable.ExecuteNonQuery();

                        FillTable();

                       // Преподаватели.SelfRef.RefreshTable(teacherID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }
    }
}
