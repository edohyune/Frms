namespace EpicV004.Frms
{
    partial class HR820
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
			leave = new Ctrls.UCTextBox();
			ealry = new Ctrls.UCTextBox();
			late = new Ctrls.UCTextBox();
			total = new Ctrls.UCTextBox();
			absent = new Ctrls.UCTextBox();
			work = new Ctrls.UCTextBox();
			std_td = new Ctrls.UCDateBox();
			to_date = new Ctrls.UCDateBox();
			date = new Ctrls.UCDateBox();
			s_emp_status = new Ctrls.UCChkCodeBox();
			emp = new Ctrls.UCTextBox();
			dept_name = new Ctrls.UCTextBox();
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
			ucSplit1.Size = new Size(1283, 616);
			ucSplit1.SplitterDistance = 78;
			ucSplit1.TabIndex = 0;
			ucSplit1.TitleWidth = 121;
			// 
			// ucPanel1
			// 
			ucPanel1.Controls.Add(leave);
			ucPanel1.Controls.Add(ealry);
			ucPanel1.Controls.Add(late);
			ucPanel1.Controls.Add(total);
			ucPanel1.Controls.Add(absent);
			ucPanel1.Controls.Add(work);
			ucPanel1.Controls.Add(std_td);
			ucPanel1.Controls.Add(to_date);
			ucPanel1.Controls.Add(date);
			ucPanel1.Controls.Add(s_emp_status);
			ucPanel1.Controls.Add(emp);
			ucPanel1.Controls.Add(dept_name);
			ucPanel1.Controls.Add(dept);
			ucPanel1.Dock = DockStyle.Fill;
			ucPanel1.Location = new Point(0, 0);
			ucPanel1.Name = "ucPanel1";
			ucPanel1.Size = new Size(1283, 78);
			ucPanel1.TabIndex = 0;
			ucPanel1.Text = "Attendance List";
			// 
			// leave
			// 
			leave.Appearance.Font = new Font("Tahoma", 9F);
			leave.Appearance.Options.UseFont = true;
			leave.ControlHeight = 23;
			leave.ControlWidth = 94;
			leave.FontColor = Color.Black;
			leave.FontFace = "Tahoma";
			leave.FontSize = 9F;
			leave.FormatStr = "";
			leave.Location = new Point(1070, 53);
			leave.Margin = new Padding(4, 3, 4, 3);
			leave.Name = "leave";
			leave.Size = new Size(94, 23);
			leave.TabIndex = 5;
			leave.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
			leave.Title = "Leave";
			leave.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			leave.TitleWidth = 50;
			// 
			// ealry
			// 
			ealry.Appearance.Font = new Font("Tahoma", 9F);
			ealry.Appearance.Options.UseFont = true;
			ealry.ControlHeight = 23;
			ealry.ControlWidth = 94;
			ealry.FontColor = Color.Black;
			ealry.FontFace = "Tahoma";
			ealry.FontSize = 9F;
			ealry.FormatStr = "";
			ealry.Location = new Point(968, 53);
			ealry.Margin = new Padding(4, 3, 4, 3);
			ealry.Name = "ealry";
			ealry.Size = new Size(94, 23);
			ealry.TabIndex = 5;
			ealry.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
			ealry.Title = "Ealry";
			ealry.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			ealry.TitleWidth = 50;
			// 
			// late
			// 
			late.Appearance.Font = new Font("Tahoma", 9F);
			late.Appearance.Options.UseFont = true;
			late.ControlHeight = 23;
			late.ControlWidth = 94;
			late.FontColor = Color.Black;
			late.FontFace = "Tahoma";
			late.FontSize = 9F;
			late.FormatStr = "";
			late.Location = new Point(866, 53);
			late.Margin = new Padding(4, 3, 4, 3);
			late.Name = "late";
			late.Size = new Size(94, 23);
			late.TabIndex = 5;
			late.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
			late.Title = "Late";
			late.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			late.TitleWidth = 50;
			// 
			// total
			// 
			total.Appearance.Font = new Font("Tahoma", 9F);
			total.Appearance.Options.UseFont = true;
			total.ControlHeight = 23;
			total.ControlWidth = 94;
			total.FontColor = Color.Black;
			total.FontFace = "Tahoma";
			total.FontSize = 9F;
			total.FormatStr = "";
			total.Location = new Point(1070, 28);
			total.Margin = new Padding(4, 3, 4, 3);
			total.Name = "total";
			total.Size = new Size(94, 23);
			total.TabIndex = 5;
			total.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
			total.Title = "Total";
			total.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			total.TitleWidth = 50;
			// 
			// absent
			// 
			absent.Appearance.Font = new Font("Tahoma", 9F);
			absent.Appearance.Options.UseFont = true;
			absent.ControlHeight = 23;
			absent.ControlWidth = 94;
			absent.FontColor = Color.Black;
			absent.FontFace = "Tahoma";
			absent.FontSize = 9F;
			absent.FormatStr = "";
			absent.Location = new Point(968, 28);
			absent.Margin = new Padding(4, 3, 4, 3);
			absent.Name = "absent";
			absent.Size = new Size(94, 23);
			absent.TabIndex = 5;
			absent.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
			absent.Title = "Absent";
			absent.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			absent.TitleWidth = 50;
			// 
			// work
			// 
			work.Appearance.Font = new Font("Tahoma", 9F);
			work.Appearance.Options.UseFont = true;
			work.ControlHeight = 23;
			work.ControlWidth = 94;
			work.FontColor = Color.Black;
			work.FontFace = "Tahoma";
			work.FontSize = 9F;
			work.FormatStr = "";
			work.Location = new Point(866, 28);
			work.Margin = new Padding(4, 3, 4, 3);
			work.Name = "work";
			work.Size = new Size(94, 23);
			work.TabIndex = 5;
			work.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
			work.Title = "Work";
			work.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			work.TitleWidth = 50;
			// 
			// std_td
			// 
			std_td.ControlHeight = 20;
			std_td.ControlWidth = 248;
			std_td.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			std_td.FontColor = Color.Black;
			std_td.FontFace = "Tahoma";
			std_td.FontSize = 9F;
			std_td.FormatStr = "";
			std_td.Location = new Point(611, 28);
			std_td.Name = "std_td";
			std_td.Size = new Size(248, 20);
			std_td.TabIndex = 4;
			std_td.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
			std_td.Title = "Date";
			std_td.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			std_td.TitleWidth = 100;
			// 
			// to_date
			// 
			to_date.ControlHeight = 21;
			to_date.ControlWidth = 192;
			to_date.FontColor = Color.Black;
			to_date.FontFace = "Tahoma";
			to_date.FontSize = 9F;
			to_date.FormatStr = "";
			to_date.Location = new Point(5, 53);
			to_date.Name = "to_date";
			to_date.Size = new Size(192, 21);
			to_date.TabIndex = 3;
			to_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
			to_date.Title = "~";
			to_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			to_date.TitleWidth = 100;
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
			date.Title = "Attendance Date";
			date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			date.TitleWidth = 100;
			// 
			// s_emp_status
			// 
			s_emp_status.Appearance.Font = new Font("Tahoma", 9F);
			s_emp_status.Appearance.Options.UseFont = true;
			s_emp_status.ControlHeight = 21;
			s_emp_status.ControlWidth = 248;
			s_emp_status.FontFace = "Tahoma";
			s_emp_status.FontSize = 9F;
			s_emp_status.Location = new Point(611, 53);
			s_emp_status.Name = "s_emp_status";
			s_emp_status.Size = new Size(248, 21);
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
			emp.ControlWidth = 402;
			emp.FontColor = Color.Black;
			emp.FontFace = "Tahoma";
			emp.FontSize = 9F;
			emp.FormatStr = "";
			emp.Location = new Point(203, 53);
			emp.Name = "emp";
			emp.Size = new Size(402, 21);
			emp.TabIndex = 0;
			emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
			emp.Title = "Employee";
			emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			emp.TitleWidth = 93;
			// 
			// dept_name
			// 
			dept_name.Appearance.Font = new Font("Tahoma", 9F);
			dept_name.Appearance.Options.UseFont = true;
			dept_name.ControlHeight = 21;
			dept_name.ControlWidth = 198;
			dept_name.FontColor = Color.Black;
			dept_name.FontFace = "Tahoma";
			dept_name.FontSize = 9F;
			dept_name.FormatStr = "";
			dept_name.Location = new Point(407, 28);
			dept_name.Name = "dept_name";
			dept_name.Size = new Size(198, 21);
			dept_name.TabIndex = 0;
			dept_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
			dept_name.Title = "";
			dept_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			dept_name.TitleWidth = 1;
			// 
			// dept
			// 
			dept.Appearance.Font = new Font("Tahoma", 9F);
			dept.Appearance.Options.UseFont = true;
			dept.ControlHeight = 21;
			dept.ControlWidth = 198;
			dept.FontColor = Color.Black;
			dept.FontFace = "Tahoma";
			dept.FontSize = 9F;
			dept.FormatStr = "";
			dept.Location = new Point(203, 28);
			dept.Name = "dept";
			dept.Size = new Size(198, 21);
			dept.TabIndex = 0;
			dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
			dept.Title = "Dept";
			dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
			dept.TitleWidth = 93;
			// 
			// g10
			// 
			g10.Dock = DockStyle.Fill;
			g10.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			g10.Location = new Point(0, 0);
			g10.Name = "g10";
			g10.Size = new Size(1283, 534);
			g10.TabIndex = 0;
			// 
			// HR820
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(ucSplit1);
			Name = "HR820";
			Size = new Size(1283, 616);
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
        private Ctrls.UCDateBox to_date;
        private Ctrls.UCDateBox date;
        private Ctrls.UCTextBox dept_name;
        private Ctrls.UCTextBox ealry;
        private Ctrls.UCTextBox late;
        private Ctrls.UCTextBox absent;
        private Ctrls.UCTextBox work;
        private Ctrls.UCDateBox std_td;
        private Ctrls.UCTextBox leave;
        private Ctrls.UCTextBox total;
    }
}
