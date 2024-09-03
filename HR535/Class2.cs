using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR535_G20 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _doc_no;
        public string doc_no
        {
            get => _doc_no;
            set => Set(ref _doc_no, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _ot_type;
        public string ot_type
        {
            get => _ot_type;
            set => Set(ref _ot_type, value);
        }

        private DateTime _ot_date;
        public DateTime ot_date
        {
            get => _ot_date;
            set => Set(ref _ot_date, value);
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

        private decimal _ot_time_org;
        public decimal ot_time_org
        {
            get => _ot_time_org;
            set => Set(ref _ot_time_org, value);
        }

        private decimal _ot_meal_allowance_org;
        public decimal ot_meal_allowance_org
        {
            get => _ot_meal_allowance_org;
            set => Set(ref _ot_meal_allowance_org, value);
        }

        private string _upload_yn;
        public string upload_yn
        {
            get => _upload_yn;
            set => Set(ref _upload_yn, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _other_lang_name;
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
        }
    }
}
