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
    public partial class Группы : Form
    {
        bool editGroup = false, addGroup = false;
        public Группы()
        {
            InitializeComponent();
        }

        private void Группы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.ПоказатьПотоки_ХП". При необходимости она может быть перемещена или удалена.
            this.показатьПотоки_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ПоказатьПотоки_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet1.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.распределениеНагрузкиDataSet1.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.ПоказатьГруппы_ХП". При необходимости она может быть перемещена или удалена.
            this.показатьГруппы_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ПоказатьГруппы_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Направления". При необходимости она может быть перемещена или удалена.
            this.направленияTableAdapter.Fill(this.распределениеНагрузкиDataSet.Направления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Языки". При необходимости она может быть перемещена или удалена.
            this.языкиTableAdapter.Fill(this.распределениеНагрузкиDataSet.Языки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Уровни_подготовки". При необходимости она может быть перемещена или удалена.
            this.уровни_подготовкиTableAdapter.Fill(this.распределениеНагрузкиDataSet.Уровни_подготовки);

            groupComboBoxFill();
            группыComboBox_SelectedIndexChanged(sender, e);
            dataGridView2.Columns[0].Visible = false;
        }

        private void группыComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            группыComboBox.ValueMember = "ID";
            группыComboBox.DisplayMember = "Группа";

            tabControl1.SelectedTab = tabPage1;

            int ID;
            ID = Convert.ToInt32(группыComboBox.SelectedValue);
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    SqlCommand getName = new SqlCommand("Select Группа from Группы where ID = '" + ID + "'", MyConnection);

                    SqlCommand getQuantity = new SqlCommand("Select Количество from Группы where ID = '" + ID + "'", MyConnection);

                    SqlCommand getYear = new SqlCommand("Select Год_поступления from Группы where ID = '" + ID + "'", MyConnection);

                    SqlCommand getCourse = new SqlCommand("Select Курс from Группы where ID = '" + ID + "'", MyConnection);

                    SqlCommand getContract = new SqlCommand("Select Бюджет from Группы where ID = '" + ID + "'", MyConnection);

                    SqlCommand getBudget = new SqlCommand("Select Контракт from Группы where ID = '" + ID + "'", MyConnection);

                    SqlCommand getDirectionID = new SqlCommand("Select Направление from Группы where ID = '" + ID + "'", MyConnection);
                    SqlCommand getDirection = new SqlCommand("Select Направление from Направления where ID = '" + getDirectionID + "'", MyConnection);

                    SqlCommand getLanguageID = new SqlCommand("Select Язык from Группы where ID = '" + ID + "'", MyConnection);
                    SqlCommand getLanguage = new SqlCommand("Select Язык from Языки where ID = '" + getLanguageID + "'", MyConnection);

                    SqlCommand getPreparationID = new SqlCommand("Select Уровень_подготовки from Группы where ID = '" + ID + "'", MyConnection);
                    SqlCommand getPreparation = new SqlCommand("Select Уровень_подготовки from Уровни_подготовки where ID = '" + getPreparationID + "'", MyConnection);

                    MyConnection.Open();

                    int course;
                    course = Convert.ToInt32(getCourse.ExecuteScalar());

                    группаTextBox.Text = getName.ExecuteScalar().ToString();
                    количествоСтудентовTextBox.Text = getQuantity.ExecuteScalar().ToString();
                    годПоступленияTextBox.Text = getYear.ExecuteScalar().ToString();
                    курсComboBox.SelectedIndex =  course - 1;
                    направлениеComboBox.SelectedValue = getDirectionID.ExecuteScalar();
                    языкComboBox.SelectedValue = getLanguageID.ExecuteScalar();
                    уровеньПодготовкиComboBox.SelectedValue = getPreparationID.ExecuteScalar();
                    количествоБюджетниковTextBox.Text = getBudget.ExecuteScalar().ToString();
                    количествоКонтрактниковTextBox.Text = getContract.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void сохранитьГруппуButton_Click(object sender, EventArgs e)
        {
            string groupName;
            groupName = группаTextBox.Text;

            bool start = false;

            start = checkGroups();

            if (start == true)
            {
                if (addGroup == true)
                {
                    using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                    {
                        try
                        {
                            SqlCommand addGroup = new SqlCommand("ДобавитьГруппу_ХП", MyConnection);
                            addGroup.CommandType = CommandType.StoredProcedure;
                            addGroup.Parameters.AddWithValue("@name", groupName);
                            addGroup.Parameters.AddWithValue("@direction", Convert.ToInt32(направлениеComboBox.SelectedValue));
                            addGroup.Parameters.AddWithValue("@studQuant", Convert.ToInt32(количествоСтудентовTextBox.Text));
                            addGroup.Parameters.AddWithValue("@language", Convert.ToInt32(языкComboBox.SelectedValue));
                            addGroup.Parameters.AddWithValue("@year", Convert.ToInt32(годПоступленияTextBox.Text));
                            addGroup.Parameters.AddWithValue("@course", Convert.ToInt32(курсComboBox.SelectedIndex + 1));
                            addGroup.Parameters.AddWithValue("@preparation", Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue));
                            addGroup.Parameters.AddWithValue("@budget", Convert.ToInt32(количествоБюджетниковTextBox.Text));
                            addGroup.Parameters.AddWithValue("@contract", Convert.ToInt32(количествоКонтрактниковTextBox.Text));

                            MyConnection.Open();
                            addGroup.ExecuteReader();

                            //this.группыTableAdapter.Fill(this.распределениеНагрузкиDataSet1.Группы);
                            groupComboBoxFill();
                            this.показатьГруппы_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ПоказатьГруппы_ХП);

                            направлениеComboBox.Enabled = false;
                            количествоСтудентовTextBox.Enabled = false;
                            языкComboBox.Enabled = false;
                            годПоступленияTextBox.Enabled = false;
                            курсComboBox.Enabled = false;
                            уровеньПодготовкиComboBox.Enabled = false;
                            группаTextBox.Enabled = false;
                            сохранитьГруппуButton.Enabled = false;
                            количествоБюджетниковTextBox.Enabled = false;
                            количествоКонтрактниковTextBox.Enabled = false;
                            отменаButton.Enabled = false;

                            MessageBox.Show("Группа добавлена", "", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    addGroup = false;
                }

                if (editGroup == true)
                {
                    int ID;
                    ID = Convert.ToInt32(группыComboBox.SelectedValue);
                    using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                    {
                        try
                        {
                            SqlCommand addGroup = new SqlCommand("РедактироватьГруппу_ХП", MyConnection);
                            addGroup.CommandType = CommandType.StoredProcedure;
                            addGroup.Parameters.AddWithValue("@name", groupName);
                            addGroup.Parameters.AddWithValue("@direction", Convert.ToInt32(направлениеComboBox.SelectedValue));
                            addGroup.Parameters.AddWithValue("@studQuant", Convert.ToInt32(количествоСтудентовTextBox.Text));
                            addGroup.Parameters.AddWithValue("@language", Convert.ToInt32(языкComboBox.SelectedValue));
                            addGroup.Parameters.AddWithValue("@year", Convert.ToInt32(годПоступленияTextBox.Text));
                            addGroup.Parameters.AddWithValue("@course", Convert.ToInt32(курсComboBox.SelectedIndex + 1));
                            addGroup.Parameters.AddWithValue("@preparation", Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue));
                            addGroup.Parameters.AddWithValue("@budget", Convert.ToInt32(количествоБюджетниковTextBox.Text));
                            addGroup.Parameters.AddWithValue("@contract", Convert.ToInt32(количествоКонтрактниковTextBox.Text));
                            addGroup.Parameters.AddWithValue("@ID", ID);

                            MyConnection.Open();
                            addGroup.ExecuteReader();

                            //this.группыTableAdapter.Fill(this.распределениеНагрузкиDataSet.Группы);
                            groupComboBoxFill();
                            this.показатьГруппы_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ПоказатьГруппы_ХП);

                            направлениеComboBox.Enabled = false;
                            количествоСтудентовTextBox.Enabled = false;
                            языкComboBox.Enabled = false;
                            годПоступленияTextBox.Enabled = false;
                            курсComboBox.Enabled = false;
                            уровеньПодготовкиComboBox.Enabled = false;
                            группаTextBox.Enabled = false;
                            сохранитьГруппуButton.Enabled = false;
                            количествоБюджетниковTextBox.Enabled = false;
                            количествоКонтрактниковTextBox.Enabled = false;
                            отменаButton.Enabled = false;

                            editGroup = false;

                            MessageBox.Show("Данные о группе изменены", "", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void groupComboBoxFill()
        {
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    SqlCommand groups = new SqlCommand("ВыбратьВсеГруппы_ХП", MyConnection);
                    groups.CommandType = CommandType.StoredProcedure;

                    MyConnection.Open();

                    using (var dataReader = groups.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dataReader);

                            группыComboBox.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool checkGroups()
        {
            bool decision;
            int budget = 0, contract = 0;

            if (!string.IsNullOrWhiteSpace(количествоБюджетниковTextBox.Text))
            {
                budget = Convert.ToInt32(количествоБюджетниковTextBox.Text);
            }
            else
            {
                budget = 0;
                количествоБюджетниковTextBox.Text = "0";
            }

            if (!string.IsNullOrWhiteSpace(группаTextBox.Text))
            {
                decision = true;
                if (!string.IsNullOrWhiteSpace(количествоСтудентовTextBox.Text))
                {
                    decision = true;
                    if (!string.IsNullOrWhiteSpace(годПоступленияTextBox.Text))
                    {
                        decision = true;
                        if (!string.IsNullOrWhiteSpace(количествоКонтрактниковTextBox.Text))
                        {
                            contract = Convert.ToInt32(количествоКонтрактниковTextBox.Text);
                            decision = true;
                            if (budget + contract != Convert.ToInt32(количествоСтудентовTextBox.Text))
                            {
                                decision = false;
                                MessageBox.Show("Количество бюджетников и контрактников не совпадает с общим количеством студентов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            decision = false;
                            MessageBox.Show("Укажите количество контрактников", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        decision = false;
                        MessageBox.Show("Укажите год поступления", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    decision = false;
                    MessageBox.Show("Укажите количество студентов", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                decision = false;
                MessageBox.Show("Введите название группы", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return decision;
        }

        private void редактироватьГруппуButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;

            editGroup = true;

            направлениеComboBox.Enabled = true;
            количествоСтудентовTextBox.Enabled = true;
            языкComboBox.Enabled = true;
            годПоступленияTextBox.Enabled = true;
            курсComboBox.Enabled = true;
            уровеньПодготовкиComboBox.Enabled = true;
            группаTextBox.Enabled = true;
            сохранитьГруппуButton.Enabled = true;
            количествоБюджетниковTextBox.Enabled = true;
            количествоКонтрактниковTextBox.Enabled = true;
            отменаButton.Enabled = true;
        }

        private void количествоСтудентовTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void количествоБюджетниковTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void количествоКонтрактниковTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void годПоступленияTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void группаTextBox_Leave(object sender, EventArgs e)
        {
            if (группаTextBox.Text.ToString().Length < 5)
            {
                MessageBox.Show("Название группы должно состоять из не мене, чем четырёх символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void отменаButton_Click(object sender, EventArgs e)
        {
            направлениеComboBox.Enabled = false;
            количествоСтудентовTextBox.Enabled = false;
            языкComboBox.Enabled = false;
            годПоступленияTextBox.Enabled = false;
            курсComboBox.Enabled = false;
            уровеньПодготовкиComboBox.Enabled = false;
            группаTextBox.Enabled = false;
            сохранитьГруппуButton.Enabled = false;
            количествоБюджетниковTextBox.Enabled = false;
            количествоКонтрактниковTextBox.Enabled = false;
            отменаButton.Enabled = false;

            группыComboBox_SelectedIndexChanged(sender, e);
        }

        private void направлениеПотокиComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            направлениеПотокиComboBox_SelectedIndexChanged(sender, e);
            уровеньПодготовкиComboBox_SelectedIndexChanged(sender, e);
        }

        private void ОКButton_Click(object sender, EventArgs e)
        {
            bool ok = false;
            if (курсПотокиComboBox.SelectedIndex > -1)
            {
                if (!string.IsNullOrEmpty(количествоПотоковTextBox.Text))
                {
                    if (!string.IsNullOrEmpty(названиеПотока.Text))
                    {
                        ok = true;
                    }
                    else
                    {
                        MessageBox.Show("Укажите название потока");
                    }
                }
                else
                {
                    MessageBox.Show("Укажите количество потоков");
                }
            }
            else
            {
                MessageBox.Show("Выберите курс");
            }

            if (ok == true)
            {
                using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                {
                    try
                    {
                        SqlCommand addFlow = new SqlCommand("ДобавитьПоток_ХП", MyConnection);
                        addFlow.CommandType = CommandType.StoredProcedure;
                        addFlow.Parameters.AddWithValue("@direction", Convert.ToInt32(направлениеПотокиComboBox.SelectedValue));
                        addFlow.Parameters.AddWithValue("@name", названиеПотока.Text.ToString());
                        addFlow.Parameters.AddWithValue("@quantity", количествоПотоковTextBox.Text.ToString());
                        addFlow.Parameters.AddWithValue("@course", курсПотокиComboBox.SelectedIndex + 1);
                        addFlow.Parameters.AddWithValue("@preparation", Convert.ToInt32(уровеньПодготовкиПотокиComboBox.SelectedValue));

                        //addFlow.ExecuteReader();
                        var returnValue = addFlow.Parameters.Add("@Return", SqlDbType.Int);

                        MyConnection.Open();

                        returnValue.Direction = ParameterDirection.ReturnValue;
                        addFlow.ExecuteNonQuery();
                        var sotredProcResult = (int)returnValue.Value;
                        var result = sotredProcResult;

                        if (result == 1)
                        {
                            MessageBox.Show("Поток с таким курсом и направлением уже существует");
                        }

                        this.показатьПотоки_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ПоказатьПотоки_ХП);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            DialogResult dialogResult;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int rowNum;
                string direction, preparation;
                int course;

                rowNum = dataGridView2.CurrentCell.RowIndex;
                direction = dataGridView2.Rows[rowNum].Cells[2].Value.ToString();
                course = Convert.ToInt32(dataGridView2.Rows[rowNum].Cells[4].Value);
                preparation = dataGridView2.Rows[rowNum].Cells[1].Value.ToString();

                dialogResult = MessageBox.Show("Удалить все потоки соответствующего курса и направления?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                    {
                        try
                        {
                            SqlCommand deleteFlows = new SqlCommand("УдалитьПотоки_ХП", MyConnection);
                            deleteFlows.CommandType = CommandType.StoredProcedure;
                            deleteFlows.Parameters.AddWithValue("@direction", direction);
                            deleteFlows.Parameters.AddWithValue("@course", course);
                            deleteFlows.Parameters.AddWithValue("@preparation", preparation);

                            MyConnection.Open();
                            deleteFlows.ExecuteNonQuery();

                            this.показатьПотоки_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ПоказатьПотоки_ХП);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void уровеньПодготовкиComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void уровеньПодготовкиПотокиComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            курсПотокиComboBox.Items.Clear();
            if (Convert.ToInt32(направлениеПотокиComboBox.SelectedValue) == 1)
            {
                курсПотокиComboBox.Items.Add("1");
                курсПотокиComboBox.Items.Add("2");
                курсПотокиComboBox.Items.Add("3");
                курсПотокиComboBox.Items.Add("4");
                курсПотокиComboBox.SelectedIndex = 0;
            }

            if (Convert.ToInt32(направлениеПотокиComboBox.SelectedValue) == 3)
            {
                курсПотокиComboBox.Items.Add("1");
                курсПотокиComboBox.Items.Add("2");
                курсПотокиComboBox.Items.Add("3");
                курсПотокиComboBox.Items.Add("4");
                курсПотокиComboBox.Items.Add("5");
                курсПотокиComboBox.SelectedIndex = 0;
            }

            if (Convert.ToInt32(направлениеПотокиComboBox.SelectedValue) == 2)
            {
                курсПотокиComboBox.Items.Add("1");
                курсПотокиComboBox.Items.Add("2");
                курсПотокиComboBox.SelectedIndex = 0;
            }
        }

        private void количествоПотоковTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void добавитьГруппуButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;

            addGroup = true;

            направлениеComboBox.SelectedValue = 1;
            количествоСтудентовTextBox.Text = "";
            языкComboBox.SelectedValue = 1;
            годПоступленияTextBox.Text = "";
            курсComboBox.SelectedIndex = 0;
            уровеньПодготовкиComboBox.SelectedValue = 1;
            группаTextBox.Text = "";
            количествоБюджетниковTextBox.Text = "";
            количествоКонтрактниковTextBox.Text = "";

            направлениеComboBox.Enabled = true;
            количествоСтудентовTextBox.Enabled = true;
            языкComboBox.Enabled = true;
            годПоступленияTextBox.Enabled = true;
            курсComboBox.Enabled = true;
            уровеньПодготовкиComboBox.Enabled = true;
            группаTextBox.Enabled = true;
            сохранитьГруппуButton.Enabled = true;
            количествоБюджетниковTextBox.Enabled = true;
            количествоКонтрактниковTextBox.Enabled = true;
            отменаButton.Enabled = true;
        }
    }
}
