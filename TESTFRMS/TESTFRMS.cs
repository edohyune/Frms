using EpicV004.Ctrls;

namespace EpicV004.Frms
{
    public partial class TESTFRMS : FrmBase
    {
        public TESTFRMS()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        protected override void BarButtonAction(string frm, string action)
        {
            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        this.Save();
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
    }
}
