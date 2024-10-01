﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO400_G30 : EpicV004.Libs.MdlBase
    {
        private string _cn_no;
        public string cn_no
        {
            get => _cn_no;
            set => Set(ref _cn_no, value);
        }

        private DateTime _cn_date;
        public DateTime cn_date
        {
            get => _cn_date;
            set => Set(ref _cn_date, value);
        }

        private string _category;
        public string category
        {
            get => _category;
            set => Set(ref _category, value);
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

        private decimal _amount;
        public decimal amount
        {
            get => _amount;
            set => Set(ref _amount, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _so_invoice_no;
        public string so_invoice_no
        {
            get => _so_invoice_no;
            set => Set(ref _so_invoice_no, value);
        }

    }
}
