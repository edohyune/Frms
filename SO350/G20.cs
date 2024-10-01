using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO350_G20 : EpicV004.Libs.MdlBase
    {
        private string _release_no;
        public string release_no
        {
            get => _release_no;
            set => Set(ref _release_no, value);
        }

        private DateTime _release_date;
        public DateTime release_date
        {
            get => _release_date;
            set => Set(ref _release_date, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

    }
}
