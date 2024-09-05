using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR690_G40 : EpicV004.Libs.MdlBase
    {
        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _emp_name;
        public string emp_name
        {
            get => _emp_name;
            set => Set(ref _emp_name, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _tdata3;
        public string tdata3
        {
            get => _tdata3;
            set => Set(ref _tdata3, value);
        }

        private DateTime _start_working_date;
        public DateTime start_working_date
        {
            get => _start_working_date;
            set => Set(ref _start_working_date, value);
        }

        private DateTime _start_date;
        public DateTime start_date
        {
            get => _start_date;
            set => Set(ref _start_date, value);
        }

        private decimal _emp_acc;
        public decimal emp_acc
        {
            get => _emp_acc;
            set => Set(ref _emp_acc, value);
        }

        private decimal _cmp_acc;
        public decimal cmp_acc
        {
            get => _cmp_acc;
            set => Set(ref _cmp_acc, value);
        }

        private decimal _salary;
        public decimal salary
        {
            get => _salary;
            set => Set(ref _salary, value);
        }

        private decimal _acc_amt;
        public decimal acc_amt
        {
            get => _acc_amt;
            set => Set(ref _acc_amt, value);
        }

        private string _gender;
        public string gender
        {
            get => _gender;
            set => Set(ref _gender, value);
        }

    }
}
