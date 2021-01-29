using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BusinessLayer
{
    public static class CustomExtensions
    {
        public static void SetDataSource<T>(this ComboBox cmb, List<T> dataSource, string displayMember, string valueMember)
        {
            cmb.DataSource = dataSource;
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
        }
    }
}
