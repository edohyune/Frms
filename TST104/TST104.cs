using Dapper;
using DevExpress.CodeParser;
using DevExpress.Utils.Extensions;
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
        public TST104(DataSet dts)
        {
            InitializeComponent();
            DataValue(dts);
            //_Save();
        }
        private void TST104_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("2");
            //g10.Open();
            //this.Open();
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

                        if (string.IsNullOrEmpty(id.Text) || id.Text == "0")
                        {
                            DataSet dts = OpenDataSet("tst104_getnumber");
                            id.Text = DataValue(dts);
                        }
                      
                        if (this.Save())
                        {

                            string newId = id.Text;
                            g10.Open();

                            // Try to focus directly using FocuseByFindedValue
                            g10.FocuseByFindedValue("id", newId);

                            // If the above didn't work (focused row doesn't match newId), 
                            // fall back to the original search
                            if (g10.GetText("id").ToString() != newId)
                            {
                                g10.FocuseByFindedValue("id", searchStr);
                            }
                  

                            ////this.Open();
                            //g10.Open();
                            //g10.FocuseByFindedValue("id", searchStr);
                            ////g10.FocusedRowIndex = 10;

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

       
        private bool _Save()
        {
            //MessageBox.Show("1");
            if (string.IsNullOrEmpty(id.Text) || id.Text == "0")
            {
                DataSet dts = OpenDataSet("tst104_getnumber");
                id.Text = DataValue(dts);
            }
           else {
                if (this.Save())
                {
                    string searchStr = g10.GetText("id").ToString();
                    //   // MessageBox.Show("Save successfully");
                    g10.Open();
                    g10.FocuseByFindedValue("id", searchStr);
                    return true;
                }
            }

            return false;
        }

        private string DataValue(DataSet dts)
        {
            //throw new NotImplementedException();

            if(dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
            {
                return dts.Tables[0].Rows[0][0].ToString();
            }
            return string.Empty;
        } 


    }
    
}
