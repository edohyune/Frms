using Dapper;
using DevExpress.CodeParser;
using DevExpress.XtraCharts.Designer.Native;
using DevExpress.XtraReports.UI;
using EpicV004.Ctrls;
using EpicV004.Libs.Repo;
using System.Data;
using TST104;

namespace EpicV004.Frms
{
    public partial class TST104 : FrmBase
    {
        public TST104()
        {
            InitializeComponent(); this.Open();
        }
        private void TST104_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("2");
            g10.Open();
            //this.Open();
        }
        private void ucButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Mupai Coding Studio!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void g10_UCAfterFocusedRow(object sender, int preIndex, int rowIndex, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //MessageBox.Show(g10.GetText("first_name"));

            //g10.SetText("first_name",[Value])
            //g10.SetText("first_name",[rowIndex],[Value])
        }

        protected override void BarButtonAction(string frm, string action)
        {
            string searchStr = g10.GetText("id").ToString();
            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        if (this.Save())
                        {
                            //this.Open();
                            g10.Open();
                            g10.FocuseByFindedValue("id", searchStr);
                        }
                        //if (this.Save())
                        //{
                        //    this.Open();
                        //}
                        ////this.Save();
                        break;

                    case "New":
                        NewWorkSet("f10");
                        break;
                      
                    default:
                        base.BarButtonAction(frm, action);
                        break;
                }
            }
        }
        //--test2
        //private void ucButton2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DynamicParameters p = new DynamicParameters();
        //        p.Add("@id", id.Text); // Add parameter

        //        DataSet dSet = OpenDataSet("tst104_print", p);

        //        // Debug information
        //        MessageBox.Show($"DataSet contains {dSet.Tables.Count} tables.");
        //        if (dSet.Tables.Count > 0)
        //        {
        //            Console.WriteLine($"Table 0 name: {dSet.Tables[0].TableName}, Row count: {dSet.Tables[0].Rows.Count}");
        //        }

        //        if (Libs.GenFunc.IsEmpty(dSet) || dSet.Tables.Count == 0 || dSet.Tables[0].Rows.Count == 0)
        //        {
        //            MessageBox.Show("No data found for the given ID.");
        //            return;
        //        }

        //        Report2 Rpt = new Report2(dSet); // Create the report with the dataset
        //        DevExpress.XtraReports.UI.ReportPrintTool ReportPrintTool = new DevExpress.XtraReports.UI.ReportPrintTool(Rpt);
        //        ReportPrintTool.ShowPreviewDialog();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
        //    }
        //}

        //--Test1
        //private void ucButton2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DynamicParameters p = new DynamicParameters();
        //        p.Add("@id", id.Text); // Add parameter

        //        DataSet dSet = OpenDataSet("tst104_print", p);

        //        // Debug information
        //        MessageBox.Show($"DataSet contains {dSet.Tables.Count} tables.");
        //        for (int i = 0; i < dSet.Tables.Count; i++)
        //        {
        //            MessageBox.Show($"Table {i} name: {dSet.Tables[i].TableName}, Row count: {dSet.Tables[i].Rows.Count}");
        //        }

        //        if (Libs.GenFunc.IsEmpty(dSet))
        //        {
        //            MessageBox.Show("No data found for the given ID.");
        //            return;
        //        }

        //        if (dSet.Tables.Count < 2)
        //        {
        //            MessageBox.Show("The dataset does not contain the expected number of tables. Please check your SQL query.");
        //            return;
        //        }

        //        Report2 Rpt = new Report2(dSet); // Create the report with the dataset
        //        DevExpress.XtraReports.UI.ReportPrintTool ReportPrintTool = new DevExpress.XtraReports.UI.ReportPrintTool(Rpt);
        //        ReportPrintTool.ShowPreviewDialog();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
        //    }
        //}

        //--test0
        private void ucButton2_Click(object sender, EventArgs e)
        {
            //DynamicParameters p = new DynamicParameters();
            //p.Add("@id", id.Text); // Add parameter
            //DataSet dSet = OpenDataSet("tst104_print",p);
            DataSet dSet = OpenDataSet("tst104_print");
            //MessageBox.Show(dSet.Tables.Count.ToString());
            if (Libs.GenFunc.IsEmpty(dSet))
            {
                return;
            }

            Report2 Rpt = new Report2(dSet); // Create the report with the dataset
            DevExpress.XtraReports.UI.ReportPrintTool ReportPrintTool = new DevExpress.XtraReports.UI.ReportPrintTool(Rpt);
            ReportPrintTool.ShowPreviewDialog();

        }
    }
}
