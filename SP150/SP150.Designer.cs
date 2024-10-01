namespace EpicV004.Frms
{
    partial class SP150
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
            g10 = new Ctrls.UCGridSet();
            ucSplit1 = new Ctrls.UCSplit();
            ucPanel1 = new Ctrls.UCPanel();
            s_status = new Ctrls.UCChkCodeBox();
            invoice_type = new Ctrls.UCChkCodeBox();
            to_dt = new Ctrls.UCDateBox();
            s_client = new Ctrls.UCTextBox();
            s_invoice_no = new Ctrls.UCTextBox();
            fr_dt = new Ctrls.UCDateBox();
            invoice_to = new Ctrls.UCTextBox();
            s_project_no = new Ctrls.UCTextBox();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1303, 719);
            g10.TabIndex = 0;
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
            ucSplit1.Size = new Size(1303, 802);
            ucSplit1.SplitterDistance = 79;
            ucSplit1.TabIndex = 2;
            ucSplit1.TitleWidth = 121;
            ucSplit1.SplitterMoved += ucSplit1_SplitterMoved;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_status);
            ucPanel1.Controls.Add(invoice_type);
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(s_client);
            ucPanel1.Controls.Add(s_invoice_no);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Controls.Add(invoice_to);
            ucPanel1.Controls.Add(s_project_no);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1303, 79);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // s_status
            // 
            s_status.ControlHeight = 21;
            s_status.ControlWidth = 250;
            s_status.FontFace = "Tahoma";
            s_status.FontSize = 9F;
            s_status.Location = new Point(769, 53);
            s_status.Name = "s_status";
            s_status.Size = new Size(250, 21);
            s_status.TabIndex = 16;
            s_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_status.Title = "Status";
            s_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_status.TitleWidth = 110;
            // 
            // invoice_type
            // 
            invoice_type.ControlHeight = 21;
            invoice_type.ControlWidth = 250;
            invoice_type.FontFace = "Tahoma";
            invoice_type.FontSize = 9F;
            invoice_type.Location = new Point(769, 26);
            invoice_type.Name = "invoice_type";
            invoice_type.Size = new Size(250, 21);
            invoice_type.TabIndex = 16;
            invoice_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            invoice_type.Title = "Invoice Type";
            invoice_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            invoice_type.TitleWidth = 110;
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 250;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(5, 53);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(250, 21);
            to_dt.TabIndex = 11;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 94;
            // 
            // s_client
            // 
            s_client.ControlHeight = 21;
            s_client.ControlWidth = 248;
            s_client.FontColor = Color.Black;
            s_client.FontFace = "Tahoma";
            s_client.FontSize = 9F;
            s_client.FormatStr = "";
            s_client.Location = new Point(515, 26);
            s_client.Name = "s_client";
            s_client.Size = new Size(248, 21);
            s_client.TabIndex = 15;
            s_client.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_client.Title = "Client";
            s_client.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_client.TitleWidth = 100;
            // 
            // s_invoice_no
            // 
            s_invoice_no.ControlHeight = 21;
            s_invoice_no.ControlWidth = 248;
            s_invoice_no.FontColor = Color.Black;
            s_invoice_no.FontFace = "Tahoma";
            s_invoice_no.FontSize = 9F;
            s_invoice_no.FormatStr = "";
            s_invoice_no.Location = new Point(261, 53);
            s_invoice_no.Name = "s_invoice_no";
            s_invoice_no.Size = new Size(248, 21);
            s_invoice_no.TabIndex = 15;
            s_invoice_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_invoice_no.Title = "Invoice No";
            s_invoice_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_invoice_no.TitleWidth = 100;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 250;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 26);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(250, 21);
            fr_dt.TabIndex = 12;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 94;
            // 
            // invoice_to
            // 
            invoice_to.ControlHeight = 21;
            invoice_to.ControlWidth = 248;
            invoice_to.FontColor = Color.Black;
            invoice_to.FontFace = "Tahoma";
            invoice_to.FontSize = 9F;
            invoice_to.FormatStr = "";
            invoice_to.Location = new Point(515, 53);
            invoice_to.Name = "invoice_to";
            invoice_to.Size = new Size(248, 21);
            invoice_to.TabIndex = 15;
            invoice_to.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            invoice_to.Title = "Invoice to";
            invoice_to.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            invoice_to.TitleWidth = 100;
            // 
            // s_project_no
            // 
            s_project_no.ControlHeight = 21;
            s_project_no.ControlWidth = 248;
            s_project_no.FontColor = Color.Black;
            s_project_no.FontFace = "Tahoma";
            s_project_no.FontSize = 9F;
            s_project_no.FormatStr = "";
            s_project_no.Location = new Point(261, 26);
            s_project_no.Name = "s_project_no";
            s_project_no.Size = new Size(248, 21);
            s_project_no.TabIndex = 15;
            s_project_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project_no.Title = "Project No";
            s_project_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project_no.TitleWidth = 100;
            // 
            // SP150
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SP150";
            Size = new Size(1303, 802);
            Load += SP150_Load;
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCGridSet g10;
        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCDateBox to_dt;
        private Ctrls.UCTextBox s_invoice_no;
        private Ctrls.UCDateBox fr_dt;
        private Ctrls.UCTextBox s_project_no;
        private Ctrls.UCTextBox s_client;
        private Ctrls.UCTextBox invoice_to;
        private Ctrls.UCChkCodeBox s_status;
        private Ctrls.UCChkCodeBox invoice_type;
    }
}
