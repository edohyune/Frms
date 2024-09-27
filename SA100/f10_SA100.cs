using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA100_F10 : Libs.MdlBase
    {
        private string _bid_no;
        public string bid_no
        {
            get => _bid_no;
            set => Set(ref _bid_no, value);
        }

        private string _rfq_no;
        public string rfq_no
        {
            get => _rfq_no;
            set => Set(ref _rfq_no, value);
        }

        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private DateTime _bid_date;
        public DateTime bid_date
        {
            get => _bid_date;
            set => Set(ref _bid_date, value);
        }

        private string _rev;
        public string rev
        {
            get => _rev;
            set => Set(ref _rev, value);
        }

        private int _validity;
        public int validity
        {
            get => _validity;
            set => Set(ref _validity, value);
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

        private string _project_owner;
        public string project_owner
        {
            get => _project_owner;
            set => Set(ref _project_owner, value);
        }

        private string _project_name;
        public string project_name
        {
            get => _project_name;
            set => Set(ref _project_name, value);
        }

        private string _project_location;
        public string project_location
        {
            get => _project_location;
            set => Set(ref _project_location, value);
        }

        private string _client;
        public string client
        {
            get => _client;
            set => Set(ref _client, value);
        }

        private string _client_name;
        public string client_name
        {
            get => _client_name;
            set => Set(ref _client_name, value);
        }

        private string _scope;
        public string scope
        {
            get => _scope;
            set => Set(ref _scope, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _invoice_to;
        public string invoice_to
        {
            get => _invoice_to;
            set => Set(ref _invoice_to, value);
        }

        private string _invoice_client;
        public string invoice_client
        {
            get => _invoice_client;
            set => Set(ref _invoice_client, value);
        }

        private string _invoice_addr;
        public string invoice_addr
        {
            get => _invoice_addr;
            set => Set(ref _invoice_addr, value);
        }

        private string _delivery_term;
        public string delivery_term
        {
            get => _delivery_term;
            set => Set(ref _delivery_term, value);
        }

        private string _delivery_company;
        public string delivery_company
        {
            get => _delivery_company;
            set => Set(ref _delivery_company, value);
        }

        private string _company_name;
        public string company_name
        {
            get => _company_name;
            set => Set(ref _company_name, value);
        }

        private string _company_addr;
        public string company_addr
        {
            get => _company_addr;
            set => Set(ref _company_addr, value);
        }

        private string _sop_type;
        public string sop_type
        {
            get => _sop_type;
            set => Set(ref _sop_type, value);
        }

    }
}
