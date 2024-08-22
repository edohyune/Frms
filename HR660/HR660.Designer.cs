namespace EpicV004.Frms
{
    partial class HR660
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
            g10 = new Ctrls.UCGridSet();
            s_year = new Ctrls.UCDateBox();
            ucPanel2 = new Ctrls.UCPanel();
            groupBox2 = new GroupBox();
            ucButton3 = new Ctrls.UCButton();
            ucButton2 = new Ctrls.UCButton();
            ucButton6 = new Ctrls.UCButton();
            ucButton5 = new Ctrls.UCButton();
            ucButton4 = new Ctrls.UCButton();
            ucButton1 = new Ctrls.UCButton();
            ucTextBox9 = new Ctrls.UCTextBox();
            ucTextBox6 = new Ctrls.UCTextBox();
            ucTextBox8 = new Ctrls.UCTextBox();
            ucTextBox5 = new Ctrls.UCTextBox();
            ucTextBox7 = new Ctrls.UCTextBox();
            ucTextBox4 = new Ctrls.UCTextBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            calc_salary_date = new Ctrls.UCTextBox();
            add_ded_date = new Ctrls.UCTextBox();
            att_summ_date = new Ctrls.UCTextBox();
            groupBox1 = new GroupBox();
            prp_en_date = new Ctrls.UCTextBox();
            prp_st_date = new Ctrls.UCTextBox();
            prp_pay_ty = new Ctrls.UCCodeBox();
            prp_paydate = new Ctrls.UCTextBox();
            paymon = new Ctrls.UCTextBox();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            ucSplit1.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucPanel2);
            ucSplit1.Size = new Size(1184, 578);
            ucSplit1.SplitterDistance = 498;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(g10);
            ucPanel1.Controls.Add(s_year);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(498, 578);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Payment Day";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(494, 553);
            g10.TabIndex = 1;
            // 
            // s_year
            // 
            s_year.ControlHeight = 21;
            s_year.ControlWidth = 152;
            s_year.FontColor = Color.Black;
            s_year.FontFace = "Tahoma";
            s_year.FontSize = 9F;
            s_year.FormatStr = "";
            s_year.Location = new Point(124, 1);
            s_year.Name = "s_year";
            s_year.Size = new Size(152, 21);
            s_year.TabIndex = 0;
            s_year.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.Title = "Year";
            s_year.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.TitleWidth = 50;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(groupBox2);
            ucPanel2.Controls.Add(groupBox1);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(682, 578);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Payment Calculation Step";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ucButton3);
            groupBox2.Controls.Add(ucButton2);
            groupBox2.Controls.Add(ucButton6);
            groupBox2.Controls.Add(ucButton5);
            groupBox2.Controls.Add(ucButton4);
            groupBox2.Controls.Add(ucButton1);
            groupBox2.Controls.Add(ucTextBox9);
            groupBox2.Controls.Add(ucTextBox6);
            groupBox2.Controls.Add(ucTextBox8);
            groupBox2.Controls.Add(ucTextBox5);
            groupBox2.Controls.Add(ucTextBox7);
            groupBox2.Controls.Add(ucTextBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(calc_salary_date);
            groupBox2.Controls.Add(add_ded_date);
            groupBox2.Controls.Add(att_summ_date);
            groupBox2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(16, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(639, 186);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Step";
            // 
            // ucButton3
            // 
            ucButton3.Appearance.BackColor = Color.DarkGray;
            ucButton3.Appearance.Font = new Font("Tahoma", 9F);
            ucButton3.Appearance.Options.UseBackColor = true;
            ucButton3.Appearance.Options.UseFont = true;
            ucButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton3.ControlHeight = 30;
            ucButton3.ControlWidth = 59;
            ucButton3.FontBold = FontStyle.Regular;
            ucButton3.FontFace = "Tahoma";
            ucButton3.FontSize = 9F;
            ucButton3.Location = new Point(458, 129);
            ucButton3.Name = "ucButton3";
            ucButton3.Size = new Size(59, 30);
            ucButton3.TabIndex = 6;
            ucButton3.Title = "Work";
            ucButton3.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucButton2
            // 
            ucButton2.Appearance.BackColor = Color.DarkGray;
            ucButton2.Appearance.Font = new Font("Tahoma", 9F);
            ucButton2.Appearance.Options.UseBackColor = true;
            ucButton2.Appearance.Options.UseFont = true;
            ucButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton2.ControlHeight = 30;
            ucButton2.ControlWidth = 59;
            ucButton2.FontBold = FontStyle.Regular;
            ucButton2.FontFace = "Tahoma";
            ucButton2.FontSize = 9F;
            ucButton2.Location = new Point(458, 90);
            ucButton2.Name = "ucButton2";
            ucButton2.Size = new Size(59, 30);
            ucButton2.TabIndex = 6;
            ucButton2.Title = "Work";
            ucButton2.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucButton6
            // 
            ucButton6.Appearance.BackColor = Color.DarkGray;
            ucButton6.Appearance.Font = new Font("Tahoma", 9F);
            ucButton6.Appearance.Options.UseBackColor = true;
            ucButton6.Appearance.Options.UseFont = true;
            ucButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton6.ControlHeight = 30;
            ucButton6.ControlWidth = 94;
            ucButton6.FontBold = FontStyle.Regular;
            ucButton6.FontFace = "Tahoma";
            ucButton6.FontSize = 9F;
            ucButton6.Location = new Point(525, 129);
            ucButton6.Name = "ucButton6";
            ucButton6.Size = new Size(94, 30);
            ucButton6.TabIndex = 6;
            ucButton6.Title = "Jump to form";
            ucButton6.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucButton5
            // 
            ucButton5.Appearance.BackColor = Color.DarkGray;
            ucButton5.Appearance.Font = new Font("Tahoma", 9F);
            ucButton5.Appearance.Options.UseBackColor = true;
            ucButton5.Appearance.Options.UseFont = true;
            ucButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton5.ControlHeight = 30;
            ucButton5.ControlWidth = 94;
            ucButton5.FontBold = FontStyle.Regular;
            ucButton5.FontFace = "Tahoma";
            ucButton5.FontSize = 9F;
            ucButton5.Location = new Point(525, 90);
            ucButton5.Name = "ucButton5";
            ucButton5.Size = new Size(94, 30);
            ucButton5.TabIndex = 6;
            ucButton5.Title = "Jump to form";
            ucButton5.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucButton4
            // 
            ucButton4.Appearance.BackColor = Color.DarkGray;
            ucButton4.Appearance.Font = new Font("Tahoma", 9F);
            ucButton4.Appearance.Options.UseBackColor = true;
            ucButton4.Appearance.Options.UseFont = true;
            ucButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton4.ControlHeight = 30;
            ucButton4.ControlWidth = 94;
            ucButton4.FontBold = FontStyle.Regular;
            ucButton4.FontFace = "Tahoma";
            ucButton4.FontSize = 9F;
            ucButton4.Location = new Point(525, 54);
            ucButton4.Name = "ucButton4";
            ucButton4.Size = new Size(94, 30);
            ucButton4.TabIndex = 6;
            ucButton4.Title = "Jump to form";
            ucButton4.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucButton1
            // 
            ucButton1.Appearance.BackColor = Color.DarkGray;
            ucButton1.Appearance.Font = new Font("Tahoma", 9F);
            ucButton1.Appearance.Options.UseBackColor = true;
            ucButton1.Appearance.Options.UseFont = true;
            ucButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton1.ControlHeight = 30;
            ucButton1.ControlWidth = 59;
            ucButton1.FontBold = FontStyle.Regular;
            ucButton1.FontFace = "Tahoma";
            ucButton1.FontSize = 9F;
            ucButton1.Location = new Point(458, 54);
            ucButton1.Name = "ucButton1";
            ucButton1.Size = new Size(59, 30);
            ucButton1.TabIndex = 6;
            ucButton1.Title = "Work";
            ucButton1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucTextBox9
            // 
            ucTextBox9.ControlHeight = 21;
            ucTextBox9.ControlWidth = 71;
            ucTextBox9.FontColor = Color.Black;
            ucTextBox9.FontFace = "Tahoma";
            ucTextBox9.FontSize = 9F;
            ucTextBox9.FormatStr = "";
            ucTextBox9.Location = new Point(374, 136);
            ucTextBox9.Name = "ucTextBox9";
            ucTextBox9.Size = new Size(71, 21);
            ucTextBox9.TabIndex = 5;
            ucTextBox9.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox9.Title = "/";
            ucTextBox9.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox9.TitleWidth = 20;
            // 
            // ucTextBox6
            // 
            ucTextBox6.ControlHeight = 21;
            ucTextBox6.ControlWidth = 51;
            ucTextBox6.FontColor = Color.Black;
            ucTextBox6.FontFace = "Tahoma";
            ucTextBox6.FontSize = 9F;
            ucTextBox6.FormatStr = "";
            ucTextBox6.Location = new Point(310, 136);
            ucTextBox6.Name = "ucTextBox6";
            ucTextBox6.Size = new Size(51, 21);
            ucTextBox6.TabIndex = 5;
            ucTextBox6.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox6.Title = "UCTextBox";
            ucTextBox6.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox6.TitleWidth = 0;
            // 
            // ucTextBox8
            // 
            ucTextBox8.ControlHeight = 21;
            ucTextBox8.ControlWidth = 71;
            ucTextBox8.FontColor = Color.Black;
            ucTextBox8.FontFace = "Tahoma";
            ucTextBox8.FontSize = 9F;
            ucTextBox8.FormatStr = "";
            ucTextBox8.Location = new Point(374, 97);
            ucTextBox8.Name = "ucTextBox8";
            ucTextBox8.Size = new Size(71, 21);
            ucTextBox8.TabIndex = 5;
            ucTextBox8.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox8.Title = "/";
            ucTextBox8.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox8.TitleWidth = 20;
            // 
            // ucTextBox5
            // 
            ucTextBox5.ControlHeight = 21;
            ucTextBox5.ControlWidth = 51;
            ucTextBox5.FontColor = Color.Black;
            ucTextBox5.FontFace = "Tahoma";
            ucTextBox5.FontSize = 9F;
            ucTextBox5.FormatStr = "";
            ucTextBox5.Location = new Point(310, 97);
            ucTextBox5.Name = "ucTextBox5";
            ucTextBox5.Size = new Size(51, 21);
            ucTextBox5.TabIndex = 5;
            ucTextBox5.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox5.Title = "UCTextBox";
            ucTextBox5.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox5.TitleWidth = 0;
            // 
            // ucTextBox7
            // 
            ucTextBox7.ControlHeight = 21;
            ucTextBox7.ControlWidth = 71;
            ucTextBox7.FontColor = Color.Black;
            ucTextBox7.FontFace = "Tahoma";
            ucTextBox7.FontSize = 9F;
            ucTextBox7.FormatStr = "";
            ucTextBox7.Location = new Point(374, 58);
            ucTextBox7.Name = "ucTextBox7";
            ucTextBox7.Size = new Size(71, 21);
            ucTextBox7.TabIndex = 5;
            ucTextBox7.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox7.Title = "/";
            ucTextBox7.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox7.TitleWidth = 20;
            // 
            // ucTextBox4
            // 
            ucTextBox4.ControlHeight = 21;
            ucTextBox4.ControlWidth = 51;
            ucTextBox4.FontColor = Color.Black;
            ucTextBox4.FontFace = "Tahoma";
            ucTextBox4.FontSize = 9F;
            ucTextBox4.FormatStr = "";
            ucTextBox4.Location = new Point(310, 58);
            ucTextBox4.Name = "ucTextBox4";
            ucTextBox4.Size = new Size(51, 21);
            ucTextBox4.TabIndex = 5;
            ucTextBox4.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox4.Title = "UCTextBox";
            ucTextBox4.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox4.TitleWidth = 0;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(276, 136);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 4;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(276, 97);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 4;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(276, 61);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 4;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 29);
            label3.Name = "label3";
            label3.Size = new Size(40, 14);
            label3.TabIndex = 3;
            label3.Text = "Count";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 29);
            label2.Name = "label2";
            label2.Size = new Size(35, 14);
            label2.TabIndex = 3;
            label2.Text = "Close";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 29);
            label1.Name = "label1";
            label1.Size = new Size(116, 14);
            label1.TabIndex = 3;
            label1.Text = "Last Work Datetime";
            // 
            // calc_salary_date
            // 
            calc_salary_date.ControlHeight = 21;
            calc_salary_date.ControlWidth = 233;
            calc_salary_date.FontColor = Color.Black;
            calc_salary_date.FontFace = "Tahoma";
            calc_salary_date.FontSize = 9F;
            calc_salary_date.FormatStr = "";
            calc_salary_date.Location = new Point(23, 136);
            calc_salary_date.Name = "calc_salary_date";
            calc_salary_date.Size = new Size(233, 21);
            calc_salary_date.TabIndex = 2;
            calc_salary_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            calc_salary_date.Title = "Calculate Salary /Tax";
            calc_salary_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            calc_salary_date.TitleWidth = 125;
            // 
            // add_ded_date
            // 
            add_ded_date.ControlHeight = 21;
            add_ded_date.ControlWidth = 233;
            add_ded_date.FontColor = Color.Black;
            add_ded_date.FontFace = "Tahoma";
            add_ded_date.FontSize = 9F;
            add_ded_date.FormatStr = "";
            add_ded_date.Location = new Point(23, 97);
            add_ded_date.Name = "add_ded_date";
            add_ded_date.Size = new Size(233, 21);
            add_ded_date.TabIndex = 1;
            add_ded_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            add_ded_date.Title = "Add/Deduct Summary";
            add_ded_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            add_ded_date.TitleWidth = 125;
            // 
            // att_summ_date
            // 
            att_summ_date.ControlHeight = 21;
            att_summ_date.ControlWidth = 233;
            att_summ_date.FontColor = Color.Black;
            att_summ_date.FontFace = "Tahoma";
            att_summ_date.FontSize = 9F;
            att_summ_date.FormatStr = "";
            att_summ_date.Location = new Point(23, 58);
            att_summ_date.Name = "att_summ_date";
            att_summ_date.Size = new Size(233, 21);
            att_summ_date.TabIndex = 0;
            att_summ_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            att_summ_date.Title = "Attendance Summary";
            att_summ_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            att_summ_date.TitleWidth = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(prp_en_date);
            groupBox1.Controls.Add(prp_st_date);
            groupBox1.Controls.Add(prp_pay_ty);
            groupBox1.Controls.Add(prp_paydate);
            groupBox1.Controls.Add(paymon);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(639, 97);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Day";
            // 
            // prp_en_date
            // 
            prp_en_date.ControlHeight = 21;
            prp_en_date.ControlWidth = 100;
            prp_en_date.FontColor = Color.Black;
            prp_en_date.FontFace = "Tahoma";
            prp_en_date.FontSize = 9F;
            prp_en_date.FormatStr = "";
            prp_en_date.Location = new Point(470, 48);
            prp_en_date.Name = "prp_en_date";
            prp_en_date.Size = new Size(100, 21);
            prp_en_date.TabIndex = 4;
            prp_en_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_en_date.Title = "~";
            prp_en_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_en_date.TitleWidth = 20;
            // 
            // prp_st_date
            // 
            prp_st_date.ControlHeight = 21;
            prp_st_date.ControlWidth = 186;
            prp_st_date.FontColor = Color.Black;
            prp_st_date.FontFace = "Tahoma";
            prp_st_date.FontSize = 9F;
            prp_st_date.FormatStr = "";
            prp_st_date.Location = new Point(264, 48);
            prp_st_date.Name = "prp_st_date";
            prp_st_date.Size = new Size(186, 21);
            prp_st_date.TabIndex = 3;
            prp_st_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_st_date.Title = "Work Period";
            prp_st_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_st_date.TitleWidth = 100;
            // 
            // prp_pay_ty
            // 
            prp_pay_ty.ControlHeight = 21;
            prp_pay_ty.ControlWidth = 306;
            prp_pay_ty.FldTy = null;
            prp_pay_ty.FontColor = Color.Black;
            prp_pay_ty.FontFace = "Tahoma";
            prp_pay_ty.FontSize = 9F;
            prp_pay_ty.Location = new Point(264, 21);
            prp_pay_ty.Name = "prp_pay_ty";
            prp_pay_ty.Size = new Size(306, 21);
            prp_pay_ty.TabIndex = 2;
            prp_pay_ty.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_pay_ty.Title = "Payment Type";
            prp_pay_ty.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_pay_ty.TitleWidth = 100;
            // 
            // prp_paydate
            // 
            prp_paydate.ControlHeight = 21;
            prp_paydate.ControlWidth = 215;
            prp_paydate.FontColor = Color.Black;
            prp_paydate.FontFace = "Tahoma";
            prp_paydate.FontSize = 9F;
            prp_paydate.FormatStr = "";
            prp_paydate.Location = new Point(23, 48);
            prp_paydate.Name = "prp_paydate";
            prp_paydate.Size = new Size(215, 21);
            prp_paydate.TabIndex = 1;
            prp_paydate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_paydate.Title = "Payment Date";
            prp_paydate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_paydate.TitleWidth = 100;
            // 
            // paymon
            // 
            paymon.ControlHeight = 21;
            paymon.ControlWidth = 215;
            paymon.FontColor = Color.Black;
            paymon.FontFace = "Tahoma";
            paymon.FontSize = 9F;
            paymon.FormatStr = "";
            paymon.Location = new Point(23, 21);
            paymon.Name = "paymon";
            paymon.Size = new Size(215, 21);
            paymon.TabIndex = 0;
            paymon.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            paymon.Title = "Payment Month";
            paymon.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            paymon.TitleWidth = 100;
            // 
            // HR660
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR660";
            Size = new Size(1184, 578);
            Load += HR660_Load;
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCGridSet g10;
        private EpicV004.Ctrls.UCDateBox s_year;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private EpicV004.Ctrls.UCTextBox paymon;
        private EpicV004.Ctrls.UCTextBox prp_st_date;
        private EpicV004.Ctrls.UCCodeBox prp_pay_ty;
        private EpicV004.Ctrls.UCTextBox prp_paydate;
        private EpicV004.Ctrls.UCTextBox prp_en_date;
        private EpicV004.Ctrls.UCTextBox ucTextBox9;
        private EpicV004.Ctrls.UCTextBox ucTextBox6;
        private EpicV004.Ctrls.UCTextBox ucTextBox8;
        private EpicV004.Ctrls.UCTextBox ucTextBox5;
        private EpicV004.Ctrls.UCTextBox ucTextBox7;
        private EpicV004.Ctrls.UCTextBox ucTextBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private EpicV004.Ctrls.UCTextBox calc_salary_date;
        private EpicV004.Ctrls.UCTextBox add_ded_date;
        private EpicV004.Ctrls.UCTextBox att_summ_date;
        private EpicV004.Ctrls.UCButton ucButton3;
        private EpicV004.Ctrls.UCButton ucButton2;
        private EpicV004.Ctrls.UCButton ucButton6;
        private EpicV004.Ctrls.UCButton ucButton5;
        private EpicV004.Ctrls.UCButton ucButton4;
        private EpicV004.Ctrls.UCButton ucButton1;
    }
}
