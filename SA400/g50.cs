using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA400_G50 :EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private string _amend_no;
        public string amend_no
        {
            get => _amend_no;
            set => Set(ref _amend_no, value);
        }

        private DateTime _amend_date;
        public DateTime amend_date
        {
            get => _amend_date;
            set => Set(ref _amend_date, value);
        }

        private decimal _amend_amount;
        public decimal amend_amount
        {
            get => _amend_amount;
            set => Set(ref _amend_amount, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private decimal _currency_amount;
        public decimal currency_amount
        {
            get => _currency_amount;
            set => Set(ref _currency_amount, value);
        }

        private decimal _currency_rate;
        public decimal currency_rate
        {
            get => _currency_rate;
            set => Set(ref _currency_rate, value);
        }
    }
}
