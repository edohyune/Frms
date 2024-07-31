using Dapper;

namespace EpicV004.Frms
{
    public partial class SYSCDE : EpicV004.FrmBase
    {
        public SYSCDE()
        {
            InitializeComponent();
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
