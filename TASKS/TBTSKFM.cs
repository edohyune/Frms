using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class TASKS_G30 : EpicV004.Libs.MdlBase
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

        private string _FrmId;
        public string FrmId
        {
            get => _FrmId;
            set => Set(ref _FrmId, value);
        }

        private string _FrmNm;
        public string FrmNm
        {
            get => _FrmNm;
            set => Set(ref _FrmNm, value);
        }
        private string _FileNm;
        public string FileNm
        {
            get => _FileNm;
            set => Set(ref _FileNm, value);
        }

    }
}
