using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA100_F30 : Libs.MdlBase
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

        private string _currency;
        public string currency
        {
            get => _currency;
            set => Set(ref _currency, value);
        }

        private decimal _currency_rate;
        public decimal currency_rate
        {
            get => _currency_rate;
            set => Set(ref _currency_rate, value);
        }

        private decimal _rt_tc;
        public decimal rt_tc
        {
            get => _rt_tc;
            set => Set(ref _rt_tc, value);
        }

        private decimal _rt_equip;
        public decimal rt_equip
        {
            get => _rt_equip;
            set => Set(ref _rt_equip, value);
        }

        private decimal _rt_indir;
        public decimal rt_indir
        {
            get => _rt_indir;
            set => Set(ref _rt_indir, value);
        }

        private decimal _rt_cogs;
        public decimal rt_cogs
        {
            get => _rt_cogs;
            set => Set(ref _rt_cogs, value);
        }

        private decimal _rt_sga;
        public decimal rt_sga
        {
            get => _rt_sga;
            set => Set(ref _rt_sga, value);
        }

        private decimal _rt_profit;
        public decimal rt_profit
        {
            get => _rt_profit;
            set => Set(ref _rt_profit, value);
        }

    }
}
