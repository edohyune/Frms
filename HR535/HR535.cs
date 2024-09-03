using EpicV004;

namespace EpicV004.Frms
{
    public partial class HR535 : FrmBase
    {
        public HR535()
        {
            InitializeComponent();
        }

        private void HR535_Load(object sender, EventArgs e)
        {
            g10.Open();
            g20.Open();
            g30.Open();
            g40.Open();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Onprogress");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Onprogress");
        }
    }
}
