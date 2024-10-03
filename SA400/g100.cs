using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA400_G100 :EpicV004.Libs.MdlBase
    {
        private string _docId;
        public string docId
        {
            get => _docId;
            set => Set(ref _docId, value);
        }

        private int _docSq;
        public int docSq
        {
            get => _docSq;
            set => Set(ref _docSq, value);
        }

        private string _refId;
        public string refId
        {
            get => _refId;
            set => Set(ref _refId, value);
        }

        private int _refSq;
        public int refSq
        {
            get => _refSq;
            set => Set(ref _refSq, value);
        }

        private string _fId;
        public string fId
        {
            get => _fId;
            set => Set(ref _fId, value);
        }

        private string _fPath;
        public string fPath
        {
            get => _fPath;
            set => Set(ref _fPath, value);
        }

        private string _fNm;
        public string fNm
        {
            get => _fNm;
            set => Set(ref _fNm, value);
        }

        private int _fSize;
        public int fSize
        {
            get => _fSize;
            set => Set(ref _fSize, value);
        }

        private string _fExt;
        public string fExt
        {
            get => _fExt;
            set => Set(ref _fExt, value);
        }

        private string _frmNm;
        public string frmNm
        {
            get => _frmNm;
            set => Set(ref _frmNm, value);
        }

        private string _rmks;
        public string rmks
        {
            get => _rmks;
            set => Set(ref _rmks, value);
        }

        private string _upload;
        public string upload
        {
            get => _upload;
            set => Set(ref _upload, value);
        }

        private string _show;
        public string show
        {
            get => _show;
            set => Set(ref _show, value);
        }

        private string _del;
        public string del
        {
            get => _del;
            set => Set(ref _del, value);
        }

        private string _down;
        public string down
        {
            get => _down;
            set => Set(ref _down, value);
        }
    }
}
