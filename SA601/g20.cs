using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA601_G20 : Libs.MdlBase
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

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _sop_group;
        public string sop_group
        {
            get => _sop_group;
            set => Set(ref _sop_group, value);
        }

        private string _bud_acc;
        public string bud_acc
        {
            get => _bud_acc;
            set => Set(ref _bud_acc, value);
        }

        private string _bud_name;
        public string bud_name
        {
            get => _bud_name;
            set => Set(ref _bud_name, value);
        }

        private decimal _bud_amount;
        public decimal bud_amount
        {
            get => _bud_amount;
            set => Set(ref _bud_amount, value);
        }

        private decimal _bud_ratio;
        public decimal bud_ratio
        {
            get => _bud_ratio;
            set => Set(ref _bud_ratio, value);
        }

        private decimal _used;
        public decimal used
        {
            get => _used;
            set => Set(ref _used, value);
        }

        private decimal _ratio;
        public decimal ratio
        {
            get => _ratio;
            set => Set(ref _ratio, value);
        }

        private decimal _remain;
        public decimal remain
        {
            get => _remain;
            set => Set(ref _remain, value);
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

        private string _int_status;
        public string int_status
        {
            get => _int_status;
            set => Set(ref _int_status, value);
        }

        private string _doc_no;
        public string doc_no
        {
            get => _doc_no;
            set => Set(ref _doc_no, value);
        }

    }
}
