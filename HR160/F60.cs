using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR160_F60 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _fund_account_no;
        public string fund_account_no
        {
            get => _fund_account_no;
            set => Set(ref _fund_account_no, value);
        }

        private DateTime _application_date;
        public DateTime application_date
        {
            get => _application_date;
            set => Set(ref _application_date, value);
        }

        private decimal _collector_cnt;
        public decimal collector_cnt
        {
            get => _collector_cnt;
            set => Set(ref _collector_cnt, value);
        }

        private DateTime _start_date;
        public DateTime start_date
        {
            get => _start_date;
            set => Set(ref _start_date, value);
        }

        private decimal _fund_acc_prev_year;
        public decimal fund_acc_prev_year
        {
            get => _fund_acc_prev_year;
            set => Set(ref _fund_acc_prev_year, value);
        }

        private decimal _cmpy_contribute_cnt;
        public decimal cmpy_contribute_cnt
        {
            get => _cmpy_contribute_cnt;
            set => Set(ref _cmpy_contribute_cnt, value);
        }

        private DateTime _cmpy_start_date;
        public DateTime cmpy_start_date
        {
            get => _cmpy_start_date;
            set => Set(ref _cmpy_start_date, value);
        }

        private decimal _cmpy_fund_prev_year;
        public decimal cmpy_fund_prev_year
        {
            get => _cmpy_fund_prev_year;
            set => Set(ref _cmpy_fund_prev_year, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
