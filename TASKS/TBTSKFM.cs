using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class TASKS_G30 : EpicV004.Libs.MdlBase
    {
        private int _TskId;
        public int TskId
        {
            get => _TskId;
            set => Set(ref _TskId, value);
        }

        private int _FrmId;
        public int FrmId
        {
            get => _FrmId;
            set => Set(ref _FrmId, value);
        }

    }
}
