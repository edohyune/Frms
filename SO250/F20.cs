using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO250_F20 : EpicV004.Libs.MdlBase
    {
        private string _so_doc_no;
        public string so_doc_no
        {
            get => _so_doc_no;
            set => Set(ref _so_doc_no, value);
        }

        private string _invoiceNo;
        public string invoiceNo
        {
            get => _invoiceNo;
            set => Set(ref _invoiceNo, value);
        }

        private DateTime _invoice_date;
        public DateTime invoice_date
        {
            get => _invoice_date;
            set => Set(ref _invoice_date, value);
        }

        private string _supplier_invoiceNo;
        public string supplier_invoiceNo
        {
            get => _supplier_invoiceNo;
            set => Set(ref _supplier_invoiceNo, value);
        }

        private string _vc_no;
        public string vc_no
        {
            get => _vc_no;
            set => Set(ref _vc_no, value);
        }

        private DateTime _dp_vatDate;
        public DateTime dp_vatDate
        {
            get => _dp_vatDate;
            set => Set(ref _dp_vatDate, value);
        }

        private string _dp_vatNumber;
        public string dp_vatNumber
        {
            get => _dp_vatNumber;
            set => Set(ref _dp_vatNumber, value);
        }

        private decimal _dp_vatAmount;
        public decimal dp_vatAmount
        {
            get => _dp_vatAmount;
            set => Set(ref _dp_vatAmount, value);
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

        private decimal _dp_ratio;
        public decimal dp_ratio
        {
            get => _dp_ratio;
            set => Set(ref _dp_ratio, value);
        }

        private decimal _dp_amount;
        public decimal dp_amount
        {
            get => _dp_amount;
            set => Set(ref _dp_amount, value);
        }

        private string _dp_memo;
        public string dp_memo
        {
            get => _dp_memo;
            set => Set(ref _dp_memo, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _dp_status;
        public string dp_status
        {
            get => _dp_status;
            set => Set(ref _dp_status, value);
        }

        private string _tax_invoiceNo;
        public string tax_invoiceNo
        {
            get => _tax_invoiceNo;
            set => Set(ref _tax_invoiceNo, value);
        }

    }
}
