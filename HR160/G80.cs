using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR160_G80 : EpicV004.Libs.MdlBase
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

        private DateTime _apply_date;
        public DateTime apply_date
        {
            get => _apply_date;
            set => Set(ref _apply_date, value);
        }

        private string _work_schedule;
        public string work_schedule
        {
            get => _work_schedule;
            set => Set(ref _work_schedule, value);
        }

        private string _doc_no;
        public string doc_no
        {
            get => _doc_no;
            set => Set(ref _doc_no, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _approval;
        public string approval
        {
            get => _approval;
            set => Set(ref _approval, value);
        }

        private string _approval_yn;
        public string approval_yn
        {
            get => _approval_yn;
            set => Set(ref _approval_yn, value);
        }
    }
}
