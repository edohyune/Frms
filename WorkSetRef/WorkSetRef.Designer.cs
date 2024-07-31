namespace EpicV004.Frms
{
    partial class WorkSetRef
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkSetRef));
            ucSplit1 = new Ctrls.UCSplit();
            ucButton1 = new Ctrls.UCButton();
            wrkId = new Ctrls.UCTextBox();
            frmId = new Ctrls.UCTextBox();
            frwId = new Ctrls.UCTextBox();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            grdWrkRef = new Ctrls.UCGridSet();
            imageCollection1 = new DevExpress.Utils.ImageCollection(components);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageCollection1).BeginInit();
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
            ucSplit1.Panel1.Controls.Add(ucButton1);
            ucSplit1.Panel1.Controls.Add(wrkId);
            ucSplit1.Panel1.Controls.Add(frmId);
            ucSplit1.Panel1.Controls.Add(frwId);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(gridControl1);
            ucSplit1.Panel2.Controls.Add(grdWrkRef);
            ucSplit1.Size = new Size(800, 450);
            ucSplit1.SplitterDistance = 35;
            ucSplit1.TabIndex = 1;
            ucSplit1.TitleWidth = 50;
            // 
            // ucButton1
            // 
            ucButton1.Appearance.Font = new Font("Tahoma", 9F);
            ucButton1.Appearance.Options.UseFont = true;
            ucButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton1.ControlHeight = 21;
            ucButton1.ControlWidth = 100;
            ucButton1.FontBold = FontStyle.Regular;
            ucButton1.FontFace = "Tahoma";
            ucButton1.FontSize = 9F;
            ucButton1.ImageOptions.Image = (Image)resources.GetObject("ucButton1.ImageOptions.Image");
            ucButton1.Location = new Point(639, 11);
            ucButton1.Name = "ucButton1";
            ucButton1.Size = new Size(100, 21);
            ucButton1.TabIndex = 7;
            ucButton1.Title = "UCButton";
            ucButton1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // wrkId
            // 
            wrkId.ButtonVisiable = true;
            wrkId.ControlHeight = 21;
            wrkId.ControlWidth = 210;
            wrkId.FontColor = Color.FromArgb(40, 40, 40);
            wrkId.FontFace = "Tahoma";
            wrkId.FontSize = 9F;
            wrkId.FormatStr = "";
            wrkId.Location = new Point(392, 8);
            wrkId.Name = "wrkId";
            wrkId.Size = new Size(210, 21);
            wrkId.TabIndex = 6;
            wrkId.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            wrkId.Title = "WorkSet";
            wrkId.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            wrkId.TitleWidth = 70;
            // 
            // frmId
            // 
            frmId.ButtonVisiable = true;
            frmId.ControlHeight = 21;
            frmId.ControlWidth = 210;
            frmId.FontColor = Color.FromArgb(40, 40, 40);
            frmId.FontFace = "Tahoma";
            frmId.FontSize = 9F;
            frmId.FormatStr = "";
            frmId.Location = new Point(202, 8);
            frmId.Name = "frmId";
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
            frwId.ButtonVisiable = true;
            frwId.ControlHeight = 21;
            frwId.ControlWidth = 210;
            frwId.FontColor = Color.FromArgb(40, 40, 40);
            frwId.FontFace = "Tahoma";
            frwId.FontSize = 9F;
            frwId.FormatStr = "";
            frwId.Location = new Point(12, 8);
            frwId.Name = "frwId";
            frwId.Size = new Size(210, 21);
            frwId.TabIndex = 4;
            frwId.Text = "EpicV004";
            frwId.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            frwId.Title = "FrameWork";
            frwId.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            frwId.TitleWidth = 70;
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(190, 137);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(400, 200);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // grdWrkRef
            // 
            grdWrkRef.Dock = DockStyle.Fill;
            grdWrkRef.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdWrkRef.Location = new Point(0, 0);
            grdWrkRef.Name = "grdWrkRef";
            grdWrkRef.Size = new Size(800, 411);
            grdWrkRef.TabIndex = 0;
            grdWrkRef.Load += grdWrkRef_Load;
            // 
            // imageCollection1
            // 
            imageCollection1.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("imageCollection1.ImageStream");
            imageCollection1.InsertGalleryImage("save_16x16.png", "grayscaleimages/save/save_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("grayscaleimages/save/save_16x16.png"), 0);
            imageCollection1.Images.SetKeyName(0, "save_16x16.png");
            imageCollection1.InsertGalleryImage("updatetable_16x16.png", "grayscaleimages/other/updatetable_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("grayscaleimages/other/updatetable_16x16.png"), 1);
            imageCollection1.Images.SetKeyName(1, "updatetable_16x16.png");
            imageCollection1.InsertGalleryImage("delete_16x16.png", "grayscaleimages/edit/delete_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("grayscaleimages/edit/delete_16x16.png"), 2);
            imageCollection1.Images.SetKeyName(2, "delete_16x16.png");
            imageCollection1.InsertGalleryImage("saveandnew_16x16.png", "grayscaleimages/save/saveandnew_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("grayscaleimages/save/saveandnew_16x16.png"), 3);
            imageCollection1.Images.SetKeyName(3, "saveandnew_16x16.png");
            // 
            // WorkSetRef
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "WorkSetRef";
            Size = new Size(800, 450);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageCollection1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCTextBox wrkId;
        private Ctrls.UCTextBox frmId;
        private Ctrls.UCTextBox frwId;
        private Ctrls.UCGridSet grdWrkRef;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Ctrls.UCButton ucButton1;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}
