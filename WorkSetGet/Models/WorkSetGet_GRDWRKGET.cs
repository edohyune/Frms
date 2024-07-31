using EpicV004.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class WorkSetGet_GRDWRKGET : MdlBase
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

        private string _GetWrkId;
        public string GetWrkId
        {
            get => _GetWrkId;
            set => Set(ref _GetWrkId, value);
        }

        private string _GetFldNm;
        public string GetFldNm
        {
            get => _GetFldNm;
            set => Set(ref _GetFldNm, value);
        }

        private string _GetDefaultValue;
        public string GetDefaultValue
        {
            get => _GetDefaultValue;
            set => Set(ref _GetDefaultValue, value);
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

        private long _PId;
        public long PId
        {
            get => _PId;
            set => Set(ref _PId, value);
        }
    }
}
