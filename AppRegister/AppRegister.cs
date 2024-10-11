using DevExpress.Utils.Extensions;
using EpicV004.Ctrls;
using EpicV004.Libs.Repo;
using System.Data;

namespace EpicV004.Frms

{
    public partial class AppRegister : FrmBase
    {
        public AppRegister()
        {
            InitializeComponent();
        }

        protected override void BarButtonAction(string frm, string action)
        {

            string searchStr = g10.GetText("applicant_id").ToString(); // Get the ID of the current row
            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        if (this.Save())

                        {
                            g10.Open(); // Reload the grid data
                            g10.FocuseByFindedValue("applicant_id", searchStr); // Focus the row with the saved ID

                            //    g20.Open();
                            //    g20.FocuseByFindedValue("applicant_id", searchStr);

                            //    g30.Open();
                            //    g30.FocuseByFindedValue("applicant_id", searchStr);

                            //    g40.Open();
                            //    g40.FocuseByFindedValue("applicant_id", searchStr);

                            //    g50.Open();
                            //    g50.FocuseByFindedValue("applicant_id", searchStr);
                        }
                        break;
                    case "Open":
                        switch (ucTab1.SelectedTabPage.Name)
                        {
                            //case "xtraTabPage1":
                            case "xtraTabPage2":
                                g20.Open();
                                break;
                            case "xtraTabPage3":
                                g30.Open();
                                break;
                            case "xtraTabPage4":
                                g40.Open();
                                break;
                            case "xtraTabPage5":
                                g50.Open();
                                break;
                            case "xtraTabPage6":
                                g60.Open();
                                break;

                            default:

                                break;
                        }

                        this.Open();
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

        private void ucImage1_EditValueChanged(object sender, EventArgs e)
        {

        }
        #region "DataValue"
        public static string DataValue(DataSet dtSet, int columnIndex = 0, int rowIndex = 0, bool withException = false)
        {
            try
            {
                // Check if the dataset is not null, and it contains tables, rows, and columns
                if (dtSet != null && dtSet.Tables.Count > 0)
                {
                    DataTable table = dtSet.Tables[0];

                    if (table.Rows.Count > rowIndex && table.Columns.Count > columnIndex)
                    {
                        // Return the value at the specified row and column
                        object value = table.Rows[rowIndex][columnIndex];
                        return value != null ? value.ToString() : string.Empty;
                    }
                }

                // If withException is true, throw an exception if the value cannot be found
                if (withException)
                {
                    throw new IndexOutOfRangeException("The specified row or column index is out of range.");
                }

                return string.Empty; // Return empty string if no value is found and withException is false
            }
            catch (Exception ex)
            {
                if (withException)
                {
                    throw; // Re-throw the exception if withException is true
                }

                // Optionally log the exception (logging can be implemented)
                return string.Empty; // Return empty string on error if withException is false
            }
        }
        #endregion 

        private void birth_date_TextChanged(object sender, EventArgs e)
        {
            DataSet dset = OpenDataSet("hr140_age");
            age.Text = DataValue(dset);
        }

        //private void AfterSave()
        //{
        //    string finder = applicant_id.Text; // Get the applicant ID
        //    this.Open(); // Re-open the form or refresh data
        //    g10.Find("applicant_id=" + finder); // Find the row with the matching applicant_id in grid g10
        //}




    }
}
