using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR145_G10 : Libs.MdlBase
    {
        private long _seq;
        public long seq
        {
            get => _seq;
            set => Set(ref _seq, value);
        }

        private string _applicant_id;
        public string applicant_id
        {
            get => _applicant_id;
            set => Set(ref _applicant_id, value);
        }

        private string _nm;
        public string nm
        {
            get => _nm;
            set => Set(ref _nm, value);
        }

        private DateTime _apply_date;
        public DateTime apply_date
        {
            get => _apply_date;
            set => Set(ref _apply_date, value);
        }

        private string _current_email;
        public string current_email
        {
            get => _current_email;
            set => Set(ref _current_email, value);
        }

        private string _current_tel_no;
        public string current_tel_no
        {
            get => _current_tel_no;
            set => Set(ref _current_tel_no, value);
        }

        private string _gender;
        public string gender
        {
            get => _gender;
            set => Set(ref _gender, value);
        }

        private string _nationality;
        public string nationality
        {
            get => _nationality;
            set => Set(ref _nationality, value);
        }

        private DateTime _birth_date;
        public DateTime birth_date
        {
            get => _birth_date;
            set => Set(ref _birth_date, value);
        }

        private int _age;
        public int age
        {
            get => _age;
            set => Set(ref _age, value);
        }

        private string _line_id;
        public string line_id
        {
            get => _line_id;
            set => Set(ref _line_id, value);
        }

        private string _pass_interview;
        public string pass_interview
        {
            get => _pass_interview;
            set => Set(ref _pass_interview, value);
        }

        private string _pass_health_check;
        public string pass_health_check
        {
            get => _pass_health_check;
            set => Set(ref _pass_health_check, value);
        }

        private string _trans_emp_master;
        public string trans_emp_master
        {
            get => _trans_emp_master;
            set => Set(ref _trans_emp_master, value);
        }

        private string _black_list_yn;
        public string black_list_yn
        {
            get => _black_list_yn;
            set => Set(ref _black_list_yn, value);
        }

        private string _resign_in_3mon;
        public string resign_in_3mon
        {
            get => _resign_in_3mon;
            set => Set(ref _resign_in_3mon, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _selected;
        public string selected
        {
            get => _selected;
            set => Set(ref _selected, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _doc_no;
        public string doc_no
        {
            get => _doc_no;
            set => Set(ref _doc_no, value);
        }

        private string _edited_by;
        public string edited_by
        {
            get => _edited_by;
            set => Set(ref _edited_by, value);
        }

        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }
    }
}
