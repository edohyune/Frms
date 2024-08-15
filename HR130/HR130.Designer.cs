namespace EpicV004.Frms
{
    partial class HR130
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
            ucSplit1 = new EpicV004.Ctrls.UCSplit();
            ucPanel1 = new EpicV004.Ctrls.UCPanel();
            s_edate = new EpicV004.Ctrls.UCDateBox();
            s_sdate = new EpicV004.Ctrls.UCDateBox();
            ucPanel2 = new EpicV004.Ctrls.UCPanel();
            ucTab1 = new EpicV004.Ctrls.UCTab();
            control1 = new DevExpress.XtraTab.XtraTabPage();
            g10 = new EpicV004.Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new EpicV004.Ctrls.UCGridSet();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g30 = new EpicV004.Ctrls.UCGridSet();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            g40 = new EpicV004.Ctrls.UCGridSet();
            xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            g50 = new EpicV004.Ctrls.UCGridSet();
            s_apt = new EpicV004.Ctrls.UCTextBox();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucTab1).BeginInit();
            ucTab1.SuspendLayout();
            control1.SuspendLayout();
            xtraTabPage2.SuspendLayout();
            xtraTabPage1.SuspendLayout();
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
            ucSplit1.Panel2.Controls.Add(ucPanel2);
            ucSplit1.Size = new Size(800, 450);
            ucSplit1.SplitterDistance = 66;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_apt);
            ucPanel1.Controls.Add(s_edate);
            ucPanel1.Controls.Add(s_sdate);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(800, 66);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "ucPanel1";
            // 
            // s_edate
            // 
            s_edate.ControlHeight = 23;
            s_edate.ControlWidth = 228;
            s_edate.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_edate.FontColor = Color.Black;
            s_edate.FontFace = "Tahoma";
            s_edate.FontSize = 9F;
            s_edate.FormatStr = "";
            s_edate.Location = new Point(267, 31);
            s_edate.Margin = new Padding(3, 4, 3, 4);
            s_edate.Name = "s_edate";
            s_edate.Size = new Size(228, 23);
            s_edate.TabIndex = 1;
            s_edate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_edate.Title = "~";
            s_edate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_edate.TitleWidth = 25;
            // 
            // s_sdate
            // 
            s_sdate.ControlHeight = 23;
            s_sdate.ControlWidth = 250;
            s_sdate.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_sdate.FontColor = Color.Black;
            s_sdate.FontFace = "Tahoma";
            s_sdate.FontSize = 9F;
            s_sdate.FormatStr = "";
            s_sdate.Location = new Point(11, 35);
            s_sdate.Margin = new Padding(3, 4, 3, 4);
            s_sdate.Name = "s_sdate";
            s_sdate.Size = new Size(250, 23);
            s_sdate.TabIndex = 0;
            s_sdate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_sdate.Title = "Date";
            s_sdate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_sdate.TitleWidth = 50;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(ucTab1);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(800, 380);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "ucPanel2";
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(2, 28);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = control1;
            ucTab1.Size = new Size(796, 350);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { control1, xtraTabPage2, xtraTabPage1, xtraTabPage3, xtraTabPage4 });
            // 
            // control1
            // 
            control1.Controls.Add(g10);
            control1.Name = "control1";
            control1.Size = new Size(794, 320);
            control1.Text = "Applicant Informations";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Margin = new Padding(3, 4, 3, 4);
            g10.Name = "g10";
            g10.Size = new Size(794, 320);
            g10.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g20);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(794, 320);
            xtraTabPage2.Text = "Family";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Margin = new Padding(3, 4, 3, 4);
            g20.Name = "g20";
            g20.Size = new Size(794, 320);
            g20.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g30);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(794, 320);
            xtraTabPage1.Text = "Education";
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Margin = new Padding(3, 4, 3, 4);
            g30.Name = "g30";
            g30.Size = new Size(794, 320);
            g30.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(g40);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new Size(794, 320);
            xtraTabPage3.Text = "license";
            // 
            // g40
            // 
            g40.Dock = DockStyle.Fill;
            g40.Location = new Point(0, 0);
            g40.Margin = new Padding(3, 4, 3, 4);
            g40.Name = "g40";
            g40.Size = new Size(794, 320);
            g40.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            xtraTabPage4.Controls.Add(g50);
            xtraTabPage4.Name = "xtraTabPage4";
            xtraTabPage4.Size = new Size(794, 320);
            xtraTabPage4.Text = "Work History";
            // 
            // g50
            // 
            g50.Dock = DockStyle.Fill;
            g50.Location = new Point(0, 0);
            g50.Margin = new Padding(3, 4, 3, 4);
            g50.Name = "g50";
            g50.Size = new Size(794, 320);
            g50.TabIndex = 0;
            // 
            // s_apt
            // 
            s_apt.ControlHeight = 26;
            s_apt.ControlWidth = 250;
            s_apt.FontColor = Color.Black;
            s_apt.FontFace = "Tahoma";
            s_apt.FontSize = 9F;
            s_apt.FormatStr = "";
            s_apt.Location = new Point(502, 31);
            s_apt.Margin = new Padding(4, 3, 4, 3);
            s_apt.Name = "s_apt";
            s_apt.Size = new Size(250, 26);
            s_apt.TabIndex = 2;
            s_apt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_apt.Title = "Applicant ID";
            s_apt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_apt.TitleWidth = 80;
            // 
            // HR130
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR130";
            Size = new Size(800, 450);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucTab1).EndInit();
            ucTab1.ResumeLayout(false);
            control1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage3.ResumeLayout(false);
            xtraTabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private EpicV004.Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage control1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private EpicV004.Ctrls.UCDateBox s_sdate;
        private EpicV004.Ctrls.UCDateBox s_edate;
        private EpicV004.Ctrls.UCGridSet g10;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private EpicV004.Ctrls.UCGridSet g20;
        private EpicV004.Ctrls.UCGridSet g30;
        private EpicV004.Ctrls.UCGridSet g40;
        private EpicV004.Ctrls.UCGridSet g50;
        private EpicV004.Ctrls.UCTextBox s_apt;
    }
}
