using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class FA700_G10 : Libs.MdlBase
    {

        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _yy;
        public string yy
        {
            get => _yy;
            set => Set(ref _yy, value);
        }

        private string _std_month;
        public string std_month
        {
            get => _std_month;
            set => Set(ref _std_month, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _emp_category;
        public string emp_category
        {
            get => _emp_category;
            set => Set(ref _emp_category, value);
        }
    }

    public class FA700_G20 : FA700_G10
    {
        // Additional properties or methods specific to AppRegister_G10
        private string _G20SpecificProperty;
        public string G20SpecificProperty
        {
            get => _G20SpecificProperty;
            set => Set(ref _G20SpecificProperty, value);
        }


    }
}
