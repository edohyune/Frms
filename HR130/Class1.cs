using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR130_G10 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _applicant_id;
        public string applicant_id
        {
            get => _applicant_id;
            set => Set(ref _applicant_id, value);
        }

        private DateTime _apply_date;
        public DateTime apply_date
        {
            get => _apply_date;
            set => Set(ref _apply_date, value);
        }

        private string _title;
        public string title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
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

        private string _last_name_eng;
        public string last_name_eng
        {
            get => _last_name_eng;
            set => Set(ref _last_name_eng, value);
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

        private string _line_id;
        public string line_id
        {
            get => _line_id;
            set => Set(ref _line_id, value);
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

        private string _id_card_no;
        public string id_card_no
        {
            get => _id_card_no;
            set => Set(ref _id_card_no, value);
        }

        private DateTime _id_card_expire_dt;
        public DateTime id_card_expire_dt
        {
            get => _id_card_expire_dt;
            set => Set(ref _id_card_expire_dt, value);
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

        private bool _black_list_yn;
        public bool black_list_yn
        {
            get => _black_list_yn;
            set => Set(ref _black_list_yn, value);
        }

        private bool _resign_in_3mon;
        public bool resign_in_3mon
        {
            get => _resign_in_3mon;
            set => Set(ref _resign_in_3mon, value);
        }

        private bool _chk_criminal;
        public bool chk_criminal
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

        private bool _chk_disease;
        public bool chk_disease
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

        private bool _chk_foreigner;
        public bool chk_foreigner
        {
            get => _chk_foreigner;
            set => Set(ref _chk_foreigner, value);
        }

        private string _issue_no;
        public string issue_no
        {
            get => _issue_no;
            set => Set(ref _issue_no, value);
        }

        private bool _messenger_use;
        public bool messenger_use
        {
            get => _messenger_use;
            set => Set(ref _messenger_use, value);
        }
    }
}
