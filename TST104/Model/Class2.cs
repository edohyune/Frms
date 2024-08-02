using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class TST104_F10 : EpicV004.Libs.MdlBase
    {
        private int _id;
        public int id
        {
            get => _id;
            set => Set(ref _id, value);
        }

        private string _first_name;
        public string first_name
        {
            get => _first_name;
            set => Set(ref _first_name, value);
        }

        private string _last_name;
        public string last_name
        {
            get => _last_name;
            set => Set(ref _last_name, value);
        }

        private string _eng_name;
        public string eng_name
        {
            get => _eng_name;
            set => Set(ref _eng_name, value);
        }

        private string _addr;
        public string addr
        {
            get => _addr;
            set => Set(ref _addr, value);
        }

        private string _gend;
        public string gend
        {
            get => _gend;
            set => Set(ref _gend, value);
        }

        private string _tell;
        public string tell
        {
            get => _tell;
            set => Set(ref _tell, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _type;
        public string type
        {
            get => _type;
            set => Set(ref _type, value);
        }

    }
}