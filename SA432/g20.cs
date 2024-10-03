using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA432_G20 : Libs.MdlBase
    {
        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private string _invoice_no;
        public string invoice_no
        {
            get => _invoice_no;
            set => Set(ref _invoice_no, value);
        }

        private int _seq;
        public int seq
        {
            get => _seq;
            set => Set(ref _seq, value);
        }

        private string _deduction_type;
        public string deduction_type
        {
            get => _deduction_type;
            set => Set(ref _deduction_type, value);
        }

        private string _subject;
        public string subject
        {
            get => _subject;
            set => Set(ref _subject, value);
        }

        private string _link_doc_no;
        public string link_doc_no
        {
            get => _link_doc_no;
            set => Set(ref _link_doc_no, value);
        }

        private decimal _ivc_amount;
        public decimal ivc_amount
        {
            get => _ivc_amount;
            set => Set(ref _ivc_amount, value);
        }

        private decimal _ratio;
        public decimal ratio
        {
            get => _ratio;
            set => Set(ref _ratio, value);
        }

        private decimal _amount;
        public decimal amount
        {
            get => _amount;
            set => Set(ref _amount, value);
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
