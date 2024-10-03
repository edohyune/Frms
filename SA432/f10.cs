using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA432_F10 : Libs.MdlBase
    {
        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private DateTime _project_date;
        public DateTime project_date
        {
            get => _project_date;
            set => Set(ref _project_date, value);
        }

        private string _invoice_to;
        public string invoice_to
        {
            get => _invoice_to;
            set => Set(ref _invoice_to, value);
        }

        private string _invoice_to_name;
        public string invoice_to_name
        {
            get => _invoice_to_name;
            set => Set(ref _invoice_to_name, value);
        }

        private string _project_manager;
        public string project_manager
        {
            get => _project_manager;
            set => Set(ref _project_manager, value);
        }

        private string _manager_name;
        public string manager_name
        {
            get => _manager_name;
            set => Set(ref _manager_name, value);
        }

        private string _project_name;
        public string project_name
        {
            get => _project_name;
            set => Set(ref _project_name, value);
        }

        private string _category;
        public string category
        {
            get => _category;
            set => Set(ref _category, value);
        }

        private string _legacy_code;
        public string legacy_code
        {
            get => _legacy_code;
            set => Set(ref _legacy_code, value);
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

        private decimal _contract_amount;
        public decimal contract_amount
        {
            get => _contract_amount;
            set => Set(ref _contract_amount, value);
        }

        private decimal _amend_amount;
        public decimal amend_amount
        {
            get => _amend_amount;
            set => Set(ref _amend_amount, value);
        }

        private decimal _co_amount;
        public decimal co_amount
        {
            get => _co_amount;
            set => Set(ref _co_amount, value);
        }

        private decimal _total_project;
        public decimal total_project
        {
            get => _total_project;
            set => Set(ref _total_project, value);
        }

        private decimal _received_amount;
        public decimal received_amount
        {
            get => _received_amount;
            set => Set(ref _received_amount, value);
        }

        private decimal _remain_amount;
        public decimal remain_amount
        {
            get => _remain_amount;
            set => Set(ref _remain_amount, value);
        }

        private decimal _thb_equivalent;
        public decimal thb_equivalent
        {
            get => _thb_equivalent;
            set => Set(ref _thb_equivalent, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _budget_memo;
        public string budget_memo
        {
            get => _budget_memo;
            set => Set(ref _budget_memo, value);
        }

    }
}
