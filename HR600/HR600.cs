using EpicV004;

namespace EpicV004.Frms
{
    public partial class HR600 : FrmBase
    {
        public HR600()
        {
            InitializeComponent();
        }

        private void HR600_Load(object sender, EventArgs e)
        {
            g10.Open();
            g20.Open();
        }
    }
}
