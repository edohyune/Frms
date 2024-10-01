using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SO350_G30 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _release_no;
        public string release_no
        {
            get => _release_no;
            set => Set(ref _release_no, value);
        }

        private int _sq;
        public int sq
        {
            get => _sq;
            set => Set(ref _sq, value);
        }

        private string _so_invoice_no;
        public string so_invoice_no
        {
            get => _so_invoice_no;
            set => Set(ref _so_invoice_no, value);
        }

        private string _so_doc_no;
        public string so_doc_no
        {
            get => _so_doc_no;
            set => Set(ref _so_doc_no, value);
        }

        private decimal _retention;
        public decimal retention
        {
            get => _retention;
            set => Set(ref _retention, value);
        }

        private decimal _deduction;
        public decimal deduction
        {
            get => _deduction;
            set => Set(ref _deduction, value);
        }

        private decimal _net_amount;
        public decimal net_amount
        {
            get => _net_amount;
            set => Set(ref _net_amount, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

    }
}
