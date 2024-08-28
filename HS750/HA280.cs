using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HS750_G10 : Libs.MdlBase
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

        //-------------------------- Column in View uv_staff. Column Name is: 

        private string _emp_name; // emp_name=b.emp_name
        public string emp_name
        {
            get => _emp_name;
            set => Set(ref _emp_name, value);
        }

        private string _dept; // dept 
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _dept_nm; // dept_nm = dbo.fndeptnm_epic2(b.dept)
        public string dept_nm
        {
            get => _dept_nm;
            set => Set(ref _dept_nm, value);
        }


        private string _position; // position
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
        }

        private string _other_lang_name; // other_lang_name
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
        }
        //----------------------------------------------------------------------- end

        private int _seq;
        public int seq
        {
            get => _seq;
            set => Set(ref _seq, value);
        }

        private string _warning_when;
        public string warning_when
        {
            get => _warning_when;
            set => Set(ref _warning_when, value);
        }

        private DateTime _warning_date;
        public DateTime warning_date
        {
            get => _warning_date;
            set => Set(ref _warning_date, value);
        }

        private string _warning_msg;
        public string warning_msg
        {
            get => _warning_msg;
            set => Set(ref _warning_msg, value);
        }
    }
}
