namespace EpicV004.Frms
{
    partial class HR100
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
            g10 = new Ctrls.UCGridSet();
            ucSplit2 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            btn_tdm = new Ctrls.UCButton();
            comment = new Ctrls.UCTextBox();
            renewal_date = new Ctrls.UCDateBox();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel3 = new Ctrls.UCPanel();
            g20 = new Ctrls.UCGridSet();
            ucPanel4 = new Ctrls.UCPanel();
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
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit3).BeginInit();
            ucSplit3.Panel1.SuspendLayout();
            ucSplit3.Panel2.SuspendLayout();
            ucSplit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel3).BeginInit();
            ucPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel4).BeginInit();
            ucPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // ucSplit1
            // 
            ucSplit1.Dock = DockStyle.Fill;
            ucSplit1.Location = new Point(0, 0);
            ucSplit1.Name = "ucSplit1";
            // 
            // ucSplit1.Panel1
            // 
            ucSplit1.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucSplit2);
            ucSplit1.Size = new Size(1316, 728);
            ucSplit1.SplitterDistance = 438;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(g10);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(438, 728);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "History of Renewal date";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(434, 703);
            g10.TabIndex = 0;
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
            ucSplit2.Panel1.Controls.Add(ucPanel2);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(ucSplit3);
            ucSplit2.Size = new Size(874, 728);
            ucSplit2.SplitterDistance = 95;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(btn_tdm);
            ucPanel2.Controls.Add(comment);
            ucPanel2.Controls.Add(renewal_date);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(874, 95);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Dept Register Date";
            // 
            // btn_tdm
            // 
            btn_tdm.Appearance.Font = new Font("Tahoma", 9F);
            btn_tdm.Appearance.Options.UseFont = true;
            btn_tdm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_tdm.ControlHeight = 48;
            btn_tdm.ControlWidth = 143;
            btn_tdm.FontBold = FontStyle.Regular;
            btn_tdm.FontFace = "Tahoma";
            btn_tdm.FontSize = 9F;
            btn_tdm.Location = new Point(429, 26);
            btn_tdm.Name = "btn_tdm";
            btn_tdm.Size = new Size(143, 48);
            btn_tdm.TabIndex = 2;
            btn_tdm.Title = "Transfer Dept Master";
            btn_tdm.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // comment
            // 
            comment.ControlHeight = 21;
            comment.ControlWidth = 418;
            comment.FontColor = Color.Black;
            comment.FontFace = "Tahoma";
            comment.FontSize = 9F;
            comment.FormatStr = "";
            comment.Location = new Point(5, 53);
            comment.Name = "comment";
            comment.Size = new Size(418, 21);
            comment.TabIndex = 1;
            comment.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            comment.Title = "Comment";
            comment.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            comment.TitleWidth = 100;
            // 
            // renewal_date
            // 
            renewal_date.ControlHeight = 21;
            renewal_date.ControlWidth = 229;
            renewal_date.FontColor = Color.Black;
            renewal_date.FontFace = "Tahoma";
            renewal_date.FontSize = 9F;
            renewal_date.FormatStr = "";
            renewal_date.Location = new Point(5, 26);
            renewal_date.Name = "renewal_date";
            renewal_date.Size = new Size(229, 21);
            renewal_date.TabIndex = 0;
            renewal_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            renewal_date.Title = "Renewal Date";
            renewal_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            renewal_date.TitleWidth = 100;
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
            ucSplit3.Panel1.Controls.Add(ucPanel3);
            // 
            // ucSplit3.Panel2
            // 
            ucSplit3.Panel2.Controls.Add(ucPanel4);
            ucSplit3.Size = new Size(874, 629);
            ucSplit3.SplitterDistance = 281;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(g20);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(0, 0);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(874, 281);
            ucPanel3.TabIndex = 0;
            ucPanel3.Text = "Register Dept";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(2, 23);
            g20.Name = "g20";
            g20.Size = new Size(870, 256);
            g20.TabIndex = 0;
            // 
            // ucPanel4
            // 
            ucPanel4.Controls.Add(g30);
            ucPanel4.Dock = DockStyle.Fill;
            ucPanel4.Location = new Point(0, 0);
            ucPanel4.Name = "ucPanel4";
            ucPanel4.Size = new Size(874, 344);
            ucPanel4.TabIndex = 0;
            ucPanel4.Text = "Staff List";
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(2, 23);
            g30.Name = "g30";
            g30.Size = new Size(870, 319);
            g30.TabIndex = 0;
            // 
            // HR100
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR100";
            Size = new Size(1316, 728);
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
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ucSplit3.Panel1.ResumeLayout(false);
            ucSplit3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit3).EndInit();
            ucSplit3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel3).EndInit();
            ucPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel4).EndInit();
            ucPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCButton btn_tdm;
        private Ctrls.UCTextBox comment;
        private Ctrls.UCDateBox renewal_date;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel3;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCPanel ucPanel4;
        private Ctrls.UCGridSet g30;
    }
}
