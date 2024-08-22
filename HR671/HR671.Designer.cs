namespace EpicV004.Frms
{
    partial class HR671
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
            ucPanel1 = new Ctrls.UCPanel();
            s_salary_degree = new Ctrls.UCTextBox();
            s_month = new Ctrls.UCDateBox();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            s_emp_type = new Ctrls.UCChkCodeBox();
            s_to_dt = new Ctrls.UCDateBox();
            s_dt = new Ctrls.UCDateBox();
            ucPanel3 = new Ctrls.UCPanel();
            btn_salary = new Ctrls.UCButton();
            btn_add = new Ctrls.UCButton();
            btnattendance = new Ctrls.UCButton();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g10 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new Ctrls.UCGridSet();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            g30 = new Ctrls.UCGridSet();
            xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            g40 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit2).BeginInit();
            ucSplit2.Panel1.SuspendLayout();
            ucSplit2.Panel2.SuspendLayout();
            ucSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit3).BeginInit();
            ucSplit3.Panel1.SuspendLayout();
            ucSplit3.Panel2.SuspendLayout();
            ucSplit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel3).BeginInit();
            ucPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucTab1).BeginInit();
            ucTab1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            xtraTabPage2.SuspendLayout();
            xtraTabPage3.SuspendLayout();
            xtraTabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // ucSplit1
            // 
            ucSplit1.Dock = DockStyle.Fill;
            ucSplit1.Location = new Point(0, 0);
            ucSplit1.Name = "ucSplit1";
            ucSplit1.Orientation = Orientation.Horizontal;
            // 
            // ucSplit1.Panel1
            // 
            ucSplit1.Panel1.Controls.Add(ucSplit2);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucTab1);
            ucSplit1.Size = new Size(1328, 725);
            ucSplit1.SplitterDistance = 79;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(ucSplit3);
            ucSplit2.Size = new Size(1328, 79);
            ucSplit2.SplitterDistance = 211;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_salary_degree);
            ucPanel1.Controls.Add(s_month);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(211, 79);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Query";
            // 
            // s_salary_degree
            // 
            s_salary_degree.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_salary_degree.Appearance.Options.UseFont = true;
            s_salary_degree.ControlHeight = 21;
            s_salary_degree.ControlWidth = 200;
            s_salary_degree.FontColor = Color.Black;
            s_salary_degree.FontFace = "Tahoma";
            s_salary_degree.FontSize = 9F;
            s_salary_degree.FormatStr = "";
            s_salary_degree.Location = new Point(5, 53);
            s_salary_degree.Name = "s_salary_degree";
            s_salary_degree.Size = new Size(200, 21);
            s_salary_degree.TabIndex = 1;
            s_salary_degree.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_salary_degree.Title = "Salary Date";
            s_salary_degree.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_salary_degree.TitleWidth = 100;
            // 
            // s_month
            // 
            s_month.ControlHeight = 21;
            s_month.ControlWidth = 200;
            s_month.Font = new Font("Tahoma", 9F);
            s_month.FontColor = Color.Black;
            s_month.FontFace = "Tahoma";
            s_month.FontSize = 9F;
            s_month.FormatStr = "";
            s_month.Location = new Point(5, 26);
            s_month.Name = "s_month";
            s_month.Size = new Size(200, 21);
            s_month.TabIndex = 0;
            s_month.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_month.Title = "Salary Month";
            s_month.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_month.TitleWidth = 100;
            // 
            // ucSplit3
            // 
            ucSplit3.Dock = DockStyle.Fill;
            ucSplit3.FixedPanel = FixedPanel.Panel1;
            ucSplit3.Location = new Point(0, 0);
            ucSplit3.Name = "ucSplit3";
            // 
            // ucSplit3.Panel1
            // 
            ucSplit3.Panel1.Controls.Add(ucPanel2);
            // 
            // ucSplit3.Panel2
            // 
            ucSplit3.Panel2.Controls.Add(ucPanel3);
            ucSplit3.Size = new Size(1113, 79);
            ucSplit3.SplitterDistance = 397;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(s_emp_type);
            ucPanel2.Controls.Add(s_to_dt);
            ucPanel2.Controls.Add(s_dt);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(397, 79);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Salary Status";
            // 
            // s_emp_type
            // 
            s_emp_type.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_emp_type.Appearance.Options.UseFont = true;
            s_emp_type.ControlHeight = 21;
            s_emp_type.ControlWidth = 324;
            s_emp_type.FontFace = "Tahoma";
            s_emp_type.FontSize = 9F;
            s_emp_type.Location = new Point(5, 53);
            s_emp_type.Name = "s_emp_type";
            s_emp_type.Size = new Size(324, 21);
            s_emp_type.TabIndex = 1;
            s_emp_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_type.Title = "Employee Type";
            s_emp_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_emp_type.TitleWidth = 100;
            // 
            // s_to_dt
            // 
            s_to_dt.ControlHeight = 21;
            s_to_dt.ControlWidth = 130;
            s_to_dt.Font = new Font("Tahoma", 9F);
            s_to_dt.FontColor = Color.Black;
            s_to_dt.FontFace = "Tahoma";
            s_to_dt.FontSize = 9F;
            s_to_dt.FormatStr = "";
            s_to_dt.Location = new Point(199, 26);
            s_to_dt.Name = "s_to_dt";
            s_to_dt.Size = new Size(130, 21);
            s_to_dt.TabIndex = 0;
            s_to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_to_dt.Title = "~";
            s_to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_to_dt.TitleWidth = 30;
            // 
            // s_dt
            // 
            s_dt.ControlHeight = 21;
            s_dt.ControlWidth = 188;
            s_dt.Font = new Font("Tahoma", 9F);
            s_dt.FontColor = Color.Black;
            s_dt.FontFace = "Tahoma";
            s_dt.FontSize = 9F;
            s_dt.FormatStr = "";
            s_dt.Location = new Point(5, 26);
            s_dt.Name = "s_dt";
            s_dt.Size = new Size(188, 21);
            s_dt.TabIndex = 0;
            s_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dt.Title = "Salary Period";
            s_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dt.TitleWidth = 100;
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(btn_salary);
            ucPanel3.Controls.Add(btn_add);
            ucPanel3.Controls.Add(btnattendance);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(0, 0);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(712, 79);
            ucPanel3.TabIndex = 0;
            ucPanel3.Text = "Execute";
            // 
            // btn_salary
            // 
            btn_salary.Appearance.Font = new Font("Tahoma", 9F);
            btn_salary.Appearance.Options.UseFont = true;
            btn_salary.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_salary.ControlHeight = 35;
            btn_salary.ControlWidth = 164;
            btn_salary.FontBold = FontStyle.Regular;
            btn_salary.FontFace = "Tahoma";
            btn_salary.FontSize = 9F;
            btn_salary.Location = new Point(345, 39);
            btn_salary.Name = "btn_salary";
            btn_salary.Size = new Size(164, 35);
            btn_salary.TabIndex = 0;
            btn_salary.Title = "Salary / Tax";
            btn_salary.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // btn_add
            // 
            btn_add.Appearance.Font = new Font("Tahoma", 9F);
            btn_add.Appearance.Options.UseFont = true;
            btn_add.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_add.ControlHeight = 35;
            btn_add.ControlWidth = 164;
            btn_add.FontBold = FontStyle.Regular;
            btn_add.FontFace = "Tahoma";
            btn_add.FontSize = 9F;
            btn_add.Location = new Point(175, 39);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(164, 35);
            btn_add.TabIndex = 0;
            btn_add.Title = "Add / Deduction";
            btn_add.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // btnattendance
            // 
            btnattendance.Appearance.Font = new Font("Tahoma", 9F);
            btnattendance.Appearance.Options.UseFont = true;
            btnattendance.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btnattendance.ControlHeight = 35;
            btnattendance.ControlWidth = 164;
            btnattendance.FontBold = FontStyle.Regular;
            btnattendance.FontFace = "Tahoma";
            btnattendance.FontSize = 9F;
            btnattendance.Location = new Point(5, 39);
            btnattendance.Name = "btnattendance";
            btnattendance.Size = new Size(164, 35);
            btnattendance.TabIndex = 0;
            btnattendance.Title = "Attendance";
            btnattendance.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1328, 642);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2, xtraTabPage3, xtraTabPage4 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g10);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1326, 617);
            xtraTabPage1.TabPageWidth = 100;
            xtraTabPage1.Text = "Attendance";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1326, 617);
            g10.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g20);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1326, 617);
            xtraTabPage2.TabPageWidth = 100;
            xtraTabPage2.Text = "Add / Deduction";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1326, 617);
            g20.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(g30);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new Size(1326, 617);
            xtraTabPage3.TabPageWidth = 100;
            xtraTabPage3.Text = "Salary Result";
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(1326, 617);
            g30.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            xtraTabPage4.Controls.Add(g40);
            xtraTabPage4.Name = "xtraTabPage4";
            xtraTabPage4.Size = new Size(1326, 617);
            xtraTabPage4.TabPageWidth = 100;
            xtraTabPage4.Text = "Tax Result";
            // 
            // g40
            // 
            g40.Dock = DockStyle.Fill;
            g40.Location = new Point(0, 0);
            g40.Name = "g40";
            g40.Size = new Size(1326, 617);
            g40.TabIndex = 0;
            // 
            // HR671
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR671";
            Size = new Size(1328, 725);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ucSplit2.Panel1.ResumeLayout(false);
            ucSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit2).EndInit();
            ucSplit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ucSplit3.Panel1.ResumeLayout(false);
            ucSplit3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit3).EndInit();
            ucSplit3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel3).EndInit();
            ucPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucTab1).EndInit();
            ucTab1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            xtraTabPage3.ResumeLayout(false);
            xtraTabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCTextBox s_salary_degree;
        private Ctrls.UCDateBox s_month;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCChkCodeBox s_emp_type;
        private Ctrls.UCDateBox s_to_dt;
        private Ctrls.UCDateBox s_dt;
        private Ctrls.UCPanel ucPanel3;
        private Ctrls.UCButton btn_salary;
        private Ctrls.UCButton btn_add;
        private Ctrls.UCButton btnattendance;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Ctrls.UCGridSet g10;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCGridSet g20;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private Ctrls.UCGridSet g30;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private Ctrls.UCGridSet g40;
    }
}
