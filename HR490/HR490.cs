using Dapper;
using EpicV004.Libs.Repo;

namespace EpicV004.Frms
{
    public partial class HR490 : FrmBase
    {
        public HR490()
        {
            InitializeComponent();
        }

        private void HR490_Load(object sender, EventArgs e)
        {

        }

        private void g20_Load(object sender, EventArgs e)
        {

        }
        protected override void BarButtonAction(string frm, string action)
        {


            string searchStr = g10.GetText("Id").ToString();

            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        if (this.Save())

                        {
                            g10.Open(); // Reload the grid data
                            g10.FocuseByFindedValue("Id", searchStr); // Focus the row with the saved ID

                            //    g20.Open();
                            //    g20.FocuseByFindedValue("applicant_id", searchStr);

                            g30.Open();
                            g30.FocuseByFindedValue("Id", searchStr);

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
                            case "xtraTabPage1":
                                g10.Open();
                                break;
                            case "xtraTabPage2":
                                g30.Open();
                                break;
                            default:

                                break;
                        }

                        //this.Open();
                        break;
                 
                    case "New":
                        //g20.New();
                        break;
                    case "Delete":
                        //this.Delete();
                        break;

                    default:
                        base.BarButtonAction(frm, action);
                        break;
                }
            }

        }

        private void g10_Load(object sender, EventArgs e)
        {

        }

        private void g10_UCFocusedRowChanged(object sender, int preIndex, int rowIndex, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
         
        }
    }
}
