using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SA400_F30 :EpicV004.Libs.MdlBase
    {
        private string _project_no;
        public string project_no
        {
            get => _project_no;
            set => Set(ref _project_no, value);
        }

        private decimal _budget_amount;
        public decimal budget_amount
        {
            get => _budget_amount;
            set => Set(ref _budget_amount, value);
        }

        private decimal _budget_expense;
        public decimal budget_expense
        {
            get => _budget_expense;
            set => Set(ref _budget_expense, value);
        }

        private decimal _budget_po;
        public decimal budget_po
        {
            get => _budget_po;
            set => Set(ref _budget_po, value);
        }

        private decimal _budget_so;
        public decimal budget_so
        {
            get => _budget_so;
            set => Set(ref _budget_so, value);
        }

        private decimal _budget_used;
        public decimal budget_used
        {
            get => _budget_used;
            set => Set(ref _budget_used, value);
        }

        private decimal _budget_remain;
        public decimal budget_remain
        {
            get => _budget_remain;
            set => Set(ref _budget_remain, value);
        }
    }
}
