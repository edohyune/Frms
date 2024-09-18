using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HS400_G10 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _dept_nm;
        public string dept_nm
        {
            get => _dept_nm;
            set => Set(ref _dept_nm, value);
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

        private int _seq;
        public int seq
        {
            get => _seq;
            set => Set(ref _seq, value);
        }

        private string _company_name;
        public string company_name
        {
            get => _company_name;
            set => Set(ref _company_name, value);
        }

        private DateTime _since_date;
        public DateTime since_date
        {
            get => _since_date;
            set => Set(ref _since_date, value);
        }

        private DateTime _end_date;
        public DateTime end_date
        {
            get => _end_date;
            set => Set(ref _end_date, value);
        }

        private int _period;
        public int period
        {
            get => _period;
            set => Set(ref _period, value);
        }

        private string _job_title;
        public string job_title
        {
            get => _job_title;
            set => Set(ref _job_title, value);
        }

        private string _responsible_work;
        public string responsible_work
        {
            get => _responsible_work;
            set => Set(ref _responsible_work, value);
        }

        private decimal _salary;
        public decimal salary
        {
            get => _salary;
            set => Set(ref _salary, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
