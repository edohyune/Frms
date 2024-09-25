namespace EpicV004.Frms
{
    partial class SA411
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
            f_close_yn = new Ctrls.UCCheckBox();
            f_category = new Ctrls.UCChkCodeBox();
            f_class = new Ctrls.UCChkCodeBox();
            f_status = new Ctrls.UCChkCodeBox();
            f_project_name = new Ctrls.UCTextBox();
            f_project_manager = new Ctrls.UCTextBox();
            f_project_no = new Ctrls.UCTextBox();
            f_to_dt = new Ctrls.UCDateBox();
            f_fr_dt = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            close_yn = new Ctrls.UCCheckBox();
            status = new Ctrls.UCCodeBox();
            contract_total = new Ctrls.UCTextBox();
            currency_Amount = new Ctrls.UCTextBox();
            amount = new Ctrls.UCTextBox();
            currency_rate = new Ctrls.UCTextBox();
            legacy_code = new Ctrls.UCTextBox();
            currency = new Ctrls.UCCodeBox();
            payment_term = new Ctrls.UCTextBox();
            payment_type = new Ctrls.UCCodeBox();
            project_location = new Ctrls.UCTextBox();
            project_name = new Ctrls.UCTextBox();
            project_owner = new Ctrls.UCTextBox();
            class_bc = new Ctrls.UCCodeBox();
            project_manager_name = new Ctrls.UCTextBox();
            Project_manager = new Ctrls.UCTextBox();
            category = new Ctrls.UCCodeBox();
            period_to = new Ctrls.UCDateBox();
            period_fr = new Ctrls.UCDateBox();
            project_date = new Ctrls.UCDateBox();
            project_no = new Ctrls.UCTextBox();
            memo = new Ctrls.UCRichText();
            ucSplit4 = new Ctrls.UCSplit();
            g20 = new Ctrls.UCGridSet();
            ucSplit5 = new Ctrls.UCSplit();
            ucPanel3 = new Ctrls.UCPanel();
            btn_gbc = new Ctrls.UCButton();
            int_status = new Ctrls.UCCodeBox();
            dept = new Ctrls.UCCodeBox();
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
            ucSplit1.Size = new Size(1618, 657);
            ucSplit1.SplitterDistance = 78;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(f_close_yn);
            ucPanel1.Controls.Add(f_category);
            ucPanel1.Controls.Add(f_class);
            ucPanel1.Controls.Add(f_status);
            ucPanel1.Controls.Add(f_project_name);
            ucPanel1.Controls.Add(f_project_manager);
            ucPanel1.Controls.Add(f_project_no);
            ucPanel1.Controls.Add(f_to_dt);
            ucPanel1.Controls.Add(f_fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1618, 78);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // f_close_yn
            // 
            f_close_yn.Checked = false;
            f_close_yn.ControlHeight = 21;
            f_close_yn.ControlWidth = 127;
            f_close_yn.FontColor = Color.Black;
            f_close_yn.FontFace = "Tahoma";
            f_close_yn.FontSize = 9F;
            f_close_yn.Location = new Point(861, 26);
            f_close_yn.Name = "f_close_yn";
            f_close_yn.Size = new Size(127, 21);
            f_close_yn.TabIndex = 11;
            f_close_yn.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_close_yn.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // f_category
            // 
            f_category.ControlHeight = 21;
            f_category.ControlWidth = 200;
            f_category.FontFace = "Tahoma";
            f_category.FontSize = 9F;
            f_category.Location = new Point(655, 26);
            f_category.Name = "f_category";
            f_category.Size = new Size(200, 21);
            f_category.TabIndex = 8;
            f_category.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_category.Title = "Category";
            f_category.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            f_category.TitleWidth = 90;
            // 
            // f_class
            // 
            f_class.ControlHeight = 21;
            f_class.ControlWidth = 200;
            f_class.FontFace = "Tahoma";
            f_class.FontSize = 9F;
            f_class.Location = new Point(655, 52);
            f_class.Name = "f_class";
            f_class.Size = new Size(200, 21);
            f_class.TabIndex = 9;
            f_class.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_class.Title = "Class";
            f_class.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            f_class.TitleWidth = 90;
            // 
            // f_status
            // 
            f_status.ControlHeight = 21;
            f_status.ControlWidth = 213;
            f_status.FontFace = "Tahoma";
            f_status.FontSize = 9F;
            f_status.Location = new Point(217, 53);
            f_status.Name = "f_status";
            f_status.Size = new Size(213, 21);
            f_status.TabIndex = 10;
            f_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_status.Title = "Status";
            f_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            f_status.TitleWidth = 90;
            // 
            // f_project_name
            // 
            f_project_name.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_project_name.Appearance.Options.UseFont = true;
            f_project_name.ControlHeight = 21;
            f_project_name.ControlWidth = 213;
            f_project_name.FontColor = Color.Black;
            f_project_name.FontFace = "Tahoma";
            f_project_name.FontSize = 9F;
            f_project_name.FormatStr = "";
            f_project_name.Location = new Point(436, 53);
            f_project_name.Name = "f_project_name";
            f_project_name.Size = new Size(213, 21);
            f_project_name.TabIndex = 5;
            f_project_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_name.Title = "Project Name";
            f_project_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_name.TitleWidth = 90;
            // 
            // f_project_manager
            // 
            f_project_manager.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_project_manager.Appearance.Options.UseFont = true;
            f_project_manager.ControlHeight = 21;
            f_project_manager.ControlWidth = 213;
            f_project_manager.FontColor = Color.Black;
            f_project_manager.FontFace = "Tahoma";
            f_project_manager.FontSize = 9F;
            f_project_manager.FormatStr = "";
            f_project_manager.Location = new Point(436, 26);
            f_project_manager.Name = "f_project_manager";
            f_project_manager.Size = new Size(213, 21);
            f_project_manager.TabIndex = 6;
            f_project_manager.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_manager.Title = "Project Manager";
            f_project_manager.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_manager.TitleWidth = 90;
            // 
            // f_project_no
            // 
            f_project_no.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_project_no.Appearance.Options.UseFont = true;
            f_project_no.ControlHeight = 21;
            f_project_no.ControlWidth = 213;
            f_project_no.FontColor = Color.Black;
            f_project_no.FontFace = "Tahoma";
            f_project_no.FontSize = 9F;
            f_project_no.FormatStr = "";
            f_project_no.Location = new Point(217, 26);
            f_project_no.Name = "f_project_no";
            f_project_no.Size = new Size(213, 21);
            f_project_no.TabIndex = 7;
            f_project_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_no.Title = "Project No";
            f_project_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_no.TitleWidth = 90;
            // 
            // f_to_dt
            // 
            f_to_dt.ControlHeight = 21;
            f_to_dt.ControlWidth = 208;
            f_to_dt.Font = new Font("Tahoma", 9F);
            f_to_dt.FontColor = Color.Black;
            f_to_dt.FontFace = "Tahoma";
            f_to_dt.FontSize = 9F;
            f_to_dt.FormatStr = "";
            f_to_dt.Location = new Point(5, 53);
            f_to_dt.Name = "f_to_dt";
            f_to_dt.Size = new Size(208, 21);
            f_to_dt.TabIndex = 0;
            f_to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_to_dt.Title = "~";
            f_to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_to_dt.TitleWidth = 90;
            // 
            // f_fr_dt
            // 
            f_fr_dt.ControlHeight = 21;
            f_fr_dt.ControlWidth = 208;
            f_fr_dt.Font = new Font("Tahoma", 9F);
            f_fr_dt.FontColor = Color.Black;
            f_fr_dt.FontFace = "Tahoma";
            f_fr_dt.FontSize = 9F;
            f_fr_dt.FormatStr = "";
            f_fr_dt.Location = new Point(5, 26);
            f_fr_dt.Name = "f_fr_dt";
            f_fr_dt.Size = new Size(208, 21);
            f_fr_dt.TabIndex = 0;
            f_fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_fr_dt.Title = "Date";
            f_fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_fr_dt.TitleWidth = 90;
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
            ucSplit2.Size = new Size(1618, 575);
            ucSplit2.SplitterDistance = 376;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(376, 575);
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
            ucSplit3.Size = new Size(1238, 575);
            ucSplit3.SplitterDistance = 161;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(close_yn);
            ucPanel2.Controls.Add(status);
            ucPanel2.Controls.Add(contract_total);
            ucPanel2.Controls.Add(currency_Amount);
            ucPanel2.Controls.Add(amount);
            ucPanel2.Controls.Add(currency_rate);
            ucPanel2.Controls.Add(legacy_code);
            ucPanel2.Controls.Add(currency);
            ucPanel2.Controls.Add(payment_term);
            ucPanel2.Controls.Add(payment_type);
            ucPanel2.Controls.Add(project_location);
            ucPanel2.Controls.Add(project_name);
            ucPanel2.Controls.Add(project_owner);
            ucPanel2.Controls.Add(class_bc);
            ucPanel2.Controls.Add(project_manager_name);
            ucPanel2.Controls.Add(Project_manager);
            ucPanel2.Controls.Add(category);
            ucPanel2.Controls.Add(period_to);
            ucPanel2.Controls.Add(period_fr);
            ucPanel2.Controls.Add(project_date);
            ucPanel2.Controls.Add(project_no);
            ucPanel2.Controls.Add(memo);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1238, 161);
            ucPanel2.TabIndex = 1;
            // 
            // close_yn
            // 
            close_yn.Checked = false;
            close_yn.ControlHeight = 18;
            close_yn.ControlWidth = 109;
            close_yn.FontColor = Color.Black;
            close_yn.FontFace = "Tahoma";
            close_yn.FontSize = 9F;
            close_yn.Location = new Point(1116, 26);
            close_yn.Name = "close_yn";
            close_yn.Size = new Size(109, 18);
            close_yn.TabIndex = 26;
            close_yn.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            close_yn.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // status
            // 
            status.ControlHeight = 21;
            status.ControlWidth = 214;
            status.FldTy = null;
            status.FontColor = Color.Black;
            status.FontFace = "Tahoma";
            status.FontSize = 9F;
            status.Location = new Point(896, 92);
            status.Name = "status";
            status.Size = new Size(214, 21);
            status.TabIndex = 23;
            status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.Title = "Status";
            status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.TitleWidth = 100;
            // 
            // contract_total
            // 
            contract_total.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contract_total.Appearance.Options.UseFont = true;
            contract_total.ControlHeight = 21;
            contract_total.ControlWidth = 215;
            contract_total.FontColor = Color.Black;
            contract_total.FontFace = "Tahoma";
            contract_total.FontSize = 9F;
            contract_total.FormatStr = "";
            contract_total.Location = new Point(895, 70);
            contract_total.Name = "contract_total";
            contract_total.Size = new Size(215, 21);
            contract_total.TabIndex = 25;
            contract_total.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            contract_total.Title = "Total Amount";
            contract_total.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            contract_total.TitleWidth = 100;
            // 
            // currency_Amount
            // 
            currency_Amount.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currency_Amount.Appearance.Options.UseFont = true;
            currency_Amount.ControlHeight = 21;
            currency_Amount.ControlWidth = 215;
            currency_Amount.FontColor = Color.Black;
            currency_Amount.FontFace = "Tahoma";
            currency_Amount.FontSize = 9F;
            currency_Amount.FormatStr = "";
            currency_Amount.Location = new Point(895, 48);
            currency_Amount.Name = "currency_Amount";
            currency_Amount.Size = new Size(215, 21);
            currency_Amount.TabIndex = 24;
            currency_Amount.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency_Amount.Title = "Currency Amount";
            currency_Amount.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency_Amount.TitleWidth = 100;
            // 
            // amount
            // 
            amount.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amount.Appearance.Options.UseFont = true;
            amount.ControlHeight = 21;
            amount.ControlWidth = 215;
            amount.FontColor = Color.Black;
            amount.FontFace = "Tahoma";
            amount.FontSize = 9F;
            amount.FormatStr = "";
            amount.Location = new Point(895, 26);
            amount.Name = "amount";
            amount.Size = new Size(215, 21);
            amount.TabIndex = 24;
            amount.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            amount.Title = "Project Amount";
            amount.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            amount.TitleWidth = 100;
            // 
            // currency_rate
            // 
            currency_rate.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currency_rate.Appearance.Options.UseFont = true;
            currency_rate.ControlHeight = 21;
            currency_rate.ControlWidth = 226;
            currency_rate.FontColor = Color.Black;
            currency_rate.FontFace = "Tahoma";
            currency_rate.FontSize = 9F;
            currency_rate.FormatStr = "";
            currency_rate.Location = new Point(662, 92);
            currency_rate.Name = "currency_rate";
            currency_rate.Size = new Size(226, 21);
            currency_rate.TabIndex = 19;
            currency_rate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency_rate.Title = "Rate";
            currency_rate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency_rate.TitleWidth = 100;
            // 
            // legacy_code
            // 
            legacy_code.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            legacy_code.Appearance.Options.UseFont = true;
            legacy_code.ControlHeight = 21;
            legacy_code.ControlWidth = 227;
            legacy_code.FontColor = Color.Black;
            legacy_code.FontFace = "Tahoma";
            legacy_code.FontSize = 9F;
            legacy_code.FormatStr = "";
            legacy_code.Location = new Point(429, 92);
            legacy_code.Name = "legacy_code";
            legacy_code.Size = new Size(227, 21);
            legacy_code.TabIndex = 18;
            legacy_code.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            legacy_code.Title = "Legacy Code";
            legacy_code.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            legacy_code.TitleWidth = 100;
            // 
            // currency
            // 
            currency.ControlHeight = 21;
            currency.ControlWidth = 227;
            currency.FldTy = null;
            currency.FontColor = Color.Black;
            currency.FontFace = "Tahoma";
            currency.FontSize = 9F;
            currency.Location = new Point(662, 48);
            currency.Name = "currency";
            currency.Size = new Size(227, 21);
            currency.TabIndex = 16;
            currency.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency.Title = "Currency";
            currency.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency.TitleWidth = 100;
            // 
            // payment_term
            // 
            payment_term.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payment_term.Appearance.Options.UseFont = true;
            payment_term.ControlHeight = 21;
            payment_term.ControlWidth = 226;
            payment_term.FontColor = Color.Black;
            payment_term.FontFace = "Tahoma";
            payment_term.FontSize = 9F;
            payment_term.FormatStr = "";
            payment_term.Location = new Point(662, 70);
            payment_term.Name = "payment_term";
            payment_term.Size = new Size(226, 21);
            payment_term.TabIndex = 12;
            payment_term.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_term.Title = "Payment Term";
            payment_term.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_term.TitleWidth = 100;
            // 
            // payment_type
            // 
            payment_type.ControlHeight = 21;
            payment_type.ControlWidth = 227;
            payment_type.FldTy = null;
            payment_type.FontColor = Color.Black;
            payment_type.FontFace = "Tahoma";
            payment_type.FontSize = 9F;
            payment_type.Location = new Point(662, 26);
            payment_type.Name = "payment_type";
            payment_type.Size = new Size(227, 21);
            payment_type.TabIndex = 17;
            payment_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_type.Title = "Payment Type";
            payment_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            payment_type.TitleWidth = 100;
            // 
            // project_location
            // 
            project_location.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project_location.Appearance.Options.UseFont = true;
            project_location.ControlHeight = 21;
            project_location.ControlWidth = 227;
            project_location.FontColor = Color.Black;
            project_location.FontFace = "Tahoma";
            project_location.FontSize = 9F;
            project_location.FormatStr = "";
            project_location.Location = new Point(429, 70);
            project_location.Name = "project_location";
            project_location.Size = new Size(227, 21);
            project_location.TabIndex = 13;
            project_location.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_location.Title = "Project Location";
            project_location.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_location.TitleWidth = 100;
            // 
            // project_name
            // 
            project_name.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project_name.Appearance.Options.UseFont = true;
            project_name.ControlHeight = 21;
            project_name.ControlWidth = 227;
            project_name.FontColor = Color.Black;
            project_name.FontFace = "Tahoma";
            project_name.FontSize = 9F;
            project_name.FormatStr = "";
            project_name.Location = new Point(429, 26);
            project_name.Name = "project_name";
            project_name.Size = new Size(227, 21);
            project_name.TabIndex = 14;
            project_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_name.Title = "Project Name";
            project_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_name.TitleWidth = 100;
            // 
            // project_owner
            // 
            project_owner.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project_owner.Appearance.Options.UseFont = true;
            project_owner.ControlHeight = 21;
            project_owner.ControlWidth = 227;
            project_owner.FontColor = Color.Black;
            project_owner.FontFace = "Tahoma";
            project_owner.FontSize = 9F;
            project_owner.FormatStr = "";
            project_owner.Location = new Point(429, 48);
            project_owner.Name = "project_owner";
            project_owner.Size = new Size(227, 21);
            project_owner.TabIndex = 15;
            project_owner.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_owner.Title = "Project Owner";
            project_owner.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_owner.TitleWidth = 100;
            // 
            // class_bc
            // 
            class_bc.ControlHeight = 21;
            class_bc.ControlWidth = 186;
            class_bc.FldTy = null;
            class_bc.FontColor = Color.Black;
            class_bc.FontFace = "Tahoma";
            class_bc.FontSize = 9F;
            class_bc.Location = new Point(237, 48);
            class_bc.Name = "class_bc";
            class_bc.Size = new Size(186, 21);
            class_bc.TabIndex = 10;
            class_bc.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            class_bc.Title = "Class";
            class_bc.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            class_bc.TitleWidth = 80;
            // 
            // project_manager_name
            // 
            project_manager_name.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project_manager_name.Appearance.Options.UseFont = true;
            project_manager_name.ControlHeight = 21;
            project_manager_name.ControlWidth = 186;
            project_manager_name.FontColor = Color.Black;
            project_manager_name.FontFace = "Tahoma";
            project_manager_name.FontSize = 9F;
            project_manager_name.FormatStr = "";
            project_manager_name.Location = new Point(237, 92);
            project_manager_name.Name = "project_manager_name";
            project_manager_name.Size = new Size(186, 21);
            project_manager_name.TabIndex = 7;
            project_manager_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_manager_name.Title = "";
            project_manager_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_manager_name.TitleWidth = 1;
            // 
            // Project_manager
            // 
            Project_manager.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Project_manager.Appearance.Options.UseFont = true;
            Project_manager.ControlHeight = 21;
            Project_manager.ControlWidth = 226;
            Project_manager.FontColor = Color.Black;
            Project_manager.FontFace = "Tahoma";
            Project_manager.FontSize = 9F;
            Project_manager.FormatStr = "";
            Project_manager.Location = new Point(5, 92);
            Project_manager.Name = "Project_manager";
            Project_manager.Size = new Size(226, 21);
            Project_manager.TabIndex = 8;
            Project_manager.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            Project_manager.Title = "Project Manager";
            Project_manager.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            Project_manager.TitleWidth = 100;
            // 
            // category
            // 
            category.ControlHeight = 21;
            category.ControlWidth = 186;
            category.FldTy = null;
            category.FontColor = Color.Black;
            category.FontFace = "Tahoma";
            category.FontSize = 9F;
            category.Location = new Point(237, 26);
            category.Name = "category";
            category.Size = new Size(186, 21);
            category.TabIndex = 11;
            category.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            category.Title = "Category";
            category.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            category.TitleWidth = 80;
            // 
            // period_to
            // 
            period_to.ControlHeight = 21;
            period_to.ControlWidth = 186;
            period_to.Font = new Font("Tahoma", 9F);
            period_to.FontColor = Color.Black;
            period_to.FontFace = "Tahoma";
            period_to.FontSize = 9F;
            period_to.FormatStr = "";
            period_to.Location = new Point(237, 70);
            period_to.Name = "period_to";
            period_to.Size = new Size(186, 21);
            period_to.TabIndex = 4;
            period_to.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            period_to.Title = "~";
            period_to.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            period_to.TitleWidth = 80;
            // 
            // period_fr
            // 
            period_fr.ControlHeight = 21;
            period_fr.ControlWidth = 226;
            period_fr.Font = new Font("Tahoma", 9F);
            period_fr.FontColor = Color.Black;
            period_fr.FontFace = "Tahoma";
            period_fr.FontSize = 9F;
            period_fr.FormatStr = "";
            period_fr.Location = new Point(5, 70);
            period_fr.Name = "period_fr";
            period_fr.Size = new Size(226, 21);
            period_fr.TabIndex = 5;
            period_fr.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            period_fr.Title = "Period";
            period_fr.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            period_fr.TitleWidth = 100;
            // 
            // project_date
            // 
            project_date.ControlHeight = 21;
            project_date.ControlWidth = 226;
            project_date.Font = new Font("Tahoma", 9F);
            project_date.FontColor = Color.Black;
            project_date.FontFace = "Tahoma";
            project_date.FontSize = 9F;
            project_date.FormatStr = "";
            project_date.Location = new Point(5, 48);
            project_date.Name = "project_date";
            project_date.Size = new Size(226, 21);
            project_date.TabIndex = 6;
            project_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_date.Title = "Date";
            project_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_date.TitleWidth = 100;
            // 
            // project_no
            // 
            project_no.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project_no.Appearance.Options.UseFont = true;
            project_no.ControlHeight = 21;
            project_no.ControlWidth = 226;
            project_no.FontColor = Color.Black;
            project_no.FontFace = "Tahoma";
            project_no.FontSize = 9F;
            project_no.FormatStr = "";
            project_no.Location = new Point(5, 26);
            project_no.Name = "project_no";
            project_no.Size = new Size(226, 21);
            project_no.TabIndex = 9;
            project_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_no.Title = "Project No";
            project_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_no.TitleWidth = 100;
            // 
            // memo
            // 
            memo.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            memo.Appearance.Text.Font = new Font("Cascadia Code Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memo.Appearance.Text.Options.UseFont = true;
            memo.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            memo.Location = new Point(106, 119);
            memo.Modified = true;
            memo.Name = "memo";
            memo.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            memo.Options.DocumentSaveOptions.DefaultFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            memo.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            memo.Options.Search.RegExResultMaxGuaranteedLength = 1000;
            memo.Padding = new Padding(50, 0, 0, 0);
            memo.Size = new Size(1004, 32);
            memo.TabIndex = 3;
            memo.Views.SimpleView.AllowDisplayLineNumbers = true;
            // 
            // ucSplit4
            // 
            ucSplit4.Dock = DockStyle.Fill;
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
            ucSplit4.Size = new Size(1238, 410);
            ucSplit4.SplitterDistance = 321;
            ucSplit4.TabIndex = 0;
            ucSplit4.TitleWidth = 121;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(321, 410);
            g20.TabIndex = 1;
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
            ucSplit5.Panel2.Controls.Add(g30);
            ucSplit5.Size = new Size(913, 410);
            ucSplit5.SplitterDistance = 56;
            ucSplit5.TabIndex = 0;
            ucSplit5.TitleWidth = 121;
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(btn_gbc);
            ucPanel3.Controls.Add(int_status);
            ucPanel3.Controls.Add(dept);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(0, 0);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(913, 56);
            ucPanel3.TabIndex = 0;
            ucPanel3.Text = "Dept Info";
            // 
            // btn_gbc
            // 
            btn_gbc.Appearance.BackColor = Color.Silver;
            btn_gbc.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btn_gbc.Appearance.Options.UseBackColor = true;
            btn_gbc.Appearance.Options.UseFont = true;
            btn_gbc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_gbc.ControlHeight = 28;
            btn_gbc.ControlWidth = 121;
            btn_gbc.FontBold = FontStyle.Bold;
            btn_gbc.FontFace = "Tahoma";
            btn_gbc.FontSize = 9F;
            btn_gbc.Location = new Point(417, 26);
            btn_gbc.Name = "btn_gbc";
            btn_gbc.Size = new Size(121, 28);
            btn_gbc.TabIndex = 1;
            btn_gbc.Title = "Get Budget Code";
            btn_gbc.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // int_status
            // 
            int_status.ControlHeight = 21;
            int_status.ControlWidth = 200;
            int_status.FldTy = null;
            int_status.FontColor = Color.Black;
            int_status.FontFace = "Tahoma";
            int_status.FontSize = 9F;
            int_status.Location = new Point(211, 30);
            int_status.Name = "int_status";
            int_status.Size = new Size(200, 21);
            int_status.TabIndex = 0;
            int_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            int_status.Title = "Budget Status";
            int_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            int_status.TitleWidth = 100;
            // 
            // dept
            // 
            dept.ControlHeight = 21;
            dept.ControlWidth = 200;
            dept.FldTy = null;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.Location = new Point(5, 30);
            dept.Name = "dept";
            dept.Size = new Size(200, 21);
            dept.TabIndex = 0;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Dept";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 100;
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(913, 350);
            g30.TabIndex = 1;
            // 
            // SA411
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SA411";
            Size = new Size(1618, 657);
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
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCDateBox f_to_dt;
        private Ctrls.UCDateBox f_fr_dt;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCRichText memo;
        private Ctrls.UCCheckBox f_close_yn;
        private Ctrls.UCChkCodeBox f_category;
        private Ctrls.UCChkCodeBox f_class;
        private Ctrls.UCChkCodeBox f_status;
        private Ctrls.UCTextBox f_project_name;
        private Ctrls.UCTextBox f_project_manager;
        private Ctrls.UCTextBox f_project_no;
        private Ctrls.UCCodeBox class_bc;
        private Ctrls.UCTextBox project_manager_name;
        private Ctrls.UCTextBox Project_manager;
        private Ctrls.UCCodeBox category;
        private Ctrls.UCDateBox period_to;
        private Ctrls.UCDateBox period_fr;
        private Ctrls.UCDateBox project_date;
        private Ctrls.UCTextBox project_no;
        private Ctrls.UCTextBox currency_rate;
        private Ctrls.UCTextBox legacy_code;
        private Ctrls.UCCodeBox currency;
        private Ctrls.UCTextBox payment_term;
        private Ctrls.UCCodeBox payment_type;
        private Ctrls.UCTextBox project_location;
        private Ctrls.UCTextBox project_name;
        private Ctrls.UCTextBox project_owner;
        private Ctrls.UCCodeBox status;
        private Ctrls.UCTextBox contract_total;
        private Ctrls.UCTextBox currency_Amount;
        private Ctrls.UCTextBox amount;
        private Ctrls.UCCheckBox close_yn;
        private Ctrls.UCSplit ucSplit4;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCSplit ucSplit5;
        private Ctrls.UCPanel ucPanel3;
        private Ctrls.UCButton btn_gbc;
        private Ctrls.UCCodeBox int_status;
        private Ctrls.UCCodeBox dept;
        private Ctrls.UCGridSet g30;
    }
}
