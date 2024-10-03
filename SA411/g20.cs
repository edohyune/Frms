using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA411_G20 : EpicV004.Libs.MdlBase
    {
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

        private decimal _pmt_amount;
        public decimal pmt_amount
        {
            get => _pmt_amount;
            set => Set(ref _pmt_amount, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

    }
}
