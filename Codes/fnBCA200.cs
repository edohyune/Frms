using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class Codes_G20 : Libs.MdlBase
    {

        private string _base_cd;
        public string base_cd
        {
            get => _base_cd;
            set => Set(ref _base_cd, value);
        }

        private string _main_cd;
        public string main_cd
        {
            get => _main_cd;
            set => Set(ref _main_cd, value);
        }

        private string _sub_cd;
        public string sub_cd
        {
            get => _sub_cd;
            set => Set(ref _sub_cd, value);
        }

        private string _title;
        public string title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private int _ord_sq;
        public int ord_sq
        {
            get => _ord_sq;
            set => Set(ref _ord_sq, value);
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

        private string _old_cd;
        public string old_cd
        {
            get => _old_cd;
            set => Set(ref _old_cd, value);
        }

        private string _rmks;
        public string rmks
        {
            get => _rmks;
            set => Set(ref _rmks, value);
        }
    }
}
