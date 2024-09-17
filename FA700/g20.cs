using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class FA700_G20 : Libs.MdlBase
    {

        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _yy;
        public string yy
        {
            get => _yy;
            set => Set(ref _yy, value);
        }

        private string _std_month;
        public string std_month
        {
            get => _std_month;
            set => Set(ref _std_month, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _dept_name;
        public string dept_name
        {
            get => _dept_name;
            set => Set(ref _dept_name, value);
        }

        private string _emp_category;
        public string emp_category
        {
            get => _emp_category;
            set => Set(ref _emp_category, value);
        }
    }
}
