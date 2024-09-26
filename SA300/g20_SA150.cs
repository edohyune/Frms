using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
   public class SA300_G20 : Libs.MdlBase
    {
        private long _pid;
        public long pid
        {
            get => _pid;
            set => Set(ref _pid, value);
        }

        private string _temp_cd;
        public string temp_cd
        {
            get => _temp_cd;
            set => Set(ref _temp_cd, value);
        }

        private string _step_no;
        public string step_no
        {
            get => _step_no;
            set => Set(ref _step_no, value);
        }

        private string _step_no2;
        public string step_no2
        {
            get => _step_no2;
            set => Set(ref _step_no2, value);
        }

        private string _step_no3;
        public string step_no3
        {
            get => _step_no3;
            set => Set(ref _step_no3, value);
        }

        private string _step_name;
        public string step_name
        {
            get => _step_name;
            set => Set(ref _step_name, value);
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

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }
    }
}
