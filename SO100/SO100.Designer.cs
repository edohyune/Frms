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
            f_project_manager = new Ctrls.UCTextBox();
            f_project_no = new Ctrls.UCTextBox();
            f_to_dt = new Ctrls.UCDateBox();
            f_fr_dt = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            amend_amount = new Ctrls.UCTextBox();
            contract_amount = new Ctrls.UCTextBox();
            budget_requester_name = new Ctrls.UCTextBox();
            budget_requester = new Ctrls.UCTextBox();
            status = new Ctrls.UCCodeBox();
            project_manager_name = new Ctrls.UCTextBox();
            Project_manager = new Ctrls.UCTextBox();
            project_date = new Ctrls.UCDateBox();
            project_no = new Ctrls.UCTextBox();
            memo = new Ctrls.UCRichText();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            ucChkCodeBox1 = new Ctrls.UCChkCodeBox();
            ucDateBox1 = new Ctrls.UCDateBox();
            ucDateBox2 = new Ctrls.UCDateBox();
            ucCodeBox1 = new Ctrls.UCCodeBox();
            ucTextBox1 = new Ctrls.UCTextBox();
            ucDateBox3 = new Ctrls.UCDateBox();
            ucDateBox4 = new Ctrls.UCDateBox();
            ucTextBox2 = new Ctrls.UCTextBox();
            ucTextBox3 = new Ctrls.UCTextBox();
            groupBox3 = new GroupBox();
            amount = new Ctrls.UCTextBox();
            ivc_currncy_rate = new Ctrls.UCTextBox();
            ucCheckBox1 = new Ctrls.UCCheckBox();
            label1 = new Label();
            ucTextBox17 = new Ctrls.UCTextBox();
            label2 = new Label();
            ucTextBox4 = new Ctrls.UCTextBox();
            ucCheckBox2 = new Ctrls.UCCheckBox();
            label3 = new Label();
            ucTextBox5 = new Ctrls.UCTextBox();
            ucCheckBox3 = new Ctrls.UCCheckBox();
            ucCheckBox4 = new Ctrls.UCCheckBox();
            ucCodeBox2 = new Ctrls.UCCodeBox();
            ucTextBox6 = new Ctrls.UCTextBox();
            g20 = new Ctrls.UCGridSet();
            g30 = new Ctrls.UCGridSet();
            g40 = new Ctrls.UCGridSet();
            ucButton1 = new Ctrls.UCButton();
            ucButton2 = new Ctrls.UCButton();
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
            xtraTabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
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
            ucPanel1.Controls.Add(ucChkCodeBox1);
            ucPanel1.Controls.Add(f_status);
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
            f_status.Title = "Subcontractor";
            f_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            f_status.TitleWidth = 90;
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
            f_project_manager.Title = "Project ";
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
            f_project_no.Title = "SR No";
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
            ucSplit3.Panel2.Controls.Add(ucTab1);
            ucSplit3.Size = new Size(1238, 575);
            ucSplit3.SplitterDistance = 395;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(ucButton2);
            ucPanel2.Controls.Add(ucButton1);
            ucPanel2.Controls.Add(ucTextBox6);
            ucPanel2.Controls.Add(ucCodeBox2);
            ucPanel2.Controls.Add(groupBox3);
            ucPanel2.Controls.Add(ucTextBox2);
            ucPanel2.Controls.Add(ucDateBox4);
            ucPanel2.Controls.Add(ucDateBox3);
            ucPanel2.Controls.Add(ucCodeBox1);
            ucPanel2.Controls.Add(ucDateBox2);
            ucPanel2.Controls.Add(ucDateBox1);
            ucPanel2.Controls.Add(amend_amount);
            ucPanel2.Controls.Add(contract_amount);
            ucPanel2.Controls.Add(ucTextBox1);
            ucPanel2.Controls.Add(budget_requester_name);
            ucPanel2.Controls.Add(ucTextBox3);
            ucPanel2.Controls.Add(budget_requester);
            ucPanel2.Controls.Add(status);
            ucPanel2.Controls.Add(project_manager_name);
            ucPanel2.Controls.Add(Project_manager);
            ucPanel2.Controls.Add(project_date);
            ucPanel2.Controls.Add(project_no);
            ucPanel2.Controls.Add(memo);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1238, 395);
            ucPanel2.TabIndex = 1;
            // 
            // amend_amount
            // 
            amend_amount.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amend_amount.Appearance.Options.UseFont = true;
            amend_amount.ControlHeight = 21;
            amend_amount.ControlWidth = 266;
            amend_amount.FontColor = Color.Black;
            amend_amount.FontFace = "Tahoma";
            amend_amount.FontSize = 9F;
            amend_amount.FormatStr = "";
            amend_amount.Location = new Point(587, 92);
            amend_amount.Name = "amend_amount";
            amend_amount.Size = new Size(266, 21);
            amend_amount.TabIndex = 30;
            amend_amount.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            amend_amount.Title = "Location";
            amend_amount.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            amend_amount.TitleWidth = 100;
            // 
            // contract_amount
            // 
            contract_amount.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contract_amount.Appearance.Options.UseFont = true;
            contract_amount.ControlHeight = 21;
            contract_amount.ControlWidth = 266;
            contract_amount.FontColor = Color.Black;
            contract_amount.FontFace = "Tahoma";
            contract_amount.FontSize = 9F;
            contract_amount.FormatStr = "";
            contract_amount.Location = new Point(587, 48);
            contract_amount.Name = "contract_amount";
            contract_amount.Size = new Size(266, 21);
            contract_amount.TabIndex = 29;
            contract_amount.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            contract_amount.Title = "SR Type";
            contract_amount.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            contract_amount.TitleWidth = 100;
            // 
            // budget_requester_name
            // 
            budget_requester_name.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            budget_requester_name.Appearance.Options.UseFont = true;
            budget_requester_name.ControlHeight = 21;
            budget_requester_name.ControlWidth = 616;
            budget_requester_name.FontColor = Color.Black;
            budget_requester_name.FontFace = "Tahoma";
            budget_requester_name.FontSize = 9F;
            budget_requester_name.FormatStr = "";
            budget_requester_name.Location = new Point(237, 136);
            budget_requester_name.Name = "budget_requester_name";
            budget_requester_name.Size = new Size(616, 21);
            budget_requester_name.TabIndex = 27;
            budget_requester_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            budget_requester_name.Title = "";
            budget_requester_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            budget_requester_name.TitleWidth = 1;
            // 
            // budget_requester
            // 
            budget_requester.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            budget_requester.Appearance.Options.UseFont = true;
            budget_requester.ControlHeight = 21;
            budget_requester.ControlWidth = 226;
            budget_requester.FontColor = Color.Black;
            budget_requester.FontFace = "Tahoma";
            budget_requester.FontSize = 9F;
            budget_requester.FormatStr = "";
            budget_requester.Location = new Point(5, 136);
            budget_requester.Name = "budget_requester";
            budget_requester.Size = new Size(226, 21);
            budget_requester.TabIndex = 28;
            budget_requester.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            budget_requester.Title = "Project";
            budget_requester.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            budget_requester.TitleWidth = 110;
            // 
            // status
            // 
            status.ControlHeight = 21;
            status.ControlWidth = 266;
            status.FldTy = null;
            status.FontColor = Color.Black;
            status.FontFace = "Tahoma";
            status.FontSize = 9F;
            status.Location = new Point(587, 70);
            status.Name = "status";
            status.Size = new Size(266, 21);
            status.TabIndex = 23;
            status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.Title = "Discipline";
            status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.TitleWidth = 100;
            // 
            // project_manager_name
            // 
            project_manager_name.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project_manager_name.Appearance.Options.UseFont = true;
            project_manager_name.ControlHeight = 21;
            project_manager_name.ControlWidth = 266;
            project_manager_name.FontColor = Color.Black;
            project_manager_name.FontFace = "Tahoma";
            project_manager_name.FontSize = 9F;
            project_manager_name.FormatStr = "";
            project_manager_name.Location = new Point(587, 114);
            project_manager_name.Name = "project_manager_name";
            project_manager_name.Size = new Size(266, 21);
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
            Project_manager.ControlWidth = 344;
            Project_manager.FontColor = Color.Black;
            Project_manager.FontFace = "Tahoma";
            Project_manager.FontSize = 9F;
            Project_manager.FormatStr = "";
            Project_manager.Location = new Point(237, 92);
            Project_manager.Name = "Project_manager";
            Project_manager.Size = new Size(344, 21);
            Project_manager.TabIndex = 8;
            Project_manager.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            Project_manager.Title = "Event";
            Project_manager.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            Project_manager.TitleWidth = 200;
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
            project_date.Title = "SR Date";
            project_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_date.TitleWidth = 110;
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
            project_no.Title = "SR No";
            project_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_no.TitleWidth = 110;
            // 
            // memo
            // 
            memo.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            memo.Appearance.Text.Font = new Font("Cascadia Code Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memo.Appearance.Text.Options.UseFont = true;
            memo.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            memo.Location = new Point(116, 185);
            memo.Modified = true;
            memo.Name = "memo";
            memo.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            memo.Options.DocumentSaveOptions.DefaultFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            memo.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            memo.Options.Search.RegExResultMaxGuaranteedLength = 1000;
            memo.Padding = new Padding(50, 0, 0, 0);
            memo.Size = new Size(737, 32);
            memo.TabIndex = 3;
            memo.Views.SimpleView.AllowDisplayLineNumbers = true;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1238, 176);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2, xtraTabPage3 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g20);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1236, 151);
            xtraTabPage1.TabPageWidth = 100;
            xtraTabPage1.Text = "Service";
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g30);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1236, 151);
            xtraTabPage2.Text = "Responsibility Matrix";
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(g40);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new Size(1236, 151);
            xtraTabPage3.Text = "Document";
            // 
            // ucChkCodeBox1
            // 
            ucChkCodeBox1.ControlHeight = 21;
            ucChkCodeBox1.ControlWidth = 213;
            ucChkCodeBox1.FontFace = "Tahoma";
            ucChkCodeBox1.FontSize = 9F;
            ucChkCodeBox1.Location = new Point(436, 52);
            ucChkCodeBox1.Name = "ucChkCodeBox1";
            ucChkCodeBox1.Size = new Size(213, 21);
            ucChkCodeBox1.TabIndex = 11;
            ucChkCodeBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucChkCodeBox1.Title = "Status";
            ucChkCodeBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            ucChkCodeBox1.TitleWidth = 90;
            // 
            // ucDateBox1
            // 
            ucDateBox1.ControlHeight = 21;
            ucDateBox1.ControlWidth = 226;
            ucDateBox1.Font = new Font("Tahoma", 9F);
            ucDateBox1.FontColor = Color.Black;
            ucDateBox1.FontFace = "Tahoma";
            ucDateBox1.FontSize = 9F;
            ucDateBox1.FormatStr = "";
            ucDateBox1.Location = new Point(5, 70);
            ucDateBox1.Name = "ucDateBox1";
            ucDateBox1.Size = new Size(226, 21);
            ucDateBox1.TabIndex = 34;
            ucDateBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox1.Title = "Start Date";
            ucDateBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox1.TitleWidth = 110;
            // 
            // ucDateBox2
            // 
            ucDateBox2.ControlHeight = 21;
            ucDateBox2.ControlWidth = 226;
            ucDateBox2.Font = new Font("Tahoma", 9F);
            ucDateBox2.FontColor = Color.Black;
            ucDateBox2.FontFace = "Tahoma";
            ucDateBox2.FontSize = 9F;
            ucDateBox2.FormatStr = "";
            ucDateBox2.Location = new Point(5, 92);
            ucDateBox2.Name = "ucDateBox2";
            ucDateBox2.Size = new Size(226, 21);
            ucDateBox2.TabIndex = 35;
            ucDateBox2.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox2.Title = "Finish Date";
            ucDateBox2.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox2.TitleWidth = 110;
            // 
            // ucCodeBox1
            // 
            ucCodeBox1.ControlHeight = 21;
            ucCodeBox1.ControlWidth = 226;
            ucCodeBox1.FldTy = null;
            ucCodeBox1.FontColor = Color.Black;
            ucCodeBox1.FontFace = "Tahoma";
            ucCodeBox1.FontSize = 9F;
            ucCodeBox1.Location = new Point(5, 114);
            ucCodeBox1.Name = "ucCodeBox1";
            ucCodeBox1.Size = new Size(226, 21);
            ucCodeBox1.TabIndex = 36;
            ucCodeBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox1.Title = "Status";
            ucCodeBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox1.TitleWidth = 110;
            // 
            // ucTextBox1
            // 
            ucTextBox1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucTextBox1.Appearance.Options.UseFont = true;
            ucTextBox1.ControlHeight = 21;
            ucTextBox1.ControlWidth = 616;
            ucTextBox1.FontColor = Color.Black;
            ucTextBox1.FontFace = "Tahoma";
            ucTextBox1.FontSize = 9F;
            ucTextBox1.FormatStr = "";
            ucTextBox1.Location = new Point(237, 158);
            ucTextBox1.Name = "ucTextBox1";
            ucTextBox1.Size = new Size(616, 21);
            ucTextBox1.TabIndex = 27;
            ucTextBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox1.Title = "";
            ucTextBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox1.TitleWidth = 1;
            // 
            // ucDateBox3
            // 
            ucDateBox3.ControlHeight = 21;
            ucDateBox3.ControlWidth = 344;
            ucDateBox3.Font = new Font("Tahoma", 9F);
            ucDateBox3.FontColor = Color.Black;
            ucDateBox3.FontFace = "Tahoma";
            ucDateBox3.FontSize = 9F;
            ucDateBox3.FormatStr = "";
            ucDateBox3.Location = new Point(237, 48);
            ucDateBox3.Name = "ucDateBox3";
            ucDateBox3.Size = new Size(344, 21);
            ucDateBox3.TabIndex = 37;
            ucDateBox3.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox3.Title = "Required Committee Meeting Date";
            ucDateBox3.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox3.TitleWidth = 200;
            // 
            // ucDateBox4
            // 
            ucDateBox4.ControlHeight = 21;
            ucDateBox4.ControlWidth = 344;
            ucDateBox4.Font = new Font("Tahoma", 9F);
            ucDateBox4.FontColor = Color.Black;
            ucDateBox4.FontFace = "Tahoma";
            ucDateBox4.FontSize = 9F;
            ucDateBox4.FormatStr = "";
            ucDateBox4.Location = new Point(237, 70);
            ucDateBox4.Name = "ucDateBox4";
            ucDateBox4.Size = new Size(344, 21);
            ucDateBox4.TabIndex = 37;
            ucDateBox4.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox4.Title = "Required Service Order Date";
            ucDateBox4.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox4.TitleWidth = 200;
            // 
            // ucTextBox2
            // 
            ucTextBox2.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucTextBox2.Appearance.Options.UseFont = true;
            ucTextBox2.ControlHeight = 21;
            ucTextBox2.ControlWidth = 344;
            ucTextBox2.FontColor = Color.Black;
            ucTextBox2.FontFace = "Tahoma";
            ucTextBox2.FontSize = 9F;
            ucTextBox2.FormatStr = "";
            ucTextBox2.Location = new Point(237, 114);
            ucTextBox2.Name = "ucTextBox2";
            ucTextBox2.Size = new Size(344, 21);
            ucTextBox2.TabIndex = 38;
            ucTextBox2.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox2.Title = "Issue Dept";
            ucTextBox2.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox2.TitleWidth = 200;
            // 
            // ucTextBox3
            // 
            ucTextBox3.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucTextBox3.Appearance.Options.UseFont = true;
            ucTextBox3.ControlHeight = 21;
            ucTextBox3.ControlWidth = 226;
            ucTextBox3.FontColor = Color.Black;
            ucTextBox3.FontFace = "Tahoma";
            ucTextBox3.FontSize = 9F;
            ucTextBox3.FormatStr = "";
            ucTextBox3.Location = new Point(5, 158);
            ucTextBox3.Name = "ucTextBox3";
            ucTextBox3.Size = new Size(226, 21);
            ucTextBox3.TabIndex = 28;
            ucTextBox3.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox3.Title = "Subcontractor";
            ucTextBox3.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox3.TitleWidth = 110;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ucCheckBox4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(ucTextBox5);
            groupBox3.Controls.Add(ucCheckBox3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(ucTextBox4);
            groupBox3.Controls.Add(ucCheckBox2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(ucTextBox17);
            groupBox3.Controls.Add(ucCheckBox1);
            groupBox3.Controls.Add(amount);
            groupBox3.Controls.Add(ivc_currncy_rate);
            groupBox3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(5, 223);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(861, 107);
            groupBox3.TabIndex = 42;
            groupBox3.TabStop = false;
            groupBox3.Text = "Paylment Term & Condition";
            // 
            // amount
            // 
            amount.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amount.Appearance.Options.UseFont = true;
            amount.ControlHeight = 21;
            amount.ControlWidth = 842;
            amount.FontColor = Color.Black;
            amount.FontFace = "Tahoma";
            amount.FontSize = 9F;
            amount.FormatStr = "";
            amount.Location = new Point(6, 48);
            amount.Name = "amount";
            amount.Size = new Size(842, 21);
            amount.TabIndex = 23;
            amount.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            amount.Title = "Measurement Type";
            amount.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            amount.TitleWidth = 110;
            // 
            // ivc_currncy_rate
            // 
            ivc_currncy_rate.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ivc_currncy_rate.Appearance.Options.UseFont = true;
            ivc_currncy_rate.ControlHeight = 21;
            ivc_currncy_rate.ControlWidth = 842;
            ivc_currncy_rate.FontColor = Color.Black;
            ivc_currncy_rate.FontFace = "Tahoma";
            ivc_currncy_rate.FontSize = 9F;
            ivc_currncy_rate.FormatStr = "";
            ivc_currncy_rate.Location = new Point(6, 21);
            ivc_currncy_rate.Name = "ivc_currncy_rate";
            ivc_currncy_rate.Size = new Size(842, 21);
            ivc_currncy_rate.TabIndex = 22;
            ivc_currncy_rate.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_currncy_rate.Title = "Contract Type";
            ivc_currncy_rate.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ivc_currncy_rate.TitleWidth = 110;
            // 
            // ucCheckBox1
            // 
            ucCheckBox1.Checked = false;
            ucCheckBox1.ControlHeight = 20;
            ucCheckBox1.ControlWidth = 106;
            ucCheckBox1.FontColor = Color.Black;
            ucCheckBox1.FontFace = "Tahoma";
            ucCheckBox1.FontSize = 9F;
            ucCheckBox1.Location = new Point(120, 75);
            ucCheckBox1.Name = "ucCheckBox1";
            ucCheckBox1.Size = new Size(106, 20);
            ucCheckBox1.TabIndex = 43;
            ucCheckBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCheckBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(297, 78);
            label1.Name = "label1";
            label1.Size = new Size(19, 14);
            label1.TabIndex = 45;
            label1.Text = "%";
            // 
            // ucTextBox17
            // 
            ucTextBox17.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucTextBox17.Appearance.Options.UseFont = true;
            ucTextBox17.ControlHeight = 21;
            ucTextBox17.ControlWidth = 59;
            ucTextBox17.FontColor = Color.Black;
            ucTextBox17.FontFace = "Tahoma";
            ucTextBox17.FontSize = 9F;
            ucTextBox17.FormatStr = "";
            ucTextBox17.Location = new Point(232, 75);
            ucTextBox17.Name = "ucTextBox17";
            ucTextBox17.Size = new Size(59, 21);
            ucTextBox17.TabIndex = 44;
            ucTextBox17.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox17.Title = "";
            ucTextBox17.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox17.TitleWidth = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(505, 78);
            label2.Name = "label2";
            label2.Size = new Size(19, 14);
            label2.TabIndex = 48;
            label2.Text = "%";
            // 
            // ucTextBox4
            // 
            ucTextBox4.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucTextBox4.Appearance.Options.UseFont = true;
            ucTextBox4.ControlHeight = 21;
            ucTextBox4.ControlWidth = 59;
            ucTextBox4.FontColor = Color.Black;
            ucTextBox4.FontFace = "Tahoma";
            ucTextBox4.FontSize = 9F;
            ucTextBox4.FormatStr = "";
            ucTextBox4.Location = new Point(440, 75);
            ucTextBox4.Name = "ucTextBox4";
            ucTextBox4.Size = new Size(59, 21);
            ucTextBox4.TabIndex = 47;
            ucTextBox4.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox4.Title = "";
            ucTextBox4.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox4.TitleWidth = 1;
            // 
            // ucCheckBox2
            // 
            ucCheckBox2.Checked = false;
            ucCheckBox2.ControlHeight = 20;
            ucCheckBox2.ControlWidth = 106;
            ucCheckBox2.FontColor = Color.Black;
            ucCheckBox2.FontFace = "Tahoma";
            ucCheckBox2.FontSize = 9F;
            ucCheckBox2.Location = new Point(328, 75);
            ucCheckBox2.Name = "ucCheckBox2";
            ucCheckBox2.Size = new Size(106, 20);
            ucCheckBox2.TabIndex = 46;
            ucCheckBox2.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCheckBox2.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(711, 78);
            label3.Name = "label3";
            label3.Size = new Size(19, 14);
            label3.TabIndex = 51;
            label3.Text = "%";
            // 
            // ucTextBox5
            // 
            ucTextBox5.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucTextBox5.Appearance.Options.UseFont = true;
            ucTextBox5.ControlHeight = 21;
            ucTextBox5.ControlWidth = 59;
            ucTextBox5.FontColor = Color.Black;
            ucTextBox5.FontFace = "Tahoma";
            ucTextBox5.FontSize = 9F;
            ucTextBox5.FormatStr = "";
            ucTextBox5.Location = new Point(647, 75);
            ucTextBox5.Name = "ucTextBox5";
            ucTextBox5.Size = new Size(59, 21);
            ucTextBox5.TabIndex = 50;
            ucTextBox5.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox5.Title = "";
            ucTextBox5.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox5.TitleWidth = 1;
            // 
            // ucCheckBox3
            // 
            ucCheckBox3.Checked = false;
            ucCheckBox3.ControlHeight = 20;
            ucCheckBox3.ControlWidth = 106;
            ucCheckBox3.FontColor = Color.Black;
            ucCheckBox3.FontFace = "Tahoma";
            ucCheckBox3.FontSize = 9F;
            ucCheckBox3.Location = new Point(535, 75);
            ucCheckBox3.Name = "ucCheckBox3";
            ucCheckBox3.Size = new Size(106, 20);
            ucCheckBox3.TabIndex = 49;
            ucCheckBox3.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCheckBox3.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // ucCheckBox4
            // 
            ucCheckBox4.Checked = false;
            ucCheckBox4.ControlHeight = 20;
            ucCheckBox4.ControlWidth = 106;
            ucCheckBox4.FontColor = Color.Black;
            ucCheckBox4.FontFace = "Tahoma";
            ucCheckBox4.FontSize = 9F;
            ucCheckBox4.Location = new Point(742, 75);
            ucCheckBox4.Name = "ucCheckBox4";
            ucCheckBox4.Size = new Size(106, 20);
            ucCheckBox4.TabIndex = 52;
            ucCheckBox4.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCheckBox4.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // ucCodeBox2
            // 
            ucCodeBox2.ControlHeight = 21;
            ucCodeBox2.ControlWidth = 227;
            ucCodeBox2.FldTy = null;
            ucCodeBox2.FontColor = Color.Black;
            ucCodeBox2.FontFace = "Tahoma";
            ucCodeBox2.FontSize = 9F;
            ucCodeBox2.Location = new Point(11, 336);
            ucCodeBox2.Name = "ucCodeBox2";
            ucCodeBox2.Size = new Size(227, 21);
            ucCodeBox2.TabIndex = 43;
            ucCodeBox2.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox2.Title = "Currency";
            ucCodeBox2.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox2.TitleWidth = 110;
            // 
            // ucTextBox6
            // 
            ucTextBox6.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucTextBox6.Appearance.Options.UseFont = true;
            ucTextBox6.ControlHeight = 21;
            ucTextBox6.ControlWidth = 226;
            ucTextBox6.FontColor = Color.Black;
            ucTextBox6.FontFace = "Tahoma";
            ucTextBox6.FontSize = 9F;
            ucTextBox6.FormatStr = "";
            ucTextBox6.Location = new Point(244, 336);
            ucTextBox6.Name = "ucTextBox6";
            ucTextBox6.Size = new Size(226, 21);
            ucTextBox6.TabIndex = 44;
            ucTextBox6.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox6.Title = "Rate";
            ucTextBox6.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox6.TitleWidth = 100;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1236, 151);
            g20.TabIndex = 1;
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(1236, 151);
            g30.TabIndex = 1;
            // 
            // g40
            // 
            g40.Dock = DockStyle.Fill;
            g40.Location = new Point(0, 0);
            g40.Name = "g40";
            g40.Size = new Size(1236, 151);
            g40.TabIndex = 1;
            // 
            // ucButton1
            // 
            ucButton1.Appearance.BackColor = Color.Silver;
            ucButton1.Appearance.Font = new Font("Tahoma", 9F);
            ucButton1.Appearance.Options.UseBackColor = true;
            ucButton1.Appearance.Options.UseFont = true;
            ucButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton1.ControlHeight = 32;
            ucButton1.ControlWidth = 100;
            ucButton1.FontBold = FontStyle.Regular;
            ucButton1.FontFace = "Tahoma";
            ucButton1.FontSize = 9F;
            ucButton1.Location = new Point(859, 48);
            ucButton1.Name = "ucButton1";
            ucButton1.Size = new Size(100, 32);
            ucButton1.TabIndex = 45;
            ucButton1.Title = "Viewer";
            ucButton1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucButton2
            // 
            ucButton2.Appearance.BackColor = Color.Gray;
            ucButton2.Appearance.Font = new Font("Tahoma", 9F);
            ucButton2.Appearance.ForeColor = Color.White;
            ucButton2.Appearance.Options.UseBackColor = true;
            ucButton2.Appearance.Options.UseFont = true;
            ucButton2.Appearance.Options.UseForeColor = true;
            ucButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton2.ControlHeight = 32;
            ucButton2.ControlWidth = 100;
            ucButton2.FontBold = FontStyle.Regular;
            ucButton2.FontFace = "Tahoma";
            ucButton2.FontSize = 9F;
            ucButton2.Location = new Point(859, 86);
            ucButton2.Name = "ucButton2";
            ucButton2.Size = new Size(100, 32);
            ucButton2.TabIndex = 45;
            ucButton2.Title = "Rivision";
            ucButton2.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // SO100
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SO100";
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
            ((System.ComponentModel.ISupportInitialize)ucTab1).EndInit();
            ucTab1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            xtraTabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private Ctrls.UCChkCodeBox f_status;
        private Ctrls.UCTextBox f_project_manager;
        private Ctrls.UCTextBox f_project_no;
        private Ctrls.UCTextBox project_manager_name;
        private Ctrls.UCTextBox Project_manager;
        private Ctrls.UCDateBox project_date;
        private Ctrls.UCTextBox project_no;
        private Ctrls.UCCodeBox status;
        private Ctrls.UCTextBox budget_requester_name;
        private Ctrls.UCTextBox budget_requester;
        private Ctrls.UCTextBox contract_amount;
        private Ctrls.UCTextBox amend_amount;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Ctrls.UCChkCodeBox ucChkCodeBox1;
        private Ctrls.UCDateBox ucDateBox2;
        private Ctrls.UCDateBox ucDateBox1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private Ctrls.UCTextBox ucTextBox2;
        private Ctrls.UCDateBox ucDateBox4;
        private Ctrls.UCDateBox ucDateBox3;
        private Ctrls.UCCodeBox ucCodeBox1;
        private Ctrls.UCTextBox ucTextBox1;
        private Ctrls.UCTextBox ucTextBox3;
        private GroupBox groupBox3;
        private Ctrls.UCCheckBox ucCheckBox1;
        private Ctrls.UCTextBox amount;
        private Ctrls.UCTextBox ivc_currncy_rate;
        private Ctrls.UCTextBox ucTextBox6;
        private Ctrls.UCCodeBox ucCodeBox2;
        private Ctrls.UCCheckBox ucCheckBox4;
        private Label label3;
        private Ctrls.UCTextBox ucTextBox5;
        private Ctrls.UCCheckBox ucCheckBox3;
        private Label label2;
        private Ctrls.UCTextBox ucTextBox4;
        private Ctrls.UCCheckBox ucCheckBox2;
        private Label label1;
        private Ctrls.UCTextBox ucTextBox17;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCGridSet g30;
        private Ctrls.UCGridSet g40;
        private Ctrls.UCButton ucButton2;
        private Ctrls.UCButton ucButton1;
    }
}
