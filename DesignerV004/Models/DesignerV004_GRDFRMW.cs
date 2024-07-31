using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class DesignerV004_GRDFRMW : EpicV004.Libs.MdlBase
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

        private string _CtrlNm;
        public string CtrlNm
        {
            get => _CtrlNm;
            set => Set(ref _CtrlNm, value);
        }

        private string _WrkNm;
        public string WrkNm
        {
            get => _WrkNm;
            set => Set(ref _WrkNm, value);
        }

        private string _WrkCd;
        public string WrkCd
        {
            get => _WrkCd;
            set => Set(ref _WrkCd, value);
        }

        private bool _ShowFindPanel;
        public bool ShowFindPanel
        {
            get => _ShowFindPanel;
            set => Set(ref _ShowFindPanel, value);
        }

        private bool _ShowGroupPanel;
        public bool ShowGroupPanel
        {
            get => _ShowGroupPanel;
            set => Set(ref _ShowGroupPanel, value);
        }

        private bool _ShowFooter;
        public bool ShowFooter
        {
            get => _ShowFooter;
            set => Set(ref _ShowFooter, value);
        }

        private bool _ShowBand;
        public bool ShowBand
        {
            get => _ShowBand;
            set => Set(ref _ShowBand, value);
        }

        private bool _ShowFilter;
        public bool ShowFilter
        {
            get => _ShowFilter;
            set => Set(ref _ShowFilter, value);
        }

        private bool _ColumnAutoWidth;
        public bool ColumnAutoWidth
        {
            get => _ColumnAutoWidth;
            set => Set(ref _ColumnAutoWidth, value);
        }

        private string _SelectMode;
        public string SelectMode
        {
            get => _SelectMode;
            set => Set(ref _SelectMode, value);
        }

        private bool _MultiSelect;
        public bool MultiSelect
        {
            get => _MultiSelect;
            set => Set(ref _MultiSelect, value);
        }

        private bool _UseYn;
        public bool UseYn
        {
            get => _UseYn;
            set => Set(ref _UseYn, value);
        }

        private bool _NavAdd;
        public bool NavAdd
        {
            get => _NavAdd;
            set => Set(ref _NavAdd, value);
        }

        private bool _NavDelete;
        public bool NavDelete
        {
            get => _NavDelete;
            set => Set(ref _NavDelete, value);
        }

        private bool _NavSave;
        public bool NavSave
        {
            get => _NavSave;
            set => Set(ref _NavSave, value);
        }

        private bool _NavCancel;
        public bool NavCancel
        {
            get => _NavCancel;
            set => Set(ref _NavCancel, value);
        }

        private int _SaveSq;
        public int SaveSq
        {
            get => _SaveSq;
            set => Set(ref _SaveSq, value);
        }

        private int _OpenSq;
        public int OpenSq
        {
            get => _OpenSq;
            set => Set(ref _OpenSq, value);
        }

        private bool _TriggerYn;
        public bool TriggerYn
        {
            get => _TriggerYn;
            set => Set(ref _TriggerYn, value);
        }

        private bool _StartYn;
        public bool StartYn
        {
            get => _StartYn;
            set => Set(ref _StartYn, value);
        }

        private string _Memo;
        public string Memo
        {
            get => _Memo;
            set => Set(ref _Memo, value);
        }
    }
}
