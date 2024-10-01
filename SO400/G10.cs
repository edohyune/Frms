using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO400_G10 : EpicV004.Libs.MdlBase
    {
        private string _so_invoice_no;
        public string so_invoice_no
        {
            get => _so_invoice_no;
            set => Set(ref _so_invoice_no, value);
        }

        private DateTime _so_invoice_date;
        public DateTime so_invoice_date
        {
            get => _so_invoice_date;
            set => Set(ref _so_invoice_date, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _supplier;
        public string supplier
        {
            get => _supplier;
            set => Set(ref _supplier, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _cd_status;
        public string cd_status
        {
            get => _cd_status;
            set => Set(ref _cd_status, value);
        }

        private string _so_doc_no;
        public string so_doc_no
        {
            get => _so_doc_no;
            set => Set(ref _so_doc_no, value);
        }
    }
}
