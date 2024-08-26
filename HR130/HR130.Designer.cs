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
            ucSplit1 = new Ctrls.UCSplit();
            ucPanel1 = new Ctrls.UCPanel();
            s_applicant_id = new Ctrls.UCTextBox();
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
            ucPanel2 = new Ctrls.UCPanel();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g10 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new Ctrls.UCGridSet();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            g30 = new Ctrls.UCGridSet();
            xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            g40 = new Ctrls.UCGridSet();
            xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            g50 = new Ctrls.UCGridSet();
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
            xtraTabPage1.SuspendLayout();
            xtraTabPage2.SuspendLayout();
            xtraTabPage3.SuspendLayout();
            xtraTabPage4.SuspendLayout();
            xtraTabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // ucSplit1
            // 
            ucSplit1.Dock = DockStyle.Fill;
            ucSplit1.FixedPanel = FixedPanel.Panel1;
            ucSplit1.Location = new Point(0, 0);
            ucSplit1.Margin = new Padding(3, 2, 3, 2);
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
            ucSplit1.Size = new Size(1086, 572);
            ucSplit1.SplitterDistance = 56;
            ucSplit1.SplitterWidth = 3;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_applicant_id);
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Margin = new Padding(3, 2, 3, 2);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1086, 56);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Batch Register Applicant";
            // 
            // s_applicant_id
            // 
            s_applicant_id.ControlHeight = 21;
            s_applicant_id.ControlWidth = 288;
            s_applicant_id.FontColor = Color.Black;
            s_applicant_id.FontFace = "Tahoma";
            s_applicant_id.FontSize = 9F;
            s_applicant_id.FormatStr = "";
            s_applicant_id.Location = new Point(314, 28);
            s_applicant_id.Name = "s_applicant_id";
            s_applicant_id.Size = new Size(288, 21);
            s_applicant_id.TabIndex = 2;
            s_applicant_id.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_applicant_id.Title = "Applicant Id";
            s_applicant_id.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_applicant_id.TitleWidth = 100;
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 140;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(168, 29);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(140, 21);
            to_dt.TabIndex = 1;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 30;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 157;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 29);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(157, 21);
            fr_dt.TabIndex = 0;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 50;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(ucTab1);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Margin = new Padding(3, 2, 3, 2);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1086, 513);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Data List";
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(2, 23);
            ucTab1.Margin = new Padding(3, 2, 3, 2);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1082, 488);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2, xtraTabPage3, xtraTabPage4, xtraTabPage5 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g10);
            xtraTabPage1.Margin = new Padding(3, 2, 3, 2);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1080, 463);
            xtraTabPage1.Text = "Applicant Informations";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1080, 463);
            g10.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g20);
            xtraTabPage2.Margin = new Padding(3, 2, 3, 2);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1080, 463);
            xtraTabPage2.Text = "Family";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1080, 463);
            g20.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(g30);
            xtraTabPage3.Margin = new Padding(3, 2, 3, 2);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new Size(1080, 463);
            xtraTabPage3.Text = "Education";
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(1080, 463);
            g30.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            xtraTabPage4.Controls.Add(g40);
            xtraTabPage4.Margin = new Padding(3, 2, 3, 2);
            xtraTabPage4.Name = "xtraTabPage4";
            xtraTabPage4.Size = new Size(1080, 463);
            xtraTabPage4.Text = "license";
            // 
            // g40
            // 
            g40.Dock = DockStyle.Fill;
            g40.Location = new Point(0, 0);
            g40.Name = "g40";
            g40.Size = new Size(1080, 463);
            g40.TabIndex = 0;
            // 
            // xtraTabPage5
            // 
            xtraTabPage5.Controls.Add(g50);
            xtraTabPage5.Margin = new Padding(3, 2, 3, 2);
            xtraTabPage5.Name = "xtraTabPage5";
            xtraTabPage5.Size = new Size(1080, 463);
            xtraTabPage5.Text = "Work History";
            // 
            // g50
            // 
            g50.Dock = DockStyle.Fill;
            g50.Location = new Point(0, 0);
            g50.Name = "g50";
            g50.Size = new Size(1080, 463);
            g50.TabIndex = 0;
            // 
            // HR130
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HR130";
            Size = new Size(1086, 572);
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
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            xtraTabPage3.ResumeLayout(false);
            xtraTabPage4.ResumeLayout(false);
            xtraTabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private EpicV004.Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private EpicV004.Ctrls.UCGridSet g10;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private EpicV004.Ctrls.UCGridSet g20;
        private EpicV004.Ctrls.UCGridSet g30;
        private EpicV004.Ctrls.UCGridSet g40;
        private EpicV004.Ctrls.UCGridSet g50;
        private Ctrls.UCTextBox s_applicant_id;
        private Ctrls.UCDateBox to_dt;
        private Ctrls.UCDateBox fr_dt;
    }
}
