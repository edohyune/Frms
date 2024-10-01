using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class MM050_G10 : EpicV004.Libs.MdlBase
    {
        private string _req_no;
        public string req_no
        {
            get => _req_no;
            set => Set(ref _req_no, value);
        }

        private DateTime _req_date;
        public DateTime req_date
        {
            get => _req_date;
            set => Set(ref _req_date, value);
        }

        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

    }
}
