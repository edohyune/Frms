using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA400_G20 :EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private string _lvl1;
        public string lvl1
        {
            get => _lvl1;
            set => Set(ref _lvl1, value);
        }

        private string _lvl2;
        public string lvl2
        {
            get => _lvl2;
            set => Set(ref _lvl2, value);
        }

        private string _lvl3;
        public string lvl3
        {
            get => _lvl3;
            set => Set(ref _lvl3, value);
        }

        private string _wbs;
        public string wbs
        {
            get => _wbs;
            set => Set(ref _wbs, value);
        }

        private DateTime _sdate;
        public DateTime sdate
        {
            get => _sdate;
            set => Set(ref _sdate, value);
        }

        private DateTime _edate;
        public DateTime edate
        {
            get => _edate;
            set => Set(ref _edate, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _manager;
        public string manager
        {
            get => _manager;
            set => Set(ref _manager, value);
        }

        private string _wbs_unit;
        public string wbs_unit
        {
            get => _wbs_unit;
            set => Set(ref _wbs_unit, value);
        }

        private decimal _qty;
        public decimal qty
        {
            get => _qty;
            set => Set(ref _qty, value);
        }

        private decimal _progress;
        public decimal progress
        {
            get => _progress;
            set => Set(ref _progress, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _division;
        public string division
        {
            get => _division;
            set => Set(ref _division, value);
        }

        private string _discipline;
        public string discipline
        {
            get => _discipline;
            set => Set(ref _discipline, value);
        }

        private string _save_txt;
        public string save_txt
        {
            get => _save_txt;
            set => Set(ref _save_txt, value);
        }

        private decimal _weight_factor;
        public decimal weight_factor
        {
            get => _weight_factor;
            set => Set(ref _weight_factor, value);
        }

        private decimal _total_progress;
        public decimal total_progress
        {
            get => _total_progress;
            set => Set(ref _total_progress, value);
        }
    }
}
