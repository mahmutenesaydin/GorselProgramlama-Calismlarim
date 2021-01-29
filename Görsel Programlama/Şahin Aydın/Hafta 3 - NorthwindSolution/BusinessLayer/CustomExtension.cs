using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public static class CustomExtension
    {
        public static void SetDataSource<T>(this ComboBox cmb,List<T> _dataSource,string _displayMember,string _valueMember)
        {
            cmb.DataSource = _dataSource;
            cmb.DisplayMember = _displayMember;
            cmb.ValueMember = _valueMember;
        }
    }
}
