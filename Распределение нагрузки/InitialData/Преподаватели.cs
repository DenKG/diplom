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
    public partial class Преподаватели : Form
    {
        SqlConnection sqlConnection;
        int teacherID, posID, doljnost, subjectAndTypeID;
        bool addTeacher = false, editTeacher = false, saveTeacher = false, laboratorySelected = false;

        public static Преподаватели SelfRef { get; set; }

        public Преподаватели()
        {
            SelfRef = this;
            InitializeComponent();
        }

        private void Преподаватели_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Направления". При необходимости она может быть перемещена или удалена.
            this.направленияTableAdapter.Fill(this.распределениеНагрузкиDataSet.Направления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Важность_предмета". При необходимости она может быть перемещена или удалена.
            this.важность_предметаTableAdapter.Fill(this.распределениеНагрузкиDataSet.Важность_предмета);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.распределениеНагрузкиDataSet.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Уровни_подготовки". При необходимости она может быть перемещена или удалена.
            this.уровни_подготовкиTableAdapter.Fill(this.распределениеНагрузкиDataSet.Уровни_подготовки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet5.ПредметыКафедры_ХП". При необходимости она может быть перемещена или удалена.
            //this.предметыКафедры_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet5.ПредметыКафедры_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.ПредметыКафедры_ХП". При необходимости она может быть перемещена или удалена.
            //this.предметыКафедры_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ПредметыКафедры_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Учебные_планы". При необходимости она может быть перемещена или удалена.
            this.учебные_планыTableAdapter.Fill(this.распределениеНагрузкиDataSet.Учебные_планы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet4.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.распределениеНагрузкиDataSet4.Преподаватели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet3.ВсеПреподаватели_ХП". При необходимости она может быть перемещена или удалена.
            this.всеПреподаватели_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet3.ВсеПреподаватели_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet2.ВсеПреподаватели_ХП". При необходимости она может быть перемещена или удалена.
            this.всеПреподаватели_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet2.ВсеПреподаватели_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet1.Виды_занятий". При необходимости она может быть перемещена или удалена.
            this.виды_занятийTableAdapter.Fill(this.распределениеНагрузкиDataSet1.Виды_занятий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet1.Предметы". При необходимости она может быть перемещена или удалена.
            //this.предметыTableAdapter.Fill(this.распределениеНагрузкиDataSet1.Предметы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet1.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.распределениеНагрузкиDataSet1.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.распределениеНагрузкиDataSet.Преподаватели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Все_преподаватели_показать_ХП". При необходимости она может быть перемещена или удалена.
            this.все_преподаватели_показать_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.Все_преподаватели_показать_ХП);

            уровеньПодготовкиComboBox_SelectedIndexChanged(sender, e);
            // Вызвать событие, чтобы при открытии формы вывести в поля информацию
            comboBox1_SelectedIndexChanged(sender, e);
            направлениеComboBox_SelectedIndexChanged(sender, e);
            teacherRateHoursCheck();
        }

        public void formRefresh()
        {
            this.преподавателиTableAdapter.Fill(this.распределениеНагрузкиDataSet.Преподаватели);
            this.всеПреподаватели_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet3.ВсеПреподаватели_ХП);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Указываем, что нажата кнопка "Редактировать"
            editTeacher = true;

            ФИОTextBox.Enabled = true;
            ставкаTextBox.Enabled = true;
            должностьComboBox.Enabled = true;
            началоТДdateTimePicker1.Enabled = true;
            ставкаБюджетTextBox.Enabled = true;
            ставкаКонтрактTextBox.Enabled = true;
            совместительRB.Enabled = true;
            совмещениеRB.Enabled = true;
            сохранитьПреподавателяButton.Enabled = true;
            button1.Enabled = true;
        }

        private int getCourse()
        {
            if (семестрComboBox.SelectedIndex == 0 || семестрComboBox.SelectedIndex == 1)
            {
                return 1;
            }

            else if (семестрComboBox.SelectedIndex == 2 || семестрComboBox.SelectedIndex == 3)
            {
                return 2;
            }

            else if (семестрComboBox.SelectedIndex == 4 || семестрComboBox.SelectedIndex == 5)
            {
                return 3;
            }

            else if (семестрComboBox.SelectedIndex == 6 || семестрComboBox.SelectedIndex == 7)
            {
                return 4;
            }

            else if (семестрComboBox.SelectedIndex == 8 || семестрComboBox.SelectedIndex == 9)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

        private void добавитьПредметПреподавателюButton_Click(object sender, EventArgs e)
        {
            int english = 1, result = 1;

            int course = getCourse();

            if (группыПотокиComboBox.SelectedIndex > -1)
            {
                if (предметыComboBox.SelectedIndex > -1)
                {
                    if (часыTextBox.Text != "0" && эквивалентЧасовTextBox.Text != "0")
                    {
                        if (языкCheckBox.Checked == true)
                        {
                            english = 2;
                        }

                        using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                        {
                            try
                            {
                                result = 0;

                                SqlCommand addTeacherSubject = new SqlCommand("ДобавитьДисциплинуПреподавателю_ХП", MyConnection);
                                addTeacherSubject.CommandType = CommandType.StoredProcedure;

                                addTeacherSubject.Parameters.AddWithValue("@ID", teacherID);
                                addTeacherSubject.Parameters.AddWithValue("@subject", Convert.ToInt32(предметыComboBox.SelectedValue));
                                addTeacherSubject.Parameters.AddWithValue("@subjectType", Convert.ToInt32(видЗанятияComboBox.SelectedValue));
                                addTeacherSubject.Parameters.AddWithValue("@preparation", Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue));
                                addTeacherSubject.Parameters.AddWithValue("@course", course);
                                addTeacherSubject.Parameters.AddWithValue("@english", english);
                                addTeacherSubject.Parameters.AddWithValue("@hoursInUnit", Convert.ToInt32(часыTextBox.Text));
                                addTeacherSubject.Parameters.AddWithValue("@hoursInHours", Convert.ToInt32(эквивалентЧасовTextBox.Text));
                                addTeacherSubject.Parameters.AddWithValue("@nesessary", Convert.ToInt32(важностьComboBox.SelectedValue));
                                addTeacherSubject.Parameters.AddWithValue("@semester", семестрComboBox.SelectedIndex + 1);
                                addTeacherSubject.Parameters.AddWithValue("@direction", Convert.ToInt32(направлениеComboBox.SelectedValue));
                                if (laboratorySelected == true)
                                {
                                    addTeacherSubject.Parameters.AddWithValue("@flow", Convert.ToInt32(группыПотокиComboBox.SelectedValue));
                                    addTeacherSubject.Parameters.AddWithValue("@group", 0);
                                }
                                else
                                {
                                    addTeacherSubject.Parameters.AddWithValue("@flow", 0);
                                    addTeacherSubject.Parameters.AddWithValue("@group", Convert.ToInt32(группыПотокиComboBox.SelectedValue));
                                }

                                var returnValue = addTeacherSubject.Parameters.Add("@Return", SqlDbType.Int);

                                MyConnection.Open();

                                returnValue.Direction = ParameterDirection.ReturnValue;
                                addTeacherSubject.ExecuteNonQuery();
                                var sotredProcResult = (int)returnValue.Value;
                                result = sotredProcResult;

                                if (result == 1)
                                {
                                    MessageBox.Show("Лекция для выбранного курса по предмету в семестре уже назначена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                                if (result == 2)
                                {
                                    MessageBox.Show("Выбранная дисциплина в группе уже назначена одному из преподавателей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                addTeacherSubject.ExecuteReader();

                                RefreshTable(teacherID);
                                MyConnection.Close();

                                teacherRateHoursCheck();

                                if (result != 2)
                                {
                                    if (Convert.ToInt32(видЗанятияComboBox.SelectedValue) == 2)
                                    {
                                        result = 0;

                                        SqlCommand checkLabs = new SqlCommand("ПроверитьЛабораторные_ХП", MyConnection);
                                        checkLabs.CommandType = CommandType.StoredProcedure;

                                        checkLabs.Parameters.AddWithValue("@teacherID", teacherID);
                                        checkLabs.Parameters.AddWithValue("@subject", Convert.ToInt32(предметыComboBox.SelectedValue));
                                        if (laboratorySelected == true)
                                        {
                                            checkLabs.Parameters.AddWithValue("@flow", Convert.ToInt32(группыПотокиComboBox.SelectedValue));
                                            checkLabs.Parameters.AddWithValue("@group", 0);
                                        }
                                        else
                                        {
                                            checkLabs.Parameters.AddWithValue("@flow", 0);
                                            checkLabs.Parameters.AddWithValue("@group", Convert.ToInt32(группыПотокиComboBox.SelectedValue));
                                        }
                                        checkLabs.Parameters.AddWithValue("@semester", семестрComboBox.SelectedIndex + 1);

                                        returnValue = checkLabs.Parameters.Add("@Return", SqlDbType.Int);

                                        MyConnection.Open();

                                        returnValue.Direction = ParameterDirection.ReturnValue;
                                        checkLabs.ExecuteNonQuery();
                                        sotredProcResult = (int)returnValue.Value;
                                        result = sotredProcResult;

                                        MyConnection.Close();

                                        if (result == 1)
                                        {
                                            DialogResult dialogResult;
                                            dialogResult = MessageBox.Show("В группе/потоке больше 18 человек. Назначьте второго преподавателя для проведения лабораторных в группе/потоке");
                                            if (dialogResult == DialogResult.OK)
                                            {
                                                int flow, group;

                                                if (laboratorySelected == true)
                                                {
                                                    flow = Convert.ToInt32(группыПотокиComboBox.SelectedValue);
                                                    group = 0;
                                                }
                                                else
                                                {
                                                    flow = 0;
                                                    group = Convert.ToInt32(группыПотокиComboBox.SelectedValue);
                                                }

                                                Преподаватели_для_лабораторных преподаватели_Для_Лабораторных = new Преподаватели_для_лабораторных(
                                                    teacherID,
                                                    Convert.ToInt32(предметыComboBox.SelectedValue),
                                                    Convert.ToInt32(видЗанятияComboBox.SelectedValue),
                                                    Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue),
                                                    course,
                                                    english,
                                                    Convert.ToInt32(часыTextBox.Text),
                                                    Convert.ToInt32(эквивалентЧасовTextBox.Text),
                                                    Convert.ToInt32(важностьComboBox.SelectedValue),
                                                    семестрComboBox.SelectedIndex + 1,
                                                    Convert.ToInt32(направлениеComboBox.SelectedValue),
                                                    flow,
                                                    group,
                                                    laboratorySelected, this);
                                                преподаватели_Для_Лабораторных.ShowDialog();
                                            }
                                        }
                                    }
                                }
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                                //MessageBox.Show("Такая запись уже имеется в базе данных. Проверьте таблицу");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Для выбранного предмета выбранного вида занятия не выделено часов в учебном плане", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите предмет");
                }
            }
            else
            {
                MessageBox.Show("Выберите группу/поток");
            }
        }

        public void teacherRateHoursCheck()
        {
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    int result = 0;
                    SqlCommand checkLections = new SqlCommand("ПреподавательСтавкаЧасы_ХП", MyConnection);
                    checkLections.CommandType = CommandType.StoredProcedure;

                    //checkLections.Parameters.AddWithValue("@course", getCourse());

                    var returnValue = checkLections.Parameters.Add("@Return", SqlDbType.Int);

                    MyConnection.Open();

                    returnValue.Direction = ParameterDirection.ReturnValue;
                    checkLections.ExecuteNonQuery();
                    var sotredProcResult = (int)returnValue.Value;
                    result = sotredProcResult;

                    MyConnection.Close();

                    if (result == 1)
                    {
                        предупреждениеPicture.Visible = true;
                        предупреждениеLb1.Visible = true;
                        предупреждениеLLb.Visible = true;
                        предупреждениеLb2.Visible = true;
                    }
                    else if (result == 2)
                    {
                        предупреждениеPicture.Visible = false;
                        предупреждениеLb1.Visible = false;
                        предупреждениеLLb.Visible = false;
                        предупреждениеLb2.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void удалитьПредметПреподавателяButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Вы уверены, что хотите удалить выбранное сочетание?", "Удалить сочетание?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                {
                    try
                    {
                        SqlCommand deleteCombination = new SqlCommand("УдалитьСочетание_ХП", MyConnection);
                        deleteCombination.CommandType = CommandType.StoredProcedure;

                        deleteCombination.Parameters.AddWithValue("@ID", subjectAndTypeID);

                        MyConnection.Open();
                        deleteCombination.ExecuteReader();

                        RefreshTable(teacherID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int rowNum;
            int selectedValue;

            rowNum = dataGridView1.CurrentCell.RowIndex;
            selectedValue = Convert.ToInt32(dataGridView1.Rows[rowNum].Cells[0].Value);
            subjectAndTypeID = selectedValue;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);

            ФИОTextBox.Enabled = false;
            ставкаTextBox.Enabled = false;
            должностьComboBox.Enabled = false;
            началоТДdateTimePicker1.Enabled = false;
            ставкаБюджетTextBox.Enabled = false;
            ставкаКонтрактTextBox.Enabled = false;
            совместительRB.Enabled = false;
            совмещениеRB.Enabled = false;

            сохранитьПреподавателяButton.Enabled = false;
            button1.Enabled = false;
        }

        private void часыTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 49 || e.KeyChar > 52) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void уровеньПодготовкиComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            семестрComboBox.Items.Clear();

            if (Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue) == 1)
            {
                семестрComboBox.Items.Add("1");
                семестрComboBox.Items.Add("2");
                семестрComboBox.Items.Add("3");
                семестрComboBox.Items.Add("4");
                семестрComboBox.Items.Add("5");
                семестрComboBox.Items.Add("6");
                семестрComboBox.Items.Add("7");
                семестрComboBox.Items.Add("8");

                семестрComboBox.SelectedIndex = 0;
            }

            if (Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue) == 2)
            {
                семестрComboBox.Items.Add("1");
                семестрComboBox.Items.Add("2");
                семестрComboBox.Items.Add("3");
                семестрComboBox.Items.Add("4");

                семестрComboBox.SelectedIndex = 0;
            }

            if (Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue) == 3)
            { 
                семестрComboBox.Items.Add("1");
                семестрComboBox.Items.Add("2");
                семестрComboBox.Items.Add("3");
                семестрComboBox.Items.Add("4");
                семестрComboBox.Items.Add("5");
                семестрComboBox.Items.Add("6");
                семестрComboBox.Items.Add("7");
                семестрComboBox.Items.Add("8");
                семестрComboBox.Items.Add("9");
                семестрComboBox.Items.Add("10");

                семестрComboBox.SelectedIndex = 0;
            }

            RefreshTable(teacherID);
            UpdateSubjectComboBox();
            направлениеComboBox_SelectedIndexChanged(sender, e);
            семестрComboBox_SelectedIndexChanged(sender, e);
        }

        private void курсComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable(teacherID);
            UpdateSubjectComboBox();
            направлениеComboBox_SelectedIndexChanged(sender, e);
        }

        private void языкCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTable(teacherID);
            направлениеComboBox_SelectedIndexChanged(sender, e);
        }
        
        private void UpdateSubjectComboBox()
        {
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    //Вызов хранимой процедуры
                    SqlCommand subjectsProcedure = new SqlCommand("ПредметыКафедры_ХП", MyConnection);
                    subjectsProcedure.CommandType = CommandType.StoredProcedure;
                    subjectsProcedure.Parameters.AddWithValue("@preparation", уровеньПодготовкиComboBox.SelectedIndex + 1);
                    subjectsProcedure.Parameters.AddWithValue("@semester", семестрComboBox.SelectedIndex + 1);
                    subjectsProcedure.Parameters.AddWithValue("@nesessary", Convert.ToInt32(важностьComboBox.SelectedValue));
                    subjectsProcedure.Parameters.AddWithValue("@direction", Convert.ToInt32(направлениеComboBox.SelectedValue));

                    MyConnection.Open();
                    subjectsProcedure.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    dt.Load(subjectsProcedure.ExecuteReader());

                    предметыComboBox.DataSource = dt;
                    предметыComboBox.ValueMember = "ID";
                    предметыComboBox.DisplayMember = "Название";

                    //предметыComboBox.DropDownWidth = DropDownWidth(предметыComboBox);


                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        //int DropDownWidth(ComboBox myCombo)
        //{
        //    int maxWidth = 0, temp = 0;
        //    foreach (var obj in myCombo.Items)
        //    {
        //        temp = TextRenderer.MeasureText(obj.ToString(), myCombo.Font).Width;
        //        if (temp > maxWidth)
        //        {
        //            maxWidth = temp;
        //        }
        //    }
        //    return maxWidth;
        //}

        private void предметыComboBox_DropDown(object sender, EventArgs e)
        {
            var senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;

            int vertScrollBarWidth = (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                    ? SystemInformation.VerticalScrollBarWidth : 0;

            var itemsList = senderComboBox.Items.Cast<object>().Select(item => item.ToString());

            foreach (string s in itemsList)
            {
                int newWidth = (int)g.MeasureString(s, font).Width + vertScrollBarWidth;

                if (width < newWidth)
                {
                    width = newWidth;
                }
            }

            senderComboBox.DropDownWidth = width;
        }

        public void RefreshTable(int teacherID)
        {
            int english = 0;
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    //Вызов хранимой процедуры
                    SqlCommand teachersProcedure = new SqlCommand("ПреподавательПредметыКритерии_ХП", MyConnection);
                    teachersProcedure.CommandType = CommandType.StoredProcedure;
                    teachersProcedure.Parameters.AddWithValue("@teacherID", Convert.ToInt32(преподавательComboBox.SelectedValue));
                    if (preparationCheckBox.Checked == true)
                    {
                        teachersProcedure.Parameters.AddWithValue("@preparation", Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue));
                    }
                    else
                    {
                        teachersProcedure.Parameters.AddWithValue("@preparation", 0);
                    }
                    if (направлениеCheckBox.Checked == true)
                    {
                        teachersProcedure.Parameters.AddWithValue("@direction", Convert.ToInt32(направлениеComboBox.SelectedValue));
                    }
                    else
                    {
                        teachersProcedure.Parameters.AddWithValue("@direction", 0);
                    }
                    if (languageCheckBox.Checked == true)
                    {
                        if (языкCheckBox.Checked == true)
                        {
                            english = 2;
                        }
                        else
                        {
                            english = 1;
                        }
                    }
                    if (nesessaryCheckBox.Checked == true)
                    {
                        teachersProcedure.Parameters.AddWithValue("@nesessary", Convert.ToInt32(важностьComboBox.SelectedValue));
                    }
                    else
                    {
                        teachersProcedure.Parameters.AddWithValue("@nesessary", 0);
                    }
                    if (semesterCheckBox.Checked == true)
                    {
                        teachersProcedure.Parameters.AddWithValue("@semester", семестрComboBox.SelectedIndex + 1);
                    }
                    else
                    {
                        teachersProcedure.Parameters.AddWithValue("@semester", 0);
                    }
                    if (subjectCheckBox.Checked == true)
                    {
                        teachersProcedure.Parameters.AddWithValue("@subject", Convert.ToInt32(предметыComboBox.SelectedValue));
                    }
                    else
                    {
                        teachersProcedure.Parameters.AddWithValue("@subject", 0);
                    }
                    if (typeCheckBox.Checked == true)
                    {
                        teachersProcedure.Parameters.AddWithValue("@type", Convert.ToInt32(видЗанятияComboBox.SelectedValue));
                    }
                    else
                    {
                        teachersProcedure.Parameters.AddWithValue("@type", 0);
                    }
                    teachersProcedure.Parameters.AddWithValue("@english", english);

                    MyConnection.Open();
                    teachersProcedure.ExecuteNonQuery();

                    using (var dataReader = teachersProcedure.ExecuteReader())
                    {
                        //if (dataReader.HasRows)
                        //{
                            DataTable dt = new DataTable();
                            dt.Load(dataReader);
                            dataGridView1.DataSource = dt.DefaultView;
                        if (dataGridView1.RowCount > 0)
                        {
                            dataGridView1.CurrentCell = dataGridView1[1, 0];
                            dataGridView1.Columns[0].Visible = false;
                        }
                        //}
                        //else
                        //{
                        //    dataGridView1.DataSource = dt.DefaultView;
                        //}
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void всеПредметыButton_Click(object sender, EventArgs e)
        {
            preparationCheckBox.Checked = false;
            направлениеCheckBox.Checked = false;
            languageCheckBox.Checked = false;
            nesessaryCheckBox.Checked = false;
            semesterCheckBox.Checked = false;
            subjectCheckBox.Checked = false;
            typeCheckBox.Checked = false;

            RefreshTable(teacherID);
            //using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            //{
            //    try
            //    {
            //        //Вызов хранимой процедуры
            //        SqlCommand teachersProcedure = new SqlCommand("ПреподавательВсеПредметы_ХП", MyConnection);
            //        teachersProcedure.CommandType = CommandType.StoredProcedure;
            //        teachersProcedure.Parameters.AddWithValue("@ID", teacherID);

            //        MyConnection.Open();
            //        teachersProcedure.ExecuteNonQuery();

            //        DataTable dt = new DataTable();
            //        dt.Load(teachersProcedure.ExecuteReader());
            //        dataGridView1.DataSource = dt.DefaultView;
            //        dataGridView1.Columns[0].Visible = false;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void preparationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTable(teacherID);
        }

        private void направлениеCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTable(teacherID);
        }

        private void languageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTable(teacherID);
        }

        private void teacherCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTable(teacherID);
        }

        private void nesessaryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTable(teacherID);
        }

        private void semesterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTable(teacherID);
        }

        private void subjectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTable(teacherID);
        }

        private void typeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTable(teacherID);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            DialogResult dialogResult;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int rowNum;
                int selectedValue;
                int teachersID;

                rowNum = dataGridView2.CurrentCell.RowIndex;
                selectedValue = Convert.ToInt32(dataGridView2.Rows[rowNum].Cells[0].Value);
                teachersID = selectedValue;

                if (e.ColumnIndex == 6)
                {                   
                    преподавательComboBox.SelectedValue = teachersID;
                }

                if(e.ColumnIndex == 7)
                {
                    dialogResult = MessageBox.Show("Удалить выбранного преподавателя?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                        {
                            try
                            {
                                SqlCommand teachersProcedure = new SqlCommand("УдалитьПреподавателя_ХП", MyConnection);
                                teachersProcedure.CommandType = CommandType.StoredProcedure;
                                teachersProcedure.Parameters.AddWithValue("@ID", teachersID);

                                MyConnection.Open();
                                teachersProcedure.ExecuteNonQuery();

                                formRefresh();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    selectedValue = Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value);
                    teachersID = selectedValue;
                    преподавательComboBox.SelectedValue = teachersID;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Если нажата кнопка "Редактировать"

            if (checkForm() == true)
            {
                double rate, rateBudget, rateContract;

                rate = Convert.ToDouble(ставкаTextBox.Text);

                if (!string.IsNullOrEmpty(ставкаБюджетTextBox.Text))
                {
                    rateBudget = Convert.ToDouble(ставкаБюджетTextBox.Text);
                }
                else
                {
                    rateBudget = 0;
                }

                if (!string.IsNullOrEmpty(ставкаКонтрактTextBox.Text))
                {
                    rateContract = Convert.ToDouble(ставкаКонтрактTextBox.Text);
                }
                else
                {
                    rateContract = 0;
                }

                bool companion = false, combination = false;
                string name, secondName, thirdName;
                string[] words = ФИОTextBox.Text.Split();
                DateTime laborActivity;
                int position, teacherID;

                if (совместительRB.Checked == true)
                {
                    companion = true;
                }

                if (совмещениеRB.Checked == true)
                {
                    combination = true;
                }

                using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                {
                    try
                    {
                        secondName = words[0];
                        name = words[1];
                        thirdName = words[2];

                        laborActivity = началоТДdateTimePicker1.Value;
                        position = Convert.ToInt32(должностьComboBox.SelectedValue);
                        rate = Convert.ToDouble(ставкаTextBox.Text);
                        teacherID = Convert.ToInt32(преподавательComboBox.SelectedValue);

                        SqlCommand editTeacher = new SqlCommand("РедактироватьПреподавателя_ХП", MyConnection);
                        editTeacher.CommandType = CommandType.StoredProcedure;

                        editTeacher.Parameters.AddWithValue("@name", name);
                        editTeacher.Parameters.AddWithValue("@secondName", secondName);
                        editTeacher.Parameters.AddWithValue("@thirdName", thirdName);
                        editTeacher.Parameters.AddWithValue("@laborActivity", laborActivity);
                        editTeacher.Parameters.AddWithValue("@position", position);
                        editTeacher.Parameters.AddWithValue("@rate", rate);
                        editTeacher.Parameters.AddWithValue("@ID", teacherID);
                        editTeacher.Parameters.AddWithValue("@rateBudget", rateBudget);
                        editTeacher.Parameters.AddWithValue("@rateContract", rateContract);
                        editTeacher.Parameters.AddWithValue("@companion", companion);
                        editTeacher.Parameters.AddWithValue("@combination", combination);

                        MyConnection.Open();
                        editTeacher.ExecuteReader();

                        formRefresh();

                        ФИОTextBox.Enabled = false;
                        ставкаTextBox.Enabled = false;
                        должностьComboBox.Enabled = false;
                        началоТДdateTimePicker1.Enabled = false;
                        ставкаБюджетTextBox.Enabled = false;
                        ставкаКонтрактTextBox.Enabled = false;
                        совместительRB.Enabled = false;
                        совмещениеRB.Enabled = false;

                        сохранитьПреподавателяButton.Enabled = false;
                        button1.Enabled = false;
                        MessageBox.Show("Данные преподавателя изменены");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public bool checkForm()
        {
            bool ready = true;

            double rate, rateBudget, rateContract;

            if (string.IsNullOrEmpty(ФИОTextBox.Text))
            {
                MessageBox.Show("Введите ФИО");
                return false;
            }

            if (string.IsNullOrEmpty(ставкаTextBox.Text))
            {
                MessageBox.Show("Укажите ставку");               
                rate = 0;
                return false;
            }
            else
            {
                rate = Convert.ToDouble(ставкаTextBox.Text);
            }

            if (!string.IsNullOrEmpty(ставкаБюджетTextBox.Text))
            {
                rateBudget = Convert.ToDouble(ставкаБюджетTextBox.Text);
            }
            else
            {
                rateBudget = 0;
            }

            if (!string.IsNullOrEmpty(ставкаКонтрактTextBox.Text))
            {
                rateContract = Convert.ToDouble(ставкаКонтрактTextBox.Text);
            }
            else
            {
                rateContract = 0;
            }

            if (rate > 1.75)
            {
                MessageBox.Show("Общая ставка не может превышать 1,75", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if ((rateBudget + rateContract) != rate)
            {
                MessageBox.Show("Сумма ставок (бюджет + контракт) не совпадает с общей. Проверьте значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return ready;
        }

        private void добавитьПреподавателяButton_Click(object sender, EventArgs e)
        {
            Добавить_преподавателя добавить_Преподавателя = new Добавить_преподавателя(this);
            добавить_Преподавателя.ShowDialog();
        }

        private void направлениеComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            семестрComboBox_SelectedIndexChanged(sender, e);
            видЗанятияComboBox_SelectedIndexChanged(sender, e);
        }

        private void семестрComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable(teacherID);
            UpdateSubjectComboBox();
            видЗанятияComboBox_SelectedIndexChanged(sender, e);
            //if (семестрComboBox.SelectedIndex == 0)
            //{
            //    checkBox1.Enabled = false;
            //    checkBox2.Enabled = false;
            //    checkBox4.Enabled = false;
            //    checkBox5.Enabled = false;
            //    checkBox6.Enabled = false;
            //    checkBox7.Enabled = false;
            //    checkBox8.Enabled = false;
            //    checkBox9.Enabled = false;
            //}
        }

        private void важностьComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubjectComboBox();
        }

        private void предметыComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int subjectID, hours = 0, quantity;

            subjectID = Convert.ToInt32(предметыComboBox.SelectedValue);

            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    SqlCommand hoursProcedure = new SqlCommand("ПолучитьЧасы_ХП", MyConnection);
                    hoursProcedure.CommandType = CommandType.StoredProcedure;
                    hoursProcedure.Parameters.AddWithValue("@subjectID", subjectID);
                    hoursProcedure.Parameters.AddWithValue("@typeID", Convert.ToInt32(видЗанятияComboBox.SelectedValue));

                    MyConnection.Open();
                    hours = Convert.ToInt32(hoursProcedure.ExecuteScalar());
                    MyConnection.Close();

                    часыTextBox.Text = hours.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                if (hours == 0)
                {
                    часыTextBox.Text = "0";
                    часыTextBox.BackColor = Color.Red;

                    эквивалентЧасовTextBox.Text = "0";
                    эквивалентЧасовTextBox.BackColor = Color.Red;
                }
                else
                {
                    try
                    {
                        SqlCommand studQuantity = new SqlCommand("КоличествоЧеловек_ХП", MyConnection);
                        studQuantity.CommandType = CommandType.StoredProcedure;

                        if (laboratorySelected == true)
                        {
                            studQuantity.Parameters.AddWithValue("@flow", Convert.ToInt32(группыПотокиComboBox.SelectedValue));
                        }
                        if (laboratorySelected == false)
                        {
                            studQuantity.Parameters.AddWithValue("@group", Convert.ToInt32(группыПотокиComboBox.SelectedValue));
                        }

                        MyConnection.Open();
                        quantity = Convert.ToInt32(studQuantity.ExecuteScalar());
                        MyConnection.Close();

                        if (quantity > 18 && Convert.ToInt32(видЗанятияComboBox.SelectedValue) == 2)
                        {
                            эквивалентЧасовTextBox.Text = (hours * 2).ToString();
                        }
                        else
                        {
                            эквивалентЧасовTextBox.Text = hours.ToString();
                        }

                        часыTextBox.BackColor = Color.FromArgb(240, 240, 240);
                        эквивалентЧасовTextBox.BackColor = Color.FromArgb(240, 240, 240);
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void видЗанятияComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool laboratory = false;

            int course = 0, language = 1;

            course = getCourse();

            if (Convert.ToInt32(видЗанятияComboBox.SelectedValue) == 2)
            {
                laboratory = true;

                using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                {
                    try
                    {
                        SqlCommand flowsAvailable = new SqlCommand("НаличиеПотоков_ХП", MyConnection);
                        flowsAvailable.CommandType = CommandType.StoredProcedure;
                        flowsAvailable.Parameters.AddWithValue("@direction", Convert.ToInt32(направлениеComboBox.SelectedValue));
                        flowsAvailable.Parameters.AddWithValue("@course", course);

                        MyConnection.Open();
                        flowsAvailable.ExecuteNonQuery();

                        using (var dataReader = flowsAvailable.ExecuteReader())
                        {
                            if (!dataReader.HasRows)
                            {
                                selectGroups(course, language);
                            }
                            else
                            {
                                label14.Text = "Потоки";

                                DataTable dt = new DataTable();
                                dt.Load(dataReader);

                                группыПотокиComboBox.DataSource = dt;
                                группыПотокиComboBox.ValueMember = "ID";
                                группыПотокиComboBox.DisplayMember = "Название";

                                if (laboratorySelected == false)
                                {
                                    MessageBox.Show("Обратите внимание! Для лабораторных группы изменились на потоки. Проверьте значение в выпадающем спике с потоками", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    laboratorySelected = true;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }             
            }

            else
            {
                selectGroups(course, language);
            }
        }

        private void группыПотокиComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            предметыComboBox_SelectedIndexChanged(sender, e);
        }

        private void экспортButton_Click(object sender, EventArgs e)
        {
            Экспорт_в_Excel экспорт_В_Excel = new Экспорт_в_Excel();
            экспорт_В_Excel.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Часы_преподавателей часы_Преподавателей = new Часы_преподавателей();
            часы_Преподавателей.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            КонсультацииАС консультацииАС = new КонсультацииАС(teacherID);
            //консультацииАС.Owner = this;
            консультацииАС.Show();
        }

        private void selectGroups(int course, int language)
        {
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    if (языкCheckBox.Checked == true)
                    {
                        language = 2;
                    }

                    SqlCommand getGroups = new SqlCommand("ВыбратьГруппы_ХП", MyConnection);
                    getGroups.CommandType = CommandType.StoredProcedure;
                    getGroups.Parameters.AddWithValue("@direction", Convert.ToInt32(направлениеComboBox.SelectedValue));
                    getGroups.Parameters.AddWithValue("@preparation", Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue));
                    getGroups.Parameters.AddWithValue("@language", language);
                    getGroups.Parameters.AddWithValue("@course", course);

                    MyConnection.Open();
                    getGroups.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    dt.Load(getGroups.ExecuteReader());

                    группыПотокиComboBox.DataSource = dt;
                    группыПотокиComboBox.ValueMember = "ID";
                    группыПотокиComboBox.DisplayMember = "Группа";

                    if (laboratorySelected == true)
                    {
                        MessageBox.Show("Обратите внимание! Для лекций и практик потоки изменились на группы. Проверьте значение в выпадающем спике с группами", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        laboratorySelected = false;
                    }
                    label14.Text = "Группы";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacherID = Convert.ToInt32(преподавательComboBox.SelectedValue);
            bool companion, combination, english = false;

            RefreshTable(teacherID);
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    SqlCommand getName = new SqlCommand("Select Имя from Преподаватели where ID = '" + teacherID + "'", MyConnection);
                    SqlCommand getSecondName = new SqlCommand("Select Фамилия from Преподаватели where ID = '" + teacherID + "'", MyConnection);
                    SqlCommand getThirdName = new SqlCommand("Select Отчество from Преподаватели where ID = '" + teacherID + "'", MyConnection);
                    SqlCommand getStartDate = new SqlCommand("Select Начало_трудовой_деятельности from Преподаватели where ID = '" + teacherID + "'", MyConnection);
                    SqlCommand getRate = new SqlCommand("Select Ставка from Преподаватели_год where ID_преподавателя = '" + teacherID + "'", MyConnection);
                    SqlCommand getPositionID = new SqlCommand("Select Должность from Преподаватели_год where ID_преподавателя = '" + teacherID + "'", MyConnection);
                    SqlCommand getRateBudget = new SqlCommand("Select Ставка_бюджет from Преподаватели_год where ID_преподавателя = '" + teacherID + "'", MyConnection);
                    SqlCommand getRateContract = new SqlCommand("Select Ставка_контракт from Преподаватели_год where ID_преподавателя = '" + teacherID + "'", MyConnection);
                    SqlCommand getCompanion = new SqlCommand("Select Совместитель from Преподаватели_год where ID_преподавателя = '" + teacherID + "'", MyConnection);
                    SqlCommand getCombination = new SqlCommand("Select Совмещение from Преподаватели_год where ID_преподавателя = '" + teacherID + "'", MyConnection);

                    MyConnection.Open();

                    posID = Convert.ToInt32(getPositionID.ExecuteScalar());

                    ФИОTextBox.Text = getSecondName.ExecuteScalar().ToString() + " " + getName.ExecuteScalar().ToString() + " " + getThirdName.ExecuteScalar().ToString();
                    началоТДdateTimePicker1.Text = getStartDate.ExecuteScalar().ToString();
                    должностьComboBox.SelectedValue = posID;
                    ставкаTextBox.Text = getRate.ExecuteScalar().ToString();
                    ставкаБюджетTextBox.Text = getRateBudget.ExecuteScalar().ToString();
                    ставкаКонтрактTextBox.Text = getRateContract.ExecuteScalar().ToString();
                    companion = Convert.ToBoolean(getCompanion.ExecuteScalar());
                    combination = Convert.ToBoolean(getCombination.ExecuteScalar());

                    if (companion == false && combination == false)
                    {
                        совместительRB.Checked = false;
                        совмещениеRB.Checked = false;
                    }
                    else
                    {
                        if (companion == false)
                        {
                            совместительRB.Checked = false;
                            совмещениеRB.Checked = true;
                        }
                        else
                        {
                            совместительRB.Checked = true;
                            совмещениеRB.Checked = false;
                        }
                    }

                    if (языкCheckBox.Checked == true)
                    {
                        english = true;
                    }

                    ФИОTextBox.Enabled = false;
                    ставкаTextBox.Enabled = false;
                    должностьComboBox.Enabled = false;
                    началоТДdateTimePicker1.Enabled = false;
                    ставкаБюджетTextBox.Enabled = false;
                    ставкаКонтрактTextBox.Enabled = false;
                    совместительRB.Enabled = false;
                    совмещениеRB.Enabled = false;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    //comboBox1_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void ставкаTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void ставкаБюджетTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void ставкаКонтрактTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
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
