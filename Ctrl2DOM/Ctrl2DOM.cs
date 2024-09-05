using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System.ComponentModel;

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
            GridNavigator(grdCtrl, true, true, true, true, true);
            #endregion

            rtxETag.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.DOM_Syntax(rtxETag.Document));

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
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "CtrlId", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "CtrlNm", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "CtrlGrpCd", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "CtrlRegNm", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Binding", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Event", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "ContainYn", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "CustomYn", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "UseYn", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Rnd", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Memo", Visible = true, Width = 100 });
            gvCtrl.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "PId", Visible = true, Width = 100 });

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
            List<CtrlMst> fldCtrls = new CtrlMstRepo().GetAll();
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
    }
}
