using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO300_F30 : EpicV004.Libs.MdlBase
    {
        private string _so_invoice_no;
        public string so_invoice_no
        {
            get => _so_invoice_no;
            set => Set(ref _so_invoice_no, value);
        }

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

        private decimal _downpayment;
        public decimal downpayment
        {
            get => _downpayment;
            set => Set(ref _downpayment, value);
        }

        private decimal _ivc_sumTotal;
        public decimal ivc_sumTotal
        {
            get => _ivc_sumTotal;
            set => Set(ref _ivc_sumTotal, value);
        }

        private decimal _ivc_sumVat;
        public decimal ivc_sumVat
        {
            get => _ivc_sumVat;
            set => Set(ref _ivc_sumVat, value);
        }

        private decimal _ivc_totalAmount;
        public decimal ivc_totalAmount
        {
            get => _ivc_totalAmount;
            set => Set(ref _ivc_totalAmount, value);
        }

        private decimal _ivc_sumRetention;
        public decimal ivc_sumRetention
        {
            get => _ivc_sumRetention;
            set => Set(ref _ivc_sumRetention, value);
        }

        private decimal _ivc_paidAmount;
        public decimal ivc_paidAmount
        {
            get => _ivc_paidAmount;
            set => Set(ref _ivc_paidAmount, value);
        }

    }
}
