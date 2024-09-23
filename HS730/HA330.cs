using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HS730_G10 : Libs.MdlBase
    {
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

        private string _social_sec_deduction;
        public string social_sec_deduction
        {
            get => _social_sec_deduction;
            set => Set(ref _social_sec_deduction, value);
        }

        private string _deduction_method;
        public string deduction_method
        {
            get => _deduction_method;
            set => Set(ref _deduction_method, value);
        }

        private DateTime _application_date;
        public DateTime application_date
        {
            get => _application_date;
            set => Set(ref _application_date, value);
        }

        private string _social_sec_no;
        public string social_sec_no
        {
            get => _social_sec_no;
            set => Set(ref _social_sec_no, value);
        }

        private string _title_social_sec;
        public string title_social_sec
        {
            get => _title_social_sec;
            set => Set(ref _title_social_sec, value);
        }

        private string _select_hospital;
        public string select_hospital
        {
            get => _select_hospital;
            set => Set(ref _select_hospital, value);
        }

        private string _choose_no1;
        public string choose_no1
        {
            get => _choose_no1;
            set => Set(ref _choose_no1, value);
        }

        private string _choose_no2;
        public string choose_no2
        {
            get => _choose_no2;
            set => Set(ref _choose_no2, value);
        }

        private string _choose_no3;
        public string choose_no3
        {
            get => _choose_no3;
            set => Set(ref _choose_no3, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
