using Dapper;

namespace EpicV004.Frms
{
    public partial class FRWCDE : EpicV004.FrmBase
    {
        public FRWCDE()
        {
            InitializeComponent();
        }

        private void grdCde_UCFocusedRowChanged(object sender, int preIndex, int rowIndex, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("Cd", grdCde.GetText("PCd"));
            grdDtl.Open(p);
        }
    }
}
