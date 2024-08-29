using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR160_G40 : EpicV004.Libs.MdlBase
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

        private DateTime _certificate_date;
        public DateTime certificate_date
        {
            get => _certificate_date;
            set => Set(ref _certificate_date, value);
        }

        private DateTime _expire_date;
        public DateTime expire_date
        {
            get => _expire_date;
            set => Set(ref _expire_date, value);
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
