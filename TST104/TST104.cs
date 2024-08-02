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
            MessageBox.Show(g10.GetText("first_name"));

            //g10.SetText("first_name",[Value])
            //g10.SetText("first_name",[rowIndex],[Value])
        }
    }
}
