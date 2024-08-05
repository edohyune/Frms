using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class DPM200_G10 : EpicV004.Libs.MdlBase
    {
        private int _id;
        public int id
        {
            get => _id;
            set => Set(ref _id, value);
        }

        private string _name;
        public string name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private string _description;
        public string description
        {
            get => _description;
            set => Set(ref _description, value);
        }

    }
}