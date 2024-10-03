using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO100_G20 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _sr_doc_no;
        public string sr_doc_no
        {
            get => _sr_doc_no;
            set => Set(ref _sr_doc_no, value);
        }

        private string _sr_rev;
        public string sr_rev
        {
            get => _sr_rev;
            set => Set(ref _sr_rev, value);
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

        private decimal _mh_ton;
        public decimal mh_ton
        {
            get => _mh_ton;
            set => Set(ref _mh_ton, value);
        }

        private decimal _mh_total;
        public decimal mh_total
        {
            get => _mh_total;
            set => Set(ref _mh_total, value);
        }

        private string _unit;
        public string unit
        {
            get => _unit;
            set => Set(ref _unit, value);
        }

        private decimal _qty;
        public decimal qty
        {
            get => _qty;
            set => Set(ref _qty, value);
        }

        private decimal _price;
        public decimal price
        {
            get => _price;
            set => Set(ref _price, value);
        }

        private decimal _amount;
        public decimal amount
        {
            get => _amount;
            set => Set(ref _amount, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
