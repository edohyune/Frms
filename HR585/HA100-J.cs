using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR585_G10 : Libs.MdlBase
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

        private string _name;
        public string name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private string _other_lang_name;
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
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

        private string _section;
        public string section
        {
            get => _section;
            set => Set(ref _section, value);
        }

        private string _job_site;
        public string job_site
        {
            get => _job_site;
            set => Set(ref _job_site, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _employee_type;
        public string employee_type
        {
            get => _employee_type;
            set => Set(ref _employee_type, value);
        }

        private string _job_class;
        public string job_class
        {
            get => _job_class;
            set => Set(ref _job_class, value);
        }

        private DateTime _apply_date;
        public DateTime apply_date
        {
            get => _apply_date;
            set => Set(ref _apply_date, value);
        }

        private string _employee_status;
        public string employee_status
        {
            get => _employee_status;
            set => Set(ref _employee_status, value);
        }

        private string _salary_category;
        public string salary_category
        {
            get => _salary_category;
            set => Set(ref _salary_category, value);
        }

        private string _lumpsum_yn;
        public string lumpsum_yn
        {
            get => _lumpsum_yn;
            set => Set(ref _lumpsum_yn, value);
        }

        private decimal _salary_rate;
        public decimal salary_rate
        {
            get => _salary_rate;
            set => Set(ref _salary_rate, value);
        }

        private string _payment_method;
        public string payment_method
        {
            get => _payment_method;
            set => Set(ref _payment_method, value);
        }

        private string _bank_name;
        public string bank_name
        {
            get => _bank_name;
            set => Set(ref _bank_name, value);
        }

        private string _bank_account_no;
        public string bank_account_no
        {
            get => _bank_account_no;
            set => Set(ref _bank_account_no, value);
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