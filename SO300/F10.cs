using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO300_F10 : EpicV004.Libs.MdlBase
    {
        private string _so_invoice_no;
        public string so_invoice_no
        {
            get => _so_invoice_no;
            set => Set(ref _so_invoice_no, value);
        }

        private DateTime _so_invoice_date;
        public DateTime so_invoice_date
        {
            get => _so_invoice_date;
            set => Set(ref _so_invoice_date, value);
        }

        private DateTime _invoice_start;
        public DateTime invoice_start
        {
            get => _invoice_start;
            set => Set(ref _invoice_start, value);
        }

        private DateTime _invoice_end;
        public DateTime invoice_end
        {
            get => _invoice_end;
            set => Set(ref _invoice_end, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _project_name;
        public string project_name
        {
            get => _project_name;
            set => Set(ref _project_name, value);
        }

        private string _supplier;
        public string supplier
        {
            get => _supplier;
            set => Set(ref _supplier, value);
        }

        private string _supplier_name;
        public string supplier_name
        {
            get => _supplier_name;
            set => Set(ref _supplier_name, value);
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

        private string _note;
        public string note
        {
            get => _note;
            set => Set(ref _note, value);
        }

        private string _sr_contract_type;
        public string sr_contract_type
        {
            get => _sr_contract_type;
            set => Set(ref _sr_contract_type, value);
        }

        private string _sr_measurement_type;
        public string sr_measurement_type
        {
            get => _sr_measurement_type;
            set => Set(ref _sr_measurement_type, value);
        }

        private string _sr_guarantee_bank;
        public string sr_guarantee_bank
        {
            get => _sr_guarantee_bank;
            set => Set(ref _sr_guarantee_bank, value);
        }

        private int _sr_bank_per;
        public int sr_bank_per
        {
            get => _sr_bank_per;
            set => Set(ref _sr_bank_per, value);
        }

        private string _sr_guarantee_bond;
        public string sr_guarantee_bond
        {
            get => _sr_guarantee_bond;
            set => Set(ref _sr_guarantee_bond, value);
        }

        private int _sr_bond_per;
        public int sr_bond_per
        {
            get => _sr_bond_per;
            set => Set(ref _sr_bond_per, value);
        }

        private string _sr_guarantee_retention;
        public string sr_guarantee_retention
        {
            get => _sr_guarantee_retention;
            set => Set(ref _sr_guarantee_retention, value);
        }

        private int _sr_retention_per;
        public int sr_retention_per
        {
            get => _sr_retention_per;
            set => Set(ref _sr_retention_per, value);
        }

        private string _sr_guarantee_na;
        public string sr_guarantee_na
        {
            get => _sr_guarantee_na;
            set => Set(ref _sr_guarantee_na, value);
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

        private string _tax_invoice_no;
        public string tax_invoice_no
        {
            get => _tax_invoice_no;
            set => Set(ref _tax_invoice_no, value);
        }

        private DateTime _vat_date;
        public DateTime vat_date
        {
            get => _vat_date;
            set => Set(ref _vat_date, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _supplier_invoice_no;
        public string supplier_invoice_no
        {
            get => _supplier_invoice_no;
            set => Set(ref _supplier_invoice_no, value);
        }

        private string _dp_invoiceNo;
        public string dp_invoiceNo
        {
            get => _dp_invoiceNo;
            set => Set(ref _dp_invoiceNo, value);
        }

        private decimal _dp_amount;
        public decimal dp_amount
        {
            get => _dp_amount;
            set => Set(ref _dp_amount, value);
        }

        private decimal _dp_usePer;
        public decimal dp_usePer
        {
            get => _dp_usePer;
            set => Set(ref _dp_usePer, value);
        }

        private string _downpayment;
        public string downpayment
        {
            get => _downpayment;
            set => Set(ref _downpayment, value);
        }

        private string _so_doc_no;
        public string so_doc_no
        {
            get => _so_doc_no;
            set => Set(ref _so_doc_no, value);
        }

    }
}
