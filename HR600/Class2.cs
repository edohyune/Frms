using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR600_G20 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _day_year_type;
        public string day_year_type
        {
            get => _day_year_type;
            set => Set(ref _day_year_type, value);
        }

        private int _from_days;
        public int from_days
        {
            get => _from_days;
            set => Set(ref _from_days, value);
        }

        private int _to_days;
        public int to_days
        {
            get => _to_days;
            set => Set(ref _to_days, value);
        }

        private int _from_years;
        public int from_years
        {
            get => _from_years;
            set => Set(ref _from_years, value);
        }

        private int _to_years;
        public int to_years
        {
            get => _to_years;
            set => Set(ref _to_years, value);
        }

        private int _severance;
        public int severance
        {
            get => _severance;
            set => Set(ref _severance, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
