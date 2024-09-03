namespace EpicV004.Frms
{
    partial class HR585
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
            ucCodeBox1 = new Ctrls.UCCodeBox();
            ucChkCodeBox3 = new Ctrls.UCChkCodeBox();
            s_emp_status = new Ctrls.UCChkCodeBox();
            job_site = new Ctrls.UCChkCodeBox();
            emp = new Ctrls.UCTextBox();
            ucTextBox2 = new Ctrls.UCTextBox();
            project = new Ctrls.UCTextBox();
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
            ucSplit1.Size = new Size(1193, 616);
            ucSplit1.SplitterDistance = 78;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(ucCodeBox1);
            ucPanel1.Controls.Add(ucChkCodeBox3);
            ucPanel1.Controls.Add(s_emp_status);
            ucPanel1.Controls.Add(job_site);
            ucPanel1.Controls.Add(emp);
            ucPanel1.Controls.Add(ucTextBox2);
            ucPanel1.Controls.Add(project);
            ucPanel1.Controls.Add(dept);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1193, 78);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Staff Salary List";
            // 
            // ucCodeBox1
            // 
            ucCodeBox1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucCodeBox1.Appearance.Options.UseFont = true;
            ucCodeBox1.ControlHeight = 23;
            ucCodeBox1.ControlWidth = 246;
            ucCodeBox1.FldTy = null;
            ucCodeBox1.FontColor = Color.Black;
            ucCodeBox1.FontFace = "Tahoma";
            ucCodeBox1.FontSize = 9F;
            ucCodeBox1.Location = new Point(402, 26);
            ucCodeBox1.Margin = new Padding(4, 3, 4, 3);
            ucCodeBox1.Name = "ucCodeBox1";
            ucCodeBox1.Size = new Size(246, 23);
            ucCodeBox1.TabIndex = 2;
            ucCodeBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox1.Title = "Position";
            ucCodeBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox1.TitleWidth = 93;
            // 
            // ucChkCodeBox3
            // 
            ucChkCodeBox3.Appearance.Font = new Font("Tahoma", 9F);
            ucChkCodeBox3.Appearance.Options.UseFont = true;
            ucChkCodeBox3.ControlHeight = 21;
            ucChkCodeBox3.ControlWidth = 248;
            ucChkCodeBox3.FontFace = "Tahoma";
            ucChkCodeBox3.FontSize = 9F;
            ucChkCodeBox3.Location = new Point(655, 49);
            ucChkCodeBox3.Name = "ucChkCodeBox3";
            ucChkCodeBox3.Size = new Size(248, 21);
            ucChkCodeBox3.TabIndex = 1;
            ucChkCodeBox3.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucChkCodeBox3.Title = "Job Site";
            ucChkCodeBox3.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            ucChkCodeBox3.TitleWidth = 117;
            // 
            // s_emp_status
            // 
            s_emp_status.Appearance.Font = new Font("Tahoma", 9F);
            s_emp_status.Appearance.Options.UseFont = true;
            s_emp_status.ControlHeight = 21;
            s_emp_status.ControlWidth = 248;
            s_emp_status.FontFace = "Tahoma";
            s_emp_status.FontSize = 9F;
            s_emp_status.Location = new Point(909, 24);
            s_emp_status.Name = "s_emp_status";
            s_emp_status.Size = new Size(248, 21);
            s_emp_status.TabIndex = 1;
            s_emp_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_status.Title = "Employee Status";
            s_emp_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_emp_status.TitleWidth = 117;
            // 
            // job_site
            // 
            job_site.Appearance.Font = new Font("Tahoma", 9F);
            job_site.Appearance.Options.UseFont = true;
            job_site.ControlHeight = 21;
            job_site.ControlWidth = 248;
            job_site.FontFace = "Tahoma";
            job_site.FontSize = 9F;
            job_site.Location = new Point(655, 24);
            job_site.Name = "job_site";
            job_site.Size = new Size(248, 21);
            job_site.TabIndex = 1;
            job_site.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            job_site.Title = "Section";
            job_site.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            job_site.TitleWidth = 117;
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
            // ucTextBox2
            // 
            ucTextBox2.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox2.Appearance.Options.UseFont = true;
            ucTextBox2.ControlHeight = 23;
            ucTextBox2.ControlWidth = 192;
            ucTextBox2.FontColor = Color.Black;
            ucTextBox2.FontFace = "Tahoma";
            ucTextBox2.FontSize = 9F;
            ucTextBox2.FormatStr = "";
            ucTextBox2.Location = new Point(203, 26);
            ucTextBox2.Name = "ucTextBox2";
            ucTextBox2.Size = new Size(192, 23);
            ucTextBox2.TabIndex = 0;
            ucTextBox2.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox2.Title = "UCTextBox";
            ucTextBox2.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox2.TitleWidth = 1;
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
            // dept
            // 
            dept.Appearance.Font = new Font("Tahoma", 9F);
            dept.Appearance.Options.UseFont = true;
            dept.ControlHeight = 23;
            dept.ControlWidth = 192;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(5, 26);
            dept.Name = "dept";
            dept.Size = new Size(192, 23);
            dept.TabIndex = 0;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Dept";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 117;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1193, 534);
            g10.TabIndex = 0;
            // 
            // HR585
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR585";
            Size = new Size(1193, 616);
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
        private Ctrls.UCChkCodeBox ucChkCodeBox3;
        private Ctrls.UCChkCodeBox s_emp_status;
        private Ctrls.UCChkCodeBox job_site;
        private Ctrls.UCTextBox emp;
        private Ctrls.UCTextBox ucTextBox2;
        private Ctrls.UCTextBox project;
        private Ctrls.UCCodeBox ucCodeBox1;
    }
}
