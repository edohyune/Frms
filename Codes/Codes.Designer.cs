namespace EpicV004.Frms
{
    partial class Codes
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
            ucPanel3 = new Ctrls.UCPanel();
            mdl_cd = new Ctrls.UCCodeBox();
            ctgr_cd = new Ctrls.UCTextBox();
            ucSplit2 = new Ctrls.UCSplit();
            ucPanel1 = new Ctrls.UCPanel();
            g10 = new Ctrls.UCGridSet();
            ucPanel2 = new Ctrls.UCPanel();
            g20 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel3).BeginInit();
            ucPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit2).BeginInit();
            ucSplit2.Panel1.SuspendLayout();
            ucSplit2.Panel2.SuspendLayout();
            ucSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
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
            ucSplit1.Panel1.Controls.Add(ucPanel3);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucSplit2);
            ucSplit1.Size = new Size(1341, 722);
            ucSplit1.SplitterDistance = 64;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(mdl_cd);
            ucPanel3.Controls.Add(ctgr_cd);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(0, 0);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(1341, 64);
            ucPanel3.TabIndex = 0;
            ucPanel3.Text = "Lookup";
            // 
            // mdl_cd
            // 
            mdl_cd.ControlHeight = 21;
            mdl_cd.ControlWidth = 219;
            mdl_cd.FldTy = null;
            mdl_cd.FontColor = Color.Black;
            mdl_cd.FontFace = "Tahoma";
            mdl_cd.FontSize = 9F;
            mdl_cd.Location = new Point(211, 37);
            mdl_cd.Name = "mdl_cd";
            mdl_cd.Size = new Size(219, 21);
            mdl_cd.TabIndex = 1;
            mdl_cd.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            mdl_cd.Title = "Module";
            mdl_cd.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            mdl_cd.TitleWidth = 100;
            // 
            // ctgr_cd
            // 
            ctgr_cd.ControlHeight = 21;
            ctgr_cd.ControlWidth = 200;
            ctgr_cd.FontColor = Color.Black;
            ctgr_cd.FontFace = "Tahoma";
            ctgr_cd.FontSize = 9F;
            ctgr_cd.FormatStr = "";
            ctgr_cd.Location = new Point(5, 37);
            ctgr_cd.Name = "ctgr_cd";
            ctgr_cd.Size = new Size(200, 21);
            ctgr_cd.TabIndex = 0;
            ctgr_cd.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ctgr_cd.Title = "Category Code";
            ctgr_cd.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ctgr_cd.TitleWidth = 100;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            ucSplit2.Orientation = Orientation.Horizontal;
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(ucPanel2);
            ucSplit2.Size = new Size(1341, 654);
            ucSplit2.SplitterDistance = 375;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(g10);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1341, 375);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Classification Code";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(1337, 350);
            g10.TabIndex = 0;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(g20);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1341, 275);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "BaseCode";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(2, 23);
            g20.Name = "g20";
            g20.Size = new Size(1337, 250);
            g20.TabIndex = 0;
            // 
            // Codes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "Codes";
            Size = new Size(1341, 722);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel3).EndInit();
            ucPanel3.ResumeLayout(false);
            ucSplit2.Panel1.ResumeLayout(false);
            ucSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit2).EndInit();
            ucSplit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCSplit ucSplit2;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private EpicV004.Ctrls.UCPanel ucPanel3;
        private EpicV004.Ctrls.UCCodeBox mdl_cd;
        private EpicV004.Ctrls.UCTextBox ctgr_cd;
        private EpicV004.Ctrls.UCGridSet g10;
        private EpicV004.Ctrls.UCGridSet g20;
    }
}
