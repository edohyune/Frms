using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class DPM100_G10 : EpicV004.Libs.MdlBase
    {
        private long _Id;
        public long Id
        {
            get => _Id;
            set => Set(ref _Id, value);
        }

        private string _Sys_cd;
        public string Sys_cd
        {
            get => _Sys_cd;
            set => Set(ref _Sys_cd, value);
        }

        private string _Frm_id;
        public string Frm_id
        {
            get => _Frm_id;
            set => Set(ref _Frm_id, value);
        }

        private string _Frm_nm;
        public string Frm_nm
        {
            get => _Frm_nm;
            set => Set(ref _Frm_nm, value);
        }

        private string _Frm_ty;
        public string Frm_ty
        {
            get => _Frm_ty;
            set => Set(ref _Frm_ty, value);
        }

        private string _Hide_chk;
        public string Hide_chk
        {
            get => _Hide_chk;
            set => Set(ref _Hide_chk, value);
        }

        private string _Use_chk;
        public string Use_chk
        {
            get => _Use_chk;
            set => Set(ref _Use_chk, value);
        }

        private string _Memo;
        public string Memo
        {
            get => _Memo;
            set => Set(ref _Memo, value);
        }

    }
}