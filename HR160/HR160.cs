using EpicV004.Ctrls;
using EpicV004.Libs.Repo;

namespace EpicV004.Frms

{
    public partial class HR160 : FrmBase
    {
        public HR160()
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
                        switch (teb.SelectedTabPage.Name)
                        {
                            case "xtraTabPage1":
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

        private void ucPanel2_UCCustomButtonClick(object Sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox20_Enter(object sender, EventArgs e)
        {

        }
    }
}
