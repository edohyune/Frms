using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR420_G30 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _code;
        public string code
        {
            get => _code;
            set => Set(ref _code, value);
        }

        private string _area;
        public string area
        {
            get => _area;
            set => Set(ref _area, value);
        }

        private decimal _allowance_staff;
        public decimal allowance_staff
        {
            get => _allowance_staff;
            set => Set(ref _allowance_staff, value);
        }

        private decimal _allowance_manager;
        public decimal allowance_manager
        {
            get => _allowance_manager;
            set => Set(ref _allowance_manager, value);
        }

        private decimal _allowance_director;
        public decimal allowance_director
        {
            get => _allowance_director;
            set => Set(ref _allowance_director, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
