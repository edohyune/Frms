using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR590_G10 : EpicV004.Libs.MdlBase
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

        private DateTime _att_summ_date;
        public DateTime att_summ_date
        {
            get => _att_summ_date;
            set => Set(ref _att_summ_date, value);
        }

        private string _att_summ_close;
        public string att_summ_close
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

        private string _add_ded_close;
        public string add_ded_close
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

        private string _calc_salary_close;
        public string calc_salary_close
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

        private string _vc_no;
        public string vc_no
        {
            get => _vc_no;
            set => Set(ref _vc_no, value);
        }

        private DateTime _vc_date;
        public DateTime vc_date
        {
            get => _vc_date;
            set => Set(ref _vc_date, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _is_use;
        public string is_use
        {
            get => _is_use;
            set => Set(ref _is_use, value);
        }

        private int _salary_degree;
        public int salary_degree
        {
            get => _salary_degree;
            set => Set(ref _salary_degree, value);
        }
    }
}
