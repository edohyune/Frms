namespace EpicV004.Frms
{
    partial class HR755
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
            f_status = new Ctrls.UCCodeBox();
            f_emp = new Ctrls.UCTextBox();
            f_dept = new Ctrls.UCTextBox();
            s_to_dt = new Ctrls.UCDateBox();
            s_fr_dt = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            ucButton2 = new Ctrls.UCButton();
            ucButton1 = new Ctrls.UCButton();
            status = new Ctrls.UCCodeBox();
            termination_date = new Ctrls.UCDateBox();
            memo = new Ctrls.UCTextBox();
            doc_no = new Ctrls.UCTextBox();
            ucSplit4 = new Ctrls.UCSplit();
            g20 = new Ctrls.UCGridSet();
            g30 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit2).BeginInit();
            ucSplit2.Panel1.SuspendLayout();
            ucSplit2.Panel2.SuspendLayout();
            ucSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit3).BeginInit();
            ucSplit3.Panel1.SuspendLayout();
            ucSplit3.Panel2.SuspendLayout();
            ucSplit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit4).BeginInit();
            ucSplit4.Panel1.SuspendLayout();
            ucSplit4.Panel2.SuspendLayout();
            ucSplit4.SuspendLayout();
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
            ucSplit1.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucSplit2);
            ucSplit1.Size = new Size(1321, 707);
            ucSplit1.SplitterDistance = 82;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(f_status);
            ucPanel1.Controls.Add(f_emp);
            ucPanel1.Controls.Add(f_dept);
            ucPanel1.Controls.Add(s_to_dt);
            ucPanel1.Controls.Add(s_fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1321, 82);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Termination";
            // 
            // f_status
            // 
            f_status.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_status.Appearance.Options.UseFont = true;
            f_status.ControlHeight = 21;
            f_status.ControlWidth = 200;
            f_status.FldTy = null;
            f_status.FontColor = Color.Black;
            f_status.FontFace = "Tahoma";
            f_status.FontSize = 9F;
            f_status.Location = new Point(414, 26);
            f_status.Name = "f_status";
            f_status.Size = new Size(200, 21);
            f_status.TabIndex = 7;
            f_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_status.Title = "Status";
            f_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_status.TitleWidth = 93;
            // 
            // f_emp
            // 
            f_emp.Appearance.Font = new Font("Tahoma", 9F);
            f_emp.Appearance.Options.UseFont = true;
            f_emp.ControlHeight = 21;
            f_emp.ControlWidth = 200;
            f_emp.FontColor = Color.Black;
            f_emp.FontFace = "Tahoma";
            f_emp.FontSize = 9F;
            f_emp.FormatStr = "";
            f_emp.Location = new Point(208, 49);
            f_emp.Name = "f_emp";
            f_emp.Size = new Size(200, 21);
            f_emp.TabIndex = 5;
            f_emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_emp.Title = "Employee";
            f_emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_emp.TitleWidth = 93;
            // 
            // f_dept
            // 
            f_dept.Appearance.Font = new Font("Tahoma", 9F);
            f_dept.Appearance.Options.UseFont = true;
            f_dept.ControlHeight = 21;
            f_dept.ControlWidth = 200;
            f_dept.FontColor = Color.Black;
            f_dept.FontFace = "Tahoma";
            f_dept.FontSize = 9F;
            f_dept.FormatStr = "";
            f_dept.Location = new Point(208, 26);
            f_dept.Name = "f_dept";
            f_dept.Size = new Size(200, 21);
            f_dept.TabIndex = 6;
            f_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_dept.Title = "Dept";
            f_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_dept.TitleWidth = 93;
            // 
            // s_to_dt
            // 
            s_to_dt.ControlHeight = 21;
            s_to_dt.ControlWidth = 200;
            s_to_dt.Font = new Font("Tahoma", 9F);
            s_to_dt.FontColor = Color.Black;
            s_to_dt.FontFace = "Tahoma";
            s_to_dt.FontSize = 9F;
            s_to_dt.FormatStr = "";
            s_to_dt.Location = new Point(2, 49);
            s_to_dt.Name = "s_to_dt";
            s_to_dt.Size = new Size(200, 21);
            s_to_dt.TabIndex = 3;
            s_to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_to_dt.Title = "~";
            s_to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_to_dt.TitleWidth = 80;
            // 
            // s_fr_dt
            // 
            s_fr_dt.ControlHeight = 21;
            s_fr_dt.ControlWidth = 200;
            s_fr_dt.Font = new Font("Tahoma", 9F);
            s_fr_dt.FontColor = Color.Black;
            s_fr_dt.FontFace = "Tahoma";
            s_fr_dt.FontSize = 9F;
            s_fr_dt.FormatStr = "";
            s_fr_dt.Location = new Point(2, 26);
            s_fr_dt.Name = "s_fr_dt";
            s_fr_dt.Size = new Size(200, 21);
            s_fr_dt.TabIndex = 4;
            s_fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_fr_dt.Title = "Resign Date";
            s_fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_fr_dt.TitleWidth = 80;
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
            ucSplit2.Size = new Size(1321, 621);
            ucSplit2.SplitterDistance = 288;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(288, 621);
            g10.TabIndex = 0;
            // 
            // ucSplit3
            // 
            ucSplit3.Dock = DockStyle.Fill;
            ucSplit3.FixedPanel = FixedPanel.Panel1;
            ucSplit3.Location = new Point(0, 0);
            ucSplit3.Name = "ucSplit3";
            ucSplit3.Orientation = Orientation.Horizontal;
            // 
            // ucSplit3.Panel1
            // 
            ucSplit3.Panel1.Controls.Add(ucPanel2);
            // 
            // ucSplit3.Panel2
            // 
            ucSplit3.Panel2.Controls.Add(ucSplit4);
            ucSplit3.Size = new Size(1029, 621);
            ucSplit3.SplitterDistance = 124;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(ucButton2);
            ucPanel2.Controls.Add(ucButton1);
            ucPanel2.Controls.Add(status);
            ucPanel2.Controls.Add(termination_date);
            ucPanel2.Controls.Add(memo);
            ucPanel2.Controls.Add(doc_no);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1029, 124);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Termination Info.";
            // 
            // ucButton2
            // 
            ucButton2.Appearance.Font = new Font("Tahoma", 9F);
            ucButton2.Appearance.Options.UseFont = true;
            ucButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton2.ControlHeight = 35;
            ucButton2.ControlWidth = 177;
            ucButton2.FontBold = FontStyle.Regular;
            ucButton2.FontFace = "Tahoma";
            ucButton2.FontSize = 9F;
            ucButton2.Location = new Point(522, 67);
            ucButton2.Name = "ucButton2";
            ucButton2.Size = new Size(177, 35);
            ucButton2.TabIndex = 10;
            ucButton2.Title = "Calulate Severance (Batch)";
            ucButton2.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucButton1
            // 
            ucButton1.Appearance.Font = new Font("Tahoma", 9F);
            ucButton1.Appearance.Options.UseFont = true;
            ucButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton1.ControlHeight = 35;
            ucButton1.ControlWidth = 177;
            ucButton1.FontBold = FontStyle.Regular;
            ucButton1.FontFace = "Tahoma";
            ucButton1.FontSize = 9F;
            ucButton1.Location = new Point(522, 26);
            ucButton1.Name = "ucButton1";
            ucButton1.Size = new Size(177, 35);
            ucButton1.TabIndex = 10;
            ucButton1.Title = "Approved";
            ucButton1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // status
            // 
            status.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status.Appearance.Options.UseFont = true;
            status.ControlHeight = 21;
            status.ControlWidth = 249;
            status.FldTy = null;
            status.FontColor = Color.Black;
            status.FontFace = "Tahoma";
            status.FontSize = 9F;
            status.Location = new Point(260, 26);
            status.Name = "status";
            status.Size = new Size(249, 21);
            status.TabIndex = 8;
            status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.Title = "Status";
            status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.TitleWidth = 100;
            // 
            // termination_date
            // 
            termination_date.ControlHeight = 21;
            termination_date.ControlWidth = 248;
            termination_date.Font = new Font("Tahoma", 9F);
            termination_date.FontColor = Color.Black;
            termination_date.FontFace = "Tahoma";
            termination_date.FontSize = 9F;
            termination_date.FormatStr = "";
            termination_date.Location = new Point(5, 53);
            termination_date.Name = "termination_date";
            termination_date.Size = new Size(248, 21);
            termination_date.TabIndex = 5;
            termination_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            termination_date.Title = "Termination Date";
            termination_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            termination_date.TitleWidth = 100;
            // 
            // memo
            // 
            memo.Appearance.Font = new Font("Tahoma", 9F);
            memo.Appearance.Options.UseFont = true;
            memo.ControlHeight = 21;
            memo.ControlWidth = 504;
            memo.FontColor = Color.Black;
            memo.FontFace = "Tahoma";
            memo.FontSize = 9F;
            memo.FormatStr = "";
            memo.Location = new Point(5, 80);
            memo.Name = "memo";
            memo.Size = new Size(504, 21);
            memo.TabIndex = 1;
            memo.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            memo.Title = "Memo";
            memo.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            memo.TitleWidth = 100;
            // 
            // doc_no
            // 
            doc_no.Appearance.Font = new Font("Tahoma", 9F);
            doc_no.Appearance.Options.UseFont = true;
            doc_no.ControlHeight = 21;
            doc_no.ControlWidth = 249;
            doc_no.FontColor = Color.Black;
            doc_no.FontFace = "Tahoma";
            doc_no.FontSize = 9F;
            doc_no.FormatStr = "";
            doc_no.Location = new Point(5, 26);
            doc_no.Name = "doc_no";
            doc_no.Size = new Size(249, 21);
            doc_no.TabIndex = 1;
            doc_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            doc_no.Title = "DOC No";
            doc_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            doc_no.TitleWidth = 100;
            // 
            // ucSplit4
            // 
            ucSplit4.Dock = DockStyle.Fill;
            ucSplit4.Location = new Point(0, 0);
            ucSplit4.Name = "ucSplit4";
            // 
            // ucSplit4.Panel1
            // 
            ucSplit4.Panel1.Controls.Add(g20);
            // 
            // ucSplit4.Panel2
            // 
            ucSplit4.Panel2.Controls.Add(g30);
            ucSplit4.Size = new Size(1029, 493);
            ucSplit4.SplitterDistance = 622;
            ucSplit4.TabIndex = 0;
            ucSplit4.TitleWidth = 121;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(622, 493);
            g20.TabIndex = 0;
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(403, 493);
            g30.TabIndex = 0;
            // 
            // HR755
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR755";
            Size = new Size(1321, 707);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ucSplit2.Panel1.ResumeLayout(false);
            ucSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit2).EndInit();
            ucSplit2.ResumeLayout(false);
            ucSplit3.Panel1.ResumeLayout(false);
            ucSplit3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit3).EndInit();
            ucSplit3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ucSplit4.Panel1.ResumeLayout(false);
            ucSplit4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit4).EndInit();
            ucSplit4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCSplit ucSplit4;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCGridSet g30;
        private Ctrls.UCCodeBox f_status;
        private Ctrls.UCTextBox f_emp;
        private Ctrls.UCTextBox f_dept;
        private Ctrls.UCDateBox s_to_dt;
        private Ctrls.UCDateBox s_fr_dt;
        private Ctrls.UCTextBox doc_no;
        private Ctrls.UCCodeBox status;
        private Ctrls.UCDateBox termination_date;
        private Ctrls.UCTextBox memo;
        private Ctrls.UCButton ucButton1;
        private Ctrls.UCButton ucButton2;
    }
}
