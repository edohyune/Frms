using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR675_G30 : EpicV004.Libs.MdlBase
    {
        private string _gbn;
        public string gbn
        {
            get => _gbn;
            set => Set(ref _gbn, value);
        }

        private DateTime _pay_date;
        public DateTime pay_date
        {
            get => _pay_date;
            set => Set(ref _pay_date, value);
        }

        private string _pts_emp;
        public string pts_emp
        {
            get => _pts_emp;
            set => Set(ref _pts_emp, value);
        }

        private string _emp_name;
        public string emp_name
        {
            get => _emp_name;
            set => Set(ref _emp_name, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private DateTime _start_working_date;
        public DateTime start_working_date
        {
            get => _start_working_date;
            set => Set(ref _start_working_date, value);
        }

        private DateTime _resign_date;
        public DateTime resign_date
        {
            get => _resign_date;
            set => Set(ref _resign_date, value);
        }

        private int _pts_seq;
        public int pts_seq
        {
            get => _pts_seq;
            set => Set(ref _pts_seq, value);
        }

        private int _pts_step;
        public int pts_step
        {
            get => _pts_step;
            set => Set(ref _pts_step, value);
        }

        private string _pts_desc;
        public string pts_desc
        {
            get => _pts_desc;
            set => Set(ref _pts_desc, value);
        }

        private decimal _erp_amt;
        public decimal erp_amt
        {
            get => _erp_amt;
            set => Set(ref _erp_amt, value);
        }

        private decimal _bplus_amt;
        public decimal bplus_amt
        {
            get => _bplus_amt;
            set => Set(ref _bplus_amt, value);
        }

        private decimal _pts_amt_1;
        public decimal pts_amt_1
        {
            get => _pts_amt_1;
            set => Set(ref _pts_amt_1, value);
        }

        private decimal _pts_amt_11;
        public decimal pts_amt_11
        {
            get => _pts_amt_11;
            set => Set(ref _pts_amt_11, value);
        }

        private decimal _pts_amt_2;
        public decimal pts_amt_2
        {
            get => _pts_amt_2;
            set => Set(ref _pts_amt_2, value);
        }

        private decimal _pts_amt_21;
        public decimal pts_amt_21
        {
            get => _pts_amt_21;
            set => Set(ref _pts_amt_21, value);
        }

        private decimal _pts_amt_3;
        public decimal pts_amt_3
        {
            get => _pts_amt_3;
            set => Set(ref _pts_amt_3, value);
        }

        private decimal _pts_amt_31;
        public decimal pts_amt_31
        {
            get => _pts_amt_31;
            set => Set(ref _pts_amt_31, value);
        }

        private decimal _pts_amt_4;
        public decimal pts_amt_4
        {
            get => _pts_amt_4;
            set => Set(ref _pts_amt_4, value);
        }

        private decimal _pts_amt_41;
        public decimal pts_amt_41
        {
            get => _pts_amt_41;
            set => Set(ref _pts_amt_41, value);
        }

        private decimal _pts_amt_5;
        public decimal pts_amt_5
        {
            get => _pts_amt_5;
            set => Set(ref _pts_amt_5, value);
        }

        private decimal _pts_amt_51;
        public decimal pts_amt_51
        {
            get => _pts_amt_51;
            set => Set(ref _pts_amt_51, value);
        }

        private decimal _pts_amt_6;
        public decimal pts_amt_6
        {
            get => _pts_amt_6;
            set => Set(ref _pts_amt_6, value);
        }

        private decimal _pts_amt_61;
        public decimal pts_amt_61
        {
            get => _pts_amt_61;
            set => Set(ref _pts_amt_61, value);
        }

        private decimal _pts_amt_c;
        public decimal pts_amt_c
        {
            get => _pts_amt_c;
            set => Set(ref _pts_amt_c, value);
        }

        private decimal _pts_amt_c1;
        public decimal pts_amt_c1
        {
            get => _pts_amt_c1;
            set => Set(ref _pts_amt_c1, value);
        }

        private DateTime _mdt1;
        public DateTime mdt1
        {
            get => _mdt1;
            set => Set(ref _mdt1, value);
        }

        private string _chkt;
        public string chkt
        {
            get => _chkt;
            set => Set(ref _chkt, value);
        }

        private string _chk1;
        public string chk1
        {
            get => _chk1;
            set => Set(ref _chk1, value);
        }

        private string _chk2;
        public string chk2
        {
            get => _chk2;
            set => Set(ref _chk2, value);
        }

        private string _chk3;
        public string chk3
        {
            get => _chk3;
            set => Set(ref _chk3, value);
        }

        private string _chk_erpbplus;
        public string chk_erpbplus
        {
            get => _chk_erpbplus;
            set => Set(ref _chk_erpbplus, value);
        }
    }
}
