using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Распределение_нагрузки
{
    public partial class Отчет_по_преподавателям : Form
    {
        int teacherID_;
        public Отчет_по_преподавателям(int _teacherID)
        {
            teacherID_ = _teacherID;
            InitializeComponent();
        }

        private void Отчет_по_преподавателям_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "РаспределениеНагрузкиDataSet.ОтчетПоПреподавателю_ХП". При необходимости она может быть перемещена или удалена.
            this.ОтчетПоПреподавателю_ХПTableAdapter.Fill(this.РаспределениеНагрузкиDataSet.ОтчетПоПреподавателю_ХП, teacherID_);
            this.reportViewer1.RefreshReport();
        }
    }
}
