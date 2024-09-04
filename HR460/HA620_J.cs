using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR460_G10 : Libs.MdlBase
    {
        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _name;
        public string name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private string _nick_name;
        public string nick_name
        {
            get => _nick_name;
            set => Set(ref _nick_name, value);
        }

        private string _other_lang_name;
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
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

        private string _leave_type;
        public string leave_type
        {
            get => _leave_type;
            set => Set(ref _leave_type, value);
        }

        private DateTime _leave_date;
        public DateTime leave_date
        {
            get => _leave_date;
            set => Set(ref _leave_date, value);
        }

        private decimal _leave_time;
        public decimal leave_time
        {
            get => _leave_time;
            set => Set(ref _leave_time, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _doc_no;
        public string doc_no
        {
            get => _doc_no;
            set => Set(ref _doc_no, value);
        }

        private string _mid;
        public string mid
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
