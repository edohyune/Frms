using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA160_G30 : Libs.MdlBase
    {
        private string _final_project;
        public string final_project
        {
            get => _final_project;
            set => Set(ref _final_project, value);
        }

        private DateTime _bid_date;
        public DateTime bid_date
        {
            get => _bid_date;
            set => Set(ref _bid_date, value);
        }

        private string _bid_no;
        public string bid_no
        {
            get => _bid_no;
            set => Set(ref _bid_no, value);
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
