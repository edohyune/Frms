namespace EpicV004.Frms
{
    partial class HR504
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
            job_site = new Ctrls.UCChkCodeBox();
            s_emp_status = new Ctrls.UCChkCodeBox();
            section = new Ctrls.UCChkCodeBox();
            emp = new Ctrls.UCTextBox();
            shift_name = new Ctrls.UCTextBox();
            project = new Ctrls.UCTextBox();
            shift = new Ctrls.UCTextBox();
            dept = new Ctrls.UCTextBox();
            g10 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
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
            ucSplit1.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(g10);
            ucSplit1.Size = new Size(1317, 724);
            ucSplit1.SplitterDistance = 78;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(position);
            ucPanel1.Controls.Add(job_site);
            ucPanel1.Controls.Add(s_emp_status);
            ucPanel1.Controls.Add(section);
            ucPanel1.Controls.Add(emp);
            ucPanel1.Controls.Add(shift_name);
            ucPanel1.Controls.Add(project);
            ucPanel1.Controls.Add(shift);
            ucPanel1.Controls.Add(dept);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1317, 78);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Shift List";
            // 
            // position
            // 
            position.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            position.Appearance.Options.UseFont = true;
            position.ControlHeight = 23;
            position.ControlWidth = 247;
            position.FldTy = null;
            position.FontColor = Color.Black;
            position.FontFace = "Tahoma";
            position.FontSize = 9F;
            position.Location = new Point(656, 28);
            position.Margin = new Padding(4, 3, 4, 3);
            position.Name = "position";
            position.Size = new Size(247, 23);
            position.TabIndex = 2;
            position.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            position.Title = "Position";
            position.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            position.TitleWidth = 93;
            // 
            // job_site
            // 
            job_site.Appearance.Font = new Font("Tahoma", 9F);
            job_site.Appearance.Options.UseFont = true;
            job_site.ControlHeight = 21;
            job_site.ControlWidth = 248;
            job_site.FontFace = "Tahoma";
            job_site.FontSize = 9F;
            job_site.Location = new Point(909, 22);
            job_site.Name = "job_site";
            job_site.Size = new Size(248, 21);
            job_site.TabIndex = 1;
            job_site.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            job_site.Title = "Job Site";
            job_site.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            job_site.TitleWidth = 117;
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
            // section
            // 
            section.Appearance.Font = new Font("Tahoma", 9F);
            section.Appearance.Options.UseFont = true;
            section.ControlHeight = 21;
            section.ControlWidth = 248;
            section.FontFace = "Tahoma";
            section.FontSize = 9F;
            section.Location = new Point(655, 53);
            section.Name = "section";
            section.Size = new Size(248, 21);
            section.TabIndex = 1;
            section.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            section.Title = "Section";
            section.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            section.TitleWidth = 93;
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
            // shift_name
            // 
            shift_name.Appearance.Font = new Font("Tahoma", 9F);
            shift_name.Appearance.Options.UseFont = true;
            shift_name.ControlHeight = 21;
            shift_name.ControlWidth = 192;
            shift_name.FontColor = Color.Black;
            shift_name.FontFace = "Tahoma";
            shift_name.FontSize = 9F;
            shift_name.FormatStr = "";
            shift_name.Location = new Point(203, 26);
            shift_name.Name = "shift_name";
            shift_name.Size = new Size(192, 21);
            shift_name.TabIndex = 0;
            shift_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            shift_name.Title = "UCTextBox";
            shift_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            shift_name.TitleWidth = 1;
            // 
            // project
            // 
            project.Appearance.Font = new Font("Tahoma", 9F);
            project.Appearance.Options.UseFont = true;
            project.ControlHeight = 22;
            project.ControlWidth = 248;
            project.FontColor = Color.Black;
            project.FontFace = "Tahoma";
            project.FontSize = 9F;
            project.FormatStr = "";
            project.Location = new Point(401, 53);
            project.Name = "project";
            project.Size = new Size(248, 22);
            project.TabIndex = 0;
            project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.Title = "Project";
            project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.TitleWidth = 93;
            // 
            // shift
            // 
            shift.Appearance.Font = new Font("Tahoma", 9F);
            shift.Appearance.Options.UseFont = true;
            shift.ControlHeight = 21;
            shift.ControlWidth = 192;
            shift.FontColor = Color.Black;
            shift.FontFace = "Tahoma";
            shift.FontSize = 9F;
            shift.FormatStr = "";
            shift.Location = new Point(5, 26);
            shift.Name = "shift";
            shift.Size = new Size(192, 21);
            shift.TabIndex = 0;
            shift.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            shift.Title = "Shift";
            shift.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            shift.TitleWidth = 117;
            // 
            // dept
            // 
            dept.Appearance.Font = new Font("Tahoma", 9F);
            dept.Appearance.Options.UseFont = true;
            dept.ControlHeight = 23;
            dept.ControlWidth = 248;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(401, 28);
            dept.Name = "dept";
            dept.Size = new Size(248, 23);
            dept.TabIndex = 0;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Dept";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 93;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1317, 642);
            g10.TabIndex = 0;
            // 
            // HR504
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR504";
            Size = new Size(1317, 724);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCTextBox dept;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCChkCodeBox job_site;
        private Ctrls.UCChkCodeBox s_emp_status;
        private Ctrls.UCChkCodeBox section;
        private Ctrls.UCTextBox emp;
        private Ctrls.UCTextBox shift_name;
        private Ctrls.UCTextBox project;
        private Ctrls.UCTextBox shift;
        private Ctrls.UCCodeBox position;
    }
}
