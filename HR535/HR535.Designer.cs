namespace EpicV004.Frms
{
    partial class HR535
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
            ucPanel1 = new Ctrls.UCPanel();
            btn_clear = new Ctrls.UCButton();
            btn_save = new Ctrls.UCButton();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            g10 = new Ctrls.UCGridSet();
            g20 = new Ctrls.UCGridSet();
            g30 = new Ctrls.UCGridSet();
            g40 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucTab1).BeginInit();
            ucTab1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            xtraTabPage2.SuspendLayout();
            xtraTabPage3.SuspendLayout();
            xtraTabPage4.SuspendLayout();
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
            ucSplit1.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucTab1);
            ucSplit1.Size = new Size(800, 450);
            ucSplit1.SplitterDistance = 72;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(btn_save);
            ucPanel1.Controls.Add(btn_clear);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(800, 72);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Upload Adjusted Data";
            // 
            // btn_clear
            // 
            btn_clear.Appearance.Font = new Font("Tahoma", 9F);
            btn_clear.Appearance.Options.UseFont = true;
            btn_clear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_clear.ControlHeight = 41;
            btn_clear.ControlWidth = 126;
            btn_clear.FontBold = FontStyle.Regular;
            btn_clear.FontFace = "Tahoma";
            btn_clear.FontSize = 9F;
            btn_clear.Location = new Point(5, 26);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(126, 41);
            btn_clear.TabIndex = 0;
            btn_clear.Title = "Clear";
            btn_clear.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // btn_save
            // 
            btn_save.Appearance.Font = new Font("Tahoma", 9F);
            btn_save.Appearance.Options.UseFont = true;
            btn_save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_save.ControlHeight = 41;
            btn_save.ControlWidth = 135;
            btn_save.FontBold = FontStyle.Regular;
            btn_save.FontFace = "Tahoma";
            btn_save.FontSize = 9F;
            btn_save.Location = new Point(137, 26);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(135, 41);
            btn_save.TabIndex = 0;
            btn_save.Title = "Save Upload Data";
            btn_save.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(800, 374);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2, xtraTabPage3, xtraTabPage4 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g10);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(798, 349);
            xtraTabPage1.TabPageWidth = 60;
            xtraTabPage1.Text = "Leave";
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g20);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(798, 349);
            xtraTabPage2.TabPageWidth = 60;
            xtraTabPage2.Text = "OT";
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(g30);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new Size(798, 349);
            xtraTabPage3.TabPageWidth = 60;
            xtraTabPage3.Text = "Time Scan";
            // 
            // xtraTabPage4
            // 
            xtraTabPage4.Controls.Add(g40);
            xtraTabPage4.Name = "xtraTabPage4";
            xtraTabPage4.Size = new Size(798, 349);
            xtraTabPage4.TabPageWidth = 100;
            xtraTabPage4.Text = "Addition/Deduction";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(798, 349);
            g10.TabIndex = 0;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(798, 349);
            g20.TabIndex = 0;
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(798, 349);
            g30.TabIndex = 0;
            // 
            // g40
            // 
            g40.Dock = DockStyle.Fill;
            g40.Location = new Point(0, 0);
            g40.Name = "g40";
            g40.Size = new Size(798, 349);
            g40.TabIndex = 0;
            // 
            // HR535
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR535";
            Size = new Size(800, 450);
            Load += HR535_Load;
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucTab1).EndInit();
            ucTab1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            xtraTabPage3.ResumeLayout(false);
            xtraTabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCButton btn_save;
        private Ctrls.UCButton btn_clear;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCGridSet g30;
        private Ctrls.UCGridSet g40;
    }
}
