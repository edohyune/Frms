using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR720_G20 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _contract_no;
        public string contract_no
        {
            get => _contract_no;
            set => Set(ref _contract_no, value);
        }

        private int _seq;
        public int seq
        {
            get => _seq;
            set => Set(ref _seq, value);
        }

        private DateTime _schedule_date;
        public DateTime schedule_date
        {
            get => _schedule_date;
            set => Set(ref _schedule_date, value);
        }

        private decimal _principal;
        public decimal principal
        {
            get => _principal;
            set => Set(ref _principal, value);
        }

        private decimal _interst;
        public decimal interst
        {
            get => _interst;
            set => Set(ref _interst, value);
        }

        private string _salaryMonth;
        public string salaryMonth
        {
            get => _salaryMonth;
            set => Set(ref _salaryMonth, value);
        }

        private decimal _total;
        public decimal total
        {
            get => _total;
            set => Set(ref _total, value);
        }

        private string _deduct_salary;
        public string deduct_salary
        {
            get => _deduct_salary;
            set => Set(ref _deduct_salary, value);
        }

        private string _mid;
        public string mid
        {
            get => _mid;
            set => Set(ref _mid, value);
        }

        private DateTime _mdt;
        public DateTime mdt
        {
            get => _mdt;
            set => Set(ref _mdt, value);
        }
    }
}
