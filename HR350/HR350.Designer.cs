namespace EpicV004.Frms
{
    partial class HR350
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
            g10 = new Ctrls.UCGridSet();
            ucSplit1 = new Ctrls.UCSplit();
            ucPanel1 = new Ctrls.UCPanel();
            s_year = new Ctrls.UCDateBox();
            s_dept = new Ctrls.UCTextBox();
            s_emp_no = new Ctrls.UCTextBox();
            s_health_check = new Ctrls.UCChkCodeBox();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1181, 559);
            g10.TabIndex = 0;
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
            ucSplit1.Size = new Size(1181, 618);
            ucSplit1.SplitterDistance = 55;
            ucSplit1.TabIndex = 1;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_health_check);
            ucPanel1.Controls.Add(s_emp_no);
            ucPanel1.Controls.Add(s_dept);
            ucPanel1.Controls.Add(s_year);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1181, 55);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // s_year
            // 
            s_year.ControlHeight = 21;
            s_year.ControlWidth = 175;
            s_year.FontColor = Color.Black;
            s_year.FontFace = "Tahoma";
            s_year.FontSize = 9F;
            s_year.FormatStr = "";
            s_year.Location = new Point(5, 26);
            s_year.Name = "s_year";
            s_year.Size = new Size(175, 21);
            s_year.TabIndex = 0;
            s_year.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.Title = "Year";
            s_year.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.TitleWidth = 50;
            // 
            // s_dept
            // 
            s_dept.ControlHeight = 21;
            s_dept.ControlWidth = 200;
            s_dept.FontColor = Color.Black;
            s_dept.FontFace = "Tahoma";
            s_dept.FontSize = 9F;
            s_dept.FormatStr = "";
            s_dept.Location = new Point(186, 26);
            s_dept.Name = "s_dept";
            s_dept.Size = new Size(200, 21);
            s_dept.TabIndex = 1;
            s_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.Title = "Dept";
            s_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.TitleWidth = 50;
            // 
            // s_emp_no
            // 
            s_emp_no.ControlHeight = 21;
            s_emp_no.ControlWidth = 200;
            s_emp_no.FontColor = Color.Black;
            s_emp_no.FontFace = "Tahoma";
            s_emp_no.FontSize = 9F;
            s_emp_no.FormatStr = "";
            s_emp_no.Location = new Point(392, 26);
            s_emp_no.Name = "s_emp_no";
            s_emp_no.Size = new Size(200, 21);
            s_emp_no.TabIndex = 2;
            s_emp_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_no.Title = "Name";
            s_emp_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_no.TitleWidth = 50;
            // 
            // s_health_check
            // 
            s_health_check.ControlHeight = 21;
            s_health_check.ControlWidth = 236;
            s_health_check.FontFace = "Tahoma";
            s_health_check.FontSize = 9F;
            s_health_check.Location = new Point(598, 26);
            s_health_check.Name = "s_health_check";
            s_health_check.Size = new Size(236, 21);
            s_health_check.TabIndex = 3;
            s_health_check.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_health_check.Title = "Health Check";
            s_health_check.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_health_check.TitleWidth = 100;
            // 
            // HR350
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR350";
            Size = new Size(1181, 618);
         
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCGridSet g10;
        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCChkCodeBox s_health_check;
        private Ctrls.UCTextBox s_emp_no;
        private Ctrls.UCTextBox s_dept;
        private Ctrls.UCDateBox s_year;
    }
}
