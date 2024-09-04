namespace EpicV004.Frms
{
    partial class HR410
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
            to_date = new Ctrls.UCDateBox();
            fr_date = new Ctrls.UCDateBox();
            evt_status = new Ctrls.UCChkCodeBox();
            rq_status = new Ctrls.UCChkCodeBox();
            s_emp_status = new Ctrls.UCChkCodeBox();
            job_site = new Ctrls.UCChkCodeBox();
            dept_name = new Ctrls.UCTextBox();
            course = new Ctrls.UCTextBox();
            name = new Ctrls.UCTextBox();
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
            ucSplit1.Size = new Size(1283, 616);
            ucSplit1.SplitterDistance = 78;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(to_date);
            ucPanel1.Controls.Add(fr_date);
            ucPanel1.Controls.Add(evt_status);
            ucPanel1.Controls.Add(rq_status);
            ucPanel1.Controls.Add(s_emp_status);
            ucPanel1.Controls.Add(job_site);
            ucPanel1.Controls.Add(dept_name);
            ucPanel1.Controls.Add(course);
            ucPanel1.Controls.Add(name);
            ucPanel1.Controls.Add(dept);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1283, 78);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Training List";
            // 
            // to_date
            // 
            to_date.ControlHeight = 21;
            to_date.ControlWidth = 192;
            to_date.FontColor = Color.Black;
            to_date.FontFace = "Tahoma";
            to_date.FontSize = 9F;
            to_date.FormatStr = "";
            to_date.Location = new Point(5, 55);
            to_date.Name = "to_date";
            to_date.Size = new Size(192, 21);
            to_date.TabIndex = 3;
            to_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_date.Title = "~";
            to_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_date.TitleWidth = 90;
            // 
            // fr_date
            // 
            fr_date.ControlHeight = 21;
            fr_date.ControlWidth = 192;
            fr_date.FontColor = Color.Black;
            fr_date.FontFace = "Tahoma";
            fr_date.FontSize = 9F;
            fr_date.FormatStr = "";
            fr_date.Location = new Point(5, 28);
            fr_date.Name = "fr_date";
            fr_date.Size = new Size(192, 21);
            fr_date.TabIndex = 3;
            fr_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_date.Title = "Training Date";
            fr_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_date.TitleWidth = 90;
            // 
            // evt_status
            // 
            evt_status.Appearance.Font = new Font("Tahoma", 9F);
            evt_status.Appearance.Options.UseFont = true;
            evt_status.ControlHeight = 21;
            evt_status.ControlWidth = 231;
            evt_status.FontFace = "Tahoma";
            evt_status.FontSize = 9F;
            evt_status.Location = new Point(793, 55);
            evt_status.Name = "evt_status";
            evt_status.Size = new Size(231, 21);
            evt_status.TabIndex = 1;
            evt_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            evt_status.Title = "Evaluation";
            evt_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            evt_status.TitleWidth = 90;
            // 
            // rq_status
            // 
            rq_status.Appearance.Font = new Font("Tahoma", 9F);
            rq_status.Appearance.Options.UseFont = true;
            rq_status.ControlHeight = 21;
            rq_status.ControlWidth = 231;
            rq_status.FontFace = "Tahoma";
            rq_status.FontSize = 9F;
            rq_status.Location = new Point(793, 28);
            rq_status.Name = "rq_status";
            rq_status.Size = new Size(231, 21);
            rq_status.TabIndex = 1;
            rq_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            rq_status.Title = "Request";
            rq_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            rq_status.TitleWidth = 90;
            // 
            // s_emp_status
            // 
            s_emp_status.Appearance.Font = new Font("Tahoma", 9F);
            s_emp_status.Appearance.Options.UseFont = true;
            s_emp_status.ControlHeight = 21;
            s_emp_status.ControlWidth = 248;
            s_emp_status.FontFace = "Tahoma";
            s_emp_status.FontSize = 9F;
            s_emp_status.Location = new Point(1030, 26);
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
            job_site.Location = new Point(539, 55);
            job_site.Name = "job_site";
            job_site.Size = new Size(248, 21);
            job_site.TabIndex = 1;
            job_site.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            job_site.Title = "Training";
            job_site.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            job_site.TitleWidth = 90;
            // 
            // dept_name
            // 
            dept_name.Appearance.Font = new Font("Tahoma", 9F);
            dept_name.Appearance.Options.UseFont = true;
            dept_name.ControlHeight = 21;
            dept_name.ControlWidth = 163;
            dept_name.FontColor = Color.Black;
            dept_name.FontFace = "Tahoma";
            dept_name.FontSize = 9F;
            dept_name.FormatStr = "";
            dept_name.Location = new Point(370, 28);
            dept_name.Name = "dept_name";
            dept_name.Size = new Size(163, 21);
            dept_name.TabIndex = 0;
            dept_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.Title = "";
            dept_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.TitleWidth = 1;
            // 
            // course
            // 
            course.Appearance.Font = new Font("Tahoma", 9F);
            course.Appearance.Options.UseFont = true;
            course.ControlHeight = 21;
            course.ControlWidth = 248;
            course.FontColor = Color.Black;
            course.FontFace = "Tahoma";
            course.FontSize = 9F;
            course.FormatStr = "";
            course.Location = new Point(539, 28);
            course.Name = "course";
            course.Size = new Size(248, 21);
            course.TabIndex = 0;
            course.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            course.Title = "Course";
            course.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            course.TitleWidth = 90;
            // 
            // name
            // 
            name.Appearance.Font = new Font("Tahoma", 9F);
            name.Appearance.Options.UseFont = true;
            name.ControlHeight = 21;
            name.ControlWidth = 330;
            name.FontColor = Color.Black;
            name.FontFace = "Tahoma";
            name.FontSize = 9F;
            name.FormatStr = "";
            name.Location = new Point(203, 55);
            name.Name = "name";
            name.Size = new Size(330, 21);
            name.TabIndex = 0;
            name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            name.Title = "Name";
            name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            name.TitleWidth = 60;
            // 
            // dept
            // 
            dept.Appearance.Font = new Font("Tahoma", 9F);
            dept.Appearance.Options.UseFont = true;
            dept.ControlHeight = 21;
            dept.ControlWidth = 161;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(203, 28);
            dept.Name = "dept";
            dept.Size = new Size(161, 21);
            dept.TabIndex = 0;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Dept";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 60;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1283, 534);
            g10.TabIndex = 0;
            // 
            // HR410
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR410";
            Size = new Size(1283, 616);
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
        private Ctrls.UCChkCodeBox rq_status;
        private Ctrls.UCChkCodeBox s_emp_status;
        private Ctrls.UCChkCodeBox job_site;
        private Ctrls.UCTextBox dept_name;
        private Ctrls.UCTextBox course;
        private Ctrls.UCDateBox to_date;
        private Ctrls.UCDateBox fr_date;
        private Ctrls.UCTextBox name;
        private Ctrls.UCChkCodeBox evt_status;
    }
}
