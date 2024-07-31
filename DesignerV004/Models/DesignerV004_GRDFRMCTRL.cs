using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class DesignerV004_GRDFRMCTRL : EpicV004.Libs.MdlBase
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

        private string _CtrlNm;
        public string CtrlNm
        {
            get => _CtrlNm;
            set => Set(ref _CtrlNm, value);
        }

        private string _CtrlTy;
        public string CtrlTy
        {
            get => _CtrlTy;
            set => Set(ref _CtrlTy, value);
        }

        private int _CtrlX;
        public int CtrlX
        {
            get => _CtrlX;
            set => Set(ref _CtrlX, value);
        }

        private int _CtrlY;
        public int CtrlY
        {
            get => _CtrlY;
            set => Set(ref _CtrlY, value);
        }

        private int _CtrlW;
        public int CtrlW
        {
            get => _CtrlW;
            set => Set(ref _CtrlW, value);
        }

        private int _CtrlH;
        public int CtrlH
        {
            get => _CtrlH;
            set => Set(ref _CtrlH, value);
        }

        private int _TitleWidth;
        public int TitleWidth
        {
            get => _TitleWidth;
            set => Set(ref _TitleWidth, value);
        }

        private string _TitleText;
        public string TitleText
        {
            get => _TitleText;
            set => Set(ref _TitleText, value);
        }

        private string _TitleAlign;
        public string TitleAlign
        {
            get => _TitleAlign;
            set => Set(ref _TitleAlign, value);
        }

        private string _PopUp;
        public string PopUp
        {
            get => _PopUp;
            set => Set(ref _PopUp, value);
        }

        private string _DefaultText;
        public string DefaultText
        {
            get => _DefaultText;
            set => Set(ref _DefaultText, value);
        }

        private string _TextAlign;
        public string TextAlign
        {
            get => _TextAlign;
            set => Set(ref _TextAlign, value);
        }

        private bool _ShowYn;
        public bool ShowYn
        {
            get => _ShowYn;
            set => Set(ref _ShowYn, value);
        }

        private bool _EditYn;
        public bool EditYn
        {
            get => _EditYn;
            set => Set(ref _EditYn, value);
        }

        private bool _NeedYn;
        public bool NeedYn
        {
            get => _NeedYn;
            set => Set(ref _NeedYn, value);
        }

        private string _FuncStr;
        public string FuncStr
        {
            get => _FuncStr;
            set => Set(ref _FuncStr, value);
        }

        private string _FormatStr;
        public string FormatStr
        {
            get => _FormatStr;
            set => Set(ref _FormatStr, value);
        }

        private string _ColorFont;
        public string ColorFont
        {
            get => _ColorFont;
            set => Set(ref _ColorFont, value);
        }

        private string _ColorBg;
        public string ColorBg
        {
            get => _ColorBg;
            set => Set(ref _ColorBg, value);
        }

        private string _ToolNm;
        public string ToolNm
        {
            get => _ToolNm;
            set => Set(ref _ToolNm, value);
        }

        private int _Seq;
        public int Seq
        {
            get => _Seq;
            set => Set(ref _Seq, value);
        }

        private long _Id;
        public long Id
        {
            get => _Id;
            set => Set(ref _Id, value);
        }

        private string _Memo;
        public string Memo
        {
            get => _Memo;
            set => Set(ref _Memo, value);
        }
    }
}
