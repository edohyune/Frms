using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HS200_G10 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        //-------------------------- Column in table HA100. Column Name is: other_lang_name As emp_name

        private string _emp_name;
        public string emp_name
        {
            get => _emp_name;
            set => Set(ref _emp_name, value);
        }
        //--------------------------------------------------------- end

        //------------------------Column in table HA100. Column Name is: dept, dept_nm = dbo.fndeptnm_epic2(b.dept) and position
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


        private string _position;
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
        }
 //----------------------------------------------------------------------- end

        private int _seq;
        public int seq
        {
            get => _seq;
            set => Set(ref _seq, value);
        }

        private string _level;
        public string level
        {
            get => _level;
            set => Set(ref _level, value);
        }

        private string _Institution_name;
        public string Institution_name
        {
            get => _Institution_name;
            set => Set(ref _Institution_name, value);
        }

        private string _year_end;
        public string year_end
        {
            get => _year_end;
            set => Set(ref _year_end, value);
        }

        private string _major;
        public string major
        {
            get => _major;
            set => Set(ref _major, value);
        }

        private string _quali_rcvd;
        public string quali_rcvd
        {
            get => _quali_rcvd;
            set => Set(ref _quali_rcvd, value);
        }

        private decimal _grade;
        public decimal grade
        {
            get => _grade;
            set => Set(ref _grade, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
