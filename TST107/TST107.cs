using Dapper;
using DevExpress.Utils.Extensions;
using EpicV004;
using EpicV004.Ctrls;
using EpicV004.Libs.Repo;
using System.Data;
using DevExpress.CodeParser;


namespace EpicV004.Frms
{
    public partial class TST107 : FrmBase
    {
        public TST107()
        {
            InitializeComponent();
        }
        //protected override void BarButtonAction(string frm, string action)
        //{
        //    string searchStr = g10.GetText("id").ToString();
        //    if (this.Name == frm)
        //    {
        //        switch (action)
        //        {
        //            case "Save":
        //                if (this.Save())
        //                {
        //                    g10.Open();
        //                    g10.FocuseByFindedValue("id", searchStr);
        //                }
        //                //if (this.Save())
        //                //{
        //                //    this.Open();

        //                //}
        //                ////this.Save();

        //                break;
        //            case "Open":
        //                this.Open();
        //                break;
        //            case "New":

        //                UCFieldSet uCFieldSet = fieldSets.FirstOrDefault((UCFieldSet fs) => fs.wrkId == "f10"); /*-----------------------------Edit WorkSet ID*/
        //                if (uCFieldSet != null)
        //                {
        //                    uCFieldSet.New();
        //                }

        //                UCGridSet uCGridSet = gridSets.FirstOrDefault((UCGridSet gs) => gs.wrkId == "g10"); /*-----------------------------Edit WorkSet ID*/
        //                if (uCGridSet != null)
        //                {
        //                    uCGridSet.New();
        //                }
        //                break;
        //            default:
        //                base.BarButtonAction(frm, action);
        //                break;
        //        }
        //    }
        //}

        protected override void BarButtonAction(string frm, string action)
        {

            string searchStr = g10.GetText("id").ToString(); // Get the ID of the current row
            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        if (this.Save())
                        {
                            g10.Open(); // Reload the grid data
                            g10.FocuseByFindedValue("id", searchStr); // Focus the row with the saved ID
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
