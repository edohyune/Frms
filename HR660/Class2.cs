using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR660_F10 : EpicV004.Libs.MdlBase
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

        private string _paymon;
        public string paymon
        {
            get => _paymon;
            set => Set(ref _paymon, value);
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

        private DateTime _att_summ_date;
        public DateTime att_summ_date
        {
            get => _att_summ_date;
            set => Set(ref _att_summ_date, value);
        }

        private bool _att_summ_close;
        public bool att_summ_close
        {
            get => _att_summ_close;
            set => Set(ref _att_summ_close, value);
        }

        private DateTime _add_ded_date;
        public DateTime add_ded_date
        {
            get => _add_ded_date;
            set => Set(ref _add_ded_date, value);
        }

        private bool _add_ded_close;
        public bool add_ded_close
        {
            get => _add_ded_close;
            set => Set(ref _add_ded_close, value);
        }

        private DateTime _calc_salary_date;
        public DateTime calc_salary_date
        {
            get => _calc_salary_date;
            set => Set(ref _calc_salary_date, value);
        }

        private bool _calc_salary_close;
        public bool calc_salary_close
        {
            get => _calc_salary_close;
            set => Set(ref _calc_salary_close, value);
        }

        private DateTime _calc_tax_date;
        public DateTime calc_tax_date
        {
            get => _calc_tax_date;
            set => Set(ref _calc_tax_date, value);
        }

        private string _calc_tax_close;
        public string calc_tax_close
        {
            get => _calc_tax_close;
            set => Set(ref _calc_tax_close, value);
        }

        private int _cnt1;
        public int cnt1
        {
            get => _cnt1;
            set => Set(ref _cnt1, value);
        }

        private int _cnt2;
        public int cnt2
        {
            get => _cnt2;
            set => Set(ref _cnt2, value);
        }

        private int _cnt3;
        public int cnt3
        {
            get => _cnt3;
            set => Set(ref _cnt3, value);
        }

        private int _cnt4;
        public int cnt4
        {
            get => _cnt4;
            set => Set(ref _cnt4, value);
        }

        private int _cnt11;
        public int cnt11
        {
            get => _cnt11;
            set => Set(ref _cnt11, value);
        }

        private int _cnt12;
        public int cnt12
        {
            get => _cnt12;
            set => Set(ref _cnt12, value);
        }

        private int _cnt13;
        public int cnt13
        {
            get => _cnt13;
            set => Set(ref _cnt13, value);
        }

        private int _cnt14;
        public int cnt14
        {
            get => _cnt14;
            set => Set(ref _cnt14, value);
        }

        private string _prp_always;
        public string prp_always
        {
            get => _prp_always;
            set => Set(ref _prp_always, value);
        }

        private string _prp_caltax;
        public string prp_caltax
        {
            get => _prp_caltax;
            set => Set(ref _prp_caltax, value);
        }

        private string _prp_yearend;
        public string prp_yearend
        {
            get => _prp_yearend;
            set => Set(ref _prp_yearend, value);
        }

        private string _prp_gur;
        public string prp_gur
        {
            get => _prp_gur;
            set => Set(ref _prp_gur, value);
        }

        private string _prp_loan;
        public string prp_loan
        {
            get => _prp_loan;
            set => Set(ref _prp_loan, value);
        }

        private string _prp_fund;
        public string prp_fund
        {
            get => _prp_fund;
            set => Set(ref _prp_fund, value);
        }

        private string _prp_soc;
        public string prp_soc
        {
            get => _prp_soc;
            set => Set(ref _prp_soc, value);
        }

        private string _prp_dlgent;
        public string prp_dlgent
        {
            get => _prp_dlgent;
            set => Set(ref _prp_dlgent, value);
        }

        private string _prp_install;
        public string prp_install
        {
            get => _prp_install;
            set => Set(ref _prp_install, value);
        }

        private string _prp_violate;
        public string prp_violate
        {
            get => _prp_violate;
            set => Set(ref _prp_violate, value);
        }

        private string _prp_inc_always;
        public string prp_inc_always
        {
            get => _prp_inc_always;
            set => Set(ref _prp_inc_always, value);
        }

        private string _prp_2fund;
        public string prp_2fund
        {
            get => _prp_2fund;
            set => Set(ref _prp_2fund, value);
        }

        private string _prp_uniform;
        public string prp_uniform
        {
            get => _prp_uniform;
            set => Set(ref _prp_uniform, value);
        }

        private string _prp_fee;
        public string prp_fee
        {
            get => _prp_fee;
            set => Set(ref _prp_fee, value);
        }

        private string _prp_welfare;
        public string prp_welfare
        {
            get => _prp_welfare;
            set => Set(ref _prp_welfare, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
