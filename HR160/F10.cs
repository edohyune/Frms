using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR160_F10 : EpicV004.Libs.MdlBase
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

        private string _emp_card_no;
        public string emp_card_no
        {
            get => _emp_card_no;
            set => Set(ref _emp_card_no, value);
        }

        private string _title;
        public string title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private string _position;
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _project_nm;
        public string project_nm
        {
            get => _project_nm;
            set => Set(ref _project_nm, value);
        }

        private string _tax_id;
        public string tax_id
        {
            get => _tax_id;
            set => Set(ref _tax_id, value);
        }

        private string _line_id;
        public string line_id
        {
            get => _line_id;
            set => Set(ref _line_id, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _gender;
        public string gender
        {
            get => _gender;
            set => Set(ref _gender, value);
        }

        private string _first_name;
        public string first_name
        {
            get => _first_name;
            set => Set(ref _first_name, value);
        }

        private string _first_name_eng;
        public string first_name_eng
        {
            get => _first_name_eng;
            set => Set(ref _first_name_eng, value);
        }

        private string _middle_name_eng;
        public string middle_name_eng
        {
            get => _middle_name_eng;
            set => Set(ref _middle_name_eng, value);
        }

        private string _last_name_eng;
        public string last_name_eng
        {
            get => _last_name_eng;
            set => Set(ref _last_name_eng, value);
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

        private string _messenger_use;
        public string messenger_use
        {
            get => _messenger_use;
            set => Set(ref _messenger_use, value);
        }

        private string _job_class;
        public string job_class
        {
            get => _job_class;
            set => Set(ref _job_class, value);
        }

        private DateTime _birth_date;
        public DateTime birth_date
        {
            get => _birth_date;
            set => Set(ref _birth_date, value);
        }

        private string _last_name;
        public string last_name
        {
            get => _last_name;
            set => Set(ref _last_name, value);
        }

        private string _nick_name;
        public string nick_name
        {
            get => _nick_name;
            set => Set(ref _nick_name, value);
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

        private DateTime _employment_date;
        public DateTime employment_date
        {
            get => _employment_date;
            set => Set(ref _employment_date, value);
        }

        private string _emp_category;
        public string emp_category
        {
            get => _emp_category;
            set => Set(ref _emp_category, value);
        }

        private string _employee_type;
        public string employee_type
        {
            get => _employee_type;
            set => Set(ref _employee_type, value);
        }

        private int _age;
        public int age
        {
            get => _age;
            set => Set(ref _age, value);
        }

        private string _emp_period;
        public string emp_period
        {
            get => _emp_period;
            set => Set(ref _emp_period, value);
        }

        private string _other_lang_name;
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
        }

        private string _section;
        public string section
        {
            get => _section;
            set => Set(ref _section, value);
        }

        private string _section_nm;
        public string section_nm
        {
            get => _section_nm;
            set => Set(ref _section_nm, value);
        }

        private string _marital;
        public string marital
        {
            get => _marital;
            set => Set(ref _marital, value);
        }

        private string _lumpsum_yn;
        public string lumpsum_yn
        {
            get => _lumpsum_yn;
            set => Set(ref _lumpsum_yn, value);
        }

        private string _employment_category;
        public string employment_category
        {
            get => _employment_category;
            set => Set(ref _employment_category, value);
        }

        private string _employee_status;
        public string employee_status
        {
            get => _employee_status;
            set => Set(ref _employee_status, value);
        }

        private DateTime _employee_status_date;
        public DateTime employee_status_date
        {
            get => _employee_status_date;
            set => Set(ref _employee_status_date, value);
        }

        private string _employee_status_reason;
        public string employee_status_reason
        {
            get => _employee_status_reason;
            set => Set(ref _employee_status_reason, value);
        }

        private DateTime _resign_date;
        public DateTime resign_date
        {
            get => _resign_date;
            set => Set(ref _resign_date, value);
        }

        private string _black_list_yn;
        public string black_list_yn
        {
            get => _black_list_yn;
            set => Set(ref _black_list_yn, value);
        }

        private string _black_reason;
        public string black_reason
        {
            get => _black_reason;
            set => Set(ref _black_reason, value);
        }

        private string _id_card_no;
        public string id_card_no
        {
            get => _id_card_no;
            set => Set(ref _id_card_no, value);
        }

        private DateTime _id_card_expire_date;
        public DateTime id_card_expire_date
        {
            get => _id_card_expire_date;
            set => Set(ref _id_card_expire_date, value);
        }

        private string _warning_when;
        public string warning_when
        {
            get => _warning_when;
            set => Set(ref _warning_when, value);
        }

        private string _warning_msg;
        public string warning_msg
        {
            get => _warning_msg;
            set => Set(ref _warning_msg, value);
        }

        private string _payslip_pw;
        public string payslip_pw
        {
            get => _payslip_pw;
            set => Set(ref _payslip_pw, value);
        }

        private string _notify;
        public string notify
        {
            get => _notify;
            set => Set(ref _notify, value);
        }

        private byte[] _photo;
        public byte[] photo
        {
            get => _photo;
            set => Set(ref _photo, value);
        }

        private byte[] _signimg;
        public byte[] signimg
        {
            get => _signimg;
            set => Set(ref _signimg, value);
        }

        private string _nosalary_vc;
        public string nosalary_vc
        {
            get => _nosalary_vc;
            set => Set(ref _nosalary_vc, value);
        }
    }
}
