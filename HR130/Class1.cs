using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR130_G10 : Libs.MdlBase
    {
        public long pid { get; set; }
        public string applicant_id { get; set; }
        public DateTime apply_date { get; set; }
        public string title { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string first_name_eng { get; set; }
        public string last_name_eng { get; set; }
        public string other_lang_name { get; set; }
        public string nick_name { get; set; }
        public string account_type { get; set; }
        public string gender { get; set; }
        public string marital { get; set; }
        public string tax_id { get; set; }
        public string line_id { get; set; }
        public DateTime birth_date { get; set; }
        public string memo { get; set; }
        public string other_msg { get; set; }
        public string current_addr1 { get; set; }
        public string current_addr2 { get; set; }
        public string current_addr3 { get; set; }
        public string current_postage { get; set; }
        public string current_tel_no { get; set; }
        public string current_email { get; set; }
        public string current_province { get; set; }
        public string current_district { get; set; }
        public string current_road { get; set; }
        public string current_country { get; set; }
        public string place_of_birth { get; set; }
        public string ethnicity { get; set; }
        public string nationality { get; set; }
        public string religion { get; set; }
        public string military { get; set; }
        public string blood { get; set; }
        public decimal height { get; set; }
        public decimal weight { get; set; }
        public string id_card_no { get; set; }
        public DateTime id_card_expire_dt { get; set; }
        public string id_card_addr1 { get; set; }
        public string id_card_addr2 { get; set; }
        public string id_card_addr3 { get; set; }
        public string id_card_province { get; set; }
        public string id_card_district { get; set; }
        public string id_card_road { get; set; }
        public string id_card_country { get; set; }
        public string id_card_postage { get; set; }
        public string emergency_contact_name { get; set; }
        public string emergency_contact_postage { get; set; }
        public string emergency_contact_addr1 { get; set; }
        public string emergency_contact_addr2 { get; set; }
        public string emergency_contact_addr3 { get; set; }
        public string emergency_contact_tel_no { get; set; }
        public string emergency_contact_relation { get; set; }
        public string pass_interview { get; set; }
        public string pass_health_check { get; set; }
        public int trans_emp_master { get; set; }
        public string emp_no { get; set; }
        public string black_list_yn { get; set; }
        public string resign_in_3mon { get; set; }
        public string doc_no { get; set; }
        public string selected { get; set; }
        public string messenger_use { get; set; }
        public string chk_criminal { get; set; }
        public string criminal_memo { get; set; }
        public string chk_disease { get; set; }
        public string disease_memo { get; set; }
        public string emp_category { get; set; }
        public string employee_type { get; set; }
        public DateTime order_date { get; set; }
        public string job_class { get; set; }
        public string position { get; set; }
        public string dept { get; set; }
        public string project { get; set; }
        public string job_site { get; set; }
        public string section { get; set; }
        public string chk_foreigner { get; set; }
        public string issue_no { get; set; }
        public DateTime salary_date { get; set; }
        public string salary_category { get; set; }
        public decimal salary_rate { get; set; }
        public string lumpsum_yn { get; set; }
        public string payment_method { get; set; }
        public string bank_name { get; set; }
        public string bank_account_no { get; set; }
        public string status { get; set; }
    }
}
