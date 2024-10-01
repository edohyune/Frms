using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO400_G20 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _so_invoice_no;
        public string so_invoice_no
        {
            get => _so_invoice_no;
            set => Set(ref _so_invoice_no, value);
        }

        private int _sq;
        public int sq
        {
            get => _sq;
            set => Set(ref _sq, value);
        }

        private string _sr_code;
        public string sr_code
        {
            get => _sr_code;
            set => Set(ref _sr_code, value);
        }

        private string _description;
        public string description
        {
            get => _description;
            set => Set(ref _description, value);
        }

        private decimal _soAmt;
        public decimal soAmt
        {
            get => _soAmt;
            set => Set(ref _soAmt, value);
        }

        private decimal _ivcAmt;
        public decimal ivcAmt
        {
            get => _ivcAmt;
            set => Set(ref _ivcAmt, value);
        }

        private decimal _remainAmt;
        public decimal remainAmt
        {
            get => _remainAmt;
            set => Set(ref _remainAmt, value);
        }

        private decimal _work_per;
        public decimal work_per
        {
            get => _work_per;
            set => Set(ref _work_per, value);
        }

        private decimal _work_sum;
        public decimal work_sum
        {
            get => _work_sum;
            set => Set(ref _work_sum, value);
        }

        private decimal _amount;
        public decimal amount
        {
            get => _amount;
            set => Set(ref _amount, value);
        }

        private decimal _amount_sum;
        public decimal amount_sum
        {
            get => _amount_sum;
            set => Set(ref _amount_sum, value);
        }

        private decimal _deduction;
        public decimal deduction
        {
            get => _deduction;
            set => Set(ref _deduction, value);
        }

        private decimal _net_amount;
        public decimal net_amount
        {
            get => _net_amount;
            set => Set(ref _net_amount, value);
        }

        private decimal _downpayment;
        public decimal downpayment
        {
            get => _downpayment;
            set => Set(ref _downpayment, value);
        }

        private decimal _total;
        public decimal total
        {
            get => _total;
            set => Set(ref _total, value);
        }

        private decimal _vat;
        public decimal vat
        {
            get => _vat;
            set => Set(ref _vat, value);
        }

        private decimal _total_amount;
        public decimal total_amount
        {
            get => _total_amount;
            set => Set(ref _total_amount, value);
        }

        private decimal _retention;
        public decimal retention
        {
            get => _retention;
            set => Set(ref _retention, value);
        }

        private string _so_doc_no;
        public string so_doc_no
        {
            get => _so_doc_no;
            set => Set(ref _so_doc_no, value);
        }

        private int _so_sq;
        public int so_sq
        {
            get => _so_sq;
            set => Set(ref _so_sq, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _readOnly;
        public string readOnly
        {
            get => _readOnly;
            set => Set(ref _readOnly, value);
        }

        private decimal _cn_amount;
        public decimal cn_amount
        {
            get => _cn_amount;
            set => Set(ref _cn_amount, value);
        }

        private string _cn_no;
        public string cn_no
        {
            get => _cn_no;
            set => Set(ref _cn_no, value);
        }

    }
}
