namespace EpicV004.Frms

{
    public partial class APPREG : FrmBase
    {
        public APPREG()
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

                            g20.Open();
                            g20.FocuseByFindedValue("applicant_id", searchStr);

                            g30.Open();
                            g30.FocuseByFindedValue("applicant_id", searchStr);

                            g40.Open();
                            g40.FocuseByFindedValue("applicant_id", searchStr);

                            g50.Open();
                            g50.FocuseByFindedValue("applicant_id", searchStr);
                        }
                        break;
                    case "Open":
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

    }
}
