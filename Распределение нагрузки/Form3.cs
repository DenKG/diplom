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
    public partial class общийОтчетForm : Form
    {
        public общийОтчетForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "РаспределениеНагрузкиDataSet.ОтчетОбщаяНагрузка_ХП". При необходимости она может быть перемещена или удалена.
            this.ОтчетОбщаяНагрузка_ХПTableAdapter.Fill(this.РаспределениеНагрузкиDataSet.ОтчетОбщаяНагрузка_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet1.ПреподавательПредметыОтчет_ХП". При необходимости она может быть перемещена или удалена.
            this.преподавательПредметыОтчет_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet1.ПреподавательПредметыОтчет_ХП);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
