using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class TST104_G20 : EpicV004.Libs.MdlBase
    {
        private int _id;
        public int id
        {
            get => _id;
            set => Set(ref _id, value);
        }

        private int _sq;
        public int sq
        {
            get => _sq;
            set => Set(ref _sq, value);
        }

        private string _person;
        public string person
        {
            get => _person;
            set => Set(ref _person, value);
        }

        private string _phone;
        public string phone
        {
            get => _phone;
            set => Set(ref _phone, value);
        }

        private string _email;
        public string email
        {
            get => _email;
            set => Set(ref _email, value);
        }

        private string _position;
        public string position
        {
            get => _position;
            set => Set(ref _position, value);
        }

        private string _memo;
        public string memo
        {
            get => _memo;
            set => Set(ref _memo, value);
        }


    }
}