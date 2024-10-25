using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR490_G20 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _std_year;
        public string std_year
        {
            get => _std_year;
            set => Set(ref _std_year, value);
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

        private string _emp_ename;
        public string emp_ename
        {
            get => _emp_ename;
            set => Set(ref _emp_ename, value);
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

        private string _dept_nm;
        public string dept_nm
        {
            get => _dept_nm;
            set => Set(ref _dept_nm, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _job_class;
        public string job_class
        {
            get => _job_class;
            set => Set(ref _job_class, value);
        }

        private string _job_site;
        public string job_site
        {
            get => _job_site;
            set => Set(ref _job_site, value);
        }

        private DateTime _start_working_date;
        public DateTime start_working_date
        {
            get => _start_working_date;
            set => Set(ref _start_working_date, value);
        }

        private DateTime _employment_date;
        public DateTime employment_date
        {
            get => _employment_date;
            set => Set(ref _employment_date, value);
        }

        private string _emp_period;
        public string emp_period
        {
            get => _emp_period;
            set => Set(ref _emp_period, value);
        }

        private string _leave_type;
        public string leave_type
        {
            get => _leave_type;
            set => Set(ref _leave_type, value);
        }

        private decimal _leave_qty;
        public decimal leave_qty
        {
            get => _leave_qty;
            set => Set(ref _leave_qty, value);
        }
    }
}
