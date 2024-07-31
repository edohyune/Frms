namespace EpicV004.Frms
{
    partial class SYSCDE
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
            ucSplit2 = new Ctrls.UCSplit();
            ucPanel1 = new Ctrls.UCPanel();
            grdCde = new Ctrls.UCGridSet();
            ucPanel2 = new Ctrls.UCPanel();
            grdPpt = new Ctrls.UCGridSet();
            ucPanel3 = new Ctrls.UCPanel();
            grdDtl = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit2).BeginInit();
            ucSplit2.Panel1.SuspendLayout();
            ucSplit2.Panel2.SuspendLayout();
            ucSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel3).BeginInit();
            ucPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // ucSplit1
            // 
            ucSplit1.Dock = DockStyle.Fill;
            ucSplit1.Location = new Point(0, 0);
            ucSplit1.Name = "ucSplit1";
            ucSplit1.Orientation = Orientation.Horizontal;
            // 
            // ucSplit1.Panel1
            // 
            ucSplit1.Panel1.Controls.Add(ucSplit2);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucPanel3);
            ucSplit1.Size = new Size(882, 542);
            ucSplit1.SplitterDistance = 249;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(ucPanel2);
            ucSplit2.Size = new Size(882, 249);
            ucSplit2.SplitterDistance = 414;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(grdCde);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(414, 249);
            ucPanel1.TabIndex = 0;
            // 
            // grdCde
            // 
            grdCde.Dock = DockStyle.Fill;
            grdCde.Location = new Point(2, 23);
            grdCde.Name = "grdCde";
            grdCde.Size = new Size(410, 224);
            grdCde.TabIndex = 0;
            grdCde.UCAfterFocusedRow += grdCde_UCAfterFocusedRow;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(grdPpt);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(464, 249);
            ucPanel2.TabIndex = 0;
            // 
            // grdPpt
            // 
            grdPpt.Dock = DockStyle.Fill;
            grdPpt.Location = new Point(2, 23);
            grdPpt.Name = "grdPpt";
            grdPpt.Size = new Size(460, 224);
            grdPpt.TabIndex = 1;
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(grdDtl);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(0, 0);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(882, 289);
            ucPanel3.TabIndex = 1;
            // 
            // grdDtl
            // 
            grdDtl.Dock = DockStyle.Fill;
            grdDtl.Location = new Point(2, 23);
            grdDtl.Name = "grdDtl";
            grdDtl.Size = new Size(878, 264);
            grdDtl.TabIndex = 1;
            // 
            // SYSCDE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SYSCDE";
            Size = new Size(882, 542);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ucSplit2.Panel1.ResumeLayout(false);
            ucSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit2).EndInit();
            ucSplit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel3).EndInit();
            ucPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCGridSet grdCde;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCGridSet grdPpt;
        private Ctrls.UCPanel ucPanel3;
        private Ctrls.UCGridSet grdDtl;
    }
}
