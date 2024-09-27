using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA100_G10 : Libs.MdlBase
    {
        private DateTime _bid_date;
        public DateTime bid_date
        {
            get => _bid_date;
            set => Set(ref _bid_date, value);
        }

        private string _cust_name;
        public string cust_name
        {
            get => _cust_name;
            set => Set(ref _cust_name, value);
        }

        private string _bid_no;
        public string bid_no
        {
            get => _bid_no;
            set => Set(ref _bid_no, value);
        }

        private string _project_name;
        public string project_name
        {
            get => _project_name;
            set => Set(ref _project_name, value);
        }

        private string _bugetary_status;
        public string bugetary_status
        {
            get => _bugetary_status;
            set => Set(ref _bugetary_status, value);
        }

        private string _rfq_status;
        public string rfq_status
        {
            get => _rfq_status;
            set => Set(ref _rfq_status, value);
        }

        private string _final_status;
        public string final_status
        {
            get => _final_status;
            set => Set(ref _final_status, value);
        }

        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private string _client;
        public string client
        {
            get => _client;
            set => Set(ref _client, value);
        }

        private string _sop_type;
        public string sop_type
        {
            get => _sop_type;
            set => Set(ref _sop_type, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

    }
}
