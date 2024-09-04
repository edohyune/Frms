using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR410_G10 : Libs.MdlBase
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

        private string _training_type;
        public string training_type
        {
            get => _training_type;
            set => Set(ref _training_type, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _emp_nm;
        public string emp_nm
        {
            get => _emp_nm;
            set => Set(ref _emp_nm, value);
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

        private string _other_lang_name;
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
        }

        private string _course;
        public string course
        {
            get => _course;
            set => Set(ref _course, value);
        }

        private string _institution;
        public string institution
        {
            get => _institution;
            set => Set(ref _institution, value);
        }

        private decimal _score;
        public decimal score
        {
            get => _score;
            set => Set(ref _score, value);
        }

        private DateTime _from_date;
        public DateTime from_date
        {
            get => _from_date;
            set => Set(ref _from_date, value);
        }

        private DateTime _to_date;
        public DateTime to_date
        {
            get => _to_date;
            set => Set(ref _to_date, value);
        }

        private int _period;
        public int period
        {
            get => _period;
            set => Set(ref _period, value);
        }

        private decimal _expense;
        public decimal expense
        {
            get => _expense;
            set => Set(ref _expense, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _status1;
        public string status1
        {
            get => _status1;
            set => Set(ref _status1, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
