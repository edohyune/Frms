using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class USRMNU_G10 : EpicV004.Libs.MdlBase
    {
        private int _UsrRegId;
        public int UsrRegId
        {
            get => _UsrRegId;
            set => Set(ref _UsrRegId, value);
        }
        private string _Username;
        public string Username
        {
            get => _Username;
            set => Set(ref _Username, value);
        }

        private string _MnuId;
        public string MnuId
        {
            get => _MnuId;
            set => Set(ref _MnuId, value);
        }

        private string _MnuPid;
        public string MnuPid
        {
            get => _MnuPid;
            set => Set(ref _MnuPid, value);
        }

        private string _MnuNm;
        public string MnuNm
        {
            get => _MnuNm;
            set => Set(ref _MnuNm, value);
        }

        private int _FrwId;
        public int FrwId
        {
            get => _FrwId;
            set => Set(ref _FrwId, value);
        }

        private string _MnuTy;
        public string MnuTy
        {
            get => _MnuTy;
            set => Set(ref _MnuTy, value);
        }

        private string _FrmId;
        public string FrmId
        {
            get => _FrmId;
            set => Set(ref _FrmId, value);
        }

        private int _Id;
        public int Id
        {
            get => _Id;
            set => Set(ref _Id, value);
        }
    }
}
