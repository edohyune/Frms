namespace EpicV004.Frms
{
    public partial class HR530 : FrmBase
    {
        public HR530()
        {
            InitializeComponent();
        }

        private void HR530_Load(object sender, EventArgs e)
        {
            g10.Open(); 
            g20.Open();    
        }
    }
}
