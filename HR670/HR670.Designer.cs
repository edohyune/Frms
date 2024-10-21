namespace EpicV004.Frms
{
    partial class HR670
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
            ucSplit2 = new Ctrls.UCSplit();
            ucPanel1 = new Ctrls.UCPanel();
            btn_payment = new Ctrls.UCButton();
            s_year = new Ctrls.UCDateBox();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            btn_voucher = new Ctrls.UCButton();
            vc_no = new Ctrls.UCTextBox();
            vc_date = new Ctrls.UCDateBox();
            s_entm_calctax = new Ctrls.UCTextBox();
            s_mdtm_calctax = new Ctrls.UCTextBox();
            s_sttm_calctax = new Ctrls.UCTextBox();
            s_pay_ty = new Ctrls.UCCodeBox();
            btn_salary = new Ctrls.UCButton();
            s_pay_date = new Ctrls.UCDateBox();
            s_emp = new Ctrls.UCTextBox();
            s_dept = new Ctrls.UCTextBox();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            g30 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit2).BeginInit();
            ucSplit2.Panel1.SuspendLayout();
            ucSplit2.Panel2.SuspendLayout();
            ucSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
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
            ucSplit1.Location = new Point(0, 0);
            ucSplit1.Name = "ucSplit1";
            // 
            // ucSplit1.Panel1
            // 
            ucSplit1.Panel1.Controls.Add(ucSplit2);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucSplit3);
            ucSplit1.Size = new Size(1372, 598);
            ucSplit1.SplitterDistance = 320;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            ucSplit1.SplitterMoved += ucSplit1_SplitterMoved;
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
            ucSplit2.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(g10);
            ucSplit2.Size = new Size(320, 598);
            ucSplit2.SplitterDistance = 85;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            ucSplit2.SplitterMoved += ucSplit2_SplitterMoved;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(btn_payment);
            ucPanel1.Controls.Add(s_year);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(320, 85);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // btn_payment
            // 
            btn_payment.Appearance.BackColor = Color.DarkGray;
            btn_payment.Appearance.Font = new Font("Tahoma", 9F);
            btn_payment.Appearance.Options.UseBackColor = true;
            btn_payment.Appearance.Options.UseFont = true;
            btn_payment.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_payment.ControlHeight = 43;
            btn_payment.ControlWidth = 144;
            btn_payment.FontBold = FontStyle.Regular;
            btn_payment.FontFace = "Tahoma";
            btn_payment.FontSize = 9F;
            btn_payment.Location = new Point(166, 31);
            btn_payment.Name = "btn_payment";
            btn_payment.Size = new Size(144, 43);
            btn_payment.TabIndex = 1;
            btn_payment.Title = "Payment Date Query";
            btn_payment.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // s_year
            // 
            s_year.ControlHeight = 21;
            s_year.ControlWidth = 156;
            s_year.FontColor = Color.Black;
            s_year.FontFace = "Tahoma";
            s_year.FontSize = 9F;
            s_year.FormatStr = "";
            s_year.Location = new Point(0, 37);
            s_year.Name = "s_year";
            s_year.Size = new Size(156, 21);
            s_year.TabIndex = 0;
            s_year.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.Title = "Year";
            s_year.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.TitleWidth = 50;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(320, 509);
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
            ucSplit3.Size = new Size(1048, 598);
            ucSplit3.SplitterDistance = 121;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(btn_voucher);
            ucPanel2.Controls.Add(vc_no);
            ucPanel2.Controls.Add(vc_date);
            ucPanel2.Controls.Add(s_entm_calctax);
            ucPanel2.Controls.Add(s_mdtm_calctax);
            ucPanel2.Controls.Add(s_sttm_calctax);
            ucPanel2.Controls.Add(s_pay_ty);
            ucPanel2.Controls.Add(btn_salary);
            ucPanel2.Controls.Add(s_pay_date);
            ucPanel2.Controls.Add(s_emp);
            ucPanel2.Controls.Add(s_dept);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1048, 121);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Calculate Salary";
            // 
            // btn_voucher
            // 
            btn_voucher.Appearance.BackColor = Color.DarkGray;
            btn_voucher.Appearance.Font = new Font("Tahoma", 9F);
            btn_voucher.Appearance.Options.UseBackColor = true;
            btn_voucher.Appearance.Options.UseFont = true;
            btn_voucher.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_voucher.ControlHeight = 45;
            btn_voucher.ControlWidth = 100;
            btn_voucher.FontBold = FontStyle.Regular;
            btn_voucher.FontFace = "Tahoma";
            btn_voucher.FontSize = 9F;
            btn_voucher.Location = new Point(813, 31);
            btn_voucher.Name = "btn_voucher";
            btn_voucher.Size = new Size(100, 45);
            btn_voucher.TabIndex = 10;
            btn_voucher.Title = "Make Voucher";
            btn_voucher.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // vc_no
            // 
            vc_no.ControlHeight = 21;
            vc_no.ControlWidth = 200;
            vc_no.FontColor = Color.Black;
            vc_no.FontFace = "Tahoma";
            vc_no.FontSize = 9F;
            vc_no.FormatStr = "";
            vc_no.Location = new Point(607, 55);
            vc_no.Name = "vc_no";
            vc_no.Size = new Size(200, 21);
            vc_no.TabIndex = 9;
            vc_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            vc_no.Title = "Voucher No";
            vc_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            vc_no.TitleWidth = 100;
            // 
            // vc_date
            // 
            vc_date.ControlHeight = 21;
            vc_date.ControlWidth = 200;
            vc_date.FontColor = Color.Black;
            vc_date.FontFace = "Tahoma";
            vc_date.FontSize = 9F;
            vc_date.FormatStr = "";
            vc_date.Location = new Point(607, 31);
            vc_date.Name = "vc_date";
            vc_date.Size = new Size(200, 21);
            vc_date.TabIndex = 8;
            vc_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            vc_date.Title = "Voucher Date";
            vc_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            vc_date.TitleWidth = 100;
            // 
            // s_entm_calctax
            // 
            s_entm_calctax.ControlHeight = 21;
            s_entm_calctax.ControlWidth = 200;
            s_entm_calctax.FontColor = Color.Black;
            s_entm_calctax.FontFace = "Tahoma";
            s_entm_calctax.FontSize = 9F;
            s_entm_calctax.FormatStr = "";
            s_entm_calctax.Location = new Point(401, 82);
            s_entm_calctax.Name = "s_entm_calctax";
            s_entm_calctax.Size = new Size(200, 21);
            s_entm_calctax.TabIndex = 7;
            s_entm_calctax.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_entm_calctax.Title = "End Calc Tm";
            s_entm_calctax.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_entm_calctax.TitleWidth = 100;
            // 
            // s_mdtm_calctax
            // 
            s_mdtm_calctax.ControlHeight = 21;
            s_mdtm_calctax.ControlWidth = 200;
            s_mdtm_calctax.FontColor = Color.Black;
            s_mdtm_calctax.FontFace = "Tahoma";
            s_mdtm_calctax.FontSize = 9F;
            s_mdtm_calctax.FormatStr = "";
            s_mdtm_calctax.Location = new Point(401, 55);
            s_mdtm_calctax.Name = "s_mdtm_calctax";
            s_mdtm_calctax.Size = new Size(200, 21);
            s_mdtm_calctax.TabIndex = 6;
            s_mdtm_calctax.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_mdtm_calctax.Title = "Mid Calc Tm";
            s_mdtm_calctax.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_mdtm_calctax.TitleWidth = 100;
            // 
            // s_sttm_calctax
            // 
            s_sttm_calctax.ControlHeight = 21;
            s_sttm_calctax.ControlWidth = 200;
            s_sttm_calctax.FontColor = Color.Black;
            s_sttm_calctax.FontFace = "Tahoma";
            s_sttm_calctax.FontSize = 9F;
            s_sttm_calctax.FormatStr = "";
            s_sttm_calctax.Location = new Point(401, 31);
            s_sttm_calctax.Name = "s_sttm_calctax";
            s_sttm_calctax.Size = new Size(200, 21);
            s_sttm_calctax.TabIndex = 5;
            s_sttm_calctax.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_sttm_calctax.Title = "ST Calc Tm";
            s_sttm_calctax.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_sttm_calctax.TitleWidth = 100;
            // 
            // s_pay_ty
            // 
            s_pay_ty.ControlHeight = 21;
            s_pay_ty.ControlWidth = 163;
            s_pay_ty.FldTy = null;
            s_pay_ty.FontColor = Color.Black;
            s_pay_ty.FontFace = "Tahoma";
            s_pay_ty.FontSize = 9F;
            s_pay_ty.Location = new Point(232, 80);
            s_pay_ty.Name = "s_pay_ty";
            s_pay_ty.Size = new Size(163, 21);
            s_pay_ty.TabIndex = 4;
            s_pay_ty.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_pay_ty.Title = "Pay Type";
            s_pay_ty.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_pay_ty.TitleWidth = 70;
            // 
            // btn_salary
            // 
            btn_salary.Appearance.BackColor = Color.DarkGray;
            btn_salary.Appearance.Font = new Font("Tahoma", 9F);
            btn_salary.Appearance.Options.UseBackColor = true;
            btn_salary.Appearance.Options.UseFont = true;
            btn_salary.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_salary.ControlHeight = 43;
            btn_salary.ControlWidth = 163;
            btn_salary.FontBold = FontStyle.Regular;
            btn_salary.FontFace = "Tahoma";
            btn_salary.FontSize = 9F;
            btn_salary.Location = new Point(232, 31);
            btn_salary.Name = "btn_salary";
            btn_salary.Size = new Size(163, 43);
            btn_salary.TabIndex = 3;
            btn_salary.Title = "Salary/Tax Calculation";
            btn_salary.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            btn_salary.Click += btn_salary_Click;
            // 
            // s_pay_date
            // 
            s_pay_date.ControlHeight = 21;
            s_pay_date.ControlWidth = 200;
            s_pay_date.FontColor = Color.Black;
            s_pay_date.FontFace = "Tahoma";
            s_pay_date.FontSize = 9F;
            s_pay_date.FormatStr = "";
            s_pay_date.Location = new Point(15, 82);
            s_pay_date.Name = "s_pay_date";
            s_pay_date.Size = new Size(200, 21);
            s_pay_date.TabIndex = 2;
            s_pay_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_pay_date.Title = "Pay Date";
            s_pay_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_pay_date.TitleWidth = 100;
            // 
            // s_emp
            // 
            s_emp.ControlHeight = 21;
            s_emp.ControlWidth = 200;
            s_emp.FontColor = Color.Black;
            s_emp.FontFace = "Tahoma";
            s_emp.FontSize = 9F;
            s_emp.FormatStr = "";
            s_emp.Location = new Point(15, 55);
            s_emp.Name = "s_emp";
            s_emp.Size = new Size(200, 21);
            s_emp.TabIndex = 1;
            s_emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp.Title = "Employee";
            s_emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp.TitleWidth = 100;
            // 
            // s_dept
            // 
            s_dept.ControlHeight = 21;
            s_dept.ControlWidth = 200;
            s_dept.FontColor = Color.Black;
            s_dept.FontFace = "Tahoma";
            s_dept.FontSize = 9F;
            s_dept.FormatStr = "";
            s_dept.Location = new Point(15, 31);
            s_dept.Name = "s_dept";
            s_dept.Size = new Size(200, 21);
            s_dept.TabIndex = 0;
            s_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.Title = "Dept";
            s_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.TitleWidth = 100;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1048, 473);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g20);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1046, 448);
            xtraTabPage1.Text = "HA850(PRRESULT)";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1046, 448);
            g20.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g30);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1046, 448);
            xtraTabPage2.Text = "HA880(PRTAXSTEP)";
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(1046, 448);
            g30.TabIndex = 0;
            // 
            // HR670
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR670";
            Size = new Size(1372, 598);
            Load += HR670_Load;
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ucSplit2.Panel1.ResumeLayout(false);
            ucSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit2).EndInit();
            ucSplit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ucSplit3.Panel1.ResumeLayout(false);
            ucSplit3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit3).EndInit();
            ucSplit3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucTab1).EndInit();
            ucTab1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCGridSet g30;
        private Ctrls.UCButton btn_payment;
        private Ctrls.UCDateBox s_year;
        private Ctrls.UCButton btn_voucher;
        private Ctrls.UCTextBox vc_no;
        private Ctrls.UCDateBox vc_date;
        private Ctrls.UCTextBox s_entm_calctax;
        private Ctrls.UCTextBox s_mdtm_calctax;
        private Ctrls.UCTextBox s_sttm_calctax;
        private Ctrls.UCCodeBox s_pay_ty;
        private Ctrls.UCButton btn_salary;
        private Ctrls.UCDateBox s_pay_date;
        private Ctrls.UCTextBox s_emp;
        private Ctrls.UCTextBox s_dept;
        private Ctrls.UCGridSet g20;
    }
}
