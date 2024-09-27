using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA100_G20 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _bid_no;
        public string bid_no
        {
            get => _bid_no;
            set => Set(ref _bid_no, value);
        }

        private int _sq;
        public int sq
        {
            get => _sq;
            set => Set(ref _sq, value);
        }

        private string _job_desc;
        public string job_desc
        {
            get => _job_desc;
            set => Set(ref _job_desc, value);
        }

        private string _job_ref;
        public string job_ref
        {
            get => _job_ref;
            set => Set(ref _job_ref, value);
        }

        private decimal _qty;
        public decimal qty
        {
            get => _qty;
            set => Set(ref _qty, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _unit;
        public string unit
        {
            get => _unit;
            set => Set(ref _unit, value);
        }

    }
}
