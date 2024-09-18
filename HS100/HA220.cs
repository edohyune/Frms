using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HS100_G10 : Libs.MdlBase
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

        private string _emp_name;
        public string emp_name
        {
            get => _emp_name;
            set => Set(ref _emp_name, value);
        }

        private string _position;
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
        }

        private int _seq;
        public int seq
        {
            get => _seq;
            set => Set(ref _seq, value);
        }

        private string _relation;
        public string relation
        {
            get => _relation;
            set => Set(ref _relation, value);
        }

        private string _title;
        public string title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private string _name;
        public string name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private string _other_lang_name;
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
        }

        private string _id_card_no;
        public string id_card_no
        {
            get => _id_card_no;
            set => Set(ref _id_card_no, value);
        }

        private string _occupation;
        public string occupation
        {
            get => _occupation;
            set => Set(ref _occupation, value);
        }

        private DateTime _birth_date;
        public DateTime birth_date
        {
            get => _birth_date;
            set => Set(ref _birth_date, value);
        }

        private string _tax_deduction;
        public string tax_deduction
        {
            get => _tax_deduction;
            set => Set(ref _tax_deduction, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
