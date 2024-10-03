using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA160_G20 : Libs.MdlBase
    {
        private string _bid_no;
        public string bid_no
        {
            get => _bid_no;
            set => Set(ref _bid_no, value);
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

        private string _work_desc;
        public string work_desc
        {
            get => _work_desc;
            set => Set(ref _work_desc, value);
        }

        private string _unit;
        public string unit
        {
            get => _unit;
            set => Set(ref _unit, value);
        }

        private decimal _qty;
        public decimal qty
        {
            get => _qty;
            set => Set(ref _qty, value);
        }

        private decimal _shop_price;
        public decimal shop_price
        {
            get => _shop_price;
            set => Set(ref _shop_price, value);
        }

        private decimal _shop_amount;
        public decimal shop_amount
        {
            get => _shop_amount;
            set => Set(ref _shop_amount, value);
        }

        private decimal _matl_price;
        public decimal matl_price
        {
            get => _matl_price;
            set => Set(ref _matl_price, value);
        }

        private decimal _matl_cutting_rate;
        public decimal matl_cutting_rate
        {
            get => _matl_cutting_rate;
            set => Set(ref _matl_cutting_rate, value);
        }

        private decimal _matl_cutting_amount;
        public decimal matl_cutting_amount
        {
            get => _matl_cutting_amount;
            set => Set(ref _matl_cutting_amount, value);
        }

        private decimal _matl_amount;
        public decimal matl_amount
        {
            get => _matl_amount;
            set => Set(ref _matl_amount, value);
        }

        private decimal _labor_mh;
        public decimal labor_mh
        {
            get => _labor_mh;
            set => Set(ref _labor_mh, value);
        }

        private decimal _labor_tmh;
        public decimal labor_tmh
        {
            get => _labor_tmh;
            set => Set(ref _labor_tmh, value);
        }

        private decimal _labor_rate;
        public decimal labor_rate
        {
            get => _labor_rate;
            set => Set(ref _labor_rate, value);
        }

        private decimal _labor_amount;
        public decimal labor_amount
        {
            get => _labor_amount;
            set => Set(ref _labor_amount, value);
        }

        private decimal _tc_cost;
        public decimal tc_cost
        {
            get => _tc_cost;
            set => Set(ref _tc_cost, value);
        }

        private decimal _equip_cost;
        public decimal equip_cost
        {
            get => _equip_cost;
            set => Set(ref _equip_cost, value);
        }

        private decimal _indirect_cost;
        public decimal indirect_cost
        {
            get => _indirect_cost;
            set => Set(ref _indirect_cost, value);
        }

        private decimal _cogs_cost;
        public decimal cogs_cost
        {
            get => _cogs_cost;
            set => Set(ref _cogs_cost, value);
        }

        private decimal _sga_cost;
        public decimal sga_cost
        {
            get => _sga_cost;
            set => Set(ref _sga_cost, value);
        }

        private decimal _profit;
        public decimal profit
        {
            get => _profit;
            set => Set(ref _profit, value);
        }

        private decimal _total;
        public decimal total
        {
            get => _total;
            set => Set(ref _total, value);
        }

        private decimal _unit_rate;
        public decimal unit_rate
        {
            get => _unit_rate;
            set => Set(ref _unit_rate, value);
        }

        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _save_txt;
        public string save_txt
        {
            get => _save_txt;
            set => Set(ref _save_txt, value);
        }

    }
}
