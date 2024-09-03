using EpicV004;

namespace EpicV004.Frms
{
    public partial class HR630 : FrmBase
    {
        public HR630()
        {
            InitializeComponent();
        }

        private void HR630_Load(object sender, EventArgs e)
        {
            g10.Open();
            g20.Open();
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Onprogress");
        }
    }
}
