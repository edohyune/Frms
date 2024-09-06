using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR550_G20 : Libs.MdlBase
    {
        private long _bh;
        public long bh
        {
            get => _bh;
            set => Set(ref _bh, value);
        }

        private long _user_serial;
        public long user_serial
        {
            get => _user_serial;
            set => Set(ref _user_serial, value);
        }

        private string _user_no;
        public string user_no
        {
            get => _user_no;
            set => Set(ref _user_no, value);
        }

        private string _user_lname;
        public string user_lname
        {
            get => _user_lname;
            set => Set(ref _user_lname, value);
        }

        private string _dep_no;
        public string dep_no
        {
            get => _dep_no;
            set => Set(ref _dep_no, value);
        }

        private int _user_dep;
        public int user_dep
        {
            get => _user_dep;
            set => Set(ref _user_dep, value);
        }

        private string _user_depname;
        public string user_depname
        {
            get => _user_depname;
            set => Set(ref _user_depname, value);
        }

        private int _user_type;
        public int user_type
        {
            get => _user_type;
            set => Set(ref _user_type, value);
        }

        private string _user_card;
        public string user_card
        {
            get => _user_card;
            set => Set(ref _user_card, value);
        }

        private DateTime _sj;
        public DateTime sj
        {
            get => _sj;
            set => Set(ref _sj, value);
        }

        private DateTime _date;
        public DateTime date
        {
            get => _date;
            set => Set(ref _date, value);
        }

        private string _time;
        public string time
        {
            get => _time;
            set => Set(ref _time, value);
        }

        private string _iden;
        public string iden
        {
            get => _iden;
            set => Set(ref _iden, value);
        }

        private int _fx;
        public int fx
        {
            get => _fx;
            set => Set(ref _fx, value);
        }

        private int _jlzp_serial;
        public int jlzp_serial
        {
            get => _jlzp_serial;
            set => Set(ref _jlzp_serial, value);
        }

        private string _dev_serial;
        public string dev_serial
        {
            get => _dev_serial;
            set => Set(ref _dev_serial, value);
        }

        private string _mc;
        public string mc
        {
            get => _mc;
            set => Set(ref _mc, value);
        }
    }
}
