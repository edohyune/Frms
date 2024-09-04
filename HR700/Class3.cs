using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR700_G30 : EpicV004.Libs.MdlBase
    {
        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _prr_emp;
        public string prr_emp
        {
            get => _prr_emp;
            set => Set(ref _prr_emp, value);
        }

        private string _emp_name;
        public string emp_name
        {
            get => _emp_name;
            set => Set(ref _emp_name, value);
        }

        private string _emp_ename;
        public string emp_ename
        {
            get => _emp_ename;
            set => Set(ref _emp_ename, value);
        }
    }
}
