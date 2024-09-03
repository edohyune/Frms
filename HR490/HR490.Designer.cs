namespace EpicV004.Frms
{
    partial class HR490
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
            btn_make = new Ctrls.UCButton();
            project = new Ctrls.UCCodeBox();
            job_site = new Ctrls.UCCodeBox();
            position = new Ctrls.UCCodeBox();
            dept_name = new Ctrls.UCTextBox();
            section = new Ctrls.UCTextBox();
            dept = new Ctrls.UCTextBox();
            emp = new Ctrls.UCTextBox();
            std_year = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            g10 = new Ctrls.UCGridSet();
            ucPanel3 = new Ctrls.UCPanel();
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
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel3).BeginInit();
            ucPanel3.SuspendLayout();
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
            ucSplit1.Size = new Size(1316, 686);
            ucSplit1.SplitterDistance = 75;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(btn_make);
            ucPanel1.Controls.Add(project);
            ucPanel1.Controls.Add(job_site);
            ucPanel1.Controls.Add(position);
            ucPanel1.Controls.Add(dept_name);
            ucPanel1.Controls.Add(section);
            ucPanel1.Controls.Add(dept);
            ucPanel1.Controls.Add(emp);
            ucPanel1.Controls.Add(std_year);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1316, 75);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // btn_make
            // 
            btn_make.Appearance.BackColor = SystemColors.ScrollBar;
            btn_make.Appearance.Font = new Font("Tahoma", 9F);
            btn_make.Appearance.Options.UseBackColor = true;
            btn_make.Appearance.Options.UseFont = true;
            btn_make.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_make.ControlHeight = 40;
            btn_make.ControlWidth = 122;
            btn_make.FontBold = FontStyle.Regular;
            btn_make.FontFace = "Tahoma";
            btn_make.FontSize = 9F;
            btn_make.Location = new Point(975, 27);
            btn_make.Name = "btn_make";
            btn_make.Size = new Size(122, 40);
            btn_make.TabIndex = 5;
            btn_make.Title = "Make Leave Issue";
            btn_make.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // project
            // 
            project.ControlHeight = 23;
            project.ControlWidth = 200;
            project.FldTy = null;
            project.FontColor = Color.Black;
            project.FontFace = "Tahoma";
            project.FontSize = 9F;
            project.Location = new Point(563, 49);
            project.Name = "project";
            project.Size = new Size(200, 23);
            project.TabIndex = 4;
            project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.Title = "Project";
            project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.TitleWidth = 60;
            // 
            // job_site
            // 
            job_site.ControlHeight = 21;
            job_site.ControlWidth = 200;
            job_site.FldTy = null;
            job_site.FontColor = Color.Black;
            job_site.FontFace = "Tahoma";
            job_site.FontSize = 9F;
            job_site.Location = new Point(769, 26);
            job_site.Name = "job_site";
            job_site.Size = new Size(200, 21);
            job_site.TabIndex = 4;
            job_site.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            job_site.Title = "Job site";
            job_site.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            job_site.TitleWidth = 60;
            // 
            // position
            // 
            position.ControlHeight = 20;
            position.ControlWidth = 200;
            position.FldTy = null;
            position.FontColor = Color.Black;
            position.FontFace = "Tahoma";
            position.FontSize = 9F;
            position.Location = new Point(563, 27);
            position.Name = "position";
            position.Size = new Size(200, 20);
            position.TabIndex = 4;
            position.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            position.Title = "Position";
            position.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            position.TitleWidth = 60;
            // 
            // dept_name
            // 
            dept_name.Appearance.Font = new Font("Tahoma", 9F);
            dept_name.Appearance.Options.UseFont = true;
            dept_name.ControlHeight = 23;
            dept_name.ControlWidth = 164;
            dept_name.FontColor = Color.Black;
            dept_name.FontFace = "Tahoma";
            dept_name.FontSize = 9F;
            dept_name.FormatStr = "";
            dept_name.Location = new Point(392, 48);
            dept_name.Margin = new Padding(4, 3, 4, 3);
            dept_name.Name = "dept_name";
            dept_name.Size = new Size(164, 23);
            dept_name.TabIndex = 3;
            dept_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.Title = "";
            dept_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.TitleWidth = 1;
            // 
            // section
            // 
            section.ControlHeight = 22;
            section.ControlWidth = 200;
            section.FontColor = Color.Black;
            section.FontFace = "Tahoma";
            section.FontSize = 9F;
            section.FormatStr = "";
            section.Location = new Point(769, 48);
            section.Name = "section";
            section.Size = new Size(200, 22);
            section.TabIndex = 3;
            section.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            section.Title = "Section";
            section.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            section.TitleWidth = 60;
            // 
            // dept
            // 
            dept.Appearance.Font = new Font("Tahoma", 9F);
            dept.Appearance.Options.UseFont = true;
            dept.ControlHeight = 23;
            dept.ControlWidth = 172;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(212, 47);
            dept.Margin = new Padding(4, 3, 4, 3);
            dept.Name = "dept";
            dept.Size = new Size(172, 23);
            dept.TabIndex = 2;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "dept";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 80;
            // 
            // emp
            // 
            emp.Appearance.Font = new Font("Tahoma", 9F);
            emp.Appearance.Options.UseFont = true;
            emp.ControlHeight = 21;
            emp.ControlWidth = 344;
            emp.FontColor = Color.Black;
            emp.FontFace = "Tahoma";
            emp.FontSize = 9F;
            emp.FormatStr = "";
            emp.Location = new Point(212, 26);
            emp.Margin = new Padding(4, 3, 4, 3);
            emp.Name = "emp";
            emp.Size = new Size(344, 21);
            emp.TabIndex = 1;
            emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.Title = "Employee";
            emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.TitleWidth = 80;
            // 
            // std_year
            // 
            std_year.ControlHeight = 20;
            std_year.ControlWidth = 200;
            std_year.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            std_year.FontColor = Color.Black;
            std_year.FontFace = "Tahoma";
            std_year.FontSize = 9F;
            std_year.FormatStr = "";
            std_year.Location = new Point(5, 27);
            std_year.Name = "std_year";
            std_year.Size = new Size(200, 20);
            std_year.TabIndex = 0;
            std_year.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            std_year.Title = "Year";
            std_year.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            std_year.TitleWidth = 80;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.FixedPanel = FixedPanel.Panel1;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            ucSplit2.Orientation = Orientation.Horizontal;
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(ucPanel2);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(ucPanel3);
            ucSplit2.Size = new Size(1316, 607);
            ucSplit2.SplitterDistance = 302;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(g10);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1316, 302);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Issued List";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(1312, 277);
            g10.TabIndex = 0;
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(g20);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(0, 0);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(1316, 301);
            ucPanel3.TabIndex = 0;
            ucPanel3.Text = "Used List";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(2, 23);
            g20.Name = "g20";
            g20.Size = new Size(1312, 276);
            g20.TabIndex = 0;
            // 
            // HR490
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR490";
            Size = new Size(1316, 686);
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
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel3).EndInit();
            ucPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCButton btn_make;
        private EpicV004.Ctrls.UCCodeBox project;
        private EpicV004.Ctrls.UCCodeBox job_site;
        private EpicV004.Ctrls.UCCodeBox position;
        private EpicV004.Ctrls.UCTextBox section;
        private EpicV004.Ctrls.UCTextBox dept;
        private EpicV004.Ctrls.UCTextBox emp;
        private EpicV004.Ctrls.UCDateBox std_year;
        private EpicV004.Ctrls.UCSplit ucSplit2;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private EpicV004.Ctrls.UCGridSet g10;
        private EpicV004.Ctrls.UCPanel ucPanel3;
        private EpicV004.Ctrls.UCGridSet g20;
        private EpicV004.Ctrls.UCTextBox dept_name;
    }
}
