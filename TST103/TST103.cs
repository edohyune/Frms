namespace EpicV004.Frms
{
    public partial class TST103 : FrmBase
    {
        public TST103()
        {
            InitializeComponent();
        }

        private void TST103_Load(object sender, EventArgs e)
        {
            g10.Open();
            g10.Show();
        }
    }
}
