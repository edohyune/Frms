using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA601_G30 : Libs.MdlBase
    {
        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private string _sub_doc_no;
        public string sub_doc_no
        {
            get => _sub_doc_no;
            set => Set(ref _sub_doc_no, value);
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

        private decimal _dept_amount;
        public decimal dept_amount
        {
            get => _dept_amount;
            set => Set(ref _dept_amount, value);
        }

        private decimal _dept_ratio;
        public decimal dept_ratio
        {
            get => _dept_ratio;
            set => Set(ref _dept_ratio, value);
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

    }
}
