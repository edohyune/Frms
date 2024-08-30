using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR600_G10 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private long _df_key;
        public long df_key
        {
            get => _df_key;
            set => Set(ref _df_key, value);
        }

        private string _df_desc;
        public string df_desc
        {
            get => _df_desc;
            set => Set(ref _df_desc, value);
        }

        private string _df_e_desc;
        public string df_e_desc
        {
            get => _df_e_desc;
            set => Set(ref _df_e_desc, value);
        }

        private string _df_month_rate;
        public string df_month_rate
        {
            get => _df_month_rate;
            set => Set(ref _df_month_rate, value);
        }

        private string _df_day_rate;
        public string df_day_rate
        {
            get => _df_day_rate;
            set => Set(ref _df_day_rate, value);
        }

        private string _df_piece_rate;
        public string df_piece_rate
        {
            get => _df_piece_rate;
            set => Set(ref _df_piece_rate, value);
        }

        private int _df_add_min;
        public int df_add_min
        {
            get => _df_add_min;
            set => Set(ref _df_add_min, value);
        }

        private int _df_b4af_tx;
        public int df_b4af_tx
        {
            get => _df_b4af_tx;
            set => Set(ref _df_b4af_tx, value);
        }

        private int _df_tx_40;
        public int df_tx_40
        {
            get => _df_tx_40;
            set => Set(ref _df_tx_40, value);
        }

        private string _df_tax_msg;
        public string df_tax_msg
        {
            get => _df_tax_msg;
            set => Set(ref _df_tax_msg, value);
        }

        private string _df_soc;
        public string df_soc
        {
            get => _df_soc;
            set => Set(ref _df_soc, value);
        }

        private string _df_fnd;
        public string df_fnd
        {
            get => _df_fnd;
            set => Set(ref _df_fnd, value);
        }

        private int _df_always;
        public int df_always
        {
            get => _df_always;
            set => Set(ref _df_always, value);
        }

        private int _df_expense;
        public int df_expense
        {
            get => _df_expense;
            set => Set(ref _df_expense, value);
        }

        private decimal _df_exp_pcnt;
        public decimal df_exp_pcnt
        {
            get => _df_exp_pcnt;
            set => Set(ref _df_exp_pcnt, value);
        }

        private decimal _df_exp_lt;
        public decimal df_exp_lt
        {
            get => _df_exp_lt;
            set => Set(ref _df_exp_lt, value);
        }

        private int _df_round;
        public int df_round
        {
            get => _df_round;
            set => Set(ref _df_round, value);
        }

        private int _df_order;
        public int df_order
        {
            get => _df_order;
            set => Set(ref _df_order, value);
        }

        private int _df_code;
        public int df_code
        {
            get => _df_code;
            set => Set(ref _df_code, value);
        }

        private int _df_avg;
        public int df_avg
        {
            get => _df_avg;
            set => Set(ref _df_avg, value);
        }

        private string _df_formula;
        public string df_formula
        {
            get => _df_formula;
            set => Set(ref _df_formula, value);
        }

        private string _df_dlgent;
        public string df_dlgent
        {
            get => _df_dlgent;
            set => Set(ref _df_dlgent, value);
        }

        private int _df_right;
        public int df_right
        {
            get => _df_right;
            set => Set(ref _df_right, value);
        }

        private int _df_step;
        public int df_step
        {
            get => _df_step;
            set => Set(ref _df_step, value);
        }

        private int _df_tax_ty;
        public int df_tax_ty
        {
            get => _df_tax_ty;
            set => Set(ref _df_tax_ty, value);
        }

        private int _df_unit;
        public int df_unit
        {
            get => _df_unit;
            set => Set(ref _df_unit, value);
        }

        private int _df_group_to;
        public int df_group_to
        {
            get => _df_group_to;
            set => Set(ref _df_group_to, value);
        }

        private string _df_enabled;
        public string df_enabled
        {
            get => _df_enabled;
            set => Set(ref _df_enabled, value);
        }

        private int _df_welfare;
        public int df_welfare
        {
            get => _df_welfare;
            set => Set(ref _df_welfare, value);
        }

        private int _df_compensation;
        public int df_compensation
        {
            get => _df_compensation;
            set => Set(ref _df_compensation, value);
        }

        private int _df_sortsq;
        public int df_sortsq
        {
            get => _df_sortsq;
            set => Set(ref _df_sortsq, value);
        }

        private string _df_sumgrp;
        public string df_sumgrp
        {
            get => _df_sumgrp;
            set => Set(ref _df_sumgrp, value);
        }

        private string _df_acct;
        public string df_acct
        {
            get => _df_acct;
            set => Set(ref _df_acct, value);
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

        private string _acc_name;
        public string acc_name
        {
            get => _acc_name;
            set => Set(ref _acc_name, value);
        }
    }
}
