using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR100_G10 : Libs.MdlBase
    {
        private DateTime _renewal_date;
        public DateTime renewal_date
        {
            get => _renewal_date;
            set => Set(ref _renewal_date, value);
        }

        private string _transfer_dept_master;
        public string transfer_dept_master
        {
            get => _transfer_dept_master;
            set => Set(ref _transfer_dept_master, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _apply_master;
        public string apply_master
        {
            get => _apply_master;
            set => Set(ref _apply_master, value);
        }
    }

    public class HR100_F10 : HR100_G10
    {
        // Additional properties or methods specific to HR100_G10
        private string _F10SpecificProperty;
        public string F10SpecificProperty
        {
            get => _F10SpecificProperty;
            set => Set(ref _F10SpecificProperty, value);
        }

    }
}
