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
            btn_wk3 = new Ctrls.UCButton();
            btn_wk = new Ctrls.UCButton();
            btn_jump3 = new Ctrls.UCButton();
            btn_jump2 = new Ctrls.UCButton();
            btn_jump1 = new Ctrls.UCButton();
            btn_wk1 = new Ctrls.UCButton();
            cnt13 = new Ctrls.UCTextBox();
            cnt3 = new Ctrls.UCTextBox();
            cnt12 = new Ctrls.UCTextBox();
            cnt2 = new Ctrls.UCTextBox();
            cnt11 = new Ctrls.UCTextBox();
            cnt1 = new Ctrls.UCTextBox();
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
            ucSplit1.FixedPanel = FixedPanel.Panel1;
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
            ucSplit1.Size = new Size(1591, 784);
            ucSplit1.SplitterDistance = 838;
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
            ucPanel1.Size = new Size(838, 784);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Payment Day";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(834, 759);
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
            ucPanel2.Size = new Size(749, 784);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Payment Calculation Step";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_wk3);
            groupBox2.Controls.Add(btn_wk);
            groupBox2.Controls.Add(btn_jump3);
            groupBox2.Controls.Add(btn_jump2);
            groupBox2.Controls.Add(btn_jump1);
            groupBox2.Controls.Add(btn_wk1);
            groupBox2.Controls.Add(cnt13);
            groupBox2.Controls.Add(cnt3);
            groupBox2.Controls.Add(cnt12);
            groupBox2.Controls.Add(cnt2);
            groupBox2.Controls.Add(cnt11);
            groupBox2.Controls.Add(cnt1);
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
            groupBox2.Location = new Point(28, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(690, 186);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Step";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btn_wk3
            // 
            btn_wk3.Appearance.BackColor = Color.DarkGray;
            btn_wk3.Appearance.Font = new Font("Tahoma", 9F);
            btn_wk3.Appearance.Options.UseBackColor = true;
            btn_wk3.Appearance.Options.UseFont = true;
            btn_wk3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_wk3.ControlHeight = 30;
            btn_wk3.ControlWidth = 59;
            btn_wk3.FontBold = FontStyle.Regular;
            btn_wk3.FontFace = "Tahoma";
            btn_wk3.FontSize = 9F;
            btn_wk3.Location = new Point(515, 129);
            btn_wk3.Name = "btn_wk3";
            btn_wk3.Size = new Size(59, 30);
            btn_wk3.TabIndex = 6;
            btn_wk3.Title = "Work";
            btn_wk3.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // btn_wk
            // 
            btn_wk.Appearance.BackColor = Color.DarkGray;
            btn_wk.Appearance.Font = new Font("Tahoma", 9F);
            btn_wk.Appearance.Options.UseBackColor = true;
            btn_wk.Appearance.Options.UseFont = true;
            btn_wk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_wk.ControlHeight = 30;
            btn_wk.ControlWidth = 59;
            btn_wk.FontBold = FontStyle.Regular;
            btn_wk.FontFace = "Tahoma";
            btn_wk.FontSize = 9F;
            btn_wk.Location = new Point(515, 90);
            btn_wk.Name = "btn_wk";
            btn_wk.Size = new Size(59, 30);
            btn_wk.TabIndex = 6;
            btn_wk.Title = "Work";
            btn_wk.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // btn_jump3
            // 
            btn_jump3.Appearance.BackColor = Color.DarkGray;
            btn_jump3.Appearance.Font = new Font("Tahoma", 9F);
            btn_jump3.Appearance.Options.UseBackColor = true;
            btn_jump3.Appearance.Options.UseFont = true;
            btn_jump3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_jump3.ControlHeight = 30;
            btn_jump3.ControlWidth = 94;
            btn_jump3.FontBold = FontStyle.Regular;
            btn_jump3.FontFace = "Tahoma";
            btn_jump3.FontSize = 9F;
            btn_jump3.Location = new Point(582, 129);
            btn_jump3.Name = "btn_jump3";
            btn_jump3.Size = new Size(94, 30);
            btn_jump3.TabIndex = 6;
            btn_jump3.Title = "Jump to form";
            btn_jump3.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // btn_jump2
            // 
            btn_jump2.Appearance.BackColor = Color.DarkGray;
            btn_jump2.Appearance.Font = new Font("Tahoma", 9F);
            btn_jump2.Appearance.Options.UseBackColor = true;
            btn_jump2.Appearance.Options.UseFont = true;
            btn_jump2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_jump2.ControlHeight = 30;
            btn_jump2.ControlWidth = 94;
            btn_jump2.FontBold = FontStyle.Regular;
            btn_jump2.FontFace = "Tahoma";
            btn_jump2.FontSize = 9F;
            btn_jump2.Location = new Point(582, 90);
            btn_jump2.Name = "btn_jump2";
            btn_jump2.Size = new Size(94, 30);
            btn_jump2.TabIndex = 6;
            btn_jump2.Title = "Jump to form";
            btn_jump2.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // btn_jump1
            // 
            btn_jump1.Appearance.BackColor = Color.DarkGray;
            btn_jump1.Appearance.Font = new Font("Tahoma", 9F);
            btn_jump1.Appearance.Options.UseBackColor = true;
            btn_jump1.Appearance.Options.UseFont = true;
            btn_jump1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_jump1.ControlHeight = 30;
            btn_jump1.ControlWidth = 94;
            btn_jump1.FontBold = FontStyle.Regular;
            btn_jump1.FontFace = "Tahoma";
            btn_jump1.FontSize = 9F;
            btn_jump1.Location = new Point(582, 54);
            btn_jump1.Name = "btn_jump1";
            btn_jump1.Size = new Size(94, 30);
            btn_jump1.TabIndex = 6;
            btn_jump1.Title = "Jump to form";
            btn_jump1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // btn_wk1
            // 
            btn_wk1.Appearance.BackColor = Color.DarkGray;
            btn_wk1.Appearance.Font = new Font("Tahoma", 9F);
            btn_wk1.Appearance.Options.UseBackColor = true;
            btn_wk1.Appearance.Options.UseFont = true;
            btn_wk1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_wk1.ControlHeight = 30;
            btn_wk1.ControlWidth = 59;
            btn_wk1.FontBold = FontStyle.Regular;
            btn_wk1.FontFace = "Tahoma";
            btn_wk1.FontSize = 9F;
            btn_wk1.Location = new Point(515, 54);
            btn_wk1.Name = "btn_wk1";
            btn_wk1.Size = new Size(59, 30);
            btn_wk1.TabIndex = 6;
            btn_wk1.Title = "Work";
            btn_wk1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // cnt13
            // 
            cnt13.ControlHeight = 21;
            cnt13.ControlWidth = 71;
            cnt13.FontColor = Color.Black;
            cnt13.FontFace = "Tahoma";
            cnt13.FontSize = 9F;
            cnt13.FormatStr = "";
            cnt13.Location = new Point(431, 136);
            cnt13.Name = "cnt13";
            cnt13.Size = new Size(71, 21);
            cnt13.TabIndex = 5;
            cnt13.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt13.Title = "/";
            cnt13.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt13.TitleWidth = 20;
            // 
            // cnt3
            // 
            cnt3.ControlHeight = 21;
            cnt3.ControlWidth = 51;
            cnt3.FontColor = Color.Black;
            cnt3.FontFace = "Tahoma";
            cnt3.FontSize = 9F;
            cnt3.FormatStr = "";
            cnt3.Location = new Point(367, 136);
            cnt3.Name = "cnt3";
            cnt3.Size = new Size(51, 21);
            cnt3.TabIndex = 5;
            cnt3.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt3.Title = "UCTextBox";
            cnt3.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt3.TitleWidth = 0;
            // 
            // cnt12
            // 
            cnt12.ControlHeight = 21;
            cnt12.ControlWidth = 71;
            cnt12.FontColor = Color.Black;
            cnt12.FontFace = "Tahoma";
            cnt12.FontSize = 9F;
            cnt12.FormatStr = "";
            cnt12.Location = new Point(431, 97);
            cnt12.Name = "cnt12";
            cnt12.Size = new Size(71, 21);
            cnt12.TabIndex = 5;
            cnt12.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt12.Title = "/";
            cnt12.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt12.TitleWidth = 20;
            // 
            // cnt2
            // 
            cnt2.ControlHeight = 21;
            cnt2.ControlWidth = 51;
            cnt2.FontColor = Color.Black;
            cnt2.FontFace = "Tahoma";
            cnt2.FontSize = 9F;
            cnt2.FormatStr = "";
            cnt2.Location = new Point(367, 97);
            cnt2.Name = "cnt2";
            cnt2.Size = new Size(51, 21);
            cnt2.TabIndex = 5;
            cnt2.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt2.Title = "UCTextBox";
            cnt2.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt2.TitleWidth = 0;
            // 
            // cnt11
            // 
            cnt11.ControlHeight = 21;
            cnt11.ControlWidth = 71;
            cnt11.FontColor = Color.Black;
            cnt11.FontFace = "Tahoma";
            cnt11.FontSize = 9F;
            cnt11.FormatStr = "";
            cnt11.Location = new Point(431, 58);
            cnt11.Name = "cnt11";
            cnt11.Size = new Size(71, 21);
            cnt11.TabIndex = 5;
            cnt11.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt11.Title = "/";
            cnt11.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt11.TitleWidth = 20;
            // 
            // cnt1
            // 
            cnt1.ControlHeight = 21;
            cnt1.ControlWidth = 51;
            cnt1.FontColor = Color.Black;
            cnt1.FontFace = "Tahoma";
            cnt1.FontSize = 9F;
            cnt1.FormatStr = "";
            cnt1.Location = new Point(367, 58);
            cnt1.Name = "cnt1";
            cnt1.Size = new Size(51, 21);
            cnt1.TabIndex = 5;
            cnt1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt1.Title = "UCTextBox";
            cnt1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            cnt1.TitleWidth = 0;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(333, 136);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 4;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(333, 97);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 4;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(333, 61);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 4;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 29);
            label3.Name = "label3";
            label3.Size = new Size(40, 14);
            label3.TabIndex = 3;
            label3.Text = "Count";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 29);
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
            calc_salary_date.ControlWidth = 295;
            calc_salary_date.FontColor = Color.Black;
            calc_salary_date.FontFace = "Tahoma";
            calc_salary_date.FontSize = 9F;
            calc_salary_date.FormatStr = "";
            calc_salary_date.Location = new Point(23, 136);
            calc_salary_date.Name = "calc_salary_date";
            calc_salary_date.Size = new Size(295, 21);
            calc_salary_date.TabIndex = 2;
            calc_salary_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            calc_salary_date.Title = "Calculate Salary /Tax";
            calc_salary_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            calc_salary_date.TitleWidth = 125;
            // 
            // add_ded_date
            // 
            add_ded_date.ControlHeight = 21;
            add_ded_date.ControlWidth = 295;
            add_ded_date.FontColor = Color.Black;
            add_ded_date.FontFace = "Tahoma";
            add_ded_date.FontSize = 9F;
            add_ded_date.FormatStr = "";
            add_ded_date.Location = new Point(23, 97);
            add_ded_date.Name = "add_ded_date";
            add_ded_date.Size = new Size(295, 21);
            add_ded_date.TabIndex = 1;
            add_ded_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            add_ded_date.Title = "Add/Deduct Summary";
            add_ded_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            add_ded_date.TitleWidth = 125;
            // 
            // att_summ_date
            // 
            att_summ_date.ControlHeight = 21;
            att_summ_date.ControlWidth = 295;
            att_summ_date.FontColor = Color.Black;
            att_summ_date.FontFace = "Tahoma";
            att_summ_date.FontSize = 9F;
            att_summ_date.FormatStr = "";
            att_summ_date.Location = new Point(23, 58);
            att_summ_date.Name = "att_summ_date";
            att_summ_date.Size = new Size(295, 21);
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
            groupBox1.Location = new Point(28, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(690, 97);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Day";
            // 
            // prp_en_date
            // 
            prp_en_date.ControlHeight = 21;
            prp_en_date.ControlWidth = 132;
            prp_en_date.FontColor = Color.Black;
            prp_en_date.FontFace = "Tahoma";
            prp_en_date.FontSize = 9F;
            prp_en_date.FormatStr = "";
            prp_en_date.Location = new Point(523, 48);
            prp_en_date.Name = "prp_en_date";
            prp_en_date.Size = new Size(132, 21);
            prp_en_date.TabIndex = 4;
            prp_en_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_en_date.Title = "~";
            prp_en_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_en_date.TitleWidth = 20;
            // 
            // prp_st_date
            // 
            prp_st_date.ControlHeight = 21;
            prp_st_date.ControlWidth = 200;
            prp_st_date.FontColor = Color.Black;
            prp_st_date.FontFace = "Tahoma";
            prp_st_date.FontSize = 9F;
            prp_st_date.FormatStr = "";
            prp_st_date.Location = new Point(317, 48);
            prp_st_date.Name = "prp_st_date";
            prp_st_date.Size = new Size(200, 21);
            prp_st_date.TabIndex = 3;
            prp_st_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_st_date.Title = "Work Period";
            prp_st_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_st_date.TitleWidth = 100;
            // 
            // prp_pay_ty
            // 
            prp_pay_ty.ControlHeight = 21;
            prp_pay_ty.ControlWidth = 338;
            prp_pay_ty.FldTy = null;
            prp_pay_ty.FontColor = Color.Black;
            prp_pay_ty.FontFace = "Tahoma";
            prp_pay_ty.FontSize = 9F;
            prp_pay_ty.Location = new Point(317, 21);
            prp_pay_ty.Name = "prp_pay_ty";
            prp_pay_ty.Size = new Size(338, 21);
            prp_pay_ty.TabIndex = 2;
            prp_pay_ty.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_pay_ty.Title = "Payment Type";
            prp_pay_ty.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_pay_ty.TitleWidth = 100;
            // 
            // prp_paydate
            // 
            prp_paydate.ControlHeight = 21;
            prp_paydate.ControlWidth = 288;
            prp_paydate.FontColor = Color.Black;
            prp_paydate.FontFace = "Tahoma";
            prp_paydate.FontSize = 9F;
            prp_paydate.FormatStr = "";
            prp_paydate.Location = new Point(23, 48);
            prp_paydate.Name = "prp_paydate";
            prp_paydate.Size = new Size(288, 21);
            prp_paydate.TabIndex = 1;
            prp_paydate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_paydate.Title = "Payment Date";
            prp_paydate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            prp_paydate.TitleWidth = 100;
            // 
            // paymon
            // 
            paymon.ControlHeight = 21;
            paymon.ControlWidth = 288;
            paymon.FontColor = Color.Black;
            paymon.FontFace = "Tahoma";
            paymon.FontSize = 9F;
            paymon.FormatStr = "";
            paymon.Location = new Point(23, 21);
            paymon.Name = "paymon";
            paymon.Size = new Size(288, 21);
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
            Size = new Size(1591, 784);
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
        private EpicV004.Ctrls.UCTextBox cnt13;
        private EpicV004.Ctrls.UCTextBox cnt3;
        private EpicV004.Ctrls.UCTextBox cnt12;
        private EpicV004.Ctrls.UCTextBox cnt2;
        private EpicV004.Ctrls.UCTextBox cnt11;
        private EpicV004.Ctrls.UCTextBox cnt1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private EpicV004.Ctrls.UCTextBox calc_salary_date;
        private EpicV004.Ctrls.UCTextBox add_ded_date;
        private EpicV004.Ctrls.UCTextBox att_summ_date;
        private EpicV004.Ctrls.UCButton btn_wk3;
        private EpicV004.Ctrls.UCButton btn_wk;
        private EpicV004.Ctrls.UCButton btn_jump3;
        private EpicV004.Ctrls.UCButton btn_jump2;
        private EpicV004.Ctrls.UCButton btn_jump1;
        private EpicV004.Ctrls.UCButton btn_wk1;
    }
}
