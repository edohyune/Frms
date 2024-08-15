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
            InitializeComponent(); //this.Open();
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
                        break;

                    case "New":
                        NewWorkSet("f10");
                        NewWorkSet("g10");
                        break;

                    default:
                        base.BarButtonAction(frm, action);
                        break;
                }
            }
        }
       
        private void ucButton2_Click(object sender, EventArgs e)
        {
            //DynamicParameters p = new DynamicParameters();
            //p.Add("@id", id.Text); // Add parameter
            //DataSet dSet = OpenDataSet("tst104_print",p);
            DataSet dSet = OpenDataSet("tst104_print");
            // MessageBox.Show(dSet.Tables.Count.ToString());
            if (Libs.GenFunc.IsEmpty(dSet))
            {
                return;
            }

            Report2 Rpt = new Report2(dSet); // Create the report with the dataset
            DevExpress.XtraReports.UI.ReportPrintTool ReportPrintTool = new DevExpress.XtraReports.UI.ReportPrintTool(Rpt);
            ReportPrintTool.ShowPreviewDialog();

        }

        private void ucButton1_Click_1(object sender, EventArgs e)
        {
            gend.Code = "01";
        }

        private void ucButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gend.Code);
        }

        private void s_txt_UCEditValueChanged(object Sender, Control control)
        {

        }
    }
}
