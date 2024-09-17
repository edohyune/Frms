using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR420_G10 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private int _seq;
        public int seq
        {
            get => _seq;
            set => Set(ref _seq, value);
        }

        private decimal _from_year;
        public decimal from_year
        {
            get => _from_year;
            set => Set(ref _from_year, value);
        }

        private decimal _to_year;
        public decimal to_year
        {
            get => _to_year;
            set => Set(ref _to_year, value);
        }

        private int _annual_leave;
        public int annual_leave
        {
            get => _annual_leave;
            set => Set(ref _annual_leave, value);
        }

        private int _sick_leave;
        public int sick_leave
        {
            get => _sick_leave;
            set => Set(ref _sick_leave, value);
        }

        private int _business_leave;
        public int business_leave
        {
            get => _business_leave;
            set => Set(ref _business_leave, value);
        }

        private int _maternity_leave;
        public int maternity_leave
        {
            get => _maternity_leave;
            set => Set(ref _maternity_leave, value);
        }

        private int _military_leave;
        public int military_leave
        {
            get => _military_leave;
            set => Set(ref _military_leave, value);
        }

        private string _termTy;
        public string termTy
        {
            get => _termTy;
            set => Set(ref _termTy, value);
        }

        private decimal _frTerm;
        public decimal frTerm
        {
            get => _frTerm;
            set => Set(ref _frTerm, value);
        }

        private decimal _toTerm;
        public decimal toTerm
        {
            get => _toTerm;
            set => Set(ref _toTerm, value);
        }

        private decimal _annual;
        public decimal annual
        {
            get => _annual;
            set => Set(ref _annual, value);
        }

        private decimal _sick;
        public decimal sick
        {
            get => _sick;
            set => Set(ref _sick, value);
        }

        private decimal _business;
        public decimal business
        {
            get => _business;
            set => Set(ref _business, value);
        }

        private decimal _maternity;
        public decimal maternity
        {
            get => _maternity;
            set => Set(ref _maternity, value);
        }

        private decimal _military;
        public decimal military
        {
            get => _military;
            set => Set(ref _military, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
