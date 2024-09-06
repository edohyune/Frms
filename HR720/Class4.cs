using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR720_F10 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _doc_no;
        public string doc_no
        {
            get => _doc_no;
            set => Set(ref _doc_no, value);
        }

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

        private string _position;
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
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

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private DateTime _start_working_date;
        public DateTime start_working_date
        {
            get => _start_working_date;
            set => Set(ref _start_working_date, value);
        }

        private string _emp_period;
        public string emp_period
        {
            get => _emp_period;
            set => Set(ref _emp_period, value);
        }

        private string _salary_category;
        public string salary_category
        {
            get => _salary_category;
            set => Set(ref _salary_category, value);
        }

        private decimal _salary_rate;
        public decimal salary_rate
        {
            get => _salary_rate;
            set => Set(ref _salary_rate, value);
        }

        private int _severance_qty;
        public int severance_qty
        {
            get => _severance_qty;
            set => Set(ref _severance_qty, value);
        }

        private decimal _severance_amt;
        public decimal severance_amt
        {
            get => _severance_amt;
            set => Set(ref _severance_amt, value);
        }

        private decimal _loan_balance;
        public decimal loan_balance
        {
            get => _loan_balance;
            set => Set(ref _loan_balance, value);
        }

        private decimal _etc_deduction;
        public decimal etc_deduction
        {
            get => _etc_deduction;
            set => Set(ref _etc_deduction, value);
        }

        private string _resign_type;
        public string resign_type
        {
            get => _resign_type;
            set => Set(ref _resign_type, value);
        }

        private DateTime _resign_date;
        public DateTime resign_date
        {
            get => _resign_date;
            set => Set(ref _resign_date, value);
        }

        private string _agree_yn;
        public string agree_yn
        {
            get => _agree_yn;
            set => Set(ref _agree_yn, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

    }
}
