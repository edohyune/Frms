namespace EpicV004.Frms
{
    partial class HR850
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
            res_type = new Ctrls.UCChkCodeBox();
            res_to_date = new Ctrls.UCDateBox();
            res_date = new Ctrls.UCDateBox();
            s_emp_status = new Ctrls.UCChkCodeBox();
            emp = new Ctrls.UCTextBox();
            dept = new Ctrls.UCTextBox();
            g10 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
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
            ucSplit1.Panel2.Controls.Add(g10);
            ucSplit1.Size = new Size(1332, 694);
            ucSplit1.SplitterDistance = 52;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(res_type);
            ucPanel1.Controls.Add(res_to_date);
            ucPanel1.Controls.Add(res_date);
            ucPanel1.Controls.Add(s_emp_status);
            ucPanel1.Controls.Add(emp);
            ucPanel1.Controls.Add(dept);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1332, 52);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Resign Order";
            // 
            // res_type
            // 
            res_type.ControlHeight = 21;
            res_type.ControlWidth = 228;
            res_type.FontFace = "Tahoma";
            res_type.FontSize = 9F;
            res_type.Location = new Point(751, 28);
            res_type.Name = "res_type";
            res_type.Size = new Size(228, 21);
            res_type.TabIndex = 4;
            res_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            res_type.Title = "Resign Type";
            res_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            res_type.TitleWidth = 100;
            // 
            // res_to_date
            // 
            res_to_date.ControlHeight = 21;
            res_to_date.ControlWidth = 144;
            res_to_date.FontColor = Color.Black;
            res_to_date.FontFace = "Tahoma";
            res_to_date.FontSize = 9F;
            res_to_date.FormatStr = "";
            res_to_date.Location = new Point(205, 28);
            res_to_date.Name = "res_to_date";
            res_to_date.Size = new Size(144, 21);
            res_to_date.TabIndex = 3;
            res_to_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            res_to_date.Title = "~";
            res_to_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            res_to_date.TitleWidth = 25;
            // 
            // res_date
            // 
            res_date.ControlHeight = 21;
            res_date.ControlWidth = 192;
            res_date.FontColor = Color.Black;
            res_date.FontFace = "Tahoma";
            res_date.FontSize = 9F;
            res_date.FormatStr = "";
            res_date.Location = new Point(5, 28);
            res_date.Name = "res_date";
            res_date.Size = new Size(192, 21);
            res_date.TabIndex = 3;
            res_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            res_date.Title = "Resign Date";
            res_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            res_date.TitleWidth = 93;
            // 
            // s_emp_status
            // 
            s_emp_status.Appearance.Font = new Font("Tahoma", 9F);
            s_emp_status.Appearance.Options.UseFont = true;
            s_emp_status.ControlHeight = 21;
            s_emp_status.ControlWidth = 237;
            s_emp_status.FontFace = "Tahoma";
            s_emp_status.FontSize = 9F;
            s_emp_status.Location = new Point(985, 28);
            s_emp_status.Name = "s_emp_status";
            s_emp_status.Size = new Size(237, 21);
            s_emp_status.TabIndex = 1;
            s_emp_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_status.Title = "Employee Status";
            s_emp_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_emp_status.TitleWidth = 100;
            // 
            // emp
            // 
            emp.Appearance.Font = new Font("Tahoma", 9F);
            emp.Appearance.Options.UseFont = true;
            emp.ControlHeight = 21;
            emp.ControlWidth = 192;
            emp.FontColor = Color.Black;
            emp.FontFace = "Tahoma";
            emp.FontSize = 9F;
            emp.FormatStr = "";
            emp.Location = new Point(553, 28);
            emp.Name = "emp";
            emp.Size = new Size(192, 21);
            emp.TabIndex = 0;
            emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.Title = "Employee";
            emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp.TitleWidth = 60;
            // 
            // dept
            // 
            dept.Appearance.Font = new Font("Tahoma", 9F);
            dept.Appearance.Options.UseFont = true;
            dept.ControlHeight = 21;
            dept.ControlWidth = 192;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(355, 28);
            dept.Name = "dept";
            dept.Size = new Size(192, 21);
            dept.TabIndex = 0;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Dept";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 60;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1332, 638);
            g10.TabIndex = 0;
            // 
            // HR850
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR850";
            Size = new Size(1332, 694);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCTextBox dept;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCChkCodeBox s_emp_status;
        private Ctrls.UCTextBox emp;
        private Ctrls.UCDateBox res_to_date;
        private Ctrls.UCDateBox res_date;
        private Ctrls.UCChkCodeBox res_type;
    }
}
