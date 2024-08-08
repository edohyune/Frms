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
            InitializeComponent();
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
                    case "Open":
                        this.Open();
                        break;
                    case "New":

                        UCFieldSet uCFieldSet = fieldSets.FirstOrDefault((UCFieldSet fs) => fs.wrkId == "f10"); /*-----------------------------Edit WorkSet ID*/
                        if (uCFieldSet != null)
                        {
                            uCFieldSet.New();
                        }

                        UCGridSet uCGridSet = gridSets.FirstOrDefault((UCGridSet gs) => gs.wrkId == "g10"); /*-----------------------------Edit WorkSet ID*/
                        if (uCGridSet != null)
                        {
                            uCGridSet.New();
                        }
                        break;
                    default:
                        base.BarButtonAction(frm, action);
                        break;
                }
            }
        }

        private void ucButton2_Click(object sender, EventArgs e)
        {
            DynamicParameters p = new DynamicParameters();
            //p.Add("@id", id.Text); // Add parameter
            //DataSet dSet = OpenDataSet("tst104_print",p);
            DataSet dSet = OpenDataSet("tst104_print");
            if (Libs.GenFunc.IsEmpty(dSet))
            {
                return;
            }

            Report2 Rpt = new Report2(dSet); // Create the report with the dataset
            DevExpress.XtraReports.UI.ReportPrintTool ReportPrintTool = new DevExpress.XtraReports.UI.ReportPrintTool(Rpt);
            ReportPrintTool.ShowPreviewDialog();



            //DynamicParameters p = new DynamicParameters();
            //p.Add("id",id);


            //DataSet dSet = OpenDataSet("TST104", p);

            //if (Libs.GenFunc.IsEmpty(dSet))
            //    { 
            //    return; 

            //    }
            //Report1 Rpt = new Report1(dSet);
            //ReportPrintTool
        }
    }
}
