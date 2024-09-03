using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR610_F10 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private int _al_key;
        public int al_key
        {
            get => _al_key;
            set => Set(ref _al_key, value);
        }

        private decimal _al_40_r;
        public decimal al_40_r
        {
            get => _al_40_r;
            set => Set(ref _al_40_r, value);
        }

        private decimal _al_40_max;
        public decimal al_40_max
        {
            get => _al_40_max;
            set => Set(ref _al_40_max, value);
        }

        private decimal _al_fnd_max;
        public decimal al_fnd_max
        {
            get => _al_fnd_max;
            set => Set(ref _al_fnd_max, value);
        }

        private decimal _al_fnd_r;
        public decimal al_fnd_r
        {
            get => _al_fnd_r;
            set => Set(ref _al_fnd_r, value);
        }

        private decimal _al_ps_alw;
        public decimal al_ps_alw
        {
            get => _al_ps_alw;
            set => Set(ref _al_ps_alw, value);
        }

        private decimal _al_sp_alw;
        public decimal al_sp_alw
        {
            get => _al_sp_alw;
            set => Set(ref _al_sp_alw, value);
        }

        private decimal _al_life;
        public decimal al_life
        {
            get => _al_life;
            set => Set(ref _al_life, value);
        }

        private decimal _al_fnd;
        public decimal al_fnd
        {
            get => _al_fnd;
            set => Set(ref _al_fnd, value);
        }

        private decimal _al_donate_r;
        public decimal al_donate_r
        {
            get => _al_donate_r;
            set => Set(ref _al_donate_r, value);
        }

        private decimal _al_home;
        public decimal al_home
        {
            get => _al_home;
            set => Set(ref _al_home, value);
        }

        private decimal _al_chdne;
        public decimal al_chdne
        {
            get => _al_chdne;
            set => Set(ref _al_chdne, value);
        }

        private decimal _al_chdwe;
        public decimal al_chdwe
        {
            get => _al_chdwe;
            set => Set(ref _al_chdwe, value);
        }

        private decimal _al_dnte_max;
        public decimal al_dnte_max
        {
            get => _al_dnte_max;
            set => Set(ref _al_dnte_max, value);
        }

        private decimal _al_dnte_times;
        public decimal al_dnte_times
        {
            get => _al_dnte_times;
            set => Set(ref _al_dnte_times, value);
        }

        private decimal _al_ltf_pcnt;
        public decimal al_ltf_pcnt
        {
            get => _al_ltf_pcnt;
            set => Set(ref _al_ltf_pcnt, value);
        }

        private decimal _al_ltf_max;
        public decimal al_ltf_max
        {
            get => _al_ltf_max;
            set => Set(ref _al_ltf_max, value);
        }

        private decimal _al_parent;
        public decimal al_parent
        {
            get => _al_parent;
            set => Set(ref _al_parent, value);
        }

        private decimal _al_rmf_pcnt;
        public decimal al_rmf_pcnt
        {
            get => _al_rmf_pcnt;
            set => Set(ref _al_rmf_pcnt, value);
        }

        private decimal _al_rmf_max;
        public decimal al_rmf_max
        {
            get => _al_rmf_max;
            set => Set(ref _al_rmf_max, value);
        }

        private decimal _al_techr_max;
        public decimal al_techr_max
        {
            get => _al_techr_max;
            set => Set(ref _al_techr_max, value);
        }

        private decimal _al_rtire_max;
        public decimal al_rtire_max
        {
            get => _al_rtire_max;
            set => Set(ref _al_rtire_max, value);
        }

        private decimal _al_rsign_max;
        public decimal al_rsign_max
        {
            get => _al_rsign_max;
            set => Set(ref _al_rsign_max, value);
        }

        private decimal _al_heh_parent;
        public decimal al_heh_parent
        {
            get => _al_heh_parent;
            set => Set(ref _al_heh_parent, value);
        }

        private decimal _al_ov_65;
        public decimal al_ov_65
        {
            get => _al_ov_65;
            set => Set(ref _al_ov_65, value);
        }

        private decimal _al_sp_ov_65;
        public decimal al_sp_ov_65
        {
            get => _al_sp_ov_65;
            set => Set(ref _al_sp_ov_65, value);
        }

        private decimal _al_disabled;
        public decimal al_disabled
        {
            get => _al_disabled;
            set => Set(ref _al_disabled, value);
        }

        private decimal _al_pension_pcnt;
        public decimal al_pension_pcnt
        {
            get => _al_pension_pcnt;
            set => Set(ref _al_pension_pcnt, value);
        }

        private decimal _al_pension_max;
        public decimal al_pension_max
        {
            get => _al_pension_max;
            set => Set(ref _al_pension_max, value);
        }

        private decimal _al_real_est_pcnt;
        public decimal al_real_est_pcnt
        {
            get => _al_real_est_pcnt;
            set => Set(ref _al_real_est_pcnt, value);
        }

        private decimal _al_real_est_max;
        public decimal al_real_est_max
        {
            get => _al_real_est_max;
            set => Set(ref _al_real_est_max, value);
        }

        private decimal _al_real_est_year;
        public decimal al_real_est_year
        {
            get => _al_real_est_year;
            set => Set(ref _al_real_est_year, value);
        }

        private int _al_inyear_tax;
        public int al_inyear_tax
        {
            get => _al_inyear_tax;
            set => Set(ref _al_inyear_tax, value);
        }

        private decimal _al_asset_max;
        public decimal al_asset_max
        {
            get => _al_asset_max;
            set => Set(ref _al_asset_max, value);
        }

        private decimal _al_tour_max;
        public decimal al_tour_max
        {
            get => _al_tour_max;
            set => Set(ref _al_tour_max, value);
        }

        private decimal _al_consume_max;
        public decimal al_consume_max
        {
            get => _al_consume_max;
            set => Set(ref _al_consume_max, value);
        }

        private decimal _al_nation_saving;
        public decimal al_nation_saving
        {
            get => _al_nation_saving;
            set => Set(ref _al_nation_saving, value);
        }

        private decimal _al_delivery;
        public decimal al_delivery
        {
            get => _al_delivery;
            set => Set(ref _al_delivery, value);
        }

        private decimal _al_ssf_pcnt;
        public decimal al_ssf_pcnt
        {
            get => _al_ssf_pcnt;
            set => Set(ref _al_ssf_pcnt, value);
        }

        private decimal _al_ssf_max;
        public decimal al_ssf_max
        {
            get => _al_ssf_max;
            set => Set(ref _al_ssf_max, value);
        }

        private decimal _al_svrnc_exempt;
        public decimal al_svrnc_exempt
        {
            get => _al_svrnc_exempt;
            set => Set(ref _al_svrnc_exempt, value);
        }

        private int _al_work_period;
        public int al_work_period
        {
            get => _al_work_period;
            set => Set(ref _al_work_period, value);
        }

        private decimal _al_step1_expense;
        public decimal al_step1_expense
        {
            get => _al_step1_expense;
            set => Set(ref _al_step1_expense, value);
        }

        private decimal _al_step2_expense;
        public decimal al_step2_expense
        {
            get => _al_step2_expense;
            set => Set(ref _al_step2_expense, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
