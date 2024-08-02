using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class DPM200_G10 : EpicV004.Libs.MdlBase
    {
        private int _department_id;
        public int department_id
        {
            get => _department_id;
            set => Set(ref _department_id, value);
        }

        private string _department_name;
        public string department_name
        {
            get => _department_name;
            set => Set(ref _department_name, value);
        }

        private string _dept_dec;
        public string dept_dec
        {
            get => _dept_dec;
            set => Set(ref _dept_dec, value);
        }

    }
}