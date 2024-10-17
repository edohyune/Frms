using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR610_F80 : EpicV004.Libs.MdlBase
    {
        private int _pid;
        public int pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private int _prm_key;
        public int prm_key
        {
            get => _prm_key;
            set => Set(ref _prm_key, value);
        }

        private int _prm_prob_dp;
        public int prm_prob_dp
        {
            get => _prm_prob_dp;
            set => Set(ref _prm_prob_dp, value);
        }

        private int _prm_prob_dd;
        public int prm_prob_dd
        {
            get => _prm_prob_dd;
            set => Set(ref _prm_prob_dd, value);
        }

        private string _prm_m2d_p;
        public string prm_m2d_p
        {
            get => _prm_m2d_p;
            set => Set(ref _prm_m2d_p, value);
        }

        private string _prm_m2d_d;
        public string prm_m2d_d
        {
            get => _prm_m2d_d;
            set => Set(ref _prm_m2d_d, value);
        }

        private string _prm_w2d_p;
        public string prm_w2d_p
        {
            get => _prm_w2d_p;
            set => Set(ref _prm_w2d_p, value);
        }

        private string _prm_w2d_d;
        public string prm_w2d_d
        {
            get => _prm_w2d_d;
            set => Set(ref _prm_w2d_d, value);
        }

        private string _prm_df_m2d_p;
        public string prm_df_m2d_p
        {
            get => _prm_df_m2d_p;
            set => Set(ref _prm_df_m2d_p, value);
        }

        private string _prm_df_m2d_d;
        public string prm_df_m2d_d
        {
            get => _prm_df_m2d_d;
            set => Set(ref _prm_df_m2d_d, value);
        }

        private string _prm_df_w2d_p;
        public string prm_df_w2d_p
        {
            get => _prm_df_w2d_p;
            set => Set(ref _prm_df_w2d_p, value);
        }

        private string _prm_df_w2d_d;
        public string prm_df_w2d_d
        {
            get => _prm_df_w2d_d;
            set => Set(ref _prm_df_w2d_d, value);
        }

        private string _prm_d2h_p;
        public string prm_d2h_p
        {
            get => _prm_d2h_p;
            set => Set(ref _prm_d2h_p, value);
        }

        private string _prm_d2h_d;
        public string prm_d2h_d
        {
            get => _prm_d2h_d;
            set => Set(ref _prm_d2h_d, value);
        }

        private string _prm_soc_no;
        public string prm_soc_no
        {
            get => _prm_soc_no;
            set => Set(ref _prm_soc_no, value);
        }

        private decimal _prm_soc_min;
        public decimal prm_soc_min
        {
            get => _prm_soc_min;
            set => Set(ref _prm_soc_min, value);
        }

        private decimal _prm_soc_max;
        public decimal prm_soc_max
        {
            get => _prm_soc_max;
            set => Set(ref _prm_soc_max, value);
        }

        private decimal _prm_soc_r;
        public decimal prm_soc_r
        {
            get => _prm_soc_r;
            set => Set(ref _prm_soc_r, value);
        }

        private string _prm_fnd_tax;
        public string prm_fnd_tax
        {
            get => _prm_fnd_tax;
            set => Set(ref _prm_fnd_tax, value);
        }

        private string _prm_fnd_no;
        public string prm_fnd_no
        {
            get => _prm_fnd_no;
            set => Set(ref _prm_fnd_no, value);
        }

        private string _prm_fnd_d2m;
        public string prm_fnd_d2m
        {
            get => _prm_fnd_d2m;
            set => Set(ref _prm_fnd_d2m, value);
        }

        private string _prm_fnd_w2m;
        public string prm_fnd_w2m
        {
            get => _prm_fnd_w2m;
            set => Set(ref _prm_fnd_w2m, value);
        }

        private int _prm_rnd_sal;
        public int prm_rnd_sal
        {
            get => _prm_rnd_sal;
            set => Set(ref _prm_rnd_sal, value);
        }

        private int _prm_rnd_tax;
        public int prm_rnd_tax
        {
            get => _prm_rnd_tax;
            set => Set(ref _prm_rnd_tax, value);
        }

        private int _prm_rnd_fnd;
        public int prm_rnd_fnd
        {
            get => _prm_rnd_fnd;
            set => Set(ref _prm_rnd_fnd, value);
        }

        private int _prm_rnd_soc;
        public int prm_rnd_soc
        {
            get => _prm_rnd_soc;
            set => Set(ref _prm_rnd_soc, value);
        }

        private int _prm_rnd_net;
        public int prm_rnd_net
        {
            get => _prm_rnd_net;
            set => Set(ref _prm_rnd_net, value);
        }

        private int _prm_fnd_lim;
        public int prm_fnd_lim
        {
            get => _prm_fnd_lim;
            set => Set(ref _prm_fnd_lim, value);
        }

        private decimal _prm_fnd_max;
        public decimal prm_fnd_max
        {
            get => _prm_fnd_max;
            set => Set(ref _prm_fnd_max, value);
        }

        private int _prm_cpy_lim;
        public int prm_cpy_lim
        {
            get => _prm_cpy_lim;
            set => Set(ref _prm_cpy_lim, value);
        }

        private decimal _prm_cpy_max;
        public decimal prm_cpy_max
        {
            get => _prm_cpy_max;
            set => Set(ref _prm_cpy_max, value);
        }

        private string _prm_fnd_b4;
        public string prm_fnd_b4
        {
            get => _prm_fnd_b4;
            set => Set(ref _prm_fnd_b4, value);
        }

        private string _prm_soc_b4;
        public string prm_soc_b4
        {
            get => _prm_soc_b4;
            set => Set(ref _prm_soc_b4, value);
        }

        private int _prm_rnd_dlg;
        public int prm_rnd_dlg
        {
            get => _prm_rnd_dlg;
            set => Set(ref _prm_rnd_dlg, value);
        }

        private int _prm_halfmonth;
        public int prm_halfmonth
        {
            get => _prm_halfmonth;
            set => Set(ref _prm_halfmonth, value);
        }

        private string _prm_2fnd_tax;
        public string prm_2fnd_tax
        {
            get => _prm_2fnd_tax;
            set => Set(ref _prm_2fnd_tax, value);
        }

        private string _prm_2fnd_no;
        public string prm_2fnd_no
        {
            get => _prm_2fnd_no;
            set => Set(ref _prm_2fnd_no, value);
        }

        private string _prm_2fnd_d2m;
        public string prm_2fnd_d2m
        {
            get => _prm_2fnd_d2m;
            set => Set(ref _prm_2fnd_d2m, value);
        }

        private string _prm_2fnd_w2m;
        public string prm_2fnd_w2m
        {
            get => _prm_2fnd_w2m;
            set => Set(ref _prm_2fnd_w2m, value);
        }

        private int _prm_2fnd_lim;
        public int prm_2fnd_lim
        {
            get => _prm_2fnd_lim;
            set => Set(ref _prm_2fnd_lim, value);
        }

        private decimal _prm_2fnd_max;
        public decimal prm_2fnd_max
        {
            get => _prm_2fnd_max;
            set => Set(ref _prm_2fnd_max, value);
        }

        private int _prm_2cpy_lim;
        public int prm_2cpy_lim
        {
            get => _prm_2cpy_lim;
            set => Set(ref _prm_2cpy_lim, value);
        }

        private decimal _prm_2cpy_max;
        public decimal prm_2cpy_max
        {
            get => _prm_2cpy_max;
            set => Set(ref _prm_2cpy_max, value);
        }

        private string _prm_soc_prov;
        public string prm_soc_prov
        {
            get => _prm_soc_prov;
            set => Set(ref _prm_soc_prov, value);
        }

        private string _prm_soc_prov_br;
        public string prm_soc_prov_br
        {
            get => _prm_soc_prov_br;
            set => Set(ref _prm_soc_prov_br, value);
        }

        private string _prm_soc_acct_br;
        public string prm_soc_acct_br
        {
            get => _prm_soc_acct_br;
            set => Set(ref _prm_soc_acct_br, value);
        }

        private int _prm_male_retire_p;
        public int prm_male_retire_p
        {
            get => _prm_male_retire_p;
            set => Set(ref _prm_male_retire_p, value);
        }

        private int _prm_female_retire_p;
        public int prm_female_retire_p
        {
            get => _prm_female_retire_p;
            set => Set(ref _prm_female_retire_p, value);
        }

        private int _prm_male_retire_d;
        public int prm_male_retire_d
        {
            get => _prm_male_retire_d;
            set => Set(ref _prm_male_retire_d, value);
        }

        private int _prm_female_retire_d;
        public int prm_female_retire_d
        {
            get => _prm_female_retire_d;
            set => Set(ref _prm_female_retire_d, value);
        }

        private int _prm_soc_ty;
        public int prm_soc_ty
        {
            get => _prm_soc_ty;
            set => Set(ref _prm_soc_ty, value);
        }

        private decimal _prm_scc_r;
        public decimal prm_scc_r
        {
            get => _prm_scc_r;
            set => Set(ref _prm_scc_r, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

    }
}
