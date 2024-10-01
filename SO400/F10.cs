using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO400_F10 : EpicV004.Libs.MdlBase
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

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _so_doc_no;
        public string so_doc_no
        {
            get => _so_doc_no;
            set => Set(ref _so_doc_no, value);
        }

        private decimal _so_amount;
        public decimal so_amount
        {
            get => _so_amount;
            set => Set(ref _so_amount, value);
        }

        private decimal _ivc_sumAmount;
        public decimal ivc_sumAmount
        {
            get => _ivc_sumAmount;
            set => Set(ref _ivc_sumAmount, value);
        }

        private decimal _so_balance;
        public decimal so_balance
        {
            get => _so_balance;
            set => Set(ref _so_balance, value);
        }

        private string _downpayment;
        public string downpayment
        {
            get => _downpayment;
            set => Set(ref _downpayment, value);
        }

        private decimal _vat;
        public decimal vat
        {
            get => _vat;
            set => Set(ref _vat, value);
        }

        private decimal _net_amount;
        public decimal net_amount
        {
            get => _net_amount;
            set => Set(ref _net_amount, value);
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

    }
}
