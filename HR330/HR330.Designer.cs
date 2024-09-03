namespace EpicV004.Frms
{
    partial class HR330
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
            emp = new Ctrls.UCTextBox();
            s_status = new Ctrls.UCCodeBox();
            s_position = new Ctrls.UCCodeBox();
            s_dept = new Ctrls.UCTextBox();
            s_date = new Ctrls.UCDateBox();
            ucChkCodeBox3 = new Ctrls.UCChkCodeBox();
            job_site = new Ctrls.UCChkCodeBox();
            project = new Ctrls.UCTextBox();
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
            ucSplit1.Size = new Size(1326, 712);
            ucSplit1.SplitterDistance = 78;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(emp);
            ucPanel1.Controls.Add(s_status);
            ucPanel1.Controls.Add(s_position);
            ucPanel1.Controls.Add(s_dept);
            ucPanel1.Controls.Add(s_date);
            ucPanel1.Controls.Add(ucChkCodeBox3);
            ucPanel1.Controls.Add(job_site);
            ucPanel1.Controls.Add(project);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1326, 78);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // emp
            // 
            emp.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp.Appearance.Options.UseFont = true;
            emp.ControlHeight = 23;
            emp.ControlWidth = 233;
            emp.FontColor = Color.Black;
            emp.FontFace = "Tahoma";
            emp.FontSize = 9F;
            emp.FormatStr = "";
            emp.Location = new Point(239, 26);
            emp.Margin = new Padding(4, 3, 4, 3);
            emp.Name = "emp";
            emp.Size = new Size(233, 23);
            emp.TabIndex = 7;
            emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.Title = "Employee";
            emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.TitleWidth = 80;
            // 
            // s_status
            // 
            s_status.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_status.Appearance.Options.UseFont = true;
            s_status.ControlHeight = 23;
            s_status.ControlWidth = 226;
            s_status.FldTy = null;
            s_status.FontColor = Color.Black;
            s_status.FontFace = "Tahoma";
            s_status.FontSize = 9F;
            s_status.Location = new Point(6, 51);
            s_status.Margin = new Padding(4, 3, 4, 3);
            s_status.Name = "s_status";
            s_status.Size = new Size(226, 23);
            s_status.TabIndex = 6;
            s_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_status.Title = "Status";
            s_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_status.TitleWidth = 80;
            // 
            // s_position
            // 
            s_position.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_position.Appearance.Options.UseFont = true;
            s_position.ControlHeight = 23;
            s_position.ControlWidth = 218;
            s_position.FldTy = null;
            s_position.FontColor = Color.Black;
            s_position.FontFace = "Tahoma";
            s_position.FontSize = 9F;
            s_position.Location = new Point(480, 26);
            s_position.Margin = new Padding(4, 3, 4, 3);
            s_position.Name = "s_position";
            s_position.Size = new Size(218, 23);
            s_position.TabIndex = 5;
            s_position.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_position.Title = "Position";
            s_position.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_position.TitleWidth = 80;
            // 
            // s_dept
            // 
            s_dept.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_dept.Appearance.Options.UseFont = true;
            s_dept.ControlHeight = 23;
            s_dept.ControlWidth = 233;
            s_dept.FontColor = Color.Black;
            s_dept.FontFace = "Tahoma";
            s_dept.FontSize = 9F;
            s_dept.FormatStr = "";
            s_dept.Location = new Point(239, 51);
            s_dept.Margin = new Padding(4, 3, 4, 3);
            s_dept.Name = "s_dept";
            s_dept.Size = new Size(233, 23);
            s_dept.TabIndex = 4;
            s_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.Title = "Dept";
            s_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.TitleWidth = 80;
            // 
            // s_date
            // 
            s_date.ControlHeight = 20;
            s_date.ControlWidth = 227;
            s_date.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_date.FontColor = Color.Black;
            s_date.FontFace = "Tahoma";
            s_date.FontSize = 9F;
            s_date.FormatStr = "";
            s_date.Location = new Point(5, 24);
            s_date.Name = "s_date";
            s_date.Size = new Size(227, 20);
            s_date.TabIndex = 2;
            s_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_date.Title = "Date";
            s_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_date.TitleWidth = 80;
            // 
            // ucChkCodeBox3
            // 
            ucChkCodeBox3.Appearance.Font = new Font("Tahoma", 9F);
            ucChkCodeBox3.Appearance.Options.UseFont = true;
            ucChkCodeBox3.ControlHeight = 23;
            ucChkCodeBox3.ControlWidth = 218;
            ucChkCodeBox3.FontFace = "Tahoma";
            ucChkCodeBox3.FontSize = 9F;
            ucChkCodeBox3.Location = new Point(704, 26);
            ucChkCodeBox3.Name = "ucChkCodeBox3";
            ucChkCodeBox3.Size = new Size(218, 23);
            ucChkCodeBox3.TabIndex = 1;
            ucChkCodeBox3.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucChkCodeBox3.Title = "Job Site";
            ucChkCodeBox3.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            ucChkCodeBox3.TitleWidth = 80;
            // 
            // job_site
            // 
            job_site.Appearance.Font = new Font("Tahoma", 9F);
            job_site.Appearance.Options.UseFont = true;
            job_site.ControlHeight = 23;
            job_site.ControlWidth = 218;
            job_site.FontFace = "Tahoma";
            job_site.FontSize = 9F;
            job_site.Location = new Point(704, 49);
            job_site.Name = "job_site";
            job_site.Size = new Size(218, 23);
            job_site.TabIndex = 1;
            job_site.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            job_site.Title = "Section";
            job_site.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            job_site.TitleWidth = 80;
            // 
            // project
            // 
            project.Appearance.Font = new Font("Tahoma", 9F);
            project.Appearance.Options.UseFont = true;
            project.ControlHeight = 23;
            project.ControlWidth = 219;
            project.FontColor = Color.Black;
            project.FontFace = "Tahoma";
            project.FontSize = 9F;
            project.FormatStr = "";
            project.Location = new Point(479, 49);
            project.Name = "project";
            project.Size = new Size(219, 23);
            project.TabIndex = 0;
            project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.Title = "Project";
            project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.TitleWidth = 80;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1326, 630);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g10);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1324, 605);
            xtraTabPage1.TabPageWidth = 50;
            xtraTabPage1.Text = "Indirect";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1324, 605);
            g10.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g20);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1324, 605);
            xtraTabPage2.TabPageWidth = 50;
            xtraTabPage2.Text = "Direct";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1324, 605);
            g20.TabIndex = 0;
            // 
            // HR330
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR330";
            Size = new Size(1326, 712);
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
        private Ctrls.UCChkCodeBox ucChkCodeBox3;
        private Ctrls.UCChkCodeBox s_emp_status;
        private Ctrls.UCChkCodeBox job_site;
        private Ctrls.UCChkCodeBox position;
        private Ctrls.UCTextBox project;
        private Ctrls.UCTextBox ucTextBox1;
        private Ctrls.UCCodeBox ucCodeBox1;
        private Ctrls.UCDateBox s_date;
        private Ctrls.UCCodeBox s_position;
        private Ctrls.UCTextBox s_dept;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCTextBox emp;
        private Ctrls.UCCodeBox s_status;
    }
}
