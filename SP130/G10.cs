using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SP130_G10 : EpicV004.Libs.MdlBase
    {
        private string _deposit_no;
        public string deposit_no
        {
            get => _deposit_no;
            set => Set(ref _deposit_no, value);
        }

        private DateTime _deposit_date;
        public DateTime deposit_date
        {
            get => _deposit_date;
            set => Set(ref _deposit_date, value);
        }

        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
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

        private long _no;
        public long no
        {
            get => _no;
            set => Set(ref _no, value);
        }

        private string _invoice_no;
        public string invoice_no
        {
            get => _invoice_no;
            set => Set(ref _invoice_no, value);
        }

        private DateTime _invoice_date;
        public DateTime invoice_date
        {
            get => _invoice_date;
            set => Set(ref _invoice_date, value);
        }

        private decimal _deposit_amount;
        public decimal deposit_amount
        {
            get => _deposit_amount;
            set => Set(ref _deposit_amount, value);
        }

        private decimal _used;
        public decimal used
        {
            get => _used;
            set => Set(ref _used, value);
        }

        private decimal _balance;
        public decimal balance
        {
            get => _balance;
            set => Set(ref _balance, value);
        }

    }
}
