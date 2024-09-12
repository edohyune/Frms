using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR100_G20 : Libs.MdlBase
    {
        private string _dept_structure;
        public string dept_structure
        {
            get => _dept_structure;
            set => Set(ref _dept_structure, value);
        }

        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private DateTime _renewal_date;
        public DateTime renewal_date
        {
            get => _renewal_date;
            set => Set(ref _renewal_date, value);
        }

        private string _dept_seq;
        public string dept_seq
        {
            get => _dept_seq;
            set => Set(ref _dept_seq, value);
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

        private string _dept_name_eng;
        public string dept_name_eng
        {
            get => _dept_name_eng;
            set => Set(ref _dept_name_eng, value);
        }

        private string _dept_middle_name;
        public string dept_middle_name
        {
            get => _dept_middle_name;
            set => Set(ref _dept_middle_name, value);
        }

        private string _dept_nick_name;
        public string dept_nick_name
        {
            get => _dept_nick_name;
            set => Set(ref _dept_nick_name, value);
        }

        private string _dept_ty;
        public string dept_ty
        {
            get => _dept_ty;
            set => Set(ref _dept_ty, value);
        }

        private string _dept_category;
        public string dept_category
        {
            get => _dept_category;
            set => Set(ref _dept_category, value);
        }

        private string _cost_center;
        public string cost_center
        {
            get => _cost_center;
            set => Set(ref _cost_center, value);
        }

        private string _bu;
        public string bu
        {
            get => _bu;
            set => Set(ref _bu, value);
        }

        private string _division;
        public string division
        {
            get => _division;
            set => Set(ref _division, value);
        }

        private string _wh;
        public string wh
        {
            get => _wh;
            set => Set(ref _wh, value);
        }

        private string _use_yn;
        public string use_yn
        {
            get => _use_yn;
            set => Set(ref _use_yn, value);
        }

        private string _budget_dept;
        public string budget_dept
        {
            get => _budget_dept;
            set => Set(ref _budget_dept, value);
        }

        private string _upper_dept;
        public string upper_dept
        {
            get => _upper_dept;
            set => Set(ref _upper_dept, value);
        }

        private string _sort;
        public string sort
        {
            get => _sort;
            set => Set(ref _sort, value);
        }

        private int _lv;
        public int lv
        {
            get => _lv;
            set => Set(ref _lv, value);
        }

        private string _save_txt;
        public string save_txt
        {
            get => _save_txt;
            set => Set(ref _save_txt, value);
        }

        private DateTime _before_date;
        public DateTime before_date
        {
            get => _before_date;
            set => Set(ref _before_date, value);
        }

        private string _budget_yn;
        public string budget_yn
        {
            get => _budget_yn;
            set => Set(ref _budget_yn, value);
        }

        private string _position_dept;
        public string position_dept
        {
            get => _position_dept;
            set => Set(ref _position_dept, value);
        }
    }
}
