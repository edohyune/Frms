namespace EpicV004.Frms
{
    public partial class HR690 : FrmBase
    {
        public HR690()
        {
            InitializeComponent();
        }

        private void HR690_Load(object sender, EventArgs e)
        {
            //g10.Open();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s_paydate.Text);
        }
    }
}
