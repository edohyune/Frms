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
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            ucButton2 = new Ctrls.UCButton();
            ucButton1 = new Ctrls.UCButton();
            ucDateBox3 = new Ctrls.UCDateBox();
            ucTextBox8 = new Ctrls.UCTextBox();
            ucTextBox7 = new Ctrls.UCTextBox();
            ucTextBox6 = new Ctrls.UCTextBox();
            ucTextBox5 = new Ctrls.UCTextBox();
            ucTextBox4 = new Ctrls.UCTextBox();
            ucCodeBox5 = new Ctrls.UCCodeBox();
            ucCodeBox4 = new Ctrls.UCCodeBox();
            ucCodeBox3 = new Ctrls.UCCodeBox();
            ucCodeBox6 = new Ctrls.UCCodeBox();
            ucCodeBox2 = new Ctrls.UCCodeBox();
            ucTextBox15 = new Ctrls.UCTextBox();
            ucTextBox14 = new Ctrls.UCTextBox();
            ucTextBox13 = new Ctrls.UCTextBox();
            ucTextBox12 = new Ctrls.UCTextBox();
            ucTextBox11 = new Ctrls.UCTextBox();
            ucTextBox10 = new Ctrls.UCTextBox();
            ucTextBox9 = new Ctrls.UCTextBox();
            ucTextBox3 = new Ctrls.UCTextBox();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ucGridSet2 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ucGridSet3 = new Ctrls.UCGridSet();
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
            ucPanel2.Controls.Add(checkBox1);
            ucPanel2.Controls.Add(label2);
            ucPanel2.Controls.Add(label1);
            ucPanel2.Controls.Add(ucButton2);
            ucPanel2.Controls.Add(ucButton1);
            ucPanel2.Controls.Add(ucDateBox3);
            ucPanel2.Controls.Add(ucTextBox8);
            ucPanel2.Controls.Add(ucTextBox7);
            ucPanel2.Controls.Add(ucTextBox6);
            ucPanel2.Controls.Add(ucTextBox5);
            ucPanel2.Controls.Add(ucTextBox4);
            ucPanel2.Controls.Add(ucCodeBox5);
            ucPanel2.Controls.Add(ucCodeBox4);
            ucPanel2.Controls.Add(ucCodeBox3);
            ucPanel2.Controls.Add(ucCodeBox6);
            ucPanel2.Controls.Add(ucCodeBox2);
            ucPanel2.Controls.Add(ucTextBox15);
            ucPanel2.Controls.Add(ucTextBox14);
            ucPanel2.Controls.Add(ucTextBox13);
            ucPanel2.Controls.Add(ucTextBox12);
            ucPanel2.Controls.Add(ucTextBox11);
            ucPanel2.Controls.Add(ucTextBox10);
            ucPanel2.Controls.Add(ucTextBox9);
            ucPanel2.Controls.Add(ucTextBox3);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(898, 349);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Resign Employee";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(355, 303);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(156, 17);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "I agree to all of the above.";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 282);
            label2.Name = "label2";
            label2.Size = new Size(464, 13);
            label2.TabIndex = 6;
            label2.Text = "deducting my outstanding wage for the last period for assets that I did not return to Company.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 264);
            label1.Name = "label1";
            label1.Size = new Size(503, 13);
            label1.TabIndex = 6;
            label1.Text = "I certified, I would not ask for any compensations or benefits in related to Labor Laws and accepted for";
            // 
            // ucButton2
            // 
            ucButton2.Appearance.Font = new Font("Tahoma", 9F);
            ucButton2.Appearance.Options.UseFont = true;
            ucButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton2.ControlHeight = 45;
            ucButton2.ControlWidth = 130;
            ucButton2.FontBold = FontStyle.Regular;
            ucButton2.FontFace = "Tahoma";
            ucButton2.FontSize = 9F;
            ucButton2.Location = new Point(514, 119);
            ucButton2.Name = "ucButton2";
            ucButton2.Size = new Size(130, 45);
            ucButton2.TabIndex = 5;
            ucButton2.Title = "Viewer";
            ucButton2.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucButton1
            // 
            ucButton1.Appearance.Font = new Font("Tahoma", 9F);
            ucButton1.Appearance.Options.UseFont = true;
            ucButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton1.ControlHeight = 43;
            ucButton1.ControlWidth = 130;
            ucButton1.FontBold = FontStyle.Regular;
            ucButton1.FontFace = "Tahoma";
            ucButton1.FontSize = 9F;
            ucButton1.Location = new Point(514, 26);
            ucButton1.Name = "ucButton1";
            ucButton1.Size = new Size(130, 43);
            ucButton1.TabIndex = 5;
            ucButton1.Title = "Submit (Groupware)";
            ucButton1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucDateBox3
            // 
            ucDateBox3.ControlHeight = 21;
            ucDateBox3.ControlWidth = 248;
            ucDateBox3.Font = new Font("Tahoma", 9F);
            ucDateBox3.FontColor = Color.Black;
            ucDateBox3.FontFace = "Tahoma";
            ucDateBox3.FontSize = 9F;
            ucDateBox3.FormatStr = "";
            ucDateBox3.Location = new Point(260, 119);
            ucDateBox3.Name = "ucDateBox3";
            ucDateBox3.Size = new Size(248, 21);
            ucDateBox3.TabIndex = 4;
            ucDateBox3.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox3.Title = "Resign Date";
            ucDateBox3.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox3.TitleWidth = 100;
            // 
            // ucTextBox8
            // 
            ucTextBox8.ControlHeight = 21;
            ucTextBox8.ControlWidth = 503;
            ucTextBox8.FontColor = Color.Black;
            ucTextBox8.FontFace = "Tahoma";
            ucTextBox8.FontSize = 9F;
            ucTextBox8.FormatStr = "";
            ucTextBox8.Location = new Point(5, 240);
            ucTextBox8.Name = "ucTextBox8";
            ucTextBox8.Size = new Size(503, 21);
            ucTextBox8.TabIndex = 3;
            ucTextBox8.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox8.Title = "Memo";
            ucTextBox8.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox8.TitleWidth = 100;
            // 
            // ucTextBox7
            // 
            ucTextBox7.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox7.Appearance.Options.UseFont = true;
            ucTextBox7.ControlHeight = 21;
            ucTextBox7.ControlWidth = 249;
            ucTextBox7.FontColor = Color.Black;
            ucTextBox7.FontFace = "Tahoma";
            ucTextBox7.FontSize = 9F;
            ucTextBox7.FormatStr = "";
            ucTextBox7.Location = new Point(5, 213);
            ucTextBox7.Name = "ucTextBox7";
            ucTextBox7.Size = new Size(249, 21);
            ucTextBox7.TabIndex = 2;
            ucTextBox7.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox7.Title = "Etc Deduction";
            ucTextBox7.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox7.TitleWidth = 100;
            // 
            // ucTextBox6
            // 
            ucTextBox6.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox6.Appearance.Options.UseFont = true;
            ucTextBox6.ControlHeight = 21;
            ucTextBox6.ControlWidth = 249;
            ucTextBox6.FontColor = Color.Black;
            ucTextBox6.FontFace = "Tahoma";
            ucTextBox6.FontSize = 9F;
            ucTextBox6.FormatStr = "";
            ucTextBox6.Location = new Point(5, 190);
            ucTextBox6.Name = "ucTextBox6";
            ucTextBox6.Size = new Size(249, 21);
            ucTextBox6.TabIndex = 2;
            ucTextBox6.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox6.Title = "Loan Balance";
            ucTextBox6.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox6.TitleWidth = 100;
            // 
            // ucTextBox5
            // 
            ucTextBox5.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox5.Appearance.Options.UseFont = true;
            ucTextBox5.ControlHeight = 21;
            ucTextBox5.ControlWidth = 249;
            ucTextBox5.FontColor = Color.Black;
            ucTextBox5.FontFace = "Tahoma";
            ucTextBox5.FontSize = 9F;
            ucTextBox5.FormatStr = "";
            ucTextBox5.Location = new Point(5, 95);
            ucTextBox5.Name = "ucTextBox5";
            ucTextBox5.Size = new Size(249, 21);
            ucTextBox5.TabIndex = 2;
            ucTextBox5.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox5.Title = "Dept";
            ucTextBox5.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox5.TitleWidth = 100;
            // 
            // ucTextBox4
            // 
            ucTextBox4.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox4.Appearance.Options.UseFont = true;
            ucTextBox4.ControlHeight = 21;
            ucTextBox4.ControlWidth = 249;
            ucTextBox4.FontColor = Color.Black;
            ucTextBox4.FontFace = "Tahoma";
            ucTextBox4.FontSize = 9F;
            ucTextBox4.FormatStr = "";
            ucTextBox4.Location = new Point(5, 72);
            ucTextBox4.Name = "ucTextBox4";
            ucTextBox4.Size = new Size(249, 21);
            ucTextBox4.TabIndex = 2;
            ucTextBox4.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox4.Title = "Emp No";
            ucTextBox4.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox4.TitleWidth = 100;
            // 
            // ucCodeBox5
            // 
            ucCodeBox5.Appearance.Font = new Font("Tahoma", 9F);
            ucCodeBox5.Appearance.Options.UseFont = true;
            ucCodeBox5.ControlHeight = 21;
            ucCodeBox5.ControlWidth = 249;
            ucCodeBox5.FldTy = null;
            ucCodeBox5.FontColor = Color.Black;
            ucCodeBox5.FontFace = "Tahoma";
            ucCodeBox5.FontSize = 9F;
            ucCodeBox5.Location = new Point(5, 167);
            ucCodeBox5.Name = "ucCodeBox5";
            ucCodeBox5.Size = new Size(249, 21);
            ucCodeBox5.TabIndex = 1;
            ucCodeBox5.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox5.Title = "Salary Category";
            ucCodeBox5.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox5.TitleWidth = 100;
            // 
            // ucCodeBox4
            // 
            ucCodeBox4.Appearance.Font = new Font("Tahoma", 9F);
            ucCodeBox4.Appearance.Options.UseFont = true;
            ucCodeBox4.ControlHeight = 21;
            ucCodeBox4.ControlWidth = 249;
            ucCodeBox4.FldTy = null;
            ucCodeBox4.FontColor = Color.Black;
            ucCodeBox4.FontFace = "Tahoma";
            ucCodeBox4.FontSize = 9F;
            ucCodeBox4.Location = new Point(5, 143);
            ucCodeBox4.Name = "ucCodeBox4";
            ucCodeBox4.Size = new Size(249, 21);
            ucCodeBox4.TabIndex = 1;
            ucCodeBox4.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox4.Title = "Start Work Dt";
            ucCodeBox4.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox4.TitleWidth = 100;
            // 
            // ucCodeBox3
            // 
            ucCodeBox3.Appearance.Font = new Font("Tahoma", 9F);
            ucCodeBox3.Appearance.Options.UseFont = true;
            ucCodeBox3.ControlHeight = 21;
            ucCodeBox3.ControlWidth = 249;
            ucCodeBox3.FldTy = null;
            ucCodeBox3.FontColor = Color.Black;
            ucCodeBox3.FontFace = "Tahoma";
            ucCodeBox3.FontSize = 9F;
            ucCodeBox3.Location = new Point(5, 119);
            ucCodeBox3.Name = "ucCodeBox3";
            ucCodeBox3.Size = new Size(249, 21);
            ucCodeBox3.TabIndex = 1;
            ucCodeBox3.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            ucCodeBox3.Title = "Resign Type";
            ucCodeBox3.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox3.TitleWidth = 100;
            // 
            // ucCodeBox6
            // 
            ucCodeBox6.Appearance.Font = new Font("Tahoma", 9F);
            ucCodeBox6.Appearance.Options.UseFont = true;
            ucCodeBox6.ControlHeight = 21;
            ucCodeBox6.ControlWidth = 248;
            ucCodeBox6.FldTy = null;
            ucCodeBox6.FontColor = Color.Black;
            ucCodeBox6.FontFace = "Tahoma";
            ucCodeBox6.FontSize = 9F;
            ucCodeBox6.Location = new Point(260, 48);
            ucCodeBox6.Name = "ucCodeBox6";
            ucCodeBox6.Size = new Size(248, 21);
            ucCodeBox6.TabIndex = 1;
            ucCodeBox6.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox6.Title = "Position";
            ucCodeBox6.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox6.TitleWidth = 100;
            // 
            // ucCodeBox2
            // 
            ucCodeBox2.Appearance.Font = new Font("Tahoma", 9F);
            ucCodeBox2.Appearance.Options.UseFont = true;
            ucCodeBox2.ControlHeight = 21;
            ucCodeBox2.ControlWidth = 249;
            ucCodeBox2.FldTy = null;
            ucCodeBox2.FontColor = Color.Black;
            ucCodeBox2.FontFace = "Tahoma";
            ucCodeBox2.FontSize = 9F;
            ucCodeBox2.Location = new Point(5, 48);
            ucCodeBox2.Name = "ucCodeBox2";
            ucCodeBox2.Size = new Size(249, 21);
            ucCodeBox2.TabIndex = 1;
            ucCodeBox2.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox2.Title = "Status";
            ucCodeBox2.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox2.TitleWidth = 100;
            // 
            // ucTextBox15
            // 
            ucTextBox15.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox15.Appearance.Options.UseFont = true;
            ucTextBox15.ControlHeight = 21;
            ucTextBox15.ControlWidth = 248;
            ucTextBox15.FontColor = Color.Black;
            ucTextBox15.FontFace = "Tahoma";
            ucTextBox15.FontSize = 9F;
            ucTextBox15.FormatStr = "";
            ucTextBox15.Location = new Point(260, 213);
            ucTextBox15.Name = "ucTextBox15";
            ucTextBox15.Size = new Size(248, 21);
            ucTextBox15.TabIndex = 0;
            ucTextBox15.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox15.Title = "Severance Amt";
            ucTextBox15.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox15.TitleWidth = 100;
            // 
            // ucTextBox14
            // 
            ucTextBox14.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox14.Appearance.Options.UseFont = true;
            ucTextBox14.ControlHeight = 21;
            ucTextBox14.ControlWidth = 248;
            ucTextBox14.FontColor = Color.Black;
            ucTextBox14.FontFace = "Tahoma";
            ucTextBox14.FontSize = 9F;
            ucTextBox14.FormatStr = "";
            ucTextBox14.Location = new Point(260, 190);
            ucTextBox14.Name = "ucTextBox14";
            ucTextBox14.Size = new Size(248, 21);
            ucTextBox14.TabIndex = 0;
            ucTextBox14.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox14.Title = "Severance Qty";
            ucTextBox14.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox14.TitleWidth = 100;
            // 
            // ucTextBox13
            // 
            ucTextBox13.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox13.Appearance.Options.UseFont = true;
            ucTextBox13.ControlHeight = 21;
            ucTextBox13.ControlWidth = 248;
            ucTextBox13.FontColor = Color.Black;
            ucTextBox13.FontFace = "Tahoma";
            ucTextBox13.FontSize = 9F;
            ucTextBox13.FormatStr = "";
            ucTextBox13.Location = new Point(260, 167);
            ucTextBox13.Name = "ucTextBox13";
            ucTextBox13.Size = new Size(248, 21);
            ucTextBox13.TabIndex = 0;
            ucTextBox13.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox13.Title = "Salary Rate";
            ucTextBox13.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox13.TitleWidth = 100;
            // 
            // ucTextBox12
            // 
            ucTextBox12.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox12.Appearance.Options.UseFont = true;
            ucTextBox12.ControlHeight = 21;
            ucTextBox12.ControlWidth = 248;
            ucTextBox12.FontColor = Color.Black;
            ucTextBox12.FontFace = "Tahoma";
            ucTextBox12.FontSize = 9F;
            ucTextBox12.FormatStr = "";
            ucTextBox12.Location = new Point(260, 143);
            ucTextBox12.Name = "ucTextBox12";
            ucTextBox12.Size = new Size(248, 21);
            ucTextBox12.TabIndex = 0;
            ucTextBox12.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox12.Title = "Period";
            ucTextBox12.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox12.TitleWidth = 100;
            // 
            // ucTextBox11
            // 
            ucTextBox11.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox11.Appearance.Options.UseFont = true;
            ucTextBox11.ControlHeight = 21;
            ucTextBox11.ControlWidth = 248;
            ucTextBox11.FontColor = Color.Black;
            ucTextBox11.FontFace = "Tahoma";
            ucTextBox11.FontSize = 9F;
            ucTextBox11.FormatStr = "";
            ucTextBox11.Location = new Point(260, 95);
            ucTextBox11.Name = "ucTextBox11";
            ucTextBox11.Size = new Size(248, 21);
            ucTextBox11.TabIndex = 0;
            ucTextBox11.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox11.Title = "";
            ucTextBox11.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox11.TitleWidth = 1;
            // 
            // ucTextBox10
            // 
            ucTextBox10.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox10.Appearance.Options.UseFont = true;
            ucTextBox10.ControlHeight = 21;
            ucTextBox10.ControlWidth = 248;
            ucTextBox10.FontColor = Color.Black;
            ucTextBox10.FontFace = "Tahoma";
            ucTextBox10.FontSize = 9F;
            ucTextBox10.FormatStr = "";
            ucTextBox10.Location = new Point(260, 72);
            ucTextBox10.Name = "ucTextBox10";
            ucTextBox10.Size = new Size(248, 21);
            ucTextBox10.TabIndex = 0;
            ucTextBox10.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox10.Title = "";
            ucTextBox10.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox10.TitleWidth = 1;
            // 
            // ucTextBox9
            // 
            ucTextBox9.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox9.Appearance.Options.UseFont = true;
            ucTextBox9.ControlHeight = 21;
            ucTextBox9.ControlWidth = 248;
            ucTextBox9.FontColor = Color.Black;
            ucTextBox9.FontFace = "Tahoma";
            ucTextBox9.FontSize = 9F;
            ucTextBox9.FormatStr = "";
            ucTextBox9.Location = new Point(260, 26);
            ucTextBox9.Name = "ucTextBox9";
            ucTextBox9.Size = new Size(248, 21);
            ucTextBox9.TabIndex = 0;
            ucTextBox9.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox9.Title = "Project";
            ucTextBox9.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox9.TitleWidth = 100;
            // 
            // ucTextBox3
            // 
            ucTextBox3.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox3.Appearance.Options.UseFont = true;
            ucTextBox3.ControlHeight = 21;
            ucTextBox3.ControlWidth = 249;
            ucTextBox3.FontColor = Color.Black;
            ucTextBox3.FontFace = "Tahoma";
            ucTextBox3.FontSize = 9F;
            ucTextBox3.FormatStr = "";
            ucTextBox3.Location = new Point(5, 26);
            ucTextBox3.Name = "ucTextBox3";
            ucTextBox3.Size = new Size(249, 21);
            ucTextBox3.TabIndex = 0;
            ucTextBox3.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox3.Title = "DOC No";
            ucTextBox3.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox3.TitleWidth = 100;
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
            xtraTabPage1.Controls.Add(ucGridSet2);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(896, 272);
            xtraTabPage1.TabPageWidth = 100;
            xtraTabPage1.Text = "Loan Balance";
            // 
            // ucGridSet2
            // 
            ucGridSet2.Dock = DockStyle.Fill;
            ucGridSet2.Location = new Point(0, 0);
            ucGridSet2.Name = "ucGridSet2";
            ucGridSet2.Size = new Size(896, 272);
            ucGridSet2.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(ucGridSet3);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(896, 272);
            xtraTabPage2.TabPageWidth = 100;
            xtraTabPage2.Text = "Tools";
            // 
            // ucGridSet3
            // 
            ucGridSet3.Dock = DockStyle.Fill;
            ucGridSet3.Location = new Point(0, 0);
            ucGridSet3.Name = "ucGridSet3";
            ucGridSet3.Size = new Size(896, 272);
            ucGridSet3.TabIndex = 0;
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
        private Ctrls.UCTextBox ucTextBox7;
        private Ctrls.UCTextBox ucTextBox6;
        private Ctrls.UCTextBox ucTextBox5;
        private Ctrls.UCTextBox ucTextBox4;
        private Ctrls.UCCodeBox ucCodeBox5;
        private Ctrls.UCCodeBox ucCodeBox4;
        private Ctrls.UCCodeBox ucCodeBox3;
        private Ctrls.UCCodeBox ucCodeBox2;
        private Ctrls.UCTextBox ucTextBox3;
        private Label label1;
        private Ctrls.UCButton ucButton2;
        private Ctrls.UCButton ucButton1;
        private Ctrls.UCDateBox ucDateBox3;
        private Ctrls.UCTextBox ucTextBox8;
        private Ctrls.UCCodeBox ucCodeBox6;
        private Ctrls.UCTextBox ucTextBox15;
        private Ctrls.UCTextBox ucTextBox14;
        private Ctrls.UCTextBox ucTextBox13;
        private Ctrls.UCTextBox ucTextBox12;
        private Ctrls.UCTextBox ucTextBox11;
        private Ctrls.UCTextBox ucTextBox10;
        private Ctrls.UCTextBox ucTextBox9;
        private Label label2;
        private CheckBox checkBox1;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Ctrls.UCGridSet ucGridSet2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCGridSet ucGridSet3;
    }
}
