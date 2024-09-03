namespace EpicV004.Frms
{
    public partial class HR650 : FrmBase
    {
        public HR650()
        {
            InitializeComponent();
        }

        private void HR650_Load(object sender, EventArgs e)
        {
            g10.Open();
            g20.Open();
        }
    }
}
