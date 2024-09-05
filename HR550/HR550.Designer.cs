namespace EpicV004.Frms
{
    partial class HR550
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
            btn_Get = new Ctrls.UCButton();
            oder_to_date = new Ctrls.UCDateBox();
            date = new Ctrls.UCDateBox();
            s_emp_status = new Ctrls.UCChkCodeBox();
            emp = new Ctrls.UCTextBox();
            dept = new Ctrls.UCTextBox();
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
            ucSplit1.Size = new Size(1335, 707);
            ucSplit1.SplitterDistance = 68;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(btn_Get);
            ucPanel1.Controls.Add(oder_to_date);
            ucPanel1.Controls.Add(date);
            ucPanel1.Controls.Add(s_emp_status);
            ucPanel1.Controls.Add(emp);
            ucPanel1.Controls.Add(dept);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1335, 68);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Attendance Period";
            // 
            // btn_Get
            // 
            btn_Get.Appearance.Font = new Font("Tahoma", 9F);
            btn_Get.Appearance.Options.UseFont = true;
            btn_Get.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_Get.ControlHeight = 31;
            btn_Get.ControlWidth = 211;
            btn_Get.FontBold = FontStyle.Regular;
            btn_Get.FontFace = "Tahoma";
            btn_Get.FontSize = 9F;
            btn_Get.Location = new Point(1096, 26);
            btn_Get.Name = "btn_Get";
            btn_Get.Size = new Size(211, 31);
            btn_Get.TabIndex = 4;
            btn_Get.Title = "Get Time Scan Data (Attendance)";
            btn_Get.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // oder_to_date
            // 
            oder_to_date.ControlHeight = 21;
            oder_to_date.ControlWidth = 176;
            oder_to_date.FontColor = Color.Black;
            oder_to_date.FontFace = "Tahoma";
            oder_to_date.FontSize = 9F;
            oder_to_date.FormatStr = "";
            oder_to_date.Location = new Point(203, 28);
            oder_to_date.Name = "oder_to_date";
            oder_to_date.Size = new Size(176, 21);
            oder_to_date.TabIndex = 3;
            oder_to_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            oder_to_date.Title = "~";
            oder_to_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            oder_to_date.TitleWidth = 60;
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
            // s_emp_status
            // 
            s_emp_status.Appearance.Font = new Font("Tahoma", 9F);
            s_emp_status.Appearance.Options.UseFont = true;
            s_emp_status.ControlHeight = 21;
            s_emp_status.ControlWidth = 236;
            s_emp_status.FontFace = "Tahoma";
            s_emp_status.FontSize = 9F;
            s_emp_status.Location = new Point(854, 28);
            s_emp_status.Name = "s_emp_status";
            s_emp_status.Size = new Size(236, 21);
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
            emp.ControlHeight = 21;
            emp.ControlWidth = 228;
            emp.FontColor = Color.Black;
            emp.FontFace = "Tahoma";
            emp.FontSize = 9F;
            emp.FormatStr = "";
            emp.Location = new Point(620, 28);
            emp.Name = "emp";
            emp.Size = new Size(228, 21);
            emp.TabIndex = 0;
            emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.Title = "Employee";
            emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.TitleWidth = 90;
            // 
            // dept
            // 
            dept.Appearance.Font = new Font("Tahoma", 9F);
            dept.Appearance.Options.UseFont = true;
            dept.ControlHeight = 21;
            dept.ControlWidth = 229;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(385, 28);
            dept.Name = "dept";
            dept.Size = new Size(229, 21);
            dept.TabIndex = 0;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Dept";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 90;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(ucPanel2);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(ucPanel3);
            ucSplit2.Size = new Size(1335, 635);
            ucSplit2.SplitterDistance = 1070;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(g10);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1070, 635);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Attendance Summary";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(1066, 610);
            g10.TabIndex = 0;
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(g20);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(0, 0);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(261, 635);
            ucPanel3.TabIndex = 0;
            ucPanel3.Text = "Attendance History";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(2, 23);
            g20.Name = "g20";
            g20.Size = new Size(257, 610);
            g20.TabIndex = 0;
            // 
            // HR550
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR550";
            Size = new Size(1335, 707);
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

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCTextBox dept;
        private Ctrls.UCChkCodeBox s_emp_status;
        private Ctrls.UCTextBox emp;
        private Ctrls.UCDateBox oder_to_date;
        private Ctrls.UCDateBox date;
        private Ctrls.UCButton btn_Get;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCPanel ucPanel3;
        private Ctrls.UCGridSet g20;
    }
}
