using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HS600_G10 : EpicV004.Libs.MdlBase
    {
        private string _emp_name;
        public string emp_name
        {
            get => _emp_name;
            set => Set(ref _emp_name, value);
        }

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

        private string _emp_relation;
        public string emp_relation
        {
            get => _emp_relation;
            set => Set(ref _emp_relation, value);
        }

        private string _emp_family_name;
        public string emp_family_name
        {
            get => _emp_family_name;
            set => Set(ref _emp_family_name, value);
        }

        private DateTime _date_visa_expire;
        public DateTime date_visa_expire
        {
            get => _date_visa_expire;
            set => Set(ref _date_visa_expire, value);
        }

        private DateTime _date_work_permit_expire;
        public DateTime date_work_permit_expire
        {
            get => _date_work_permit_expire;
            set => Set(ref _date_work_permit_expire, value);
        }

        private DateTime _date_90;
        public DateTime date_90
        {
            get => _date_90;
            set => Set(ref _date_90, value);
        }

        private DateTime _date_arrival_1st;
        public DateTime date_arrival_1st
        {
            get => _date_arrival_1st;
            set => Set(ref _date_arrival_1st, value);
        }

        private DateTime _date_lastest_arrival;
        public DateTime date_lastest_arrival
        {
            get => _date_lastest_arrival;
            set => Set(ref _date_lastest_arrival, value);
        }

        private DateTime _date_lastest_departure;
        public DateTime date_lastest_departure
        {
            get => _date_lastest_departure;
            set => Set(ref _date_lastest_departure, value);
        }

        private string _reentry_type;
        public string reentry_type
        {
            get => _reentry_type;
            set => Set(ref _reentry_type, value);
        }

        private DateTime _date_reentry_expire;
        public DateTime date_reentry_expire
        {
            get => _date_reentry_expire;
            set => Set(ref _date_reentry_expire, value);
        }

        private string _passport_no;
        public string passport_no
        {
            get => _passport_no;
            set => Set(ref _passport_no, value);
        }

        private DateTime _date_passport_issue;
        public DateTime date_passport_issue
        {
            get => _date_passport_issue;
            set => Set(ref _date_passport_issue, value);
        }

        private DateTime _date_passport_expire;
        public DateTime date_passport_expire
        {
            get => _date_passport_expire;
            set => Set(ref _date_passport_expire, value);
        }

        private string _work_permit_no;
        public string work_permit_no
        {
            get => _work_permit_no;
            set => Set(ref _work_permit_no, value);
        }

        private string _foreign_id_no;
        public string foreign_id_no
        {
            get => _foreign_id_no;
            set => Set(ref _foreign_id_no, value);
        }

        private string _ss_no;
        public string ss_no
        {
            get => _ss_no;
            set => Set(ref _ss_no, value);
        }

        private string _tax_id_no;
        public string tax_id_no
        {
            get => _tax_id_no;
            set => Set(ref _tax_id_no, value);
        }

        private DateTime _date_birth;
        public DateTime date_birth
        {
            get => _date_birth;
            set => Set(ref _date_birth, value);
        }

        private string _visa_type;
        public string visa_type
        {
            get => _visa_type;
            set => Set(ref _visa_type, value);
        }

        private string _nationality;
        public string nationality
        {
            get => _nationality;
            set => Set(ref _nationality, value);
        }

        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _pink_card_no;
        public string pink_card_no
        {
            get => _pink_card_no;
            set => Set(ref _pink_card_no, value);
        }

        private DateTime _date_pink_card_issue;
        public DateTime date_pink_card_issue
        {
            get => _date_pink_card_issue;
            set => Set(ref _date_pink_card_issue, value);
        }

        private DateTime _date_pink_card_expire;
        public DateTime date_pink_card_expire
        {
            get => _date_pink_card_expire;
            set => Set(ref _date_pink_card_expire, value);
        }

        private string _tm6_no;
        public string tm6_no
        {
            get => _tm6_no;
            set => Set(ref _tm6_no, value);
        }

        private string _ss_entitlement;
        public string ss_entitlement
        {
            get => _ss_entitlement;
            set => Set(ref _ss_entitlement, value);
        }

        private string _ss_unregistered;
        public string ss_unregistered
        {
            get => _ss_unregistered;
            set => Set(ref _ss_unregistered, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _is_active;
        public string is_active
        {
            get => _is_active;
            set => Set(ref _is_active, value);
        }

        private string _deleted;
        public string deleted
        {
            get => _deleted;
            set => Set(ref _deleted, value);
        }
    }
}
