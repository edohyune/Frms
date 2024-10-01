using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EpicV004.Frms
{
    public class SP172_G10 : EpicV004.Libs.MdlBase
    {
        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _dept_name;
        public string dept_name
        {
            get => _dept_name;
            set => Set(ref _dept_name, value);
        }

        private string _acc;
        public string acc
        {
            get => _acc;
            set => Set(ref _acc, value);
        }

        private string _acc_name;
        public string acc_name
        {
            get => _acc_name;
            set => Set(ref _acc_name, value);
        }

        private string _vc_no;
        public string vc_no
        {
            get => _vc_no;
            set => Set(ref _vc_no, value);
        }

        private DateTime _vc_date;
        public DateTime vc_date
        {
            get => _vc_date;
            set => Set(ref _vc_date, value);
        }

        private int _seq;
        public int seq
        {
            get => _seq;
            set => Set(ref _seq, value);
        }

        private string _line_memo;
        public string line_memo
        {
            get => _line_memo;
            set => Set(ref _line_memo, value);
        }

        private decimal _cost;
        public decimal cost
        {
            get => _cost;
            set => Set(ref _cost, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

    }
}
