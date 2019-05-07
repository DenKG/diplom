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
    public partial class Экспорт_в_Excel : Form
    {
        public Экспорт_в_Excel()
        {
            InitializeComponent();
        }

        private void Экспорт_в_Excel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "РаспределениеНагрузкиDataSet.ЭкспортДанныхПреподавателей_ХП". При необходимости она может быть перемещена или удалена.
            this.ЭкспортДанныхПреподавателей_ХПTableAdapter.Fill(this.РаспределениеНагрузкиDataSet.ЭкспортДанныхПреподавателей_ХП);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
