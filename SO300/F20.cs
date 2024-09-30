using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO300_F20 : EpicV004.Libs.MdlBase
    {
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

        private decimal _so_downpayment;
        public decimal so_downpayment
        {
            get => _so_downpayment;
            set => Set(ref _so_downpayment, value);
        }

        private decimal _paid_sum;
        public decimal paid_sum
        {
            get => _paid_sum;
            set => Set(ref _paid_sum, value);
        }

        private decimal _so_balance;
        public decimal so_balance
        {
            get => _so_balance;
            set => Set(ref _so_balance, value);
        }
    }
}
