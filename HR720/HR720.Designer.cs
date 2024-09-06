namespace EpicV004.Frms
{
    partial class HR720
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
            f_status = new Ctrls.UCCodeBox();
            f_emp = new Ctrls.UCTextBox();
            f_dept = new Ctrls.UCTextBox();
            s_to_dt = new Ctrls.UCDateBox();
            s_fr_dt = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            start_working_date = new Ctrls.UCDateBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            resign_date = new Ctrls.UCDateBox();
            memo = new Ctrls.UCTextBox();
            etc_deduction = new Ctrls.UCTextBox();
            loan_balance = new Ctrls.UCTextBox();
            dept = new Ctrls.UCTextBox();
            emp_no = new Ctrls.UCTextBox();
            salary_category = new Ctrls.UCCodeBox();
            resign_type = new Ctrls.UCCodeBox();
            position = new Ctrls.UCCodeBox();
            status = new Ctrls.UCCodeBox();
            severance_amt = new Ctrls.UCTextBox();
            severance_qty = new Ctrls.UCTextBox();
            salary_rate = new Ctrls.UCTextBox();
            emp_period = new Ctrls.UCTextBox();
            dept_name = new Ctrls.UCTextBox();
            emp_name = new Ctrls.UCTextBox();
            project = new Ctrls.UCTextBox();
            doc_no = new Ctrls.UCTextBox();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            g30 = new Ctrls.UCGridSet();
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
            ((System.ComponentModel.ISupportInitialize)ucSplit3).BeginInit();
            ucSplit3.Panel1.SuspendLayout();
            ucSplit3.Panel2.SuspendLayout();
            ucSplit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
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
            ucSplit1.Panel2.Controls.Add(ucSplit2);
            ucSplit1.Size = new Size(1353, 729);
            ucSplit1.SplitterDistance = 75;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(f_status);
            ucPanel1.Controls.Add(f_emp);
            ucPanel1.Controls.Add(f_dept);
            ucPanel1.Controls.Add(s_to_dt);
            ucPanel1.Controls.Add(s_fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1353, 75);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Apply Resign";
            // 
            // f_status
            // 
            f_status.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_status.Appearance.Options.UseFont = true;
            f_status.ControlHeight = 21;
            f_status.ControlWidth = 200;
            f_status.FldTy = null;
            f_status.FontColor = Color.Black;
            f_status.FontFace = "Tahoma";
            f_status.FontSize = 9F;
            f_status.Location = new Point(417, 26);
            f_status.Name = "f_status";
            f_status.Size = new Size(200, 21);
            f_status.TabIndex = 2;
            f_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_status.Title = "Status";
            f_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_status.TitleWidth = 93;
            // 
            // f_emp
            // 
            f_emp.Appearance.Font = new Font("Tahoma", 9F);
            f_emp.Appearance.Options.UseFont = true;
            f_emp.ControlHeight = 21;
            f_emp.ControlWidth = 200;
            f_emp.FontColor = Color.Black;
            f_emp.FontFace = "Tahoma";
            f_emp.FontSize = 9F;
            f_emp.FormatStr = "";
            f_emp.Location = new Point(211, 49);
            f_emp.Name = "f_emp";
            f_emp.Size = new Size(200, 21);
            f_emp.TabIndex = 1;
            f_emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_emp.Title = "Employee";
            f_emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_emp.TitleWidth = 93;
            // 
            // f_dept
            // 
            f_dept.Appearance.Font = new Font("Tahoma", 9F);
            f_dept.Appearance.Options.UseFont = true;
            f_dept.ControlHeight = 21;
            f_dept.ControlWidth = 200;
            f_dept.FontColor = Color.Black;
            f_dept.FontFace = "Tahoma";
            f_dept.FontSize = 9F;
            f_dept.FormatStr = "";
            f_dept.Location = new Point(211, 26);
            f_dept.Name = "f_dept";
            f_dept.Size = new Size(200, 21);
            f_dept.TabIndex = 1;
            f_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_dept.Title = "Dept";
            f_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_dept.TitleWidth = 93;
            // 
            // s_to_dt
            // 
            s_to_dt.ControlHeight = 21;
            s_to_dt.ControlWidth = 200;
            s_to_dt.Font = new Font("Tahoma", 9F);
            s_to_dt.FontColor = Color.Black;
            s_to_dt.FontFace = "Tahoma";
            s_to_dt.FontSize = 9F;
            s_to_dt.FormatStr = "";
            s_to_dt.Location = new Point(5, 49);
            s_to_dt.Name = "s_to_dt";
            s_to_dt.Size = new Size(200, 21);
            s_to_dt.TabIndex = 0;
            s_to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_to_dt.Title = "~";
            s_to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_to_dt.TitleWidth = 80;
            // 
            // s_fr_dt
            // 
            s_fr_dt.ControlHeight = 21;
            s_fr_dt.ControlWidth = 200;
            s_fr_dt.Font = new Font("Tahoma", 9F);
            s_fr_dt.FontColor = Color.Black;
            s_fr_dt.FontFace = "Tahoma";
            s_fr_dt.FontSize = 9F;
            s_fr_dt.FormatStr = "";
            s_fr_dt.Location = new Point(5, 26);
            s_fr_dt.Name = "s_fr_dt";
            s_fr_dt.Size = new Size(200, 21);
            s_fr_dt.TabIndex = 0;
            s_fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_fr_dt.Title = "Resign Date";
            s_fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_fr_dt.TitleWidth = 80;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(g10);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(ucSplit3);
            ucSplit2.Size = new Size(1353, 650);
            ucSplit2.SplitterDistance = 451;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(451, 650);
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
            ucSplit3.Panel2.Controls.Add(ucTab1);
            ucSplit3.Size = new Size(898, 650);
            ucSplit3.SplitterDistance = 349;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(start_working_date);
            ucPanel2.Controls.Add(checkBox1);
            ucPanel2.Controls.Add(label2);
            ucPanel2.Controls.Add(label1);
            ucPanel2.Controls.Add(resign_date);
            ucPanel2.Controls.Add(memo);
            ucPanel2.Controls.Add(etc_deduction);
            ucPanel2.Controls.Add(loan_balance);
            ucPanel2.Controls.Add(dept);
            ucPanel2.Controls.Add(emp_no);
            ucPanel2.Controls.Add(salary_category);
            ucPanel2.Controls.Add(resign_type);
            ucPanel2.Controls.Add(position);
            ucPanel2.Controls.Add(status);
            ucPanel2.Controls.Add(severance_amt);
            ucPanel2.Controls.Add(severance_qty);
            ucPanel2.Controls.Add(salary_rate);
            ucPanel2.Controls.Add(emp_period);
            ucPanel2.Controls.Add(dept_name);
            ucPanel2.Controls.Add(emp_name);
            ucPanel2.Controls.Add(project);
            ucPanel2.Controls.Add(doc_no);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(898, 349);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Resign Employee";
            // 
            // start_working_date
            // 
            start_working_date.ControlHeight = 21;
            start_working_date.ControlWidth = 249;
            start_working_date.FontColor = Color.Black;
            start_working_date.FontFace = "Tahoma";
            start_working_date.FontSize = 9F;
            start_working_date.FormatStr = "";
            start_working_date.Location = new Point(5, 142);
            start_working_date.Name = "start_working_date";
            start_working_date.Size = new Size(249, 21);
            start_working_date.TabIndex = 8;
            start_working_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            start_working_date.Title = "Start Work Dt";
            start_working_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            start_working_date.TitleWidth = 100;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Font = new Font("Tahoma", 9F);
            checkBox1.Location = new Point(355, 303);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 18);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "I agree to all of the above.";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(8, 282);
            label2.Name = "label2";
            label2.Size = new Size(533, 14);
            label2.TabIndex = 6;
            label2.Text = "deducting my outstanding wage for the last period for assets that I did not return to Company.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F);
            label1.Location = new Point(5, 264);
            label1.Name = "label1";
            label1.Size = new Size(576, 14);
            label1.TabIndex = 6;
            label1.Text = "I certified, I would not ask for any compensations or benefits in related to Labor Laws and accepted for";
            // 
            // resign_date
            // 
            resign_date.ControlHeight = 21;
            resign_date.ControlWidth = 248;
            resign_date.Font = new Font("Tahoma", 9F);
            resign_date.FontColor = Color.Black;
            resign_date.FontFace = "Tahoma";
            resign_date.FontSize = 9F;
            resign_date.FormatStr = "";
            resign_date.Location = new Point(260, 119);
            resign_date.Name = "resign_date";
            resign_date.Size = new Size(248, 21);
            resign_date.TabIndex = 4;
            resign_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            resign_date.Title = "Resign Date";
            resign_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            resign_date.TitleWidth = 100;
            // 
            // memo
            // 
            memo.ControlHeight = 21;
            memo.ControlWidth = 503;
            memo.FontColor = Color.Black;
            memo.FontFace = "Tahoma";
            memo.FontSize = 9F;
            memo.FormatStr = "";
            memo.Location = new Point(5, 240);
            memo.Name = "memo";
            memo.Size = new Size(503, 21);
            memo.TabIndex = 3;
            memo.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            memo.Title = "Memo";
            memo.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            memo.TitleWidth = 100;
            // 
            // etc_deduction
            // 
            etc_deduction.Appearance.Font = new Font("Tahoma", 9F);
            etc_deduction.Appearance.Options.UseFont = true;
            etc_deduction.ControlHeight = 21;
            etc_deduction.ControlWidth = 249;
            etc_deduction.FontColor = Color.Black;
            etc_deduction.FontFace = "Tahoma";
            etc_deduction.FontSize = 9F;
            etc_deduction.FormatStr = "";
            etc_deduction.Location = new Point(5, 213);
            etc_deduction.Name = "etc_deduction";
            etc_deduction.Size = new Size(249, 21);
            etc_deduction.TabIndex = 2;
            etc_deduction.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            etc_deduction.Title = "Etc Deduction";
            etc_deduction.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            etc_deduction.TitleWidth = 100;
            // 
            // loan_balance
            // 
            loan_balance.Appearance.Font = new Font("Tahoma", 9F);
            loan_balance.Appearance.Options.UseFont = true;
            loan_balance.ControlHeight = 21;
            loan_balance.ControlWidth = 249;
            loan_balance.FontColor = Color.Black;
            loan_balance.FontFace = "Tahoma";
            loan_balance.FontSize = 9F;
            loan_balance.FormatStr = "";
            loan_balance.Location = new Point(5, 190);
            loan_balance.Name = "loan_balance";
            loan_balance.Size = new Size(249, 21);
            loan_balance.TabIndex = 2;
            loan_balance.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            loan_balance.Title = "Loan Balance";
            loan_balance.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            loan_balance.TitleWidth = 100;
            // 
            // dept
            // 
            dept.Appearance.Font = new Font("Tahoma", 9F);
            dept.Appearance.Options.UseFont = true;
            dept.ControlHeight = 21;
            dept.ControlWidth = 249;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(5, 95);
            dept.Name = "dept";
            dept.Size = new Size(249, 21);
            dept.TabIndex = 2;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Dept";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 100;
            // 
            // emp_no
            // 
            emp_no.Appearance.Font = new Font("Tahoma", 9F);
            emp_no.Appearance.Options.UseFont = true;
            emp_no.ControlHeight = 21;
            emp_no.ControlWidth = 249;
            emp_no.FontColor = Color.Black;
            emp_no.FontFace = "Tahoma";
            emp_no.FontSize = 9F;
            emp_no.FormatStr = "";
            emp_no.Location = new Point(5, 72);
            emp_no.Name = "emp_no";
            emp_no.Size = new Size(249, 21);
            emp_no.TabIndex = 2;
            emp_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_no.Title = "Emp No";
            emp_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_no.TitleWidth = 100;
            // 
            // salary_category
            // 
            salary_category.Appearance.Font = new Font("Tahoma", 9F);
            salary_category.Appearance.Options.UseFont = true;
            salary_category.ControlHeight = 21;
            salary_category.ControlWidth = 249;
            salary_category.FldTy = null;
            salary_category.FontColor = Color.Black;
            salary_category.FontFace = "Tahoma";
            salary_category.FontSize = 9F;
            salary_category.Location = new Point(5, 167);
            salary_category.Name = "salary_category";
            salary_category.Size = new Size(249, 21);
            salary_category.TabIndex = 1;
            salary_category.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            salary_category.Title = "Salary Category";
            salary_category.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            salary_category.TitleWidth = 100;
            // 
            // resign_type
            // 
            resign_type.Appearance.Font = new Font("Tahoma", 9F);
            resign_type.Appearance.Options.UseFont = true;
            resign_type.ControlHeight = 21;
            resign_type.ControlWidth = 249;
            resign_type.FldTy = null;
            resign_type.FontColor = Color.Black;
            resign_type.FontFace = "Tahoma";
            resign_type.FontSize = 9F;
            resign_type.Location = new Point(5, 119);
            resign_type.Name = "resign_type";
            resign_type.Size = new Size(249, 21);
            resign_type.TabIndex = 1;
            resign_type.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            resign_type.Title = "Resign Type";
            resign_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            resign_type.TitleWidth = 100;
            // 
            // position
            // 
            position.Appearance.Font = new Font("Tahoma", 9F);
            position.Appearance.Options.UseFont = true;
            position.ControlHeight = 21;
            position.ControlWidth = 248;
            position.FldTy = null;
            position.FontColor = Color.Black;
            position.FontFace = "Tahoma";
            position.FontSize = 9F;
            position.Location = new Point(260, 48);
            position.Name = "position";
            position.Size = new Size(248, 21);
            position.TabIndex = 1;
            position.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            position.Title = "Position";
            position.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            position.TitleWidth = 100;
            // 
            // status
            // 
            status.Appearance.Font = new Font("Tahoma", 9F);
            status.Appearance.Options.UseFont = true;
            status.ControlHeight = 21;
            status.ControlWidth = 249;
            status.FldTy = null;
            status.FontColor = Color.Black;
            status.FontFace = "Tahoma";
            status.FontSize = 9F;
            status.Location = new Point(5, 48);
            status.Name = "status";
            status.Size = new Size(249, 21);
            status.TabIndex = 1;
            status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.Title = "Status";
            status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.TitleWidth = 100;
            // 
            // severance_amt
            // 
            severance_amt.Appearance.Font = new Font("Tahoma", 9F);
            severance_amt.Appearance.Options.UseFont = true;
            severance_amt.ControlHeight = 21;
            severance_amt.ControlWidth = 248;
            severance_amt.FontColor = Color.Black;
            severance_amt.FontFace = "Tahoma";
            severance_amt.FontSize = 9F;
            severance_amt.FormatStr = "";
            severance_amt.Location = new Point(260, 213);
            severance_amt.Name = "severance_amt";
            severance_amt.Size = new Size(248, 21);
            severance_amt.TabIndex = 0;
            severance_amt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            severance_amt.Title = "Severance Amt";
            severance_amt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            severance_amt.TitleWidth = 100;
            // 
            // severance_qty
            // 
            severance_qty.Appearance.Font = new Font("Tahoma", 9F);
            severance_qty.Appearance.Options.UseFont = true;
            severance_qty.ControlHeight = 21;
            severance_qty.ControlWidth = 248;
            severance_qty.FontColor = Color.Black;
            severance_qty.FontFace = "Tahoma";
            severance_qty.FontSize = 9F;
            severance_qty.FormatStr = "";
            severance_qty.Location = new Point(260, 190);
            severance_qty.Name = "severance_qty";
            severance_qty.Size = new Size(248, 21);
            severance_qty.TabIndex = 0;
            severance_qty.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            severance_qty.Title = "Severance Qty";
            severance_qty.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            severance_qty.TitleWidth = 100;
            // 
            // salary_rate
            // 
            salary_rate.Appearance.Font = new Font("Tahoma", 9F);
            salary_rate.Appearance.Options.UseFont = true;
            salary_rate.ControlHeight = 21;
            salary_rate.ControlWidth = 248;
            salary_rate.FontColor = Color.Black;
            salary_rate.FontFace = "Tahoma";
            salary_rate.FontSize = 9F;
            salary_rate.FormatStr = "";
            salary_rate.Location = new Point(260, 167);
            salary_rate.Name = "salary_rate";
            salary_rate.Size = new Size(248, 21);
            salary_rate.TabIndex = 0;
            salary_rate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            salary_rate.Title = "Salary Rate";
            salary_rate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            salary_rate.TitleWidth = 100;
            // 
            // emp_period
            // 
            emp_period.Appearance.Font = new Font("Tahoma", 9F);
            emp_period.Appearance.Options.UseFont = true;
            emp_period.ControlHeight = 21;
            emp_period.ControlWidth = 248;
            emp_period.FontColor = Color.Black;
            emp_period.FontFace = "Tahoma";
            emp_period.FontSize = 9F;
            emp_period.FormatStr = "";
            emp_period.Location = new Point(260, 143);
            emp_period.Name = "emp_period";
            emp_period.Size = new Size(248, 21);
            emp_period.TabIndex = 0;
            emp_period.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_period.Title = "Period";
            emp_period.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_period.TitleWidth = 100;
            // 
            // dept_name
            // 
            dept_name.Appearance.Font = new Font("Tahoma", 9F);
            dept_name.Appearance.Options.UseFont = true;
            dept_name.ControlHeight = 21;
            dept_name.ControlWidth = 248;
            dept_name.FontColor = Color.Black;
            dept_name.FontFace = "Tahoma";
            dept_name.FontSize = 9F;
            dept_name.FormatStr = "";
            dept_name.Location = new Point(260, 95);
            dept_name.Name = "dept_name";
            dept_name.Size = new Size(248, 21);
            dept_name.TabIndex = 0;
            dept_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.Title = "";
            dept_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.TitleWidth = 1;
            // 
            // emp_name
            // 
            emp_name.Appearance.Font = new Font("Tahoma", 9F);
            emp_name.Appearance.Options.UseFont = true;
            emp_name.ControlHeight = 21;
            emp_name.ControlWidth = 248;
            emp_name.FontColor = Color.Black;
            emp_name.FontFace = "Tahoma";
            emp_name.FontSize = 9F;
            emp_name.FormatStr = "";
            emp_name.Location = new Point(260, 72);
            emp_name.Name = "emp_name";
            emp_name.Size = new Size(248, 21);
            emp_name.TabIndex = 0;
            emp_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_name.Title = "";
            emp_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            emp_name.TitleWidth = 1;
            // 
            // project
            // 
            project.Appearance.Font = new Font("Tahoma", 9F);
            project.Appearance.Options.UseFont = true;
            project.ControlHeight = 21;
            project.ControlWidth = 248;
            project.FontColor = Color.Black;
            project.FontFace = "Tahoma";
            project.FontSize = 9F;
            project.FormatStr = "";
            project.Location = new Point(260, 26);
            project.Name = "project";
            project.Size = new Size(248, 21);
            project.TabIndex = 0;
            project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.Title = "Project";
            project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.TitleWidth = 100;
            // 
            // doc_no
            // 
            doc_no.Appearance.Font = new Font("Tahoma", 9F);
            doc_no.Appearance.Options.UseFont = true;
            doc_no.ControlHeight = 21;
            doc_no.ControlWidth = 249;
            doc_no.FontColor = Color.Black;
            doc_no.FontFace = "Tahoma";
            doc_no.FontSize = 9F;
            doc_no.FormatStr = "";
            doc_no.Location = new Point(5, 26);
            doc_no.Name = "doc_no";
            doc_no.Size = new Size(249, 21);
            doc_no.TabIndex = 0;
            doc_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            doc_no.Title = "DOC No";
            doc_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            doc_no.TitleWidth = 100;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(898, 297);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g20);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(896, 272);
            xtraTabPage1.TabPageWidth = 100;
            xtraTabPage1.Text = "Loan Balance";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(896, 272);
            g20.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g30);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(896, 272);
            xtraTabPage2.TabPageWidth = 100;
            xtraTabPage2.Text = "Tools";
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(896, 272);
            g30.TabIndex = 0;
            // 
            // HR720
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR720";
            Size = new Size(1353, 729);
            Load += UserControl1_Load;
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
            ucSplit3.Panel1.ResumeLayout(false);
            ucSplit3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit3).EndInit();
            ucSplit3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ucPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ucTab1).EndInit();
            ucTab1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCCodeBox f_status;
        private Ctrls.UCTextBox f_emp;
        private Ctrls.UCTextBox f_dept;
        private Ctrls.UCDateBox s_to_dt;
        private Ctrls.UCDateBox s_fr_dt;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCTextBox etc_deduction;
        private Ctrls.UCTextBox loan_balance;
        private Ctrls.UCTextBox dept;
        private Ctrls.UCTextBox emp_no;
        private Ctrls.UCCodeBox salary_category;
        private Ctrls.UCCodeBox resign_type;
        private Ctrls.UCCodeBox status;
        private Ctrls.UCTextBox doc_no;
        private Label label1;
        private Ctrls.UCDateBox resign_date;
        private Ctrls.UCTextBox memo;
        private Ctrls.UCCodeBox position;
        private Ctrls.UCTextBox severance_amt;
        private Ctrls.UCTextBox severance_qty;
        private Ctrls.UCTextBox salary_rate;
        private Ctrls.UCTextBox emp_period;
        private Ctrls.UCTextBox dept_name;
        private Ctrls.UCTextBox emp_name;
        private Ctrls.UCTextBox project;
        private Label label2;
        private CheckBox checkBox1;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Ctrls.UCGridSet g20;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCGridSet g30;
        private Ctrls.UCDateBox start_working_date;
    }
}
