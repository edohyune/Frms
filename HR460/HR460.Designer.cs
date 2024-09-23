namespace EpicV004.Frms
{
    partial class HR460
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
            app_to_date = new Ctrls.UCDateBox();
            app_date = new Ctrls.UCDateBox();
            leave_type = new Ctrls.UCChkCodeBox();
            s_emp_status = new Ctrls.UCChkCodeBox();
            emp = new Ctrls.UCTextBox();
            dept_name = new Ctrls.UCTextBox();
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
            ucPanel1.Controls.Add(app_to_date);
            ucPanel1.Controls.Add(app_date);
            ucPanel1.Controls.Add(leave_type);
            ucPanel1.Controls.Add(s_emp_status);
            ucPanel1.Controls.Add(emp);
            ucPanel1.Controls.Add(dept_name);
            ucPanel1.Controls.Add(dept);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1283, 78);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Leave List";
            // 
            // app_to_date
            // 
            app_to_date.ControlHeight = 21;
            app_to_date.ControlWidth = 192;
            app_to_date.FontColor = Color.Black;
            app_to_date.FontFace = "Tahoma";
            app_to_date.FontSize = 9F;
            app_to_date.FormatStr = "";
            app_to_date.Location = new Point(5, 53);
            app_to_date.Name = "app_to_date";
            app_to_date.Size = new Size(192, 21);
            app_to_date.TabIndex = 3;
            app_to_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            app_to_date.Title = "~";
            app_to_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            app_to_date.TitleWidth = 90;
            // 
            // app_date
            // 
            app_date.ControlHeight = 21;
            app_date.ControlWidth = 192;
            app_date.FontColor = Color.Black;
            app_date.FontFace = "Tahoma";
            app_date.FontSize = 9F;
            app_date.FormatStr = "";
            app_date.Location = new Point(5, 28);
            app_date.Name = "app_date";
            app_date.Size = new Size(192, 21);
            app_date.TabIndex = 3;
            app_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            app_date.Title = "Apply Date";
            app_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            app_date.TitleWidth = 90;
            // 
            // leave_type
            // 
            leave_type.Appearance.Font = new Font("Tahoma", 9F);
            leave_type.Appearance.Options.UseFont = true;
            leave_type.ControlHeight = 21;
            leave_type.ControlWidth = 248;
            leave_type.FontFace = "Tahoma";
            leave_type.FontSize = 9F;
            leave_type.Location = new Point(674, 28);
            leave_type.Name = "leave_type";
            leave_type.Size = new Size(248, 21);
            leave_type.TabIndex = 1;
            leave_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            leave_type.Title = "Leave Type";
            leave_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            leave_type.TitleWidth = 117;
            // 
            // s_emp_status
            // 
            s_emp_status.Appearance.Font = new Font("Tahoma", 9F);
            s_emp_status.Appearance.Options.UseFont = true;
            s_emp_status.ControlHeight = 21;
            s_emp_status.ControlWidth = 248;
            s_emp_status.FontFace = "Tahoma";
            s_emp_status.FontSize = 9F;
            s_emp_status.Location = new Point(674, 53);
            s_emp_status.Name = "s_emp_status";
            s_emp_status.Size = new Size(248, 21);
            s_emp_status.TabIndex = 1;
            s_emp_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_status.Title = "Employee Status";
            s_emp_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_emp_status.TitleWidth = 117;
            // 
            // emp
            // 
            emp.Appearance.Font = new Font("Tahoma", 9F);
            emp.Appearance.Options.UseFont = true;
            emp.ControlHeight = 24;
            emp.ControlWidth = 465;
            emp.FontColor = Color.Black;
            emp.FontFace = "Tahoma";
            emp.FontSize = 9F;
            emp.FormatStr = "";
            emp.Location = new Point(203, 53);
            emp.Name = "emp";
            emp.Size = new Size(465, 24);
            emp.TabIndex = 0;
            emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.Title = "Employee";
            emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.TitleWidth = 93;
            // 
            // dept_name
            // 
            dept_name.Appearance.Font = new Font("Tahoma", 9F);
            dept_name.Appearance.Options.UseFont = true;
            dept_name.ControlHeight = 21;
            dept_name.ControlWidth = 211;
            dept_name.FontColor = Color.Black;
            dept_name.FontFace = "Tahoma";
            dept_name.FontSize = 9F;
            dept_name.FormatStr = "";
            dept_name.Location = new Point(457, 28);
            dept_name.Name = "dept_name";
            dept_name.Size = new Size(211, 21);
            dept_name.TabIndex = 0;
            dept_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.Title = "";
            dept_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.TitleWidth = 1;
            // 
            // dept
            // 
            dept.Appearance.Font = new Font("Tahoma", 9F);
            dept.Appearance.Options.UseFont = true;
            dept.ControlHeight = 21;
            dept.ControlWidth = 248;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(203, 28);
            dept.Name = "dept";
            dept.Size = new Size(248, 21);
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
            g10.Size = new Size(1283, 534);
            g10.TabIndex = 0;
            // 
            // HR460
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR460";
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
        private Ctrls.UCChkCodeBox leave_type;
        private Ctrls.UCChkCodeBox s_emp_status;
        private Ctrls.UCChkCodeBox job_site;
        private Ctrls.UCTextBox emp;
        private Ctrls.UCTextBox dept_name;
        private Ctrls.UCDateBox app_to_date;
        private Ctrls.UCDateBox app_date;
    }
}
