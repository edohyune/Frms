using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR520_G10 : Libs.MdlBase
    {
        private DateTime _apply_date;
        public DateTime apply_date
        {
            get => _apply_date;
            set => Set(ref _apply_date, value);
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

        private DateTime _ot_date;
        public DateTime ot_date
        {
            get => _ot_date;
            set => Set(ref _ot_date, value);
        }

        private string _ot_type;
        public string ot_type
        {
            get => _ot_type;
            set => Set(ref _ot_type, value);
        }

        private string _beginTime;
        public string beginTime
        {
            get => _beginTime;
            set => Set(ref _beginTime, value);
        }

        private string _endTime;
        public string endTime
        {
            get => _endTime;
            set => Set(ref _endTime, value);
        }

        private decimal _ot_time;
        public decimal ot_time
        {
            get => _ot_time;
            set => Set(ref _ot_time, value);
        }

        private decimal _ot_meal_allowance;
        public decimal ot_meal_allowance
        {
            get => _ot_meal_allowance;
            set => Set(ref _ot_meal_allowance, value);
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

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _doc_no;
        public string doc_no
        {
            get => _doc_no;
            set => Set(ref _doc_no, value);
        }
    }
}
