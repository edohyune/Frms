namespace EpicV004.Frms
{
    partial class HR520
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
            date = new Ctrls.UCDateBox();
            s_salary_category = new Ctrls.UCChkCodeBox();
            s_emp_status = new Ctrls.UCChkCodeBox();
            ot_type = new Ctrls.UCChkCodeBox();
            emp = new Ctrls.UCTextBox();
            dept_name = new Ctrls.UCTextBox();
            dept = new Ctrls.UCTextBox();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g10 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucTab1).BeginInit();
            ucTab1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            xtraTabPage2.SuspendLayout();
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
            ucSplit1.Panel2.Controls.Add(ucTab1);
            ucSplit1.Size = new Size(1321, 711);
            ucSplit1.SplitterDistance = 78;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(to_date);
            ucPanel1.Controls.Add(date);
            ucPanel1.Controls.Add(s_salary_category);
            ucPanel1.Controls.Add(s_emp_status);
            ucPanel1.Controls.Add(ot_type);
            ucPanel1.Controls.Add(emp);
            ucPanel1.Controls.Add(dept_name);
            ucPanel1.Controls.Add(dept);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1321, 78);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "OT List";
            // 
            // to_date
            // 
            to_date.ControlHeight = 21;
            to_date.ControlWidth = 192;
            to_date.FontColor = Color.Black;
            to_date.FontFace = "Tahoma";
            to_date.FontSize = 9F;
            to_date.FormatStr = "";
            to_date.Location = new Point(5, 51);
            to_date.Name = "to_date";
            to_date.Size = new Size(192, 21);
            to_date.TabIndex = 3;
            to_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_date.Title = "~";
            to_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_date.TitleWidth = 90;
            // 
            // date
            // 
            date.ControlHeight = 21;
            date.ControlWidth = 192;
            date.FontColor = Color.Black;
            date.FontFace = "Tahoma";
            date.FontSize = 9F;
            date.FormatStr = "";
            date.Location = new Point(5, 28);
            date.Name = "date";
            date.Size = new Size(192, 21);
            date.TabIndex = 3;
            date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            date.Title = "Date";
            date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            date.TitleWidth = 90;
            // 
            // s_salary_category
            // 
            s_salary_category.Appearance.Font = new Font("Tahoma", 9F);
            s_salary_category.Appearance.Options.UseFont = true;
            s_salary_category.ControlHeight = 21;
            s_salary_category.ControlWidth = 264;
            s_salary_category.FontFace = "Tahoma";
            s_salary_category.FontSize = 9F;
            s_salary_category.Location = new Point(612, 28);
            s_salary_category.Name = "s_salary_category";
            s_salary_category.Size = new Size(264, 21);
            s_salary_category.TabIndex = 1;
            s_salary_category.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_salary_category.Title = "Salary Category";
            s_salary_category.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_salary_category.TitleWidth = 117;
            // 
            // s_emp_status
            // 
            s_emp_status.Appearance.Font = new Font("Tahoma", 9F);
            s_emp_status.Appearance.Options.UseFont = true;
            s_emp_status.ControlHeight = 21;
            s_emp_status.ControlWidth = 233;
            s_emp_status.FontFace = "Tahoma";
            s_emp_status.FontSize = 9F;
            s_emp_status.Location = new Point(882, 28);
            s_emp_status.Name = "s_emp_status";
            s_emp_status.Size = new Size(233, 21);
            s_emp_status.TabIndex = 1;
            s_emp_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_status.Title = "Employee Status";
            s_emp_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_emp_status.TitleWidth = 117;
            // 
            // ot_type
            // 
            ot_type.Appearance.Font = new Font("Tahoma", 9F);
            ot_type.Appearance.Options.UseFont = true;
            ot_type.ControlHeight = 21;
            ot_type.ControlWidth = 264;
            ot_type.FontFace = "Tahoma";
            ot_type.FontSize = 9F;
            ot_type.Location = new Point(611, 53);
            ot_type.Name = "ot_type";
            ot_type.Size = new Size(264, 21);
            ot_type.TabIndex = 1;
            ot_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ot_type.Title = "OT Type";
            ot_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            ot_type.TitleWidth = 117;
            // 
            // emp
            // 
            emp.Appearance.Font = new Font("Tahoma", 9F);
            emp.Appearance.Options.UseFont = true;
            emp.ControlHeight = 22;
            emp.ControlWidth = 402;
            emp.FontColor = Color.Black;
            emp.FontFace = "Tahoma";
            emp.FontSize = 9F;
            emp.FormatStr = "";
            emp.Location = new Point(203, 51);
            emp.Name = "emp";
            emp.Size = new Size(402, 22);
            emp.TabIndex = 0;
            emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.Title = "Employee";
            emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.TitleWidth = 90;
            // 
            // dept_name
            // 
            dept_name.Appearance.Font = new Font("Tahoma", 9F);
            dept_name.Appearance.Options.UseFont = true;
            dept_name.ControlHeight = 21;
            dept_name.ControlWidth = 177;
            dept_name.FontColor = Color.Black;
            dept_name.FontFace = "Tahoma";
            dept_name.FontSize = 9F;
            dept_name.FormatStr = "";
            dept_name.Location = new Point(429, 28);
            dept_name.Name = "dept_name";
            dept_name.Size = new Size(177, 21);
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
            dept.ControlWidth = 220;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(203, 28);
            dept.Name = "dept";
            dept.Size = new Size(220, 21);
            dept.TabIndex = 0;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Dept";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 90;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1321, 629);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g10);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1319, 604);
            xtraTabPage1.TabPageWidth = 50;
            xtraTabPage1.Text = "OT List";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1319, 604);
            g10.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g20);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1319, 604);
            xtraTabPage2.TabPageWidth = 80;
            xtraTabPage2.Text = "OT Actual List";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1319, 604);
            g20.TabIndex = 0;
            // 
            // HR520
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR520";
            Size = new Size(1321, 711);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucTab1).EndInit();
            ucTab1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCTextBox dept;
        private Ctrls.UCChkCodeBox s_salary_category;
        private Ctrls.UCChkCodeBox s_emp_status;
        private Ctrls.UCChkCodeBox ot_type;
        private Ctrls.UCTextBox emp;
        private Ctrls.UCDateBox to_date;
        private Ctrls.UCDateBox date;
        private Ctrls.UCTextBox dept_name;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Ctrls.UCGridSet g10;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCGridSet g20;
    }
}
