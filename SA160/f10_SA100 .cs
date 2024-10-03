using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA160_F10 : EpicV004.Libs.MdlBase
    {
        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private string _final_project;
        public string final_project
        {
            get => _final_project;
            set => Set(ref _final_project, value);
        }

        private string _project_name;
        public string project_name
        {
            get => _project_name;
            set => Set(ref _project_name, value);
        }

        private string _project_location;
        public string project_location
        {
            get => _project_location;
            set => Set(ref _project_location, value);
        }

        private string _scope;
        public string scope
        {
            get => _scope;
            set => Set(ref _scope, value);
        }

        private string _project_owner;
        public string project_owner
        {
            get => _project_owner;
            set => Set(ref _project_owner, value);
        }

        private string _client;
        public string client
        {
            get => _client;
            set => Set(ref _client, value);
        }

        private string _client_name;
        public string client_name
        {
            get => _client_name;
            set => Set(ref _client_name, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _final_memo;
        public string final_memo
        {
            get => _final_memo;
            set => Set(ref _final_memo, value);
        }

    }
}
