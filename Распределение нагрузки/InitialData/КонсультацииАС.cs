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
    public partial class КонсультацииАС : Form
    {
        public int teacherID;
        public КонсультацииАС(int _teacherID)
        {
            teacherID = _teacherID;
            InitializeComponent();
        }

        private void КонсультацииАС_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet1.ПоказатьАкадСоветников_ХП". При необходимости она может быть перемещена или удалена.
            this.показатьАкадСоветников_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet1.ПоказатьАкадСоветников_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.ПоказатьАкадСоветников_ХП". При необходимости она может быть перемещена или удалена.
            this.показатьАкадСоветников_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ПоказатьАкадСоветников_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Уровни_подготовки". При необходимости она может быть перемещена или удалена.
            this.уровни_подготовкиTableAdapter.Fill(this.распределениеНагрузкиDataSet.Уровни_подготовки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Направления". При необходимости она может быть перемещена или удалена.
            this.направленияTableAdapter.Fill(this.распределениеНагрузкиDataSet.Направления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.распределениеНагрузкиDataSet.Преподаватели);
            comboBox5_SelectedIndexChanged(sender, e);
        }

        private void fillGroupCB ()
        {
            int course = 0;

            course = (int)Math.Ceiling(Convert.ToDecimal(comboBox3.SelectedIndex + 1) / 2);
            

            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    SqlCommand flowsAvailable = new SqlCommand("ВыбратьГруппы_ХП", MyConnection);
                    flowsAvailable.CommandType = CommandType.StoredProcedure;
                    flowsAvailable.Parameters.AddWithValue("@direction", Convert.ToInt32(comboBox4.SelectedValue));
                    flowsAvailable.Parameters.AddWithValue("@preparation", Convert.ToInt32(comboBox5.SelectedValue));
                    flowsAvailable.Parameters.AddWithValue("@language", "");
                    flowsAvailable.Parameters.AddWithValue("@course", course);

                    MyConnection.Open();
                    flowsAvailable.ExecuteNonQuery();

                    using (var dataReader = flowsAvailable.ExecuteReader())
                    {
                        comboBox2.DataSource = null;
                        comboBox2.Items.Clear();
                        DataTable dt = new DataTable();
                        dt.Load(dataReader);

                        comboBox2.DataSource = dt;
                        comboBox2.ValueMember = "ID";
                        comboBox2.DisplayMember = "Группа";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGroupCB();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            if (Convert.ToInt32(comboBox5.SelectedValue) == 1)
            {
                comboBox3.Items.Add("1");
                comboBox3.Items.Add("2");
                comboBox3.Items.Add("3");
                comboBox3.Items.Add("4");
                comboBox3.Items.Add("5");
                comboBox3.Items.Add("6");
                comboBox3.Items.Add("7");
                comboBox3.Items.Add("8");

                comboBox3.SelectedIndex = 0;
            }

            if (Convert.ToInt32(comboBox5.SelectedValue) == 2)
            {
                comboBox3.Items.Add("1");
                comboBox3.Items.Add("2");
                comboBox3.Items.Add("3");
                comboBox3.Items.Add("4");

                comboBox3.SelectedIndex = 0;
            }

            if (Convert.ToInt32(comboBox5.SelectedValue) == 3)
            {
                comboBox3.Items.Add("1");
                comboBox3.Items.Add("2");
                comboBox3.Items.Add("3");
                comboBox3.Items.Add("4");
                comboBox3.Items.Add("5");
                comboBox3.Items.Add("6");
                comboBox3.Items.Add("7");
                comboBox3.Items.Add("8");
                comboBox3.Items.Add("9");
                comboBox3.Items.Add("10");

                comboBox3.SelectedIndex = 0;
            }

            fillGroupCB();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGroupCB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    SqlCommand addAcadCur = new SqlCommand("НазначитьАкадемСоветника_ХП", MyConnection);
                    addAcadCur.CommandType = CommandType.StoredProcedure;

                    addAcadCur.Parameters.AddWithValue("@direction", (int)comboBox4.SelectedValue);
                    addAcadCur.Parameters.AddWithValue("@preparation", (int)comboBox5.SelectedValue);
                    addAcadCur.Parameters.AddWithValue("@semester", comboBox3.SelectedIndex + 1);
                    addAcadCur.Parameters.AddWithValue("@group", (int)comboBox2.SelectedValue);
                    addAcadCur.Parameters.AddWithValue("@teacher", (int)comboBox1.SelectedValue);

                    var returnValue = addAcadCur.Parameters.Add("@Return", SqlDbType.Int);

                    MyConnection.Open();

                    returnValue.Direction = ParameterDirection.ReturnValue;
                    addAcadCur.ExecuteReader();
                    var storedProcResult = (int)returnValue.Value;

                    if (storedProcResult == 1)
                    {
                        MessageBox.Show("Данный преподаватель в группе уже назначен как академический советник", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        fillTable();
                        Преподаватели.SelfRef.RefreshTable(teacherID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void fillTable()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.ПоказатьАкадСоветников_ХП". При необходимости она может быть перемещена или удалена.
            this.показатьАкадСоветников_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet1.ПоказатьАкадСоветников_ХП);
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
                int groupID;
                int subjID;

                rowNum = dataGridView1.CurrentCell.RowIndex;
                teachersID = Convert.ToInt32(dataGridView1.Rows[rowNum].Cells[6].Value);
                groupID = Convert.ToInt32(dataGridView1.Rows[rowNum].Cells[7].Value);
                subjID = Convert.ToInt32(dataGridView1.Rows[rowNum].Cells[8].Value);

                using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                {
                    try
                    {
                        SqlCommand flowsAvailable = new SqlCommand($"DELETE FROM Преподаватель_предметы WHERE Преподаватель = {teachersID} AND Группа = {groupID} AND Предмет = {subjID}", MyConnection);

                        MyConnection.Open();
                        flowsAvailable.ExecuteNonQuery();

                        fillTable();

                        Преподаватели.SelfRef.RefreshTable(teacherID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
