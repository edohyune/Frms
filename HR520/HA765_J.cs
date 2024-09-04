using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR520_G20 : Libs.MdlBase
    {
        private long _no;
        public long no
        {
            get => _no;
            set => Set(ref _no, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _emp_nm;
        public string emp_nm
        {
            get => _emp_nm;
            set => Set(ref _emp_nm, value);
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

        private string _dept_name;
        public string dept_name
        {
            get => _dept_name;
            set => Set(ref _dept_name, value);
        }

        private string _team;
        public string team
        {
            get => _team;
            set => Set(ref _team, value);
        }

        private string _area;
        public string area
        {
            get => _area;
            set => Set(ref _area, value);
        }

        private DateTime _ot_date;
        public DateTime ot_date
        {
            get => _ot_date;
            set => Set(ref _ot_date, value);
        }

        private DateTime _org_ot_date;
        public DateTime org_ot_date
        {
            get => _org_ot_date;
            set => Set(ref _org_ot_date, value);
        }

        private string _salary_category;
        public string salary_category
        {
            get => _salary_category;
            set => Set(ref _salary_category, value);
        }

        private string _ot_type;
        public string ot_type
        {
            get => _ot_type;
            set => Set(ref _ot_type, value);
        }

        private string _night_shift_wage;
        public string night_shift_wage
        {
            get => _night_shift_wage;
            set => Set(ref _night_shift_wage, value);
        }

        private string _std_begin;
        public string std_begin
        {
            get => _std_begin;
            set => Set(ref _std_begin, value);
        }

        private string _std_end;
        public string std_end
        {
            get => _std_end;
            set => Set(ref _std_end, value);
        }

        private string _tmm_min_stamp;
        public string tmm_min_stamp
        {
            get => _tmm_min_stamp;
            set => Set(ref _tmm_min_stamp, value);
        }

        private string _tmm_max_stamp;
        public string tmm_max_stamp
        {
            get => _tmm_max_stamp;
            set => Set(ref _tmm_max_stamp, value);
        }

        private string _ot_time_begin;
        public string ot_time_begin
        {
            get => _ot_time_begin;
            set => Set(ref _ot_time_begin, value);
        }

        private string _ot_time_end;
        public string ot_time_end
        {
            get => _ot_time_end;
            set => Set(ref _ot_time_end, value);
        }

        private string _bgActual;
        public string bgActual
        {
            get => _bgActual;
            set => Set(ref _bgActual, value);
        }

        private string _edActual;
        public string edActual
        {
            get => _edActual;
            set => Set(ref _edActual, value);
        }

        private int _dp;
        public int dp
        {
            get => _dp;
            set => Set(ref _dp, value);
        }

        private string _hp;
        public string hp
        {
            get => _hp;
            set => Set(ref _hp, value);
        }

        private decimal _ot_meal_allowance;
        public decimal ot_meal_allowance
        {
            get => _ot_meal_allowance;
            set => Set(ref _ot_meal_allowance, value);
        }

        private decimal _ot_min;
        public decimal ot_min
        {
            get => _ot_min;
            set => Set(ref _ot_min, value);
        }

        private decimal _ot_hour;
        public decimal ot_hour
        {
            get => _ot_hour;
            set => Set(ref _ot_hour, value);
        }
    }
}
