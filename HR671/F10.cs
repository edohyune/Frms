using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR671_F10 : Libs.MdlBase
    {
        private int _yy;
        public int yy
        {
            get => _yy;
            set => Set(ref _yy, value);
        }

        private int _mm;
        public int mm
        {
            get => _mm;
            set => Set(ref _mm, value);
        }

        private int _emp_type;
        public int emp_type
        {
            get => _emp_type;
            set => Set(ref _emp_type, value);
        }

        private DateTime _salary_date;
        public DateTime salary_date
        {
            get => _salary_date;
            set => Set(ref _salary_date, value);
        }

        private DateTime _salary_sdate;
        public DateTime salary_sdate
        {
            get => _salary_sdate;
            set => Set(ref _salary_sdate, value);
        }

        private DateTime _salary_edate;
        public DateTime salary_edate
        {
            get => _salary_edate;
            set => Set(ref _salary_edate, value);
        }
    }
}
