using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA100_F20 : Libs.MdlBase
    {
        private decimal _sum_shop;
        public decimal sum_shop
        {
            get => _sum_shop;
            set => Set(ref _sum_shop, value);
        }

        private decimal _rt_shop;
        public decimal rt_shop
        {
            get => _rt_shop;
            set => Set(ref _rt_shop, value);
        }

        private decimal _sum_labor;
        public decimal sum_labor
        {
            get => _sum_labor;
            set => Set(ref _sum_labor, value);
        }

        private decimal _rt_labor;
        public decimal rt_labor
        {
            get => _rt_labor;
            set => Set(ref _rt_labor, value);
        }

        private decimal _sum_equip;
        public decimal sum_equip
        {
            get => _sum_equip;
            set => Set(ref _sum_equip, value);
        }

        private decimal _rt_equip;
        public decimal rt_equip
        {
            get => _rt_equip;
            set => Set(ref _rt_equip, value);
        }

        private decimal _sum_profit;
        public decimal sum_profit
        {
            get => _sum_profit;
            set => Set(ref _sum_profit, value);
        }

        private decimal _rt_profit;
        public decimal rt_profit
        {
            get => _rt_profit;
            set => Set(ref _rt_profit, value);
        }

        private decimal _sum_cogs;
        public decimal sum_cogs
        {
            get => _sum_cogs;
            set => Set(ref _sum_cogs, value);
        }

        private decimal _rt_cogs;
        public decimal rt_cogs
        {
            get => _rt_cogs;
            set => Set(ref _rt_cogs, value);
        }

        private decimal _sum_matl;
        public decimal sum_matl
        {
            get => _sum_matl;
            set => Set(ref _sum_matl, value);
        }

        private decimal _rt_matl;
        public decimal rt_matl
        {
            get => _rt_matl;
            set => Set(ref _rt_matl, value);
        }

        private decimal _sum_tc;
        public decimal sum_tc
        {
            get => _sum_tc;
            set => Set(ref _sum_tc, value);
        }

        private decimal _rt_tc;
        public decimal rt_tc
        {
            get => _rt_tc;
            set => Set(ref _rt_tc, value);
        }

        private decimal _sum_indir;
        public decimal sum_indir
        {
            get => _sum_indir;
            set => Set(ref _sum_indir, value);
        }

        private decimal _rt_indir;
        public decimal rt_indir
        {
            get => _rt_indir;
            set => Set(ref _rt_indir, value);
        }

        private decimal _sum_sga;
        public decimal sum_sga
        {
            get => _sum_sga;
            set => Set(ref _sum_sga, value);
        }

        private decimal _rt_sga;
        public decimal rt_sga
        {
            get => _rt_sga;
            set => Set(ref _rt_sga, value);
        }

        private decimal _total_amount;
        public decimal total_amount
        {
            get => _total_amount;
            set => Set(ref _total_amount, value);
        }

    }
}
