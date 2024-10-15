using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR200_G20 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _selected;
        public string selected
        {
            get => _selected;
            set => Set(ref _selected, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _nm;
        public string nm
        {
            get => _nm;
            set => Set(ref _nm, value);
        }

        private string _other_lang_name;
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
        }

        private DateTime _order_date;
        public DateTime order_date
        {
            get => _order_date;
            set => Set(ref _order_date, value);
        }

        private string _order_type;
        public string order_type
        {
            get => _order_type;
            set => Set(ref _order_type, value);
        }

        private string _emp_category;
        public string emp_category
        {
            get => _emp_category;
            set => Set(ref _emp_category, value);
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

        private string _project_name;
        public string project_name
        {
            get => _project_name;
            set => Set(ref _project_name, value);
        }

        private string _position;
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
        }

        private string _job_class;
        public string job_class
        {
            get => _job_class;
            set => Set(ref _job_class, value);
        }

        private string _employee_type;
        public string employee_type
        {
            get => _employee_type;
            set => Set(ref _employee_type, value);
        }

        private string _doc_no;
        public string doc_no
        {
            get => _doc_no;
            set => Set(ref _doc_no, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }
    }
}
