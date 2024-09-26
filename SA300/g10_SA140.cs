using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
   public class SA300_G10 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _temp_cd;
        public string temp_cd
        {
            get => _temp_cd;
            set => Set(ref _temp_cd, value);
        }

        private string _temp_name;
        public string temp_name
        {
            get => _temp_name;
            set => Set(ref _temp_name, value);
        }

        private string _category;
        public string category
        {
            get => _category;
            set => Set(ref _category, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _yn_deleted;
        public string yn_deleted
        {
            get => _yn_deleted;
            set => Set(ref _yn_deleted, value);
        }
    }
    public class SA300_F10 : SA300_G10
    {
        //private string _F20SpecificProperty;
        //public string F20SpecificProperty
        //{
        //    get => _F20SpecificProperty;
        //    set => Set(ref _F20SpecificProperty, value);
        //}

    }
}
