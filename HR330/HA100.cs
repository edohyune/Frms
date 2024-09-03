using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR330_G10 : Libs.MdlBase
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

        private long _old_emp_key;
        public long old_emp_key
        {
            get => _old_emp_key;
            set => Set(ref _old_emp_key, value);
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

        private string _nick_name;
        public string nick_name
        {
            get => _nick_name;
            set => Set(ref _nick_name, value);
        }

        private string _gender;
        public string gender
        {
            get => _gender;
            set => Set(ref _gender, value);
        }

        private string _emp_category;
        public string emp_category
        {
            get => _emp_category;
            set => Set(ref _emp_category, value);
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

        private string _employee_status;
        public string employee_status
        {
            get => _employee_status;
            set => Set(ref _employee_status, value);
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

        private string _line_id;
        public string line_id
        {
            get => _line_id;
            set => Set(ref _line_id, value);
        }

        private string _lumpsum_yn;
        public string lumpsum_yn
        {
            get => _lumpsum_yn;
            set => Set(ref _lumpsum_yn, value);
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

        private DateTime _resign_date;
        public DateTime resign_date
        {
            get => _resign_date;
            set => Set(ref _resign_date, value);
        }

        private string _marital;
        public string marital
        {
            get => _marital;
            set => Set(ref _marital, value);
        }

        private string _tax_id;
        public string tax_id
        {
            get => _tax_id;
            set => Set(ref _tax_id, value);
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

        private string _current_postage;
        public string current_postage
        {
            get => _current_postage;
            set => Set(ref _current_postage, value);
        }

        private string _current_addr1;
        public string current_addr1
        {
            get => _current_addr1;
            set => Set(ref _current_addr1, value);
        }

        private string _current_tel_no;
        public string current_tel_no
        {
            get => _current_tel_no;
            set => Set(ref _current_tel_no, value);
        }

        private string _current_email;
        public string current_email
        {
            get => _current_email;
            set => Set(ref _current_email, value);
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

        private string _ethnicity;
        public string ethnicity
        {
            get => _ethnicity;
            set => Set(ref _ethnicity, value);
        }

        private string _nationality;
        public string nationality
        {
            get => _nationality;
            set => Set(ref _nationality, value);
        }

        private decimal _height;
        public decimal height
        {
            get => _height;
            set => Set(ref _height, value);
        }

        private decimal _weight;
        public decimal weight
        {
            get => _weight;
            set => Set(ref _weight, value);
        }

        private decimal _bmi;
        public decimal bmi
        {
            get => _bmi;
            set => Set(ref _bmi, value);
        }

        private string _bmi_result;
        public string bmi_result
        {
            get => _bmi_result;
            set => Set(ref _bmi_result, value);
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

        private string _id_card_postage;
        public string id_card_postage
        {
            get => _id_card_postage;
            set => Set(ref _id_card_postage, value);
        }

        private string _id_card_addr1;
        public string id_card_addr1
        {
            get => _id_card_addr1;
            set => Set(ref _id_card_addr1, value);
        }

        private string _eg_contact_name;
        public string eg_contact_name
        {
            get => _eg_contact_name;
            set => Set(ref _eg_contact_name, value);
        }

        private string _eg_contact_postage;
        public string eg_contact_postage
        {
            get => _eg_contact_postage;
            set => Set(ref _eg_contact_postage, value);
        }

        private string _eg_contact_addr1;
        public string eg_contact_addr1
        {
            get => _eg_contact_addr1;
            set => Set(ref _eg_contact_addr1, value);
        }

        private string _eg_contact_tel_no;
        public string eg_contact_tel_no
        {
            get => _eg_contact_tel_no;
            set => Set(ref _eg_contact_tel_no, value);
        }

        private string _eg_contact_relation;
        public string eg_contact_relation
        {
            get => _eg_contact_relation;
            set => Set(ref _eg_contact_relation, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
