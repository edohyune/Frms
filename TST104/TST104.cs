using DevExpress.CodeParser;
using EpicV004.Ctrls;
using EpicV004.Libs.Repo;

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
