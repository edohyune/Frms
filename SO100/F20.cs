using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EpicV004.Frms
{
    public class SO100_F20 : EpicV004.Libs.MdlBase
    {
        private string _sr_doc_no;
        public string sr_doc_no
        {
            get => _sr_doc_no;
            set => Set(ref _sr_doc_no, value);
        }

        private string _sr_rev;
        public string sr_rev
        {
            get => _sr_rev;
            set => Set(ref _sr_rev, value);
        }

        private string _material_full;
        public string material_full
        {
            get => _material_full;
            set => Set(ref _material_full, value);
        }

        private string _material_partial;
        public string material_partial
        {
            get => _material_partial;
            set => Set(ref _material_partial, value);
        }

        private string _material_none;
        public string material_none
        {
            get => _material_none;
            set => Set(ref _material_none, value);
        }

        private string _manpower_qc;
        public string manpower_qc
        {
            get => _manpower_qc;
            set => Set(ref _manpower_qc, value);
        }

        private string _manpower_safety;
        public string manpower_safety
        {
            get => _manpower_safety;
            set => Set(ref _manpower_safety, value);
        }

        private string _manpower_manager;
        public string manpower_manager
        {
            get => _manpower_manager;
            set => Set(ref _manpower_manager, value);
        }

        private string _manpower_engineer;
        public string manpower_engineer
        {
            get => _manpower_engineer;
            set => Set(ref _manpower_engineer, value);
        }

        private string _manpower_supervisor;
        public string manpower_supervisor
        {
            get => _manpower_supervisor;
            set => Set(ref _manpower_supervisor, value);
        }

        private string _etools_full;
        public string etools_full
        {
            get => _etools_full;
            set => Set(ref _etools_full, value);
        }

        private string _etools_partial;
        public string etools_partial
        {
            get => _etools_partial;
            set => Set(ref _etools_partial, value);
        }

        private string _etools_none;
        public string etools_none
        {
            get => _etools_none;
            set => Set(ref _etools_none, value);
        }

    }
}
