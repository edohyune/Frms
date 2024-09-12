namespace EpicV004.Frms
{
    partial class HR145
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
            frmDt = new Ctrls.UCDateBox();
            toDt = new Ctrls.UCDateBox();
            s_applicant_id = new Ctrls.UCTextBox();
            ucChkCodeBox1 = new Ctrls.UCChkCodeBox();
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
            ucSplit1.Size = new Size(1395, 582);
            ucSplit1.SplitterDistance = 57;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(ucChkCodeBox1);
            ucPanel1.Controls.Add(s_applicant_id);
            ucPanel1.Controls.Add(toDt);
            ucPanel1.Controls.Add(frmDt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1395, 57);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Applicant Resource Report";
            // 
            // frmDt
            // 
            frmDt.ControlHeight = 21;
            frmDt.ControlWidth = 200;
            frmDt.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frmDt.FontColor = Color.Black;
            frmDt.FontFace = "Tahoma";
            frmDt.FontSize = 9F;
            frmDt.FormatStr = "";
            frmDt.Location = new Point(5, 26);
            frmDt.Name = "frmDt";
            frmDt.Size = new Size(200, 21);
            frmDt.TabIndex = 0;
            frmDt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            frmDt.Title = "Apply Date";
            frmDt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            frmDt.TitleWidth = 100;
            // 
            // toDt
            // 
            toDt.ControlHeight = 21;
            toDt.ControlWidth = 177;
            toDt.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toDt.FontColor = Color.Black;
            toDt.FontFace = "Tahoma";
            toDt.FontSize = 9F;
            toDt.FormatStr = "";
            toDt.Location = new Point(211, 26);
            toDt.Name = "toDt";
            toDt.Size = new Size(177, 21);
            toDt.TabIndex = 0;
            toDt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            toDt.Title = "~";
            toDt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            toDt.TitleWidth = 60;
            // 
            // s_applicant_id
            // 
            s_applicant_id.ControlHeight = 21;
            s_applicant_id.ControlWidth = 200;
            s_applicant_id.FontColor = Color.Black;
            s_applicant_id.FontFace = "Tahoma";
            s_applicant_id.FontSize = 9F;
            s_applicant_id.FormatStr = "";
            s_applicant_id.Location = new Point(394, 26);
            s_applicant_id.Name = "s_applicant_id";
            s_applicant_id.Size = new Size(200, 21);
            s_applicant_id.TabIndex = 1;
            s_applicant_id.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_applicant_id.Title = "Applicant";
            s_applicant_id.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_applicant_id.TitleWidth = 100;
            // 
            // ucChkCodeBox1
            // 
            ucChkCodeBox1.ControlHeight = 21;
            ucChkCodeBox1.ControlWidth = 212;
            ucChkCodeBox1.FontFace = "Tahoma";
            ucChkCodeBox1.FontSize = 9F;
            ucChkCodeBox1.Location = new Point(600, 26);
            ucChkCodeBox1.Name = "ucChkCodeBox1";
            ucChkCodeBox1.Size = new Size(212, 21);
            ucChkCodeBox1.TabIndex = 2;
            ucChkCodeBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucChkCodeBox1.Title = "Employee Status";
            ucChkCodeBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            ucChkCodeBox1.TitleWidth = 100;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1395, 521);
            g10.TabIndex = 0;
            // 
            // HR145
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR145";
            Size = new Size(1395, 582);
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
        private Ctrls.UCChkCodeBox ucChkCodeBox1;
        private Ctrls.UCTextBox s_applicant_id;
        private Ctrls.UCDateBox toDt;
        private Ctrls.UCDateBox frmDt;
        private Ctrls.UCGridSet g10;
    }
}
