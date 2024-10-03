namespace EpicV004.Frms
{
    partial class SO100
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
            f_status = new Ctrls.UCChkCodeBox();
            f_subcontractor = new Ctrls.UCChkCodeBox();
            f_project = new Ctrls.UCTextBox();
            f_srno = new Ctrls.UCTextBox();
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            so_need_date = new Ctrls.UCDateBox();
            committee_date = new Ctrls.UCDateBox();
            note = new Ctrls.UCNote();
            btn_revision = new Ctrls.UCButton();
            currency_rate = new Ctrls.UCTextBox();
            currency = new Ctrls.UCCodeBox();
            groupBox3 = new GroupBox();
            sr_measurement_type = new Ctrls.UCCodeBox();
            sr_contract_type = new Ctrls.UCCodeBox();
            sr_guarantee_na = new Ctrls.UCCheckBox();
            label3 = new Label();
            sr_retention_per = new Ctrls.UCTextBox();
            sr_guarantee_retention = new Ctrls.UCCheckBox();
            label2 = new Label();
            sr_bond_per = new Ctrls.UCTextBox();
            sr_guarantee_bond = new Ctrls.UCCheckBox();
            label4 = new Label();
            label1 = new Label();
            sr_bank_per = new Ctrls.UCTextBox();
            sr_guarantee_bank = new Ctrls.UCCheckBox();
            sr_rev = new Ctrls.UCTextBox();
            issue_dept = new Ctrls.UCTextBox();
            status = new Ctrls.UCCodeBox();
            sr_edate = new Ctrls.UCDateBox();
            sr_sdate = new Ctrls.UCDateBox();
            location = new Ctrls.UCTextBox();
            cust_name = new Ctrls.UCTextBox();
            prject_name = new Ctrls.UCTextBox();
            cust = new Ctrls.UCTextBox();
            project = new Ctrls.UCTextBox();
            sr_type = new Ctrls.UCCodeBox();
            sr_category = new Ctrls.UCCodeBox();
            discipline = new Ctrls.UCCodeBox();
            issue_deptName = new Ctrls.UCTextBox();
            sr_date = new Ctrls.UCDateBox();
            sr_doc_no = new Ctrls.UCTextBox();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ucSplit4 = new Ctrls.UCSplit();
            g30 = new Ctrls.UCGridSet();
            ucPanel3 = new Ctrls.UCPanel();
            groupBox2 = new GroupBox();
            manpower_supervisor = new Ctrls.UCCheckBox();
            manpower_engineer = new Ctrls.UCCheckBox();
            manpower_manager = new Ctrls.UCCheckBox();
            manpower_safety = new Ctrls.UCCheckBox();
            manpower_qc = new Ctrls.UCCheckBox();
            groupBox4 = new GroupBox();
            etools_none = new Ctrls.UCCheckBox();
            etools_partial = new Ctrls.UCCheckBox();
            etools_full = new Ctrls.UCCheckBox();
            groupBox1 = new GroupBox();
            material_none = new Ctrls.UCCheckBox();
            material_partial = new Ctrls.UCCheckBox();
            material_full = new Ctrls.UCCheckBox();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            g40 = new Ctrls.UCGridSet();
            sr_event = new Ctrls.UCCodeBox();
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
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucTab1).BeginInit();
            ucTab1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit4).BeginInit();
            ucSplit4.Panel1.SuspendLayout();
            ucSplit4.Panel2.SuspendLayout();
            ucSplit4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel3).BeginInit();
            ucPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            xtraTabPage3.SuspendLayout();
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
            ucSplit1.Size = new Size(1592, 825);
            ucSplit1.SplitterDistance = 78;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(f_status);
            ucPanel1.Controls.Add(f_subcontractor);
            ucPanel1.Controls.Add(f_project);
            ucPanel1.Controls.Add(f_srno);
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1592, 78);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // f_status
            // 
            f_status.ControlHeight = 21;
            f_status.ControlWidth = 213;
            f_status.FontFace = "Tahoma";
            f_status.FontSize = 9F;
            f_status.Location = new Point(436, 52);
            f_status.Name = "f_status";
            f_status.Size = new Size(213, 21);
            f_status.TabIndex = 11;
            f_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_status.Title = "Status";
            f_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            f_status.TitleWidth = 90;
            // 
            // f_subcontractor
            // 
            f_subcontractor.ControlHeight = 21;
            f_subcontractor.ControlWidth = 213;
            f_subcontractor.FontFace = "Tahoma";
            f_subcontractor.FontSize = 9F;
            f_subcontractor.Location = new Point(217, 53);
            f_subcontractor.Name = "f_subcontractor";
            f_subcontractor.Size = new Size(213, 21);
            f_subcontractor.TabIndex = 10;
            f_subcontractor.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_subcontractor.Title = "Subcontractor";
            f_subcontractor.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            f_subcontractor.TitleWidth = 90;
            // 
            // f_project
            // 
            f_project.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_project.Appearance.Options.UseFont = true;
            f_project.ControlHeight = 21;
            f_project.ControlWidth = 213;
            f_project.FontColor = Color.Black;
            f_project.FontFace = "Tahoma";
            f_project.FontSize = 9F;
            f_project.FormatStr = "";
            f_project.Location = new Point(436, 26);
            f_project.Name = "f_project";
            f_project.Size = new Size(213, 21);
            f_project.TabIndex = 6;
            f_project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project.Title = "Project ";
            f_project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project.TitleWidth = 90;
            // 
            // f_srno
            // 
            f_srno.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_srno.Appearance.Options.UseFont = true;
            f_srno.ControlHeight = 21;
            f_srno.ControlWidth = 213;
            f_srno.FontColor = Color.Black;
            f_srno.FontFace = "Tahoma";
            f_srno.FontSize = 9F;
            f_srno.FormatStr = "";
            f_srno.Location = new Point(217, 26);
            f_srno.Name = "f_srno";
            f_srno.Size = new Size(213, 21);
            f_srno.TabIndex = 7;
            f_srno.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_srno.Title = "SR No";
            f_srno.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_srno.TitleWidth = 90;
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 208;
            to_dt.Font = new Font("Tahoma", 9F);
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(5, 53);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(208, 21);
            to_dt.TabIndex = 0;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 90;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 208;
            fr_dt.Font = new Font("Tahoma", 9F);
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 26);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(208, 21);
            fr_dt.TabIndex = 0;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Date";
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
            ucSplit2.Size = new Size(1592, 743);
            ucSplit2.SplitterDistance = 471;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(471, 743);
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
            ucSplit3.Size = new Size(1117, 743);
            ucSplit3.SplitterDistance = 366;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(so_need_date);
            ucPanel2.Controls.Add(committee_date);
            ucPanel2.Controls.Add(note);
            ucPanel2.Controls.Add(btn_revision);
            ucPanel2.Controls.Add(currency_rate);
            ucPanel2.Controls.Add(currency);
            ucPanel2.Controls.Add(groupBox3);
            ucPanel2.Controls.Add(sr_rev);
            ucPanel2.Controls.Add(issue_dept);
            ucPanel2.Controls.Add(status);
            ucPanel2.Controls.Add(sr_edate);
            ucPanel2.Controls.Add(sr_sdate);
            ucPanel2.Controls.Add(location);
            ucPanel2.Controls.Add(cust_name);
            ucPanel2.Controls.Add(prject_name);
            ucPanel2.Controls.Add(cust);
            ucPanel2.Controls.Add(project);
            ucPanel2.Controls.Add(sr_type);
            ucPanel2.Controls.Add(sr_category);
            ucPanel2.Controls.Add(sr_event);
            ucPanel2.Controls.Add(discipline);
            ucPanel2.Controls.Add(issue_deptName);
            ucPanel2.Controls.Add(sr_date);
            ucPanel2.Controls.Add(sr_doc_no);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1117, 366);
            ucPanel2.TabIndex = 1;
            // 
            // so_need_date
            // 
            so_need_date.ControlHeight = 21;
            so_need_date.ControlWidth = 344;
            so_need_date.FontColor = Color.Black;
            so_need_date.FontFace = "Tahoma";
            so_need_date.FontSize = 9F;
            so_need_date.FormatStr = "";
            so_need_date.Location = new Point(278, 70);
            so_need_date.Name = "so_need_date";
            so_need_date.Size = new Size(344, 21);
            so_need_date.TabIndex = 48;
            so_need_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_need_date.Title = "Required Service Order Date";
            so_need_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_need_date.TitleWidth = 200;
            // 
            // committee_date
            // 
            committee_date.ControlHeight = 21;
            committee_date.ControlWidth = 344;
            committee_date.FontColor = Color.Black;
            committee_date.FontFace = "Tahoma";
            committee_date.FontSize = 9F;
            committee_date.FormatStr = "";
            committee_date.Location = new Point(278, 48);
            committee_date.Name = "committee_date";
            committee_date.Size = new Size(344, 21);
            committee_date.TabIndex = 47;
            committee_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            committee_date.Title = "Required Commettee Meeting Date";
            committee_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            committee_date.TitleWidth = 200;
            // 
            // note
            // 
            note.ControlHeight = 51;
            note.ControlWidth = 889;
            note.FontColor = Color.Black;
            note.FontFace = "Tahoma";
            note.FontSize = 9F;
            note.Location = new Point(5, 182);
            note.Name = "note";
            note.Size = new Size(889, 51);
            note.TabIndex = 46;
            note.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            note.Title = "Note";
            note.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            note.TitleWidth = 107;
            // 
            // btn_revision
            // 
            btn_revision.Appearance.BackColor = Color.Gray;
            btn_revision.Appearance.Font = new Font("Tahoma", 9F);
            btn_revision.Appearance.ForeColor = Color.White;
            btn_revision.Appearance.Options.UseBackColor = true;
            btn_revision.Appearance.Options.UseFont = true;
            btn_revision.Appearance.Options.UseForeColor = true;
            btn_revision.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_revision.ControlHeight = 41;
            btn_revision.ControlWidth = 100;
            btn_revision.FontBold = FontStyle.Regular;
            btn_revision.FontFace = "Tahoma";
            btn_revision.FontSize = 9F;
            btn_revision.Location = new Point(900, 27);
            btn_revision.Name = "btn_revision";
            btn_revision.Size = new Size(100, 41);
            btn_revision.TabIndex = 45;
            btn_revision.Title = "Revision";
            btn_revision.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
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
            currency_rate.Location = new Point(244, 333);
            currency_rate.Name = "currency_rate";
            currency_rate.Size = new Size(226, 21);
            currency_rate.TabIndex = 44;
            currency_rate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency_rate.Title = "Rate";
            currency_rate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency_rate.TitleWidth = 100;
            // 
            // currency
            // 
            currency.ControlHeight = 21;
            currency.ControlWidth = 227;
            currency.FldTy = null;
            currency.FontColor = Color.Black;
            currency.FontFace = "Tahoma";
            currency.FontSize = 9F;
            currency.Location = new Point(11, 333);
            currency.Name = "currency";
            currency.Size = new Size(227, 21);
            currency.TabIndex = 43;
            currency.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency.Title = "Currency";
            currency.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            currency.TitleWidth = 110;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(sr_measurement_type);
            groupBox3.Controls.Add(sr_contract_type);
            groupBox3.Controls.Add(sr_guarantee_na);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(sr_retention_per);
            groupBox3.Controls.Add(sr_guarantee_retention);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(sr_bond_per);
            groupBox3.Controls.Add(sr_guarantee_bond);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(sr_bank_per);
            groupBox3.Controls.Add(sr_guarantee_bank);
            groupBox3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(5, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(889, 91);
            groupBox3.TabIndex = 42;
            groupBox3.TabStop = false;
            groupBox3.Text = "Paylment Term  Condition";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // sr_measurement_type
            // 
            sr_measurement_type.ControlHeight = 21;
            sr_measurement_type.ControlWidth = 432;
            sr_measurement_type.FldTy = null;
            sr_measurement_type.FontColor = Color.Black;
            sr_measurement_type.FontFace = "Tahoma";
            sr_measurement_type.FontSize = 9F;
            sr_measurement_type.Location = new Point(433, 21);
            sr_measurement_type.Name = "sr_measurement_type";
            sr_measurement_type.Size = new Size(432, 21);
            sr_measurement_type.TabIndex = 53;
            sr_measurement_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_measurement_type.Title = "Measurement Type";
            sr_measurement_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_measurement_type.TitleWidth = 110;
            // 
            // sr_contract_type
            // 
            sr_contract_type.ControlHeight = 21;
            sr_contract_type.ControlWidth = 416;
            sr_contract_type.FldTy = null;
            sr_contract_type.FontColor = Color.Black;
            sr_contract_type.FontFace = "Tahoma";
            sr_contract_type.FontSize = 9F;
            sr_contract_type.Location = new Point(9, 21);
            sr_contract_type.Name = "sr_contract_type";
            sr_contract_type.Size = new Size(416, 21);
            sr_contract_type.TabIndex = 53;
            sr_contract_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_contract_type.Title = "Contract Type";
            sr_contract_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_contract_type.TitleWidth = 110;
            // 
            // sr_guarantee_na
            // 
            sr_guarantee_na.Checked = false;
            sr_guarantee_na.ControlHeight = 20;
            sr_guarantee_na.ControlWidth = 106;
            sr_guarantee_na.FontColor = Color.Black;
            sr_guarantee_na.FontFace = "Tahoma";
            sr_guarantee_na.FontSize = 9F;
            sr_guarantee_na.Location = new Point(733, 58);
            sr_guarantee_na.Name = "sr_guarantee_na";
            sr_guarantee_na.Size = new Size(106, 20);
            sr_guarantee_na.TabIndex = 52;
            sr_guarantee_na.Text = "Not Applicable";
            sr_guarantee_na.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_guarantee_na.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(671, 61);
            label3.Name = "label3";
            label3.Size = new Size(19, 14);
            label3.TabIndex = 51;
            label3.Text = "%";
            // 
            // sr_retention_per
            // 
            sr_retention_per.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sr_retention_per.Appearance.Options.UseFont = true;
            sr_retention_per.ControlHeight = 21;
            sr_retention_per.ControlWidth = 59;
            sr_retention_per.FontColor = Color.Black;
            sr_retention_per.FontFace = "Tahoma";
            sr_retention_per.FontSize = 9F;
            sr_retention_per.FormatStr = "";
            sr_retention_per.Location = new Point(611, 58);
            sr_retention_per.Name = "sr_retention_per";
            sr_retention_per.Size = new Size(59, 21);
            sr_retention_per.TabIndex = 50;
            sr_retention_per.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_retention_per.Title = "";
            sr_retention_per.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_retention_per.TitleWidth = 1;
            // 
            // sr_guarantee_retention
            // 
            sr_guarantee_retention.Checked = false;
            sr_guarantee_retention.ControlHeight = 20;
            sr_guarantee_retention.ControlWidth = 89;
            sr_guarantee_retention.FontColor = Color.Black;
            sr_guarantee_retention.FontFace = "Tahoma";
            sr_guarantee_retention.FontSize = 9F;
            sr_guarantee_retention.Location = new Point(514, 58);
            sr_guarantee_retention.Name = "sr_guarantee_retention";
            sr_guarantee_retention.Size = new Size(89, 20);
            sr_guarantee_retention.TabIndex = 49;
            sr_guarantee_retention.Text = "Retention";
            sr_guarantee_retention.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_guarantee_retention.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(488, 61);
            label2.Name = "label2";
            label2.Size = new Size(19, 14);
            label2.TabIndex = 48;
            label2.Text = "%";
            // 
            // sr_bond_per
            // 
            sr_bond_per.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sr_bond_per.Appearance.Options.UseFont = true;
            sr_bond_per.ControlHeight = 21;
            sr_bond_per.ControlWidth = 59;
            sr_bond_per.FontColor = Color.Black;
            sr_bond_per.FontFace = "Tahoma";
            sr_bond_per.FontSize = 9F;
            sr_bond_per.FormatStr = "";
            sr_bond_per.Location = new Point(427, 58);
            sr_bond_per.Name = "sr_bond_per";
            sr_bond_per.Size = new Size(59, 21);
            sr_bond_per.TabIndex = 47;
            sr_bond_per.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_bond_per.Title = "";
            sr_bond_per.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_bond_per.TitleWidth = 1;
            // 
            // sr_guarantee_bond
            // 
            sr_guarantee_bond.Checked = false;
            sr_guarantee_bond.ControlHeight = 20;
            sr_guarantee_bond.ControlWidth = 106;
            sr_guarantee_bond.FontColor = Color.Black;
            sr_guarantee_bond.FontFace = "Tahoma";
            sr_guarantee_bond.FontSize = 9F;
            sr_guarantee_bond.Location = new Point(319, 58);
            sr_guarantee_bond.Name = "sr_guarantee_bond";
            sr_guarantee_bond.Size = new Size(106, 20);
            sr_guarantee_bond.TabIndex = 46;
            sr_guarantee_bond.Text = "Performance";
            sr_guarantee_bond.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_guarantee_bond.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(9, 61);
            label4.Name = "label4";
            label4.Size = new Size(64, 14);
            label4.TabIndex = 45;
            label4.Text = "Guarantee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(293, 61);
            label1.Name = "label1";
            label1.Size = new Size(19, 14);
            label1.TabIndex = 45;
            label1.Text = "%";
            // 
            // sr_bank_per
            // 
            sr_bank_per.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sr_bank_per.Appearance.Options.UseFont = true;
            sr_bank_per.ControlHeight = 21;
            sr_bank_per.ControlWidth = 59;
            sr_bank_per.FontColor = Color.Black;
            sr_bank_per.FontFace = "Tahoma";
            sr_bank_per.FontSize = 9F;
            sr_bank_per.FormatStr = "";
            sr_bank_per.Location = new Point(232, 58);
            sr_bank_per.Name = "sr_bank_per";
            sr_bank_per.Size = new Size(59, 21);
            sr_bank_per.TabIndex = 44;
            sr_bank_per.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_bank_per.Title = "";
            sr_bank_per.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_bank_per.TitleWidth = 1;
            // 
            // sr_guarantee_bank
            // 
            sr_guarantee_bank.Checked = false;
            sr_guarantee_bank.ControlHeight = 20;
            sr_guarantee_bank.ControlWidth = 120;
            sr_guarantee_bank.FontColor = Color.Black;
            sr_guarantee_bank.FontFace = "Tahoma";
            sr_guarantee_bank.FontSize = 9F;
            sr_guarantee_bank.Location = new Point(119, 58);
            sr_guarantee_bank.Name = "sr_guarantee_bank";
            sr_guarantee_bank.Size = new Size(120, 20);
            sr_guarantee_bank.TabIndex = 43;
            sr_guarantee_bank.Text = "Bank Guarantee";
            sr_guarantee_bank.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_guarantee_bank.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // sr_rev
            // 
            sr_rev.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sr_rev.Appearance.Options.UseFont = true;
            sr_rev.ControlHeight = 21;
            sr_rev.ControlWidth = 344;
            sr_rev.FontColor = Color.Black;
            sr_rev.FontFace = "Tahoma";
            sr_rev.FontSize = 9F;
            sr_rev.FormatStr = "";
            sr_rev.Location = new Point(278, 26);
            sr_rev.Name = "sr_rev";
            sr_rev.Size = new Size(344, 21);
            sr_rev.TabIndex = 38;
            sr_rev.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_rev.Title = "Rev No";
            sr_rev.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_rev.TitleWidth = 200;
            // 
            // issue_dept
            // 
            issue_dept.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            issue_dept.Appearance.Options.UseFont = true;
            issue_dept.ControlHeight = 21;
            issue_dept.ControlWidth = 344;
            issue_dept.FontColor = Color.Black;
            issue_dept.FontFace = "Tahoma";
            issue_dept.FontSize = 9F;
            issue_dept.FormatStr = "";
            issue_dept.Location = new Point(278, 114);
            issue_dept.Name = "issue_dept";
            issue_dept.Size = new Size(344, 21);
            issue_dept.TabIndex = 38;
            issue_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            issue_dept.Title = "Issue Dept";
            issue_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            issue_dept.TitleWidth = 200;
            // 
            // status
            // 
            status.ControlHeight = 21;
            status.ControlWidth = 267;
            status.FldTy = null;
            status.FontColor = Color.Black;
            status.FontFace = "Tahoma";
            status.FontSize = 9F;
            status.Location = new Point(5, 114);
            status.Name = "status";
            status.Size = new Size(267, 21);
            status.TabIndex = 36;
            status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.Title = "Status";
            status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.TitleWidth = 110;
            // 
            // sr_edate
            // 
            sr_edate.ControlHeight = 21;
            sr_edate.ControlWidth = 267;
            sr_edate.Font = new Font("Tahoma", 9F);
            sr_edate.FontColor = Color.Black;
            sr_edate.FontFace = "Tahoma";
            sr_edate.FontSize = 9F;
            sr_edate.FormatStr = "";
            sr_edate.Location = new Point(5, 92);
            sr_edate.Name = "sr_edate";
            sr_edate.Size = new Size(267, 21);
            sr_edate.TabIndex = 35;
            sr_edate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_edate.Title = "Finish Date";
            sr_edate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_edate.TitleWidth = 110;
            // 
            // sr_sdate
            // 
            sr_sdate.ControlHeight = 21;
            sr_sdate.ControlWidth = 267;
            sr_sdate.Font = new Font("Tahoma", 9F);
            sr_sdate.FontColor = Color.Black;
            sr_sdate.FontFace = "Tahoma";
            sr_sdate.FontSize = 9F;
            sr_sdate.FormatStr = "";
            sr_sdate.Location = new Point(5, 70);
            sr_sdate.Name = "sr_sdate";
            sr_sdate.Size = new Size(267, 21);
            sr_sdate.TabIndex = 34;
            sr_sdate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_sdate.Title = "Start Date";
            sr_sdate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_sdate.TitleWidth = 110;
            // 
            // location
            // 
            location.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            location.Appearance.Options.UseFont = true;
            location.ControlHeight = 21;
            location.ControlWidth = 266;
            location.FontColor = Color.Black;
            location.FontFace = "Tahoma";
            location.FontSize = 9F;
            location.FormatStr = "";
            location.Location = new Point(628, 92);
            location.Name = "location";
            location.Size = new Size(266, 21);
            location.TabIndex = 30;
            location.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            location.Title = "Location";
            location.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            location.TitleWidth = 100;
            // 
            // cust_name
            // 
            cust_name.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cust_name.Appearance.Options.UseFont = true;
            cust_name.ControlHeight = 21;
            cust_name.ControlWidth = 616;
            cust_name.FontColor = Color.Black;
            cust_name.FontFace = "Tahoma";
            cust_name.FontSize = 9F;
            cust_name.FormatStr = "";
            cust_name.Location = new Point(278, 158);
            cust_name.Name = "cust_name";
            cust_name.Size = new Size(616, 21);
            cust_name.TabIndex = 27;
            cust_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            cust_name.Title = "";
            cust_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            cust_name.TitleWidth = 1;
            // 
            // prject_name
            // 
            prject_name.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prject_name.Appearance.Options.UseFont = true;
            prject_name.ControlHeight = 21;
            prject_name.ControlWidth = 616;
            prject_name.FontColor = Color.Black;
            prject_name.FontFace = "Tahoma";
            prject_name.FontSize = 9F;
            prject_name.FormatStr = "";
            prject_name.Location = new Point(278, 136);
            prject_name.Name = "prject_name";
            prject_name.Size = new Size(616, 21);
            prject_name.TabIndex = 27;
            prject_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            prject_name.Title = "";
            prject_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            prject_name.TitleWidth = 1;
            // 
            // cust
            // 
            cust.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cust.Appearance.Options.UseFont = true;
            cust.ControlHeight = 21;
            cust.ControlWidth = 267;
            cust.FontColor = Color.Black;
            cust.FontFace = "Tahoma";
            cust.FontSize = 9F;
            cust.FormatStr = "";
            cust.Location = new Point(5, 158);
            cust.Name = "cust";
            cust.Size = new Size(267, 21);
            cust.TabIndex = 28;
            cust.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            cust.Title = "Subcontractor";
            cust.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            cust.TitleWidth = 110;
            // 
            // project
            // 
            project.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project.Appearance.Options.UseFont = true;
            project.ControlHeight = 21;
            project.ControlWidth = 267;
            project.FontColor = Color.Black;
            project.FontFace = "Tahoma";
            project.FontSize = 9F;
            project.FormatStr = "";
            project.Location = new Point(5, 136);
            project.Name = "project";
            project.Size = new Size(267, 21);
            project.TabIndex = 28;
            project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.Title = "Project";
            project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project.TitleWidth = 110;
            // 
            // sr_type
            // 
            sr_type.ControlHeight = 21;
            sr_type.ControlWidth = 266;
            sr_type.FldTy = null;
            sr_type.FontColor = Color.Black;
            sr_type.FontFace = "Tahoma";
            sr_type.FontSize = 9F;
            sr_type.Location = new Point(628, 47);
            sr_type.Name = "sr_type";
            sr_type.Size = new Size(266, 21);
            sr_type.TabIndex = 23;
            sr_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_type.Title = "SR Type";
            sr_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_type.TitleWidth = 100;
            // 
            // sr_category
            // 
            sr_category.ControlHeight = 21;
            sr_category.ControlWidth = 266;
            sr_category.FldTy = null;
            sr_category.FontColor = Color.Black;
            sr_category.FontFace = "Tahoma";
            sr_category.FontSize = 9F;
            sr_category.Location = new Point(628, 26);
            sr_category.Name = "sr_category";
            sr_category.Size = new Size(266, 21);
            sr_category.TabIndex = 23;
            sr_category.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_category.Title = "SR Category";
            sr_category.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_category.TitleWidth = 100;
            // 
            // discipline
            // 
            discipline.ControlHeight = 21;
            discipline.ControlWidth = 266;
            discipline.FldTy = null;
            discipline.FontColor = Color.Black;
            discipline.FontFace = "Tahoma";
            discipline.FontSize = 9F;
            discipline.Location = new Point(628, 70);
            discipline.Name = "discipline";
            discipline.Size = new Size(266, 21);
            discipline.TabIndex = 23;
            discipline.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            discipline.Title = "Discipline";
            discipline.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            discipline.TitleWidth = 100;
            // 
            // issue_deptName
            // 
            issue_deptName.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            issue_deptName.Appearance.Options.UseFont = true;
            issue_deptName.ControlHeight = 21;
            issue_deptName.ControlWidth = 266;
            issue_deptName.FontColor = Color.Black;
            issue_deptName.FontFace = "Tahoma";
            issue_deptName.FontSize = 9F;
            issue_deptName.FormatStr = "";
            issue_deptName.Location = new Point(628, 114);
            issue_deptName.Name = "issue_deptName";
            issue_deptName.Size = new Size(266, 21);
            issue_deptName.TabIndex = 7;
            issue_deptName.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            issue_deptName.Title = "";
            issue_deptName.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            issue_deptName.TitleWidth = 1;
            // 
            // sr_date
            // 
            sr_date.ControlHeight = 21;
            sr_date.ControlWidth = 267;
            sr_date.Font = new Font("Tahoma", 9F);
            sr_date.FontColor = Color.Black;
            sr_date.FontFace = "Tahoma";
            sr_date.FontSize = 9F;
            sr_date.FormatStr = "";
            sr_date.Location = new Point(5, 48);
            sr_date.Name = "sr_date";
            sr_date.Size = new Size(267, 21);
            sr_date.TabIndex = 6;
            sr_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_date.Title = "SR Date";
            sr_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_date.TitleWidth = 110;
            // 
            // sr_doc_no
            // 
            sr_doc_no.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sr_doc_no.Appearance.Options.UseFont = true;
            sr_doc_no.ControlHeight = 21;
            sr_doc_no.ControlWidth = 267;
            sr_doc_no.FontColor = Color.Black;
            sr_doc_no.FontFace = "Tahoma";
            sr_doc_no.FontSize = 9F;
            sr_doc_no.FormatStr = "";
            sr_doc_no.Location = new Point(5, 26);
            sr_doc_no.Name = "sr_doc_no";
            sr_doc_no.Size = new Size(267, 21);
            sr_doc_no.TabIndex = 9;
            sr_doc_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_doc_no.Title = "SR No";
            sr_doc_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_doc_no.TitleWidth = 110;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1117, 373);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2, xtraTabPage3 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g20);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1115, 348);
            xtraTabPage1.TabPageWidth = 100;
            xtraTabPage1.Text = "Service";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1115, 348);
            g20.TabIndex = 1;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(ucSplit4);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1115, 348);
            xtraTabPage2.TabPageWidth = 110;
            xtraTabPage2.Text = "Responsibility Matrix";
            // 
            // ucSplit4
            // 
            ucSplit4.Dock = DockStyle.Fill;
            ucSplit4.Location = new Point(0, 0);
            ucSplit4.Name = "ucSplit4";
            // 
            // ucSplit4.Panel1
            // 
            ucSplit4.Panel1.Controls.Add(g30);
            // 
            // ucSplit4.Panel2
            // 
            ucSplit4.Panel2.Controls.Add(ucPanel3);
            ucSplit4.Size = new Size(1115, 348);
            ucSplit4.SplitterDistance = 383;
            ucSplit4.TabIndex = 0;
            ucSplit4.TitleWidth = 121;
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(383, 348);
            g30.TabIndex = 0;
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(groupBox2);
            ucPanel3.Controls.Add(groupBox4);
            ucPanel3.Controls.Add(groupBox1);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(0, 0);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(728, 348);
            ucPanel3.TabIndex = 0;
            ucPanel3.Text = "Responsibility Matrix";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(manpower_supervisor);
            groupBox2.Controls.Add(manpower_engineer);
            groupBox2.Controls.Add(manpower_manager);
            groupBox2.Controls.Add(manpower_safety);
            groupBox2.Controls.Add(manpower_qc);
            groupBox2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(164, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 119);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Indirect Manpower";
            // 
            // manpower_supervisor
            // 
            manpower_supervisor.Checked = false;
            manpower_supervisor.ControlHeight = 20;
            manpower_supervisor.ControlWidth = 89;
            manpower_supervisor.FontColor = Color.Black;
            manpower_supervisor.FontFace = "Tahoma";
            manpower_supervisor.FontSize = 9F;
            manpower_supervisor.Location = new Point(102, 46);
            manpower_supervisor.Name = "manpower_supervisor";
            manpower_supervisor.Size = new Size(89, 20);
            manpower_supervisor.TabIndex = 49;
            manpower_supervisor.Text = "Supervisor";
            manpower_supervisor.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            manpower_supervisor.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // manpower_engineer
            // 
            manpower_engineer.Checked = false;
            manpower_engineer.ControlHeight = 20;
            manpower_engineer.ControlWidth = 89;
            manpower_engineer.FontColor = Color.Black;
            manpower_engineer.FontFace = "Tahoma";
            manpower_engineer.FontSize = 9F;
            manpower_engineer.Location = new Point(6, 46);
            manpower_engineer.Name = "manpower_engineer";
            manpower_engineer.Size = new Size(89, 20);
            manpower_engineer.TabIndex = 49;
            manpower_engineer.Text = "Engineer";
            manpower_engineer.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            manpower_engineer.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // manpower_manager
            // 
            manpower_manager.Checked = false;
            manpower_manager.ControlHeight = 20;
            manpower_manager.ControlWidth = 89;
            manpower_manager.FontColor = Color.Black;
            manpower_manager.FontFace = "Tahoma";
            manpower_manager.FontSize = 9F;
            manpower_manager.Location = new Point(219, 21);
            manpower_manager.Name = "manpower_manager";
            manpower_manager.Size = new Size(89, 20);
            manpower_manager.TabIndex = 49;
            manpower_manager.Text = "Manager";
            manpower_manager.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            manpower_manager.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // manpower_safety
            // 
            manpower_safety.Checked = false;
            manpower_safety.ControlHeight = 20;
            manpower_safety.ControlWidth = 89;
            manpower_safety.FontColor = Color.Black;
            manpower_safety.FontFace = "Tahoma";
            manpower_safety.FontSize = 9F;
            manpower_safety.Location = new Point(102, 20);
            manpower_safety.Name = "manpower_safety";
            manpower_safety.Size = new Size(89, 20);
            manpower_safety.TabIndex = 49;
            manpower_safety.Text = "Safety";
            manpower_safety.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            manpower_safety.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // manpower_qc
            // 
            manpower_qc.Checked = false;
            manpower_qc.ControlHeight = 20;
            manpower_qc.ControlWidth = 89;
            manpower_qc.FontColor = Color.Black;
            manpower_qc.FontFace = "Tahoma";
            manpower_qc.FontSize = 9F;
            manpower_qc.Location = new Point(7, 20);
            manpower_qc.Name = "manpower_qc";
            manpower_qc.Size = new Size(89, 20);
            manpower_qc.TabIndex = 49;
            manpower_qc.Text = "QC";
            manpower_qc.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            manpower_qc.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(etools_none);
            groupBox4.Controls.Add(etools_partial);
            groupBox4.Controls.Add(etools_full);
            groupBox4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(531, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(176, 119);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Service Equipment Tools";
            // 
            // etools_none
            // 
            etools_none.Checked = false;
            etools_none.ControlHeight = 20;
            etools_none.ControlWidth = 89;
            etools_none.FontColor = Color.Black;
            etools_none.FontFace = "Tahoma";
            etools_none.FontSize = 9F;
            etools_none.Location = new Point(6, 72);
            etools_none.Name = "etools_none";
            etools_none.Size = new Size(89, 20);
            etools_none.TabIndex = 49;
            etools_none.Text = "None";
            etools_none.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            etools_none.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // etools_partial
            // 
            etools_partial.Checked = false;
            etools_partial.ControlHeight = 20;
            etools_partial.ControlWidth = 89;
            etools_partial.FontColor = Color.Black;
            etools_partial.FontFace = "Tahoma";
            etools_partial.FontSize = 9F;
            etools_partial.Location = new Point(6, 46);
            etools_partial.Name = "etools_partial";
            etools_partial.Size = new Size(89, 20);
            etools_partial.TabIndex = 49;
            etools_partial.Text = "Partial";
            etools_partial.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            etools_partial.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // etools_full
            // 
            etools_full.Checked = false;
            etools_full.ControlHeight = 20;
            etools_full.ControlWidth = 89;
            etools_full.FontColor = Color.Black;
            etools_full.FontFace = "Tahoma";
            etools_full.FontSize = 9F;
            etools_full.Location = new Point(7, 20);
            etools_full.Name = "etools_full";
            etools_full.Size = new Size(89, 20);
            etools_full.TabIndex = 49;
            etools_full.Text = "Full";
            etools_full.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            etools_full.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(material_none);
            groupBox1.Controls.Add(material_partial);
            groupBox1.Controls.Add(material_full);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(5, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(134, 119);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Material";
            // 
            // material_none
            // 
            material_none.Checked = false;
            material_none.ControlHeight = 20;
            material_none.ControlWidth = 89;
            material_none.FontColor = Color.Black;
            material_none.FontFace = "Tahoma";
            material_none.FontSize = 9F;
            material_none.Location = new Point(6, 72);
            material_none.Name = "material_none";
            material_none.Size = new Size(89, 20);
            material_none.TabIndex = 49;
            material_none.Text = "None";
            material_none.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            material_none.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // material_partial
            // 
            material_partial.Checked = false;
            material_partial.ControlHeight = 20;
            material_partial.ControlWidth = 89;
            material_partial.FontColor = Color.Black;
            material_partial.FontFace = "Tahoma";
            material_partial.FontSize = 9F;
            material_partial.Location = new Point(6, 46);
            material_partial.Name = "material_partial";
            material_partial.Size = new Size(89, 20);
            material_partial.TabIndex = 49;
            material_partial.Text = "Partial";
            material_partial.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            material_partial.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // material_full
            // 
            material_full.Checked = false;
            material_full.ControlHeight = 20;
            material_full.ControlWidth = 89;
            material_full.FontColor = Color.Black;
            material_full.FontFace = "Tahoma";
            material_full.FontSize = 9F;
            material_full.Location = new Point(7, 20);
            material_full.Name = "material_full";
            material_full.Size = new Size(89, 20);
            material_full.TabIndex = 49;
            material_full.Text = "Full";
            material_full.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            material_full.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(g40);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new Size(1115, 348);
            xtraTabPage3.TabPageWidth = 100;
            xtraTabPage3.Text = "Document";
            // 
            // g40
            // 
            g40.Dock = DockStyle.Fill;
            g40.Location = new Point(0, 0);
            g40.Name = "g40";
            g40.Size = new Size(1115, 348);
            g40.TabIndex = 1;
            // 
            // sr_event
            // 
            sr_event.ControlHeight = 21;
            sr_event.ControlWidth = 344;
            sr_event.FldTy = null;
            sr_event.FontColor = Color.Black;
            sr_event.FontFace = "Tahoma";
            sr_event.FontSize = 9F;
            sr_event.Location = new Point(278, 92);
            sr_event.Name = "sr_event";
            sr_event.Size = new Size(344, 21);
            sr_event.TabIndex = 23;
            sr_event.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_event.Title = "Event";
            sr_event.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sr_event.TitleWidth = 200;
            // 
            // SO100
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SO100";
            Size = new Size(1592, 825);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ucTab1).EndInit();
            ucTab1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            ucSplit4.Panel1.ResumeLayout(false);
            ucSplit4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit4).EndInit();
            ucSplit4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel3).EndInit();
            ucPanel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            xtraTabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCDateBox to_dt;
        private Ctrls.UCDateBox fr_dt;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCChkCodeBox f_subcontractor;
        private Ctrls.UCTextBox f_project;
        private Ctrls.UCTextBox f_srno;
        private Ctrls.UCTextBox issue_deptName;
        private Ctrls.UCDateBox sr_date;
        private Ctrls.UCTextBox sr_doc_no;
        private Ctrls.UCCodeBox discipline;
        private Ctrls.UCTextBox prject_name;
        private Ctrls.UCTextBox project;
        private Ctrls.UCTextBox location;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCChkCodeBox f_status;
        private Ctrls.UCDateBox sr_edate;
        private Ctrls.UCDateBox sr_sdate;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private Ctrls.UCTextBox issue_dept;
        private Ctrls.UCCodeBox status;
        private Ctrls.UCTextBox cust_name;
        private Ctrls.UCTextBox cust;
        private GroupBox groupBox3;
        private Ctrls.UCCheckBox sr_guarantee_bank;
        private Ctrls.UCTextBox currency_rate;
        private Ctrls.UCCodeBox currency;
        private Ctrls.UCCheckBox sr_guarantee_na;
        private Label label3;
        private Ctrls.UCTextBox sr_retention_per;
        private Ctrls.UCCheckBox sr_guarantee_retention;
        private Label label2;
        private Ctrls.UCTextBox sr_bond_per;
        private Ctrls.UCCheckBox sr_guarantee_bond;
        private Label label1;
        private Ctrls.UCTextBox sr_bank_per;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCGridSet g40;
        private Ctrls.UCButton btn_revision;
        private Ctrls.UCNote note;
        private Ctrls.UCSplit ucSplit4;
        private Ctrls.UCGridSet g30;
        private Ctrls.UCPanel ucPanel3;
        private Ctrls.UCCodeBox sr_measurement_type;
        private Ctrls.UCCodeBox sr_contract_type;
        private Label label4;
        private GroupBox groupBox1;
        private Ctrls.UCCheckBox material_full;
        private Ctrls.UCCheckBox material_none;
        private Ctrls.UCCheckBox material_partial;
        private GroupBox groupBox2;
        private Ctrls.UCCheckBox manpower_supervisor;
        private Ctrls.UCCheckBox manpower_engineer;
        private Ctrls.UCCheckBox manpower_manager;
        private Ctrls.UCCheckBox manpower_safety;
        private Ctrls.UCCheckBox manpower_qc;
        private GroupBox groupBox4;
        private Ctrls.UCCheckBox etools_none;
        private Ctrls.UCCheckBox etools_partial;
        private Ctrls.UCCheckBox etools_full;
        private Ctrls.UCTextBox sr_rev;
        private Ctrls.UCCodeBox sr_category;
        private Ctrls.UCCodeBox sr_type;
        private Ctrls.UCDateBox so_need_date;
        private Ctrls.UCDateBox committee_date;
        private Ctrls.UCCodeBox sr_event;
    }
}
