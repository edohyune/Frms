using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO200_F20 : EpicV004.Libs.MdlBase
    {
        private string _so_doc_no;
        public string so_doc_no
        {
            get => _so_doc_no;
            set => Set(ref _so_doc_no, value);
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

        private decimal _amount;
        public decimal amount
        {
            get => _amount;
            set => Set(ref _amount, value);
        }

        private decimal _dp_vatAmount;
        public decimal dp_vatAmount
        {
            get => _dp_vatAmount;
            set => Set(ref _dp_vatAmount, value);
        }

        private string _dp_status;
        public string dp_status
        {
            get => _dp_status;
            set => Set(ref _dp_status, value);
        }

        private string _dp_memo;
        public string dp_memo
        {
            get => _dp_memo;
            set => Set(ref _dp_memo, value);
        }

    }
}
