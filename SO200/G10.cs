using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO200_G10 : EpicV004.Libs.MdlBase
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

        private string _sr_doc_no;
        public string sr_doc_no
        {
            get => _sr_doc_no;
            set => Set(ref _sr_doc_no, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _cust;
        public string cust
        {
            get => _cust;
            set => Set(ref _cust, value);
        }

        private string _cust_name;
        public string cust_name
        {
            get => _cust_name;
            set => Set(ref _cust_name, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _issue_name;
        public string issue_name
        {
            get => _issue_name;
            set => Set(ref _issue_name, value);
        }

        private string _nm;
        public string nm
        {
            get => _nm;
            set => Set(ref _nm, value);
        }

    }
}
