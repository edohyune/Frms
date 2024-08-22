namespace EpicV004.Frms
{
    partial class HR705
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
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel1 = new Ctrls.UCPanel();
            s_year = new Ctrls.UCDateBox();
            ucPanel2 = new Ctrls.UCPanel();
            g10 = new Ctrls.UCGridSet();
            s_dept = new Ctrls.UCTextBox();
            s_emp = new Ctrls.UCTextBox();
            s_position = new Ctrls.UCCodeBox();
            s_project = new Ctrls.UCTextBox();
            s_section = new Ctrls.UCChkCodeBox();
            s_jobsite = new Ctrls.UCChkCodeBox();
            s_status = new Ctrls.UCChkCodeBox();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new Ctrls.UCGridSet();
            g30 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit2).BeginInit();
            ucSplit2.Panel1.SuspendLayout();
            ucSplit2.Panel2.SuspendLayout();
            ucSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit3).BeginInit();
            ucSplit3.Panel1.SuspendLayout();
            ucSplit3.Panel2.SuspendLayout();
            ucSplit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucTab1).BeginInit();
            ucTab1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            xtraTabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // ucSplit1
            // 
            ucSplit1.Dock = DockStyle.Fill;
            ucSplit1.Location = new Point(0, 0);
            ucSplit1.Name = "ucSplit1";
            // 
            // ucSplit1.Panel1
            // 
            ucSplit1.Panel1.Controls.Add(ucSplit2);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucSplit3);
            ucSplit1.Size = new Size(1232, 671);
            ucSplit1.SplitterDistance = 297;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
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
            ucSplit2.Panel2.Controls.Add(g10);
            ucSplit2.Size = new Size(297, 671);
            ucSplit2.SplitterDistance = 66;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
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
            ucSplit3.Size = new Size(931, 671);
            ucSplit3.SplitterDistance = 87;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_year);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(297, 66);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Payroll Summary";
            // 
            // s_year
            // 
            s_year.ControlHeight = 21;
            s_year.ControlWidth = 137;
            s_year.FontColor = Color.Black;
            s_year.FontFace = "Tahoma";
            s_year.FontSize = 9F;
            s_year.FormatStr = "";
            s_year.Location = new Point(5, 31);
            s_year.Name = "s_year";
            s_year.Size = new Size(137, 21);
            s_year.TabIndex = 0;
            s_year.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.Title = "Year";
            s_year.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.TitleWidth = 50;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(s_status);
            ucPanel2.Controls.Add(s_jobsite);
            ucPanel2.Controls.Add(s_section);
            ucPanel2.Controls.Add(s_project);
            ucPanel2.Controls.Add(s_position);
            ucPanel2.Controls.Add(s_emp);
            ucPanel2.Controls.Add(s_dept);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(931, 87);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Detail Query Conditon";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(297, 601);
            g10.TabIndex = 0;
            // 
            // s_dept
            // 
            s_dept.ControlHeight = 21;
            s_dept.ControlWidth = 200;
            s_dept.FontColor = Color.Black;
            s_dept.FontFace = "Tahoma";
            s_dept.FontSize = 9F;
            s_dept.FormatStr = "";
            s_dept.Location = new Point(5, 26);
            s_dept.Name = "s_dept";
            s_dept.Size = new Size(200, 21);
            s_dept.TabIndex = 0;
            s_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.Title = "Dept";
            s_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.TitleWidth = 100;
            // 
            // s_emp
            // 
            s_emp.ControlHeight = 21;
            s_emp.ControlWidth = 200;
            s_emp.FontColor = Color.Black;
            s_emp.FontFace = "Tahoma";
            s_emp.FontSize = 9F;
            s_emp.FormatStr = "";
            s_emp.Location = new Point(5, 53);
            s_emp.Name = "s_emp";
            s_emp.Size = new Size(200, 21);
            s_emp.TabIndex = 1;
            s_emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp.Title = "Employee";
            s_emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp.TitleWidth = 100;
            // 
            // s_position
            // 
            s_position.ControlHeight = 21;
            s_position.ControlWidth = 200;
            s_position.FldTy = null;
            s_position.FontColor = Color.Black;
            s_position.FontFace = "Tahoma";
            s_position.FontSize = 9F;
            s_position.Location = new Point(211, 26);
            s_position.Name = "s_position";
            s_position.Size = new Size(200, 21);
            s_position.TabIndex = 2;
            s_position.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_position.Title = "Position";
            s_position.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_position.TitleWidth = 100;
            // 
            // s_project
            // 
            s_project.ControlHeight = 21;
            s_project.ControlWidth = 200;
            s_project.FontColor = Color.Black;
            s_project.FontFace = "Tahoma";
            s_project.FontSize = 9F;
            s_project.FormatStr = "";
            s_project.Location = new Point(211, 53);
            s_project.Name = "s_project";
            s_project.Size = new Size(200, 21);
            s_project.TabIndex = 3;
            s_project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.Title = "Project";
            s_project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.TitleWidth = 100;
            // 
            // s_section
            // 
            s_section.ControlHeight = 21;
            s_section.ControlWidth = 200;
            s_section.FontFace = "Tahoma";
            s_section.FontSize = 9F;
            s_section.Location = new Point(417, 26);
            s_section.Name = "s_section";
            s_section.Size = new Size(200, 21);
            s_section.TabIndex = 4;
            s_section.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_section.Title = "Section";
            s_section.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_section.TitleWidth = 100;
            // 
            // s_jobsite
            // 
            s_jobsite.ControlHeight = 21;
            s_jobsite.ControlWidth = 200;
            s_jobsite.FontFace = "Tahoma";
            s_jobsite.FontSize = 9F;
            s_jobsite.Location = new Point(417, 53);
            s_jobsite.Name = "s_jobsite";
            s_jobsite.Size = new Size(200, 21);
            s_jobsite.TabIndex = 5;
            s_jobsite.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_jobsite.Title = "Job Site";
            s_jobsite.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_jobsite.TitleWidth = 100;
            // 
            // s_status
            // 
            s_status.ControlHeight = 21;
            s_status.ControlWidth = 200;
            s_status.FontFace = "Tahoma";
            s_status.FontSize = 9F;
            s_status.Location = new Point(623, 26);
            s_status.Name = "s_status";
            s_status.Size = new Size(200, 21);
            s_status.TabIndex = 6;
            s_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_status.Title = "Status";
            s_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_status.TitleWidth = 100;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(931, 580);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g20);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(929, 555);
            xtraTabPage1.Text = "Payment List (Employee)";
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g30);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(929, 501);
            xtraTabPage2.Text = "Payment Summary (Dept)";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(929, 555);
            g20.TabIndex = 0;
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(929, 501);
            g30.TabIndex = 0;
            // 
            // HR705
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR705";
            Size = new Size(1232, 671);
            Load += HR705_Load;
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ucSplit2.Panel1.ResumeLayout(false);
            ucSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit2).EndInit();
            ucSplit2.ResumeLayout(false);
            ucSplit3.Panel1.ResumeLayout(false);
            ucSplit3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit3).EndInit();
            ucSplit3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucTab1).EndInit();
            ucTab1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCDateBox s_year;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCTextBox s_emp;
        private Ctrls.UCTextBox s_dept;
        private Ctrls.UCChkCodeBox s_status;
        private Ctrls.UCChkCodeBox s_jobsite;
        private Ctrls.UCChkCodeBox s_section;
        private Ctrls.UCTextBox s_project;
        private Ctrls.UCCodeBox s_position;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Ctrls.UCGridSet g20;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCGridSet g30;
    }
}
