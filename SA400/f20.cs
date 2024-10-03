using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA400_F20 :EpicV004.Libs.MdlBase
    {
        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private decimal _contract_original;
        public decimal contract_original
        {
            get => _contract_original;
            set => Set(ref _contract_original, value);
        }

        private decimal _contract_amendment;
        public decimal contract_amendment
        {
            get => _contract_amendment;
            set => Set(ref _contract_amendment, value);
        }

        private decimal _contract_co;
        public decimal contract_co
        {
            get => _contract_co;
            set => Set(ref _contract_co, value);
        }

        private decimal _contract_op;
        public decimal contract_op
        {
            get => _contract_op;
            set => Set(ref _contract_op, value);
        }

        private decimal _contract_total;
        public decimal contract_total
        {
            get => _contract_total;
            set => Set(ref _contract_total, value);
        }

        private decimal _invoiced_original;
        public decimal invoiced_original
        {
            get => _invoiced_original;
            set => Set(ref _invoiced_original, value);
        }

        private decimal _invoiced_amendment;
        public decimal invoiced_amendment
        {
            get => _invoiced_amendment;
            set => Set(ref _invoiced_amendment, value);
        }

        private decimal _invoiced_co;
        public decimal invoiced_co
        {
            get => _invoiced_co;
            set => Set(ref _invoiced_co, value);
        }

        private decimal _invoiced_op;
        public decimal invoiced_op
        {
            get => _invoiced_op;
            set => Set(ref _invoiced_op, value);
        }

        private decimal _invoiced_total;
        public decimal invoiced_total
        {
            get => _invoiced_total;
            set => Set(ref _invoiced_total, value);
        }

        private decimal _thb_total;
        public decimal thb_total
        {
            get => _thb_total;
            set => Set(ref _thb_total, value);
        }

        private decimal _invoiced_receive;
        public decimal invoiced_receive
        {
            get => _invoiced_receive;
            set => Set(ref _invoiced_receive, value);
        }

        private decimal _thb_receive;
        public decimal thb_receive
        {
            get => _thb_receive;
            set => Set(ref _thb_receive, value);
        }

        private decimal _invoiced_balance;
        public decimal invoiced_balance
        {
            get => _invoiced_balance;
            set => Set(ref _invoiced_balance, value);
        }

        private decimal _contract_remain;
        public decimal contract_remain
        {
            get => _contract_remain;
            set => Set(ref _contract_remain, value);
        }

        private decimal _per_original;
        public decimal per_original
        {
            get => _per_original;
            set => Set(ref _per_original, value);
        }

        private decimal _per_amendment;
        public decimal per_amendment
        {
            get => _per_amendment;
            set => Set(ref _per_amendment, value);
        }

        private decimal _per_co;
        public decimal per_co
        {
            get => _per_co;
            set => Set(ref _per_co, value);
        }

        private decimal _per_op;
        public decimal per_op
        {
            get => _per_op;
            set => Set(ref _per_op, value);
        }

        private decimal _per_total;
        public decimal per_total
        {
            get => _per_total;
            set => Set(ref _per_total, value);
        }

        private decimal _per_receive;
        public decimal per_receive
        {
            get => _per_receive;
            set => Set(ref _per_receive, value);
        }
    }
}
