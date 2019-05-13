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
    public partial class Часы_преподавателей : Form
    {
        public Часы_преподавателей()
        {
            InitializeComponent();
        }

        private void Часы_преподавателей_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet1.ПреподавателиНеВсеЧасы_ХП". При необходимости она может быть перемещена или удалена.
            this.преподавателиНеВсеЧасы_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet1.ПреподавателиНеВсеЧасы_ХП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "распределениеНагрузкиDataSet.ПреподавателиНеВсеЧасы_ХП". При необходимости она может быть перемещена или удалена.
            //this.преподавателиНеВсеЧасы_ХПTableAdapter.Fill(this.распределениеНагрузкиDataSet.ПреподавателиНеВсеЧасы_ХП);

        }
    }
}
