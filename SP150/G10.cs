using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SP150_G10 : EpicV004.Libs.MdlBase
    {
        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private string _invoice_no;
        public string invoice_no
        {
            get => _invoice_no;
            set => Set(ref _invoice_no, value);
        }

        private DateTime _invoice_date;
        public DateTime invoice_date
        {
            get => _invoice_date;
            set => Set(ref _invoice_date, value);
        }

        private DateTime _due_date;
        public DateTime due_date
        {
            get => _due_date;
            set => Set(ref _due_date, value);
        }

        private string _invoice_type;
        public string invoice_type
        {
            get => _invoice_type;
            set => Set(ref _invoice_type, value);
        }

        private string _cust;
        public string cust
        {
            get => _cust;
            set => Set(ref _cust, value);
        }

        private string _supplier_name;
        public string supplier_name
        {
            get => _supplier_name;
            set => Set(ref _supplier_name, value);
        }

        private string _ivc_currency;
        public string ivc_currency
        {
            get => _ivc_currency;
            set => Set(ref _ivc_currency, value);
        }

        private decimal _ivc_currencyRate;
        public decimal ivc_currencyRate
        {
            get => _ivc_currencyRate;
            set => Set(ref _ivc_currencyRate, value);
        }

        private decimal _amount;
        public decimal amount
        {
            get => _amount;
            set => Set(ref _amount, value);
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

        private decimal _thb_equivalents;
        public decimal thb_equivalents
        {
            get => _thb_equivalents;
            set => Set(ref _thb_equivalents, value);
        }

        private decimal _thb_amount;
        public decimal thb_amount
        {
            get => _thb_amount;
            set => Set(ref _thb_amount, value);
        }

        private decimal _thb_vat;
        public decimal thb_vat
        {
            get => _thb_vat;
            set => Set(ref _thb_vat, value);
        }

        private decimal _thb_total;
        public decimal thb_total
        {
            get => _thb_total;
            set => Set(ref _thb_total, value);
        }

        private decimal _thb_netAmount;
        public decimal thb_netAmount
        {
            get => _thb_netAmount;
            set => Set(ref _thb_netAmount, value);
        }

        private decimal _deduction_advance;
        public decimal deduction_advance
        {
            get => _deduction_advance;
            set => Set(ref _deduction_advance, value);
        }

        private decimal _deduction_retention;
        public decimal deduction_retention
        {
            get => _deduction_retention;
            set => Set(ref _deduction_retention, value);
        }

        private decimal _deduction_damages;
        public decimal deduction_damages
        {
            get => _deduction_damages;
            set => Set(ref _deduction_damages, value);
        }

        private decimal _acc_invoiceAmount;
        public decimal acc_invoiceAmount
        {
            get => _acc_invoiceAmount;
            set => Set(ref _acc_invoiceAmount, value);
        }

        private decimal _acc_advDeduction;
        public decimal acc_advDeduction
        {
            get => _acc_advDeduction;
            set => Set(ref _acc_advDeduction, value);
        }

        private decimal _acc_retention;
        public decimal acc_retention
        {
            get => _acc_retention;
            set => Set(ref _acc_retention, value);
        }

        private string _bjc_info;
        public string bjc_info
        {
            get => _bjc_info;
            set => Set(ref _bjc_info, value);
        }

        private string _bank;
        public string bank
        {
            get => _bank;
            set => Set(ref _bank, value);
        }

        private string _bank_name;
        public string bank_name
        {
            get => _bank_name;
            set => Set(ref _bank_name, value);
        }

        private string _bank_addr;
        public string bank_addr
        {
            get => _bank_addr;
            set => Set(ref _bank_addr, value);
        }

        private string _bank_acc_no;
        public string bank_acc_no
        {
            get => _bank_acc_no;
            set => Set(ref _bank_acc_no, value);
        }

        private string _purchase_order_number;
        public string purchase_order_number
        {
            get => _purchase_order_number;
            set => Set(ref _purchase_order_number, value);
        }

        private string _cust_invoiceNo;
        public string cust_invoiceNo
        {
            get => _cust_invoiceNo;
            set => Set(ref _cust_invoiceNo, value);
        }

        private string _vat_number;
        public string vat_number
        {
            get => _vat_number;
            set => Set(ref _vat_number, value);
        }

        private string _release_note;
        public string release_note
        {
            get => _release_note;
            set => Set(ref _release_note, value);
        }

        private string _supplement_number;
        public string supplement_number
        {
            get => _supplement_number;
            set => Set(ref _supplement_number, value);
        }

        private string _ivc_status;
        public string ivc_status
        {
            get => _ivc_status;
            set => Set(ref _ivc_status, value);
        }

        private int _payment_days;
        public int payment_days
        {
            get => _payment_days;
            set => Set(ref _payment_days, value);
        }

        private string _payment_term;
        public string payment_term
        {
            get => _payment_term;
            set => Set(ref _payment_term, value);
        }

        private string _delivery_term;
        public string delivery_term
        {
            get => _delivery_term;
            set => Set(ref _delivery_term, value);
        }

        private string _subject;
        public string subject
        {
            get => _subject;
            set => Set(ref _subject, value);
        }

        private string _invoice_description;
        public string invoice_description
        {
            get => _invoice_description;
            set => Set(ref _invoice_description, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

    }
}
