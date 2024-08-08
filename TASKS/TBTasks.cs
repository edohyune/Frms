using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class TASKS_G10 : EpicV004.Libs.MdlBase
    {
        private int _TskId;
        public int TskId
        {
            get => _TskId;
            set => Set(ref _TskId, value);
        }

        private string _TskNm;
        public string TskNm
        {
            get => _TskNm;
            set => Set(ref _TskNm, value);
        }

        private string _TskDes;
        public string TskDes
        {
            get => _TskDes;
            set => Set(ref _TskDes, value);
        }

        private DateTime _TskDtDue;
        public DateTime TskDtDue
        {
            get => _TskDtDue;
            set => Set(ref _TskDtDue, value);
        }

        private DateTime _TskDtEnd;
        public DateTime TskDtEnd
        {
            get => _TskDtEnd;
            set => Set(ref _TskDtEnd, value);
        }

        private string _TskStatus;
        public string TskStatus
        {
            get => _TskStatus;
            set => Set(ref _TskStatus, value);
        }

        private int _TskPriority;
        public int TskPriority
        {
            get => _TskPriority;
            set => Set(ref _TskPriority, value);
        }

        private string _TskLoc;
        public string TskLoc
        {
            get => _TskLoc;
            set => Set(ref _TskLoc, value);
        }

        private int _TskClient;
        public int TskClient
        {
            get => _TskClient;
            set => Set(ref _TskClient, value);
        }

        private int _PrjId;
        public int PrjId
        {
            get => _PrjId;
            set => Set(ref _PrjId, value);
        }
    }

    public class TASKS_F10 : TASKS_G10
    {
        // Additional properties or methods specific to NSP001_G20
        private string _F10SpecificProperty;
        public string F10SpecificProperty
        {
            get => _F10SpecificProperty;
            set => Set(ref _F10SpecificProperty, value);
        }


    }
}
