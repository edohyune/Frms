using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR600_G30 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private DateTime _apply_date;
        public DateTime apply_date
        {
            get => _apply_date;
            set => Set(ref _apply_date, value);
        }

        private string _grp1_cd;
        public string grp1_cd
        {
            get => _grp1_cd;
            set => Set(ref _grp1_cd, value);
        }

        private string _grp2_cd;
        public string grp2_cd
        {
            get => _grp2_cd;
            set => Set(ref _grp2_cd, value);
        }

        private string _grp3_cd;
        public string grp3_cd
        {
            get => _grp3_cd;
            set => Set(ref _grp3_cd, value);
        }

        private string _grp4_cd;
        public string grp4_cd
        {
            get => _grp4_cd;
            set => Set(ref _grp4_cd, value);
        }

        private string _df_key;
        public string df_key
        {
            get => _df_key;
            set => Set(ref _df_key, value);
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

        private string _acc_name;
        public string acc_name
        {
            get => _acc_name;
            set => Set(ref _acc_name, value);
        }
    }
}
