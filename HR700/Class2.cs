using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR700_G20 : EpicV004.Libs.MdlBase
    {
        private string _other_lang_name;
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
        }

        private decimal _wdays;
        public decimal wdays
        {
            get => _wdays;
            set => Set(ref _wdays, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _dept_nm;
        public string dept_nm
        {
            get => _dept_nm;
            set => Set(ref _dept_nm, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private long _prr_key;
        public long prr_key
        {
            get => _prr_key;
            set => Set(ref _prr_key, value);
        }

        private string _prr_emp;
        public string prr_emp
        {
            get => _prr_emp;
            set => Set(ref _prr_emp, value);
        }

        private int _prr_prp;
        public int prr_prp
        {
            get => _prr_prp;
            set => Set(ref _prr_prp, value);
        }

        private DateTime _pay_date;
        public DateTime pay_date
        {
            get => _pay_date;
            set => Set(ref _pay_date, value);
        }

        private int _prr_df;
        public int prr_df
        {
            get => _prr_df;
            set => Set(ref _prr_df, value);
        }

        private int _prr_dept;
        public int prr_dept
        {
            get => _prr_dept;
            set => Set(ref _prr_dept, value);
        }

        private decimal _prr_qty;
        public decimal prr_qty
        {
            get => _prr_qty;
            set => Set(ref _prr_qty, value);
        }

        private decimal _prr_amt;
        public decimal prr_amt
        {
            get => _prr_amt;
            set => Set(ref _prr_amt, value);
        }

        private decimal _prr_values;
        public decimal prr_values
        {
            get => _prr_values;
            set => Set(ref _prr_values, value);
        }

        private decimal _prr_expense;
        public decimal prr_expense
        {
            get => _prr_expense;
            set => Set(ref _prr_expense, value);
        }

        private decimal _prr_crncy_amt;
        public decimal prr_crncy_amt
        {
            get => _prr_crncy_amt;
            set => Set(ref _prr_crncy_amt, value);
        }

        private decimal _prr_crncy_values;
        public decimal prr_crncy_values
        {
            get => _prr_crncy_values;
            set => Set(ref _prr_crncy_values, value);
        }

        private decimal _prr_times;
        public decimal prr_times
        {
            get => _prr_times;
            set => Set(ref _prr_times, value);
        }

        private int _prr_br;
        public int prr_br
        {
            get => _prr_br;
            set => Set(ref _prr_br, value);
        }

        private int _prr_sctn;
        public int prr_sctn
        {
            get => _prr_sctn;
            set => Set(ref _prr_sctn, value);
        }

        private int _prr_site;
        public int prr_site
        {
            get => _prr_site;
            set => Set(ref _prr_site, value);
        }

    }
}
