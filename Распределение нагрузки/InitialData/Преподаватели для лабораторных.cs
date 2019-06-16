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
    public partial class Преподаватели_для_лабораторных : Form
    {
        Преподаватели _owner;
        public Преподаватели_для_лабораторных(int teacherID, int subject, int subjectType, int preparation, int course, int english, int hoursInUnit, int hoursInHours,
            int nesessary, int semester, int direction, int flow, int group, bool laboratorySelected, Преподаватели owner)
        {
            _owner = owner;
            InitializeComponent();
            this.teacherID = teacherID;
            this.subject = subject;
            this.subjectType = subjectType;
            this.preparation = preparation;
            this.course = course;
            this.english = english;
            this.hoursInUnit = hoursInUnit;
            this.hoursInHours = hoursInHours;
            this.nesessary = nesessary;
            this.semester = semester;
            this.direction = direction;
            this.flow = flow;
            this.group = group;
            this.laboratorySelected = laboratorySelected;
        }
        int teacherID, subject, subjectType, preparation, course, english, hoursInUnit, hoursInHours, nesessary, semester, direction, flow, group;
        bool laboratorySelected;

        private void Преподаватели_для_лабораторных_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.распределениеНагрузкиDataSet.Преподаватели);
        }

        private void ОКButton_Click(object sender, EventArgs e)
        {
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                try
                {
                    int result = 0;
                    SqlCommand addTeacherSubject = new SqlCommand("ДобавитьДисциплинуПреподавателю_ХП", MyConnection);
                    addTeacherSubject.CommandType = CommandType.StoredProcedure;

                    addTeacherSubject.Parameters.AddWithValue("@ID", Convert.ToInt32(преподавателиComboBox.SelectedValue));
                    addTeacherSubject.Parameters.AddWithValue("@subject", subject);
                    addTeacherSubject.Parameters.AddWithValue("@subjectType", subjectType);
                    addTeacherSubject.Parameters.AddWithValue("@preparation", preparation);
                    addTeacherSubject.Parameters.AddWithValue("@course", course);
                    addTeacherSubject.Parameters.AddWithValue("@english", english);
                    addTeacherSubject.Parameters.AddWithValue("@hoursInUnit", hoursInUnit);
                    addTeacherSubject.Parameters.AddWithValue("@hoursInHours", hoursInHours);
                    addTeacherSubject.Parameters.AddWithValue("@nesessary", nesessary);
                    addTeacherSubject.Parameters.AddWithValue("@semester", semester);
                    addTeacherSubject.Parameters.AddWithValue("@direction", direction);
                    if (laboratorySelected == true)
                    {
                        addTeacherSubject.Parameters.AddWithValue("@flow", flow);
                        addTeacherSubject.Parameters.AddWithValue("@group", 0);
                    }
                    else
                    {
                        addTeacherSubject.Parameters.AddWithValue("@flow", 0);
                        addTeacherSubject.Parameters.AddWithValue("@group", group);
                    }
                    addTeacherSubject.Parameters.AddWithValue("@secondTeacherForLab", true);

                    var returnValue = addTeacherSubject.Parameters.Add("@Return", SqlDbType.Int);

                    MyConnection.Open();

                    returnValue.Direction = ParameterDirection.ReturnValue;
                    addTeacherSubject.ExecuteNonQuery();
                    var sotredProcResult = (int)returnValue.Value;
                    result = sotredProcResult;

                    if (result == 3)
                    {
                        MessageBox.Show("Этому преподавателю уже назначена лабораторная", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        _owner.RefreshTable(teacherID);
                        MyConnection.Close();

                        _owner.teacherRateHoursCheck();

                        MessageBox.Show("Дисциплина добавлена");

                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

