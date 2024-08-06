using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class URT_G10 : EpicV004.Libs.MdlBase
    {
        private int _UsrRegId;
        public int UsrRegId
        {
            get => _UsrRegId;
            set => Set(ref _UsrRegId, value);
        }

        private string _UsrId;
        public string UsrId
        {
            get => _UsrId;
            set => Set(ref _UsrId, value);
        }

        private string _UsrNm;
        public string UsrNm
        {
            get => _UsrNm;
            set => Set(ref _UsrNm, value);
        }

        private string _Pwd;
        public string Pwd
        {
            get => _Pwd;
            set => Set(ref _Pwd, value);
        }

        private string _Cls;
        public string Cls
        {
            get => _Cls;
            set => Set(ref _Cls, value);
        }
    }
}
