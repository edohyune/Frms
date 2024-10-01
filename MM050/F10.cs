using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class MM050_F10 : EpicV004.Libs.MdlBase
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

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _division;
        public string division
        {
            get => _division;
            set => Set(ref _division, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _internal_bc;
        public string internal_bc
        {
            get => _internal_bc;
            set => Set(ref _internal_bc, value);
        }

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

        private string _note;
        public string note
        {
            get => _note;
            set => Set(ref _note, value);
        }

        private string _conditions;
        public string conditions
        {
            get => _conditions;
            set => Set(ref _conditions, value);
        }

        private string _attatchment;
        public string attatchment
        {
            get => _attatchment;
            set => Set(ref _attatchment, value);
        }

    }
}
