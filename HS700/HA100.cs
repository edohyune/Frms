using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HS700_G10 : Libs.MdlBase
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

        private string _ethnicity;
        public string ethnicity
        {
            get => _ethnicity;
            set => Set(ref _ethnicity, value);
        }

        private string _nationality;
        public string nationality
        {
            get => _nationality;
            set => Set(ref _nationality, value);
        }

        private string _current_postage;
        public string current_postage
        {
            get => _current_postage;
            set => Set(ref _current_postage, value);
        }

        private string _current_addr1;
        public string current_addr1
        {
            get => _current_addr1;
            set => Set(ref _current_addr1, value);
        }

        private decimal _height;
        public decimal height
        {
            get => _height;
            set => Set(ref _height, value);
        }

        private decimal _weight;
        public decimal weight
        {
            get => _weight;
            set => Set(ref _weight, value);
        }

        private string _emergency_contact_name;
        public string emergency_contact_name
        {
            get => _emergency_contact_name;
            set => Set(ref _emergency_contact_name, value);
        }

        private string _emergency_contact_postage;
        public string emergency_contact_postage
        {
            get => _emergency_contact_postage;
            set => Set(ref _emergency_contact_postage, value);
        }

        private string _emergency_contact_addr1;
        public string emergency_contact_addr1
        {
            get => _emergency_contact_addr1;
            set => Set(ref _emergency_contact_addr1, value);
        }

        private string _emergency_contact_tel_no;
        public string emergency_contact_tel_no
        {
            get => _emergency_contact_tel_no;
            set => Set(ref _emergency_contact_tel_no, value);
        }

        private string _emergency_contact_relation;
        public string emergency_contact_relation
        {
            get => _emergency_contact_relation;
            set => Set(ref _emergency_contact_relation, value);
        }

        private string _id_card_postage;
        public string id_card_postage
        {
            get => _id_card_postage;
            set => Set(ref _id_card_postage, value);
        }

        private string _id_card_addr1;
        public string id_card_addr1
        {
            get => _id_card_addr1;
            set => Set(ref _id_card_addr1, value);
        }
    }
}
