using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA400_G60 :EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _cor_no;
        public string cor_no
        {
            get => _cor_no;
            set => Set(ref _cor_no, value);
        }

        private DateTime _cor_date;
        public DateTime cor_date
        {
            get => _cor_date;
            set => Set(ref _cor_date, value);
        }

        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private string _dsc;
        public string dsc
        {
            get => _dsc;
            set => Set(ref _dsc, value);
        }

        private string _pricing_method;
        public string pricing_method
        {
            get => _pricing_method;
            set => Set(ref _pricing_method, value);
        }

        private decimal _markup_per;
        public decimal markup_per
        {
            get => _markup_per;
            set => Set(ref _markup_per, value);
        }

        private decimal _cor_amount;
        public decimal cor_amount
        {
            get => _cor_amount;
            set => Set(ref _cor_amount, value);
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

        private decimal _currency_amount;
        public decimal currency_amount
        {
            get => _currency_amount;
            set => Set(ref _currency_amount, value);
        }

        private decimal _payment_rate;
        public decimal payment_rate
        {
            get => _payment_rate;
            set => Set(ref _payment_rate, value);
        }

        private string _payment_condition;
        public string payment_condition
        {
            get => _payment_condition;
            set => Set(ref _payment_condition, value);
        }

        private decimal _ratio;
        public decimal ratio
        {
            get => _ratio;
            set => Set(ref _ratio, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
