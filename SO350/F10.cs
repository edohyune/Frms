using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO350_F10 : EpicV004.Libs.MdlBase
    {
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

        private string _supplier;
        public string supplier
        {
            get => _supplier;
            set => Set(ref _supplier, value);
        }

        private string _supplier_name;
        public string supplier_name
        {
            get => _supplier_name;
            set => Set(ref _supplier_name, value);
        }

        private string _prj_currency;
        public string prj_currency
        {
            get => _prj_currency;
            set => Set(ref _prj_currency, value);
        }

        private decimal _prj_currencyRate;
        public decimal prj_currencyRate
        {
            get => _prj_currencyRate;
            set => Set(ref _prj_currencyRate, value);
        }

        private decimal _supplier_retention;
        public decimal supplier_retention
        {
            get => _supplier_retention;
            set => Set(ref _supplier_retention, value);
        }

        private decimal _paid_sum;
        public decimal paid_sum
        {
            get => _paid_sum;
            set => Set(ref _paid_sum, value);
        }

        private decimal _retention_balance;
        public decimal retention_balance
        {
            get => _retention_balance;
            set => Set(ref _retention_balance, value);
        }

    }
}
