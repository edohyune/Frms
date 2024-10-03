using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO100_G10 : EpicV004.Libs.MdlBase
    {
        private string _srNoRev;
        public string srNoRev
        {
            get => _srNoRev;
            set => Set(ref _srNoRev, value);
        }

        private string _sr_doc_no;
        public string sr_doc_no
        {
            get => _sr_doc_no;
            set => Set(ref _sr_doc_no, value);
        }

        private DateTime _sr_date;
        public DateTime sr_date
        {
            get => _sr_date;
            set => Set(ref _sr_date, value);
        }

        private string _cust;
        public string cust
        {
            get => _cust;
            set => Set(ref _cust, value);
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

        private string _sr_rev;
        public string sr_rev
        {
            get => _sr_rev;
            set => Set(ref _sr_rev, value);
        }

    }
}
