using DevExpress.CodeParser;
using EpicV004.Ctrls;
using EpicV004.Libs.Repo;

namespace EpicV004.Frms
{
    public partial class TASKS : FrmBase
    {
        public TASKS()
        {
            InitializeComponent();
        }
        protected override void BarButtonAction(string frm, string action)
        {

            string searchStr = g10.GetText("TskId").ToString(); // Get the ID of the current row
            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        if (this.Save())
                        {
                            g10.Open(); // Reload the grid data
                            g10.FocuseByFindedValue("TskId", searchStr); // Focus the row with the saved ID
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
