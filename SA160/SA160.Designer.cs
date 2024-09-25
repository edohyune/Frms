namespace EpicV004.Frms
{
    partial class SA160
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
            f_status = new Ctrls.UCChkCodeBox();
            f_project_no = new Ctrls.UCTextBox();
            f_client = new Ctrls.UCTextBox();
            f_to_dt = new Ctrls.UCDateBox();
            f_fr_dt = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            btn_viewer = new Ctrls.UCButton();
            btn_submit = new Ctrls.UCButton();
            memo = new Ctrls.UCRichText();
            client = new Ctrls.UCTextBox();
            final_project = new Ctrls.UCTextBox();
            client_name = new Ctrls.UCTextBox();
            project_location = new Ctrls.UCTextBox();
            scope = new Ctrls.UCTextBox();
            project_name = new Ctrls.UCTextBox();
            project_owner = new Ctrls.UCTextBox();
            ucTab1 = new Ctrls.UCTab();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            g20 = new Ctrls.UCGridSet();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            g30 = new Ctrls.UCGridSet();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            g40 = new Ctrls.UCGridSet();
            f_final_project = new Ctrls.UCTextBox();
            project_no = new Ctrls.UCTextBox();
            ucCodeBox1 = new Ctrls.UCCodeBox();
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
            ucPanel1.Controls.Add(f_final_project);
            ucPanel1.Controls.Add(btn_hm);
            ucPanel1.Controls.Add(f_status);
            ucPanel1.Controls.Add(f_project_no);
            ucPanel1.Controls.Add(f_client);
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
            btn_hm.Location = new Point(657, 25);
            btn_hm.Name = "btn_hm";
            btn_hm.Size = new Size(137, 48);
            btn_hm.TabIndex = 3;
            btn_hm.Title = "Hide Master";
            btn_hm.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // f_status
            // 
            f_status.ControlHeight = 21;
            f_status.ControlWidth = 213;
            f_status.FontFace = "Tahoma";
            f_status.FontSize = 9F;
            f_status.Location = new Point(438, 52);
            f_status.Name = "f_status";
            f_status.Size = new Size(213, 21);
            f_status.TabIndex = 2;
            f_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_status.Title = "Status";
            f_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            f_status.TitleWidth = 90;
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
            f_project_no.Location = new Point(219, 53);
            f_project_no.Name = "f_project_no";
            f_project_no.Size = new Size(213, 21);
            f_project_no.TabIndex = 1;
            f_project_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_no.Title = "Project No";
            f_project_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project_no.TitleWidth = 100;
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
            f_client.Location = new Point(438, 26);
            f_client.Name = "f_client";
            f_client.Size = new Size(213, 21);
            f_client.TabIndex = 1;
            f_client.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_client.Title = "Client";
            f_client.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_client.TitleWidth = 90;
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
            ucSplit3.SplitterDistance = 198;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(ucCodeBox1);
            ucPanel2.Controls.Add(btn_viewer);
            ucPanel2.Controls.Add(btn_submit);
            ucPanel2.Controls.Add(memo);
            ucPanel2.Controls.Add(project_no);
            ucPanel2.Controls.Add(client);
            ucPanel2.Controls.Add(final_project);
            ucPanel2.Controls.Add(client_name);
            ucPanel2.Controls.Add(project_location);
            ucPanel2.Controls.Add(scope);
            ucPanel2.Controls.Add(project_name);
            ucPanel2.Controls.Add(project_owner);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1016, 198);
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
            memo.Location = new Point(106, 107);
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
            client.Location = new Point(5, 80);
            client.Name = "client";
            client.Size = new Size(226, 21);
            client.TabIndex = 1;
            client.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            client.Title = "Client";
            client.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            client.TitleWidth = 100;
            // 
            // final_project
            // 
            final_project.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            final_project.Appearance.Options.UseFont = true;
            final_project.ControlHeight = 21;
            final_project.ControlWidth = 226;
            final_project.FontColor = Color.Black;
            final_project.FontFace = "Tahoma";
            final_project.FontSize = 9F;
            final_project.FormatStr = "";
            final_project.Location = new Point(5, 26);
            final_project.Name = "final_project";
            final_project.Size = new Size(226, 21);
            final_project.TabIndex = 1;
            final_project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            final_project.Title = "Final Proposal No";
            final_project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            final_project.TitleWidth = 100;
            // 
            // client_name
            // 
            client_name.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            client_name.Appearance.Options.UseFont = true;
            client_name.ControlHeight = 21;
            client_name.ControlWidth = 353;
            client_name.FontColor = Color.Black;
            client_name.FontFace = "Tahoma";
            client_name.FontSize = 9F;
            client_name.FormatStr = "";
            client_name.Location = new Point(237, 80);
            client_name.Name = "client_name";
            client_name.Size = new Size(353, 21);
            client_name.TabIndex = 1;
            client_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            client_name.Title = "";
            client_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            client_name.TitleWidth = 1;
            // 
            // project_location
            // 
            project_location.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project_location.Appearance.Options.UseFont = true;
            project_location.ControlHeight = 21;
            project_location.ControlWidth = 289;
            project_location.FontColor = Color.Black;
            project_location.FontFace = "Tahoma";
            project_location.FontSize = 9F;
            project_location.FormatStr = "";
            project_location.Location = new Point(596, 26);
            project_location.Name = "project_location";
            project_location.Size = new Size(289, 21);
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
            scope.ControlWidth = 289;
            scope.FontColor = Color.Black;
            scope.FontFace = "Tahoma";
            scope.FontSize = 9F;
            scope.FormatStr = "";
            scope.Location = new Point(596, 53);
            scope.Name = "scope";
            scope.Size = new Size(289, 21);
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
            project_name.ControlWidth = 353;
            project_name.FontColor = Color.Black;
            project_name.FontFace = "Tahoma";
            project_name.FontSize = 9F;
            project_name.FormatStr = "";
            project_name.Location = new Point(237, 26);
            project_name.Name = "project_name";
            project_name.Size = new Size(353, 21);
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
            project_owner.ControlWidth = 353;
            project_owner.FontColor = Color.Black;
            project_owner.FontFace = "Tahoma";
            project_owner.FontSize = 9F;
            project_owner.FormatStr = "";
            project_owner.Location = new Point(237, 53);
            project_owner.Name = "project_owner";
            project_owner.Size = new Size(353, 21);
            project_owner.TabIndex = 1;
            project_owner.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_owner.Title = "Project Owner";
            project_owner.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_owner.TitleWidth = 100;
            // 
            // ucTab1
            // 
            ucTab1.Dock = DockStyle.Fill;
            ucTab1.Location = new Point(0, 0);
            ucTab1.Name = "ucTab1";
            ucTab1.SelectedTabPage = xtraTabPage1;
            ucTab1.Size = new Size(1016, 682);
            ucTab1.TabIndex = 0;
            ucTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2, xtraTabPage3 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(g20);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(1014, 657);
            xtraTabPage1.TabPageWidth = 100;
            xtraTabPage1.Text = "Final Proposal SOP";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1014, 657);
            g20.TabIndex = 1;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(g30);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(1014, 657);
            xtraTabPage2.TabPageWidth = 80;
            xtraTabPage2.Text = "Awaded SOP";
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(1014, 657);
            g30.TabIndex = 1;
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(g40);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new Size(1014, 657);
            xtraTabPage3.TabPageWidth = 60;
            xtraTabPage3.Text = "Document";
            // 
            // g40
            // 
            g40.Dock = DockStyle.Fill;
            g40.Location = new Point(0, 0);
            g40.Name = "g40";
            g40.Size = new Size(1014, 657);
            g40.TabIndex = 1;
            // 
            // f_final_project
            // 
            f_final_project.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_final_project.Appearance.Options.UseFont = true;
            f_final_project.ControlHeight = 21;
            f_final_project.ControlWidth = 213;
            f_final_project.FontColor = Color.Black;
            f_final_project.FontFace = "Tahoma";
            f_final_project.FontSize = 9F;
            f_final_project.FormatStr = "";
            f_final_project.Location = new Point(219, 26);
            f_final_project.Name = "f_final_project";
            f_final_project.Size = new Size(213, 21);
            f_final_project.TabIndex = 4;
            f_final_project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_final_project.Title = "Final Proposal No";
            f_final_project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_final_project.TitleWidth = 100;
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
            project_no.Location = new Point(5, 53);
            project_no.Name = "project_no";
            project_no.Size = new Size(226, 21);
            project_no.TabIndex = 1;
            project_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_no.Title = "Project No";
            project_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_no.TitleWidth = 100;
            // 
            // ucCodeBox1
            // 
            ucCodeBox1.ControlHeight = 21;
            ucCodeBox1.ControlWidth = 289;
            ucCodeBox1.FldTy = null;
            ucCodeBox1.FontColor = Color.Black;
            ucCodeBox1.FontFace = "Tahoma";
            ucCodeBox1.FontSize = 9F;
            ucCodeBox1.Location = new Point(596, 80);
            ucCodeBox1.Name = "ucCodeBox1";
            ucCodeBox1.Size = new Size(289, 21);
            ucCodeBox1.TabIndex = 4;
            ucCodeBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox1.Title = "Status";
            ucCodeBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox1.TitleWidth = 100;
            // 
            // SA160
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SA160";
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
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCButton btn_hm;
        private Ctrls.UCChkCodeBox f_status;
        private Ctrls.UCTextBox f_project_no;
        private Ctrls.UCTextBox f_client;
        private Ctrls.UCDateBox f_to_dt;
        private Ctrls.UCDateBox f_fr_dt;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCTextBox final_project;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCGridSet g30;
        private Ctrls.UCGridSet g40;
        private Ctrls.UCTextBox client;
        private Ctrls.UCTextBox client_name;
        private Ctrls.UCTextBox project_location;
        private Ctrls.UCTextBox scope;
        private Ctrls.UCTextBox project_name;
        private Ctrls.UCTextBox project_owner;
        private Ctrls.UCButton btn_viewer;
        private Ctrls.UCButton btn_submit;
        private Ctrls.UCRichText memo;
        private Ctrls.UCTextBox f_final_project;
        private Ctrls.UCTextBox project_no;
        private Ctrls.UCCodeBox ucCodeBox1;
    }
}
