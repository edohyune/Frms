using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA601_G00 : Libs.MdlBase
    {
        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private string _project_name;
        public string project_name
        {
            get => _project_name;
            set => Set(ref _project_name, value);
        }

        private DateTime _project_date;
        public DateTime project_date
        {
            get => _project_date;
            set => Set(ref _project_date, value);
        }

        private string _close_yn;
        public string close_yn
        {
            get => _close_yn;
            set => Set(ref _close_yn, value);
        }

        private string _project_manager;
        public string project_manager
        {
            get => _project_manager;
            set => Set(ref _project_manager, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _legacy_code;
        public string legacy_code
        {
            get => _legacy_code;
            set => Set(ref _legacy_code, value);
        }

        private string _gridColor;
        public string gridColor
        {
            get => _gridColor;
            set => Set(ref _gridColor, value);
        }

    }
}
