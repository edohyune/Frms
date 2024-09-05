using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR532_G10 : Libs.MdlBase
    {
        private string _emp_no;
        public string emp_no
        {
            get => _emp_no;
            set => Set(ref _emp_no, value);
        }

        private string _emp_ename;
        public string emp_ename
        {
            get => _emp_ename;
            set => Set(ref _emp_ename, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _dept_name;
        public string dept_name
        {
            get => _dept_name;
            set => Set(ref _dept_name, value);
        }

        private DateTime _start_working_date;
        public DateTime start_working_date
        {
            get => _start_working_date;
            set => Set(ref _start_working_date, value);
        }

        private DateTime _resign_date;
        public DateTime resign_date
        {
            get => _resign_date;
            set => Set(ref _resign_date, value);
        }

        private string _scan_yn;
        public string scan_yn
        {
            get => _scan_yn;
            set => Set(ref _scan_yn, value);
        }

        private string _night_shift_wage;
        public string night_shift_wage
        {
            get => _night_shift_wage;
            set => Set(ref _night_shift_wage, value);
        }

        private DateTime _tmm_date;
        public DateTime tmm_date
        {
            get => _tmm_date;
            set => Set(ref _tmm_date, value);
        }

        private string _min_stamp;
        public string min_stamp
        {
            get => _min_stamp;
            set => Set(ref _min_stamp, value);
        }

        private string _max_stamp;
        public string max_stamp
        {
            get => _max_stamp;
            set => Set(ref _max_stamp, value);
        }

        private string _tmm_in;
        public string tmm_in
        {
            get => _tmm_in;
            set => Set(ref _tmm_in, value);
        }

        private string _tmm_out;
        public string tmm_out
        {
            get => _tmm_out;
            set => Set(ref _tmm_out, value);
        }

        private string _sf_begin;
        public string sf_begin
        {
            get => _sf_begin;
            set => Set(ref _sf_begin, value);
        }

        private string _sf_end;
        public string sf_end
        {
            get => _sf_end;
            set => Set(ref _sf_end, value);
        }

        private string _sf_break_begin;
        public string sf_break_begin
        {
            get => _sf_break_begin;
            set => Set(ref _sf_break_begin, value);
        }

        private string _sf_break_end;
        public string sf_break_end
        {
            get => _sf_break_end;
            set => Set(ref _sf_break_end, value);
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

        private string _ot_time_begin;
        public string ot_time_begin
        {
            get => _ot_time_begin;
            set => Set(ref _ot_time_begin, value);
        }

        private string _ot_time_end;
        public string ot_time_end
        {
            get => _ot_time_end;
            set => Set(ref _ot_time_end, value);
        }

        private string _biz_yn;
        public string biz_yn
        {
            get => _biz_yn;
            set => Set(ref _biz_yn, value);
        }

        private string _tra_yn;
        public string tra_yn
        {
            get => _tra_yn;
            set => Set(ref _tra_yn, value);
        }

        private string _chk;
        public string chk
        {
            get => _chk;
            set => Set(ref _chk, value);
        }

        private string _std_in;
        public string std_in
        {
            get => _std_in;
            set => Set(ref _std_in, value);
        }

        private string _std_out;
        public string std_out
        {
            get => _std_out;
            set => Set(ref _std_out, value);
        }

        private string _err_text;
        public string err_text
        {
            get => _err_text;
            set => Set(ref _err_text, value);
        }
    }
}
