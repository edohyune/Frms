namespace EpicV004.Frms
{
    partial class HR840
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
            position = new Ctrls.UCCodeBox();
            chk_last = new CheckBox();
            s_job_site = new Ctrls.UCChkCodeBox();
            s_tatus = new Ctrls.UCChkCodeBox();
            s_emp_status = new Ctrls.UCChkCodeBox();
            s_section = new Ctrls.UCChkCodeBox();
            emp = new Ctrls.UCTextBox();
            dept_name = new Ctrls.UCTextBox();
            project = new Ctrls.UCTextBox();
            dept = new Ctrls.UCTextBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            g20 = new Ctrls.UCGridSet();
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
            ucSplit1.Size = new Size(1311, 690);
            ucSplit1.SplitterDistance = 78;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(position);
            ucPanel1.Controls.Add(chk_last);
            ucPanel1.Controls.Add(s_job_site);
            ucPanel1.Controls.Add(s_tatus);
            ucPanel1.Controls.Add(s_emp_status);
            ucPanel1.Controls.Add(s_section);
            ucPanel1.Controls.Add(emp);
            ucPanel1.Controls.Add(dept_name);
            ucPanel1.Controls.Add(project);
            ucPanel1.Controls.Add(dept);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1311, 78);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // position
            // 
            position.ControlHeight = 23;
            position.ControlWidth = 248;
            position.FldTy = null;
            position.FontColor = Color.Black;
            position.FontFace = "Tahoma";
            position.FontSize = 9F;
            position.Location = new Point(401, 26);
            position.Name = "position";
            position.Size = new Size(248, 23);
            position.TabIndex = 3;
            position.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            position.Title = "Position";
            position.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            position.TitleWidth = 93;
            // 
            // chk_last
            // 
            chk_last.AutoSize = true;
            chk_last.CheckAlign = ContentAlignment.MiddleRight;
            chk_last.Location = new Point(1163, 26);
            chk_last.Name = "chk_last";
            chk_last.Size = new Size(100, 17);
            chk_last.TabIndex = 2;
            chk_last.Text = "Show Last Shift";
            chk_last.UseVisualStyleBackColor = true;
            // 
            // s_job_site
            // 
            s_job_site.Appearance.Font = new Font("Tahoma", 9F);
            s_job_site.Appearance.Options.UseFont = true;
            s_job_site.ControlHeight = 21;
            s_job_site.ControlWidth = 248;
            s_job_site.FontFace = "Tahoma";
            s_job_site.FontSize = 9F;
            s_job_site.Location = new Point(655, 51);
            s_job_site.Name = "s_job_site";
            s_job_site.Size = new Size(248, 21);
            s_job_site.TabIndex = 1;
            s_job_site.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_job_site.Title = "Job Site";
            s_job_site.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_job_site.TitleWidth = 117;
            // 
            // s_tatus
            // 
            s_tatus.Appearance.Font = new Font("Tahoma", 9F);
            s_tatus.Appearance.Options.UseFont = true;
            s_tatus.ControlHeight = 21;
            s_tatus.ControlWidth = 248;
            s_tatus.FontFace = "Tahoma";
            s_tatus.FontSize = 9F;
            s_tatus.Location = new Point(909, 26);
            s_tatus.Name = "s_tatus";
            s_tatus.Size = new Size(248, 21);
            s_tatus.TabIndex = 1;
            s_tatus.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_tatus.Title = "Status";
            s_tatus.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_tatus.TitleWidth = 117;
            // 
            // s_emp_status
            // 
            s_emp_status.Appearance.Font = new Font("Tahoma", 9F);
            s_emp_status.Appearance.Options.UseFont = true;
            s_emp_status.ControlHeight = 21;
            s_emp_status.ControlWidth = 248;
            s_emp_status.FontFace = "Tahoma";
            s_emp_status.FontSize = 9F;
            s_emp_status.Location = new Point(909, 49);
            s_emp_status.Name = "s_emp_status";
            s_emp_status.Size = new Size(248, 21);
            s_emp_status.TabIndex = 1;
            s_emp_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_status.Title = "Employee Status";
            s_emp_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_emp_status.TitleWidth = 117;
            // 
            // s_section
            // 
            s_section.Appearance.Font = new Font("Tahoma", 9F);
            s_section.Appearance.Options.UseFont = true;
            s_section.ControlHeight = 21;
            s_section.ControlWidth = 248;
            s_section.FontFace = "Tahoma";
            s_section.FontSize = 9F;
            s_section.Location = new Point(655, 26);
            s_section.Name = "s_section";
            s_section.Size = new Size(248, 21);
            s_section.TabIndex = 1;
            s_section.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_section.Title = "Section";
            s_section.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_section.TitleWidth = 117;
            // 
            // emp
            // 
            emp.Appearance.Font = new Font("Tahoma", 9F);
            emp.Appearance.Options.UseFont = true;
            emp.ControlHeight = 22;
            emp.ControlWidth = 390;
            emp.FontColor = Color.Black;
            emp.FontFace = "Tahoma";
            emp.FontSize = 9F;
            emp.FormatStr = "";
            emp.Location = new Point(5, 51);
            emp.Name = "emp";
            emp.Size = new Size(390, 22);
            emp.TabIndex = 0;
            emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.Title = "Employee";
            emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.TitleWidth = 117;
            // 
            // dept_name
            // 
            dept_name.Appearance.Font = new Font("Tahoma", 9F);
            dept_name.Appearance.Options.UseFont = true;
            dept_name.ControlHeight = 21;
            dept_name.ControlWidth = 192;
            dept_name.FontColor = Color.Black;
            dept_name.FontFace = "Tahoma";
            dept_name.FontSize = 9F;
            dept_name.FormatStr = "";
            dept_name.Location = new Point(203, 26);
            dept_name.Name = "dept_name";
            dept_name.Size = new Size(192, 21);
            dept_name.TabIndex = 0;
            dept_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.Title = "UCTextBox";
            dept_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.TitleWidth = 1;
            // 
            // project
            // 
            project.Appearance.Font = new Font("Tahoma", 9F);
            project.Appearance.Options.UseFont = true;
            project.ControlHeight = 23;
            project.ControlWidth = 248;
            project.FontColor = Color.Black;
            project.FontFace = "Tahoma";
            project.FontSize = 9F;
            project.FormatStr = "";
            project.Location = new Point(401, 51);
            project.Name = "project";
            project.Size = new Size(248, 23);
            project.TabIndex = 0;
            project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.Title = "Project";
            project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.TitleWidth = 93;
            // 
            // dept
            // 
            dept.Appearance.Font = new Font("Tahoma", 9F);
            dept.Appearance.Options.UseFont = true;
            dept.ControlHeight = 21;
            dept.ControlWidth = 192;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(5, 26);
            dept.Name = "dept";
            dept.Size = new Size(192, 21);
            dept.TabIndex = 0;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Dept";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 117;
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
            ucSplit2.Panel2.Controls.Add(g20);
            ucSplit2.Size = new Size(1311, 608);
            ucSplit2.SplitterDistance = 1038;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1038, 608);
            g10.TabIndex = 0;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(269, 608);
            g20.TabIndex = 0;
            // 
            // HR840
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR840";
            Size = new Size(1311, 690);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ucPanel1.PerformLayout();
            ucSplit2.Panel1.ResumeLayout(false);
            ucSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit2).EndInit();
            ucSplit2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCTextBox dept;
        private Ctrls.UCChkCodeBox s_job_site;
        private Ctrls.UCChkCodeBox s_emp_status;
        private Ctrls.UCChkCodeBox s_section;
        private Ctrls.UCTextBox emp;
        private Ctrls.UCTextBox dept_name;
        private Ctrls.UCTextBox project;
        private Ctrls.UCChkCodeBox s_tatus;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCCodeBox position;
        private CheckBox chk_last;
    }
}
