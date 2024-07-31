namespace EpicV004.Frms
{
    partial class WorkSetSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ucSplit1 = new Ctrls.UCSplit();
            wrkId = new Ctrls.UCTextBox();
            frmId = new Ctrls.UCTextBox();
            frwId = new Ctrls.UCTextBox();
            grdWrkSet = new Ctrls.UCGridSet();
            btnLoadField = new Ctrls.UCButton();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdWrkSet).BeginInit();
            SuspendLayout();
            // 
            // ucSplit1
            // 
            ucSplit1.Dock = DockStyle.Fill;
            ucSplit1.FixedPanel = FixedPanel.Panel1;
            ucSplit1.Location = new Point(0, 0);
            ucSplit1.Name = "ucSplit1";
            ucSplit1.Orientation = Orientation.Horizontal;
            // 
            // ucSplit1.Panel1
            // 
            ucSplit1.Panel1.Controls.Add(btnLoadField);
            ucSplit1.Panel1.Controls.Add(wrkId);
            ucSplit1.Panel1.Controls.Add(frmId);
            ucSplit1.Panel1.Controls.Add(frwId);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(grdWrkSet);
            ucSplit1.Size = new Size(800, 450);
            ucSplit1.SplitterDistance = 35;
            ucSplit1.TabIndex = 1;
            ucSplit1.TitleWidth = 50;
            // 
            // wrkId
            // 
            wrkId.BindText = "";
            wrkId.ButtonVisiable = true;
            wrkId.ControlHeight = 21;
            wrkId.ControlWidth = 210;
            wrkId.EditYn = true;
            wrkId.FontColor = Color.FromArgb(40, 40, 40);
            wrkId.FontFace = "Tahoma";
            wrkId.FontSize = 9F;
            wrkId.FormatStr = "";
            wrkId.Location = new Point(392, 8);
            wrkId.Name = "wrkId";
            wrkId.ShowYn = true;
            wrkId.Size = new Size(210, 21);
            wrkId.TabIndex = 6;
            wrkId.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            wrkId.Title = "WorkSet";
            wrkId.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            wrkId.TitleWidth = 70;
            // 
            // frmId
            // 
            frmId.BindText = "DesignerV004";
            frmId.ButtonVisiable = true;
            frmId.ControlHeight = 21;
            frmId.ControlWidth = 210;
            frmId.EditYn = true;
            frmId.FontColor = Color.FromArgb(40, 40, 40);
            frmId.FontFace = "Tahoma";
            frmId.FontSize = 9F;
            frmId.FormatStr = "";
            frmId.Location = new Point(202, 8);
            frmId.Name = "frmId";
            frmId.ShowYn = true;
            frmId.Size = new Size(210, 21);
            frmId.TabIndex = 5;
            frmId.Text = "DesignerV004";
            frmId.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            frmId.Title = "Form ID";
            frmId.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            frmId.TitleWidth = 70;
            // 
            // frwId
            // 
            frwId.BindText = "EpicV004";
            frwId.ButtonVisiable = true;
            frwId.ControlHeight = 21;
            frwId.ControlWidth = 210;
            frwId.EditYn = true;
            frwId.FontColor = Color.FromArgb(40, 40, 40);
            frwId.FontFace = "Tahoma";
            frwId.FontSize = 9F;
            frwId.FormatStr = "";
            frwId.Location = new Point(12, 8);
            frwId.Name = "frwId";
            frwId.ShowYn = true;
            frwId.Size = new Size(210, 21);
            frwId.TabIndex = 4;
            frwId.Text = "EpicV004";
            frwId.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            frwId.Title = "FrameWork";
            frwId.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            frwId.TitleWidth = 70;
            // 
            // grdWrkSet
            // 
            grdWrkSet.ColumnAutoWidth = true;
            grdWrkSet.Dock = DockStyle.Fill;
            grdWrkSet.FocusedRowIndex = int.MinValue;
            grdWrkSet.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdWrkSet.frmId = "Unknown";
            grdWrkSet.frwId = "";
            grdWrkSet.Location = new Point(0, 0);
            grdWrkSet.MultiSelect = false;
            grdWrkSet.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            grdWrkSet.Name = "grdWrkSet";
            grdWrkSet.ParentForm = null;
            grdWrkSet.RowAutoHeigh = false;
            grdWrkSet.ShowFindPanel = false;
            grdWrkSet.ShowGroupPanel = true;
            grdWrkSet.Size = new Size(800, 411);
            grdWrkSet.TabIndex = 0;
            grdWrkSet.wrkId = "grdWrkSet";
            // 
            // btnLoadField
            // 
            btnLoadField.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadField.Appearance.Options.UseFont = true;
            btnLoadField.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btnLoadField.ControlHeight = 21;
            btnLoadField.ControlWidth = 104;
            btnLoadField.EditYn = true;
            btnLoadField.FontBold = FontStyle.Regular;
            btnLoadField.FontFace = "Tahoma";
            btnLoadField.FontSize = 9F;
            btnLoadField.Location = new Point(608, 8);
            btnLoadField.Name = "btnLoadField";
            btnLoadField.ShowYn = true;
            btnLoadField.Size = new Size(104, 21);
            btnLoadField.TabIndex = 7;
            btnLoadField.Title = "Load Field";
            btnLoadField.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            btnLoadField.Click += btnLoadField_Click;
            // 
            // WorkSetSet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "WorkSetSet";
            Size = new Size(800, 450);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdWrkSet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCTextBox wrkId;
        private Ctrls.UCTextBox frmId;
        private Ctrls.UCTextBox frwId;
        private Ctrls.UCGridSet grdWrkSet;
        private Ctrls.UCButton btnLoadField;
    }
}
