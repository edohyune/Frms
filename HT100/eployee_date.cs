using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HT100_G10 : Libs.MdlBase
    {
        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _dept_middle_name;
        public string dept_middle_name
        {
            get => _dept_middle_name;
            set => Set(ref _dept_middle_name, value);
        }

        private int _total_last_week;
        public int total_last_week
        {
            get => _total_last_week;
            set => Set(ref _total_last_week, value);
        }

        private int _direct_last_week;
        public int direct_last_week
        {
            get => _direct_last_week;
            set => Set(ref _direct_last_week, value);
        }

        private int _indirect_last_week;
        public int indirect_last_week
        {
            get => _indirect_last_week;
            set => Set(ref _indirect_last_week, value);
        }

        private int _total_this_week;
        public int total_this_week
        {
            get => _total_this_week;
            set => Set(ref _total_this_week, value);
        }

        private int _direct_this_week;
        public int direct_this_week
        {
            get => _direct_this_week;
            set => Set(ref _direct_this_week, value);
        }

        private int _indirect_this_week;
        public int indirect_this_week
        {
            get => _indirect_this_week;
            set => Set(ref _indirect_this_week, value);
        }

        private int _new_hired_total;
        public int new_hired_total
        {
            get => _new_hired_total;
            set => Set(ref _new_hired_total, value);
        }

        private int _new_hired_direct;
        public int new_hired_direct
        {
            get => _new_hired_direct;
            set => Set(ref _new_hired_direct, value);
        }

        private int _new_hired_indirect;
        public int new_hired_indirect
        {
            get => _new_hired_indirect;
            set => Set(ref _new_hired_indirect, value);
        }

        private int _resigned_total;
        public int resigned_total
        {
            get => _resigned_total;
            set => Set(ref _resigned_total, value);
        }

        private int _resigned_direct;
        public int resigned_direct
        {
            get => _resigned_direct;
            set => Set(ref _resigned_direct, value);
        }

        private int _resigned_indirect;
        public int resigned_indirect
        {
            get => _resigned_indirect;
            set => Set(ref _resigned_indirect, value);
        }
    }
}
