namespace EpicV004.Frms
{
    partial class HR530
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
            btn_summary = new Ctrls.UCButton();
            dept = new Ctrls.UCTextBox();
            emp_no = new Ctrls.UCTextBox();
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
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
            ucSplit1.Size = new Size(800, 450);
            ucSplit1.SplitterDistance = 76;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(btn_summary);
            ucPanel1.Controls.Add(dept);
            ucPanel1.Controls.Add(emp_no);
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(800, 76);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Payment Day";
            // 
            // btn_summary
            // 
            btn_summary.Appearance.BackColor = Color.DarkGray;
            btn_summary.Appearance.Font = new Font("Tahoma", 9F);
            btn_summary.Appearance.Options.UseBackColor = true;
            btn_summary.Appearance.Options.UseFont = true;
            btn_summary.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_summary.ControlHeight = 45;
            btn_summary.ControlWidth = 194;
            btn_summary.FontBold = FontStyle.Regular;
            btn_summary.FontFace = "Tahoma";
            btn_summary.FontSize = 9F;
            btn_summary.Location = new Point(561, 26);
            btn_summary.Name = "btn_summary";
            btn_summary.Size = new Size(194, 45);
            btn_summary.TabIndex = 4;
            btn_summary.Title = "Summary Attendance Log";
            btn_summary.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // dept
            // 
            dept.ControlHeight = 21;
            dept.ControlWidth = 249;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(287, 50);
            dept.Name = "dept";
            dept.Size = new Size(249, 21);
            dept.TabIndex = 3;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Department";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 100;
            // 
            // emp_no
            // 
            emp_no.ControlHeight = 21;
            emp_no.ControlWidth = 249;
            emp_no.FontColor = Color.Black;
            emp_no.FontFace = "Tahoma";
            emp_no.FontSize = 9F;
            emp_no.FormatStr = "";
            emp_no.Location = new Point(287, 26);
            emp_no.Name = "emp_no";
            emp_no.Size = new Size(249, 21);
            emp_no.TabIndex = 2;
            emp_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_no.Title = "Employee";
            emp_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_no.TitleWidth = 100;
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 236;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(5, 50);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(236, 21);
            to_dt.TabIndex = 1;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 100;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 236;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 26);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(236, 21);
            fr_dt.TabIndex = 0;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Attendance Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 100;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(800, 370);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g10);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(798, 345);
            xtraTabPage1.Text = "Summary by Attendance Date";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(798, 345);
            g10.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g20);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(798, 345);
            xtraTabPage2.Text = "Summary by Attendance Type";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(798, 345);
            g20.TabIndex = 0;
            // 
            // HR530
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR530";
            Size = new Size(800, 450);
            Load += HR530_Load;
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

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCButton btn_summary;
        private EpicV004.Ctrls.UCTextBox dept;
        private EpicV004.Ctrls.UCTextBox emp_no;
        private EpicV004.Ctrls.UCDateBox to_dt;
        private EpicV004.Ctrls.UCDateBox fr_dt;
        private EpicV004.Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private EpicV004.Ctrls.UCGridSet g10;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private EpicV004.Ctrls.UCGridSet g20;
    }
}
