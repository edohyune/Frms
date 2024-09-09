using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class AppRegister_F10 : EpicV004.Libs.MdlBase
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

        private string _gender;
        public string gender
        {
            get => _gender;
            set => Set(ref _gender, value);
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

        private string _last_name_eng;
        public string last_name_eng
        {
            get => _last_name_eng;
            set => Set(ref _last_name_eng, value);
        }

        private string _messenger_use;
        public string messenger_use
        {
            get => _messenger_use;
            set => Set(ref _messenger_use, value);
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

        private string _line_id;
        public string line_id
        {
            get => _line_id;
            set => Set(ref _line_id, value);
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

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _current_tel_no;
        public string current_tel_no
        {
            get => _current_tel_no;
            set => Set(ref _current_tel_no, value);
        }

        private string _current_addr1;
        public string current_addr1
        {
            get => _current_addr1;
            set => Set(ref _current_addr1, value);
        }

        private string _current_district;
        public string current_district
        {
            get => _current_district;
            set => Set(ref _current_district, value);
        }

        private string _current_province;
        public string current_province
        {
            get => _current_province;
            set => Set(ref _current_province, value);
        }

        private string _current_road;
        public string current_road
        {
            get => _current_road;
            set => Set(ref _current_road, value);
        }

        private string _current_postage;
        public string current_postage
        {
            get => _current_postage;
            set => Set(ref _current_postage, value);
        }

        private string _current_country;
        public string current_country
        {
            get => _current_country;
            set => Set(ref _current_country, value);
        }

        private string _id_card_no;
        public string id_card_no
        {
            get => _id_card_no;
            set => Set(ref _id_card_no, value);
        }

        private string _current_email;
        public string current_email
        {
            get => _current_email;
            set => Set(ref _current_email, value);
        }
    }
    }
