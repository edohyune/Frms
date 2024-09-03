using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR671_G40 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private long _pts_key;
        public long pts_key
        {
            get => _pts_key;
            set => Set(ref _pts_key, value);
        }

        private string _pts_emp;
        public string pts_emp
        {
            get => _pts_emp;
            set => Set(ref _pts_emp, value);
        }


        // ---------------Column from view uv_staff-------------
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

        private string _dept_ename;
        public string dept_ename
        {
            get => _dept_ename;
            set => Set(ref _dept_ename, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _position;
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
        }


        //-------------------------------------------------------------------

        //--------------------------------- Column in table HA810

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

        //--------------------------------- end
        private int _pts_prp;
        public int pts_prp
        {
            get => _pts_prp;
            set => Set(ref _pts_prp, value);
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

        private decimal _pts_amt_1;
        public decimal pts_amt_1
        {
            get => _pts_amt_1;
            set => Set(ref _pts_amt_1, value);
        }

        private decimal _pts_amt_2;
        public decimal pts_amt_2
        {
            get => _pts_amt_2;
            set => Set(ref _pts_amt_2, value);
        }

        private decimal _pts_amt_3;
        public decimal pts_amt_3
        {
            get => _pts_amt_3;
            set => Set(ref _pts_amt_3, value);
        }

        private decimal _pts_amt_4;
        public decimal pts_amt_4
        {
            get => _pts_amt_4;
            set => Set(ref _pts_amt_4, value);
        }

        private decimal _pts_amt_5;
        public decimal pts_amt_5
        {
            get => _pts_amt_5;
            set => Set(ref _pts_amt_5, value);
        }

        private decimal _pts_amt_6;
        public decimal pts_amt_6
        {
            get => _pts_amt_6;
            set => Set(ref _pts_amt_6, value);
        }

        private decimal _pts_amt_7;
        public decimal pts_amt_7
        {
            get => _pts_amt_7;
            set => Set(ref _pts_amt_7, value);
        }

        private decimal _pts_amt_8;
        public decimal pts_amt_8
        {
            get => _pts_amt_8;
            set => Set(ref _pts_amt_8, value);
        }

        private decimal _pts_amt_9;
        public decimal pts_amt_9
        {
            get => _pts_amt_9;
            set => Set(ref _pts_amt_9, value);
        }

        private decimal _pts_amt_a;
        public decimal pts_amt_a
        {
            get => _pts_amt_a;
            set => Set(ref _pts_amt_a, value);
        }

        private decimal _pts_amt_b;
        public decimal pts_amt_b
        {
            get => _pts_amt_b;
            set => Set(ref _pts_amt_b, value);
        }

        private decimal _pts_amt_c;
        public decimal pts_amt_c
        {
            get => _pts_amt_c;
            set => Set(ref _pts_amt_c, value);
        }

        private string _pts_year_e;
        public string pts_year_e
        {
            get => _pts_year_e;
            set => Set(ref _pts_year_e, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private DateTime _pay_date;
        public DateTime pay_date
        {
            get => _pay_date;
            set => Set(ref _pay_date, value);
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
