using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA601_G10 : Libs.MdlBase
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

        private decimal _sopAmount;
        public decimal sopAmount
        {
            get => _sopAmount;
            set => Set(ref _sopAmount, value);
        }

        private string _int_status;
        public string int_status
        {
            get => _int_status;
            set => Set(ref _int_status, value);
        }

        private decimal _bud_amount;
        public decimal bud_amount
        {
            get => _bud_amount;
            set => Set(ref _bud_amount, value);
        }

        private string _approval;
        public string approval
        {
            get => _approval;
            set => Set(ref _approval, value);
        }

        private string _cancel;
        public string cancel
        {
            get => _cancel;
            set => Set(ref _cancel, value);
        }

        private string _chk_status;
        public string chk_status
        {
            get => _chk_status;
            set => Set(ref _chk_status, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _sub_doc_no;
        public string sub_doc_no
        {
            get => _sub_doc_no;
            set => Set(ref _sub_doc_no, value);
        }

    }
}
