namespace EpicV004.Frms
{
    partial class SO350
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
            s_supplier = new Ctrls.UCTextBox();
            s_project = new Ctrls.UCTextBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            retention_balance = new Ctrls.UCTextBox();
            paid_sum = new Ctrls.UCTextBox();
            supplier_retention = new Ctrls.UCTextBox();
            prj_currency = new Ctrls.UCCodeBox();
            prj_currencyRate = new Ctrls.UCTextBox();
            supplier_name = new Ctrls.UCTextBox();
            project_name = new Ctrls.UCTextBox();
            supplier = new Ctrls.UCTextBox();
            project = new Ctrls.UCTextBox();
            ucSplit4 = new Ctrls.UCSplit();
            g20 = new Ctrls.UCGridSet();
            ucSplit5 = new Ctrls.UCSplit();
            ucPanel3 = new Ctrls.UCPanel();
            note = new Ctrls.UCNote();
            btn_getdata = new Ctrls.UCButton();
            ivc_sumNet = new Ctrls.UCTextBox();
            ivc_sumDeduction = new Ctrls.UCTextBox();
            ivc_sumAmount = new Ctrls.UCTextBox();
            payment_term = new Ctrls.UCCodeBox();
            payment_type = new Ctrls.UCCodeBox();
            payment_date = new Ctrls.UCDateBox();
            payment_days = new Ctrls.UCTextBox();
            supplier_invoice_no = new Ctrls.UCTextBox();
            status = new Ctrls.UCCodeBox();
            currency = new Ctrls.UCCodeBox();
            currency_rate = new Ctrls.UCTextBox();
            release_date = new Ctrls.UCDateBox();
            release_no = new Ctrls.UCTextBox();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g30 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            cuFtp = new Ctrls.UCGridSet();
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
            ((System.ComponentModel.ISupportInitialize)ucSplit4).BeginInit();
            ucSplit4.Panel1.SuspendLayout();
            ucSplit4.Panel2.SuspendLayout();
            ucSplit4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit5).BeginInit();
            ucSplit5.Panel1.SuspendLayout();
            ucSplit5.Panel2.SuspendLayout();
            ucSplit5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel3).BeginInit();
            ucPanel3.SuspendLayout();
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
            ucSplit1.Size = new Size(1818, 831);
            ucSplit1.SplitterDistance = 83;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_supplier);
            ucPanel1.Controls.Add(s_project);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1818, 83);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // s_supplier
            // 
            s_supplier.ControlHeight = 21;
            s_supplier.ControlWidth = 250;
            s_supplier.FontColor = Color.Black;
            s_supplier.FontFace = "Tahoma";
            s_supplier.FontSize = 9F;
            s_supplier.FormatStr = "";
            s_supplier.Location = new Point(5, 29);
            s_supplier.Name = "s_supplier";
            s_supplier.Size = new Size(250, 21);
            s_supplier.TabIndex = 13;
            s_supplier.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_supplier.Title = "Supplier";
            s_supplier.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_supplier.TitleWidth = 110;
            // 
            // s_project
            // 
            s_project.ControlHeight = 21;
            s_project.ControlWidth = 250;
            s_project.FontColor = Color.Black;
            s_project.FontFace = "Tahoma";
            s_project.FontSize = 9F;
            s_project.FormatStr = "";
            s_project.Location = new Point(5, 56);
            s_project.Name = "s_project";
            s_project.Size = new Size(250, 21);
            s_project.TabIndex = 14;
            s_project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.Title = "Project";
            s_project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.TitleWidth = 110;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.FixedPanel = FixedPanel.Panel1;
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
            ucSplit2.Size = new Size(1818, 744);
            ucSplit2.SplitterDistance = 353;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(353, 744);
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
            ucSplit3.Panel2.Controls.Add(ucSplit4);
            ucSplit3.Size = new Size(1461, 744);
            ucSplit3.SplitterDistance = 98;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(retention_balance);
            ucPanel2.Controls.Add(paid_sum);
            ucPanel2.Controls.Add(supplier_retention);
            ucPanel2.Controls.Add(prj_currency);
            ucPanel2.Controls.Add(prj_currencyRate);
            ucPanel2.Controls.Add(supplier_name);
            ucPanel2.Controls.Add(project_name);
            ucPanel2.Controls.Add(supplier);
            ucPanel2.Controls.Add(project);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1461, 98);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Service Invoice Info";
            // 
            // retention_balance
            // 
            retention_balance.ControlHeight = 21;
            retention_balance.ControlWidth = 282;
            retention_balance.FontColor = Color.Black;
            retention_balance.FontFace = "Tahoma";
            retention_balance.FontSize = 9F;
            retention_balance.FormatStr = "";
            retention_balance.Location = new Point(855, 72);
            retention_balance.Name = "retention_balance";
            retention_balance.Size = new Size(282, 21);
            retention_balance.TabIndex = 42;
            retention_balance.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            retention_balance.Title = "Balance";
            retention_balance.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            retention_balance.TitleWidth = 130;
            // 
            // paid_sum
            // 
            paid_sum.ControlHeight = 21;
            paid_sum.ControlWidth = 282;
            paid_sum.FontColor = Color.Black;
            paid_sum.FontFace = "Tahoma";
            paid_sum.FontSize = 9F;
            paid_sum.FormatStr = "";
            paid_sum.Location = new Point(855, 48);
            paid_sum.Name = "paid_sum";
            paid_sum.Size = new Size(282, 21);
            paid_sum.TabIndex = 41;
            paid_sum.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            paid_sum.Title = "Accumulated";
            paid_sum.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            paid_sum.TitleWidth = 130;
            // 
            // supplier_retention
            // 
            supplier_retention.ControlHeight = 21;
            supplier_retention.ControlWidth = 282;
            supplier_retention.FontColor = Color.Black;
            supplier_retention.FontFace = "Tahoma";
            supplier_retention.FontSize = 9F;
            supplier_retention.FormatStr = "";
            supplier_retention.Location = new Point(855, 25);
            supplier_retention.Name = "supplier_retention";
            supplier_retention.Size = new Size(282, 21);
            supplier_retention.TabIndex = 43;
            supplier_retention.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier_retention.Title = "Retention Amount";
            supplier_retention.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier_retention.TitleWidth = 130;
            // 
            // prj_currency
            // 
            prj_currency.ControlHeight = 21;
            prj_currency.ControlWidth = 248;
            prj_currency.FldTy = null;
            prj_currency.FontColor = Color.Black;
            prj_currency.FontFace = "Tahoma";
            prj_currency.FontSize = 9F;
            prj_currency.Location = new Point(597, 26);
            prj_currency.Name = "prj_currency";
            prj_currency.Size = new Size(248, 21);
            prj_currency.TabIndex = 40;
            prj_currency.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            prj_currency.Title = "Currency";
            prj_currency.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            prj_currency.TitleWidth = 100;
            // 
            // prj_currencyRate
            // 
            prj_currencyRate.ControlHeight = 21;
            prj_currencyRate.ControlWidth = 248;
            prj_currencyRate.FontColor = Color.Black;
            prj_currencyRate.FontFace = "Tahoma";
            prj_currencyRate.FontSize = 9F;
            prj_currencyRate.FormatStr = "";
            prj_currencyRate.Location = new Point(597, 50);
            prj_currencyRate.Name = "prj_currencyRate";
            prj_currencyRate.Size = new Size(248, 21);
            prj_currencyRate.TabIndex = 39;
            prj_currencyRate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            prj_currencyRate.Title = "Rate";
            prj_currencyRate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            prj_currencyRate.TitleWidth = 100;
            // 
            // supplier_name
            // 
            supplier_name.ControlHeight = 21;
            supplier_name.ControlWidth = 333;
            supplier_name.FontColor = Color.Black;
            supplier_name.FontFace = "Tahoma";
            supplier_name.FontSize = 9F;
            supplier_name.FormatStr = "";
            supplier_name.Location = new Point(258, 49);
            supplier_name.Name = "supplier_name";
            supplier_name.Size = new Size(333, 21);
            supplier_name.TabIndex = 37;
            supplier_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier_name.Title = "";
            supplier_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier_name.TitleWidth = 0;
            // 
            // project_name
            // 
            project_name.ControlHeight = 21;
            project_name.ControlWidth = 333;
            project_name.FontColor = Color.Black;
            project_name.FontFace = "Tahoma";
            project_name.FontSize = 9F;
            project_name.FormatStr = "";
            project_name.Location = new Point(258, 26);
            project_name.Name = "project_name";
            project_name.Size = new Size(333, 21);
            project_name.TabIndex = 38;
            project_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_name.Title = "UCTextBox";
            project_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_name.TitleWidth = 0;
            // 
            // supplier
            // 
            supplier.ControlHeight = 21;
            supplier.ControlWidth = 248;
            supplier.FontColor = Color.Black;
            supplier.FontFace = "Tahoma";
            supplier.FontSize = 9F;
            supplier.FormatStr = "";
            supplier.Location = new Point(7, 49);
            supplier.Name = "supplier";
            supplier.Size = new Size(248, 21);
            supplier.TabIndex = 35;
            supplier.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier.Title = "Supplier";
            supplier.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier.TitleWidth = 100;
            // 
            // project
            // 
            project.ControlHeight = 21;
            project.ControlWidth = 248;
            project.FontColor = Color.Black;
            project.FontFace = "Tahoma";
            project.FontSize = 9F;
            project.FormatStr = "";
            project.Location = new Point(7, 26);
            project.Name = "project";
            project.Size = new Size(248, 21);
            project.TabIndex = 36;
            project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.Title = "Project";
            project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.TitleWidth = 100;
            // 
            // ucSplit4
            // 
            ucSplit4.Dock = DockStyle.Fill;
            ucSplit4.FixedPanel = FixedPanel.Panel1;
            ucSplit4.Location = new Point(0, 0);
            ucSplit4.Name = "ucSplit4";
            // 
            // ucSplit4.Panel1
            // 
            ucSplit4.Panel1.Controls.Add(g20);
            // 
            // ucSplit4.Panel2
            // 
            ucSplit4.Panel2.Controls.Add(ucSplit5);
            ucSplit4.Size = new Size(1461, 642);
            ucSplit4.SplitterDistance = 266;
            ucSplit4.TabIndex = 0;
            ucSplit4.TitleWidth = 121;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(266, 642);
            g20.TabIndex = 0;
            // 
            // ucSplit5
            // 
            ucSplit5.Dock = DockStyle.Fill;
            ucSplit5.FixedPanel = FixedPanel.Panel1;
            ucSplit5.Location = new Point(0, 0);
            ucSplit5.Name = "ucSplit5";
            ucSplit5.Orientation = Orientation.Horizontal;
            // 
            // ucSplit5.Panel1
            // 
            ucSplit5.Panel1.Controls.Add(ucPanel3);
            // 
            // ucSplit5.Panel2
            // 
            ucSplit5.Panel2.Controls.Add(ucTab1);
            ucSplit5.Size = new Size(1191, 642);
            ucSplit5.SplitterDistance = 180;
            ucSplit5.TabIndex = 0;
            ucSplit5.TitleWidth = 121;
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(note);
            ucPanel3.Controls.Add(btn_getdata);
            ucPanel3.Controls.Add(ivc_sumNet);
            ucPanel3.Controls.Add(ivc_sumDeduction);
            ucPanel3.Controls.Add(ivc_sumAmount);
            ucPanel3.Controls.Add(payment_term);
            ucPanel3.Controls.Add(payment_type);
            ucPanel3.Controls.Add(payment_date);
            ucPanel3.Controls.Add(payment_days);
            ucPanel3.Controls.Add(supplier_invoice_no);
            ucPanel3.Controls.Add(status);
            ucPanel3.Controls.Add(currency);
            ucPanel3.Controls.Add(currency_rate);
            ucPanel3.Controls.Add(release_date);
            ucPanel3.Controls.Add(release_no);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(0, 0);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(1191, 180);
            ucPanel3.TabIndex = 0;
            ucPanel3.Text = "Retention Invoice Info";
            // 
            // note
            // 
            note.ControlHeight = 57;
            note.ControlWidth = 756;
            note.FontColor = Color.Black;
            note.FontFace = "Tahoma";
            note.FontSize = 9F;
            note.Location = new Point(5, 118);
            note.Name = "note";
            note.Size = new Size(756, 57);
            note.TabIndex = 48;
            note.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            note.Title = "Note";
            note.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            note.TitleWidth = 98;
            // 
            // btn_getdata
            // 
            btn_getdata.Appearance.BackColor = Color.DarkGray;
            btn_getdata.Appearance.Font = new Font("Tahoma", 9F);
            btn_getdata.Appearance.Options.UseBackColor = true;
            btn_getdata.Appearance.Options.UseFont = true;
            btn_getdata.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_getdata.ControlHeight = 44;
            btn_getdata.ControlWidth = 148;
            btn_getdata.FontBold = FontStyle.Regular;
            btn_getdata.FontFace = "Tahoma";
            btn_getdata.FontSize = 9F;
            btn_getdata.Location = new Point(867, 100);
            btn_getdata.Name = "btn_getdata";
            btn_getdata.Size = new Size(148, 44);
            btn_getdata.TabIndex = 47;
            btn_getdata.Title = "Get Invoice";
            btn_getdata.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ivc_sumNet
            // 
            ivc_sumNet.ControlHeight = 21;
            ivc_sumNet.ControlWidth = 248;
            ivc_sumNet.FontColor = Color.Black;
            ivc_sumNet.FontFace = "Tahoma";
            ivc_sumNet.FontSize = 9F;
            ivc_sumNet.FormatStr = "";
            ivc_sumNet.Location = new Point(767, 73);
            ivc_sumNet.Name = "ivc_sumNet";
            ivc_sumNet.Size = new Size(248, 21);
            ivc_sumNet.TabIndex = 34;
            ivc_sumNet.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumNet.Title = "Net Amounts";
            ivc_sumNet.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumNet.TitleWidth = 100;
            // 
            // ivc_sumDeduction
            // 
            ivc_sumDeduction.ControlHeight = 21;
            ivc_sumDeduction.ControlWidth = 248;
            ivc_sumDeduction.FontColor = Color.Black;
            ivc_sumDeduction.FontFace = "Tahoma";
            ivc_sumDeduction.FontSize = 9F;
            ivc_sumDeduction.FormatStr = "";
            ivc_sumDeduction.Location = new Point(767, 50);
            ivc_sumDeduction.Name = "ivc_sumDeduction";
            ivc_sumDeduction.Size = new Size(248, 21);
            ivc_sumDeduction.TabIndex = 35;
            ivc_sumDeduction.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumDeduction.Title = "Deduction";
            ivc_sumDeduction.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumDeduction.TitleWidth = 100;
            // 
            // ivc_sumAmount
            // 
            ivc_sumAmount.ControlHeight = 21;
            ivc_sumAmount.ControlWidth = 248;
            ivc_sumAmount.FontColor = Color.Black;
            ivc_sumAmount.FontFace = "Tahoma";
            ivc_sumAmount.FontSize = 9F;
            ivc_sumAmount.FormatStr = "";
            ivc_sumAmount.Location = new Point(767, 26);
            ivc_sumAmount.Name = "ivc_sumAmount";
            ivc_sumAmount.Size = new Size(248, 21);
            ivc_sumAmount.TabIndex = 36;
            ivc_sumAmount.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumAmount.Title = "Paid(Incl. Item)";
            ivc_sumAmount.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumAmount.TitleWidth = 100;
            // 
            // payment_term
            // 
            payment_term.ControlHeight = 21;
            payment_term.ControlWidth = 248;
            payment_term.FldTy = null;
            payment_term.FontColor = Color.Black;
            payment_term.FontFace = "Tahoma";
            payment_term.FontSize = 9F;
            payment_term.Location = new Point(513, 49);
            payment_term.Name = "payment_term";
            payment_term.Size = new Size(248, 21);
            payment_term.TabIndex = 32;
            payment_term.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_term.Title = "Payment Term";
            payment_term.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_term.TitleWidth = 100;
            // 
            // payment_type
            // 
            payment_type.ControlHeight = 21;
            payment_type.ControlWidth = 248;
            payment_type.FldTy = null;
            payment_type.FontColor = Color.Black;
            payment_type.FontFace = "Tahoma";
            payment_type.FontSize = 9F;
            payment_type.Location = new Point(513, 26);
            payment_type.Name = "payment_type";
            payment_type.Size = new Size(248, 21);
            payment_type.TabIndex = 33;
            payment_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_type.Title = "Payment Type";
            payment_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_type.TitleWidth = 100;
            // 
            // payment_date
            // 
            payment_date.ControlHeight = 21;
            payment_date.ControlWidth = 248;
            payment_date.FontColor = Color.Black;
            payment_date.FontFace = "Tahoma";
            payment_date.FontSize = 9F;
            payment_date.FormatStr = "";
            payment_date.Location = new Point(513, 95);
            payment_date.Name = "payment_date";
            payment_date.Size = new Size(248, 21);
            payment_date.TabIndex = 31;
            payment_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_date.Title = "Payment Date";
            payment_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_date.TitleWidth = 100;
            // 
            // payment_days
            // 
            payment_days.ControlHeight = 21;
            payment_days.ControlWidth = 248;
            payment_days.FontColor = Color.Black;
            payment_days.FontFace = "Tahoma";
            payment_days.FontSize = 9F;
            payment_days.FormatStr = "";
            payment_days.Location = new Point(513, 72);
            payment_days.Name = "payment_days";
            payment_days.Size = new Size(248, 21);
            payment_days.TabIndex = 30;
            payment_days.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_days.Title = "Payment Days";
            payment_days.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_days.TitleWidth = 100;
            // 
            // supplier_invoice_no
            // 
            supplier_invoice_no.ControlHeight = 21;
            supplier_invoice_no.ControlWidth = 248;
            supplier_invoice_no.FontColor = Color.Black;
            supplier_invoice_no.FontFace = "Tahoma";
            supplier_invoice_no.FontSize = 9F;
            supplier_invoice_no.FormatStr = "";
            supplier_invoice_no.Location = new Point(259, 72);
            supplier_invoice_no.Name = "supplier_invoice_no";
            supplier_invoice_no.Size = new Size(248, 21);
            supplier_invoice_no.TabIndex = 29;
            supplier_invoice_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier_invoice_no.Title = "Supplier Invoice ";
            supplier_invoice_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier_invoice_no.TitleWidth = 100;
            // 
            // status
            // 
            status.ControlHeight = 21;
            status.ControlWidth = 248;
            status.FldTy = null;
            status.FontColor = Color.Black;
            status.FontFace = "Tahoma";
            status.FontSize = 9F;
            status.Location = new Point(5, 72);
            status.Name = "status";
            status.Size = new Size(248, 21);
            status.TabIndex = 27;
            status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.Title = "Status";
            status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.TitleWidth = 100;
            // 
            // currency
            // 
            currency.ControlHeight = 21;
            currency.ControlWidth = 248;
            currency.FldTy = null;
            currency.FontColor = Color.Black;
            currency.FontFace = "Tahoma";
            currency.FontSize = 9F;
            currency.Location = new Point(259, 26);
            currency.Name = "currency";
            currency.Size = new Size(248, 21);
            currency.TabIndex = 28;
            currency.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency.Title = "Currency";
            currency.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency.TitleWidth = 100;
            // 
            // currency_rate
            // 
            currency_rate.ControlHeight = 21;
            currency_rate.ControlWidth = 248;
            currency_rate.FontColor = Color.Black;
            currency_rate.FontFace = "Tahoma";
            currency_rate.FontSize = 9F;
            currency_rate.FormatStr = "";
            currency_rate.Location = new Point(259, 49);
            currency_rate.Name = "currency_rate";
            currency_rate.Size = new Size(248, 21);
            currency_rate.TabIndex = 26;
            currency_rate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency_rate.Title = "Rate";
            currency_rate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency_rate.TitleWidth = 100;
            // 
            // release_date
            // 
            release_date.ControlHeight = 21;
            release_date.ControlWidth = 248;
            release_date.FontColor = Color.Black;
            release_date.FontFace = "Tahoma";
            release_date.FontSize = 9F;
            release_date.FormatStr = "";
            release_date.Location = new Point(5, 49);
            release_date.Name = "release_date";
            release_date.Size = new Size(248, 21);
            release_date.TabIndex = 23;
            release_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            release_date.Title = "Release Date";
            release_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            release_date.TitleWidth = 100;
            // 
            // release_no
            // 
            release_no.ControlHeight = 21;
            release_no.ControlWidth = 248;
            release_no.FontColor = Color.Black;
            release_no.FontFace = "Tahoma";
            release_no.FontSize = 9F;
            release_no.FormatStr = "";
            release_no.Location = new Point(5, 26);
            release_no.Name = "release_no";
            release_no.Size = new Size(248, 21);
            release_no.TabIndex = 22;
            release_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            release_no.Title = "Release No";
            release_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            release_no.TitleWidth = 100;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1191, 458);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g30);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1189, 433);
            xtraTabPage1.TabPageWidth = 100;
            xtraTabPage1.Text = "Invoice";
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(1189, 433);
            g30.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(cuFtp);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1189, 423);
            xtraTabPage2.TabPageWidth = 100;
            xtraTabPage2.Text = "Document";
            // 
            // cuFtp
            // 
            cuFtp.Dock = DockStyle.Fill;
            cuFtp.Location = new Point(0, 0);
            cuFtp.Name = "cuFtp";
            cuFtp.Size = new Size(1189, 423);
            cuFtp.TabIndex = 0;
            // 
            // SO350
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SO350";
            Size = new Size(1818, 831);
            Load += SO350_Load;
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
            ucSplit4.Panel1.ResumeLayout(false);
            ucSplit4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit4).EndInit();
            ucSplit4.ResumeLayout(false);
            ucSplit5.Panel1.ResumeLayout(false);
            ucSplit5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit5).EndInit();
            ucSplit5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel3).EndInit();
            ucPanel3.ResumeLayout(false);
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
        private Ctrls.UCSplit ucSplit4;
        private Ctrls.UCSplit ucSplit5;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCPanel ucPanel3;
        private Ctrls.UCGridSet g30;
        private Ctrls.UCGridSet cuFtp;
        private Ctrls.UCTextBox s_supplier;
        private Ctrls.UCTextBox s_project;
        private Ctrls.UCTextBox supplier_name;
        private Ctrls.UCTextBox project_name;
        private Ctrls.UCTextBox supplier;
        private Ctrls.UCTextBox project;
        private Ctrls.UCCodeBox prj_currency;
        private Ctrls.UCTextBox prj_currencyRate;
        private Ctrls.UCTextBox retention_balance;
        private Ctrls.UCTextBox paid_sum;
        private Ctrls.UCTextBox supplier_retention;
        private Ctrls.UCCodeBox status;
        private Ctrls.UCCodeBox currency;
        private Ctrls.UCTextBox currency_rate;
        private Ctrls.UCDateBox release_date;
        private Ctrls.UCTextBox release_no;
        private Ctrls.UCTextBox supplier_invoice_no;
        private Ctrls.UCCodeBox payment_term;
        private Ctrls.UCCodeBox payment_type;
        private Ctrls.UCDateBox payment_date;
        private Ctrls.UCTextBox payment_days;
        private Ctrls.UCTextBox ivc_sumNet;
        private Ctrls.UCTextBox ivc_sumDeduction;
        private Ctrls.UCTextBox ivc_sumAmount;
        private Ctrls.UCRichText memo;
        private Label label3;
        private Ctrls.UCButton btn_getdata;
        private Ctrls.UCNote note;
    }
}
