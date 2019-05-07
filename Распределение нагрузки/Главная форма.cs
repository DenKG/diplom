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
    public partial class Form1 : Form
    {
        Преподаватели преподаватели = null;
        Группы группы = null;
        Предметы предметы = null;
        Бакалавры бакалавры = null;
        общийОтчетForm form3 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Преподаватели преподаватели = new Преподаватели();
            преподаватели.Show();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Группы группы = new Группы();
            группы.Show();
        }

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Предметы предметы = new Предметы();
            предметы.Show();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            общийОтчетForm form3 = new общийОтчетForm();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (преподаватели == null || преподаватели.IsDisposed)
            {
                преподаватели = new Преподаватели();
                преподаватели.Show();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (группы == null || группы.IsDisposed)
            {
                группы = new Группы();
                группы.Show();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (предметы == null || предметы.IsDisposed)
            {
                предметы = new Предметы();
                предметы.Show();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new общийОтчетForm();
                form3.Show();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void бакалаврыButton_Click(object sender, EventArgs e)
        {
            if (бакалавры == null || бакалавры.IsDisposed)
            {
                бакалавры = new Бакалавры();
                бакалавры.Show();
            }
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
