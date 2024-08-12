using DevExpress.CodeParser;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Data;
using DevExpress.XtraTreeList.Nodes;
using EpicV004.Libs;
using EpicV004.Libs.Repo;
using EpicV004.Repo;
using System.ComponentModel;
using System.Windows.Forms;

namespace EpicV004.Frms
{
    public partial class FRMTST : FrmBase
    {
        public FRMTST()
        {
            InitializeComponent();
            LoadSampleData();
        }
        protected override void BarButtonAction(string frm, string action)
        {
            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        if (this.Save()) 
                        {
                            MessageBox.Show("저장되었습니다.");
                        }
                        break;
                    case "Delete":
                        this.Delete();
                        break;
                    case "Open":
                        this.Open();
                        break;
                    case "New":
                        this.New();
                        break;
                    default:
                        base.BarButtonAction(frm, action);
                        break;
                }
            }
        }

        private void LoadSampleData()
        {
            List<UsrFrmDir> smpDats = new UsrFrmDirRepo().GetByUsrRegId(Common.GetValue("gFrameWorkId"), Common.GetValue("gRegId").ToInt());
            BindingList<UsrFrmDir> smpDatbs = new BindingList<UsrFrmDir>(smpDats);

            //// TreeList - GRDTRE
            treeList1.DataSource = smpDatbs;
            treeList1.KeyFieldName = "DirId";
            treeList1.ParentFieldName = "PDirId";
            treeList1.TreeViewFieldName = "DirNm";
            treeList1.PopulateColumns();
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                var selectedData = (UsrFrmDir)treeList1.GetDataRecordByNode(e.Node);
                if (selectedData != null)
                {
                    listBox1.Items.Add(selectedData.DirId + " - " + selectedData.DirNm);
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

        private void FRMTST_Load(object sender, EventArgs e)
        {
            base.Open();
        }

        private void grdFrwFrm_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void grdFrwFrm_DragDrop(object sender, DragEventArgs e)
        {
            TreeListNode draggedNode = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;
            if (draggedNode != null)
            {
                UsrFrmDir data = treeList1.GetDataRecordByNode(draggedNode) as UsrFrmDir;
                GridHitInfo hitInfo = grdFrwFrm.gvBand.CalcHitInfo(grdFrwFrm.PointToClient(new Point(e.X, e.Y)));

                if (hitInfo.InRow && data != null)
                {
                    grdFrwFrm.SetText("PId", hitInfo.RowHandle, data.DirId);
                }
            }
        }

        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            TreeListHitInfo hitInfo = treeList1.CalcHitInfo(new Point(e.X, e.Y));
            if (hitInfo.Node != null && e.Button == MouseButtons.Left)
            {
                treeList1.DoDragDrop(hitInfo.Node, DragDropEffects.Move);
            }
        }
    }
}
