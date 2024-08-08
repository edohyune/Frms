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
            string searchStr = g10.GetText("PCd").ToString();

            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        if (this.Save())
                        {
                            g10.Open();
                            g10.FocuseByFindedValue("PCd", searchStr);
                        }
                        break;
                    case "New":

                        UCFieldSet uCFieldSet = fieldSets.FirstOrDefault((UCFieldSet fs) => fs.wrkId == "f10"); // -----------------------------Edit WorkSet ID/
                  if (uCFieldSet != null)
                        {
                            uCFieldSet.New();
                        }

                        UCGridSet uCGridSet = gridSets.FirstOrDefault((UCGridSet gs) => gs.wrkId == ""); // -----------------------------Edit WorkSet ID/
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


    }
}
