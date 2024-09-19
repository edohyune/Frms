using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR690_F10 : EpicV004.Libs.MdlBase
    {
        private int _prp_pay_ty;
        public int prp_pay_ty
        {
            get => _prp_pay_ty;
            set => Set(ref _prp_pay_ty, value);
        }

        private DateTime _prp_paydate;
        public DateTime prp_paydate
        {
            get => _prp_paydate;
            set => Set(ref _prp_paydate, value);
        }
    }
}
