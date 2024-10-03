using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA400_G80 :EpicV004.Libs.MdlBase
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

        private string _subcon_no;
        public string subcon_no
        {
            get => _subcon_no;
            set => Set(ref _subcon_no, value);
        }

        private DateTime _subcon_date;
        public DateTime subcon_date
        {
            get => _subcon_date;
            set => Set(ref _subcon_date, value);
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

        private string _payment_condition;
        public string payment_condition
        {
            get => _payment_condition;
            set => Set(ref _payment_condition, value);
        }

        private decimal _manhour;
        public decimal manhour
        {
            get => _manhour;
            set => Set(ref _manhour, value);
        }

        private decimal _budget_amount;
        public decimal budget_amount
        {
            get => _budget_amount;
            set => Set(ref _budget_amount, value);
        }

        private string _contract_type;
        public string contract_type
        {
            get => _contract_type;
            set => Set(ref _contract_type, value);
        }

        private string _description;
        public string description
        {
            get => _description;
            set => Set(ref _description, value);
        }

        private string _score;
        public string score
        {
            get => _score;
            set => Set(ref _score, value);
        }

        private decimal _score_value;
        public decimal score_value
        {
            get => _score_value;
            set => Set(ref _score_value, value);
        }

        private string _deleted;
        public string deleted
        {
            get => _deleted;
            set => Set(ref _deleted, value);
        }

        private string _division;
        public string division
        {
            get => _division;
            set => Set(ref _division, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private decimal _normal_mh;
        public decimal normal_mh
        {
            get => _normal_mh;
            set => Set(ref _normal_mh, value);
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

        private decimal _price;
        public decimal price
        {
            get => _price;
            set => Set(ref _price, value);
        }

        private string _rev;
        public string rev
        {
            get => _rev;
            set => Set(ref _rev, value);
        }

        private decimal _currency_amount;
        public decimal currency_amount
        {
            get => _currency_amount;
            set => Set(ref _currency_amount, value);
        }

        private string _supplier;
        public string supplier
        {
            get => _supplier;
            set => Set(ref _supplier, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }
    }
}
