namespace EpicV004.Frms
{
    partial class SA100
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
            btn_hm = new Ctrls.UCButton();
            f_sop_type = new Ctrls.UCChkCodeBox();
            f_status = new Ctrls.UCChkCodeBox();
            f_project_name = new Ctrls.UCTextBox();
            f_rfq_no = new Ctrls.UCTextBox();
            f_client = new Ctrls.UCTextBox();
            f_project_no = new Ctrls.UCTextBox();
            f_bid_no = new Ctrls.UCTextBox();
            f_to_dt = new Ctrls.UCDateBox();
            f_fr_dt = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            btn_viewer = new Ctrls.UCButton();
            btn_submit = new Ctrls.UCButton();
            memo = new Ctrls.UCRichText();
            final_status = new Ctrls.UCCodeBox();
            rfq_status = new Ctrls.UCCodeBox();
            bugetary_status = new Ctrls.UCCodeBox();
            client = new Ctrls.UCTextBox();
            project_no = new Ctrls.UCTextBox();
            rfq_no = new Ctrls.UCTextBox();
            client_name = new Ctrls.UCTextBox();
            validity = new Ctrls.UCTextBox();
            rev = new Ctrls.UCTextBox();
            project_location = new Ctrls.UCTextBox();
            scope = new Ctrls.UCTextBox();
            project_name = new Ctrls.UCTextBox();
            project_owner = new Ctrls.UCTextBox();
            sop_type = new Ctrls.UCTextBox();
            bid_no = new Ctrls.UCTextBox();
            bid_date = new Ctrls.UCDateBox();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            g30 = new Ctrls.UCGridSet();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            g40 = new Ctrls.UCGridSet();
            xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            g50 = new Ctrls.UCGridSet();
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
            xtraTabPage4.SuspendLayout();
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
            ucSplit1.Size = new Size(1411, 966);
            ucSplit1.SplitterDistance = 78;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(btn_hm);
            ucPanel1.Controls.Add(f_sop_type);
            ucPanel1.Controls.Add(f_status);
            ucPanel1.Controls.Add(f_project_name);
            ucPanel1.Controls.Add(f_rfq_no);
            ucPanel1.Controls.Add(f_client);
            ucPanel1.Controls.Add(f_project_no);
            ucPanel1.Controls.Add(f_bid_no);
            ucPanel1.Controls.Add(f_to_dt);
            ucPanel1.Controls.Add(f_fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1411, 78);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // btn_hm
            // 
            btn_hm.Appearance.BackColor = Color.Gray;
            btn_hm.Appearance.Font = new Font("Tahoma", 9F);
            btn_hm.Appearance.ForeColor = Color.White;
            btn_hm.Appearance.Options.UseBackColor = true;
            btn_hm.Appearance.Options.UseFont = true;
            btn_hm.Appearance.Options.UseForeColor = true;
            btn_hm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_hm.ControlHeight = 48;
            btn_hm.ControlWidth = 137;
            btn_hm.FontBold = FontStyle.Regular;
            btn_hm.FontFace = "Tahoma";
            btn_hm.FontSize = 9F;
            btn_hm.Location = new Point(1082, 26);
            btn_hm.Name = "btn_hm";
            btn_hm.Size = new Size(137, 48);
            btn_hm.TabIndex = 3;
            btn_hm.Title = "Hide Master";
            btn_hm.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // f_sop_type
            // 
            f_sop_type.ControlHeight = 21;
            f_sop_type.ControlWidth = 200;
            f_sop_type.FontFace = "Tahoma";
            f_sop_type.FontSize = 9F;
            f_sop_type.Location = new Point(876, 53);
            f_sop_type.Name = "f_sop_type";
            f_sop_type.Size = new Size(200, 21);
            f_sop_type.TabIndex = 2;
            f_sop_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_sop_type.Title = "SOP Type";
            f_sop_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            f_sop_type.TitleWidth = 90;
            // 
            // f_status
            // 
            f_status.ControlHeight = 21;
            f_status.ControlWidth = 200;
            f_status.FontFace = "Tahoma";
            f_status.FontSize = 9F;
            f_status.Location = new Point(876, 26);
            f_status.Name = "f_status";
            f_status.Size = new Size(200, 21);
            f_status.TabIndex = 2;
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
            f_project_name.Location = new Point(438, 53);
            f_project_name.Name = "f_project_name";
            f_project_name.Size = new Size(213, 21);
            f_project_name.TabIndex = 1;
            f_project_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_name.Title = "Project Name";
            f_project_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_name.TitleWidth = 90;
            // 
            // f_rfq_no
            // 
            f_rfq_no.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_rfq_no.Appearance.Options.UseFont = true;
            f_rfq_no.ControlHeight = 21;
            f_rfq_no.ControlWidth = 213;
            f_rfq_no.FontColor = Color.Black;
            f_rfq_no.FontFace = "Tahoma";
            f_rfq_no.FontSize = 9F;
            f_rfq_no.FormatStr = "";
            f_rfq_no.Location = new Point(219, 53);
            f_rfq_no.Name = "f_rfq_no";
            f_rfq_no.Size = new Size(213, 21);
            f_rfq_no.TabIndex = 1;
            f_rfq_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_rfq_no.Title = "RFQ No";
            f_rfq_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_rfq_no.TitleWidth = 90;
            // 
            // f_client
            // 
            f_client.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_client.Appearance.Options.UseFont = true;
            f_client.ControlHeight = 21;
            f_client.ControlWidth = 213;
            f_client.FontColor = Color.Black;
            f_client.FontFace = "Tahoma";
            f_client.FontSize = 9F;
            f_client.FormatStr = "";
            f_client.Location = new Point(657, 26);
            f_client.Name = "f_client";
            f_client.Size = new Size(213, 21);
            f_client.TabIndex = 1;
            f_client.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_client.Title = "Client";
            f_client.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_client.TitleWidth = 90;
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
            f_project_no.Location = new Point(438, 26);
            f_project_no.Name = "f_project_no";
            f_project_no.Size = new Size(213, 21);
            f_project_no.TabIndex = 1;
            f_project_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_no.Title = "Project No";
            f_project_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_no.TitleWidth = 90;
            // 
            // f_bid_no
            // 
            f_bid_no.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_bid_no.Appearance.Options.UseFont = true;
            f_bid_no.ControlHeight = 21;
            f_bid_no.ControlWidth = 213;
            f_bid_no.FontColor = Color.Black;
            f_bid_no.FontFace = "Tahoma";
            f_bid_no.FontSize = 9F;
            f_bid_no.FormatStr = "";
            f_bid_no.Location = new Point(219, 26);
            f_bid_no.Name = "f_bid_no";
            f_bid_no.Size = new Size(213, 21);
            f_bid_no.TabIndex = 1;
            f_bid_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_bid_no.Title = "Bidding No";
            f_bid_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_bid_no.TitleWidth = 90;
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
            ucSplit2.Size = new Size(1411, 884);
            ucSplit2.SplitterDistance = 391;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(391, 884);
            g10.TabIndex = 0;
            // 
            // ucSplit3
            // 
            ucSplit3.Dock = DockStyle.Fill;
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
            ucSplit3.Size = new Size(1016, 884);
            ucSplit3.SplitterDistance = 251;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(btn_viewer);
            ucPanel2.Controls.Add(btn_submit);
            ucPanel2.Controls.Add(memo);
            ucPanel2.Controls.Add(final_status);
            ucPanel2.Controls.Add(rfq_status);
            ucPanel2.Controls.Add(bugetary_status);
            ucPanel2.Controls.Add(client);
            ucPanel2.Controls.Add(project_no);
            ucPanel2.Controls.Add(rfq_no);
            ucPanel2.Controls.Add(client_name);
            ucPanel2.Controls.Add(validity);
            ucPanel2.Controls.Add(rev);
            ucPanel2.Controls.Add(project_location);
            ucPanel2.Controls.Add(scope);
            ucPanel2.Controls.Add(project_name);
            ucPanel2.Controls.Add(project_owner);
            ucPanel2.Controls.Add(sop_type);
            ucPanel2.Controls.Add(bid_no);
            ucPanel2.Controls.Add(bid_date);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1016, 251);
            ucPanel2.TabIndex = 1;
            ucPanel2.Text = "Bidding Info";
            // 
            // btn_viewer
            // 
            btn_viewer.Appearance.BackColor = Color.Gainsboro;
            btn_viewer.Appearance.Font = new Font("Tahoma", 9F);
            btn_viewer.Appearance.ForeColor = Color.RoyalBlue;
            btn_viewer.Appearance.Options.UseBackColor = true;
            btn_viewer.Appearance.Options.UseFont = true;
            btn_viewer.Appearance.Options.UseForeColor = true;
            btn_viewer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_viewer.ControlHeight = 48;
            btn_viewer.ControlWidth = 105;
            btn_viewer.FontBold = FontStyle.Regular;
            btn_viewer.FontFace = "Tahoma";
            btn_viewer.FontSize = 9F;
            btn_viewer.Location = new Point(891, 80);
            btn_viewer.Name = "btn_viewer";
            btn_viewer.Size = new Size(105, 48);
            btn_viewer.TabIndex = 3;
            btn_viewer.Title = "Viewer";
            btn_viewer.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // btn_submit
            // 
            btn_submit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            btn_submit.Appearance.Font = new Font("Tahoma", 9F);
            btn_submit.Appearance.ForeColor = Color.White;
            btn_submit.Appearance.Options.UseBackColor = true;
            btn_submit.Appearance.Options.UseFont = true;
            btn_submit.Appearance.Options.UseForeColor = true;
            btn_submit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_submit.ControlHeight = 48;
            btn_submit.ControlWidth = 105;
            btn_submit.FontBold = FontStyle.Regular;
            btn_submit.FontFace = "Tahoma";
            btn_submit.FontSize = 9F;
            btn_submit.Location = new Point(891, 26);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(105, 48);
            btn_submit.TabIndex = 3;
            btn_submit.Title = "Submit (Groupware)";
            btn_submit.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // memo
            // 
            memo.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            memo.Appearance.Text.Font = new Font("Cascadia Code Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memo.Appearance.Text.Options.UseFont = true;
            memo.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            memo.Location = new Point(106, 161);
            memo.Modified = true;
            memo.Name = "memo";
            memo.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            memo.Options.DocumentSaveOptions.DefaultFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            memo.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            memo.Options.Search.RegExResultMaxGuaranteedLength = 1000;
            memo.Padding = new Padding(50, 0, 0, 0);
            memo.Size = new Size(779, 77);
            memo.TabIndex = 3;
            memo.Views.SimpleView.AllowDisplayLineNumbers = true;
            // 
            // final_status
            // 
            final_status.ControlHeight = 21;
            final_status.ControlWidth = 200;
            final_status.FldTy = null;
            final_status.FontColor = Color.Black;
            final_status.FontFace = "Tahoma";
            final_status.FontSize = 9F;
            final_status.Location = new Point(453, 107);
            final_status.Name = "final_status";
            final_status.Size = new Size(200, 21);
            final_status.TabIndex = 2;
            final_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            final_status.Title = "Final Status";
            final_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            final_status.TitleWidth = 100;
            // 
            // rfq_status
            // 
            rfq_status.ControlHeight = 21;
            rfq_status.ControlWidth = 200;
            rfq_status.FldTy = null;
            rfq_status.FontColor = Color.Black;
            rfq_status.FontFace = "Tahoma";
            rfq_status.FontSize = 9F;
            rfq_status.Location = new Point(453, 80);
            rfq_status.Name = "rfq_status";
            rfq_status.Size = new Size(200, 21);
            rfq_status.TabIndex = 2;
            rfq_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            rfq_status.Title = "RFQ Status";
            rfq_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            rfq_status.TitleWidth = 100;
            // 
            // bugetary_status
            // 
            bugetary_status.ControlHeight = 21;
            bugetary_status.ControlWidth = 200;
            bugetary_status.FldTy = null;
            bugetary_status.FontColor = Color.Black;
            bugetary_status.FontFace = "Tahoma";
            bugetary_status.FontSize = 9F;
            bugetary_status.Location = new Point(453, 53);
            bugetary_status.Name = "bugetary_status";
            bugetary_status.Size = new Size(200, 21);
            bugetary_status.TabIndex = 2;
            bugetary_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            bugetary_status.Title = "Bugetary Status";
            bugetary_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            bugetary_status.TitleWidth = 100;
            // 
            // client
            // 
            client.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            client.Appearance.Options.UseFont = true;
            client.ControlHeight = 21;
            client.ControlWidth = 226;
            client.FontColor = Color.Black;
            client.FontFace = "Tahoma";
            client.FontSize = 9F;
            client.FormatStr = "";
            client.Location = new Point(5, 134);
            client.Name = "client";
            client.Size = new Size(226, 21);
            client.TabIndex = 1;
            client.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            client.Title = "Client";
            client.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            client.TitleWidth = 100;
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
            project_no.Location = new Point(5, 80);
            project_no.Name = "project_no";
            project_no.Size = new Size(226, 21);
            project_no.TabIndex = 1;
            project_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_no.Title = "Final Proposal No.";
            project_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_no.TitleWidth = 100;
            // 
            // rfq_no
            // 
            rfq_no.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rfq_no.Appearance.Options.UseFont = true;
            rfq_no.ControlHeight = 21;
            rfq_no.ControlWidth = 226;
            rfq_no.FontColor = Color.Black;
            rfq_no.FontFace = "Tahoma";
            rfq_no.FontSize = 9F;
            rfq_no.FormatStr = "";
            rfq_no.Location = new Point(5, 53);
            rfq_no.Name = "rfq_no";
            rfq_no.Size = new Size(226, 21);
            rfq_no.TabIndex = 1;
            rfq_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            rfq_no.Title = "RFQ No.";
            rfq_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            rfq_no.TitleWidth = 100;
            // 
            // client_name
            // 
            client_name.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            client_name.Appearance.Options.UseFont = true;
            client_name.ControlHeight = 21;
            client_name.ControlWidth = 416;
            client_name.FontColor = Color.Black;
            client_name.FontFace = "Tahoma";
            client_name.FontSize = 9F;
            client_name.FormatStr = "";
            client_name.Location = new Point(237, 134);
            client_name.Name = "client_name";
            client_name.Size = new Size(416, 21);
            client_name.TabIndex = 1;
            client_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            client_name.Title = "";
            client_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            client_name.TitleWidth = 1;
            // 
            // validity
            // 
            validity.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validity.Appearance.Options.UseFont = true;
            validity.ControlHeight = 21;
            validity.ControlWidth = 210;
            validity.FontColor = Color.Black;
            validity.FontFace = "Tahoma";
            validity.FontSize = 9F;
            validity.FormatStr = "";
            validity.Location = new Point(237, 107);
            validity.Name = "validity";
            validity.Size = new Size(210, 21);
            validity.TabIndex = 1;
            validity.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            validity.Title = "Validity";
            validity.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            validity.TitleWidth = 80;
            // 
            // rev
            // 
            rev.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rev.Appearance.Options.UseFont = true;
            rev.ControlHeight = 21;
            rev.ControlWidth = 210;
            rev.FontColor = Color.Black;
            rev.FontFace = "Tahoma";
            rev.FontSize = 9F;
            rev.FormatStr = "";
            rev.Location = new Point(237, 80);
            rev.Name = "rev";
            rev.Size = new Size(210, 21);
            rev.TabIndex = 1;
            rev.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            rev.Title = "Rev";
            rev.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            rev.TitleWidth = 80;
            // 
            // project_location
            // 
            project_location.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project_location.Appearance.Options.UseFont = true;
            project_location.ControlHeight = 21;
            project_location.ControlWidth = 226;
            project_location.FontColor = Color.Black;
            project_location.FontFace = "Tahoma";
            project_location.FontSize = 9F;
            project_location.FormatStr = "";
            project_location.Location = new Point(659, 80);
            project_location.Name = "project_location";
            project_location.Size = new Size(226, 21);
            project_location.TabIndex = 1;
            project_location.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_location.Title = "Project Location";
            project_location.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_location.TitleWidth = 100;
            // 
            // scope
            // 
            scope.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scope.Appearance.Options.UseFont = true;
            scope.ControlHeight = 21;
            scope.ControlWidth = 226;
            scope.FontColor = Color.Black;
            scope.FontFace = "Tahoma";
            scope.FontSize = 9F;
            scope.FormatStr = "";
            scope.Location = new Point(659, 107);
            scope.Name = "scope";
            scope.Size = new Size(226, 21);
            scope.TabIndex = 1;
            scope.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            scope.Title = "Scope of Supply";
            scope.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            scope.TitleWidth = 100;
            // 
            // project_name
            // 
            project_name.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project_name.Appearance.Options.UseFont = true;
            project_name.ControlHeight = 21;
            project_name.ControlWidth = 226;
            project_name.FontColor = Color.Black;
            project_name.FontFace = "Tahoma";
            project_name.FontSize = 9F;
            project_name.FormatStr = "";
            project_name.Location = new Point(659, 26);
            project_name.Name = "project_name";
            project_name.Size = new Size(226, 21);
            project_name.TabIndex = 1;
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
            project_owner.ControlWidth = 226;
            project_owner.FontColor = Color.Black;
            project_owner.FontFace = "Tahoma";
            project_owner.FontSize = 9F;
            project_owner.FormatStr = "";
            project_owner.Location = new Point(659, 53);
            project_owner.Name = "project_owner";
            project_owner.Size = new Size(226, 21);
            project_owner.TabIndex = 1;
            project_owner.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_owner.Title = "Project Owner";
            project_owner.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_owner.TitleWidth = 100;
            // 
            // sop_type
            // 
            sop_type.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sop_type.Appearance.Options.UseFont = true;
            sop_type.ControlHeight = 21;
            sop_type.ControlWidth = 416;
            sop_type.FontColor = Color.Black;
            sop_type.FontFace = "Tahoma";
            sop_type.FontSize = 9F;
            sop_type.FormatStr = "";
            sop_type.Location = new Point(237, 26);
            sop_type.Name = "sop_type";
            sop_type.Size = new Size(416, 21);
            sop_type.TabIndex = 1;
            sop_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            sop_type.Title = "SOP Type";
            sop_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            sop_type.TitleWidth = 80;
            // 
            // bid_no
            // 
            bid_no.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bid_no.Appearance.Options.UseFont = true;
            bid_no.ControlHeight = 21;
            bid_no.ControlWidth = 226;
            bid_no.FontColor = Color.Black;
            bid_no.FontFace = "Tahoma";
            bid_no.FontSize = 9F;
            bid_no.FormatStr = "";
            bid_no.Location = new Point(5, 26);
            bid_no.Name = "bid_no";
            bid_no.Size = new Size(226, 21);
            bid_no.TabIndex = 1;
            bid_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            bid_no.Title = "Bidding No";
            bid_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            bid_no.TitleWidth = 100;
            // 
            // bid_date
            // 
            bid_date.ControlHeight = 21;
            bid_date.ControlWidth = 226;
            bid_date.Font = new Font("Tahoma", 9F);
            bid_date.FontColor = Color.Black;
            bid_date.FontFace = "Tahoma";
            bid_date.FontSize = 9F;
            bid_date.FormatStr = "";
            bid_date.Location = new Point(5, 107);
            bid_date.Name = "bid_date";
            bid_date.Size = new Size(226, 21);
            bid_date.TabIndex = 0;
            bid_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            bid_date.Title = "Bidding Date";
            bid_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            bid_date.TitleWidth = 100;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1016, 629);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2, xtraTabPage3, xtraTabPage4 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g20);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1014, 604);
            xtraTabPage1.TabPageWidth = 80;
            xtraTabPage1.Text = "* More Info";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1014, 604);
            g20.TabIndex = 1;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g30);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1014, 604);
            xtraTabPage2.TabPageWidth = 80;
            xtraTabPage2.Text = "* Job Scope";
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(1014, 604);
            g30.TabIndex = 1;
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(g40);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new Size(1014, 604);
            xtraTabPage3.TabPageWidth = 50;
            xtraTabPage3.Text = "*SOP";
            // 
            // g40
            // 
            g40.Dock = DockStyle.Fill;
            g40.Location = new Point(0, 0);
            g40.Name = "g40";
            g40.Size = new Size(1014, 604);
            g40.TabIndex = 1;
            // 
            // xtraTabPage4
            // 
            xtraTabPage4.Controls.Add(g50);
            xtraTabPage4.Name = "xtraTabPage4";
            xtraTabPage4.Size = new Size(1014, 604);
            xtraTabPage4.TabPageWidth = 100;
            xtraTabPage4.Text = "* Document";
            // 
            // g50
            // 
            g50.Dock = DockStyle.Fill;
            g50.Location = new Point(0, 0);
            g50.Name = "g50";
            g50.Size = new Size(1014, 604);
            g50.TabIndex = 1;
            // 
            // SA100
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SA100";
            Size = new Size(1411, 966);
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
            xtraTabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCTab ucTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCButton btn_hm;
        private Ctrls.UCChkCodeBox f_sop_type;
        private Ctrls.UCChkCodeBox f_status;
        private Ctrls.UCTextBox f_project_name;
        private Ctrls.UCTextBox f_rfq_no;
        private Ctrls.UCTextBox f_client;
        private Ctrls.UCTextBox f_project_no;
        private Ctrls.UCTextBox f_bid_no;
        private Ctrls.UCDateBox f_to_dt;
        private Ctrls.UCDateBox f_fr_dt;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCTextBox project_no;
        private Ctrls.UCTextBox rfq_no;
        private Ctrls.UCTextBox bid_no;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCGridSet g30;
        private Ctrls.UCGridSet g40;
        private Ctrls.UCGridSet g50;
        private Ctrls.UCCodeBox final_status;
        private Ctrls.UCCodeBox rfq_status;
        private Ctrls.UCCodeBox bugetary_status;
        private Ctrls.UCTextBox client;
        private Ctrls.UCTextBox client_name;
        private Ctrls.UCTextBox validity;
        private Ctrls.UCTextBox rev;
        private Ctrls.UCTextBox project_location;
        private Ctrls.UCTextBox scope;
        private Ctrls.UCTextBox project_name;
        private Ctrls.UCTextBox project_owner;
        private Ctrls.UCTextBox sop_type;
        private Ctrls.UCDateBox bid_date;
        private Ctrls.UCButton btn_viewer;
        private Ctrls.UCButton btn_submit;
        private Ctrls.UCRichText memo;
    }
}
