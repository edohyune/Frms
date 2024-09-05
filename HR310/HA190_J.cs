using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR310_G10 : Libs.MdlBase
    {
        private string _issue_no;
        public string issue_no
        {
            get => _issue_no;
            set => Set(ref _issue_no, value);
        }

        private DateTime _issue_date;
        public DateTime issue_date
        {
            get => _issue_date;
            set => Set(ref _issue_date, value);
        }

        private string _certificate_type;
        public string certificate_type
        {
            get => _certificate_type;
            set => Set(ref _certificate_type, value);
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

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _employee_status;
        public string employee_status
        {
            get => _employee_status;
            set => Set(ref _employee_status, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _emp_nm;
        public string emp_nm
        {
            get => _emp_nm;
            set => Set(ref _emp_nm, value);
        }

    }

    public class HR310_F10 : HR310_G10
    {
        // Additional properties or methods specific to HR310_G10
        private string _F10SpecificProperty;
        public string F10SpecificProperty
        {
            get => _F10SpecificProperty;
            set => Set(ref _F10SpecificProperty, value);
        }

       
    }

}
