using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO100_F10 : EpicV004.Libs.MdlBase
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

        private DateTime _sr_sdate;
        public DateTime sr_sdate
        {
            get => _sr_sdate;
            set => Set(ref _sr_sdate, value);
        }

        private DateTime _sr_edate;
        public DateTime sr_edate
        {
            get => _sr_edate;
            set => Set(ref _sr_edate, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _issue_dept;
        public string issue_dept
        {
            get => _issue_dept;
            set => Set(ref _issue_dept, value);
        }

        private string _issue_deptName;
        public string issue_deptName
        {
            get => _issue_deptName;
            set => Set(ref _issue_deptName, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _project_name;
        public string project_name
        {
            get => _project_name;
            set => Set(ref _project_name, value);
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

        private string _note;
        public string note
        {
            get => _note;
            set => Set(ref _note, value);
        }

        private string _sr_rev;
        public string sr_rev
        {
            get => _sr_rev;
            set => Set(ref _sr_rev, value);
        }

        private DateTime _committee_date;
        public DateTime committee_date
        {
            get => _committee_date;
            set => Set(ref _committee_date, value);
        }

        private DateTime _so_need_date;
        public DateTime so_need_date
        {
            get => _so_need_date;
            set => Set(ref _so_need_date, value);
        }

        private string _sr_event;
        public string sr_event
        {
            get => _sr_event;
            set => Set(ref _sr_event, value);
        }

        private string _sr_category;
        public string sr_category
        {
            get => _sr_category;
            set => Set(ref _sr_category, value);
        }

        private string _sr_type;
        public string sr_type
        {
            get => _sr_type;
            set => Set(ref _sr_type, value);
        }

        private string _discipline;
        public string discipline
        {
            get => _discipline;
            set => Set(ref _discipline, value);
        }

        private string _location;
        public string location
        {
            get => _location;
            set => Set(ref _location, value);
        }

        private string _sr_contract_type;
        public string sr_contract_type
        {
            get => _sr_contract_type;
            set => Set(ref _sr_contract_type, value);
        }

        private string _sr_measurement_type;
        public string sr_measurement_type
        {
            get => _sr_measurement_type;
            set => Set(ref _sr_measurement_type, value);
        }

        private string _sr_guarantee_bank;
        public string sr_guarantee_bank
        {
            get => _sr_guarantee_bank;
            set => Set(ref _sr_guarantee_bank, value);
        }

        private decimal _sr_bank_per;
        public decimal sr_bank_per
        {
            get => _sr_bank_per;
            set => Set(ref _sr_bank_per, value);
        }

        private string _sr_guarantee_bond;
        public string sr_guarantee_bond
        {
            get => _sr_guarantee_bond;
            set => Set(ref _sr_guarantee_bond, value);
        }

        private decimal _sr_bond_per;
        public decimal sr_bond_per
        {
            get => _sr_bond_per;
            set => Set(ref _sr_bond_per, value);
        }

        private string _sr_guarantee_retention;
        public string sr_guarantee_retention
        {
            get => _sr_guarantee_retention;
            set => Set(ref _sr_guarantee_retention, value);
        }

        private decimal _sr_retention_per;
        public decimal sr_retention_per
        {
            get => _sr_retention_per;
            set => Set(ref _sr_retention_per, value);
        }

        private string _sr_guarantee_na;
        public string sr_guarantee_na
        {
            get => _sr_guarantee_na;
            set => Set(ref _sr_guarantee_na, value);
        }

        private string _currency;
        public string currency
        {
            get => _currency;
            set => Set(ref _currency, value);
        }

        private decimal _currency_rate;
        public decimal currency_rate
        {
            get => _currency_rate;
            set => Set(ref _currency_rate, value);
        }
    }
}
