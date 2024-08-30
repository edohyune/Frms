using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR671_G10 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _tmt_emp;
        public string tmt_emp
        {
            get => _tmt_emp;
            set => Set(ref _tmt_emp, value);
        }

        private DateTime _tmt_date;
        public DateTime tmt_date
        {
            get => _tmt_date;
            set => Set(ref _tmt_date, value);
        }

        private string _wkday;
        public string wkday
        {
            get => _wkday;
            set => Set(ref _wkday, value);
        }

        private string _tmt_sf;
        public string tmt_sf
        {
            get => _tmt_sf;
            set => Set(ref _tmt_sf, value);
        }

        private string _tmt_stt;
        public string tmt_stt
        {
            get => _tmt_stt;
            set => Set(ref _tmt_stt, value);
        }

        private string _tmt_in;
        public string tmt_in
        {
            get => _tmt_in;
            set => Set(ref _tmt_in, value);
        }

        private string _tmt_out;
        public string tmt_out
        {
            get => _tmt_out;
            set => Set(ref _tmt_out, value);
        }

        private string _tmt_out_nextday;
        public string tmt_out_nextday
        {
            get => _tmt_out_nextday;
            set => Set(ref _tmt_out_nextday, value);
        }

        private int _dummy;
        public int dummy
        {
            get => _dummy;
            set => Set(ref _dummy, value);
        }

        private string _sf_wd_begin;
        public string sf_wd_begin
        {
            get => _sf_wd_begin;
            set => Set(ref _sf_wd_begin, value);
        }

        private string _sf_wd_end;
        public string sf_wd_end
        {
            get => _sf_wd_end;
            set => Set(ref _sf_wd_end, value);
        }

        private string _sf_wd_break_begin;
        public string sf_wd_break_begin
        {
            get => _sf_wd_break_begin;
            set => Set(ref _sf_wd_break_begin, value);
        }

        private string _sf_wd_break_end;
        public string sf_wd_break_end
        {
            get => _sf_wd_break_end;
            set => Set(ref _sf_wd_break_end, value);
        }

        private string _sf_wk_begin;
        public string sf_wk_begin
        {
            get => _sf_wk_begin;
            set => Set(ref _sf_wk_begin, value);
        }

        private string _sf_wk_end;
        public string sf_wk_end
        {
            get => _sf_wk_end;
            set => Set(ref _sf_wk_end, value);
        }

        private string _sf_wk_break_begin;
        public string sf_wk_break_begin
        {
            get => _sf_wk_break_begin;
            set => Set(ref _sf_wk_break_begin, value);
        }

        private string _sf_wk_break_end;
        public string sf_wk_break_end
        {
            get => _sf_wk_break_end;
            set => Set(ref _sf_wk_break_end, value);
        }

        private int _c_work_time;
        public int c_work_time
        {
            get => _c_work_time;
            set => Set(ref _c_work_time, value);
        }

        private int _c_meal_allow;
        public int c_meal_allow
        {
            get => _c_meal_allow;
            set => Set(ref _c_meal_allow, value);
        }

        private int _c_sfwage;
        public int c_sfwage
        {
            get => _c_sfwage;
            set => Set(ref _c_sfwage, value);
        }

        private int _c_work_time_org;
        public int c_work_time_org
        {
            get => _c_work_time_org;
            set => Set(ref _c_work_time_org, value);
        }

        private int _c_meal_allow_org;
        public int c_meal_allow_org
        {
            get => _c_meal_allow_org;
            set => Set(ref _c_meal_allow_org, value);
        }

        private int _c_sfwage_org;
        public int c_sfwage_org
        {
            get => _c_sfwage_org;
            set => Set(ref _c_sfwage_org, value);
        }

        private string _c_req;
        public string c_req
        {
            get => _c_req;
            set => Set(ref _c_req, value);
        }

        private string _tmt_stamp_1;
        public string tmt_stamp_1
        {
            get => _tmt_stamp_1;
            set => Set(ref _tmt_stamp_1, value);
        }

        private string _tmt_stamp_2;
        public string tmt_stamp_2
        {
            get => _tmt_stamp_2;
            set => Set(ref _tmt_stamp_2, value);
        }

        private string _tmt_stamp_3;
        public string tmt_stamp_3
        {
            get => _tmt_stamp_3;
            set => Set(ref _tmt_stamp_3, value);
        }

        private string _tmt_stamp_4;
        public string tmt_stamp_4
        {
            get => _tmt_stamp_4;
            set => Set(ref _tmt_stamp_4, value);
        }

        private string _tmt_stamp_5;
        public string tmt_stamp_5
        {
            get => _tmt_stamp_5;
            set => Set(ref _tmt_stamp_5, value);
        }

        private string _tmt_stamp_6;
        public string tmt_stamp_6
        {
            get => _tmt_stamp_6;
            set => Set(ref _tmt_stamp_6, value);
        }

        private string _tmt_stamp_7;
        public string tmt_stamp_7
        {
            get => _tmt_stamp_7;
            set => Set(ref _tmt_stamp_7, value);
        }

        private string _tmt_stamp_8;
        public string tmt_stamp_8
        {
            get => _tmt_stamp_8;
            set => Set(ref _tmt_stamp_8, value);
        }

        private string _tmt_stamp_9;
        public string tmt_stamp_9
        {
            get => _tmt_stamp_9;
            set => Set(ref _tmt_stamp_9, value);
        }

        private string _tmt_stamp_10;
        public string tmt_stamp_10
        {
            get => _tmt_stamp_10;
            set => Set(ref _tmt_stamp_10, value);
        }

        private string _tmt_stamp_11;
        public string tmt_stamp_11
        {
            get => _tmt_stamp_11;
            set => Set(ref _tmt_stamp_11, value);
        }

        private string _tmt_stamp_12;
        public string tmt_stamp_12
        {
            get => _tmt_stamp_12;
            set => Set(ref _tmt_stamp_12, value);
        }

        private string _tmt_stamp_13;
        public string tmt_stamp_13
        {
            get => _tmt_stamp_13;
            set => Set(ref _tmt_stamp_13, value);
        }

        private string _tmt_stamp_14;
        public string tmt_stamp_14
        {
            get => _tmt_stamp_14;
            set => Set(ref _tmt_stamp_14, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
