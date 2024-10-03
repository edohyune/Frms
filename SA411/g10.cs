using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA411_G10 : Libs.MdlBase
    {
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

        private decimal _budget;
        public decimal budget
        {
            get => _budget;
            set => Set(ref _budget, value);
        }

        private string _int_status;
        public string int_status
        {
            get => _int_status;
            set => Set(ref _int_status, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

    }
}
