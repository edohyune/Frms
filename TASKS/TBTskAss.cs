using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class TASKS_G20 : EpicV004.Libs.MdlBase
    {
        private int _Sq;
        public int Sq
        {
            get => _Sq;
            set => Set(ref _Sq, value);
        }

        private int _TskId;
        public int TskId
        {
            get => _TskId;
            set => Set(ref _TskId, value);
        }

        private int _UsrRegId;
        public int UsrRegId
        {
            get => _UsrRegId;
            set => Set(ref _UsrRegId, value);
        }

        private DateTime _AssDt;
        public DateTime AssDt
        {
            get => _AssDt;
            set => Set(ref _AssDt, value);
        }

        private int _AssUsr;
        public int AssUsr
        {
            get => _AssUsr;
            set => Set(ref _AssUsr, value);
        }
        private string _UsrNm;
        public string UsrNm
        {
            get => _UsrNm;
            set => Set(ref _UsrNm, value);
        }

        // Add private field for Class
        private string _Cls;
        public string Cls
        {
            get => _Cls;
            set => Set(ref _Cls, value);
        }
    }
}
