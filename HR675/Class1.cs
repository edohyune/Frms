using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR675_G10 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private long _prp_key;
        public long prp_key
        {
            get => _prp_key;
            set => Set(ref _prp_key, value);
        }

        private int _prp_pay_ty;
        public int prp_pay_ty
        {
            get => _prp_pay_ty;
            set => Set(ref _prp_pay_ty, value);
        }

        private int _prp_year;
        public int prp_year
        {
            get => _prp_year;
            set => Set(ref _prp_year, value);
        }

        private int _prp_month;
        public int prp_month
        {
            get => _prp_month;
            set => Set(ref _prp_month, value);
        }

        private DateTime _prp_paydate;
        public DateTime prp_paydate
        {
            get => _prp_paydate;
            set => Set(ref _prp_paydate, value);
        }

        private DateTime _prp_st_date;
        public DateTime prp_st_date
        {
            get => _prp_st_date;
            set => Set(ref _prp_st_date, value);
        }

        private DateTime _prp_en_date;
        public DateTime prp_en_date
        {
            get => _prp_en_date;
            set => Set(ref _prp_en_date, value);
        }

    }
}
