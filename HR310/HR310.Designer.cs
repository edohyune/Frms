namespace EpicV004.Frms
{
    partial class HR310
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
            btn_print = new Ctrls.UCButton();
            issue_date = new Ctrls.UCDateBox();
            memo = new Ctrls.UCTextBox();
            certificate_type = new Ctrls.UCCodeBox();
            employee_status = new Ctrls.UCCodeBox();
            issue_no = new Ctrls.UCTextBox();
            emp_nm = new Ctrls.UCTextBox();
            emp_no = new Ctrls.UCTextBox();
            ucSplit2 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            s_emp_status = new Ctrls.UCChkCodeBox();
            s_emp = new Ctrls.UCTextBox();
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
            g10 = new Ctrls.UCGridSet();
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
            ucSplit1.Size = new Size(1283, 616);
            ucSplit1.SplitterDistance = 137;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(btn_print);
            ucPanel1.Controls.Add(issue_date);
            ucPanel1.Controls.Add(memo);
            ucPanel1.Controls.Add(certificate_type);
            ucPanel1.Controls.Add(employee_status);
            ucPanel1.Controls.Add(issue_no);
            ucPanel1.Controls.Add(emp_nm);
            ucPanel1.Controls.Add(emp_no);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1283, 137);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Information";
            // 
            // btn_print
            // 
            btn_print.Appearance.Font = new Font("Tahoma", 9F);
            btn_print.Appearance.Options.UseFont = true;
            btn_print.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_print.ControlHeight = 106;
            btn_print.ControlWidth = 75;
            btn_print.FontBold = FontStyle.Regular;
            btn_print.FontFace = "Tahoma";
            btn_print.FontSize = 9F;
            btn_print.Location = new Point(603, 28);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(75, 106);
            btn_print.TabIndex = 4;
            btn_print.Title = "Print";
            btn_print.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // issue_date
            // 
            issue_date.ControlHeight = 20;
            issue_date.ControlWidth = 292;
            issue_date.Font = new Font("Tahoma", 9F);
            issue_date.FontColor = Color.Black;
            issue_date.FontFace = "Tahoma";
            issue_date.FontSize = 9F;
            issue_date.FormatStr = "";
            issue_date.Location = new Point(304, 54);
            issue_date.Name = "issue_date";
            issue_date.Size = new Size(292, 20);
            issue_date.TabIndex = 3;
            issue_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            issue_date.Title = "Issue Date";
            issue_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            issue_date.TitleWidth = 100;
            // 
            // memo
            // 
            memo.Appearance.Font = new Font("Tahoma", 9F);
            memo.Appearance.Options.UseFont = true;
            memo.ControlHeight = 23;
            memo.ControlWidth = 590;
            memo.FontColor = Color.Black;
            memo.FontFace = "Tahoma";
            memo.FontSize = 9F;
            memo.FormatStr = "";
            memo.Location = new Point(6, 109);
            memo.Margin = new Padding(4, 3, 4, 3);
            memo.Name = "memo";
            memo.Size = new Size(590, 23);
            memo.TabIndex = 2;
            memo.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            memo.Title = "Memo";
            memo.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            memo.TitleWidth = 100;
            // 
            // certificate_type
            // 
            certificate_type.Appearance.Font = new Font("Tahoma", 9F);
            certificate_type.Appearance.Options.UseFont = true;
            certificate_type.ControlHeight = 23;
            certificate_type.ControlWidth = 292;
            certificate_type.FldTy = null;
            certificate_type.FontColor = Color.Black;
            certificate_type.FontFace = "Tahoma";
            certificate_type.FontSize = 9F;
            certificate_type.Location = new Point(5, 83);
            certificate_type.Margin = new Padding(4, 3, 4, 3);
            certificate_type.Name = "certificate_type";
            certificate_type.Size = new Size(292, 23);
            certificate_type.TabIndex = 1;
            certificate_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            certificate_type.Title = "Certificate Type";
            certificate_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            certificate_type.TitleWidth = 100;
            // 
            // employee_status
            // 
            employee_status.Appearance.Font = new Font("Tahoma", 9F);
            employee_status.Appearance.Options.UseFont = true;
            employee_status.ControlHeight = 23;
            employee_status.ControlWidth = 292;
            employee_status.FldTy = null;
            employee_status.FontColor = Color.Black;
            employee_status.FontFace = "Tahoma";
            employee_status.FontSize = 9F;
            employee_status.Location = new Point(6, 54);
            employee_status.Margin = new Padding(4, 3, 4, 3);
            employee_status.Name = "employee_status";
            employee_status.Size = new Size(292, 23);
            employee_status.TabIndex = 1;
            employee_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            employee_status.Title = "Status";
            employee_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            employee_status.TitleWidth = 100;
            // 
            // issue_no
            // 
            issue_no.Appearance.Font = new Font("Tahoma", 9F);
            issue_no.Appearance.Options.UseFont = true;
            issue_no.ControlHeight = 23;
            issue_no.ControlWidth = 292;
            issue_no.FontColor = Color.Black;
            issue_no.FontFace = "Tahoma";
            issue_no.FontSize = 9F;
            issue_no.FormatStr = "";
            issue_no.Location = new Point(304, 83);
            issue_no.Margin = new Padding(4, 3, 4, 3);
            issue_no.Name = "issue_no";
            issue_no.Size = new Size(292, 23);
            issue_no.TabIndex = 0;
            issue_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            issue_no.Title = "Issue No";
            issue_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            issue_no.TitleWidth = 100;
            // 
            // emp_nm
            // 
            emp_nm.Appearance.Font = new Font("Tahoma", 9F);
            emp_nm.Appearance.Options.UseFont = true;
            emp_nm.ControlHeight = 20;
            emp_nm.ControlWidth = 292;
            emp_nm.FontColor = Color.Black;
            emp_nm.FontFace = "Tahoma";
            emp_nm.FontSize = 9F;
            emp_nm.FormatStr = "";
            emp_nm.Location = new Point(304, 28);
            emp_nm.Margin = new Padding(4, 3, 4, 3);
            emp_nm.Name = "emp_nm";
            emp_nm.Size = new Size(292, 20);
            emp_nm.TabIndex = 0;
            emp_nm.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_nm.Title = "";
            emp_nm.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_nm.TitleWidth = 1;
            // 
            // emp_no
            // 
            emp_no.Appearance.Font = new Font("Tahoma", 9F);
            emp_no.Appearance.Options.UseFont = true;
            emp_no.ControlHeight = 20;
            emp_no.ControlWidth = 292;
            emp_no.FontColor = Color.Black;
            emp_no.FontFace = "Tahoma";
            emp_no.FontSize = 9F;
            emp_no.FormatStr = "";
            emp_no.Location = new Point(6, 28);
            emp_no.Margin = new Padding(4, 3, 4, 3);
            emp_no.Name = "emp_no";
            emp_no.Size = new Size(292, 20);
            emp_no.TabIndex = 0;
            emp_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_no.Title = "Employee No";
            emp_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            emp_no.TitleWidth = 100;
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
            ucSplit2.Panel2.Controls.Add(g10);
            ucSplit2.Size = new Size(1283, 475);
            ucSplit2.SplitterDistance = 54;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(s_emp_status);
            ucPanel2.Controls.Add(s_emp);
            ucPanel2.Controls.Add(to_dt);
            ucPanel2.Controls.Add(fr_dt);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1283, 54);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Certificate Issue History";
            // 
            // s_emp_status
            // 
            s_emp_status.ControlHeight = 21;
            s_emp_status.ControlWidth = 200;
            s_emp_status.FontFace = "Tahoma";
            s_emp_status.FontSize = 9F;
            s_emp_status.Location = new Point(579, 26);
            s_emp_status.Name = "s_emp_status";
            s_emp_status.Size = new Size(200, 21);
            s_emp_status.TabIndex = 2;
            s_emp_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_status.Title = "Employee Status";
            s_emp_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_emp_status.TitleWidth = 100;
            // 
            // s_emp
            // 
            s_emp.ControlHeight = 21;
            s_emp.ControlWidth = 200;
            s_emp.FontColor = Color.Black;
            s_emp.FontFace = "Tahoma";
            s_emp.FontSize = 9F;
            s_emp.FormatStr = "";
            s_emp.Location = new Point(373, 26);
            s_emp.Name = "s_emp";
            s_emp.Size = new Size(200, 21);
            s_emp.TabIndex = 1;
            s_emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp.Title = "Employee";
            s_emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp.TitleWidth = 100;
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 156;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(211, 26);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(156, 21);
            to_dt.TabIndex = 0;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 50;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 200;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 26);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(200, 21);
            fr_dt.TabIndex = 0;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Issue Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 100;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1283, 417);
            g10.TabIndex = 0;
            // 
            // HR310
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR310";
            Size = new Size(1283, 616);
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
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCTextBox emp_no;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCButton btn_print;
        private Ctrls.UCDateBox issue_date;
        private Ctrls.UCTextBox memo;
        private Ctrls.UCCodeBox certificate_type;
        private Ctrls.UCCodeBox employee_status;
        private Ctrls.UCTextBox issue_no;
        private Ctrls.UCTextBox emp_nm;
        private Ctrls.UCChkCodeBox s_emp_status;
        private Ctrls.UCTextBox s_emp;
        private Ctrls.UCDateBox to_dt;
        private Ctrls.UCDateBox fr_dt;
    }
}
