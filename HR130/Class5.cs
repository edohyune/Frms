using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR130_G50 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _applicant_id;
        public string applicant_id
        {
            get => _applicant_id;
            set => Set(ref _applicant_id, value);
        }

        private int _seq;
        public int seq
        {
            get => _seq;
            set => Set(ref _seq, value);
        }

        private string _company_name;
        public string company_name
        {
            get => _company_name;
            set => Set(ref _company_name, value);
        }

        private DateTime _since_dt;
        public DateTime since_dt
        {
            get => _since_dt;
            set => Set(ref _since_dt, value);
        }

        private DateTime _end_dt;
        public DateTime end_dt
        {
            get => _end_dt;
            set => Set(ref _end_dt, value);
        }

        private string _job_title;
        public string job_title
        {
            get => _job_title;
            set => Set(ref _job_title, value);
        }

        private string _responsible_work;
        public string responsible_work
        {
            get => _responsible_work;
            set => Set(ref _responsible_work, value);
        }

        private decimal _salary;
        public decimal salary
        {
            get => _salary;
            set => Set(ref _salary, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _period;
        public string period
        {
            get => _period;
            set => Set(ref _period, value);
        }
    }
}
