using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SP110_G10 : EpicV004.Libs.MdlBase
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

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _category;
        public string category
        {
            get => _category;
            set => Set(ref _category, value);
        }

        private string _class_bc;
        public string class_bc
        {
            get => _class_bc;
            set => Set(ref _class_bc, value);
        }

        private string _project_name;
        public string project_name
        {
            get => _project_name;
            set => Set(ref _project_name, value);
        }

        private string _project_owner;
        public string project_owner
        {
            get => _project_owner;
            set => Set(ref _project_owner, value);
        }

        private string _project_location;
        public string project_location
        {
            get => _project_location;
            set => Set(ref _project_location, value);
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

        private string _payment_type;
        public string payment_type
        {
            get => _payment_type;
            set => Set(ref _payment_type, value);
        }

        private string _payment_term;
        public string payment_term
        {
            get => _payment_term;
            set => Set(ref _payment_term, value);
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

        private DateTime _period_fr;
        public DateTime period_fr
        {
            get => _period_fr;
            set => Set(ref _period_fr, value);
        }

        private DateTime _period_to;
        public DateTime period_to
        {
            get => _period_to;
            set => Set(ref _period_to, value);
        }

        private decimal _amount;
        public decimal amount
        {
            get => _amount;
            set => Set(ref _amount, value);
        }

        private decimal _currency_amount;
        public decimal currency_amount
        {
            get => _currency_amount;
            set => Set(ref _currency_amount, value);
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

        private decimal _total_amount;
        public decimal total_amount
        {
            get => _total_amount;
            set => Set(ref _total_amount, value);
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

        private string _delivery_company;
        public string delivery_company
        {
            get => _delivery_company;
            set => Set(ref _delivery_company, value);
        }

        private string _delivery_name;
        public string delivery_name
        {
            get => _delivery_name;
            set => Set(ref _delivery_name, value);
        }

        private string _delivery_term;
        public string delivery_term
        {
            get => _delivery_term;
            set => Set(ref _delivery_term, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _close_yn;
        public string close_yn
        {
            get => _close_yn;
            set => Set(ref _close_yn, value);
        }

        private string _division;
        public string division
        {
            get => _division;
            set => Set(ref _division, value);
        }

        private string _discipline;
        public string discipline
        {
            get => _discipline;
            set => Set(ref _discipline, value);
        }

    }
}
