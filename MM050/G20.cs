using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class MM050_G20 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _req_no;
        public string req_no
        {
            get => _req_no;
            set => Set(ref _req_no, value);
        }

        private int _sq;
        public int sq
        {
            get => _sq;
            set => Set(ref _sq, value);
        }

        private string _item;
        public string item
        {
            get => _item;
            set => Set(ref _item, value);
        }

        private string _spec;
        public string spec
        {
            get => _spec;
            set => Set(ref _spec, value);
        }

        private decimal _qty;
        public decimal qty
        {
            get => _qty;
            set => Set(ref _qty, value);
        }

        private string _unit;
        public string unit
        {
            get => _unit;
            set => Set(ref _unit, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

    }
}
