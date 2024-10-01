namespace EpicV004.Frms
{
    partial class SO201P
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
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
            btn_close = new Ctrls.UCButton();
            btn_select = new Ctrls.UCButton();
            btn_clear = new Ctrls.UCButton();
            btn_qeury = new Ctrls.UCButton();
            s_status = new Ctrls.UCChkCodeBox();
            f_so_doc_no = new Ctrls.UCTextBox();
            so_rev = new Ctrls.UCTextBox();
            f_cust = new Ctrls.UCTextBox();
            so_doc_no = new Ctrls.UCTextBox();
            f_project = new Ctrls.UCTextBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            g20 = new Ctrls.UCGridSet();
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
            ucSplit1.Size = new Size(1563, 777);
            ucSplit1.SplitterDistance = 86;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Controls.Add(btn_close);
            ucPanel1.Controls.Add(btn_select);
            ucPanel1.Controls.Add(btn_clear);
            ucPanel1.Controls.Add(btn_qeury);
            ucPanel1.Controls.Add(s_status);
            ucPanel1.Controls.Add(f_so_doc_no);
            ucPanel1.Controls.Add(so_rev);
            ucPanel1.Controls.Add(f_cust);
            ucPanel1.Controls.Add(so_doc_no);
            ucPanel1.Controls.Add(f_project);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1563, 86);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 248;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(5, 53);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(248, 21);
            to_dt.TabIndex = 12;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 100;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 248;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 26);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(248, 21);
            fr_dt.TabIndex = 12;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "PO Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 100;
            // 
            // btn_close
            // 
            btn_close.Appearance.BackColor = Color.DarkGray;
            btn_close.Appearance.Font = new Font("Tahoma", 9F);
            btn_close.Appearance.Options.UseBackColor = true;
            btn_close.Appearance.Options.UseFont = true;
            btn_close.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_close.ControlHeight = 48;
            btn_close.ControlWidth = 95;
            btn_close.FontBold = FontStyle.Regular;
            btn_close.FontFace = "Tahoma";
            btn_close.FontSize = 9F;
            btn_close.Location = new Point(994, 26);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(95, 48);
            btn_close.TabIndex = 11;
            btn_close.Title = "Close";
            btn_close.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            btn_close.Click += btn_close_Click;
            // 
            // btn_select
            // 
            btn_select.Appearance.BackColor = Color.DarkGray;
            btn_select.Appearance.Font = new Font("Tahoma", 9F);
            btn_select.Appearance.Options.UseBackColor = true;
            btn_select.Appearance.Options.UseFont = true;
            btn_select.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_select.ControlHeight = 48;
            btn_select.ControlWidth = 97;
            btn_select.FontBold = FontStyle.Regular;
            btn_select.FontFace = "Tahoma";
            btn_select.FontSize = 9F;
            btn_select.Location = new Point(891, 26);
            btn_select.Name = "btn_select";
            btn_select.Size = new Size(97, 48);
            btn_select.TabIndex = 11;
            btn_select.Title = "Select";
            btn_select.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            btn_select.Click += btn_select_Click;
            // 
            // btn_clear
            // 
            btn_clear.Appearance.BackColor = Color.DarkGray;
            btn_clear.Appearance.Font = new Font("Tahoma", 9F);
            btn_clear.Appearance.Options.UseBackColor = true;
            btn_clear.Appearance.Options.UseFont = true;
            btn_clear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_clear.ControlHeight = 48;
            btn_clear.ControlWidth = 98;
            btn_clear.FontBold = FontStyle.Regular;
            btn_clear.FontFace = "Tahoma";
            btn_clear.FontSize = 9F;
            btn_clear.Location = new Point(1418, 26);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(98, 48);
            btn_clear.TabIndex = 11;
            btn_clear.Title = "Clear";
            btn_clear.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_qeury
            // 
            btn_qeury.Appearance.BackColor = Color.DarkGray;
            btn_qeury.Appearance.Font = new Font("Tahoma", 9F);
            btn_qeury.Appearance.Options.UseBackColor = true;
            btn_qeury.Appearance.Options.UseFont = true;
            btn_qeury.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_qeury.ControlHeight = 48;
            btn_qeury.ControlWidth = 98;
            btn_qeury.FontBold = FontStyle.Regular;
            btn_qeury.FontFace = "Tahoma";
            btn_qeury.FontSize = 9F;
            btn_qeury.Location = new Point(787, 26);
            btn_qeury.Name = "btn_qeury";
            btn_qeury.Size = new Size(98, 48);
            btn_qeury.TabIndex = 11;
            btn_qeury.Title = "Query";
            btn_qeury.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            btn_qeury.Click += btn_qeury_Click;
            // 
            // s_status
            // 
            s_status.ControlHeight = 21;
            s_status.ControlWidth = 248;
            s_status.FontFace = "Tahoma";
            s_status.FontSize = 9F;
            s_status.Location = new Point(519, 53);
            s_status.Name = "s_status";
            s_status.Size = new Size(248, 21);
            s_status.TabIndex = 10;
            s_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_status.Title = "Status";
            s_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_status.TitleWidth = 100;
            // 
            // f_so_doc_no
            // 
            f_so_doc_no.ControlHeight = 21;
            f_so_doc_no.ControlWidth = 248;
            f_so_doc_no.FontColor = Color.Black;
            f_so_doc_no.FontFace = "Tahoma";
            f_so_doc_no.FontSize = 9F;
            f_so_doc_no.FormatStr = "";
            f_so_doc_no.Location = new Point(519, 26);
            f_so_doc_no.Name = "f_so_doc_no";
            f_so_doc_no.Size = new Size(248, 21);
            f_so_doc_no.TabIndex = 9;
            f_so_doc_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_so_doc_no.Title = "SO No";
            f_so_doc_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_so_doc_no.TitleWidth = 100;
            // 
            // so_rev
            // 
            so_rev.ControlHeight = 21;
            so_rev.ControlWidth = 248;
            so_rev.FontColor = Color.Black;
            so_rev.FontFace = "Tahoma";
            so_rev.FontSize = 9F;
            so_rev.FormatStr = "";
            so_rev.Location = new Point(1155, 53);
            so_rev.Name = "so_rev";
            so_rev.Size = new Size(248, 21);
            so_rev.TabIndex = 9;
            so_rev.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_rev.Title = "Rev";
            so_rev.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_rev.TitleWidth = 100;
            // 
            // f_cust
            // 
            f_cust.ControlHeight = 21;
            f_cust.ControlWidth = 248;
            f_cust.FontColor = Color.Black;
            f_cust.FontFace = "Tahoma";
            f_cust.FontSize = 9F;
            f_cust.FormatStr = "";
            f_cust.Location = new Point(265, 53);
            f_cust.Name = "f_cust";
            f_cust.Size = new Size(248, 21);
            f_cust.TabIndex = 9;
            f_cust.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_cust.Title = "Cust";
            f_cust.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_cust.TitleWidth = 100;
            // 
            // so_doc_no
            // 
            so_doc_no.ControlHeight = 21;
            so_doc_no.ControlWidth = 248;
            so_doc_no.FontColor = Color.Black;
            so_doc_no.FontFace = "Tahoma";
            so_doc_no.FontSize = 9F;
            so_doc_no.FormatStr = "";
            so_doc_no.Location = new Point(1155, 26);
            so_doc_no.Name = "so_doc_no";
            so_doc_no.Size = new Size(248, 21);
            so_doc_no.TabIndex = 9;
            so_doc_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_doc_no.Title = "PO No";
            so_doc_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            so_doc_no.TitleWidth = 100;
            // 
            // f_project
            // 
            f_project.ControlHeight = 21;
            f_project.ControlWidth = 248;
            f_project.FontColor = Color.Black;
            f_project.FontFace = "Tahoma";
            f_project.FontSize = 9F;
            f_project.FormatStr = "";
            f_project.Location = new Point(265, 26);
            f_project.Name = "f_project";
            f_project.Size = new Size(248, 21);
            f_project.TabIndex = 9;
            f_project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project.Title = "Project";
            f_project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project.TitleWidth = 100;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.FixedPanel = FixedPanel.Panel1;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            ucSplit2.Orientation = Orientation.Horizontal;
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(g10);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(g20);
            ucSplit2.Size = new Size(1563, 687);
            ucSplit2.SplitterDistance = 435;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1563, 435);
            g10.TabIndex = 0;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(1563, 248);
            g20.TabIndex = 0;
            // 
            // SO201P
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SO201P";
            Size = new Size(1563, 777);
            Load += SO201P_Load;
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
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCDateBox ucDateBox2;
        private Ctrls.UCDateBox fr_dt;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCTextBox ucTextBox1;
        private Ctrls.UCTextBox ucTextBox2;
        private Ctrls.UCTextBox f_project;
        private Ctrls.UCButton btn_qeury;
        private Ctrls.UCChkCodeBox s_status;
        private Ctrls.UCButton btn_close;
        private Ctrls.UCButton btn_select;
        private Ctrls.UCDateBox to_dt;
        private Ctrls.UCTextBox f_so_doc_no;
        private Ctrls.UCTextBox f_cust;
        private Ctrls.UCButton btn_clear;
        private Ctrls.UCTextBox so_rev;
        private Ctrls.UCTextBox so_doc_no;
    }
}
