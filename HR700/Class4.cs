using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR700_G40 : EpicV004.Libs.MdlBase
    {
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

        private int _prp_year;
        public int prp_year
        {
            get => _prp_year;
            set => Set(ref _prp_year, value);
        }

        private int _prp_month;
        public int prp_month
        {
            get => _prp_month;
            set => Set(ref _prp_month, value);
        }

        private DateTime _prp_paydate;
        public DateTime prp_paydate
        {
            get => _prp_paydate;
            set => Set(ref _prp_paydate, value);
        }

        private DateTime _prp_st_date;
        public DateTime prp_st_date
        {
            get => _prp_st_date;
            set => Set(ref _prp_st_date, value);
        }

        private DateTime _prp_en_date;
        public DateTime prp_en_date
        {
            get => _prp_en_date;
            set => Set(ref _prp_en_date, value);
        }

        private string _prr_emp;
        public string prr_emp
        {
            get => _prr_emp;
            set => Set(ref _prr_emp, value);
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

        private int _prr_prp;
        public int prr_prp
        {
            get => _prr_prp;
            set => Set(ref _prr_prp, value);
        }

        private int _prr_df;
        public int prr_df
        {
            get => _prr_df;
            set => Set(ref _prr_df, value);
        }

        private string _df_e_desc;
        public string df_e_desc
        {
            get => _df_e_desc;
            set => Set(ref _df_e_desc, value);
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

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private int _mid;
        public int mid
        {
            get => _mid;
            set => Set(ref _mid, value);
        }

        private DateTime _mdt;
        public DateTime mdt
        {
            get => _mdt;
            set => Set(ref _mdt, value);
        }

    }
}
