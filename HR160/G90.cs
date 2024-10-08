using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR160_G90 : EpicV004.Libs.MdlBase
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

        private string _warning_when;
        public string warning_when
        {
            get => _warning_when;
            set => Set(ref _warning_when, value);
        }

        private DateTime _warning_date;
        public DateTime warning_date
        {
            get => _warning_date;
            set => Set(ref _warning_date, value);
        }

        private string _warning_msg;
        public string warning_msg
        {
            get => _warning_msg;
            set => Set(ref _warning_msg, value);
        }

        private string _wtype;
        public string wtype
        {
            get => _wtype;
            set => Set(ref _wtype, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }
    }
}
