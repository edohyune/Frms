using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class Codes_G10 : Libs.MdlBase
    {

        private string _main_cd;
        public string main_cd
        {
            get => _main_cd;
            set => Set(ref _main_cd, value);
        }

        private string _title;
        public string title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private string _mdl_cd;
        public string mdl_cd
        {
            get => _mdl_cd;
            set => Set(ref _mdl_cd, value);
        }

        private string _grp_nm;
        public string grp_nm
        {
            get => _grp_nm;
            set => Set(ref _grp_nm, value);
        }

        private string _sort_bc;
        public string sort_bc
        {
            get => _sort_bc;
            set => Set(ref _sort_bc, value);
        }

        private string _user_yn;
        public string user_yn
        {
            get => _user_yn;
            set => Set(ref _user_yn, value);
        }

        private string _sys_yn;
        public string sys_yn
        {
            get => _sys_yn;
            set => Set(ref _sys_yn, value);
        }

        private string _use_yn;
        public string use_yn
        {
            get => _use_yn;
            set => Set(ref _use_yn, value);
        }

        private int _popup_id;
        public int popup_id
        {
            get => _popup_id;
            set => Set(ref _popup_id, value);
        }

        private string _rmks;
        public string rmks
        {
            get => _rmks;
            set => Set(ref _rmks, value);
        }
    }
}
