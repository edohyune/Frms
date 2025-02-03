using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EpicV004.Frms
{
    public class SP172_G30 : EpicV004.Libs.MdlBase
    {
        private long _Id;
        public long Id
        {
            get => _Id;
            set => Set(ref _Id, value);
        }

        private string _En;
        public string En
        {
            get => _En;
            set => Set(ref _En, value);
        }

        private string _Kr;
        public string Kr
        {
            get => _Kr;
            set => Set(ref _Kr, value);
        }

        private string _La;
        public string La
        {
            get => _La;
            set => Set(ref _La, value);
        }

        private string _Ch;
        public string Ch
        {
            get => _Ch;
            set => Set(ref _Ch, value);
        }

        private string _Th;
        public string Th
        {
            get => _Th;
            set => Set(ref _Th, value);
        }

        private string _Vn;
        public string Vn
        {
            get => _Vn;
            set => Set(ref _Vn, value);
        }

        private string _UseYn;
        public string UseYn
        {
            get => _UseYn;
            set => Set(ref _UseYn, value);
        }
        private long _SId;
        public long SId
        {
            get => _SId;
            set => Set(ref _SId, value);
        }
        private long _WId;
        public long WId
        {
            get => _WId;
            set => Set(ref _WId, value);
        }

        private string _CId;
        public string CId
        {
            get => _CId;
            set => Set(ref _CId, value);
        }

        private string _MId;
        public string MId
        {
            get => _MId;
            set => Set(ref _MId, value);
        }

        private DateTime _CDt;
        public DateTime CDt
        {
            get => _CDt;
            set => Set(ref _CDt, value);
        }

        private DateTime _MDt;
        public DateTime MDt
        {
            get => _MDt;
            set => Set(ref _MDt, value);
        }

    
    }
}
