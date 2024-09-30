using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO250_G10 : EpicV004.Libs.MdlBase
    {
        private string _so_doc_no;
        public string so_doc_no
        {
            get => _so_doc_no;
            set => Set(ref _so_doc_no, value);
        }

        private DateTime _so_date;
        public DateTime so_date
        {
            get => _so_date;
            set => Set(ref _so_date, value);
        }

        private string _invoiceNo;
        public string invoiceNo
        {
            get => _invoiceNo;
            set => Set(ref _invoiceNo, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

    }
}
