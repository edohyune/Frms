using Dapper;
using DevExpress.CodeParser;

namespace EpicV004.Frms
{
    public partial class SYSCDE : EpicV004.FrmBase
    {
        public SYSCDE()
        {
            InitializeComponent();
        }
        protected override void BarButtonAction(string frm, string action)
        {
            string searchStr = grdCde.GetText("PCd").ToString();

            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        if (this.Save()) 
                        {
                            grdCde.Open();
                            grdCde.FocuseByFindedValue("PCd", searchStr);
                        }
                        break;
                    default:
                        base.BarButtonAction(frm, action);
                        break;
                }
            }
        }

        private void grdCde_UCAfterFocusedRow(object sender, int preIndex, int rowIndex, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Libs.Common.gMsg = "프로그램코드 : " + grdCde.GetText("FrwId") + " / 프로그램명 : " + grdCde.GetText("PCd");

            DynamicParameters p = new DynamicParameters();
            p.Add("FrwId", grdCde.GetText("FrwId"));
            p.Add("Cd", grdCde.GetText("PCd"));
            p.Add("PCd", grdCde.GetText("PCd"));
            grdDtl.Open(p);
        }
    }
}
