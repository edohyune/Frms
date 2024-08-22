namespace EpicV004.Frms
{
    partial class HR650
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
            s_year = new Ctrls.UCDateBox();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            s_emp = new Ctrls.UCTextBox();
            s_dept = new Ctrls.UCTextBox();
            btn_summary = new Ctrls.UCButton();
            g20 = new Ctrls.UCGridSet();
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
            SuspendLayout();
            // 
            // ucSplit1
            // 
            ucSplit1.Dock = DockStyle.Fill;
            ucSplit1.Location = new Point(0, 0);
            ucSplit1.Name = "ucSplit1";
            // 
            // ucSplit1.Panel1
            // 
            ucSplit1.Panel1.Controls.Add(ucSplit2);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucSplit3);
            ucSplit1.Size = new Size(1101, 547);
            ucSplit1.SplitterDistance = 269;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
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
            ucSplit2.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(g10);
            ucSplit2.Size = new Size(269, 547);
            ucSplit2.SplitterDistance = 69;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_year);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(269, 69);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // s_year
            // 
            s_year.ControlHeight = 21;
            s_year.ControlWidth = 163;
            s_year.FontColor = Color.Black;
            s_year.FontFace = "Tahoma";
            s_year.FontSize = 9F;
            s_year.FormatStr = "";
            s_year.Location = new Point(5, 33);
            s_year.Name = "s_year";
            s_year.Size = new Size(163, 21);
            s_year.TabIndex = 0;
            s_year.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.Title = "Year";
            s_year.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.TitleWidth = 70;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(269, 474);
            g10.TabIndex = 0;
            // 
            // ucSplit3
            // 
            ucSplit3.Dock = DockStyle.Fill;
            ucSplit3.FixedPanel = FixedPanel.Panel1;
            ucSplit3.Location = new Point(0, 0);
            ucSplit3.Name = "ucSplit3";
            ucSplit3.Orientation = Orientation.Horizontal;
            // 
            // ucSplit3.Panel1
            // 
            ucSplit3.Panel1.Controls.Add(ucPanel2);
            // 
            // ucSplit3.Panel2
            // 
            ucSplit3.Panel2.Controls.Add(g20);
            ucSplit3.Size = new Size(828, 547);
            ucSplit3.SplitterDistance = 81;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(s_emp);
            ucPanel2.Controls.Add(s_dept);
            ucPanel2.Controls.Add(btn_summary);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(828, 81);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Search";
            // 
            // s_emp
            // 
            s_emp.ControlHeight = 21;
            s_emp.ControlWidth = 227;
            s_emp.FontColor = Color.Black;
            s_emp.FontFace = "Tahoma";
            s_emp.FontSize = 9F;
            s_emp.FormatStr = "";
            s_emp.Location = new Point(425, 51);
            s_emp.Name = "s_emp";
            s_emp.Size = new Size(227, 21);
            s_emp.TabIndex = 2;
            s_emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp.Title = "Employee";
            s_emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp.TitleWidth = 100;
            // 
            // s_dept
            // 
            s_dept.ControlHeight = 21;
            s_dept.ControlWidth = 227;
            s_dept.FontColor = Color.Black;
            s_dept.FontFace = "Tahoma";
            s_dept.FontSize = 9F;
            s_dept.FormatStr = "";
            s_dept.Location = new Point(425, 26);
            s_dept.Name = "s_dept";
            s_dept.Size = new Size(227, 21);
            s_dept.TabIndex = 1;
            s_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.Title = "Dept";
            s_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.TitleWidth = 100;
            // 
            // btn_summary
            // 
            btn_summary.Appearance.BackColor = Color.DarkGray;
            btn_summary.Appearance.Font = new Font("Tahoma", 9F);
            btn_summary.Appearance.Options.UseBackColor = true;
            btn_summary.Appearance.Options.UseFont = true;
            btn_summary.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_summary.ControlHeight = 50;
            btn_summary.ControlWidth = 192;
            btn_summary.FontBold = FontStyle.Regular;
            btn_summary.FontFace = "Tahoma";
            btn_summary.FontSize = 9F;
            btn_summary.Location = new Point(19, 26);
            btn_summary.Name = "btn_summary";
            btn_summary.Size = new Size(192, 50);
            btn_summary.TabIndex = 0;
            btn_summary.Title = "Summary Addition/Deduction";
            btn_summary.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(828, 462);
            g20.TabIndex = 0;
            // 
            // HR650
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR650";
            Size = new Size(1101, 547);
            Load += HR650_Load;
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
            ResumeLayout(false);
        }

        #endregion

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCSplit ucSplit2;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCSplit ucSplit3;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private EpicV004.Ctrls.UCTextBox s_emp;
        private EpicV004.Ctrls.UCTextBox s_dept;
        private EpicV004.Ctrls.UCButton btn_summary;
        private EpicV004.Ctrls.UCDateBox s_year;
        private EpicV004.Ctrls.UCGridSet g10;
        private EpicV004.Ctrls.UCGridSet g20;
    }
}
