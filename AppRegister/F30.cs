using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class AppRegister_F30 : EpicV004.Libs.MdlBase
    {
        private string _applicant_id;
        public string applicant_id
        {
            get => _applicant_id;
            set => Set(ref _applicant_id, value);
        }

        private byte[] _photo;
        public byte[] photo
        {
            get => _photo;
            set => Set(ref _photo, value);
        }

        private byte[] _photo2;
        public byte[] photo2
        {
            get => _photo2;
            set => Set(ref _photo2, value);
        }
    }
}
