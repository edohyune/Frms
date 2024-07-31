using EpicV004.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class WorkSetSet_GRDWRKSET : MdlBase
    {
        private string _FrwId;
        public string FrwId
        {
            get => _FrwId;
            set => Set(ref _FrwId, value);
        }

        private string _FrmId;
        public string FrmId
        {
            get => _FrmId;
            set => Set(ref _FrmId, value);
        }

        private string _WrkId;
        public string WrkId
        {
            get => _WrkId;
            set => Set(ref _WrkId, value);
        }

        private string _FldNm;
        public string FldNm
        {
            get => _FldNm;
            set => Set(ref _FldNm, value);
        }

        private string _SetWrkId;
        public string SetWrkId
        {
            get => _SetWrkId;
            set => Set(ref _SetWrkId, value);
        }

        private string _SetFldNm;
        public string SetFldNm
        {
            get => _SetFldNm;
            set => Set(ref _SetFldNm, value);
        }

        private string _SetDefaultValue;
        public string SetDefaultValue
        {
            get => _SetDefaultValue;
            set => Set(ref _SetDefaultValue, value);
        }

        private string _SqlId;
        public string SqlId
        {
            get => _SqlId;
            set => Set(ref _SqlId, value);
        }

        private long _Id;
        public long Id
        {
            get => _Id;
            set => Set(ref _Id, value);
        }

        private long _Pid;
        public long Pid
        {
            get => _Pid;
            set => Set(ref _Pid, value);
        }
    }
}
