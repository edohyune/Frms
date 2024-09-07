using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR690_G50 : EpicV004.Libs.MdlBase
    {
        private string _file_text;
        public string file_text
        {
            get => _file_text;
            set => Set(ref _file_text, value);
        }
    }
}
