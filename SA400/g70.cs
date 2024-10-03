using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA400_G70 :EpicV004.Libs.MdlBase
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

        private string _po_no;
        public string po_no
        {
            get => _po_no;
            set => Set(ref _po_no, value);
        }

        private DateTime _po_date;
        public DateTime po_date
        {
            get => _po_date;
            set => Set(ref _po_date, value);
        }

        private string _client_poNo;
        public string client_poNo
        {
            get => _client_poNo;
            set => Set(ref _client_poNo, value);
        }

        private string _revenue_type;
        public string revenue_type
        {
            get => _revenue_type;
            set => Set(ref _revenue_type, value);
        }

        private string _svc_id;
        public string svc_id
        {
            get => _svc_id;
            set => Set(ref _svc_id, value);
        }

        private string _svc_name;
        public string svc_name
        {
            get => _svc_name;
            set => Set(ref _svc_name, value);
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

        private decimal _po_amount;
        public decimal po_amount
        {
            get => _po_amount;
            set => Set(ref _po_amount, value);
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

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _chk_read;
        public string chk_read
        {
            get => _chk_read;
            set => Set(ref _chk_read, value);
        }
    }
}
