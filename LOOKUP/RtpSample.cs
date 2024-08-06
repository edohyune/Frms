using DevExpress.XtraExport.Xlsx;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;

namespace LOOKUP
{
    public partial class RtpSample : DevExpress.XtraReports.UI.XtraReport
    {
        public RtpSample()
        {
            InitializeComponent();
        }

        public RtpSample(DataSet dSet)
        {
            InitializeComponent();
            SetDateSet(dSet);
        }

        private void SetDateSet(DataSet dSet)
        {
            //DetailReport1.DataSource = dSet.Tables[1];

            //pr_no.DataBindings.Add("Text", dSet.Tables[0], "pr_no");
            //rev_no.DataBindings.Add("Text", dSet.Tables[0], "rev_no");
            //pr_date.DataBindings.Add("Text", dSet.Tables[0], "pr_date");

            //unit.DataBindings.Add("Text", dSet.Tables[1], "unit");
            //qty.DataBindings.Add("Text", dSet.Tables[1], "qty", "{0:#,0.00}");
            //unit_price.DataBindings.Add("Text", dSet.Tables[1], "unit_price", "{0:#,0.00}");
            //amt.DataBindings.Add("Text", dSet.Tables[1], "amt", "{0:#,0.00}");
            //rmks.DataBindings.Add("Text", dSet.Tables[1], "rmks");
        }
    }
}
