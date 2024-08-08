using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace TST104
{
    public partial class Report2 : DevExpress.XtraReports.UI.XtraReport
    {
        public Report2()
        {
            InitializeComponent();
        }

        public Report2(DataSet dSet)
        {
            InitializeComponent();
        }

        private void xrTable8_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
