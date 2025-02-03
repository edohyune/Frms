using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EpicV004.Frms
{
    public class SP172_F10 : EpicV004.Libs.MdlBase
    {
        private long _Id;
        public long Id
        {
            get => _Id;
            set => Set(ref _Id, value);
        }

    }
}
