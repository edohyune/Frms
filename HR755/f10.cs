using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR755_F10 : Libs.MdlBase
    {
        private string _doc_no;
        public string doc_no
        {
            get => _doc_no;
            set => Set(ref _doc_no, value);
        }

        private DateTime _terminate_date;
        public DateTime terminate_date
        {
            get => _terminate_date;
            set => Set(ref _terminate_date, value);
        }

        //private DateTime _pay_date;
        //public DateTime pay_date
        //{
        //    get => _pay_date;
        //    set => Set(ref _pay_date, value);
        //}

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _hr_status;
        public string hr_status
        {
            get => _hr_status;
            set => Set(ref _hr_status, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
    }
