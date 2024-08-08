using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace TST104
{
    public partial class Report1 : DevExpress.XtraReports.UI.XtraReport
    {
        public Report1()
        {
            InitializeComponent();
        }

        public Report1(DataSet dSet)
        {
            InitializeComponent();
        }
    }
}
