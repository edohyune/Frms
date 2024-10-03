using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA411_F10: Libs.MdlBase
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

        private string _bud_acc;
        public string bud_acc
        {
            get => _bud_acc;
            set => Set(ref _bud_acc, value);
        }

        private decimal _bud_amount;
        public decimal bud_amount
        {
            get => _bud_amount;
            set => Set(ref _bud_amount, value);
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

        private decimal _pmt_amount;
        public decimal pmt_amount
        {
            get => _pmt_amount;
            set => Set(ref _pmt_amount, value);
        }

        private string _sub_doc_no;
        public string sub_doc_no
        {
            get => _sub_doc_no;
            set => Set(ref _sub_doc_no, value);
        }

    }
}
