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

            //// GridLookUpEdit - GRDPOP
            gridLookUpEdit1.Properties.DataSource = smpDatbs;
            gridLookUpEdit1.Properties.DisplayMember = "Name";
            gridLookUpEdit1.Properties.ValueMember = "ID";
            gridLookUpEdit1.Properties.View.BestFitColumns();

            //// SearchLookUpEdit - POPEDT
            searchLookUpEdit2.Properties.DataSource = smpDatbs;
            searchLookUpEdit2.Properties.DisplayMember = "Name";
            searchLookUpEdit2.Properties.ValueMember = "ID";
            searchLookUpEdit2.Properties.View.BestFitColumns();

            //// SearchLookUpEdit - SRCHPOP
            searchLookUpEdit1.Properties.DataSource = smpDatbs;
            searchLookUpEdit1.Properties.DisplayMember = "Name";
            searchLookUpEdit1.Properties.ValueMember = "ID";
            searchLookUpEdit1.Properties.View.BestFitColumns();

            //// TreeListLookUpEdit - TREPOP
            treeListLookUpEdit1.Properties.DataSource = smpDatbs;
            treeListLookUpEdit1.Properties.DisplayMember = "Name";
            treeListLookUpEdit1.Properties.ValueMember = "ID";

            treeListLookUpEdit1.Properties.TreeList.KeyFieldName = "ID";
            treeListLookUpEdit1.Properties.TreeList.ParentFieldName = "PID";
            treeListLookUpEdit1.Properties.TreeList.PopulateColumns();

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

        private void searchLookUpEdit2_Properties_Popup(object sender, EventArgs e)
        {
            searchLookUpEdit2.Properties.PopupFormWidth = 500; // 예시로 팝업 폼 너비 설정
        }
    }
}
