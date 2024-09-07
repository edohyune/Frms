using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR690_G60 : EpicV004.Libs.MdlBase
    {
        private long _row_num;
        public long row_num
        {
            get => _row_num;
            set => Set(ref _row_num, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _social_sec_no;
        public string social_sec_no
        {
            get => _social_sec_no;
            set => Set(ref _social_sec_no, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _emp_nm;
        public string emp_nm
        {
            get => _emp_nm;
            set => Set(ref _emp_nm, value);
        }

        private string _hire_ty;
        public string hire_ty
        {
            get => _hire_ty;
            set => Set(ref _hire_ty, value);
        }

        private decimal _PRR_INCOME;
        public decimal PRR_INCOME
        {
            get => _PRR_INCOME;
            set => Set(ref _PRR_INCOME, value);
        }

        private decimal _PRR_SOC;
        public decimal PRR_SOC
        {
            get => _PRR_SOC;
            set => Set(ref _PRR_SOC, value);
        }

        private decimal _PRR_TL_INCOME;
        public decimal PRR_TL_INCOME
        {
            get => _PRR_TL_INCOME;
            set => Set(ref _PRR_TL_INCOME, value);
        }

        private decimal _PRR_SCC;
        public decimal PRR_SCC
        {
            get => _PRR_SCC;
            set => Set(ref _PRR_SCC, value);
        }

    }
}
