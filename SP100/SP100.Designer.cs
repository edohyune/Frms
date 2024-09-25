namespace EpicV004.Frms
{
    partial class SP100
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
            f_sop_type = new Ctrls.UCChkCodeBox();
            f_status = new Ctrls.UCChkCodeBox();
            f_project_name = new Ctrls.UCTextBox();
            f_rfq_no = new Ctrls.UCTextBox();
            f_client = new Ctrls.UCTextBox();
            f_project_no = new Ctrls.UCTextBox();
            f_bid_no = new Ctrls.UCTextBox();
            f_to_dt = new Ctrls.UCDateBox();
            f_fr_dt = new Ctrls.UCDateBox();
            g10 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
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
            ucSplit1.Panel2.Controls.Add(g10);
            ucSplit1.Size = new Size(1411, 966);
            ucSplit1.SplitterDistance = 78;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
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
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1411, 884);
            g10.TabIndex = 0;
            // 
            // SP100
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SP100";
            Size = new Size(1411, 966);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
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
    }
}
