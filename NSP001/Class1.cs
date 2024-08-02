using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class NSP001_G10 : EpicV004.Libs.MdlBase
    {
        private int _SupplierID;
        public int SupplierID
        {
            get => _SupplierID;
            set => Set(ref _SupplierID, value);
        }

        private string _SupplierName;
        public string SupplierName
        {
            get => _SupplierName;
            set => Set(ref _SupplierName, value);
        }

        private string _ContactName;
        public string ContactName
        {
            get => _ContactName;
            set => Set(ref _ContactName, value);
        }

        private string _ContactEmail;
        public string ContactEmail
        {
            get => _ContactEmail;
            set => Set(ref _ContactEmail, value);
        }

        private string _Phone;
        public string Phone
        {
            get => _Phone;
            set => Set(ref _Phone, value);
        }

        private string _Address;
        public string Address
        {
            get => _Address;
            set => Set(ref _Address, value);
        }

        private string _City;
        public string City
        {
            get => _City;
            set => Set(ref _City, value);
        }

        private string _State;
        public string State
        {
            get => _State;
            set => Set(ref _State, value);
        }

        private string _ZipCode;
        public string ZipCode
        {
            get => _ZipCode;
            set => Set(ref _ZipCode, value);
        }

        private string _Country;
        public string Country
        {
            get => _Country;
            set => Set(ref _Country, value);
        }

        private string _Website;
        public string Website
        {
            get => _Website;
            set => Set(ref _Website, value);
        }

        private string _Memo;
        public string Memo
        {
            get => _Memo;
            set => Set(ref _Memo, value);
        }
    }

    public class NSP001_G20 : NSP001_G10
    {
        // Additional properties or methods specific to NSP001_G20
        private string _G20SpecificProperty;
        public string G20SpecificProperty
        {
            get => _G20SpecificProperty;
            set => Set(ref _G20SpecificProperty, value);
        }

       
    }



    public class NSP001_F10 : NSP001_G10
    {
        // Additional properties or methods specific to NSP001_G20
        private string _F10SpecificProperty;
        public string F10SpecificProperty
        {
            get => _F10SpecificProperty;
            set => Set(ref _F10SpecificProperty, value);
        }


    }
}
