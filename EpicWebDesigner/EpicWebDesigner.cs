using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using EpicV004.Libs.Repo;
using EpicV004.Libs;
using System.ComponentModel;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using System.Reflection;
using DevExpress.XtraTreeList;
using System.IO;

namespace EpicV004.Frms
{
    public partial class EpicWebDesigner : UserControl
    {
        public EpicWebDesigner()
        {
            InitializeComponent();

            selectedFrwId.SetCtrl(Common.GetValue("gFrameWorkId"), "FRW");
            selectedFrwId.FldTy = "SubCd";
            selectedFrwId.Code = Common.GetValue("gFrameWorkId");

            #region xTab1 Form Registration (grdFrm, fldFrm) ----------------------------------------------------
            gvFrm.OptionsNavigation.AutoFocusNewRow = true;
            gvFrm.OptionsView.AllowHtmlDrawHeaders = true;
            gvFrm.OptionsView.RowAutoHeight = true;

            gvFrm.OptionsFind.AlwaysVisible = false;
            gvFrm.OptionsView.ShowGroupPanel = false;
            gvFrm.OptionsView.ShowFooter = false;
            gvFrm.OptionsView.ColumnAutoWidth = false;
            gvFrm.OptionsSelection.MultiSelect = false;
            gvFrm.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            //GridHeader
            gvFrm.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gvFrm.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            gvFrm.OptionsView.EnableAppearanceEvenRow = true;
            GridNavigator(grdFrm, false, false, false, false, false);
            gvFrm.OptionsBehavior.Editable = false;//----------------------------- ReadOnly
            #endregion

            EpicV004.FormMain.BarButtonActive += new EpicV004.FormMain.BarBtnEventHandler(BarButtonAction);
        }

        private void BarButtonAction(string frm, string action)
        {
            if ("EpicWebDesigner" == frm)
            {
                switch (action)
                {
                    case "Save":
                        break;
                    case "Delete":
                        break;
                    case "Open":
                        grdFrmOpen();
                        break;
                    case "New":
                        break;
                }
            }
        }

        #region Function : grdFrm -----------------------------------------------------------------||
        private FrwFrm selectedFrwFrm;
        private void grdFrmOpen()
        {
            List<FrwFrm> GRDFRMs = new FrwFrmRepo().GetByEpicFrwFrm(Common.GetValue("gRegId").ToInt(), Common.GetValue("gFrameWorkId"));

            gvFrm.Columns.Clear();
            gvFrm.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "FrwId", Visible = false });
            gvFrm.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "FrmId", Caption = "Form ID", Visible = true, Width = 100 });
            gvFrm.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "FrmNm", Caption = "Form Name", Visible = true, Width = 180 });
            gvFrm.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "UsrRegId", Visible = false });
            gvFrm.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "FilePath", Visible = false });
            gvFrm.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "FileNm", Visible = false });
            gvFrm.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "NmSpace", Visible = false });
            gvFrm.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "FldYn", Visible = false });
            gvFrm.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "PId", Visible = false });
            gvFrm.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Memo", Visible = false });

            grdFrm.DataSource = new BindingList<FrwFrm>(GRDFRMs);
        }
        private void gvFrm_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvFrm.SetRowCellValue(e.RowHandle, gvFrm.Columns["FrwId"], Common.GetValue("gFrameWorkId"));
            gvFrm.SetRowCellValue(e.RowHandle, gvFrm.Columns["UsrRegId"], Common.GetValue("gRegId"));
            gvFrm.SetRowCellValue(e.RowHandle, gvFrm.Columns["FldYn"], false);

            gvFrm.FocusedRowHandle = e.RowHandle;

        }
        private void grdFrmNew()
        {
            gvFrm.AddNewRow();
        }
        private void grdFrmSave()
        {
            string searchStr = selectedFrwFrm.FrmId;

            if (selectedFrwFrm.ChangedFlag == MdlState.Inserted)
            {
                selectedFrwFrm.CId = Common.GetValue("gRegId").ToInt();
                selectedFrwFrm.MId = Common.GetValue("gRegId").ToInt();
                new FrwFrmRepo().Add(selectedFrwFrm);
            }
            else
            {
                selectedFrwFrm.MId = Common.GetValue("gRegId").ToInt();
                new FrwFrmRepo().Update(selectedFrwFrm);
            }
            grdFrmOpen();
            FindRowByValue(gvFrm, "FrmId", searchStr);
        }
        private void grdFrmDelete()
        {
            new FrwFrmRepo().Delete(selectedFrwFrm);
        }
        private void gvFrm_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            selectedFrwFrm = gvFrm.GetFocusedRow() as FrwFrm;

            if (selectedFrwFrm != null)
            {
                grdFrmBindingWithfldFrm();
            }

            if (string.IsNullOrEmpty(selectedFrwFrm.FrwId))
            {
                selectedFrmNm.Text = string.Empty;
                selectedFrmId.Text = string.Empty;
            }
            else
            {
                selectedFrmNm.Text = gvFrm.GetFocusedRowCellValue("FrmNm").ToString();
                selectedFrmId.Text = gvFrm.GetFocusedRowCellValue("FrmId").ToString();
            }

            treeFrmCtrlOpen();

            //frmFullPath.Text = $"{frmWorkSpace.Text}\\{frmFilePath.Text}\\{frmFileName.Text}";

            //fromFullPath.Text = $"{frmWorkSpace.Text}\\{frmFilePath.Text}\\{frmFileName.Text}";
            //fromNameSpace.Text = frmNameSpace.Text.Replace($".{frmFormId.Text}", "");
            //fromFormId.Text = frmFormId.Text;

            //grdFrmCtrlOpen();
            //grdFrmWrkOpen();
            //grdUsrDirOpen();
        }
        private void grdFrmBindingWithfldFrm()
        {
            //AddBindingForFldFrm(frmFilePath, "BindText", selectedFrwFrm, "FilePath");
            //AddBindingForFldFrm(frmFileName, "BindText", selectedFrwFrm, "FileNm");
            //AddBindingForFldFrm(frmFormId, "BindText", selectedFrwFrm, "FrmId");
            //AddBindingForFldFrm(frmFormName, "BindText", selectedFrwFrm, "FrmNm");
            //AddBindingForFldFrm(frmFrameWork, "BindText", selectedFrwFrm, "FrwId");
            //AddBindingForFldFrm(frmNameSpace, "BindText", selectedFrwFrm, "NmSpace");
            //AddBindingForFldFrm(frmChangedFlag, "BindText", selectedFrwFrm, "ChangedFlag");
        }
        private System.Windows.Forms.BindingSource bindingSourceFldFrm = new System.Windows.Forms.BindingSource();
        private void AddBindingForFldFrm(System.Windows.Forms.Control control, string propertyName, object dataSource, string dataMember)
        {
            bindingSourceFldFrm.DataSource = dataSource;
            control.DataBindings.Clear();
            control.DataBindings.Add(propertyName, bindingSourceFldFrm, dataMember, false, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion

        #region Function treeFrmCtrl ---------------------------------------------------------------||
        private void treeFrmCtrlOpen()
        {
            List<FrmEle> treeFrmCtrls = new FrmEleRepo().GetByEpicFrmCtrl(selectedFrwFrm.FrwId, selectedFrwFrm.FrmId);

            treeFrmCtrl.KeyFieldName = "Id";          // 각 노드의 고유 키
            treeFrmCtrl.ParentFieldName = "PId";      // 부모 노드의 키
            treeFrmCtrl.TreeViewFieldName = "DOM";
            
            treeFrmCtrl.DataSource = new BindingList<FrmEle>(treeFrmCtrls);
            treeFrmCtrl.ExpandAll();
        }
        #endregion

        #region ETC Function
        /// <summary>
        /// Enables the EmbeddedNavigator in the grid.
        /// </summary>
        /// <param name="navCreate">Create</param>
        /// <param name="navOpen">Open</param>
        /// <param name="navSave">Save</param>
        /// <param name="navDelete">Delete</param>
        /// <param name="navCancel">Cancel</param>
        /// <returns>두 숫자의 합</returns>
        private void GridNavigator(GridControl gc, bool navCreate, bool navOpen, bool navSave, bool navDelete, bool navCancel)
        {
            ControlNavigator navigator = gc.EmbeddedNavigator;
            navigator.Buttons.BeginUpdate();
            navigator.Buttons.CustomButtons.Clear();
            try
            {
                navigator.Buttons.Append.Visible = navCreate;
                navigator.Buttons.Remove.Visible = navDelete;
                navigator.Buttons.EndEdit.Visible = navSave;
                navigator.Buttons.CancelEdit.Visible = navCancel;

                navigator.Buttons.Edit.Enabled = false;
                navigator.Buttons.Edit.Visible = false;
                navigator.Buttons.First.Enabled = false;
                navigator.Buttons.First.Visible = false;
                navigator.Buttons.Last.Enabled = false;
                navigator.Buttons.Last.Visible = false;
                navigator.Buttons.Next.Enabled = false;
                navigator.Buttons.Next.Visible = false;
                navigator.Buttons.NextPage.Enabled = false;
                navigator.Buttons.NextPage.Visible = false;
                navigator.Buttons.Prev.Enabled = false;
                navigator.Buttons.Prev.Visible = false;
                navigator.Buttons.PrevPage.Enabled = false;
                navigator.Buttons.PrevPage.Visible = false;
                navigator.ShowToolTips = false;
                navigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
                if (navOpen)
                {
                    navigator.Buttons.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] { new DevExpress.XtraEditors.NavigatorCustomButton(-1, 11, true, true, "Open", "Open") });
                }
            }
            finally
            {
                navigator.Buttons.EndUpdate();
            }
            gc.UseEmbeddedNavigator = true;
        }

        public void FindRowByValue(DevExpress.XtraGrid.Views.Grid.GridView view, string columnName, object value)
        {
            for (int i = 0; i < view.RowCount; i++)
            {
                object cellValue = view.GetRowCellValue(i, columnName);
                if (cellValue != null && cellValue.Equals(value))
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = view.Columns[columnName];
                    return;
                }
            }
        }
        #endregion
        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption== "Load Controllers")
            {
                #region FormLoad - Reflection을 이용하여 개체를 로드한다. 

                if (selectedFrwFrm == null) return;

                //frm.FilePath, frm.NmSpace의 값이 없으면 아무것도 하지 않는다.
                if (string.IsNullOrEmpty(selectedFrwFrm.FilePath) || string.IsNullOrEmpty(selectedFrwFrm.NmSpace))
                {
                    return;
                }

                //UserControl정보를 넣는 변수 ucform을 선언한다.
                System.Windows.Forms.UserControl ucform = null;

                string strFullPath = $"{GenFunc.GetIni(Common.GetValue("gFrameWorkId"))}\\{selectedFrwFrm.FilePath}\\{selectedFrwFrm.FileNm}";

                Assembly assembly = AppDomain.CurrentDomain.Load(File.ReadAllBytes($"{strFullPath}"));
                var ty = assembly.GetType(selectedFrwFrm.NmSpace);
                ucform = (System.Windows.Forms.UserControl)Activator.CreateInstance(ty);

                #endregion
                #region FormLoad - Controller 목록 구성
                new FrmEleRepo().Delete(selectedFrwId.Code, selectedFrmId.Text);
                FindControlsRecursive(ucform, 0);
                PrintControlHierarchy(ucform, "    ");
                #endregion

            }
        }
        public static void PrintControlHierarchy(Control control, string indent = "")
        {
            // 현재 컨트롤의 정보 출력
            Common.gLog = $"{indent}Control: {control.Name}, Type: {control.GetType().Name}";

            // 자식 컨트롤이 있는지 확인하고 재귀적으로 출력
            foreach (Control childControl in control.Controls)
            {
                PrintControlHierarchy(childControl, indent + "    ");
            }
        }

        private void FindControlsRecursive(System.Windows.Forms.Control parentControl, int parentId)
        {
            int currentId = SaveControl(parentControl, parentId);
            foreach (System.Windows.Forms.Control ctrl in parentControl.Controls)
            {
                FindControlsRecursive(ctrl, currentId); // 재귀 호출
            }
        }
        private int SaveControl(System.Windows.Forms.Control control, int parentId)
        {
            var frmEle = new FrmEle
            {
                FrwId = Common.GetValue("gFrameWorkId"),
                FrmId = selectedFrwFrm.FrmId,
                CtrlNm = control.Name,
                FldNm = control.Name,
                ToolNm = control.GetType().Name,
                DOM = $"Control: {control.Name}, Type: {control.GetType().Name}",
                PId = parentId // Use 0 for root controls or parentId for child controls
                //public long Id { get; set; }
                //public long PId { get; set; }
                //public string FrwId { get; set; }
                //public string FrmId { get; set; }
                //public string CtrlNm { get; set; }
                //public string FldNm { get; set; }
                //public string ToolNm { get; set; }
                //public string DOM { get; set; }
    };
            return new FrmEleRepo().Add(frmEle);
        }
    }
}
