using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SP100_G10 : EpicV004.Libs.MdlBase
    {
        private string _bid_no;
        public string bid_no
        {
            get => _bid_no;
            set => Set(ref _bid_no, value);
        }

        private string _rev;
        public string rev
        {
            get => _rev;
            set => Set(ref _rev, value);
        }

        private int _validity;
        public int validity
        {
            get => _validity;
            set => Set(ref _validity, value);
        }

        private DateTime _bid_date;
        public DateTime bid_date
        {
            get => _bid_date;
            set => Set(ref _bid_date, value);
        }

        private string _rfq_no;
        public string rfq_no
        {
            get => _rfq_no;
            set => Set(ref _rfq_no, value);
        }

        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private string _project_name;
        public string project_name
        {
            get => _project_name;
            set => Set(ref _project_name, value);
        }

        private int _category;
        public int category
        {
            get => _category;
            set => Set(ref _category, value);
        }

        private string _sop_type;
        public string sop_type
        {
            get => _sop_type;
            set => Set(ref _sop_type, value);
        }

        private string _client;
        public string client
        {
            get => _client;
            set => Set(ref _client, value);
        }

        private string _bugetary_status;
        public string bugetary_status
        {
            get => _bugetary_status;
            set => Set(ref _bugetary_status, value);
        }

        private string _rfq_status;
        public string rfq_status
        {
            get => _rfq_status;
            set => Set(ref _rfq_status, value);
        }

        private string _final_status;
        public string final_status
        {
            get => _final_status;
            set => Set(ref _final_status, value);
        }

        private int _unit;
        public int unit
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

        private string _currency;
        public string currency
        {
            get => _currency;
            set => Set(ref _currency, value);
        }

        private decimal _shop_amount;
        public decimal shop_amount
        {
            get => _shop_amount;
            set => Set(ref _shop_amount, value);
        }

        private decimal _matl_amount;
        public decimal matl_amount
        {
            get => _matl_amount;
            set => Set(ref _matl_amount, value);
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

    }
}
