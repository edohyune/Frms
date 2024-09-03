using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR610_G20 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private long _tx_key;
        public long tx_key
        {
            get => _tx_key;
            set => Set(ref _tx_key, value);
        }

        private decimal _tx_fm;
        public decimal tx_fm
        {
            get => _tx_fm;
            set => Set(ref _tx_fm, value);
        }

        private decimal _tx_to;
        public decimal tx_to
        {
            get => _tx_to;
            set => Set(ref _tx_to, value);
        }

        private decimal _tx_range;
        public decimal tx_range
        {
            get => _tx_range;
            set => Set(ref _tx_range, value);
        }

        private decimal _tx_pcnt;
        public decimal tx_pcnt
        {
            get => _tx_pcnt;
            set => Set(ref _tx_pcnt, value);
        }

        private decimal _tx_amt;
        public decimal tx_amt
        {
            get => _tx_amt;
            set => Set(ref _tx_amt, value);
        }

        private decimal _tx_cvm;
        public decimal tx_cvm
        {
            get => _tx_cvm;
            set => Set(ref _tx_cvm, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _is_use;
        public string is_use
        {
            get => _is_use;
            set => Set(ref _is_use, value);
        }
    }
}
