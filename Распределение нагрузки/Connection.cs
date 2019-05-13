using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Распределение_нагрузки
{
    class Connection
    {
        Properties.Settings settings = Properties.Settings.Default;
        public static string LoadConnectionString = @"Data Source=DESKTOP-9C92TFD\SQLEXPRESS;Initial Catalog=РаспределениеНагрузки;Integrated Security=True";
    }
}
