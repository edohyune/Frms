using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR430_G10 : Libs.MdlBase
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

        private decimal _vac_issued;
        public decimal vac_issued
        {
            get => _vac_issued;
            set => Set(ref _vac_issued, value);
        }

        private decimal _vac_used;
        public decimal vac_used
        {
            get => _vac_used;
            set => Set(ref _vac_used, value);
        }

        private decimal _sik_issued;
        public decimal sik_issued
        {
            get => _sik_issued;
            set => Set(ref _sik_issued, value);
        }

        private decimal _sik_used;
        public decimal sik_used
        {
            get => _sik_used;
            set => Set(ref _sik_used, value);
        }

        private decimal _biz_issued;
        public decimal biz_issued
        {
            get => _biz_issued;
            set => Set(ref _biz_issued, value);
        }

        private decimal _biz_used;
        public decimal biz_used
        {
            get => _biz_used;
            set => Set(ref _biz_used, value);
        }

        private decimal _vac_balance;
        public decimal vac_balance
        {
            get => _vac_balance;
            set => Set(ref _vac_balance, value);
        }

        private decimal _sik_balance;
        public decimal sik_balance
        {
            get => _sik_balance;
            set => Set(ref _sik_balance, value);
        }

        private decimal _biz_balance;
        public decimal biz_balance
        {
            get => _biz_balance;
            set => Set(ref _biz_balance, value);
        }
    }
}
