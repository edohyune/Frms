using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA601_F10 : Libs.MdlBase
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

        private string _budget_requester;
        public string budget_requester
        {
            get => _budget_requester;
            set => Set(ref _budget_requester, value);
        }

        private string _requester_name;
        public string requester_name
        {
            get => _requester_name;
            set => Set(ref _requester_name, value);
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

        private decimal _currency_amount;
        public decimal currency_amount
        {
            get => _currency_amount;
            set => Set(ref _currency_amount, value);
        }

        private decimal _bud_amount;
        public decimal bud_amount
        {
            get => _bud_amount;
            set => Set(ref _bud_amount, value);
        }

        private decimal _ratio;
        public decimal ratio
        {
            get => _ratio;
            set => Set(ref _ratio, value);
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

        private string _save_txt;
        public string save_txt
        {
            get => _save_txt;
            set => Set(ref _save_txt, value);
        }

        private string _close_yn;
        public string close_yn
        {
            get => _close_yn;
            set => Set(ref _close_yn, value);
        }

    }
}
