using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class HR470_G10 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private int _year;
        public int year
        {
            get => _year;
            set => Set(ref _year, value);
        }

        private DateTime _holiday_date;
        public DateTime holiday_date
        {
            get => _holiday_date;
            set => Set(ref _holiday_date, value);
        }

        private string _holiday_name;
        public string holiday_name
        {
            get => _holiday_name;
            set => Set(ref _holiday_name, value);
        }

        private string _holiday_name_eng;
        public string holiday_name_eng
        {
            get => _holiday_name_eng;
            set => Set(ref _holiday_name_eng, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }

        private string _stt_key;
        public string stt_key
        {
            get => _stt_key;
            set => Set(ref _stt_key, value);
        }
    }

    public class HR470_G20 : HR470_G10
    {
        // Additional properties or methods specific to AppRegister_G10
        private string _G20SpecificProperty;
        public string G20SpecificProperty
        {
            get => _G20SpecificProperty;
            set => Set(ref _G20SpecificProperty, value);
        }


    }
}


