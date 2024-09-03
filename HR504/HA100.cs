using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR504_G10 : Libs.MdlBase
    {
        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private DateTime _apply_date;
        public DateTime apply_date
        {
            get => _apply_date;
            set => Set(ref _apply_date, value);
        }

        private string _work_schedule;
        public string work_schedule
        {
            get => _work_schedule;
            set => Set(ref _work_schedule, value);
        }

        private string _wt_name;
        public string wt_name
        {
            get => _wt_name;
            set => Set(ref _wt_name, value);
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

        private string _position;
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
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
    }
}
