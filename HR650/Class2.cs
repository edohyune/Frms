using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR650_G20 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private long _prt_key;
        public long prt_key
        {
            get => _prt_key;
            set => Set(ref _prt_key, value);
        }

        private string _prt_emp;
        public string prt_emp
        {
            get => _prt_emp;
            set => Set(ref _prt_emp, value);
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

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _position;
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private int _prt_df;
        public int prt_df
        {
            get => _prt_df;
            set => Set(ref _prt_df, value);
        }

        private string _df_desc;
        public string df_desc
        {
            get => _df_desc;
            set => Set(ref _df_desc, value);
        }

        private string _df_e_desc;
        public string df_e_desc
        {
            get => _df_e_desc;
            set => Set(ref _df_e_desc, value);
        }

        private DateTime _prt_date;
        public DateTime prt_date
        {
            get => _prt_date;
            set => Set(ref _prt_date, value);
        }

        private DateTime _pay_date;
        public DateTime pay_date
        {
            get => _pay_date;
            set => Set(ref _pay_date, value);
        }

        private decimal _prt_qty;
        public decimal prt_qty
        {
            get => _prt_qty;
            set => Set(ref _prt_qty, value);
        }

        private decimal _prt_expense;
        public decimal prt_expense
        {
            get => _prt_expense;
            set => Set(ref _prt_expense, value);
        }

        private int _prt_dept_ex;
        public int prt_dept_ex
        {
            get => _prt_dept_ex;
            set => Set(ref _prt_dept_ex, value);
        }

        private string _prt_reason;
        public string prt_reason
        {
            get => _prt_reason;
            set => Set(ref _prt_reason, value);
        }

        private decimal _prt_times;
        public decimal prt_times
        {
            get => _prt_times;
            set => Set(ref _prt_times, value);
        }

        private int _prt_br_ex;
        public int prt_br_ex
        {
            get => _prt_br_ex;
            set => Set(ref _prt_br_ex, value);
        }

        private int _prt_sctn_ex;
        public int prt_sctn_ex
        {
            get => _prt_sctn_ex;
            set => Set(ref _prt_sctn_ex, value);
        }

        private int _prt_site_ex;
        public int prt_site_ex
        {
            get => _prt_site_ex;
            set => Set(ref _prt_site_ex, value);
        }

        private decimal _prt_terminate;
        public decimal prt_terminate
        {
            get => _prt_terminate;
            set => Set(ref _prt_terminate, value);
        }

        private decimal _prt_retire;
        public decimal prt_retire
        {
            get => _prt_retire;
            set => Set(ref _prt_retire, value);
        }

        private DateTime _prt_start_work;
        public DateTime prt_start_work
        {
            get => _prt_start_work;
            set => Set(ref _prt_start_work, value);
        }

        private string _flag;
        public string flag
        {
            get => _flag;
            set => Set(ref _flag, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private DateTime _mdt;
        public DateTime mdt
        {
            get => _mdt;
            set => Set(ref _mdt, value);
        }


        private int _mid;
        public int mid
        {
            get => _mid;
            set => Set(ref _mid, value);
        }

    }
}
