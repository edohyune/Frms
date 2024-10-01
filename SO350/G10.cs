using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO350_G10 : EpicV004.Libs.MdlBase
    {
        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _supplier;
        public string supplier
        {
            get => _supplier;
            set => Set(ref _supplier, value);
        }

        private string _supplier_name;
        public string supplier_name
        {
            get => _supplier_name;
            set => Set(ref _supplier_name, value);
        }

        private decimal _remain_amount;
        public decimal remain_amount
        {
            get => _remain_amount;
            set => Set(ref _remain_amount, value);
        }

    }
}
