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
    public partial class Ctrl2DOM : UserControl
    {
        public Ctrl2DOM()
        {
            InitializeComponent();

            selectedFrwId.SetCtrl(Common.GetValue("gFrameWorkId"), "FRW");
            selectedFrwId.FldTy = "SubCd";
            selectedFrwId.Code = Common.GetValue("gFrameWorkId");

            #region xTab1 Form Registration (grdCtrl, fldFrm) ----------------------------------------------------
            gvCtrl.OptionsNavigation.AutoFocusNewRow = true;
            gvCtrl.OptionsView.AllowHtmlDrawHeaders = true;
            gvCtrl.OptionsView.RowAutoHeight = true;

            gvCtrl.OptionsFind.AlwaysVisible = false;
            gvCtrl.OptionsView.ShowGroupPanel = false;
            gvCtrl.OptionsView.ShowFooter = false;
            gvCtrl.OptionsView.ColumnAutoWidth = false;
            gvCtrl.OptionsSelection.MultiSelect = false;
            gvCtrl.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            //GridHeader
            gvCtrl.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gvCtrl.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            gvCtrl.OptionsView.EnableAppearanceEvenRow = true;
            GridNavigator(grdCtrl, false, false, false, false, false);
            gvCtrl.OptionsBehavior.Editable = false;//----------------------------- ReadOnly
            #endregion

            rtxTAG.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.DOM_Syntax(rtxTAG.Document));

            EpicV004.FormMain.BarButtonActive += new EpicV004.FormMain.BarBtnEventHandler(BarButtonAction);
        }

        private void BarButtonAction(string frm, string action)
        {
            if ("Ctrl2DOM" == frm)
            {
                switch (action)
                {
                    case "Save":
                        break;
                    case "Delete":
                        break;
                    case "Open":
                        grdCtrlOpen();
                        break;
                    case "New":
                        break;
                }
            }
        }

        #region Function : grdCtrl -----------------------------------------------------------------||
        private CtrlMst selectedCtrlMst;
        private void grdCtrlOpen()
        {
            List<CtrlMst> GRDFRMs = new CtrlMstRepo().GetByEpicCtrlMst();

            gvCtrl.Columns.Clear();
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "CtrlId", Visible = false, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "CtrlNm", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "CtrlGrpCd", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "CtrlRegNm", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Binding", Visible = false, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Event", Visible = false, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "ContainYn", Visible = false, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "CustomYn", Visible = false, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "UseYn", Visible = false, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Rnd", Visible = false, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Memo", Visible = false, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "PId", Visible = false, Width = 100 });

            grdCtrl.DataSource = new BindingList<CtrlMst>(GRDFRMs);
        }

        private void gvCtrl_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            selectedCtrlMst = gvCtrl.GetFocusedRow() as CtrlMst;
        }
        #endregion

        #region Function fldCtrl ---------------------------------------------------------------||
        private void fldCtrlOpen()
        {
            List<CtrlDOM> fldCtrls = new CtrlDOMRepo().GetByEpicFrmCtrl(selectedCtrlMst.FrwId, selectedCtrlMst.FrmId);

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

                if (selectedCtrlMst == null) return;

                //frm.FilePath, frm.NmSpace의 값이 없으면 아무것도 하지 않는다.
                if (string.IsNullOrEmpty(selectedCtrlMst.FilePath) || string.IsNullOrEmpty(selectedCtrlMst.NmSpace))
                {
                    return;
                }

                //UserControl정보를 넣는 변수 ucform을 선언한다.
                System.Windows.Forms.UserControl ucform = null;

                string strFullPath = $"{GenFunc.GetIni(Common.GetValue("gFrameWorkId"))}\\{selectedCtrlMst.FilePath}\\{selectedCtrlMst.FileNm}";

                Assembly assembly = AppDomain.CurrentDomain.Load(File.ReadAllBytes($"{strFullPath}"));
                var ty = assembly.GetType(selectedCtrlMst.NmSpace);
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
                FrmId = selectedCtrlMst.FrmId,
                CtrlNm = control.Name,
                FldNm = control.Name,
                ToolNm = control.GetType().Name,
                DOM = $"Control: {control.Name}, Type: {control.GetType().Name}",
                PId = parentId // Use 0 for root controls or parentId for child controls
            };
            return new FrmEleRepo().Add(frmEle);
        }
    }
}
