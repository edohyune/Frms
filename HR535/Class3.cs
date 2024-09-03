using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR535_G30 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _tmt_emp;
        public string tmt_emp
        {
            get => _tmt_emp;
            set => Set(ref _tmt_emp, value);
        }

        private DateTime _tmt_date;
        public DateTime tmt_date
        {
            get => _tmt_date;
            set => Set(ref _tmt_date, value);
        }

        private string _tmt_in;
        public string tmt_in
        {
            get => _tmt_in;
            set => Set(ref _tmt_in, value);
        }

        private string _tmt_out;
        public string tmt_out
        {
            get => _tmt_out;
            set => Set(ref _tmt_out, value);
        }

        private string _upload_yn;
        public string upload_yn
        {
            get => _upload_yn;
            set => Set(ref _upload_yn, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
