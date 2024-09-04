using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR850_G10 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _doc_no;
        public string doc_no
        {
            get => _doc_no;
            set => Set(ref _doc_no, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _emp_name;
        public string emp_name
        {
            get => _emp_name;
            set => Set(ref _emp_name, value);
        }

        private string _emp_ename;
        public string emp_ename
        {
            get => _emp_ename;
            set => Set(ref _emp_ename, value);
        }

        private string _position;
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _job_class;
        public string job_class
        {
            get => _job_class;
            set => Set(ref _job_class, value);
        }

        private string _job_site;
        public string job_site
        {
            get => _job_site;
            set => Set(ref _job_site, value);
        }

        private DateTime _start_working_date;
        public DateTime start_working_date
        {
            get => _start_working_date;
            set => Set(ref _start_working_date, value);
        }

        private DateTime _employment_date;
        public DateTime employment_date
        {
            get => _employment_date;
            set => Set(ref _employment_date, value);
        }

        private string _emp_period;
        public string emp_period
        {
            get => _emp_period;
            set => Set(ref _emp_period, value);
        }

        private string _resign_type;
        public string resign_type
        {
            get => _resign_type;
            set => Set(ref _resign_type, value);
        }

        private DateTime _resign_date;
        public DateTime resign_date
        {
            get => _resign_date;
            set => Set(ref _resign_date, value);
        }

        private DateTime _notice_date;
        public DateTime notice_date
        {
            get => _notice_date;
            set => Set(ref _notice_date, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private int _severance_qty;
        public int severance_qty
        {
            get => _severance_qty;
            set => Set(ref _severance_qty, value);
        }

        private decimal _severance_amt;
        public decimal severance_amt
        {
            get => _severance_amt;
            set => Set(ref _severance_amt, value);
        }

        private DateTime _resign_calc_date;
        public DateTime resign_calc_date
        {
            get => _resign_calc_date;
            set => Set(ref _resign_calc_date, value);
        }

        private int _payment_seq;
        public int payment_seq
        {
            get => _payment_seq;
            set => Set(ref _payment_seq, value);
        }

        private string _resign_order_yn;
        public string resign_order_yn
        {
            get => _resign_order_yn;
            set => Set(ref _resign_order_yn, value);
        }

        private decimal _net_pay;
        public decimal net_pay
        {
            get => _net_pay;
            set => Set(ref _net_pay, value);
        }

        private decimal _settle_loan;
        public decimal settle_loan
        {
            get => _settle_loan;
            set => Set(ref _settle_loan, value);
        }

        private decimal _settle_etc;
        public decimal settle_etc
        {
            get => _settle_etc;
            set => Set(ref _settle_etc, value);
        }

        private string _settle_loan_voucher;
        public string settle_loan_voucher
        {
            get => _settle_loan_voucher;
            set => Set(ref _settle_loan_voucher, value);
        }

        private string _settle_etc_voucher;
        public string settle_etc_voucher
        {
            get => _settle_etc_voucher;
            set => Set(ref _settle_etc_voucher, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
