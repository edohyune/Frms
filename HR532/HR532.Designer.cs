namespace EpicV004.Frms
{
    partial class HR532
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
            btn_today = new Ctrls.UCButton();
            btn_testerday = new Ctrls.UCButton();
            date = new Ctrls.UCDateBox();
            s_emp_status = new Ctrls.UCChkCodeBox();
            dpm_name = new Ctrls.UCTextBox();
            dpm = new Ctrls.UCTextBox();
            emp_no = new Ctrls.UCTextBox();
            ucPanel2 = new Ctrls.UCPanel();
            g10 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
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
            ucSplit1.Panel2.Controls.Add(ucPanel2);
            ucSplit1.Size = new Size(1283, 616);
            ucSplit1.SplitterDistance = 78;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(btn_today);
            ucPanel1.Controls.Add(btn_testerday);
            ucPanel1.Controls.Add(date);
            ucPanel1.Controls.Add(s_emp_status);
            ucPanel1.Controls.Add(dpm_name);
            ucPanel1.Controls.Add(dpm);
            ucPanel1.Controls.Add(emp_no);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1283, 78);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // btn_today
            // 
            btn_today.Appearance.Font = new Font("Tahoma", 9F);
            btn_today.Appearance.Options.UseFont = true;
            btn_today.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_today.ControlHeight = 21;
            btn_today.ControlWidth = 86;
            btn_today.FontBold = FontStyle.Regular;
            btn_today.FontFace = "Tahoma";
            btn_today.FontSize = 9F;
            btn_today.Location = new Point(157, 53);
            btn_today.Name = "btn_today";
            btn_today.Size = new Size(86, 21);
            btn_today.TabIndex = 4;
            btn_today.Title = "Today";
            btn_today.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // btn_testerday
            // 
            btn_testerday.Appearance.Font = new Font("Tahoma", 9F);
            btn_testerday.Appearance.Options.UseFont = true;
            btn_testerday.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_testerday.ControlHeight = 21;
            btn_testerday.ControlWidth = 86;
            btn_testerday.FontBold = FontStyle.Regular;
            btn_testerday.FontFace = "Tahoma";
            btn_testerday.FontSize = 9F;
            btn_testerday.Location = new Point(65, 53);
            btn_testerday.Name = "btn_testerday";
            btn_testerday.Size = new Size(86, 21);
            btn_testerday.TabIndex = 4;
            btn_testerday.Title = "Yesterday";
            btn_testerday.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // date
            // 
            date.ControlHeight = 21;
            date.ControlWidth = 238;
            date.FontColor = Color.Black;
            date.FontFace = "Tahoma";
            date.FontSize = 9F;
            date.FormatStr = "";
            date.Location = new Point(5, 28);
            date.Name = "date";
            date.Size = new Size(238, 21);
            date.TabIndex = 3;
            date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            date.Title = "Date";
            date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            date.TitleWidth = 90;
            // 
            // s_emp_status
            // 
            s_emp_status.Appearance.Font = new Font("Tahoma", 9F);
            s_emp_status.Appearance.Options.UseFont = true;
            s_emp_status.ControlHeight = 21;
            s_emp_status.ControlWidth = 248;
            s_emp_status.FontFace = "Tahoma";
            s_emp_status.FontSize = 9F;
            s_emp_status.Location = new Point(640, 28);
            s_emp_status.Name = "s_emp_status";
            s_emp_status.Size = new Size(248, 21);
            s_emp_status.TabIndex = 1;
            s_emp_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_status.Title = "Employee Status";
            s_emp_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_emp_status.TitleWidth = 117;
            // 
            // dpm_name
            // 
            dpm_name.Appearance.Font = new Font("Tahoma", 9F);
            dpm_name.Appearance.Options.UseFont = true;
            dpm_name.ControlHeight = 21;
            dpm_name.ControlWidth = 183;
            dpm_name.FontColor = Color.Black;
            dpm_name.FontFace = "Tahoma";
            dpm_name.FontSize = 9F;
            dpm_name.FormatStr = "";
            dpm_name.Location = new Point(451, 28);
            dpm_name.Name = "dpm_name";
            dpm_name.Size = new Size(183, 21);
            dpm_name.TabIndex = 0;
            dpm_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dpm_name.Title = "";
            dpm_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dpm_name.TitleWidth = 1;
            // 
            // dpm
            // 
            dpm.Appearance.Font = new Font("Tahoma", 9F);
            dpm.Appearance.Options.UseFont = true;
            dpm.ControlHeight = 21;
            dpm.ControlWidth = 196;
            dpm.FontColor = Color.Black;
            dpm.FontFace = "Tahoma";
            dpm.FontSize = 9F;
            dpm.FormatStr = "";
            dpm.Location = new Point(249, 28);
            dpm.Name = "dpm";
            dpm.Size = new Size(196, 21);
            dpm.TabIndex = 0;
            dpm.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dpm.Title = "Department";
            dpm.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dpm.TitleWidth = 93;
            // 
            // emp_no
            // 
            emp_no.Appearance.Font = new Font("Tahoma", 9F);
            emp_no.Appearance.Options.UseFont = true;
            emp_no.ControlHeight = 25;
            emp_no.ControlWidth = 385;
            emp_no.FontColor = Color.Black;
            emp_no.FontFace = "Tahoma";
            emp_no.FontSize = 9F;
            emp_no.FormatStr = "";
            emp_no.Location = new Point(249, 53);
            emp_no.Name = "emp_no";
            emp_no.Size = new Size(385, 25);
            emp_no.TabIndex = 0;
            emp_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_no.Title = "Employee No";
            emp_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_no.TitleWidth = 93;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(g10);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1283, 534);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Attendance";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(1279, 509);
            g10.TabIndex = 0;
            // 
            // HR532
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR532";
            Size = new Size(1283, 616);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCTextBox emp_no;
        private Ctrls.UCChkCodeBox s_emp_status;
        private Ctrls.UCTextBox dpm;
        private Ctrls.UCButton ucButton2;
        private Ctrls.UCButton btn_testerday;
        private Ctrls.UCDateBox date;
        private Ctrls.UCTextBox dpm_name;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCButton btn_today;
    }
}
