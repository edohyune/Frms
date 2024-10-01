namespace EpicV004.Frms
{
    partial class SO300
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
            s_status = new Ctrls.UCChkCodeBox();
            s_supplier = new Ctrls.UCTextBox();
            s_project = new Ctrls.UCTextBox();
            f_sono = new Ctrls.UCTextBox();
            f_invoice_no = new Ctrls.UCTextBox();
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            note = new Ctrls.UCNote();
            sr_guarantee_na = new Ctrls.UCCheckBox();
            sr_guarantee_retention = new Ctrls.UCCheckBox();
            sr_performance_bond = new Ctrls.UCCheckBox();
            sr_guarantee_bank = new Ctrls.UCCheckBox();
            btn_getdata = new Ctrls.UCButton();
            label2 = new Label();
            sr_mesurement_type = new Ctrls.UCCodeBox();
            sr_contract_type = new Ctrls.UCCodeBox();
            ucTextBox1 = new Ctrls.UCTextBox();
            ucTextBox5 = new Ctrls.UCTextBox();
            ucTextBox6 = new Ctrls.UCTextBox();
            supplier_name = new Ctrls.UCTextBox();
            project_name = new Ctrls.UCTextBox();
            payment_term = new Ctrls.UCCodeBox();
            payment_type = new Ctrls.UCCodeBox();
            status = new Ctrls.UCCodeBox();
            currency = new Ctrls.UCCodeBox();
            supplier = new Ctrls.UCTextBox();
            project = new Ctrls.UCTextBox();
            supplier_invoice_no = new Ctrls.UCTextBox();
            currency_rate = new Ctrls.UCTextBox();
            invoice_end = new Ctrls.UCDateBox();
            invoice_start = new Ctrls.UCDateBox();
            vat_date = new Ctrls.UCDateBox();
            payment_date = new Ctrls.UCDateBox();
            invoice_date = new Ctrls.UCDateBox();
            dp_usePer = new Ctrls.UCTextBox();
            dp_amount = new Ctrls.UCTextBox();
            dp_invoiceNo = new Ctrls.UCTextBox();
            ivc_totalAmount = new Ctrls.UCTextBox();
            ivc_paidAmount = new Ctrls.UCTextBox();
            ivc_sumRetention = new Ctrls.UCTextBox();
            ivc_sumVat = new Ctrls.UCTextBox();
            ivc_sumTotal = new Ctrls.UCTextBox();
            downpayment = new Ctrls.UCTextBox();
            ivc_sumNet = new Ctrls.UCTextBox();
            ivc_sumDeduction = new Ctrls.UCTextBox();
            ivc_sumAmount = new Ctrls.UCTextBox();
            so_balance = new Ctrls.UCTextBox();
            paid_sum = new Ctrls.UCTextBox();
            so_downpayment = new Ctrls.UCTextBox();
            so_amount = new Ctrls.UCTextBox();
            so_doc_no = new Ctrls.UCTextBox();
            tax_invoice_no = new Ctrls.UCTextBox();
            payment_days = new Ctrls.UCTextBox();
            so_invoice_no = new Ctrls.UCTextBox();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            cuFtp = new Ctrls.UCGridSet();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            ucSplit1.Size = new Size(1604, 798);
            ucSplit1.SplitterDistance = 86;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_status);
            ucPanel1.Controls.Add(s_supplier);
            ucPanel1.Controls.Add(s_project);
            ucPanel1.Controls.Add(f_sono);
            ucPanel1.Controls.Add(f_invoice_no);
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1604, 86);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // s_status
            // 
            s_status.ControlHeight = 21;
            s_status.ControlWidth = 200;
            s_status.FontFace = "Tahoma";
            s_status.FontSize = 9F;
            s_status.Location = new Point(634, 29);
            s_status.Name = "s_status";
            s_status.Size = new Size(200, 21);
            s_status.TabIndex = 8;
            s_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_status.Title = "Status";
            s_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_status.TitleWidth = 90;
            // 
            // s_supplier
            // 
            s_supplier.ControlHeight = 21;
            s_supplier.ControlWidth = 200;
            s_supplier.FontColor = Color.Black;
            s_supplier.FontFace = "Tahoma";
            s_supplier.FontSize = 9F;
            s_supplier.FormatStr = "";
            s_supplier.Location = new Point(428, 29);
            s_supplier.Name = "s_supplier";
            s_supplier.Size = new Size(200, 21);
            s_supplier.TabIndex = 5;
            s_supplier.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_supplier.Title = "Supplier";
            s_supplier.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_supplier.TitleWidth = 90;
            // 
            // s_project
            // 
            s_project.ControlHeight = 21;
            s_project.ControlWidth = 200;
            s_project.FontColor = Color.Black;
            s_project.FontFace = "Tahoma";
            s_project.FontSize = 9F;
            s_project.FormatStr = "";
            s_project.Location = new Point(428, 56);
            s_project.Name = "s_project";
            s_project.Size = new Size(200, 21);
            s_project.TabIndex = 5;
            s_project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.Title = "Project";
            s_project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.TitleWidth = 90;
            // 
            // f_sono
            // 
            f_sono.ControlHeight = 21;
            f_sono.ControlWidth = 200;
            f_sono.FontColor = Color.Black;
            f_sono.FontFace = "Tahoma";
            f_sono.FontSize = 9F;
            f_sono.FormatStr = "";
            f_sono.Location = new Point(222, 56);
            f_sono.Name = "f_sono";
            f_sono.Size = new Size(200, 21);
            f_sono.TabIndex = 6;
            f_sono.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_sono.Title = "SO No";
            f_sono.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_sono.TitleWidth = 90;
            // 
            // f_invoice_no
            // 
            f_invoice_no.ControlHeight = 21;
            f_invoice_no.ControlWidth = 200;
            f_invoice_no.FontColor = Color.Black;
            f_invoice_no.FontFace = "Tahoma";
            f_invoice_no.FontSize = 9F;
            f_invoice_no.FormatStr = "";
            f_invoice_no.Location = new Point(222, 29);
            f_invoice_no.Name = "f_invoice_no";
            f_invoice_no.Size = new Size(200, 21);
            f_invoice_no.TabIndex = 7;
            f_invoice_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_invoice_no.Title = "Invoice No";
            f_invoice_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_invoice_no.TitleWidth = 90;
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 200;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(5, 56);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(200, 21);
            to_dt.TabIndex = 3;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 90;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 200;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 29);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(200, 21);
            fr_dt.TabIndex = 4;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Invoice Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 90;
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
            ucSplit2.Size = new Size(1604, 708);
            ucSplit2.SplitterDistance = 418;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(418, 708);
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
            ucSplit3.Size = new Size(1182, 708);
            ucSplit3.SplitterDistance = 320;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(note);
            ucPanel2.Controls.Add(sr_guarantee_na);
            ucPanel2.Controls.Add(sr_guarantee_retention);
            ucPanel2.Controls.Add(sr_performance_bond);
            ucPanel2.Controls.Add(sr_guarantee_bank);
            ucPanel2.Controls.Add(btn_getdata);
            ucPanel2.Controls.Add(label4);
            ucPanel2.Controls.Add(label3);
            ucPanel2.Controls.Add(label1);
            ucPanel2.Controls.Add(label2);
            ucPanel2.Controls.Add(sr_mesurement_type);
            ucPanel2.Controls.Add(sr_contract_type);
            ucPanel2.Controls.Add(ucTextBox1);
            ucPanel2.Controls.Add(ucTextBox5);
            ucPanel2.Controls.Add(ucTextBox6);
            ucPanel2.Controls.Add(supplier_name);
            ucPanel2.Controls.Add(project_name);
            ucPanel2.Controls.Add(payment_term);
            ucPanel2.Controls.Add(payment_type);
            ucPanel2.Controls.Add(status);
            ucPanel2.Controls.Add(currency);
            ucPanel2.Controls.Add(supplier);
            ucPanel2.Controls.Add(project);
            ucPanel2.Controls.Add(supplier_invoice_no);
            ucPanel2.Controls.Add(currency_rate);
            ucPanel2.Controls.Add(invoice_end);
            ucPanel2.Controls.Add(invoice_start);
            ucPanel2.Controls.Add(vat_date);
            ucPanel2.Controls.Add(payment_date);
            ucPanel2.Controls.Add(invoice_date);
            ucPanel2.Controls.Add(dp_usePer);
            ucPanel2.Controls.Add(dp_amount);
            ucPanel2.Controls.Add(dp_invoiceNo);
            ucPanel2.Controls.Add(ivc_totalAmount);
            ucPanel2.Controls.Add(ivc_paidAmount);
            ucPanel2.Controls.Add(ivc_sumRetention);
            ucPanel2.Controls.Add(ivc_sumVat);
            ucPanel2.Controls.Add(ivc_sumTotal);
            ucPanel2.Controls.Add(downpayment);
            ucPanel2.Controls.Add(ivc_sumNet);
            ucPanel2.Controls.Add(ivc_sumDeduction);
            ucPanel2.Controls.Add(ivc_sumAmount);
            ucPanel2.Controls.Add(so_balance);
            ucPanel2.Controls.Add(paid_sum);
            ucPanel2.Controls.Add(so_downpayment);
            ucPanel2.Controls.Add(so_amount);
            ucPanel2.Controls.Add(so_doc_no);
            ucPanel2.Controls.Add(tax_invoice_no);
            ucPanel2.Controls.Add(payment_days);
            ucPanel2.Controls.Add(so_invoice_no);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1182, 320);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Service Invoice Info";
            // 
            // note
            // 
            note.ControlHeight = 39;
            note.ControlWidth = 754;
            note.FontColor = Color.Black;
            note.FontFace = "Tahoma";
            note.FontSize = 9F;
            note.Location = new Point(5, 212);
            note.Name = "note";
            note.Size = new Size(754, 39);
            note.TabIndex = 48;
            note.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            note.Title = "Note";
            note.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            note.TitleWidth = 97;
            // 
            // sr_guarantee_na
            // 
            sr_guarantee_na.Checked = false;
            sr_guarantee_na.ControlHeight = 21;
            sr_guarantee_na.ControlWidth = 109;
            sr_guarantee_na.FontColor = Color.Black;
            sr_guarantee_na.FontFace = "Tahoma";
            sr_guarantee_na.FontSize = 9F;
            sr_guarantee_na.Location = new Point(650, 282);
            sr_guarantee_na.Name = "sr_guarantee_na";
            sr_guarantee_na.Size = new Size(109, 21);
            sr_guarantee_na.TabIndex = 47;
            sr_guarantee_na.Text = "Not Applicable";
            sr_guarantee_na.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_guarantee_na.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // sr_guarantee_retention
            // 
            sr_guarantee_retention.Checked = false;
            sr_guarantee_retention.ControlHeight = 21;
            sr_guarantee_retention.ControlWidth = 81;
            sr_guarantee_retention.FontColor = Color.Black;
            sr_guarantee_retention.FontFace = "Tahoma";
            sr_guarantee_retention.FontSize = 9F;
            sr_guarantee_retention.Location = new Point(503, 282);
            sr_guarantee_retention.Name = "sr_guarantee_retention";
            sr_guarantee_retention.Size = new Size(81, 21);
            sr_guarantee_retention.TabIndex = 47;
            sr_guarantee_retention.Text = "Retention";
            sr_guarantee_retention.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_guarantee_retention.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // sr_performance_bond
            // 
            sr_performance_bond.Checked = false;
            sr_performance_bond.ControlHeight = 21;
            sr_performance_bond.ControlWidth = 129;
            sr_performance_bond.FontColor = Color.Black;
            sr_performance_bond.FontFace = "Tahoma";
            sr_performance_bond.FontSize = 9F;
            sr_performance_bond.Location = new Point(294, 282);
            sr_performance_bond.Name = "sr_performance_bond";
            sr_performance_bond.Size = new Size(129, 21);
            sr_performance_bond.TabIndex = 47;
            sr_performance_bond.Text = "Performance Bond";
            sr_performance_bond.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_performance_bond.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // sr_guarantee_bank
            // 
            sr_guarantee_bank.Checked = false;
            sr_guarantee_bank.ControlHeight = 21;
            sr_guarantee_bank.ControlWidth = 108;
            sr_guarantee_bank.FontColor = Color.Black;
            sr_guarantee_bank.FontFace = "Tahoma";
            sr_guarantee_bank.FontSize = 9F;
            sr_guarantee_bank.Location = new Point(106, 282);
            sr_guarantee_bank.Name = "sr_guarantee_bank";
            sr_guarantee_bank.Size = new Size(108, 21);
            sr_guarantee_bank.TabIndex = 47;
            sr_guarantee_bank.Text = "Bank Guarantee";
            sr_guarantee_bank.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_guarantee_bank.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // btn_getdata
            // 
            btn_getdata.Appearance.BackColor = Color.DarkGray;
            btn_getdata.Appearance.Font = new Font("Tahoma", 9F);
            btn_getdata.Appearance.Options.UseBackColor = true;
            btn_getdata.Appearance.Options.UseFont = true;
            btn_getdata.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_getdata.ControlHeight = 44;
            btn_getdata.ControlWidth = 113;
            btn_getdata.FontBold = FontStyle.Regular;
            btn_getdata.FontFace = "Tahoma";
            btn_getdata.FontSize = 9F;
            btn_getdata.Location = new Point(1025, 26);
            btn_getdata.Name = "btn_getdata";
            btn_getdata.Size = new Size(113, 44);
            btn_getdata.TabIndex = 30;
            btn_getdata.Title = "Get SO";
            btn_getdata.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            btn_getdata.Click += btn_getdata_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 285);
            label2.Name = "label2";
            label2.Size = new Size(64, 14);
            label2.TabIndex = 29;
            label2.Text = "Guarantee";
            // 
            // sr_mesurement_type
            // 
            sr_mesurement_type.ControlHeight = 21;
            sr_mesurement_type.ControlWidth = 380;
            sr_mesurement_type.FldTy = null;
            sr_mesurement_type.FontColor = Color.Black;
            sr_mesurement_type.FontFace = "Tahoma";
            sr_mesurement_type.FontSize = 9F;
            sr_mesurement_type.Location = new Point(379, 255);
            sr_mesurement_type.Name = "sr_mesurement_type";
            sr_mesurement_type.Size = new Size(380, 21);
            sr_mesurement_type.TabIndex = 23;
            sr_mesurement_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_mesurement_type.Title = "Measurement Type";
            sr_mesurement_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_mesurement_type.TitleWidth = 120;
            // 
            // sr_contract_type
            // 
            sr_contract_type.ControlHeight = 21;
            sr_contract_type.ControlWidth = 356;
            sr_contract_type.FldTy = null;
            sr_contract_type.FontColor = Color.Black;
            sr_contract_type.FontFace = "Tahoma";
            sr_contract_type.FontSize = 9F;
            sr_contract_type.Location = new Point(5, 255);
            sr_contract_type.Name = "sr_contract_type";
            sr_contract_type.Size = new Size(356, 21);
            sr_contract_type.TabIndex = 24;
            sr_contract_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_contract_type.Title = "Contract Type";
            sr_contract_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_contract_type.TitleWidth = 100;
            // 
            // ucTextBox1
            // 
            ucTextBox1.ControlHeight = 21;
            ucTextBox1.ControlWidth = 41;
            ucTextBox1.FontColor = Color.Black;
            ucTextBox1.FontFace = "Tahoma";
            ucTextBox1.FontSize = 9F;
            ucTextBox1.FormatStr = "";
            ucTextBox1.Location = new Point(584, 282);
            ucTextBox1.Name = "ucTextBox1";
            ucTextBox1.Size = new Size(41, 21);
            ucTextBox1.TabIndex = 20;
            ucTextBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox1.Title = "UCTextBox";
            ucTextBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox1.TitleWidth = 0;
            // 
            // ucTextBox5
            // 
            ucTextBox5.ControlHeight = 21;
            ucTextBox5.ControlWidth = 47;
            ucTextBox5.FontColor = Color.Black;
            ucTextBox5.FontFace = "Tahoma";
            ucTextBox5.FontSize = 9F;
            ucTextBox5.FormatStr = "";
            ucTextBox5.Location = new Point(429, 282);
            ucTextBox5.Name = "ucTextBox5";
            ucTextBox5.Size = new Size(47, 21);
            ucTextBox5.TabIndex = 21;
            ucTextBox5.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox5.Title = "UCTextBox";
            ucTextBox5.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox5.TitleWidth = 0;
            // 
            // ucTextBox6
            // 
            ucTextBox6.ControlHeight = 21;
            ucTextBox6.ControlWidth = 41;
            ucTextBox6.FontColor = Color.Black;
            ucTextBox6.FontFace = "Tahoma";
            ucTextBox6.FontSize = 9F;
            ucTextBox6.FormatStr = "";
            ucTextBox6.Location = new Point(220, 282);
            ucTextBox6.Name = "ucTextBox6";
            ucTextBox6.Size = new Size(41, 21);
            ucTextBox6.TabIndex = 22;
            ucTextBox6.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox6.Title = "UCTextBox";
            ucTextBox6.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox6.TitleWidth = 0;
            // 
            // supplier_name
            // 
            supplier_name.ControlHeight = 21;
            supplier_name.ControlWidth = 500;
            supplier_name.FontColor = Color.Black;
            supplier_name.FontFace = "Tahoma";
            supplier_name.FontSize = 9F;
            supplier_name.FormatStr = "";
            supplier_name.Location = new Point(259, 189);
            supplier_name.Name = "supplier_name";
            supplier_name.Size = new Size(500, 21);
            supplier_name.TabIndex = 17;
            supplier_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier_name.Title = "";
            supplier_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier_name.TitleWidth = 0;
            // 
            // project_name
            // 
            project_name.ControlHeight = 21;
            project_name.ControlWidth = 500;
            project_name.FontColor = Color.Black;
            project_name.FontFace = "Tahoma";
            project_name.FontSize = 9F;
            project_name.FormatStr = "";
            project_name.Location = new Point(259, 166);
            project_name.Name = "project_name";
            project_name.Size = new Size(500, 21);
            project_name.TabIndex = 18;
            project_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_name.Title = "UCTextBox";
            project_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_name.TitleWidth = 0;
            // 
            // payment_term
            // 
            payment_term.ControlHeight = 21;
            payment_term.ControlWidth = 248;
            payment_term.FldTy = null;
            payment_term.FontColor = Color.Black;
            payment_term.FontFace = "Tahoma";
            payment_term.FontSize = 9F;
            payment_term.Location = new Point(257, 49);
            payment_term.Name = "payment_term";
            payment_term.Size = new Size(248, 21);
            payment_term.TabIndex = 15;
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
            payment_type.Location = new Point(257, 26);
            payment_type.Name = "payment_type";
            payment_type.Size = new Size(248, 21);
            payment_type.TabIndex = 15;
            payment_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_type.Title = "Payment Type";
            payment_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_type.TitleWidth = 100;
            // 
            // status
            // 
            status.ControlHeight = 21;
            status.ControlWidth = 248;
            status.FldTy = null;
            status.FontColor = Color.Black;
            status.FontFace = "Tahoma";
            status.FontSize = 9F;
            status.Location = new Point(257, 140);
            status.Name = "status";
            status.Size = new Size(248, 21);
            status.TabIndex = 15;
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
            currency.Location = new Point(5, 118);
            currency.Name = "currency";
            currency.Size = new Size(248, 21);
            currency.TabIndex = 15;
            currency.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency.Title = "Currency";
            currency.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency.TitleWidth = 100;
            // 
            // supplier
            // 
            supplier.ControlHeight = 21;
            supplier.ControlWidth = 248;
            supplier.FontColor = Color.Black;
            supplier.FontFace = "Tahoma";
            supplier.FontSize = 9F;
            supplier.FormatStr = "";
            supplier.Location = new Point(5, 189);
            supplier.Name = "supplier";
            supplier.Size = new Size(248, 21);
            supplier.TabIndex = 14;
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
            project.Location = new Point(5, 166);
            project.Name = "project";
            project.Size = new Size(248, 21);
            project.TabIndex = 14;
            project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.Title = "Project";
            project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.TitleWidth = 100;
            // 
            // supplier_invoice_no
            // 
            supplier_invoice_no.ControlHeight = 21;
            supplier_invoice_no.ControlWidth = 248;
            supplier_invoice_no.FontColor = Color.Black;
            supplier_invoice_no.FontFace = "Tahoma";
            supplier_invoice_no.FontSize = 9F;
            supplier_invoice_no.FormatStr = "";
            supplier_invoice_no.Location = new Point(257, 118);
            supplier_invoice_no.Name = "supplier_invoice_no";
            supplier_invoice_no.Size = new Size(248, 21);
            supplier_invoice_no.TabIndex = 12;
            supplier_invoice_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier_invoice_no.Title = "Supplier Invoice ";
            supplier_invoice_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            supplier_invoice_no.TitleWidth = 100;
            // 
            // currency_rate
            // 
            currency_rate.ControlHeight = 21;
            currency_rate.ControlWidth = 248;
            currency_rate.FontColor = Color.Black;
            currency_rate.FontFace = "Tahoma";
            currency_rate.FontSize = 9F;
            currency_rate.FormatStr = "";
            currency_rate.Location = new Point(5, 142);
            currency_rate.Name = "currency_rate";
            currency_rate.Size = new Size(248, 21);
            currency_rate.TabIndex = 12;
            currency_rate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency_rate.Title = "Rate";
            currency_rate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency_rate.TitleWidth = 100;
            // 
            // invoice_end
            // 
            invoice_end.ControlHeight = 21;
            invoice_end.ControlWidth = 248;
            invoice_end.FontColor = Color.Black;
            invoice_end.FontFace = "Tahoma";
            invoice_end.FontSize = 9F;
            invoice_end.FormatStr = "";
            invoice_end.Location = new Point(5, 95);
            invoice_end.Name = "invoice_end";
            invoice_end.Size = new Size(248, 21);
            invoice_end.TabIndex = 10;
            invoice_end.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            invoice_end.Title = "~";
            invoice_end.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            invoice_end.TitleWidth = 100;
            // 
            // invoice_start
            // 
            invoice_start.ControlHeight = 21;
            invoice_start.ControlWidth = 248;
            invoice_start.FontColor = Color.Black;
            invoice_start.FontFace = "Tahoma";
            invoice_start.FontSize = 9F;
            invoice_start.FormatStr = "";
            invoice_start.Location = new Point(5, 72);
            invoice_start.Name = "invoice_start";
            invoice_start.Size = new Size(248, 21);
            invoice_start.TabIndex = 9;
            invoice_start.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            invoice_start.Title = "Invoice Period";
            invoice_start.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            invoice_start.TitleWidth = 100;
            // 
            // vat_date
            // 
            vat_date.ControlHeight = 21;
            vat_date.ControlWidth = 248;
            vat_date.FontColor = Color.Black;
            vat_date.FontFace = "Tahoma";
            vat_date.FontSize = 9F;
            vat_date.FormatStr = "";
            vat_date.Location = new Point(511, 49);
            vat_date.Name = "vat_date";
            vat_date.Size = new Size(248, 21);
            vat_date.TabIndex = 8;
            vat_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            vat_date.Title = "VAT Date";
            vat_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            vat_date.TitleWidth = 100;
            // 
            // payment_date
            // 
            payment_date.ControlHeight = 21;
            payment_date.ControlWidth = 248;
            payment_date.FontColor = Color.Black;
            payment_date.FontFace = "Tahoma";
            payment_date.FontSize = 9F;
            payment_date.FormatStr = "";
            payment_date.Location = new Point(257, 95);
            payment_date.Name = "payment_date";
            payment_date.Size = new Size(248, 21);
            payment_date.TabIndex = 8;
            payment_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_date.Title = "Invoice Date";
            payment_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_date.TitleWidth = 100;
            // 
            // invoice_date
            // 
            invoice_date.ControlHeight = 21;
            invoice_date.ControlWidth = 248;
            invoice_date.FontColor = Color.Black;
            invoice_date.FontFace = "Tahoma";
            invoice_date.FontSize = 9F;
            invoice_date.FormatStr = "";
            invoice_date.Location = new Point(5, 49);
            invoice_date.Name = "invoice_date";
            invoice_date.Size = new Size(248, 21);
            invoice_date.TabIndex = 8;
            invoice_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            invoice_date.Title = "Invoice Date";
            invoice_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            invoice_date.TitleWidth = 100;
            // 
            // dp_usePer
            // 
            dp_usePer.ControlHeight = 21;
            dp_usePer.ControlWidth = 248;
            dp_usePer.FontColor = Color.Black;
            dp_usePer.FontFace = "Tahoma";
            dp_usePer.FontSize = 9F;
            dp_usePer.FormatStr = "";
            dp_usePer.Location = new Point(511, 118);
            dp_usePer.Name = "dp_usePer";
            dp_usePer.Size = new Size(248, 21);
            dp_usePer.TabIndex = 7;
            dp_usePer.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dp_usePer.Title = "DP Use(%)";
            dp_usePer.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dp_usePer.TitleWidth = 100;
            // 
            // dp_amount
            // 
            dp_amount.ControlHeight = 21;
            dp_amount.ControlWidth = 248;
            dp_amount.FontColor = Color.Black;
            dp_amount.FontFace = "Tahoma";
            dp_amount.FontSize = 9F;
            dp_amount.FormatStr = "";
            dp_amount.Location = new Point(511, 95);
            dp_amount.Name = "dp_amount";
            dp_amount.Size = new Size(248, 21);
            dp_amount.TabIndex = 7;
            dp_amount.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dp_amount.Title = "DP Amount";
            dp_amount.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dp_amount.TitleWidth = 100;
            // 
            // dp_invoiceNo
            // 
            dp_invoiceNo.ControlHeight = 21;
            dp_invoiceNo.ControlWidth = 248;
            dp_invoiceNo.FontColor = Color.Black;
            dp_invoiceNo.FontFace = "Tahoma";
            dp_invoiceNo.FontSize = 9F;
            dp_invoiceNo.FormatStr = "";
            dp_invoiceNo.Location = new Point(511, 72);
            dp_invoiceNo.Name = "dp_invoiceNo";
            dp_invoiceNo.Size = new Size(248, 21);
            dp_invoiceNo.TabIndex = 7;
            dp_invoiceNo.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dp_invoiceNo.Title = "DP Invoice";
            dp_invoiceNo.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dp_invoiceNo.TitleWidth = 100;
            // 
            // ivc_totalAmount
            // 
            ivc_totalAmount.ControlHeight = 21;
            ivc_totalAmount.ControlWidth = 248;
            ivc_totalAmount.FontColor = Color.Black;
            ivc_totalAmount.FontFace = "Tahoma";
            ivc_totalAmount.FontSize = 9F;
            ivc_totalAmount.FormatStr = "";
            ivc_totalAmount.Location = new Point(765, 280);
            ivc_totalAmount.Name = "ivc_totalAmount";
            ivc_totalAmount.Size = new Size(248, 21);
            ivc_totalAmount.TabIndex = 7;
            ivc_totalAmount.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_totalAmount.Title = "Total Amount";
            ivc_totalAmount.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_totalAmount.TitleWidth = 100;
            // 
            // ivc_paidAmount
            // 
            ivc_paidAmount.ControlHeight = 21;
            ivc_paidAmount.ControlWidth = 248;
            ivc_paidAmount.FontColor = Color.Black;
            ivc_paidAmount.FontFace = "Tahoma";
            ivc_paidAmount.FontSize = 9F;
            ivc_paidAmount.FormatStr = "";
            ivc_paidAmount.Location = new Point(1019, 279);
            ivc_paidAmount.Name = "ivc_paidAmount";
            ivc_paidAmount.Size = new Size(248, 21);
            ivc_paidAmount.TabIndex = 7;
            ivc_paidAmount.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_paidAmount.Title = "Payment";
            ivc_paidAmount.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_paidAmount.TitleWidth = 100;
            // 
            // ivc_sumRetention
            // 
            ivc_sumRetention.ControlHeight = 21;
            ivc_sumRetention.ControlWidth = 248;
            ivc_sumRetention.FontColor = Color.Black;
            ivc_sumRetention.FontFace = "Tahoma";
            ivc_sumRetention.FontSize = 9F;
            ivc_sumRetention.FormatStr = "";
            ivc_sumRetention.Location = new Point(1019, 257);
            ivc_sumRetention.Name = "ivc_sumRetention";
            ivc_sumRetention.Size = new Size(248, 21);
            ivc_sumRetention.TabIndex = 7;
            ivc_sumRetention.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumRetention.Title = "Retention";
            ivc_sumRetention.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumRetention.TitleWidth = 100;
            // 
            // ivc_sumVat
            // 
            ivc_sumVat.ControlHeight = 21;
            ivc_sumVat.ControlWidth = 248;
            ivc_sumVat.FontColor = Color.Black;
            ivc_sumVat.FontFace = "Tahoma";
            ivc_sumVat.FontSize = 9F;
            ivc_sumVat.FormatStr = "";
            ivc_sumVat.Location = new Point(765, 257);
            ivc_sumVat.Name = "ivc_sumVat";
            ivc_sumVat.Size = new Size(248, 21);
            ivc_sumVat.TabIndex = 7;
            ivc_sumVat.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumVat.Title = "VAT(7%)";
            ivc_sumVat.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumVat.TitleWidth = 100;
            // 
            // ivc_sumTotal
            // 
            ivc_sumTotal.ControlHeight = 21;
            ivc_sumTotal.ControlWidth = 248;
            ivc_sumTotal.FontColor = Color.Black;
            ivc_sumTotal.FontFace = "Tahoma";
            ivc_sumTotal.FontSize = 9F;
            ivc_sumTotal.FormatStr = "";
            ivc_sumTotal.Location = new Point(765, 234);
            ivc_sumTotal.Name = "ivc_sumTotal";
            ivc_sumTotal.Size = new Size(248, 21);
            ivc_sumTotal.TabIndex = 7;
            ivc_sumTotal.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumTotal.Title = "INC Amounts";
            ivc_sumTotal.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumTotal.TitleWidth = 100;
            // 
            // downpayment
            // 
            downpayment.ControlHeight = 21;
            downpayment.ControlWidth = 248;
            downpayment.FontColor = Color.Black;
            downpayment.FontFace = "Tahoma";
            downpayment.FontSize = 9F;
            downpayment.FormatStr = "";
            downpayment.Location = new Point(765, 210);
            downpayment.Name = "downpayment";
            downpayment.Size = new Size(248, 21);
            downpayment.TabIndex = 7;
            downpayment.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            downpayment.Title = "Downpayment";
            downpayment.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            downpayment.TitleWidth = 100;
            // 
            // ivc_sumNet
            // 
            ivc_sumNet.ControlHeight = 21;
            ivc_sumNet.ControlWidth = 248;
            ivc_sumNet.FontColor = Color.Black;
            ivc_sumNet.FontFace = "Tahoma";
            ivc_sumNet.FontSize = 9F;
            ivc_sumNet.FormatStr = "";
            ivc_sumNet.Location = new Point(765, 187);
            ivc_sumNet.Name = "ivc_sumNet";
            ivc_sumNet.Size = new Size(248, 21);
            ivc_sumNet.TabIndex = 7;
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
            ivc_sumDeduction.Location = new Point(765, 164);
            ivc_sumDeduction.Name = "ivc_sumDeduction";
            ivc_sumDeduction.Size = new Size(248, 21);
            ivc_sumDeduction.TabIndex = 7;
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
            ivc_sumAmount.Location = new Point(765, 140);
            ivc_sumAmount.Name = "ivc_sumAmount";
            ivc_sumAmount.Size = new Size(248, 21);
            ivc_sumAmount.TabIndex = 7;
            ivc_sumAmount.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumAmount.Title = "Paid(Incl. Item)";
            ivc_sumAmount.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_sumAmount.TitleWidth = 100;
            // 
            // so_balance
            // 
            so_balance.ControlHeight = 21;
            so_balance.ControlWidth = 248;
            so_balance.FontColor = Color.Black;
            so_balance.FontFace = "Tahoma";
            so_balance.FontSize = 9F;
            so_balance.FormatStr = "";
            so_balance.Location = new Point(765, 118);
            so_balance.Name = "so_balance";
            so_balance.Size = new Size(248, 21);
            so_balance.TabIndex = 7;
            so_balance.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_balance.Title = "Balance";
            so_balance.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_balance.TitleWidth = 100;
            // 
            // paid_sum
            // 
            paid_sum.ControlHeight = 21;
            paid_sum.ControlWidth = 248;
            paid_sum.FontColor = Color.Black;
            paid_sum.FontFace = "Tahoma";
            paid_sum.FontSize = 9F;
            paid_sum.FormatStr = "";
            paid_sum.Location = new Point(765, 95);
            paid_sum.Name = "paid_sum";
            paid_sum.Size = new Size(248, 21);
            paid_sum.TabIndex = 7;
            paid_sum.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            paid_sum.Title = "Accumulated";
            paid_sum.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            paid_sum.TitleWidth = 100;
            // 
            // so_downpayment
            // 
            so_downpayment.ControlHeight = 21;
            so_downpayment.ControlWidth = 248;
            so_downpayment.FontColor = Color.Black;
            so_downpayment.FontFace = "Tahoma";
            so_downpayment.FontSize = 9F;
            so_downpayment.FormatStr = "";
            so_downpayment.Location = new Point(765, 72);
            so_downpayment.Name = "so_downpayment";
            so_downpayment.Size = new Size(248, 21);
            so_downpayment.TabIndex = 7;
            so_downpayment.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_downpayment.Title = "Down Payment";
            so_downpayment.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_downpayment.TitleWidth = 100;
            // 
            // so_amount
            // 
            so_amount.ControlHeight = 21;
            so_amount.ControlWidth = 248;
            so_amount.FontColor = Color.Black;
            so_amount.FontFace = "Tahoma";
            so_amount.FontSize = 9F;
            so_amount.FormatStr = "";
            so_amount.Location = new Point(765, 49);
            so_amount.Name = "so_amount";
            so_amount.Size = new Size(248, 21);
            so_amount.TabIndex = 7;
            so_amount.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_amount.Title = "Contract Amount";
            so_amount.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_amount.TitleWidth = 100;
            // 
            // so_doc_no
            // 
            so_doc_no.ControlHeight = 21;
            so_doc_no.ControlWidth = 248;
            so_doc_no.FontColor = Color.Black;
            so_doc_no.FontFace = "Tahoma";
            so_doc_no.FontSize = 9F;
            so_doc_no.FormatStr = "";
            so_doc_no.Location = new Point(765, 26);
            so_doc_no.Name = "so_doc_no";
            so_doc_no.Size = new Size(248, 21);
            so_doc_no.TabIndex = 7;
            so_doc_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_doc_no.Title = "SO No";
            so_doc_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_doc_no.TitleWidth = 100;
            // 
            // tax_invoice_no
            // 
            tax_invoice_no.ControlHeight = 21;
            tax_invoice_no.ControlWidth = 248;
            tax_invoice_no.FontColor = Color.Black;
            tax_invoice_no.FontFace = "Tahoma";
            tax_invoice_no.FontSize = 9F;
            tax_invoice_no.FormatStr = "";
            tax_invoice_no.Location = new Point(511, 26);
            tax_invoice_no.Name = "tax_invoice_no";
            tax_invoice_no.Size = new Size(248, 21);
            tax_invoice_no.TabIndex = 7;
            tax_invoice_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            tax_invoice_no.Title = "TAX Invoice No";
            tax_invoice_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            tax_invoice_no.TitleWidth = 100;
            // 
            // payment_days
            // 
            payment_days.ControlHeight = 21;
            payment_days.ControlWidth = 248;
            payment_days.FontColor = Color.Black;
            payment_days.FontFace = "Tahoma";
            payment_days.FontSize = 9F;
            payment_days.FormatStr = "";
            payment_days.Location = new Point(257, 72);
            payment_days.Name = "payment_days";
            payment_days.Size = new Size(248, 21);
            payment_days.TabIndex = 7;
            payment_days.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_days.Title = "Invoice No";
            payment_days.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_days.TitleWidth = 100;
            // 
            // so_invoice_no
            // 
            so_invoice_no.ControlHeight = 21;
            so_invoice_no.ControlWidth = 248;
            so_invoice_no.FontColor = Color.Black;
            so_invoice_no.FontFace = "Tahoma";
            so_invoice_no.FontSize = 9F;
            so_invoice_no.FormatStr = "";
            so_invoice_no.Location = new Point(5, 26);
            so_invoice_no.Name = "so_invoice_no";
            so_invoice_no.Size = new Size(248, 21);
            so_invoice_no.TabIndex = 7;
            so_invoice_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_invoice_no.Title = "Invoice No";
            so_invoice_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_invoice_no.TitleWidth = 100;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1182, 384);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g20);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1180, 359);
            xtraTabPage1.TabPageWidth = 100;
            xtraTabPage1.Text = "Invoice";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1180, 359);
            g20.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(cuFtp);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1180, 359);
            xtraTabPage2.TabPageWidth = 100;
            xtraTabPage2.Text = "Document";
            // 
            // cuFtp
            // 
            cuFtp.Dock = DockStyle.Fill;
            cuFtp.Location = new Point(0, 0);
            cuFtp.Name = "cuFtp";
            cuFtp.Size = new Size(1180, 359);
            cuFtp.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 285);
            label1.Name = "label1";
            label1.Size = new Size(19, 14);
            label1.TabIndex = 29;
            label1.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(482, 285);
            label3.Name = "label3";
            label3.Size = new Size(19, 14);
            label3.TabIndex = 29;
            label3.Text = "%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(627, 285);
            label4.Name = "label4";
            label4.Size = new Size(19, 14);
            label4.TabIndex = 29;
            label4.Text = "%";
            // 
            // SO300
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SO300";
            Size = new Size(1604, 798);
            Load += SO300_Load;
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

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCSplit ucSplit2;
        private EpicV004.Ctrls.UCGridSet g10;
        private EpicV004.Ctrls.UCSplit ucSplit3;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private EpicV004.Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private EpicV004.Ctrls.UCGridSet g20;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private EpicV004.Ctrls.UCGridSet cuFtp;
        private EpicV004.Ctrls.UCChkCodeBox s_status;
        private EpicV004.Ctrls.UCTextBox s_project;
        private EpicV004.Ctrls.UCTextBox f_sono;
        private EpicV004.Ctrls.UCTextBox f_invoice_no;
        private EpicV004.Ctrls.UCDateBox to_dt;
        private EpicV004.Ctrls.UCDateBox fr_dt;
        private EpicV004.Ctrls.UCTextBox s_supplier;
        private EpicV004.Ctrls.UCTextBox currency_rate;
        private EpicV004.Ctrls.UCTextBox project;
        private EpicV004.Ctrls.UCDateBox invoice_end;
        private EpicV004.Ctrls.UCDateBox invoice_start;
        private EpicV004.Ctrls.UCDateBox invoice_date;
        private EpicV004.Ctrls.UCTextBox so_invoice_no;
        private EpicV004.Ctrls.UCCodeBox status;
     
        private EpicV004.Ctrls.UCCodeBox currency;
        private EpicV004.Ctrls.UCTextBox supplier;
        private EpicV004.Ctrls.UCTextBox supplier_name;
        private EpicV004.Ctrls.UCTextBox project_name;
        private Label label2;
        private EpicV004.Ctrls.UCCodeBox sr_mesurement_type;
        private EpicV004.Ctrls.UCCodeBox sr_contract_type;
        private EpicV004.Ctrls.UCTextBox ucTextBox1;
        private EpicV004.Ctrls.UCTextBox ucTextBox5;
        private EpicV004.Ctrls.UCTextBox ucTextBox6;
        private EpicV004.Ctrls.UCCodeBox payment_term;
        private EpicV004.Ctrls.UCCodeBox payment_type;
        private EpicV004.Ctrls.UCTextBox supplier_invoice_no;
        private EpicV004.Ctrls.UCDateBox payment_date;
        private EpicV004.Ctrls.UCTextBox payment_days;
        private EpicV004.Ctrls.UCButton btn_getdata;

        private EpicV004.Ctrls.UCDateBox vat_date;
        private EpicV004.Ctrls.UCTextBox dp_usePer;
        private EpicV004.Ctrls.UCTextBox dp_amount;
        private EpicV004.Ctrls.UCTextBox dp_invoiceNo;
        private EpicV004.Ctrls.UCTextBox ivc_totalAmount;
        private EpicV004.Ctrls.UCTextBox ivc_sumVat;
        private EpicV004.Ctrls.UCTextBox ivc_sumTotal;
        private EpicV004.Ctrls.UCTextBox downpayment;
        private EpicV004.Ctrls.UCTextBox ivc_sumNet;
        private EpicV004.Ctrls.UCTextBox ivc_sumDeduction;
        private EpicV004.Ctrls.UCTextBox ivc_sumAmount;
        private EpicV004.Ctrls.UCTextBox so_balance;
        private EpicV004.Ctrls.UCTextBox paid_sum;
        private EpicV004.Ctrls.UCTextBox so_downpayment;
        private EpicV004.Ctrls.UCTextBox so_amount;
        private EpicV004.Ctrls.UCTextBox so_doc_no;
        private EpicV004.Ctrls.UCTextBox tax_invoice_no;
        private EpicV004.Ctrls.UCTextBox ivc_paidAmount;
        private EpicV004.Ctrls.UCTextBox ivc_sumRetention;
        private Ctrls.UCCheckBox sr_guarantee_bank;
        private Ctrls.UCCheckBox sr_guarantee_na;
        private Ctrls.UCCheckBox sr_guarantee_retention;
        private Ctrls.UCCheckBox sr_performance_bond;
        private Ctrls.UCNote note;
        private Label label1;
        private Label label4;
        private Label label3;
    }
}
