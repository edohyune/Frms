using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR130_G40 : EpicV004.Libs.MdlBase
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

        private string _license_name;
        public string license_name
        {
            get => _license_name;
            set => Set(ref _license_name, value);
        }

        private string _license_no;
        public string license_no
        {
            get => _license_no;
            set => Set(ref _license_no, value);
        }

        private DateTime _certificate_dt;
        public DateTime certificate_dt
        {
            get => _certificate_dt;
            set => Set(ref _certificate_dt, value);
        }

        private DateTime _expire_dt;
        public DateTime expire_dt
        {
            get => _expire_dt;
            set => Set(ref _expire_dt, value);
        }

        private string _institution_issued;
        public string institution_issued
        {
            get => _institution_issued;
            set => Set(ref _institution_issued, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
