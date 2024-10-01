namespace EpicV004.Frms
{
    partial class MM050
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
            project_name = new Ctrls.UCTextBox();
            internal_type = new Ctrls.UCCodeBox();
            status = new Ctrls.UCCodeBox();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            cuFtp = new Ctrls.UCGridSet();
            g20 = new Ctrls.UCGridSet();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ucTab1 = new Ctrls.UCTab();
            ucSplit1 = new Ctrls.UCSplit();
            ucPanel1 = new Ctrls.UCPanel();
            s_status = new Ctrls.UCChkCodeBox();
            s_project = new Ctrls.UCTextBox();
            f_dept = new Ctrls.UCTextBox();
            f_req_no = new Ctrls.UCTextBox();
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            division = new Ctrls.UCCodeBox();
            attachment = new Ctrls.UCCodeBox();
            project = new Ctrls.UCTextBox();
            req_no = new Ctrls.UCTextBox();
            note = new Ctrls.UCNote();
            condition = new Ctrls.UCNote();
            req_date = new Ctrls.UCDateBox();
            xtraTabPage2.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucTab1).BeginInit();
            ucTab1.SuspendLayout();
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
            SuspendLayout();
            // 
            // project_name
            // 
            project_name.ControlHeight = 21;
            project_name.ControlWidth = 502;
            project_name.FontColor = Color.Black;
            project_name.FontFace = "Tahoma";
            project_name.FontSize = 9F;
            project_name.FormatStr = "";
            project_name.Location = new Point(259, 74);
            project_name.Name = "project_name";
            project_name.Size = new Size(502, 21);
            project_name.TabIndex = 18;
            project_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_name.Title = "UCTextBox";
            project_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_name.TitleWidth = 0;
            // 
            // internal_type
            // 
            internal_type.ControlHeight = 21;
            internal_type.ControlWidth = 248;
            internal_type.FldTy = null;
            internal_type.FontColor = Color.Black;
            internal_type.FontFace = "Tahoma";
            internal_type.FontSize = 9F;
            internal_type.Location = new Point(513, 49);
            internal_type.Name = "internal_type";
            internal_type.Size = new Size(248, 21);
            internal_type.TabIndex = 15;
            internal_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            internal_type.Title = "Internal Type";
            internal_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            internal_type.TitleWidth = 100;
            // 
            // status
            // 
            status.ControlHeight = 21;
            status.ControlWidth = 248;
            status.FldTy = null;
            status.FontColor = Color.Black;
            status.FontFace = "Tahoma";
            status.FontSize = 9F;
            status.Location = new Point(513, 26);
            status.Name = "status";
            status.Size = new Size(248, 21);
            status.TabIndex = 15;
            status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.Title = "Status";
            status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.TitleWidth = 100;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(cuFtp);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(857, 335);
            xtraTabPage2.TabPageWidth = 100;
            xtraTabPage2.Text = "Document";
            // 
            // cuFtp
            // 
            cuFtp.Dock = DockStyle.Fill;
            cuFtp.Location = new Point(0, 0);
            cuFtp.Name = "cuFtp";
            cuFtp.Size = new Size(857, 335);
            cuFtp.TabIndex = 0;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(857, 335);
            g20.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g20);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(857, 335);
            xtraTabPage1.TabPageWidth = 100;
            xtraTabPage1.Text = "Invoice";
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(859, 360);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
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
            ucSplit1.Size = new Size(1183, 665);
            ucSplit1.SplitterDistance = 86;
            ucSplit1.TabIndex = 1;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_status);
            ucPanel1.Controls.Add(s_project);
            ucPanel1.Controls.Add(f_dept);
            ucPanel1.Controls.Add(f_req_no);
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1183, 86);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // s_status
            // 
            s_status.ControlHeight = 21;
            s_status.ControlWidth = 200;
            s_status.FontFace = "Tahoma";
            s_status.FontSize = 9F;
            s_status.Location = new Point(428, 56);
            s_status.Name = "s_status";
            s_status.Size = new Size(200, 21);
            s_status.TabIndex = 8;
            s_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_status.Title = "Status";
            s_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_status.TitleWidth = 90;
            // 
            // s_project
            // 
            s_project.ControlHeight = 21;
            s_project.ControlWidth = 200;
            s_project.FontColor = Color.Black;
            s_project.FontFace = "Tahoma";
            s_project.FontSize = 9F;
            s_project.FormatStr = "";
            s_project.Location = new Point(428, 29);
            s_project.Name = "s_project";
            s_project.Size = new Size(200, 21);
            s_project.TabIndex = 5;
            s_project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.Title = "Project";
            s_project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.TitleWidth = 90;
            // 
            // f_dept
            // 
            f_dept.ControlHeight = 21;
            f_dept.ControlWidth = 200;
            f_dept.FontColor = Color.Black;
            f_dept.FontFace = "Tahoma";
            f_dept.FontSize = 9F;
            f_dept.FormatStr = "";
            f_dept.Location = new Point(222, 56);
            f_dept.Name = "f_dept";
            f_dept.Size = new Size(200, 21);
            f_dept.TabIndex = 6;
            f_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_dept.Title = "Dept";
            f_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_dept.TitleWidth = 90;
            // 
            // f_req_no
            // 
            f_req_no.ControlHeight = 21;
            f_req_no.ControlWidth = 200;
            f_req_no.FontColor = Color.Black;
            f_req_no.FontFace = "Tahoma";
            f_req_no.FontSize = 9F;
            f_req_no.FormatStr = "";
            f_req_no.Location = new Point(222, 29);
            f_req_no.Name = "f_req_no";
            f_req_no.Size = new Size(200, 21);
            f_req_no.TabIndex = 7;
            f_req_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_req_no.Title = "Request No";
            f_req_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_req_no.TitleWidth = 90;
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 200;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(5, 56);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(200, 21);
            to_dt.TabIndex = 3;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 90;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 200;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 29);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(200, 21);
            fr_dt.TabIndex = 4;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 90;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.FixedPanel = FixedPanel.Panel1;
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
            ucSplit2.Size = new Size(1183, 575);
            ucSplit2.SplitterDistance = 320;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(320, 575);
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
            ucSplit3.Panel2.Controls.Add(ucTab1);
            ucSplit3.Size = new Size(859, 575);
            ucSplit3.SplitterDistance = 211;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(req_date);
            ucPanel2.Controls.Add(condition);
            ucPanel2.Controls.Add(note);
            ucPanel2.Controls.Add(project_name);
            ucPanel2.Controls.Add(internal_type);
            ucPanel2.Controls.Add(division);
            ucPanel2.Controls.Add(attachment);
            ucPanel2.Controls.Add(status);
            ucPanel2.Controls.Add(project);
            ucPanel2.Controls.Add(req_no);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(859, 211);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Service Invoice Info";
            // 
            // division
            // 
            division.ControlHeight = 21;
            division.ControlWidth = 248;
            division.FldTy = null;
            division.FontColor = Color.Black;
            division.FontFace = "Tahoma";
            division.FontSize = 9F;
            division.Location = new Point(259, 49);
            division.Name = "division";
            division.Size = new Size(248, 21);
            division.TabIndex = 15;
            division.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            division.Title = "Division";
            division.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            division.TitleWidth = 100;
            // 
            // attachment
            // 
            attachment.ControlHeight = 21;
            attachment.ControlWidth = 248;
            attachment.FldTy = null;
            attachment.FontColor = Color.Black;
            attachment.FontFace = "Tahoma";
            attachment.FontSize = 9F;
            attachment.Location = new Point(259, 26);
            attachment.Name = "attachment";
            attachment.Size = new Size(248, 21);
            attachment.TabIndex = 15;
            attachment.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            attachment.Title = "Attachments";
            attachment.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            attachment.TitleWidth = 100;
            // 
            // project
            // 
            project.ControlHeight = 21;
            project.ControlWidth = 248;
            project.FontColor = Color.Black;
            project.FontFace = "Tahoma";
            project.FontSize = 9F;
            project.FormatStr = "";
            project.Location = new Point(5, 74);
            project.Name = "project";
            project.Size = new Size(248, 21);
            project.TabIndex = 14;
            project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.Title = "Project";
            project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.TitleWidth = 100;
            // 
            // req_no
            // 
            req_no.ControlHeight = 21;
            req_no.ControlWidth = 248;
            req_no.FontColor = Color.Black;
            req_no.FontFace = "Tahoma";
            req_no.FontSize = 9F;
            req_no.FormatStr = "";
            req_no.Location = new Point(5, 26);
            req_no.Name = "req_no";
            req_no.Size = new Size(248, 21);
            req_no.TabIndex = 7;
            req_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            req_no.Title = "Request No";
            req_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            req_no.TitleWidth = 100;
            // 
            // note
            // 
            note.ControlHeight = 52;
            note.ControlWidth = 756;
            note.FontColor = Color.Black;
            note.FontFace = "Tahoma";
            note.FontSize = 9F;
            note.Location = new Point(5, 99);
            note.Name = "note";
            note.Size = new Size(756, 52);
            note.TabIndex = 19;
            note.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            note.Title = "Note";
            note.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            note.TitleWidth = 97;
            // 
            // condition
            // 
            condition.ControlHeight = 52;
            condition.ControlWidth = 756;
            condition.FontColor = Color.Black;
            condition.FontFace = "Tahoma";
            condition.FontSize = 9F;
            condition.Location = new Point(5, 154);
            condition.Name = "condition";
            condition.Size = new Size(756, 52);
            condition.TabIndex = 19;
            condition.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            condition.Title = "Condition";
            condition.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            condition.TitleWidth = 97;
            // 
            // req_date
            // 
            req_date.ControlHeight = 21;
            req_date.ControlWidth = 248;
            req_date.FontColor = Color.Black;
            req_date.FontFace = "Tahoma";
            req_date.FontSize = 9F;
            req_date.FormatStr = "";
            req_date.Location = new Point(5, 49);
            req_date.Name = "req_date";
            req_date.Size = new Size(248, 21);
            req_date.TabIndex = 20;
            req_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            req_date.Title = "Request Date";
            req_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            req_date.TitleWidth = 100;
            // 
            // MM050
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "MM050";
            Size = new Size(1183, 665);
            Load += MM050_Load;
            xtraTabPage2.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucTab1).EndInit();
            ucTab1.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion
        private Ctrls.UCTextBox project_name;
        private Ctrls.UCCodeBox internal_type;
        private Ctrls.UCCodeBox status;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCGridSet cuFtp;
        private Ctrls.UCGridSet g20;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Ctrls.UCTab ucTab1;
        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCChkCodeBox s_status;
        private Ctrls.UCTextBox s_project;
        private Ctrls.UCTextBox f_dept;
        private Ctrls.UCTextBox f_req_no;
        private Ctrls.UCDateBox to_dt;
        private Ctrls.UCDateBox fr_dt;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCTextBox project;
        private Ctrls.UCTextBox req_no;
        private Ctrls.UCCodeBox division;
        private Ctrls.UCCodeBox attachment;
        private Ctrls.UCNote condition;
        private Ctrls.UCNote note;
        private Ctrls.UCDateBox req_date;
    }
}
