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
    public partial class Бакалавры : Form
    {
        public Бакалавры()
        {
            InitializeComponent();
        }

        private void Бакалавры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "РаспределениеНагрузкиDataSet.БакалаврыНагрузка_ХП". При необходимости она может быть перемещена или удалена.
            this.БакалаврыНагрузка_ХПTableAdapter.Fill(this.РаспределениеНагрузкиDataSet.БакалаврыНагрузка_ХП);

            this.reportViewer1.RefreshReport();
        }
    }
}
