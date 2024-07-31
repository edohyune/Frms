namespace EpicV004.Frms
{
    partial class QueryEditor
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
            crudm = new Ctrls.UCTextBox();
            wrkId = new Ctrls.UCTextBox();
            frmId = new Ctrls.UCTextBox();
            frwId = new Ctrls.UCTextBox();
            rtxQuery = new Ctrls.UCRichText();
            changedFlag = new Ctrls.UCTextBox();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
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
            ucSplit1.Panel1.Controls.Add(changedFlag);
            ucSplit1.Panel1.Controls.Add(crudm);
            ucSplit1.Panel1.Controls.Add(wrkId);
            ucSplit1.Panel1.Controls.Add(frmId);
            ucSplit1.Panel1.Controls.Add(frwId);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(rtxQuery);
            ucSplit1.Size = new Size(1097, 466);
            ucSplit1.SplitterDistance = 35;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 50;
            // 
            // crudm
            // 
            crudm.ButtonVisiable = true;
            crudm.ControlHeight = 21;
            crudm.ControlWidth = 182;
            crudm.FontColor = Color.FromArgb(40, 40, 40);
            crudm.FontFace = "Tahoma";
            crudm.FontSize = 9F;
            crudm.FormatStr = "";
            crudm.Location = new Point(582, 8);
            crudm.Margin = new Padding(4, 3, 4, 3);
            crudm.Name = "crudm";
            crudm.Size = new Size(182, 21);
            crudm.TabIndex = 3;
            crudm.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            crudm.Title = "CRUDM";
            crudm.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            crudm.TitleWidth = 70;
            // 
            // wrkId
            // 
            wrkId.ButtonVisiable = true;
            wrkId.ControlHeight = 21;
            wrkId.ControlWidth = 182;
            wrkId.FontColor = Color.FromArgb(40, 40, 40);
            wrkId.FontFace = "Tahoma";
            wrkId.FontSize = 9F;
            wrkId.FormatStr = "";
            wrkId.Location = new Point(392, 8);
            wrkId.Margin = new Padding(4, 3, 4, 3);
            wrkId.Name = "wrkId";
            wrkId.Size = new Size(182, 21);
            wrkId.TabIndex = 2;
            wrkId.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            wrkId.Title = "WorkSet";
            wrkId.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            wrkId.TitleWidth = 70;
            // 
            // frmId
            // 
            frmId.ButtonVisiable = true;
            frmId.ControlHeight = 21;
            frmId.ControlWidth = 182;
            frmId.FontColor = Color.FromArgb(40, 40, 40);
            frmId.FontFace = "Tahoma";
            frmId.FontSize = 9F;
            frmId.FormatStr = "";
            frmId.Location = new Point(202, 8);
            frmId.Margin = new Padding(4, 3, 4, 3);
            frmId.Name = "frmId";
            frmId.Size = new Size(182, 21);
            frmId.TabIndex = 1;
            frmId.Text = "DesignerV004";
            frmId.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            frmId.Title = "Form ID";
            frmId.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            frmId.TitleWidth = 70;
            // 
            // frwId
            // 
            frwId.ButtonVisiable = true;
            frwId.ControlHeight = 21;
            frwId.ControlWidth = 182;
            frwId.FontColor = Color.FromArgb(40, 40, 40);
            frwId.FontFace = "Tahoma";
            frwId.FontSize = 9F;
            frwId.FormatStr = "";
            frwId.Location = new Point(12, 8);
            frwId.Margin = new Padding(4, 3, 4, 3);
            frwId.Name = "frwId";
            frwId.Size = new Size(182, 21);
            frwId.TabIndex = 0;
            frwId.Text = "EpicV004";
            frwId.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            frwId.Title = "FrameWork";
            frwId.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            frwId.TitleWidth = 70;
            // 
            // rtxQuery
            // 
            rtxQuery.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            rtxQuery.Appearance.Text.Font = new Font("Consolas", 9F);
            rtxQuery.Appearance.Text.Options.UseFont = true;
            rtxQuery.Dock = DockStyle.Fill;
            rtxQuery.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            rtxQuery.Location = new Point(0, 0);
            rtxQuery.Modified = true;
            rtxQuery.Name = "rtxQuery";
            rtxQuery.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            rtxQuery.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            rtxQuery.Options.Search.RegExResultMaxGuaranteedLength = 500;
            rtxQuery.Size = new Size(1097, 427);
            rtxQuery.TabIndex = 0;
            // 
            // changedFlag
            // 
            changedFlag.ButtonVisiable = true;
            changedFlag.ControlHeight = 21;
            changedFlag.ControlWidth = 182;
            changedFlag.FontColor = Color.FromArgb(40, 40, 40);
            changedFlag.FontFace = "Tahoma";
            changedFlag.FontSize = 9F;
            changedFlag.FormatStr = "";
            changedFlag.Location = new Point(772, 8);
            changedFlag.Margin = new Padding(4, 3, 4, 3);
            changedFlag.Name = "changedFlag";
            changedFlag.Size = new Size(182, 21);
            changedFlag.TabIndex = 4;
            changedFlag.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            changedFlag.Title = "ChangedFlag";
            changedFlag.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            changedFlag.TitleWidth = 70;
            // 
            // QueryEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "QueryEditor";
            Size = new Size(1097, 466);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCTextBox crudm;
        private EpicV004.Ctrls.UCTextBox wrkId;
        private EpicV004.Ctrls.UCTextBox frmId;
        private EpicV004.Ctrls.UCTextBox frwId;
        private EpicV004.Ctrls.UCRichText rtxQuery;
        private Ctrls.UCTextBox changedFlag;
    }
}
