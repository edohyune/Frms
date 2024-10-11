using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR160_G10 : EpicV004.Libs.MdlBase
    {
        private string _kbn;
        public string kbn
        {
            get => _kbn;
            set => Set(ref _kbn, value);
        }

        private string _emp_category;
        public string emp_category
        {
            get => _emp_category;
            set => Set(ref _emp_category, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _gender;
        public string gender
        {
            get => _gender;
            set => Set(ref _gender, value);
        }

        private string _name;
        public string name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private string _name_eng;
        public string name_eng
        {
            get => _name_eng;
            set => Set(ref _name_eng, value);
        }

        private DateTime _emp_date;
        public DateTime emp_date
        {
            get => _emp_date;
            set => Set(ref _emp_date, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
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

        private string _upper_dept;
        public string upper_dept
        {
            get => _upper_dept;
            set => Set(ref _upper_dept, value);
        }

        private string _pkey;
        public string pkey
        {
            get => _pkey;
            set => Set(ref _pkey, value);
        }

        private string _dkey;
        public string dkey
        {
            get => _dkey;
            set => Set(ref _dkey, value);
        }


    }

    //public class HR160_F10 : HR160_G10
    //{
    //    // Additional properties or methods specific to AppRegister_G10
    //    private string _F10SpecificProperty;
    //    public string F10SpecificProperty
    //    {
    //        get => _F10SpecificProperty;
    //        set => Set(ref _F10SpecificProperty, value);
    //    }


    }

    //public class HR160_F20 : AppRegister_G10
    //{
    //    // Additional properties or methods specific to AppRegister_G10
    //    private string _F20SpecificProperty;
    //    public string F20SpecificProperty
    //    {
    //        get => _F20SpecificProperty;
    //        set => Set(ref _F20SpecificProperty, value);
    //    }


    //}
//}
