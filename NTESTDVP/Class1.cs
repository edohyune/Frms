using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class NTESTDVP_G_10 : EpicV004.Libs.MdlBase
    {
        private int _ID;
        public int ID
        {
            get => _ID;
            set => Set(ref _ID, value);
        }

        private string _Name;
        public string Name
        {
            get => _Name;
            set => Set(ref _Name, value);
        }

        private int _Age;
        public int Age
        {
            get => _Age;
            set => Set(ref _Age, value);
        }

        private int _PID;
        public int PID
        {
            get => _PID;
            set => Set(ref _PID, value);
        }

    }
}