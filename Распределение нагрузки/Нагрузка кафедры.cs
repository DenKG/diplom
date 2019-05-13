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
    public partial class Нагрузка_кафедры : Form
    {
        public Нагрузка_кафедры()
        {
            InitializeComponent();
        }

        private void Нагрузка_кафедры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "РаспределениеНагрузкиDataSet.БакалаврыНагрузка_ХП". При необходимости она может быть перемещена или удалена.
            this.БакалаврыНагрузка_ХПTableAdapter.Fill(this.РаспределениеНагрузкиDataSet.БакалаврыНагрузка_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "РаспределениеНагрузкиDataSet.ОтчетОбщаяНагрузка_ХП". При необходимости она может быть перемещена или удалена.
            this.ОтчетОбщаяНагрузка_ХПTableAdapter.Fill(this.РаспределениеНагрузкиDataSet.ОтчетОбщаяНагрузка_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "РаспределениеНагрузкиDataSet.ОтчетНагрузкаКафедры_ХП". При необходимости она может быть перемещена или удалена.
            this.ОтчетНагрузкаКафедры_ХПTableAdapter.Fill(this.РаспределениеНагрузкиDataSet.ОтчетНагрузкаКафедры_ХП);

            this.reportViewer1.RefreshReport();
        }
    }
}
