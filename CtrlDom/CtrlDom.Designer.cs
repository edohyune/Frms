namespace EpicV004.Frms
{
    partial class CtrlDom
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
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucSplit5 = new Ctrls.UCSplit();
            cmdDomTy = new Ctrls.UCCodeBox();
            richTxt1 = new Ctrls.UCRichText();
            ucSplit4 = new Ctrls.UCSplit();
            richTxt2 = new Ctrls.UCRichText();
            richTxt3 = new Ctrls.UCRichText();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ucImage1 = new Ctrls.UCImage();
            ((System.ComponentModel.ISupportInitialize)ucTab1).BeginInit();
            ucTab1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit2).BeginInit();
            ucSplit2.Panel1.SuspendLayout();
            ucSplit2.Panel2.SuspendLayout();
            ucSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit3).BeginInit();
            ucSplit3.Panel1.SuspendLayout();
            ucSplit3.Panel2.SuspendLayout();
            ucSplit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit5).BeginInit();
            ucSplit5.Panel1.SuspendLayout();
            ucSplit5.Panel2.SuspendLayout();
            ucSplit5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit4).BeginInit();
            ucSplit4.Panel1.SuspendLayout();
            ucSplit4.Panel2.SuspendLayout();
            ucSplit4.SuspendLayout();
            xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucImage1.Properties).BeginInit();
            SuspendLayout();
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(800, 450);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(ucSplit2);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(798, 424);
            xtraTabPage1.TabPageWidth = 120;
            xtraTabPage1.Text = "Controller List";
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(g10);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(ucSplit3);
            ucSplit2.Size = new Size(798, 424);
            ucSplit2.SplitterDistance = 482;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(482, 424);
            g10.TabIndex = 0;
            // 
            // ucSplit3
            // 
            ucSplit3.Dock = DockStyle.Fill;
            ucSplit3.FixedPanel = FixedPanel.Panel2;
            ucSplit3.Location = new Point(0, 0);
            ucSplit3.Name = "ucSplit3";
            ucSplit3.Orientation = Orientation.Horizontal;
            // 
            // ucSplit3.Panel1
            // 
            ucSplit3.Panel1.Controls.Add(ucSplit5);
            // 
            // ucSplit3.Panel2
            // 
            ucSplit3.Panel2.Controls.Add(ucSplit4);
            ucSplit3.Size = new Size(312, 424);
            ucSplit3.SplitterDistance = 318;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucSplit5
            // 
            ucSplit5.Dock = DockStyle.Fill;
            ucSplit5.FixedPanel = FixedPanel.Panel1;
            ucSplit5.Location = new Point(0, 0);
            ucSplit5.Name = "ucSplit5";
            ucSplit5.Orientation = Orientation.Horizontal;
            // 
            // ucSplit5.Panel1
            // 
            ucSplit5.Panel1.Controls.Add(cmdDomTy);
            // 
            // ucSplit5.Panel2
            // 
            ucSplit5.Panel2.Controls.Add(richTxt1);
            ucSplit5.Size = new Size(312, 318);
            ucSplit5.SplitterDistance = 38;
            ucSplit5.TabIndex = 0;
            ucSplit5.TitleWidth = 121;
            // 
            // cmdDomTy
            // 
            cmdDomTy.ControlHeight = 21;
            cmdDomTy.ControlWidth = 200;
            cmdDomTy.FldTy = null;
            cmdDomTy.FontColor = Color.Black;
            cmdDomTy.FontFace = "Tahoma";
            cmdDomTy.FontSize = 9F;
            cmdDomTy.Location = new Point(10, 9);
            cmdDomTy.Margin = new Padding(4, 3, 4, 3);
            cmdDomTy.Name = "cmdDomTy";
            cmdDomTy.Size = new Size(200, 21);
            cmdDomTy.TabIndex = 0;
            cmdDomTy.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            cmdDomTy.Title = "DOM Type";
            cmdDomTy.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            cmdDomTy.TitleWidth = 60;
            // 
            // richTxt1
            // 
            richTxt1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            richTxt1.Dock = DockStyle.Fill;
            richTxt1.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            richTxt1.Location = new Point(0, 0);
            richTxt1.Modified = true;
            richTxt1.Name = "richTxt1";
            richTxt1.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            richTxt1.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            richTxt1.Options.Search.RegExResultMaxGuaranteedLength = 1000;
            richTxt1.Padding = new Padding(50, 0, 0, 0);
            richTxt1.Size = new Size(312, 276);
            richTxt1.TabIndex = 0;
            richTxt1.Views.DraftView.AllowDisplayLineNumbers = true;
            // 
            // ucSplit4
            // 
            ucSplit4.Dock = DockStyle.Fill;
            ucSplit4.Location = new Point(0, 0);
            ucSplit4.Name = "ucSplit4";
            ucSplit4.Orientation = Orientation.Horizontal;
            // 
            // ucSplit4.Panel1
            // 
            ucSplit4.Panel1.Controls.Add(richTxt2);
            // 
            // ucSplit4.Panel2
            // 
            ucSplit4.Panel2.Controls.Add(richTxt3);
            ucSplit4.Size = new Size(312, 102);
            ucSplit4.SplitterDistance = 51;
            ucSplit4.TabIndex = 0;
            ucSplit4.TitleWidth = 121;
            // 
            // richTxt2
            // 
            richTxt2.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            richTxt2.Dock = DockStyle.Fill;
            richTxt2.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            richTxt2.Location = new Point(0, 0);
            richTxt2.Modified = true;
            richTxt2.Name = "richTxt2";
            richTxt2.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            richTxt2.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            richTxt2.Options.Search.RegExResultMaxGuaranteedLength = 1000;
            richTxt2.Padding = new Padding(50, 0, 0, 0);
            richTxt2.Size = new Size(312, 51);
            richTxt2.TabIndex = 0;
            richTxt2.Views.DraftView.AllowDisplayLineNumbers = true;
            // 
            // richTxt3
            // 
            richTxt3.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            richTxt3.Dock = DockStyle.Fill;
            richTxt3.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            richTxt3.Location = new Point(0, 0);
            richTxt3.Modified = true;
            richTxt3.Name = "richTxt3";
            richTxt3.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            richTxt3.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            richTxt3.Options.Search.RegExResultMaxGuaranteedLength = 1000;
            richTxt3.Padding = new Padding(50, 0, 0, 0);
            richTxt3.Size = new Size(312, 47);
            richTxt3.TabIndex = 0;
            richTxt3.Views.DraftView.AllowDisplayLineNumbers = true;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(ucImage1);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(798, 424);
            xtraTabPage2.TabPageWidth = 120;
            xtraTabPage2.Text = "xtraTabPage2";
            // 
            // ucImage1
            // 
            ucImage1.Location = new Point(55, 67);
            ucImage1.Name = "ucImage1";
            ucImage1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            ucImage1.Size = new Size(210, 215);
            ucImage1.TabIndex = 0;
            // 
            // CtrlDom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucTab1);
            Name = "CtrlDom";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)ucTab1).EndInit();
            ucTab1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            ucSplit2.Panel1.ResumeLayout(false);
            ucSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit2).EndInit();
            ucSplit2.ResumeLayout(false);
            ucSplit3.Panel1.ResumeLayout(false);
            ucSplit3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit3).EndInit();
            ucSplit3.ResumeLayout(false);
            ucSplit5.Panel1.ResumeLayout(false);
            ucSplit5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit5).EndInit();
            ucSplit5.ResumeLayout(false);
            ucSplit4.Panel1.ResumeLayout(false);
            ucSplit4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit4).EndInit();
            ucSplit4.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucImage1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCSplit ucSplit4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCCodeBox cmdDomTy;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCSplit ucSplit5;
        private Ctrls.UCRichText richTxt1;
        private Ctrls.UCRichText richTxt2;
        private Ctrls.UCRichText richTxt3;
        private Ctrls.UCImage ucImage1;
        //private RichTxt richTxt1;
        //private RichTxt richTxt2;
        //private RichTxt richTxt3;
    }
}
