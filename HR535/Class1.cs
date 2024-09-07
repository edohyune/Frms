using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR535_G10 : EpicV004.Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private DateTime _leave_date;
        public DateTime leave_date
        {
            get => _leave_date;
            set => Set(ref _leave_date, value);
        }

        private string _leave_type;
        public string leave_type
        {
            get => _leave_type;
            set => Set(ref _leave_type, value);
        }

        private string _leave_begin;
        public string leave_begin
        {
            get => _leave_begin;
            set => Set(ref _leave_begin, value);
        }

        private string _leave_fr_time;
        public string leave_fr_time
        {
            get => _leave_fr_time;
            set => Set(ref _leave_fr_time, value);
        }

        private string _leave_to_time;
        public string leave_to_time
        {
            get => _leave_to_time;
            set => Set(ref _leave_to_time, value);
        }

        private decimal _leave_time;
        public decimal leave_time
        {
            get => _leave_time;
            set => Set(ref _leave_time, value);
        }

        private string _leave_fr_time_org;
        public string leave_fr_time_org
        {
            get => _leave_fr_time_org;
            set => Set(ref _leave_fr_time_org, value);
        }

        private string _leave_to_time_org;
        public string leave_to_time_org
        {
            get => _leave_to_time_org;
            set => Set(ref _leave_to_time_org, value);
        }

        private decimal _leave_time_org;
        public decimal leave_time_org
        {
            get => _leave_time_org;
            set => Set(ref _leave_time_org, value);
        }

        private string _doc_no;
        public string doc_no
        {
            get => _doc_no;
            set => Set(ref _doc_no, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        private string _upload_yn;
        public string upload_yn
        {
            get => _upload_yn;
            set => Set(ref _upload_yn, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _other_lang_name;
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
        }

        private int _cid;
        public int cid
        {
            get => _cid;
            set => Set(ref _cid, value);
        }

        private DateTime _cdt;
        public DateTime cdt
        {
            get => _cdt;
            set => Set(ref _cdt, value);
        }

    }
}
