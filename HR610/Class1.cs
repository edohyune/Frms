using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR610_G10 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private int _pts_seq;
        public int pts_seq
        {
            get => _pts_seq;
            set => Set(ref _pts_seq, value);
        }

        private int _pts_step;
        public int pts_step
        {
            get => _pts_step;
            set => Set(ref _pts_step, value);
        }

        private string _pts_desc;
        public string pts_desc
        {
            get => _pts_desc;
            set => Set(ref _pts_desc, value);
        }

        private string _pts_e_desc;
        public string pts_e_desc
        {
            get => _pts_e_desc;
            set => Set(ref _pts_e_desc, value);
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
    }
}
