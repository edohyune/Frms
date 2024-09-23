namespace EpicV004.Frms
{
    partial class HR690
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
            s_paydate = new Ctrls.UCDateBox();
            btn_print = new Ctrls.UCButton();
            s_pay_ty = new Ctrls.UCCodeBox();
            s_paymonth = new Ctrls.UCDateBox();
            btn_file = new Ctrls.UCButton();
            btn_open = new Ctrls.UCButton();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            g30 = new Ctrls.UCGridSet();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            g40 = new Ctrls.UCGridSet();
            xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            g50 = new Ctrls.UCGridSet();
            xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            g60 = new Ctrls.UCGridSet();
            xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            g70 = new Ctrls.UCGridSet();
            xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            g80 = new Ctrls.UCGridSet();
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
            xtraTabPage3.SuspendLayout();
            xtraTabPage4.SuspendLayout();
            xtraTabPage5.SuspendLayout();
            xtraTabPage6.SuspendLayout();
            xtraTabPage7.SuspendLayout();
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
            ucSplit1.Panel1.Controls.Add(ucSplit2);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucSplit3);
            ucSplit1.Size = new Size(1346, 614);
            ucSplit1.SplitterDistance = 335;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
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
            ucSplit2.Size = new Size(335, 614);
            ucSplit2.SplitterDistance = 66;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(btn_payment);
            ucPanel1.Controls.Add(s_year);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(335, 66);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Payment Date";
            // 
            // btn_payment
            // 
            btn_payment.Appearance.BackColor = Color.DarkGray;
            btn_payment.Appearance.Options.UseBackColor = true;
            btn_payment.Appearance.Options.UseFont = true;
            btn_payment.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_payment.ControlHeight = 35;
            btn_payment.ControlWidth = 154;
            btn_payment.FontBold = FontStyle.Regular;
            btn_payment.FontFace = "Tahoma";
            btn_payment.FontSize = 9F;
            btn_payment.Location = new Point(176, 26);
            btn_payment.Name = "btn_payment";
            btn_payment.Size = new Size(154, 35);
            btn_payment.TabIndex = 1;
            btn_payment.Title = "Payment Date Query";
            btn_payment.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // s_year
            // 
            s_year.ControlHeight = 21;
            s_year.ControlWidth = 165;
            s_year.FontColor = Color.Black;
            s_year.FontFace = "Tahoma";
            s_year.FontSize = 9F;
            s_year.FormatStr = "";
            s_year.Location = new Point(5, 33);
            s_year.Name = "s_year";
            s_year.Size = new Size(165, 21);
            s_year.TabIndex = 0;
            s_year.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.Title = "Year";
            s_year.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.TitleWidth = 40;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(335, 544);
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
            ucSplit3.Size = new Size(1007, 614);
            ucSplit3.SplitterDistance = 70;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(s_paydate);
            ucPanel2.Controls.Add(btn_print);
            ucPanel2.Controls.Add(s_pay_ty);
            ucPanel2.Controls.Add(s_paymonth);
            ucPanel2.Controls.Add(btn_file);
            ucPanel2.Controls.Add(btn_open);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1007, 70);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Make Transfer File";
            // 
            // s_paydate
            // 
            s_paydate.ControlHeight = 21;
            s_paydate.ControlWidth = 165;
            s_paydate.FontColor = Color.Black;
            s_paydate.FontFace = "Tahoma";
            s_paydate.FontSize = 9F;
            s_paydate.FormatStr = "";
            s_paydate.Location = new Point(411, 33);
            s_paydate.Name = "s_paydate";
            s_paydate.Size = new Size(165, 21);
            s_paydate.TabIndex = 6;
            s_paydate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_paydate.Title = "Date";
            s_paydate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_paydate.TitleWidth = 60;
            // 
            // btn_print
            // 
            btn_print.Appearance.BackColor = Color.DarkGray;
            btn_print.Appearance.Options.UseBackColor = true;
            btn_print.Appearance.Options.UseFont = true;
            btn_print.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_print.ControlHeight = 35;
            btn_print.ControlWidth = 97;
            btn_print.FontBold = FontStyle.Regular;
            btn_print.FontFace = "Tahoma";
            btn_print.FontSize = 9F;
            btn_print.Location = new Point(807, 26);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(97, 35);
            btn_print.TabIndex = 5;
            btn_print.Title = "Print";
            btn_print.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // s_pay_ty
            // 
            s_pay_ty.ControlHeight = 21;
            s_pay_ty.ControlWidth = 182;
            s_pay_ty.FldTy = null;
            s_pay_ty.FontColor = Color.Black;
            s_pay_ty.FontFace = "Tahoma";
            s_pay_ty.FontSize = 9F;
            s_pay_ty.Location = new Point(618, 33);
            s_pay_ty.Margin = new Padding(4, 3, 4, 3);
            s_pay_ty.Name = "s_pay_ty";
            s_pay_ty.Size = new Size(182, 21);
            s_pay_ty.TabIndex = 4;
            s_pay_ty.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_pay_ty.Title = "Pay Type";
            s_pay_ty.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_pay_ty.TitleWidth = 70;
            // 
            // s_paymonth
            // 
            s_paymonth.ControlHeight = 21;
            s_paymonth.ControlWidth = 165;
            s_paymonth.FontColor = Color.Black;
            s_paymonth.FontFace = "Tahoma";
            s_paymonth.FontSize = 9F;
            s_paymonth.FormatStr = "";
            s_paymonth.Location = new Point(240, 33);
            s_paymonth.Name = "s_paymonth";
            s_paymonth.Size = new Size(165, 21);
            s_paymonth.TabIndex = 2;
            s_paymonth.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_paymonth.Title = "Month";
            s_paymonth.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_paymonth.TitleWidth = 60;
            // 
            // btn_file
            // 
            btn_file.Appearance.BackColor = Color.DarkGray;
            btn_file.Appearance.Options.UseBackColor = true;
            btn_file.Appearance.Options.UseFont = true;
            btn_file.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_file.ControlHeight = 35;
            btn_file.ControlWidth = 111;
            btn_file.FontBold = FontStyle.Regular;
            btn_file.FontFace = "Tahoma";
            btn_file.FontSize = 9F;
            btn_file.Location = new Point(123, 26);
            btn_file.Name = "btn_file";
            btn_file.Size = new Size(111, 35);
            btn_file.TabIndex = 1;
            btn_file.Title = "Make File";
            btn_file.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // btn_open
            // 
            btn_open.Appearance.BackColor = Color.DarkGray;
            btn_open.Appearance.Options.UseBackColor = true;
            btn_open.Appearance.Options.UseFont = true;
            btn_open.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_open.ControlHeight = 35;
            btn_open.ControlWidth = 112;
            btn_open.FontBold = FontStyle.Regular;
            btn_open.FontFace = "Tahoma";
            btn_open.FontSize = 9F;
            btn_open.Location = new Point(5, 26);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(112, 35);
            btn_open.TabIndex = 0;
            btn_open.Title = "Open";
            btn_open.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1007, 540);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2, xtraTabPage3, xtraTabPage4, xtraTabPage5, xtraTabPage6, xtraTabPage7 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g20);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1005, 514);
            xtraTabPage1.Text = "Payroll Bank Transfer Data";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1005, 514);
            g20.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g30);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1005, 514);
            xtraTabPage2.Text = "Social Security Data";
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(1005, 514);
            g30.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(g40);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new Size(1005, 514);
            xtraTabPage3.Text = "Prov. Fund Transfer Data";
            // 
            // g40
            // 
            g40.Dock = DockStyle.Fill;
            g40.Location = new Point(0, 0);
            g40.Name = "g40";
            g40.Size = new Size(1005, 514);
            g40.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            xtraTabPage4.Controls.Add(g50);
            xtraTabPage4.Name = "xtraTabPage4";
            xtraTabPage4.Size = new Size(1005, 514);
            xtraTabPage4.Text = "Tax Transfer Data";
            // 
            // g50
            // 
            g50.Dock = DockStyle.Fill;
            g50.Location = new Point(0, 0);
            g50.Name = "g50";
            g50.Size = new Size(1005, 514);
            g50.TabIndex = 0;
            // 
            // xtraTabPage5
            // 
            xtraTabPage5.Controls.Add(g60);
            xtraTabPage5.Name = "xtraTabPage5";
            xtraTabPage5.Size = new Size(1005, 514);
            xtraTabPage5.Text = "SSO (Excel Print)";
            // 
            // g60
            // 
            g60.Dock = DockStyle.Fill;
            g60.Location = new Point(0, 0);
            g60.Name = "g60";
            g60.Size = new Size(1005, 514);
            g60.TabIndex = 0;
            // 
            // xtraTabPage6
            // 
            xtraTabPage6.Controls.Add(g70);
            xtraTabPage6.Name = "xtraTabPage6";
            xtraTabPage6.Size = new Size(1005, 514);
            xtraTabPage6.Text = "PND1 (Excel Print)";
            // 
            // g70
            // 
            g70.Dock = DockStyle.Fill;
            g70.Location = new Point(0, 0);
            g70.Name = "g70";
            g70.Size = new Size(1005, 514);
            g70.TabIndex = 0;
            // 
            // xtraTabPage7
            // 
            xtraTabPage7.Controls.Add(g80);
            xtraTabPage7.Name = "xtraTabPage7";
            xtraTabPage7.Size = new Size(1005, 514);
            xtraTabPage7.Text = "Cash Payment (Print)";
            // 
            // g80
            // 
            g80.Dock = DockStyle.Fill;
            g80.Location = new Point(0, 0);
            g80.Name = "g80";
            g80.Size = new Size(1005, 514);
            g80.TabIndex = 0;
            // 
            // HR690
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR690";
            Size = new Size(1346, 614);
            Load += HR690_Load;
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
            xtraTabPage3.ResumeLayout(false);
            xtraTabPage4.ResumeLayout(false);
            xtraTabPage5.ResumeLayout(false);
            xtraTabPage6.ResumeLayout(false);
            xtraTabPage7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCButton btn_print;
        private Ctrls.UCCodeBox s_pay_ty;
        private Ctrls.UCDateBox s_paymonth;
        private Ctrls.UCButton btn_file;
        private Ctrls.UCButton btn_open;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCGridSet g30;
        private Ctrls.UCGridSet g40;
        private Ctrls.UCGridSet g50;
        private Ctrls.UCGridSet g60;
        private Ctrls.UCGridSet g70;
       
        private Ctrls.UCGridSet g80;
        private Ctrls.UCButton btn_payment;
        private Ctrls.UCDateBox s_year;
        private Ctrls.UCDateBox s_paydate;
    }
}
