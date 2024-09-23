using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR160_F20 : EpicV004.Libs.MdlBase
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

        private string _new_empno;
        public string new_empno
        {
            get => _new_empno;
            set => Set(ref _new_empno, value);
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

        private string _first_name;
        public string first_name
        {
            get => _first_name;
            set => Set(ref _first_name, value);
        }

        private string _last_name;
        public string last_name
        {
            get => _last_name;
            set => Set(ref _last_name, value);
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

        private string _nick_name;
        public string nick_name
        {
            get => _nick_name;
            set => Set(ref _nick_name, value);
        }

        private string _other_lang_name;
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
        }

        private string _gender;
        public string gender
        {
            get => _gender;
            set => Set(ref _gender, value);
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

        private string _level;
        public string level
        {
            get => _level;
            set => Set(ref _level, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _emp_account_type;
        public string emp_account_type
        {
            get => _emp_account_type;
            set => Set(ref _emp_account_type, value);
        }

        private string _job_class;
        public string job_class
        {
            get => _job_class;
            set => Set(ref _job_class, value);
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

        private string _employment_category;
        public string employment_category
        {
            get => _employment_category;
            set => Set(ref _employment_category, value);
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

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _other_msg;
        public string other_msg
        {
            get => _other_msg;
            set => Set(ref _other_msg, value);
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

        private string _current_addr1;
        public string current_addr1
        {
            get => _current_addr1;
            set => Set(ref _current_addr1, value);
        }

        private string _current_addr2;
        public string current_addr2
        {
            get => _current_addr2;
            set => Set(ref _current_addr2, value);
        }

        private string _current_addr3;
        public string current_addr3
        {
            get => _current_addr3;
            set => Set(ref _current_addr3, value);
        }

        private string _current_postage;
        public string current_postage
        {
            get => _current_postage;
            set => Set(ref _current_postage, value);
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

        private string _current_province;
        public string current_province
        {
            get => _current_province;
            set => Set(ref _current_province, value);
        }

        private string _current_district;
        public string current_district
        {
            get => _current_district;
            set => Set(ref _current_district, value);
        }

        private string _current_road;
        public string current_road
        {
            get => _current_road;
            set => Set(ref _current_road, value);
        }

        private string _current_country;
        public string current_country
        {
            get => _current_country;
            set => Set(ref _current_country, value);
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

        private string _place_of_birth;
        public string place_of_birth
        {
            get => _place_of_birth;
            set => Set(ref _place_of_birth, value);
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

        private string _religion;
        public string religion
        {
            get => _religion;
            set => Set(ref _religion, value);
        }

        private string _military;
        public string military
        {
            get => _military;
            set => Set(ref _military, value);
        }

        private string _blood;
        public string blood
        {
            get => _blood;
            set => Set(ref _blood, value);
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

        private string _id_card_addr1;
        public string id_card_addr1
        {
            get => _id_card_addr1;
            set => Set(ref _id_card_addr1, value);
        }

        private string _id_card_addr2;
        public string id_card_addr2
        {
            get => _id_card_addr2;
            set => Set(ref _id_card_addr2, value);
        }

        private string _id_card_addr3;
        public string id_card_addr3
        {
            get => _id_card_addr3;
            set => Set(ref _id_card_addr3, value);
        }

        private string _id_card_province;
        public string id_card_province
        {
            get => _id_card_province;
            set => Set(ref _id_card_province, value);
        }

        private string _id_card_district;
        public string id_card_district
        {
            get => _id_card_district;
            set => Set(ref _id_card_district, value);
        }

        private string _id_card_road;
        public string id_card_road
        {
            get => _id_card_road;
            set => Set(ref _id_card_road, value);
        }

        private string _id_card_country;
        public string id_card_country
        {
            get => _id_card_country;
            set => Set(ref _id_card_country, value);
        }

        private string _id_card_postage;
        public string id_card_postage
        {
            get => _id_card_postage;
            set => Set(ref _id_card_postage, value);
        }

        private string _emergency_contact_name;
        public string emergency_contact_name
        {
            get => _emergency_contact_name;
            set => Set(ref _emergency_contact_name, value);
        }

        private string _emergency_contact_postage;
        public string emergency_contact_postage
        {
            get => _emergency_contact_postage;
            set => Set(ref _emergency_contact_postage, value);
        }

        private string _emergency_contact_addr1;
        public string emergency_contact_addr1
        {
            get => _emergency_contact_addr1;
            set => Set(ref _emergency_contact_addr1, value);
        }

        private string _emergency_contact_addr2;
        public string emergency_contact_addr2
        {
            get => _emergency_contact_addr2;
            set => Set(ref _emergency_contact_addr2, value);
        }

        private string _emergency_contact_addr3;
        public string emergency_contact_addr3
        {
            get => _emergency_contact_addr3;
            set => Set(ref _emergency_contact_addr3, value);
        }

        private string _emergency_contact_tel_no;
        public string emergency_contact_tel_no
        {
            get => _emergency_contact_tel_no;
            set => Set(ref _emergency_contact_tel_no, value);
        }

        private string _emergency_contact_relation;
        public string emergency_contact_relation
        {
            get => _emergency_contact_relation;
            set => Set(ref _emergency_contact_relation, value);
        }

        private string _messenger_use;
        public string messenger_use
        {
            get => _messenger_use;
            set => Set(ref _messenger_use, value);
        }

        private string _chk_criminal;
        public string chk_criminal
        {
            get => _chk_criminal;
            set => Set(ref _chk_criminal, value);
        }

        private string _criminal_memo;
        public string criminal_memo
        {
            get => _criminal_memo;
            set => Set(ref _criminal_memo, value);
        }

        private string _chk_disease;
        public string chk_disease
        {
            get => _chk_disease;
            set => Set(ref _chk_disease, value);
        }

        private string _disease_memo;
        public string disease_memo
        {
            get => _disease_memo;
            set => Set(ref _disease_memo, value);
        }

        private string _scan_yn;
        public string scan_yn
        {
            get => _scan_yn;
            set => Set(ref _scan_yn, value);
        }

        private string _nosalary_vc;
        public string nosalary_vc
        {
            get => _nosalary_vc;
            set => Set(ref _nosalary_vc, value);
        }

        private string _emp_period;
        public string emp_period
        {
            get => _emp_period;
            set => Set(ref _emp_period, value);
        }

        private string _age;
        public string age
        {
            get => _age;
            set => Set(ref _age, value);
        }

        private string _project_nm;
        public string project_nm
        {
            get => _project_nm;
            set => Set(ref _project_nm, value);
        }

        private string _dept_nm;
        public string dept_nm
        {
            get => _dept_nm;
            set => Set(ref _dept_nm, value);
        }

        private string _section_nm;
        public string section_nm
        {
            get => _section_nm;
            set => Set(ref _section_nm, value);
        }

        private string _email;
        public string email
        {
            get => _email;
            set => Set(ref _email, value);
        }

        private string _bmi;
        public string bmi
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
    }
}
