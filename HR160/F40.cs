using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR160_F40 : EpicV004.Libs.MdlBase
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

        private string _tax_calc_method;
        public string tax_calc_method
        {
            get => _tax_calc_method;
            set => Set(ref _tax_calc_method, value);
        }

        private string _tax_form_method;
        public string tax_form_method
        {
            get => _tax_form_method;
            set => Set(ref _tax_form_method, value);
        }

        private decimal _donate_school;
        public decimal donate_school
        {
            get => _donate_school;
            set => Set(ref _donate_school, value);
        }

        private decimal _donations;
        public decimal donations
        {
            get => _donations;
            set => Set(ref _donations, value);
        }

        private decimal _sum_allowance;
        public decimal sum_allowance
        {
            get => _sum_allowance;
            set => Set(ref _sum_allowance, value);
        }

        private decimal _residence_values;
        public decimal residence_values
        {
            get => _residence_values;
            set => Set(ref _residence_values, value);
        }

        private decimal _gov_pension_fund;
        public decimal gov_pension_fund
        {
            get => _gov_pension_fund;
            set => Set(ref _gov_pension_fund, value);
        }

        private decimal _teachers_fund;
        public decimal teachers_fund
        {
            get => _teachers_fund;
            set => Set(ref _teachers_fund, value);
        }

        private decimal _national_saving_fund;
        public decimal national_saving_fund
        {
            get => _national_saving_fund;
            set => Set(ref _national_saving_fund, value);
        }

        private decimal _years_65old;
        public decimal years_65old
        {
            get => _years_65old;
            set => Set(ref _years_65old, value);
        }

        private decimal _spouse_65years;
        public decimal spouse_65years
        {
            get => _spouse_65years;
            set => Set(ref _spouse_65years, value);
        }

        private decimal _compensation;
        public decimal compensation
        {
            get => _compensation;
            set => Set(ref _compensation, value);
        }

        private decimal _tax_calc_period;
        public decimal tax_calc_period
        {
            get => _tax_calc_period;
            set => Set(ref _tax_calc_period, value);
        }

        private decimal _income_prev_emp;
        public decimal income_prev_emp
        {
            get => _income_prev_emp;
            set => Set(ref _income_prev_emp, value);
        }

        private decimal _tax_prev_emp;
        public decimal tax_prev_emp
        {
            get => _tax_prev_emp;
            set => Set(ref _tax_prev_emp, value);
        }

        private string _spouse_deduction;
        public string spouse_deduction
        {
            get => _spouse_deduction;
            set => Set(ref _spouse_deduction, value);
        }

        private string _marital_status;
        public string marital_status
        {
            get => _marital_status;
            set => Set(ref _marital_status, value);
        }

        private decimal _anter_prev_year;
        public decimal anter_prev_year
        {
            get => _anter_prev_year;
            set => Set(ref _anter_prev_year, value);
        }

        private decimal _anter_current_year;
        public decimal anter_current_year
        {
            get => _anter_current_year;
            set => Set(ref _anter_current_year, value);
        }

        private int _child_deduction1;
        public int child_deduction1
        {
            get => _child_deduction1;
            set => Set(ref _child_deduction1, value);
        }

        private int _child_deduction2;
        public int child_deduction2
        {
            get => _child_deduction2;
            set => Set(ref _child_deduction2, value);
        }

        private int _child_deduction3;
        public int child_deduction3
        {
            get => _child_deduction3;
            set => Set(ref _child_deduction3, value);
        }

        private int _child_deduction4;
        public int child_deduction4
        {
            get => _child_deduction4;
            set => Set(ref _child_deduction4, value);
        }

        private string _sponsor_father;
        public string sponsor_father
        {
            get => _sponsor_father;
            set => Set(ref _sponsor_father, value);
        }

        private string _sponsor_mother;
        public string sponsor_mother
        {
            get => _sponsor_mother;
            set => Set(ref _sponsor_mother, value);
        }

        private string _sponsor_father_spouse;
        public string sponsor_father_spouse
        {
            get => _sponsor_father_spouse;
            set => Set(ref _sponsor_father_spouse, value);
        }

        private string _sponsor_mother_spouse;
        public string sponsor_mother_spouse
        {
            get => _sponsor_mother_spouse;
            set => Set(ref _sponsor_mother_spouse, value);
        }

        private string _insurance_father;
        public string insurance_father
        {
            get => _insurance_father;
            set => Set(ref _insurance_father, value);
        }

        private string _insurance_mother;
        public string insurance_mother
        {
            get => _insurance_mother;
            set => Set(ref _insurance_mother, value);
        }

        private decimal _sum_insurance;
        public decimal sum_insurance
        {
            get => _sum_insurance;
            set => Set(ref _sum_insurance, value);
        }

        private string _insurance_father_spouse;
        public string insurance_father_spouse
        {
            get => _insurance_father_spouse;
            set => Set(ref _insurance_father_spouse, value);
        }

        private string _insurance_mother_spouse;
        public string insurance_mother_spouse
        {
            get => _insurance_mother_spouse;
            set => Set(ref _insurance_mother_spouse, value);
        }

        private decimal _sum_insurance_spouse;
        public decimal sum_insurance_spouse
        {
            get => _sum_insurance_spouse;
            set => Set(ref _sum_insurance_spouse, value);
        }

        private decimal _life_insurance;
        public decimal life_insurance
        {
            get => _life_insurance;
            set => Set(ref _life_insurance, value);
        }

        private decimal _pension_insurance;
        public decimal pension_insurance
        {
            get => _pension_insurance;
            set => Set(ref _pension_insurance, value);
        }

        private decimal _house_interest;
        public decimal house_interest
        {
            get => _house_interest;
            set => Set(ref _house_interest, value);
        }

        private decimal _life_insurance_spouse;
        public decimal life_insurance_spouse
        {
            get => _life_insurance_spouse;
            set => Set(ref _life_insurance_spouse, value);
        }

        private decimal _pension_insurance_spouse;
        public decimal pension_insurance_spouse
        {
            get => _pension_insurance_spouse;
            set => Set(ref _pension_insurance_spouse, value);
        }

        private decimal _house_interest_spouse;
        public decimal house_interest_spouse
        {
            get => _house_interest_spouse;
            set => Set(ref _house_interest_spouse, value);
        }

        private decimal _exem_income_disabled;
        public decimal exem_income_disabled
        {
            get => _exem_income_disabled;
            set => Set(ref _exem_income_disabled, value);
        }

        private decimal _retire_mutual_fund;
        public decimal retire_mutual_fund
        {
            get => _retire_mutual_fund;
            set => Set(ref _retire_mutual_fund, value);
        }

        private decimal _long_term_fund;
        public decimal long_term_fund
        {
            get => _long_term_fund;
            set => Set(ref _long_term_fund, value);
        }

        private decimal _income_real_estate;
        public decimal income_real_estate
        {
            get => _income_real_estate;
            set => Set(ref _income_real_estate, value);
        }

        private decimal _property_value;
        public decimal property_value
        {
            get => _property_value;
            set => Set(ref _property_value, value);
        }

        private decimal _travel_expense;
        public decimal travel_expense
        {
            get => _travel_expense;
            set => Set(ref _travel_expense, value);
        }

        private decimal _purchase_goods;
        public decimal purchase_goods
        {
            get => _purchase_goods;
            set => Set(ref _purchase_goods, value);
        }

        private decimal _etc;
        public decimal etc
        {
            get => _etc;
            set => Set(ref _etc, value);
        }

        private string _tax_force_enabled;
        public string tax_force_enabled
        {
            get => _tax_force_enabled;
            set => Set(ref _tax_force_enabled, value);
        }

        private decimal _tax_force_amt;
        public decimal tax_force_amt
        {
            get => _tax_force_amt;
            set => Set(ref _tax_force_amt, value);
        }

        private string _tax_yr_force_enabled;
        public string tax_yr_force_enabled
        {
            get => _tax_yr_force_enabled;
            set => Set(ref _tax_yr_force_enabled, value);
        }

        private decimal _tax_yr_force_amt;
        public decimal tax_yr_force_amt
        {
            get => _tax_yr_force_amt;
            set => Set(ref _tax_yr_force_amt, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
