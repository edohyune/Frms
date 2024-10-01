using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public class SP160_G10 : EpicV004.Libs.MdlBase
    {
        private string _project;
        public string project
        {
            get => _project;
            set => Set(ref _project, value);
        }

        private string _dept;
        public string dept
        {
            get => _dept;
            set => Set(ref _dept, value);
        }

        private string _dept_nm;
        public string dept_nm
        {
            get => _dept_nm;
            set => Set(ref _dept_nm, value);
        }

        private string _fr_wh;
        public string fr_wh
        {
            get => _fr_wh;
            set => Set(ref _fr_wh, value);
        }

        private string _item;
        public string item
        {
            get => _item;
            set => Set(ref _item, value);
        }

        private string _item_name;
        public string item_name
        {
            get => _item_name;
            set => Set(ref _item_name, value);
        }

        private DateTime _issue_date;
        public DateTime issue_date
        {
            get => _issue_date;
            set => Set(ref _issue_date, value);
        }

        private string _rcv_no;
        public string rcv_no
        {
            get => _rcv_no;
            set => Set(ref _rcv_no, value);
        }

        private int _rcv_sq;
        public int rcv_sq
        {
            get => _rcv_sq;
            set => Set(ref _rcv_sq, value);
        }

        private string _req_no;
        public string req_no
        {
            get => _req_no;
            set => Set(ref _req_no, value);
        }

        private string _unit;
        public string unit
        {
            get => _unit;
            set => Set(ref _unit, value);
        }

        private decimal _fifo_qty;
        public decimal fifo_qty
        {
            get => _fifo_qty;
            set => Set(ref _fifo_qty, value);
        }

        private decimal _price;
        public decimal price
        {
            get => _price;
            set => Set(ref _price, value);
        }

        private decimal _fifo_amt;
        public decimal fifo_amt
        {
            get => _fifo_amt;
            set => Set(ref _fifo_amt, value);
        }

        private string _category1;
        public string category1
        {
            get => _category1;
            set => Set(ref _category1, value);
        }

        private string _category2;
        public string category2
        {
            get => _category2;
            set => Set(ref _category2, value);
        }

        private string _po_no;
        public string po_no
        {
            get => _po_no;
            set => Set(ref _po_no, value);
        }

        private int _po_sq;
        public int po_sq
        {
            get => _po_sq;
            set => Set(ref _po_sq, value);
        }

        private string _memo_line;
        public string memo_line
        {
            get => _memo_line;
            set => Set(ref _memo_line, value);
        }

        private string _status;
        public string status
        {
            get => _status;
            set => Set(ref _status, value);
        }

    }
}
