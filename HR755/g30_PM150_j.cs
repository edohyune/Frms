using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR755_G30 : Libs.MdlBase
    {
        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _emp_nm;
        public string emp_nm
        {
            get => _emp_nm;
            set => Set(ref _emp_nm, value);
        }

        private string _category;
        public string category
        {
            get => _category;
            set => Set(ref _category, value);
        }

        private string _pm_name;
        public string pm_name
        {
            get => _pm_name;
            set => Set(ref _pm_name, value);
        }

        private DateTime _issue_date;
        public DateTime issue_date
        {
            get => _issue_date;
            set => Set(ref _issue_date, value);
        }

        private DateTime _rtn_date;
        public DateTime rtn_date
        {
            get => _rtn_date;
            set => Set(ref _rtn_date, value);
        }
    }
}
