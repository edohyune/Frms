using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR480_G10 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private long _stt_key;
        public long stt_key
        {
            get => _stt_key;
            set => Set(ref _stt_key, value);
        }

        private string _stt_code;
        public string stt_code
        {
            get => _stt_code;
            set => Set(ref _stt_code, value);
        }

        private string _stt_desc;
        public string stt_desc
        {
            get => _stt_desc;
            set => Set(ref _stt_desc, value);
        }

        private string _stt_e_desc;
        public string stt_e_desc
        {
            get => _stt_e_desc;
            set => Set(ref _stt_e_desc, value);
        }

        private int _stt_df;
        public int stt_df
        {
            get => _stt_df;
            set => Set(ref _stt_df, value);
        }

        private DateTime _stt_date;
        public DateTime stt_date
        {
            get => _stt_date;
            set => Set(ref _stt_date, value);
        }

        private string _stt_enabled;
        public string stt_enabled
        {
            get => _stt_enabled;
            set => Set(ref _stt_enabled, value);
        }

        private int _stt_new_since;
        public int stt_new_since
        {
            get => _stt_new_since;
            set => Set(ref _stt_new_since, value);
        }

        private int _stt_new_next;
        public int stt_new_next
        {
            get => _stt_new_next;
            set => Set(ref _stt_new_next, value);
        }

        private string _stt_type;
        public string stt_type
        {
            get => _stt_type;
            set => Set(ref _stt_type, value);
        }

        private string _stt_guid;
        public string stt_guid
        {
            get => _stt_guid;
            set => Set(ref _stt_guid, value);
        }

        private string _stt_subtype;
        public string stt_subtype
        {
            get => _stt_subtype;
            set => Set(ref _stt_subtype, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _stt_ot;
        public string stt_ot
        {
            get => _stt_ot;
            set => Set(ref _stt_ot, value);
        }

        private string _stt_leave;
        public string stt_leave
        {
            get => _stt_leave;
            set => Set(ref _stt_leave, value);
        }

        private int _sort_order;
        public int sort_order
        {
            get => _sort_order;
            set => Set(ref _sort_order, value);
        }

        private string _stt_att;
        public string stt_att
        {
            get => _stt_att;
            set => Set(ref _stt_att, value);
        }
    }
}
