using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Data;
using EpicV004.Libs.Repo;
using System.ComponentModel;
using System.Windows.Forms;

namespace EpicV004.Frms
{
    public partial class LOOKUP : FrmBase
    {
        public LOOKUP()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            List<SMPDAT> smpDats = new SMPDATRepo().GetSampleData();
            BindingList<SMPDAT> smpDatbs = new BindingList<SMPDAT>(smpDats);

            //// TreeList - GRDTRE
            treeList1.DataSource = smpDatbs;
            treeList1.KeyFieldName = "ID";
            treeList1.ParentFieldName = "PID";
            treeList1.TreeViewFieldName = "NM";
            treeList1.PopulateColumns();
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                var selectedData = (SMPDAT)treeList1.GetDataRecordByNode(e.Node);
                if (selectedData != null)
                {
                    listBox1.Items.Add(selectedData.ID + " - " + selectedData.NM);
                }
            }
        }
        private void TreeList1_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Node.GetValue("ImageIndex") != null)
            {
                int imageIndex = (int)e.Node.GetValue("ImageIndex");
                //e.Graphics.DrawImage(_imageList.Images[imageIndex], e.Bounds.X - 16, e.Bounds.Y);
            }
        }

        private void LOOKUP_Load(object sender, EventArgs e)
        {
            
        }
    }
}
