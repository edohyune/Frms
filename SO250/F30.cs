using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO250_F30 : EpicV004.Libs.MdlBase
    {
        private decimal _amount;
        public decimal amount
        {
            get => _amount;
            set => Set(ref _amount, value);
        }

        private decimal _vat_amt;
        public decimal vat_amt
        {
            get => _vat_amt;
            set => Set(ref _vat_amt, value);
        }

        private decimal _total_amt;
        public decimal total_amt
        {
            get => _total_amt;
            set => Set(ref _total_amt, value);
        }
    }
}
