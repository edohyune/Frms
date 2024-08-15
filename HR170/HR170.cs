namespace EpicV004.Frms
{
    public partial class HR170 : FrmBase
    {
        public HR170()
        {
            InitializeComponent();
        }
        protected override void BarButtonAction(string frm, string action)
        {
            string searchStr = g10.GetText("applicant_id").ToString();
            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        if (this.Save())
                        {
                            //this.Open();
                            g10.Open();
                            g10.FocuseByFindedValue("applicant_id", searchStr);
                        }
                        break;

                    case "New":
                        //NewWorkSet("f10");
                        //NewWorkSet("g10");
                        break;

                    default:
                        base.BarButtonAction(frm, action);
                        break;
                }
            }
        }
    }
}
