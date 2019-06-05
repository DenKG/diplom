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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "РаспределениеНагрузкиDataSet.ОтчетНагрузкаКафедрыForMatrix_ХП". При необходимости она может быть перемещена или удалена.
            this.ОтчетНагрузкаКафедрыForMatrix_ХПTableAdapter.Fill(this.РаспределениеНагрузкиDataSet.ОтчетНагрузкаКафедрыForMatrix_ХП);

            this.reportViewer1.RefreshReport();
        }
    }
}
