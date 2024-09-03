using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR620_G10 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private long _pra_key;
        public long pra_key
        {
            get => _pra_key;
            set => Set(ref _pra_key, value);
        }

        private string _pra_emp;
        public string pra_emp
        {
            get => _pra_emp;
            set => Set(ref _pra_emp, value);
        }

        private int _pra_df;
        public int pra_df
        {
            get => _pra_df;
            set => Set(ref _pra_df, value);
        }

        private decimal _pra_qty;
        public decimal pra_qty
        {
            get => _pra_qty;
            set => Set(ref _pra_qty, value);
        }

        private decimal _pra_expense;
        public decimal pra_expense
        {
            get => _pra_expense;
            set => Set(ref _pra_expense, value);
        }

        private DateTime _end_date;
        public DateTime end_date
        {
            get => _end_date;
            set => Set(ref _end_date, value);
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

        private string _dept_name;
        public string dept_name
        {
            get => _dept_name;
            set => Set(ref _dept_name, value);
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
    }
}
