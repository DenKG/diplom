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
using System.Data.OleDb;

namespace Распределение_нагрузки
{
    public partial class Предметы : Form
    {
        public Предметы()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "Выберите документ для загрузки данных";

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                сохранитьButton.Enabled = true;
            }

            textBox1.Text = ofd.FileName;

            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            ofd.FileName + ";Extended Properties='Excel 12.0 XML;HDR=YES;IMEX=1';";

            OleDbConnection con = new OleDbConnection(constr);
            con.Open();
            DataSet ds = new DataSet();
            DataTable schemaTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            string sheet1 = (string)schemaTable.Rows[0].ItemArray[2];
            string select = String.Format("SELECT * FROM [{0}]", sheet1);
            OleDbDataAdapter ad = new OleDbDataAdapter(select, con);
            ad.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.Close();
            con.Dispose();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int semester = 1, preparation = 0, direction = 0, educationForm = 0, stopWhile = 0;
            int sheet = 1;
            if (бакалаврыRadioButton.Checked == true || дистантникиRadioButton.Checked == true || магистрыRadioButton.Checked == true)
            {
                if (ПИRB.Checked == true || ИБRB.Checked == true)
                {
                    int nesessary = 1;
                    int stopFlag = 0;
                    if (бакалаврыRadioButton.Checked == true)
                    {
                        preparation = 1;
                        educationForm = 1;
                    }
                    else if (дистантникиRadioButton.Checked == true)
                    {
                        preparation = 3;
                        educationForm = 2;
                    }
                    else if (магистрыRadioButton.Checked == true)
                    {
                        preparation = 2;
                        educationForm = 1;
                    }

                    if (ПИRB.Checked == true)
                    {
                        direction = 1;
                    }
                    else if (ИБRB.Checked == true)
                    {
                        direction = 2;
                    }

                    int i = 0, c = 5;
                    int subjectNameRowNum = 0, //Строка-столбец "Наименование дисциплин"
                        nesessarySubjectRowNum, //Строка-столбец "Обязательные дисциплины"
                        horizontalEndTable = 10; //Конец строки. Начало отсчета с 10

                    //Ищем строку-столбец с именем "Наименование дисциплин"
                    do
                    {
                        subjectNameRowNum++;
                        i++;
                    } while (dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Наименование дисциплин");

                    //Ищем строку-столбец с именем "Обязательные дисциплины"
                    do
                    {
                        if (dataGridView1.Rows[subjectNameRowNum].Cells[1].Value.ToString().TrimEnd() == "Обязательные дисциплины" ||
                            dataGridView1.Rows[subjectNameRowNum].Cells[1].Value.ToString().TrimEnd() == "Обязательные предметы")
                        {                            
                            nesessary = 1;
                            i++;
                            break;
                        }
                        i++;
                        stopFlag++;
                        subjectNameRowNum++;
                    } while (stopFlag != 10);

                    //Ищем конец таблицы по горизонтали
                    do
                    {
                        horizontalEndTable++;
                    } while (dataGridView1.Rows[subjectNameRowNum - 1].Cells[horizontalEndTable].Value.ToString() != "");

                    while (sheet < 3)
                    {
                        //Внести Обязательные предметы
                        do
                        {
                            semester = 0;
                            if (i >= dataGridView1.RowCount)
                            {
                                break;
                            }
                            if (dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() == "Итого по обязательным дисциплинам:")
                            {
                                i++;
                            }

                            if (dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() == "Курсы по выбору студента" || dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() == "Курсы по выбору")
                            {
                                //subjectNameRowNum++;
                                nesessary = 2;
                                i = i + 1;
                            }

                            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                            {
                                //try
                                //{
                                int lection = 0, laboratory = 0, practice = 0;
                                int auditoryLessonsHours = 0, lectionHoursTotal = 0, LaboratoryHoursTotal = 0, practiceHoursTotal = 0, SRSHoursTotal = 0;
                                SqlCommand addSubjects = new SqlCommand("ВнестиУчебныйПлан_ХП", MyConnection);
                                addSubjects.CommandType = CommandType.StoredProcedure;

                                if (dataGridView1.Rows[i].Cells[1].Value.ToString() != "" &&
                                    dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Учебная практика" &&
                                    dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Производственная практика" &&
                                    dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Предквалификационная практика" &&
                                    dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Физическая культура" &&
                                    dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Физкультура")
                                {
                                    addSubjects.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value.ToString());
                                    addSubjects.Parameters.AddWithValue("@departmentName", dataGridView1.Rows[i].Cells[2].Value.ToString());
                                    addSubjects.Parameters.AddWithValue("@credits", Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                                    addSubjects.Parameters.AddWithValue("@hours", Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value));

                                    addSubjects.Parameters.AddWithValue("@direction", direction);
                                    addSubjects.Parameters.AddWithValue("@preparation", preparation);

                                    addSubjects.Parameters.AddWithValue("@educationForm", educationForm);

                                    if (educationForm == 1)
                                    {
                                        c = 5;
                                        if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                        {
                                            auditoryLessonsHours = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                            c++;
                                        }
                                        else
                                        {
                                            c++;
                                        }

                                        if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                        {
                                            lectionHoursTotal = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                            c++;
                                        }
                                        else
                                        {
                                            c++;
                                        }

                                        if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                        {
                                            LaboratoryHoursTotal = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                            c++;
                                        }
                                        else
                                        {
                                            c++;
                                        }

                                        if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                        {
                                            practiceHoursTotal = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                            c++;
                                        }
                                        else
                                        {
                                            c++;
                                        }

                                        if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                        {
                                            SRSHoursTotal = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                            c++;
                                        }
                                        else
                                        {
                                            c++;
                                        }

                                        for (c = 10; c < horizontalEndTable; c++)
                                        {
                                            if (c == 13 || c == 17 || c == 21 || c == 25 || c == 29)
                                            {
                                                continue;
                                            }

                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                lection = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                c++;
                                                semester = semesterEF1(c, sheet);
                                            }
                                            else
                                            {
                                                c++;
                                            }

                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                laboratory = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                c++;
                                                semester = 0;
                                                semester = semesterEF1(c, sheet);
                                            }
                                            else
                                            {
                                                c++;
                                            }

                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                practice = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                semester = 0;
                                                semester = semesterEF1(c, sheet);
                                            }
                                        }
                                    }

                                    else if (educationForm == 2)
                                    {
                                        for (c = 5; c < horizontalEndTable; c++)
                                        {
                                            if (c == 8 || c == 12 || c == 16 || c == 20 || c == 24)
                                            {
                                                continue;
                                            }
                                            if (c == horizontalEndTable)
                                            {
                                                break;
                                            }
                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                lection = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                c++;
                                                semester = semesterEF2(c, sheet);
                                            }
                                            else
                                            {
                                                c++;
                                            }
                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                laboratory = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                c++;
                                                semester = semesterEF2(c, sheet);
                                            }
                                            else
                                            {
                                                c++;
                                            }
                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                practice = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                semester = semesterEF2(c, sheet);
                                            }
                                        }
                                    }

                                    addSubjects.Parameters.AddWithValue("@auditoryLessonsHours", auditoryLessonsHours);
                                    addSubjects.Parameters.AddWithValue("@lectionHoursTotal", lectionHoursTotal);
                                    addSubjects.Parameters.AddWithValue("@laboratoryHoursTotal", LaboratoryHoursTotal);
                                    addSubjects.Parameters.AddWithValue("@praticeHoursTotal", practiceHoursTotal);
                                    addSubjects.Parameters.AddWithValue("@SRSHoursTotal", SRSHoursTotal);

                                    addSubjects.Parameters.AddWithValue("@lections", lection);
                                    addSubjects.Parameters.AddWithValue("@laboratory", laboratory);
                                    addSubjects.Parameters.AddWithValue("@practice", practice);
                                    addSubjects.Parameters.AddWithValue("@semester", semester);
                                    addSubjects.Parameters.AddWithValue("@subjectImportance", nesessary);

                                    i++;
                                    MyConnection.Open();
                                    addSubjects.ExecuteNonQuery();
                                }
                                else
                                {
                                    i++;
                                    if (i >= dataGridView1.RowCount)
                                    {
                                        break;
                                    }
                                }
                                //}
                                //catch (Exception ex)
                                //{
                                //    MessageBox.Show(ex.Message);
                                //}
                            }
                        }
                        while (dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Итого по курсам по выбору:");
                        /***********************************************************************************/

                        do
                        {
                            i++;
                            if (i >= dataGridView1.RowCount)
                            {
                                break;
                            }
                        } while (dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Факультативы");
                        i++;

                        do
                        {
                            semester = 0;
                            if (i >= dataGridView1.RowCount)
                            {
                                break;
                            }
                            nesessary = 3;
                            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                            {
                                //try
                                //{
                                int lection = 0, laboratory = 0, practice = 0;
                                int auditoryLessonsHours = 0, lectionHoursTotal = 0, LaboratoryHoursTotal = 0, practiceHoursTotal = 0, SRSHoursTotal = 0;
                                SqlCommand addSubjects = new SqlCommand("ВнестиУчебныйПлан_ХП", MyConnection);
                                addSubjects.CommandType = CommandType.StoredProcedure;

                                if (dataGridView1.Rows[i].Cells[1].Value.ToString() != "" &&
                                    dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Учебная практика" &&
                                    dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Производственная практика" &&
                                    dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Предквалификационная практика" &&
                                    dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Физическая культура" &&
                                    dataGridView1.Rows[i].Cells[1].Value.ToString().TrimEnd() != "Физкультура")
                                {
                                    //i++;
                                    addSubjects.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value.ToString());
                                    addSubjects.Parameters.AddWithValue("@departmentName", dataGridView1.Rows[i].Cells[2].Value.ToString());
                                    if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "")
                                    {
                                        addSubjects.Parameters.AddWithValue("@credits", Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                                    }
                                    else
                                    {
                                        addSubjects.Parameters.AddWithValue("@credits", 0);
                                    }
                                    if (dataGridView1.Rows[i].Cells[4].Value.ToString() != "")
                                    {
                                        addSubjects.Parameters.AddWithValue("@hours", Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value));
                                    }
                                    else
                                    {
                                        addSubjects.Parameters.AddWithValue("@hours", 0);
                                    }

                                    addSubjects.Parameters.AddWithValue("@direction", direction);
                                    addSubjects.Parameters.AddWithValue("@preparation", preparation);

                                    addSubjects.Parameters.AddWithValue("@educationForm", educationForm);

                                    if (educationForm == 1)
                                    {
                                        c = 5;
                                        if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                        {
                                            auditoryLessonsHours = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                            c++;
                                        }
                                        else
                                        {
                                            c++;
                                        }

                                        if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                        {
                                            lectionHoursTotal = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                            c++;
                                        }
                                        else
                                        {
                                            c++;
                                        }

                                        if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                        {
                                            LaboratoryHoursTotal = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                            c++;
                                        }
                                        else
                                        {
                                            c++;
                                        }

                                        if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                        {
                                            practiceHoursTotal = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                            c++;
                                        }
                                        else
                                        {
                                            c++;
                                        }

                                        if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                        {
                                            SRSHoursTotal = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                            c++;
                                        }
                                        else
                                        {
                                            c++;
                                        }

                                        for (c = 10; c < horizontalEndTable; c++)
                                        {
                                            if (c == 13 || c == 17 || c == 21 || c == 25 || c == 29 || c == 24)
                                            {
                                                continue;
                                            }

                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                lection = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                c++;
                                                semester = semesterEF1(c, sheet);
                                            }
                                            else
                                            {
                                                c++;
                                            }

                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                laboratory = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                c++;
                                                semester = semesterEF1(c, sheet);
                                            }
                                            else
                                            {
                                                c++;
                                            }

                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                practice = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                semester = semesterEF1(c, sheet);
                                            }
                                        }
                                    }

                                    else if (educationForm == 2)
                                    {
                                        for (c = 5; c < horizontalEndTable; c++)
                                        {
                                            if (c == 8 || c == 12 || c == 16 || c == 20 || c == 24)
                                            {
                                                continue;
                                            }
                                            if (c == horizontalEndTable)
                                            {
                                                break;
                                            }
                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                lection = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                c++;
                                                semester = semesterEF2(c, sheet);
                                            }
                                            else
                                            {
                                                c++;
                                            }
                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                laboratory = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                c++;
                                                semester = semesterEF2(c, sheet);
                                            }
                                            else
                                            {
                                                c++;
                                            }
                                            if (dataGridView1.Rows[i].Cells[c].Value.ToString() != "")
                                            {
                                                practice = Convert.ToInt32(numeralOnly(dataGridView1.Rows[i].Cells[c].Value.ToString()));
                                                semester = semesterEF2(c, sheet);
                                            }
                                        }
                                    }

                                    addSubjects.Parameters.AddWithValue("@auditoryLessonsHours", auditoryLessonsHours);
                                    addSubjects.Parameters.AddWithValue("@lectionHoursTotal", lectionHoursTotal);
                                    addSubjects.Parameters.AddWithValue("@laboratoryHoursTotal", LaboratoryHoursTotal);
                                    addSubjects.Parameters.AddWithValue("@praticeHoursTotal", practiceHoursTotal);
                                    addSubjects.Parameters.AddWithValue("@SRSHoursTotal", SRSHoursTotal);

                                    addSubjects.Parameters.AddWithValue("@lections", lection);
                                    addSubjects.Parameters.AddWithValue("@laboratory", laboratory);
                                    addSubjects.Parameters.AddWithValue("@practice", practice);
                                    addSubjects.Parameters.AddWithValue("@semester", semester);
                                    addSubjects.Parameters.AddWithValue("@subjectImportance", nesessary);

                                    i++;
                                    MyConnection.Open();
                                    addSubjects.ExecuteNonQuery();
                                }
                                else
                                {
                                    i++;
                                    if (i >= dataGridView1.RowCount)
                                    {
                                        break;
                                    }
                                }

                                if (i >= dataGridView1.RowCount)
                                {
                                    break;
                                }
                                //}
                                //catch (Exception ex)
                                //{
                                //    MessageBox.Show(ex.Message);
                                //}
                            }
                            if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Кредитов по учебным модулям" || dataGridView1.Rows[i - 1].Cells[1].Value.ToString() == "Программная инженерия олимпиад")
                            {
                                break;
                            }
                        }
                        while (dataGridView1.Rows[i].Cells[1].Value.ToString() != "" || dataGridView1.Rows[i - 1].Cells[1].Value.ToString() != "Программная инженерия олимпиад");
                        sheet++;
                    }
                    using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
                    {
                        SqlCommand addAcadCur = new SqlCommand("ДополнитьУчебныйПлан_ХП", MyConnection);
                        addAcadCur.CommandType = CommandType.StoredProcedure;

                        MyConnection.Open();
                        
                        addAcadCur.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Выберите направление");
                }
            }
            else
            {
                MessageBox.Show("Укажите, для каких групп вводится учебный план");
            }
            сохранитьButton.Enabled = false;
            showPlan(preparation, direction);
            MessageBox.Show("Предметы успешно добавлены в базу данных");
        }

        private string numeralOnly (string target)
        {
            string result = new string(target.Where(t => char.IsDigit(t)).ToArray());
            return result;
        }

        private int semesterEF1(int c, int s)
        {
            if (c < 13)
            {
                if (s == 2)
                {
                    return 1 + 4;
                }
                return 1;
            }
            else if (c > 13 && c < 17)
            {
                if (s == 2)
                {
                    return 2 + 4;
                }
                return 2;
            }
            else if (c > 17 && c < 21)
            {
                if (s == 2)
                {
                    return 3 + 4;
                }
                return 3;
            }
            else if (c > 21 && c < 25)
            {
                if (s == 2)
                {
                    return 4 + 4;
                }
                return 4;
            }
            else if (c > 25 && c < 29)
            {
                if (s == 2)
                {
                    return 5 + 4;
                }
                return 5;
            }
            else
            {
                return 0;
            }
        }

        private int semesterEF2(int c, int s)
        {
            if (c < 8)
            {
                if (s == 2)
                {
                    return 1 + 4;
                }
                return 1;
            }
            else if (c > 8 && c < 12)
            {
                if (s == 2)
                {
                    return 2 + 4;
                }
                return 2;
            }
            else if (c > 12 && c < 16)
            {
                if (s == 2)
                {
                    return 3 + 4;
                }
                return 3;
            }
            else if (c > 16 && c < 20)
            {
                if (s == 2)
                {
                    return 4 + 4;
                }
                return 4;
            }
            else if (c > 20 && c < 24)
            {
                if (s == 2)
                {
                    return 5 + 4;
                }
                return 5;
            }
            else
            {
                return 0;
            }
        }

        private void Предметы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet1.Направления". При необходимости она может быть перемещена или удалена.
            this.направленияTableAdapter.Fill(this.распределениеНагрузкиDataSet1.Направления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Важность_предмета". При необходимости она может быть перемещена или удалена.
            this.важность_предметаTableAdapter.Fill(this.распределениеНагрузкиDataSet.Важность_предмета);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.Уровни_подготовки". При необходимости она может быть перемещена или удалена.
            this.уровни_подготовкиTableAdapter.Fill(this.распределениеНагрузкиDataSet.Уровни_подготовки);
            comboBox1_SelectedIndexChanged(sender, e);
            comboBox2_SelectedIndexChanged(sender, e);
            направлениеComboBox_SelectedIndexChanged(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            курсComboBox.Items.Clear();
            if (Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue) == 1)
            {
                курсComboBox.Items.Add("1");
                курсComboBox.Items.Add("2");
                курсComboBox.Items.Add("3");
                курсComboBox.Items.Add("4");
                курсComboBox.SelectedIndex = 0;
            }

            if (Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue) == 3)
            {
                курсComboBox.Items.Add("1");
                курсComboBox.Items.Add("2");
                курсComboBox.Items.Add("3");
                курсComboBox.Items.Add("4");
                курсComboBox.Items.Add("5");
                курсComboBox.SelectedIndex = 0;
            }

            if (Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue) == 2)
            {
                курсComboBox.Items.Add("1");
                курсComboBox.Items.Add("2");
                курсComboBox.SelectedIndex = 0;
            }

            showPlan(0, 0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPlan(0, 0);
        }

        private void направлениеComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPlan(0, 0);
        }

        private void showPlan(int a, int b)
        {
            using (var MyConnection = new SqlConnection(Connection.LoadConnectionString))
            {
                int preparation, direction, nesessary, course;

                if (a != 0 && b != 0)
                {
                    preparation = a;
                    direction = b;
                    nesessary = 1;
                    уровеньПодготовкиComboBox.SelectedIndex = preparation - 1;
                    направлениеComboBox.SelectedIndex = direction - 1;
                    важностьComboBox.SelectedIndex = nesessary - 1;
                    course = курсComboBox.SelectedIndex + 1;
                }
                else
                {
                    preparation = Convert.ToInt32(уровеньПодготовкиComboBox.SelectedValue);
                    direction = Convert.ToInt32(направлениеComboBox.SelectedValue);
                    nesessary = Convert.ToInt32(важностьComboBox.SelectedValue);
                    course = курсComboBox.SelectedIndex + 1;
                }

                try
                {
                    //Вызов хранимой процедуры
                    SqlCommand studyPlanProcedure = new SqlCommand("ВыбратьУчебныйПлан_ХП", MyConnection);
                    studyPlanProcedure.CommandType = CommandType.StoredProcedure;
                    studyPlanProcedure.Parameters.AddWithValue("@preparation", preparation);
                    studyPlanProcedure.Parameters.AddWithValue("@direction", direction);
                    studyPlanProcedure.Parameters.AddWithValue("@nesessary", nesessary);
                    studyPlanProcedure.Parameters.AddWithValue("@course", course);

                    MyConnection.Open();
                    studyPlanProcedure.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    dt.Load(studyPlanProcedure.ExecuteReader());
                    dataGridView1.DataSource = dt.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Помощь_по_учебному_плану помощь_По_Учебному_Плану = new Помощь_по_учебному_плану();
            помощь_По_Учебному_Плану.Show();
        }

        private void курсComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPlan(0, 0);
        }
    }
}
