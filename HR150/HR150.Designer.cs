namespace EpicV004.Frms
{
    partial class HR150
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
            ucPanel2 = new Ctrls.UCPanel();
            s_status = new Ctrls.UCChkCodeBox();
            health_chk = new Ctrls.UCChkCodeBox();
            interview = new Ctrls.UCChkCodeBox();
            trn_emp = new Ctrls.UCChkCodeBox();
            s_applicant = new Ctrls.UCTextBox();
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
            ucPanel1 = new Ctrls.UCPanel();
            g10 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
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
            ucSplit1.Panel1.Controls.Add(ucPanel2);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucPanel1);
            ucSplit1.Size = new Size(1079, 538);
            ucSplit1.SplitterDistance = 79;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(s_status);
            ucPanel2.Controls.Add(health_chk);
            ucPanel2.Controls.Add(interview);
            ucPanel2.Controls.Add(trn_emp);
            ucPanel2.Controls.Add(s_applicant);
            ucPanel2.Controls.Add(to_dt);
            ucPanel2.Controls.Add(fr_dt);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1079, 79);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Search";
            // 
            // s_status
            // 
            s_status.ControlHeight = 21;
            s_status.ControlWidth = 200;
            s_status.FontFace = "Tahoma";
            s_status.FontSize = 9F;
            s_status.Location = new Point(778, 26);
            s_status.Name = "s_status";
            s_status.Size = new Size(200, 21);
            s_status.TabIndex = 5;
            s_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_status.Title = "Status";
            s_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_status.TitleWidth = 100;
            // 
            // health_chk
            // 
            health_chk.ControlHeight = 21;
            health_chk.ControlWidth = 200;
            health_chk.FontFace = "Tahoma";
            health_chk.FontSize = 9F;
            health_chk.Location = new Point(572, 52);
            health_chk.Name = "health_chk";
            health_chk.Size = new Size(200, 21);
            health_chk.TabIndex = 4;
            health_chk.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            health_chk.Title = "Health Check";
            health_chk.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            health_chk.TitleWidth = 100;
            // 
            // interview
            // 
            interview.ControlHeight = 21;
            interview.ControlWidth = 200;
            interview.FontFace = "Tahoma";
            interview.FontSize = 9F;
            interview.Location = new Point(572, 26);
            interview.Name = "interview";
            interview.Size = new Size(200, 21);
            interview.TabIndex = 3;
            interview.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            interview.Title = "Interview";
            interview.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            interview.TitleWidth = 100;
            // 
            // trn_emp
            // 
            trn_emp.ControlHeight = 21;
            trn_emp.ControlWidth = 342;
            trn_emp.FontFace = "Tahoma";
            trn_emp.FontSize = 9F;
            trn_emp.Location = new Point(224, 52);
            trn_emp.Name = "trn_emp";
            trn_emp.Size = new Size(342, 21);
            trn_emp.TabIndex = 2;
            trn_emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            trn_emp.Title = "Transfer to Employee Master";
            trn_emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            trn_emp.TitleWidth = 160;
            // 
            // s_applicant
            // 
            s_applicant.ControlHeight = 21;
            s_applicant.ControlWidth = 342;
            s_applicant.FontColor = Color.Black;
            s_applicant.FontFace = "Tahoma";
            s_applicant.FontSize = 9F;
            s_applicant.FormatStr = "";
            s_applicant.Location = new Point(224, 26);
            s_applicant.Name = "s_applicant";
            s_applicant.Size = new Size(342, 21);
            s_applicant.TabIndex = 1;
            s_applicant.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_applicant.Title = "Applicant";
            s_applicant.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_applicant.TitleWidth = 160;
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 200;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(5, 52);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(200, 21);
            to_dt.TabIndex = 0;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 100;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 200;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 26);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(200, 21);
            fr_dt.TabIndex = 0;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Apply Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 100;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(g10);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1079, 455);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Data List";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(1075, 430);
            g10.TabIndex = 0;
            // 
            // HR150
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR150";
            Size = new Size(1079, 538);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private EpicV004.Ctrls.UCChkCodeBox interview;
        private EpicV004.Ctrls.UCChkCodeBox trn_emp;
        private EpicV004.Ctrls.UCTextBox s_applicant;
        private EpicV004.Ctrls.UCDateBox to_dt;
        private EpicV004.Ctrls.UCDateBox fr_dt;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCGridSet g10;
        private EpicV004.Ctrls.UCChkCodeBox s_status;
        private EpicV004.Ctrls.UCChkCodeBox health_chk;
    }
}
