using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR690_G80 : EpicV004.Libs.MdlBase
    {
        private decimal _prr_amt;
        public decimal prr_amt
        {
            get => _prr_amt;
            set => Set(ref _prr_amt, value);
        }

        private string _title;
        public string title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private string _first_name;
        public string first_name
        {
            get => _first_name;
            set => Set(ref _first_name, value);
        }

        private string _last_name;
        public string last_name
        {
            get => _last_name;
            set => Set(ref _last_name, value);
        }

        private string _prr_emp;
        public string prr_emp
        {
            get => _prr_emp;
            set => Set(ref _prr_emp, value);
        }

        private string _bank_account_no;
        public string bank_account_no
        {
            get => _bank_account_no;
            set => Set(ref _bank_account_no, value);
        }

        private string _bank_name;
        public string bank_name
        {
            get => _bank_name;
            set => Set(ref _bank_name, value);
        }

        private string _bank_nm;
        public string bank_nm
        {
            get => _bank_nm;
            set => Set(ref _bank_nm, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _dept_nick_name;
        public string dept_nick_name
        {
            get => _dept_nick_name;
            set => Set(ref _dept_nick_name, value);
        }
    }
}
