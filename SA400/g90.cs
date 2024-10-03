using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA400_G90 :EpicV004.Libs.MdlBase
    {
        private string _invoice_no;
        public string invoice_no
        {
            get => _invoice_no;
            set => Set(ref _invoice_no, value);
        }

        private string _invoice_type;
        public string invoice_type
        {
            get => _invoice_type;
            set => Set(ref _invoice_type, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private DateTime _invoice_date;
        public DateTime invoice_date
        {
            get => _invoice_date;
            set => Set(ref _invoice_date, value);
        }

        private DateTime _due_date;
        public DateTime due_date
        {
            get => _due_date;
            set => Set(ref _due_date, value);
        }

        private int _over_days;
        public int over_days
        {
            get => _over_days;
            set => Set(ref _over_days, value);
        }

        private decimal _invoice_amount;
        public decimal invoice_amount
        {
            get => _invoice_amount;
            set => Set(ref _invoice_amount, value);
        }

        private decimal _col_amount;
        public decimal col_amount
        {
            get => _col_amount;
            set => Set(ref _col_amount, value);
        }

        private decimal _balance;
        public decimal balance
        {
            get => _balance;
            set => Set(ref _balance, value);
        }
    }
}
