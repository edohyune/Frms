using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using EpicV004.Libs;
using EpicV004.Libs.Repo;
using EpicV004.Libs.Syntax;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;

namespace EpicV004.Frms
{
    public partial class DesignerV004 : FrmBase
    {
        private List<CtrlMst> ctrlMsts;
        private CtrlMst ctrlMst;
        private CtrlMstRepo ctrlMstRepo;

        private BindingList<DesignerV004_GRDFRMCTRL> frmCtrlbs;
        private BindingList<DesignerV004_GRDFRMW> frmWrkbs;
        private BindingList<DesignerV004_GRDGRDFLD> grdGrdFldbs;

        public DesignerV004()
        {
            InitializeComponent();

            rtxFldC.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.SQL_Syntax(rtxFldC.Document));
            rtxFldR.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.SQL_Syntax(rtxFldR.Document));
            rtxFldU.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.SQL_Syntax(rtxFldU.Document));
            rtxFldD.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.SQL_Syntax(rtxFldD.Document));
            rtxFldM.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.CS_Syntax(rtxFldM.Document));
            rtxGrdC.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.SQL_Syntax(rtxGrdC.Document));
            rtxGrdR.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.SQL_Syntax(rtxGrdR.Document));
            rtxGrdU.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.SQL_Syntax(rtxGrdU.Document));
            rtxGrdD.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.SQL_Syntax(rtxGrdD.Document));
            rtxGrdM.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.CS_Syntax(rtxGrdM.Document));

            rtxDataR.ReplaceService<DevExpress.XtraRichEdit.Services.ISyntaxHighlightService>(new Libs.Syntax.SQL_Syntax(rtxDataR.Document));

        }
        private void DesignerV004_Load(object sender, EventArgs e)
        {
            frmWorkSpace.Text = GenFunc.GetIni(Common.GetValue("gFrameWorkId"));
        }

        #region Button event : ------------------------------------------------------
        protected override void BarButtonAction(string frm, string action)
        {
            if (this.Name == frm)
            {
                switch (action)
                {
                    case "Save":
                        CustomSave();
                        break;
                    case "Open":
                        switch (ucTab1.SelectedTabPage.Name)
                        {
                            case "xtraTabPage1":
                            case "xtraTabPage2":
                                grdFrm.Open();
                                break;
                            case "xtraTabPage3":
                                grdWrkGrd.Open();
                                break;
                            case "xtraTabPage4":
                                grdWrkFld.Open();
                                break;
                            case "xtraTabPage5":
                                grdWrkData.Open();
                                break;
                            default:
                                break;
                        }
                        //this.Open();
                        break;
                    case "New":
                        if (ucTab1.SelectedTabPage.Name == "xtraTabPage1")
                        {
                            NewWorkSet("fldFrm");
                        }
                        //this.Open();
                        break;
                    default:
                        base.BarButtonAction(frm, action);
                        break;
                }
            }
        }

        private void CustomSave()
        {
            if (grdGrdGet.RowCount > 0)
            {
                for (int i = 0; i < grdGrdGet.RowCount; i++)
                {
                    var status = grdGrdGet.GetText("ChangedFlag", i);

                    if (status == MdlState.Inserted.ToString() || status == MdlState.Updated.ToString())
                    {
                        var fldNm = grdGrdGet.GetText("GetFldNm", i);
                        var defaultValue = grdGrdGet.GetText("GetDefaultValue", i);

                        if (string.IsNullOrWhiteSpace(fldNm) && string.IsNullOrWhiteSpace(defaultValue))
                        {
                            grdGrdGet.SetText("ChangedFlag", i, MdlState.None);
                        }
                    }
                }
            }

            if (grdGrdSet.RowCount > 0)
            {
                for (int i = 0; i < grdGrdSet.RowCount; i++)
                {
                    var fldNm = grdGrdSet.GetText("FldNm", i);

                    if (string.IsNullOrWhiteSpace(fldNm))
                    {
                        grdGrdSet.SetText("ChangedFlag", i, MdlState.None);
                    }
                }
            }

            if (grdGrdRef.RowCount > 0)
            {
                for (int i = 0; i < grdGrdRef.RowCount; i++)
                {
                    var status = grdGrdRef.GetText("ChangedFlag", i);

                    if (status == MdlState.Inserted.ToString() || status == MdlState.Updated.ToString())
                    {
                        var fldNm = grdGrdRef.GetText("RefFldNm", i);
                        var defaultValue = grdGrdRef.GetText("RefDefaultValue", i);

                        if (string.IsNullOrWhiteSpace(fldNm) && string.IsNullOrWhiteSpace(defaultValue))
                        {
                            grdGrdRef.SetText("ChangedFlag", i, MdlState.None);
                        }

                    }

                }
            }

            if (grdFldGet.RowCount > 0)
            {
                for (int i = 0; i < grdFldGet.RowCount; i++)
                {
                    var status = grdFldGet.GetText("ChangedFlag", i);

                    if (status == MdlState.Inserted.ToString() || status == MdlState.Updated.ToString())
                    {
                        var fldNm = grdFldGet.GetText("GetFldNm", i);
                        var defaultValue = grdFldGet.GetText("GetDefaultValue", i);

                        if (string.IsNullOrWhiteSpace(fldNm) && string.IsNullOrWhiteSpace(defaultValue))
                        {
                            grdFldGet.SetText("ChangedFlag", i, MdlState.None);
                        }
                    }
                }
            }

            if (grdFldSet.RowCount > 0)
            {
                for (int i = 0; i < grdFldSet.RowCount; i++)
                {
                    var status = grdFldSet.GetText("ChangedFlag", i);

                    if (status == MdlState.Inserted.ToString() || status == MdlState.Updated.ToString())
                    {
                        var fldNm = grdFldSet.GetText("FldNm", i);

                        if (string.IsNullOrWhiteSpace(fldNm))
                        {
                            grdFldSet.SetText("ChangedFlag", i, MdlState.None);
                        }

                    }
                }
            }

            if (grdFldRef.RowCount > 0)
            {
                for (int i = 0; i < grdFldRef.RowCount; i++)
                {
                    var status = grdFldRef.GetText("ChangedFlag", i);

                    if (status == MdlState.Inserted.ToString() || status == MdlState.Updated.ToString())
                    {
                        var fldNm = grdFldRef.GetText("RefFldNm", i);
                        var defaultValue = grdFldRef.GetText("RefDefaultValue", i);

                        if (string.IsNullOrWhiteSpace(fldNm) && string.IsNullOrWhiteSpace(defaultValue))
                        {
                            grdFldRef.SetText("ChangedFlag", i, MdlState.None);
                        }
                    }
                }
            }

            if (grdDataGet.RowCount > 0)
            {
                for (int i = 0; i < grdDataGet.RowCount; i++)
                {
                    var status = grdDataGet.GetText("ChangedFlag", i);

                    if (status == MdlState.Inserted.ToString() || status == MdlState.Updated.ToString())
                    {
                        var fldNm = grdDataGet.GetText("GetFldNm", i);
                        var defaultValue = grdDataGet.GetText("GetDefaultValue", i);

                        if (string.IsNullOrWhiteSpace(fldNm) && string.IsNullOrWhiteSpace(defaultValue))
                        {
                            grdDataGet.SetText("ChangedFlag", i, MdlState.None);
                        }
                    }
                }
            }

            if (this.Save())
            {

            }

        }
        #endregion
        #region Form Load -----------------------------------------------------------
        private void btnFormLoad_Click(object sender, EventArgs e)
        {
            //frm.FilePath, frm.NmSpace의 값이 없으면 아무것도 하지 않는다.
            if (string.IsNullOrEmpty(fromFullPath.Text) || string.IsNullOrEmpty(fromNameSpace.Text))
            {
                return;
            }

            frmCtrlbs = (BindingList<DesignerV004_GRDFRMCTRL>)grdFrmCtrl.DataSource;
            frmWrkbs = (BindingList<DesignerV004_GRDFRMW>)grdFrmW.DataSource;

            //UserControl정보를 넣는 변수 ucform을 선언한다.
            System.Windows.Forms.UserControl ucform = null;
            //추가 정보을 읽어 올 파일의 목록
            ctrlMstRepo = new CtrlMstRepo();
            ctrlMsts = ctrlMstRepo.GetAll();
            //frmCtrlbs.Clear();

            Assembly assembly = AppDomain.CurrentDomain.Load(File.ReadAllBytes($"{fromFullPath.Text}"));
            var ty = assembly.GetType(fromNameSpace.Text);

            Common.gLog = $"{fromFullPath.Text}.{fromNameSpace.Text}";

            ucform = (UserControl)Activator.CreateInstance(ty);

            # region Non-Visual Components 사용안함 
            //1. Non-Visual Components Tray Area 컨트롤 확인
            //Common.gMsg = "1. Non-Visual Components Tray Area 컨트롤 확인";
            //FieldInfo[] fields = ucform.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            //foreach (var field in fields)
            //{
            //    // BindingList, Repo, IContainer 타입 제외
            //    if (field.FieldType.FullName.Contains("BindingList") ||
            //        field.FieldType.FullName.Contains("Repo") ||
            //        field.FieldType.FullName.Contains("IContainer"))
            //    {
            //        continue;
            //    }
            //    // UCField 또는 OpenFileDialog 타입인지 확인
            //    if (field.FieldType.FullName.Contains("Ctrls.UCField")) // 사용안함 field.FieldType.FullName.Contains("OpenFileDialog")
            //    {
            //        // frmCtrls에 추가 (FrmCtrl 객체 생성 및 frmCtrlbs에 추가)
            //        var ctrlNm = field.Name;
            //        var toolNm = field.FieldType.Name;

            //        // frmCtrlbs 에 데이터가 있으면 업데이트, 없으면 추가.
            //        var frmCtrl = frmCtrlbs.FirstOrDefault(c => c.CtrlNm == ctrlNm);
            //        if (frmCtrl != null)
            //        {
            //            frmCtrl.FrwId = Common.GetValue("gFrameWorkId");
            //            frmCtrl.FrmId = selectedFrwFrm.FrmId;
            //            frmCtrl.CtrlNm = ctrlNm;
            //            frmCtrl.ToolNm = toolNm;
            //            frmCtrl.ChangedFlag = MdlState.Updated;
            //        }
            //        else
            //        {
            //            frmCtrlbs.Add(new FrmCtrl
            //            {
            //                FrwId = Common.GetValue("gFrameWorkId"),
            //                FrmId = selectedFrwFrm.FrmId,
            //                CtrlNm = ctrlNm,
            //                ToolNm = toolNm,
            //                ChangedFlag = MdlState.Inserted
            //                //사용하지 않는 데이터는 Null로 처리
            //                //CtrlW = 0,CtrlH = 0,TitleText = "",TitleAlign = "",VisibleYn = false,ReadonlyYn = false
            //            }); ;
            //        }
            //    }
            //    else if (field.FieldType.FullName.Contains("UCGridSet"))
            //    {
            //        var ctrlNm = field.Name;
            //        var toolNm = field.FieldType.Name;
            //        var frmCtrl = frmCtrlbs.FirstOrDefault(c => c.CtrlNm == ctrlNm);

            //        if (frmCtrl != null)
            //        {
            //            frmCtrl.FrwId = Common.GetValue("gFrameWorkId");
            //            frmCtrl.FrmId = selectedFrwFrm.FrmId;
            //            frmCtrl.CtrlNm = ctrlNm;
            //            frmCtrl.ToolNm = toolNm;
            //            frmCtrl.ChangedFlag = MdlState.Updated;
            //        }
            //        else
            //        {
            //            frmCtrlbs.Add(new FrmCtrl
            //            {
            //                FrwId = Common.GetValue("gFrameWorkId"),
            //                FrmId = selectedFrwFrm.FrmId,
            //                CtrlNm = ctrlNm,
            //                ToolNm = toolNm,
            //                ChangedFlag = MdlState.Inserted
            //            });
            //        }
            //    }
            //}
            #endregion

            // 2. 폼에 등록된 컨트롤 확인 (ucform.Controls)
            //Common.gMsg = "2. 폼에 등록된 컨트롤 확인 (ucform.Controls)";
            FindUCControlsRecursive(ucform);

            // 3. WorkSet 등록 (UCField, UCGrid)
            //Common.gMsg = "3. WorkSet 등록 (UCField, UCGrid, UCGridSet)";
            foreach (var item in frmCtrlbs)
            {
                if (item.ToolNm == "UCGrid" || item.ToolNm == "U1GridSet" || item.ToolNm == "UCGridSet" || item.ToolNm == "UCGridNav")
                {   //frmWrks에 데이터가 있으면 업데이트, 없으면 추가.
                    var frmWrk = frmWrkbs.FirstOrDefault(c => c.CtrlNm == item.CtrlNm);
                    if (frmWrk != null)
                    {
                        frmWrk.FrwId = item.FrwId;
                        frmWrk.FrmId = item.FrmId;
                        frmWrk.CtrlNm = item.CtrlNm;
                        frmWrk.WrkCd = "GridSet";
                        frmWrk.UseYn = true;
                        frmWrk.ChangedFlag = MdlState.Updated;
                    }
                    else
                    {
                        frmWrkbs.Add(new DesignerV004_GRDFRMW
                        {
                            FrwId = item.FrwId,
                            FrmId = item.FrmId,
                            WrkId = item.CtrlNm,
                            CtrlNm = item.CtrlNm,
                            WrkCd = "GridSet",
                            UseYn = true,
                            ChangedFlag = MdlState.Inserted
                        });
                    }
                }
            }

            grdFrmCtrl.DataSource = frmCtrlbs;
            grdFrmW.DataSource = frmWrkbs;
        }

        private void FindUCControlsRecursive(Control parentControl)
        {
            foreach (Control ctrl in parentControl.Controls)
            {
                if (!ctrlMsts.Any(c => c.CtrlRegNm == ctrl.GetType().FullName))
                {
                    ctrlMst = new CtrlMst
                    {
                        CtrlNm = ctrl.GetType().Name,
                        CtrlRegNm = ctrl.GetType().FullName,
                        Memo = ctrl.HasChildren ? "HasChildren" : "NoChildren"
                    };
                    ctrlMstRepo.Add(ctrlMst);
                }
                else
                {
                    ctrlMst = new CtrlMst
                    {
                        CtrlNm = ctrl.GetType().Name,
                        CtrlRegNm = ctrl.GetType().FullName,
                        Memo = ctrl.HasChildren ? "HasChildren" : "NoChildren"
                    };
                    ctrlMstRepo.Update(ctrlMst);
                }

                //수정 ctrlMsts.Any(c => c.CtrlRegNm == ctrl.GetType().FullName) 이면서 UseYn = true 인 경우만 frmCtrlbs에 추가
                if (ctrlMsts.Any(c => c.CtrlRegNm == ctrl.GetType().FullName && c.UseYn))
                {
                    if (ctrlMsts.Any(c => c.CtrlRegNm == ctrl.GetType().FullName && c.CustomYn))
                    {
                        //frmCtrlbs에 데이터가 있으면 업데이트, 없으면 추가.
                        var frmCtrl = frmCtrlbs.FirstOrDefault(c => c.CtrlNm == ctrl.Name);
                        if (ctrl.Name == "frmFormId")
                        {
                            Common.gLog = $"{ctrl.Name}.{ctrl.GetType().FullName}.{GetShowYn(ctrl).ToString()}";
                        }
                        if (frmCtrl != null)
                        {
                            frmCtrl.FrwId = Common.GetValue("gFrameWorkId");
                            frmCtrl.FrmId = fromFormId.Text;
                            frmCtrl.CtrlNm = ctrl.Name;
                            frmCtrl.ToolNm = ctrl.GetType().Name;
                            frmCtrl.CtrlW = GetWidth(ctrl);
                            frmCtrl.CtrlH = GetHeight(ctrl);
                            frmCtrl.CtrlX = ctrl.Location.X;
                            frmCtrl.CtrlY = ctrl.Location.Y;
                            frmCtrl.TitleText = GetTitleText(ctrl);
                            frmCtrl.TitleWidth = GetTitleWidth(ctrl);
                            frmCtrl.TitleAlign = GetTitleAlign(ctrl);
                            frmCtrl.DefaultText = GetText(ctrl);
                            frmCtrl.TextAlign = GetTextAlign(ctrl);
                            frmCtrl.ShowYn = GetShowYn(ctrl);
                            frmCtrl.EditYn = GetEditYn(ctrl);
                            frmCtrl.ChangedFlag = MdlState.Updated;
                        }
                        else
                        {
                            frmCtrlbs.Add(new DesignerV004_GRDFRMCTRL
                            {
                                FrwId = Common.GetValue("gFrameWorkId"),
                                FrmId = fromFormId.Text,
                                CtrlNm = ctrl.Name,
                                ToolNm = ctrl.GetType().Name,
                                CtrlW = GetWidth(ctrl),
                                CtrlH = GetHeight(ctrl),
                                CtrlX = ctrl.Location.X,
                                CtrlY = ctrl.Location.Y,
                                TitleText = GetTitleText(ctrl),
                                TitleWidth = GetTitleWidth(ctrl),
                                TitleAlign = GetTitleAlign(ctrl),
                                DefaultText = GetText(ctrl),
                                TextAlign = GetTextAlign(ctrl),
                                ShowYn = GetShowYn(ctrl),
                                EditYn = GetEditYn(ctrl),
                                ChangedFlag = MdlState.Inserted
                            });
                        }
                    }

                    if (ctrlMsts.Any(c => c.CtrlRegNm == ctrl.GetType().FullName && c.ContainYn))
                    {
                        FindUCControlsRecursive(ctrl); // 재귀 호출
                    }
                }
            }
        }

        private void frmFullPath_UCButtonClick(object Sender, Control control)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "DLL Files|*.dll|EXE Files|*.exe";

            if (string.IsNullOrEmpty(fromFullPath.Text))
            {
                openFileDialog1.InitialDirectory = frmWorkSpace.Text;
            }
            else
            {
                openFileDialog1.InitialDirectory = fromFullPath.Text;
            }

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

                frmFilePath.Text = Path.GetDirectoryName(openFileDialog1.FileName).Replace($"{frmWorkSpace.Text}\\", "");
                frmFileName.Text = openFileDialog1.SafeFileName;
                frmFormId.Text = frmFileName.Text.Substring(0, frmFileName.Text.Length - 4);
                frmFrameWork.Text = Common.GetValue("gFrameWorkId");
                frmNameSpace.Text = Common.GetValue("gNameSpace");
            }
        }
        #region Get Control Properties
        private string GetTextAlign(Control ctrl)
        {
            //if (ctrl is Ctrls.UCButton ucButton)
            //    return ucButton.TextAlignment.ToString();
            //else if (ctrl is Ctrls.UCCheckBox ucCheckBox)
            //    return ucCheckBox.TextAlignment.ToString();
            if (ctrl is Ctrls.UCChkCodeBox ucChkCodeBox)
                return ucChkCodeBox.TextAlignment.ToString();
            else if (ctrl is Ctrls.UCCodeBox ucCodeBox)
                return ucCodeBox.TextAlignment.ToString();
            //else if (ctrl is Ctrls.UCDataSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCDateBox ucDateBox)
            //    return ucDateBox.TextAlignment.ToString();
            //else if (ctrl is Ctrls.UCFieldSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCGridSet ucGridSet)
            //    return ucGridSet.TextAlignment.ToString();
            //else if (ctrl is Ctrls.UCLookUp ucLookUp)
            //    return ucLookUp.TextAlignment.ToString();
            else if (ctrl is Ctrls.UCMemo ucMemo)
                return ucMemo.TextAlignment.ToString();
            //else if (ctrl is Ctrls.UCPanel ucPanel)
            //    return ucPanel.TextAlignment.ToString();
            //else if (ctrl is Ctrls.UCRichText ucRichText)
            //    return ucRichText.TextAlignment.ToString();
            //else if (ctrl is Ctrls.UCSplit ucSplit)
            //    return ucSplit.TextAlignment.ToString();
            //else if (ctrl is Ctrls.UCTab ucTab)
            //    return ucTab.TextAlignment.ToString();
            else if (ctrl is Ctrls.UCTextBox ucTextBox)
                return ucTextBox.TextAlignment.ToString();
            else
                return "Default";
        }

        private string GetText(Control ctrl)
        {
            //if (ctrl is Ctrls.UCButton ucButton)
            //    return ucButton.Text;
            //else if (ctrl is Ctrls.UCCheckBox ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCChkCodeBox ucCtrl)
            //    return ucCtrl.Text;
            if (ctrl is Ctrls.UCCodeBox ucCodeBox)
                return ucCodeBox.Code;
            //else if (ctrl is Ctrls.UCDataSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCDateBox ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCFieldSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCGridSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCLookUp ucLookUp)
            //    return ucLookUp.Text;
            else if (ctrl is Ctrls.UCMemo ucMemo)
                return ucMemo.Text;
            //else if (ctrl is Ctrls.UCPanel ucCtrl)
            //    return ucCtrl.Text;
            else if (ctrl is Ctrls.UCRichText ucRichText)
                return ucRichText.Text;
            //else if (ctrl is Ctrls.UCSplit ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCTab ucCtrl)
            //    return ucCtrl.Text;
            else if (ctrl is Ctrls.UCTextBox ucTextBox)
                return ucTextBox.Text;
            else
                return "";
        }

        private int GetTitleWidth(Control ctrl)
        {
            if (ctrl is Ctrls.UCButton ucButton)
                return ucButton.Width;
            else if (ctrl is Ctrls.UCCheckBox ucCheckBox)
                return ucCheckBox.Width;
            else if (ctrl is Ctrls.UCChkCodeBox ucChkCodeBox)
                return ucChkCodeBox.TitleWidth;
            else if (ctrl is Ctrls.UCCodeBox ucCodeBox)
                return ucCodeBox.TitleWidth;
            //else if (ctrl is Ctrls.UCDataSet ucCtrl)
            //    return ucCtrl.Text;
            else if (ctrl is Ctrls.UCDateBox ucDateBox)
                return ucDateBox.Width;
            //else if (ctrl is Ctrls.UCFieldSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCGridSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCLookUp ucLookUp)
            //    return ucLookUp.TitleWidth;
            else if (ctrl is Ctrls.UCMemo ucMemo)
                return ucMemo.TitleWidth;
            //else if (ctrl is Ctrls.UCPanel ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCRichText ucRichText)
            //    return ucRichText.Text;
            //else if (ctrl is Ctrls.UCSplit ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCTab ucCtrl)
            //    return ucCtrl.Text;
            else if (ctrl is Ctrls.UCTextBox ucTextBox)
                return ucTextBox.TitleWidth;
            else
                return 0;
        }

        private int GetWidth(Control ctrl)
        {
            if (ctrl is Ctrls.UCButton ucButton)
                return ucButton.Width;
            else if (ctrl is Ctrls.UCCheckBox ucCheckBox)
                return ucCheckBox.Width;
            else if (ctrl is Ctrls.UCChkCodeBox ucChkCodeBox)
                return ucChkCodeBox.Width;
            else if (ctrl is Ctrls.UCCodeBox ucCodeBox)
                return ucCodeBox.Width;
            //else if (ctrl is Ctrls.UCDataSet ucCtrl)
            //    return ucCtrl.Text;
            else if (ctrl is Ctrls.UCDateBox ucDateBox)
                return ucDateBox.Width;
            //else if (ctrl is Ctrls.UCFieldSet ucCtrl)
            //    return ucCtrl.Text;
            else if (ctrl is Ctrls.UCGridSet ucGridSet)
                return ucGridSet.Width;
            //else if (ctrl is Ctrls.UCLookUp ucLookUp)
            //    return ucLookUp.Width;
            else if (ctrl is Ctrls.UCMemo ucMemo)
                return ucMemo.Width;
            else if (ctrl is Ctrls.UCPanel ucPanel)
                return ucPanel.Width;
            else if (ctrl is Ctrls.UCRichText ucRichText)
                return ucRichText.Width;
            else if (ctrl is Ctrls.UCSplit ucSplit)
                return ucSplit.Width;
            else if (ctrl is Ctrls.UCTab ucTab)
                return ucTab.Width;
            else if (ctrl is Ctrls.UCTextBox ucTextBox)
                return ucTextBox.Width;
            else if (ctrl is DevExpress.XtraTab.XtraTabPage tabPage)
                return tabPage.TabPageWidth;
            return ctrl.Width;

        }

        private int GetHeight(Control ctrl)
        {
            if (ctrl is Ctrls.UCButton ucButton)
                return ucButton.Height;
            else if (ctrl is Ctrls.UCCheckBox ucCheckBox)
                return ucCheckBox.Height;
            else if (ctrl is Ctrls.UCChkCodeBox ucChkCodeBox)
                return ucChkCodeBox.Height;
            else if (ctrl is Ctrls.UCCodeBox ucCodeBox)
                return ucCodeBox.Height;
            //else if (ctrl is Ctrls.UCDataSet ucCtrl)
            //    return ucCtrl.Text;
            else if (ctrl is Ctrls.UCDateBox ucDateBox)
                return ucDateBox.Height;
            //else if (ctrl is Ctrls.UCFieldSet ucCtrl)
            //    return ucCtrl.Text;
            else if (ctrl is Ctrls.UCGridSet ucGridSet)
                return ucGridSet.Height;
            //else if (ctrl is Ctrls.UCLookUp ucLookUp)
            //    return ucLookUp.Height;
            else if (ctrl is Ctrls.UCMemo ucMemo)
                return ucMemo.Height;
            else if (ctrl is Ctrls.UCPanel ucPanel)
                return ucPanel.Height;
            else if (ctrl is Ctrls.UCRichText ucRichText)
                return ucRichText.Height;
            else if (ctrl is Ctrls.UCSplit ucSplit)
                return ucSplit.Height;
            else if (ctrl is Ctrls.UCTab ucTab)
                return ucTab.Height;
            else if (ctrl is Ctrls.UCTextBox ucTextBox)
                return ucTextBox.Height;
            else
                return ctrl.Height;
        }

        private string GetTitleText(Control ctrl)
        {
            if (ctrl is Ctrls.UCButton ucButton)
                return ucButton.Title;
            //else if (ctrl is Ctrls.UCCheckBox ucCheckBox)
            //    return ucCheckBox.Title;
            else if (ctrl is Ctrls.UCChkCodeBox ucChkCodeBox)
                return ucChkCodeBox.Title;
            else if (ctrl is Ctrls.UCCodeBox ucCodeBox)
                return ucCodeBox.Title;
            //else if (ctrl is Ctrls.UCDataSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCDateBox ucDateBox)
            //    return ucDateBox.Title;
            //else if (ctrl is Ctrls.UCFieldSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCGridSet ucGridSet)
            //    return ucGridSet.Title;
            //else if (ctrl is Ctrls.UCLookUp ucLookUp)
            //    return ucLookUp.Title;
            else if (ctrl is Ctrls.UCMemo ucMemo)
                return ucMemo.Title;
            else if (ctrl is Ctrls.UCPanel ucPanel)
                return ucPanel.Text;
            //else if (ctrl is Ctrls.UCRichText ucRichText)
            //    return ucRichText.Title;
            //else if (ctrl is Ctrls.UCSplit ucSplit)
            //    return ucSplit.Title;
            //else if (ctrl is Ctrls.UCTab ucTab)
            //    return ucTab.Title;
            else if (ctrl is Ctrls.UCTextBox ucTextBox)
                return ucTextBox.Title;
            else if (ctrl is DevExpress.XtraTab.XtraTabPage tabPage)
                return tabPage.Text;
            return "";
        }

        private string GetTitleAlign(Control ctrl)
        {
            if (ctrl is Ctrls.UCButton ucButton)
                return ucButton.TitleAlignment.ToString();
            //else if (ctrl is Ctrls.UCCheckBox ucCheckBox)
            //    return ucCheckBox.TitleAlignment.ToString();
            else if (ctrl is Ctrls.UCChkCodeBox ucChkCodeBox)
                return ucChkCodeBox.TitleAlignment.ToString();
            else if (ctrl is Ctrls.UCCodeBox ucCodeBox)
                return ucCodeBox.TitleAlignment.ToString();
            //else if (ctrl is Ctrls.UCDataSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCDateBox ucDateBox)
            //    return ucDateBox.TitleAlignment.ToString();
            //else if (ctrl is Ctrls.UCFieldSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCGridSet ucGridSet)
            //    return ucGridSet.TitleAlignment.ToString();
            //else if (ctrl is Ctrls.UCLookUp ucLookUp)
            //    return ucLookUp.TitleAlignment.ToString();
            else if (ctrl is Ctrls.UCMemo ucMemo)
                return ucMemo.TitleAlignment.ToString();
            //else if (ctrl is Ctrls.UCPanel ucPanel)
            //    return ucPanel.TitleAlignment.ToString();
            //else if (ctrl is Ctrls.UCRichText ucRichText)
            //    return ucRichText.TitleAlignment.ToString();
            //else if (ctrl is Ctrls.UCSplit ucSplit)
            //    return ucSplit.TitleAlignment.ToString();
            //else if (ctrl is Ctrls.UCTab ucTab)
            //    return ucTab.TitleAlignment.ToString();
            else if (ctrl is Ctrls.UCTextBox ucTextBox)
                return ucTextBox.TitleAlignment.ToString();
            else
                return "Default";
        }

        private bool GetEditYn(Control ctrl)
        {
            if (ctrl is Ctrls.UCButton ucButton)
                return ucButton.EditYn;
            //else if (ctrl is Ctrls.UCCheckBox ucCheckBox)
            //    return ucCheckBox.EditYn;
            else if (ctrl is Ctrls.UCChkCodeBox ucChkCodeBox)
                return ucChkCodeBox.EditYn;
            else if (ctrl is Ctrls.UCCodeBox ucCodeBox)
                return ucCodeBox.EditYn;
            //else if (ctrl is Ctrls.UCDataSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCDateBox ucDateBox)
            //    return ucDateBox.EditYn;
            //else if (ctrl is Ctrls.UCFieldSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCGridSet ucGridSet)
            //    return ucGridSet.EditYn;
            //else if (ctrl is Ctrls.UCLookUp ucLookUp)
            //    return ucLookUp.EditYn;
            else if (ctrl is Ctrls.UCMemo ucMemo)
                return ucMemo.EditYn;
            else if (ctrl is Ctrls.UCPanel ucPanel)
                return ucPanel.EditYn;
            else if (ctrl is Ctrls.UCRichText ucRichText)
                return ucRichText.EditYn;
            //else if (ctrl is Ctrls.UCSplit ucSplit)
            //    return ucSplit.EditYn;
            //else if (ctrl is Ctrls.UCTab ucTab)
            //    return ucTab.EditYn;
            else if (ctrl is Ctrls.UCTextBox ucTextBox)
                return ucTextBox.EditYn;
            else
                return true;
        }
        private bool GetShowYn(Control ctrl)
        {
            if (ctrl is Ctrls.UCButton ucButton)
                return ucButton.ShowYn;
            //else if (ctrl is Ctrls.UCCheckBox ucCheckBox)
            //    return ucCheckBox.ShowYn;
            else if (ctrl is Ctrls.UCChkCodeBox ucChkCodeBox)
                return ucChkCodeBox.ShowYn;
            else if (ctrl is Ctrls.UCCodeBox ucCodeBox)
                return ucCodeBox.ShowYn;
            //else if (ctrl is Ctrls.UCDataSet ucCtrl)
            //    return ucCtrl.Text;
            //else if (ctrl is Ctrls.UCDateBox ucDateBox)
            //    return ucDateBox.ShowYn;
            //else if (ctrl is Ctrls.UCFieldSet ucCtrl)
            //    return ucCtrl.Text;
            else if (ctrl is Ctrls.UCGridSet ucGridSet)
                return ucGridSet.Visible;
            //else if (ctrl is Ctrls.UCLookUp ucLookUp)
            //    return ucLookUp.ShowYn;
            else if (ctrl is Ctrls.UCMemo ucMemo)
                return ucMemo.ShowYn;
            else if (ctrl is Ctrls.UCPanel ucPanel)
                return ucPanel.ShowYn;
            else if (ctrl is Ctrls.UCRichText ucRichText)
                return ucRichText.ShowYn;
            else if (ctrl is Ctrls.UCSplit ucSplit)
                return ucSplit.Visible;
            else if (ctrl is Ctrls.UCTextBox ucTextBox)
                return ucTextBox.ShowYn;
            else if (ctrl is DevExpress.XtraTab.XtraTabPage tabPage)
                return tabPage.PageVisible;
            else
                return true;
        }
        #endregion
        #endregion

        #region WorkSet Event -------------------------------------------------------
        private void grdFrm_UCAfterFocusedRow(object sender, int preIndex, int rowIndex, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            s_frmId.Text = frmFormId.Text;
            s_frmNm.Text = frmFormName.Text;
            //frmFullPath.Text = $"{frmWorkSpace.Text}\\{GetField("fldFrm", "FilePath")}\\{GetField("fldFrm", "FileNm")}";
            frmFullPath.Text = $"{frmWorkSpace.Text}\\{frmFilePath.Text}\\{frmFileName.Text}";
            fromFullPath.Text = $"{frmWorkSpace.Text}\\{frmFilePath.Text}\\{frmFileName.Text}";
            fromFormId.Text = frmFormId.Text;
            fromNameSpace.Text = frmNameSpace.Text;
        }
        #endregion

        #region DataSet Navigator ---------------------------------------------------
        private void grdWrkData_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            switch (e.Button.ButtonType)
            {
                case NavigatorButtonType.Remove:
                    break;
                case NavigatorButtonType.EndEdit:
                    break;
                case NavigatorButtonType.Append:
                    grdWrkData.AddNewDoc();
                    break;
                case NavigatorButtonType.CancelEdit:
                    break;
            }
        }
        #endregion
        #region FieldSet Navigator --------------------------------------------------

        private void grdWrkFld_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            switch (e.Button.ButtonType)
            {
                case NavigatorButtonType.Remove:
                    break;
                case NavigatorButtonType.EndEdit:
                    break;
                case NavigatorButtonType.Append:
                    grdWrkFld.AddNewDoc();
                    break;
                case NavigatorButtonType.CancelEdit:
                    break;
            }
        }
        #endregion

        #region grdFrmW Navigator ---------------------------------------------------
        private void grdFrmW_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            switch (e.Button.ButtonType)
            {
                case NavigatorButtonType.Remove:
                    break;
                case NavigatorButtonType.EndEdit:
                    break;
                case NavigatorButtonType.Append:
                    grdFrmW.AddNewDoc();
                    break;
                case NavigatorButtonType.CancelEdit:
                    break;
            }
        }
        #endregion

        #region GridSet Column ------------------------------------------------------
        private void pnlGrdColumns_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {

            //grdGrdFldbs = (BindingList<DesignerV004_GRDGRDFLD>)grdGrdFld.DataSource;
            grdGrdFldbs = grdGrdFld.DataSource as BindingList<DesignerV004_GRDGRDFLD>;

            DesignerV004_GRDWRKGRD selectedDoc = grdWrkGrd.GetDoc<DesignerV004_GRDWRKGRD>(grdWrkGrd.FocusedRowIndex);

            if (e.Button.Properties.Caption == "Numbering")
            {
                int i = 1;
                foreach (var wrkFld in grdGrdFldbs)
                {
                    wrkFld.Seq = i * 10;
                    i++;
                }
            }
            else if (e.Button.Properties.Caption == "Make Columns")
            {
                if (string.IsNullOrWhiteSpace(GenFunc.GetSql(new { FrwId = selectedDoc.FrwId, FrmId = selectedDoc.FrmId, WrkId = selectedDoc.WrkId, CRUDM = "R" })))
                {
                    MessageBox.Show("Select 쿼리를 먼저 입력하세요.");
                    return;
                }

                using (var db = new GaiaHelper())
                {
                    DataSet dSet = db.GetSelectColumns(new { FrwId = selectedDoc.FrwId, FrmId = selectedDoc.FrmId, WrkId = selectedDoc.WrkId, CRUDM = "R" });
                    if (dSet != null)
                    {
                        for (int i = 0; i < grdGrdFldbs.Count; i++)
                        {
                            grdGrdFldbs[i].ChangedFlag = MdlState.Deleted;
                        }

                        foreach (DataColumn cols in dSet.Tables[0].Columns)
                        {
                            var wrkFld = grdGrdFldbs.Where(x => x.CtrlNm == $"{selectedDoc.WrkId}.{cols.ColumnName}").FirstOrDefault();

                            if (wrkFld != null)
                            {
                                wrkFld.FrwId = selectedDoc.FrwId;
                                wrkFld.FrmId = selectedDoc.FrmId;
                                wrkFld.WrkId = selectedDoc.WrkId;
                                wrkFld.CtrlCls = "Column";
                                wrkFld.CtrlNm = $"{selectedDoc.WrkId}.{cols.ColumnName}";
                                wrkFld.FldNm = cols.ColumnName;
                                wrkFld.FldTy = GetFieldType(cols.DataType);
                                //wrkFld.FldTitle = cols.ColumnName;
                                wrkFld.ChangedFlag = MdlState.Updated;
                            }
                            else
                            {
                                grdGrdFldbs.Add(new DesignerV004_GRDGRDFLD
                                {
                                    FrwId = selectedDoc.FrwId,
                                    FrmId = selectedDoc.FrmId,
                                    WrkId = selectedDoc.WrkId,
                                    CtrlCls = "Column",
                                    CtrlNm = $"{selectedDoc.WrkId}.{cols.ColumnName}",
                                    FldNm = cols.ColumnName,
                                    FldTy = GetFieldType(cols.DataType),
                                    FldTitle = cols.ColumnName,
                                    ShowYn = true,
                                    EditYn = true,
                                    ChangedFlag = MdlState.Inserted
                                });
                            }
                        }
                        grdGrdFld.DataSource = grdGrdFldbs;
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Show ChangedFlag")
            {
                string sql = @"
if exists(select 1
            from WRKFLD
           where FrwId = @FrwId
             and FrmId = @FrmId
             and WrkId = @WrkId
             and FldNm = 'ChangedFlag')
begin
    update a
       set ShowYn = 1
      from WRKFLD a
     where FrwId = @FrwId
       and FrmId = @FrmId
       and WrkId = @WrkId
       and FldNm = 'ChangedFlag'
end else begin
    insert into WRKFLD
          (FrwId, FrmId, CtrlNm, WrkId, FldNm,
           CtrlCls, FldTy, FldTitleWidth, FldTitle, ShowYn, Seq, 
           CId, CDt, MId, MDt)
    select @FrwId, @FrmId, CtrlNm=concat(@WrkId,'.ChangedFlag'), @WrkId, 'ChangedFlag',
           'Column', 'Text', 80, 'ChangedFlag', 1, 0, 
           10020, getdate(), 10020, getdate()
end
";
                using (var db = new Libs.GaiaHelper())
                {
                    db.OpenExecute(sql, new { FrwId = selectedDoc.FrwId, FrmId = selectedDoc.FrmId, WrkId = selectedDoc.WrkId });
                }
            }
        }
        private string GetFieldType(Type dataType)
        {
            return dataType.Name switch
            {
                "Int32" => "Int",
                "String" => "Text",
                "DateTime" => "DateTime",
                "Date" => "Date",
                "Decimal" => "Decimal",
                "Double" => "Decimal",
                "Boolean" => "bool",
                _ => "Text",
            };
        }
        #endregion
        #region GridSet GET ---------------------------------------------------------
        private void ucPanel16_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Make GetParameters Data")
            {
                SyntaxExtractor extractor = new SyntaxExtractor();
                SyntaxMatch cvariables = extractor.ExtractVariables(rtxGrdR.Text);

                var wrkGetbs = (BindingList<DesignerV004_GRDGRDGET>)grdGrdGet.DataSource;

                foreach (var kvp in cvariables.OPatternMatch)
                {
                    //wrkGets에 있으면 update 없으면 insert
                    var wrkGet = wrkGetbs.Where(x => x.FldNm == kvp.Key).FirstOrDefault();
                    if (wrkGet == null)
                    {
                        wrkGet = wrkGetbs.Where(x => x.FldNm.ToLower() == kvp.Key.ToLower()).FirstOrDefault();
                        if (wrkGet != null)
                        {
                            wrkGet.FldNm = kvp.Key;
                            wrkGet.ChangedFlag = MdlState.Updated;
                        }
                        else
                        {
                            wrkGetbs.Add(new DesignerV004_GRDGRDGET
                            {
                                FrwId = grdWrkGrd.GetText("FrwId"),
                                FrmId = grdWrkGrd.GetText("FrmId"),
                                WrkId = grdWrkGrd.GetText("WrkId"),
                                FldNm = kvp.Key,
                                ChangedFlag = MdlState.None
                            });
                        }
                    }
                }
            }
        }
        #endregion
        #region GridSet SET ---------------------------------------------------------
        private void ucPanel15_CustomButtonClick(object Sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //grdGrdSet
            if (e.Button.Properties.Caption == "Set(Push) Target List")
            {
                var wrkSetbs = (BindingList<DesignerV004_GRDGRDSET>)grdGrdSet.DataSource;
                var addSetbs = new WrkSetRepo().GetTargetList(grdWrkGrd.GetText("FrwId"), grdWrkGrd.GetText("FrmId"));

                foreach (var addSet in addSetbs)
                {
                    //wrkGets에 있으면 update 없으면 insert
                    var setList = wrkSetbs.Where(x => x.FldNm == addSet.SetFldNm).FirstOrDefault();
                    if (setList == null)
                    {
                        wrkSetbs.Add(new DesignerV004_GRDGRDSET
                        {
                            FrwId = addSet.FrwId,
                            FrmId = addSet.FrmId,
                            WrkId = grdWrkGrd.GetText("WrkId"),
                            SetFldNm = addSet.SetFldNm,
                            ChangedFlag = MdlState.None
                        });
                    }
                }
            }
        }
        #endregion
        #region GridSet REF ---------------------------------------------------------
        private BindingList<DesignerV004_GRDGRDREF> grdGrdRefbs;
        private void ucPanel14_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Reference Data")
            {
                SyntaxExtractor extractor = new SyntaxExtractor();
                SyntaxMatch cvariables = extractor.ExtractVariables(rtxGrdU.Text);

                grdGrdRefbs = (BindingList<DesignerV004_GRDGRDREF>)grdGrdRef.DataSource;

                foreach (var kvp in cvariables.OPatternMatch)
                {
                    //wrkRefs에 있으면 update 없으면 insert
                    var wrkRef = grdGrdRefbs.Where(x => x.FldNm == kvp.Key).FirstOrDefault();
                    if (wrkRef == null)
                    {
                        wrkRef = grdGrdRefbs.Where(x => x.FldNm.ToLower() == kvp.Key.ToLower()).FirstOrDefault();
                        if (wrkRef != null)
                        {
                            wrkRef.FldNm = kvp.Key;
                            wrkRef.ChangedFlag = MdlState.Updated;
                        }
                        else
                        {
                            grdGrdRefbs.Add(new DesignerV004_GRDGRDREF
                            {
                                FrwId = grdWrkGrd.GetText("FrwId"),
                                FrmId = grdWrkGrd.GetText("FrmId"),
                                WrkId = grdWrkGrd.GetText("WrkId"),
                                FldNm = kvp.Key,
                                ChangedFlag = MdlState.None
                            });
                        }
                    }
                }

                cvariables = extractor.ExtractVariables(rtxGrdC.Text);

                foreach (var kvp in cvariables.OPatternMatch)
                {
                    var wrkRef = grdGrdRefbs.Where(x => x.FldNm == kvp.Key).FirstOrDefault();
                    if (wrkRef == null)
                    {
                        wrkRef = grdGrdRefbs.Where(x => x.FldNm.ToLower() == kvp.Key.ToLower()).FirstOrDefault();
                        if (wrkRef != null)
                        {
                            wrkRef.FldNm = kvp.Key;
                            wrkRef.ChangedFlag = MdlState.Updated;
                        }
                        else
                        {
                            grdGrdRefbs.Add(new DesignerV004_GRDGRDREF
                            {
                                FrwId = grdWrkGrd.GetText("FrwId"),
                                FrmId = grdWrkGrd.GetText("FrmId"),
                                WrkId = grdWrkGrd.GetText("WrkId"),
                                FldNm = kvp.Key,
                                ChangedFlag = MdlState.None
                            });
                        }
                    }
                }
            }
        }
        #endregion
        #region FieldSet Get --------------------------------------------------------
        private void ucPanel18_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Make GetParameters Data")
            {
                SyntaxExtractor extractor = new SyntaxExtractor();
                SyntaxMatch cvariables = extractor.ExtractVariables(rtxFldR.Text);

                var wrkGetbs = (BindingList<DesignerV004_GRDFLDGET>)grdFldGet.DataSource;

                foreach (var kvp in cvariables.OPatternMatch)
                {
                    //wrkGets에 있으면 update 없으면 insert
                    var wrkGet = wrkGetbs.Where(x => x.FldNm == kvp.Key).FirstOrDefault();
                    if (wrkGet == null)
                    {
                        wrkGet = wrkGetbs.Where(x => x.FldNm.ToLower() == kvp.Key.ToLower()).FirstOrDefault();
                        if (wrkGet != null)
                        {
                            wrkGet.FldNm = kvp.Key;
                            wrkGet.ChangedFlag = MdlState.Updated;
                        }
                        else
                        {
                            wrkGetbs.Add(new DesignerV004_GRDFLDGET
                            {
                                FrwId = grdWrkFld.GetText("FrwId"),
                                FrmId = grdWrkFld.GetText("FrmId"),
                                WrkId = grdWrkFld.GetText("WrkId"),
                                FldNm = kvp.Key,
                                ChangedFlag = MdlState.Inserted
                            });
                        }
                    }
                }
            }
        }
        #endregion
        #region FieldSet Ref --------------------------------------------------------        
        private void ucPanel17_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Reference Data")
            {
                SyntaxExtractor extractor = new SyntaxExtractor();
                SyntaxMatch cvariables = extractor.ExtractVariables(rtxFldU.Text);

                var wrkRefbs = (BindingList<DesignerV004_GRDFLDREF>)grdFldRef.DataSource;

                foreach (var kvp in cvariables.OPatternMatch)
                {
                    //wrkRefs에 있으면 update 없으면 insert
                    var wrkRef = wrkRefbs.Where(x => x.FldNm == kvp.Key).FirstOrDefault();
                    if (wrkRef == null)
                    {
                        wrkRef = wrkRefbs.Where(x => x.FldNm.ToLower() == kvp.Key.ToLower()).FirstOrDefault();
                        if (wrkRef != null)
                        {
                            wrkRef.FldNm = kvp.Key;
                            wrkRef.ChangedFlag = MdlState.Updated;
                        }
                        else
                        {
                            wrkRefbs.Add(new DesignerV004_GRDFLDREF
                            {
                                FrwId = grdWrkFld.GetText("FrwId"),
                                FrmId = grdWrkFld.GetText("FrmId"),
                                WrkId = grdWrkFld.GetText("WrkId"),
                                FldNm = kvp.Key,
                                ChangedFlag = MdlState.None
                            });
                        }
                    }
                }

                cvariables = extractor.ExtractVariables(rtxFldC.Text);

                foreach (var kvp in cvariables.OPatternMatch)
                {
                    var wrkRef = wrkRefbs.Where(x => x.FldNm == kvp.Key).FirstOrDefault();
                    if (wrkRef == null)
                    {
                        wrkRef = wrkRefbs.Where(x => x.FldNm.ToLower() == kvp.Key.ToLower()).FirstOrDefault();
                        if (wrkRef != null)
                        {
                            wrkRef.FldNm = kvp.Key;
                            wrkRef.ChangedFlag = MdlState.Updated;
                        }
                        else
                        {
                            wrkRefbs.Add(new DesignerV004_GRDFLDREF
                            {
                                FrwId = grdWrkGrd.GetText("FrwId"),
                                FrmId = grdWrkGrd.GetText("FrmId"),
                                WrkId = grdWrkGrd.GetText("WrkId"),
                                FldNm = kvp.Key,
                                ChangedFlag = MdlState.None
                            });
                        }
                    }
                }
            }
        }
        #endregion
        #region FieldSet Set --------------------------------------------------------  
        private void ucPanel2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //grdGrdSet
            if (e.Button.Properties.Caption == "Get Field")
            {
                var wrkSetbs = (BindingList<DesignerV004_GRDFLDSET>)grdFldSet.DataSource;
                var addSetbs = new WrkSetRepo().GetTargetList(grdWrkFld.GetText("FrwId"), grdWrkFld.GetText("FrmId"));

                foreach (var addSet in addSetbs)
                {
                    //wrkGets에 있으면 update 없으면 insert
                    var setList = wrkSetbs.Where(x => x.FldNm == addSet.SetFldNm).FirstOrDefault();
                    if (setList == null)
                    {
                        wrkSetbs.Add(new DesignerV004_GRDFLDSET
                        {
                            FrwId = addSet.FrwId,
                            FrmId = addSet.FrmId,
                            WrkId = grdWrkFld.GetText("WrkId"),
                            SetFldNm = addSet.SetFldNm,
                            ChangedFlag = MdlState.None
                        });
                    }
                }
            }
        }
        #endregion
        #region DataSet Get ---------------------------------------------------------
        private void ucPanel3_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Make GetParameters Data")
            {
                SyntaxExtractor extractor = new SyntaxExtractor();
                SyntaxMatch cvariables = extractor.ExtractVariables(rtxDataR.Text);

                var wrkGetbs = (BindingList<DesignerV004_GRDDATAGET>)grdDataGet.DataSource;

                foreach (var kvp in cvariables.OPatternMatch)
                {
                    //wrkGets에 있으면 update 없으면 insert
                    var wrkGet = wrkGetbs.Where(x => x.FldNm == kvp.Key).FirstOrDefault();
                    if (wrkGet == null)
                    {
                        wrkGet = wrkGetbs.Where(x => x.FldNm.ToLower() == kvp.Key.ToLower()).FirstOrDefault();
                        if (wrkGet != null)
                        {
                            wrkGet.FldNm = kvp.Key;
                            wrkGet.ChangedFlag = MdlState.Updated;
                        }
                        else
                        {
                            wrkGetbs.Add(new DesignerV004_GRDDATAGET
                            {
                                FrwId = grdWrkData.GetText("FrwId"),
                                FrmId = grdWrkData.GetText("FrmId"),
                                WrkId = grdWrkData.GetText("WrkId"),
                                FldNm = kvp.Key,
                                ChangedFlag = MdlState.None
                            });
                        }
                    }
                }
            }
        }
        #endregion

        #region ETC -----------------------------------------------------------------
        private void btnGridWrk_Click(object sender, EventArgs e)
        {
            Common.gLog = "-----------------------------------------------------";
            Common.gLog = "-- grdFrmW Start ------------------------------------";
            Common.gLog = "-----------------------------------------------------";
            // GridView 객체 가져오기
            StringBuilder properties = new StringBuilder();

            if (grdFrm.MainView is GridView gridView)
            {
                MessageBox.Show("MainView is a GridView.");
                // GridView의 모든 속성 조회
                properties.AppendLine("GridView Properties:");
                properties.AppendLine(GetProperties(gridView));

                // GridControl의 모든 속성 조회
                properties.AppendLine("GridControl Properties:");
                properties.AppendLine(GetProperties(grdFrmW));
            }
            else if (grdFrm.MainView is BandedGridView bandView)
            {
                MessageBox.Show("MainView is a BandedGridView.");
                // GridView의 모든 속성 조회
                properties.AppendLine("BandedGridView Properties:");
                properties.AppendLine(GetProperties(bandView));

                // GridControl의 모든 속성 조회
                properties.AppendLine("GridControl Properties:");
                properties.AppendLine(GetProperties(grdFrmW));
            }
            Common.gLog = $"{properties.ToString()}";
            Common.gLog = "-----------------------------------------------------";
            Common.gLog = "-- grdFrmW End --------------------------------------";
            Common.gLog = "-----------------------------------------------------";
            Common.gLog = " ";
        }

        private void btnGridCtrl_Click(object sender, EventArgs e)
        {
            Common.gLog = "-----------------------------------------------------";
            Common.gLog = "-- grdFrmCtrl Start ---------------------------------";
            Common.gLog = "-----------------------------------------------------";
            // GridView 객체 가져오기
            GridView gridView = grdFrmCtrl.gvBand as GridView;

            if (gridView != null)
            {
                // GridView의 모든 속성 조회
                StringBuilder properties = new StringBuilder();
                properties.AppendLine("GridView Properties:");
                properties.AppendLine(GetProperties(gridView));

                // GridControl의 모든 속성 조회
                properties.AppendLine("GridControl Properties:");
                properties.AppendLine(GetProperties(grdFrmCtrl));

                // 조회한 속성을 메시지 박스에 표시
                Common.gLog = $"{properties.ToString()}";
            }
            else
            {
                MessageBox.Show("MainView is not a GridView.");
            }
            Common.gLog = "-----------------------------------------------------";
            Common.gLog = "-- grdFrmCtrl End -----------------------------------";
            Common.gLog = "-----------------------------------------------------";
            Common.gLog = " ";
        }

        private string GetProperties(object obj)
        {
            StringBuilder properties = new StringBuilder();
            PropertyInfo[] propertyInfos = obj.GetType().GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                try
                {
                    var value = propertyInfo.GetValue(obj, null);
                    properties.AppendLine($"{propertyInfo.Name}: {value}");
                }
                catch (Exception ex)
                {
                    properties.AppendLine($"{propertyInfo.Name}: {ex.Message}");
                }
            }

            return properties.ToString();
        }
        #endregion

        private void grdFrmW_UCInitNewRow(object sender, InitNewRowEventArgs e)
        {
            grdFrmW.SetText("FrwId", grdFrm.GetText("FrwId"));
            grdFrmW.SetText("FrmId", grdFrm.GetText("FrmId"));
            grdFrmW.SetText("UseYn", 1);
        }

        private void ucButton2_Click(object sender, EventArgs e)
        {
            //DynamicParameters p = new DynamicParameters();
            //p.Add("@FrwId", grdFrm.GetText("FrwId"));
            //OpenDataSet("dtTest", p);
            DataSet ds = new DataSet();
            ds = OpenDataSet("dtTest");

            DataTable table = ds.Tables[0];

            if (table != null)
            {
                // DataTable의 각 행(DataRow)을 순회하며 데이터 출력
                foreach (DataRow row in table.Rows)
                {
                    // 각 열(DataColumn)의 값을 출력 (필요에 따라 형변환)
                    foreach (DataColumn column in table.Columns)
                    {
                        Common.gLog = $"{column.ColumnName}: {row[column]}";
                        // 또는 원하는 방식으로 데이터 처리
                    }
                }
            }
            else
            {
                Common.gLog = "dtTest라는 이름의 DataTable이 없습니다.";
            }


        }
    }
}
