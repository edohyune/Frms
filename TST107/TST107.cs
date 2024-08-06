using DevExpress.Utils.Extensions;
using EpicV004;
using EpicV004.Ctrls;
using System.Data;

namespace EpicV004.Frms
{
    public partial class TST107 : FrmBase
    {
        public TST107()
        {
            InitializeComponent();
        }
        protected override void BarButtonAction(string frm, string action)
        {
            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        if (this.Save())
                        {
                            this.Open();
                            
                        }
                        //this.Save();
                        
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

                        UCGridSet uCGridSet = gridSets.FirstOrDefault((UCGridSet gs) => gs.wrkId == ""); /*-----------------------------Edit WorkSet ID*/
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
