using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO350_F30 : EpicV004.Libs.MdlBase
    {
        private decimal _ivc_sumAmount;
        public decimal ivc_sumAmount
        {
            get => _ivc_sumAmount;
            set => Set(ref _ivc_sumAmount, value);
        }

        private decimal _ivc_sumDeduction;
        public decimal ivc_sumDeduction
        {
            get => _ivc_sumDeduction;
            set => Set(ref _ivc_sumDeduction, value);
        }

        private decimal _ivc_sumNet;
        public decimal ivc_sumNet
        {
            get => _ivc_sumNet;
            set => Set(ref _ivc_sumNet, value);
        }

    }
}
