using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR675_G20 : EpicV004.Libs.MdlBase
    {
        private DateTime _pay_date;
        public DateTime pay_date
        {
            get => _pay_date;
            set => Set(ref _pay_date, value);
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

        private string _dept_name;
        public string dept_name
        {
            get => _dept_name;
            set => Set(ref _dept_name, value);
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

        private decimal _erp_qty;
        public decimal erp_qty
        {
            get => _erp_qty;
            set => Set(ref _erp_qty, value);
        }

        private decimal _erp_amt;
        public decimal erp_amt
        {
            get => _erp_amt;
            set => Set(ref _erp_amt, value);
        }

        private decimal _legacy_qty;
        public decimal legacy_qty
        {
            get => _legacy_qty;
            set => Set(ref _legacy_qty, value);
        }

        private decimal _legacy_amt;
        public decimal legacy_amt
        {
            get => _legacy_amt;
            set => Set(ref _legacy_amt, value);
        }

        private decimal _diff;
        public decimal diff
        {
            get => _diff;
            set => Set(ref _diff, value);
        }

        private int _chk1;
        public int chk1
        {
            get => _chk1;
            set => Set(ref _chk1, value);
        }

        private int _chk2;
        public int chk2
        {
            get => _chk2;
            set => Set(ref _chk2, value);
        }
    }
}
