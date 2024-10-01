using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO350_F20 : EpicV004.Libs.MdlBase
    {
        private string _release_no;
        public string release_no
        {
            get => _release_no;
            set => Set(ref _release_no, value);
        }

        private DateTime _release_date;
        public DateTime release_date
        {
            get => _release_date;
            set => Set(ref _release_date, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
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

        private string _supplier_invoice_no;
        public string supplier_invoice_no
        {
            get => _supplier_invoice_no;
            set => Set(ref _supplier_invoice_no, value);
        }

        private string _payment_type;
        public string payment_type
        {
            get => _payment_type;
            set => Set(ref _payment_type, value);
        }

        private string _payment_term;
        public string payment_term
        {
            get => _payment_term;
            set => Set(ref _payment_term, value);
        }

        private int _payment_days;
        public int payment_days
        {
            get => _payment_days;
            set => Set(ref _payment_days, value);
        }

        private DateTime _payment_date;
        public DateTime payment_date
        {
            get => _payment_date;
            set => Set(ref _payment_date, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _retention_project;
        public string retention_project
        {
            get => _retention_project;
            set => Set(ref _retention_project, value);
        }

        private string _retention_supplier;
        public string retention_supplier
        {
            get => _retention_supplier;
            set => Set(ref _retention_supplier, value);
        }

    }
}
