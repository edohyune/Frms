namespace EpicV004.Frms
{
    public partial class CtrlDom : FrmBase
    {
        public CtrlDom()
        {
            InitializeComponent();
        }

        private void ucButton1_Click(object sender, EventArgs e)
        {
            ucRichText2.Text = ucChkCodeBox1.Code;
        }
    }
}
