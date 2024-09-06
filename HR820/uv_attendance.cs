using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR820_G10 : Libs.MdlBase
    {
        private string _tmt_emp;
        public string tmt_emp
        {
            get => _tmt_emp;
            set => Set(ref _tmt_emp, value);
        }

        private string _name;
        public string name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private string _other_lang_name;
        public string other_lang_name
        {
            get => _other_lang_name;
            set => Set(ref _other_lang_name, value);
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

        private string _position;
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _section;
        public string section
        {
            get => _section;
            set => Set(ref _section, value);
        }

        private string _job_site;
        public string job_site
        {
            get => _job_site;
            set => Set(ref _job_site, value);
        }

        private DateTime _tmt_date;
        public DateTime tmt_date
        {
            get => _tmt_date;
            set => Set(ref _tmt_date, value);
        }

        private int _wkday;
        public int wkday
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

        private string _sf_e_name;
        public string sf_e_name
        {
            get => _sf_e_name;
            set => Set(ref _sf_e_name, value);
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

        private string _dsmart_in;
        public string dsmart_in
        {
            get => _dsmart_in;
            set => Set(ref _dsmart_in, value);
        }

        private string _dsmart_out;
        public string dsmart_out
        {
            get => _dsmart_out;
            set => Set(ref _dsmart_out, value);
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

        private int _late;
        public int late
        {
            get => _late;
            set => Set(ref _late, value);
        }

        private int _early;
        public int early
        {
            get => _early;
            set => Set(ref _early, value);
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

        private string _leave_yn;
        public string leave_yn
        {
            get => _leave_yn;
            set => Set(ref _leave_yn, value);
        }

        private string _leave_ty;
        public string leave_ty
        {
            get => _leave_ty;
            set => Set(ref _leave_ty, value);
        }

        private decimal _leave_time;
        public decimal leave_time
        {
            get => _leave_time;
            set => Set(ref _leave_time, value);
        }

        private string _leave_yn_org;
        public string leave_yn_org
        {
            get => _leave_yn_org;
            set => Set(ref _leave_yn_org, value);
        }

        private string _leave_ty_org;
        public string leave_ty_org
        {
            get => _leave_ty_org;
            set => Set(ref _leave_ty_org, value);
        }

        private string _ot_type;
        public string ot_type
        {
            get => _ot_type;
            set => Set(ref _ot_type, value);
        }

        private string _ot_fr;
        public string ot_fr
        {
            get => _ot_fr;
            set => Set(ref _ot_fr, value);
        }

        private string _ot_to;
        public string ot_to
        {
            get => _ot_to;
            set => Set(ref _ot_to, value);
        }

        private int _ot_time;
        public int ot_time
        {
            get => _ot_time;
            set => Set(ref _ot_time, value);
        }

        private string _ot_type_org;
        public string ot_type_org
        {
            get => _ot_type_org;
            set => Set(ref _ot_type_org, value);
        }

        private string _ot_fr_org;
        public string ot_fr_org
        {
            get => _ot_fr_org;
            set => Set(ref _ot_fr_org, value);
        }

        private string _ot_to_org;
        public string ot_to_org
        {
            get => _ot_to_org;
            set => Set(ref _ot_to_org, value);
        }

        private int _ot_time_org;
        public int ot_time_org
        {
            get => _ot_time_org;
            set => Set(ref _ot_time_org, value);
        }

        private string _night_shift_wage;
        public string night_shift_wage
        {
            get => _night_shift_wage;
            set => Set(ref _night_shift_wage, value);
        }
    }
}
