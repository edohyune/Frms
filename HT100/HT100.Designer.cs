namespace EpicV004.Frms
{
    partial class HT100
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
            s_emp_status = new Ctrls.UCCodeBox();
            frwk = new Ctrls.UCTextBox();
            frmdt = new Ctrls.UCDateBox();
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
            ucSplit1.Size = new Size(1414, 553);
            ucSplit1.SplitterDistance = 69;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_emp_status);
            ucPanel1.Controls.Add(frwk);
            ucPanel1.Controls.Add(frmdt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1414, 69);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Batch Order";
            // 
            // s_emp_status
            // 
            s_emp_status.Appearance.Font = new Font("Tahoma", 9F);
            s_emp_status.Appearance.Options.UseFont = true;
            s_emp_status.ControlHeight = 21;
            s_emp_status.ControlWidth = 207;
            s_emp_status.FldTy = null;
            s_emp_status.FontColor = Color.Black;
            s_emp_status.FontFace = "Tahoma";
            s_emp_status.FontSize = 9F;
            s_emp_status.Location = new Point(220, 26);
            s_emp_status.Name = "s_emp_status";
            s_emp_status.Size = new Size(207, 21);
            s_emp_status.TabIndex = 2;
            s_emp_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_status.Title = "Employee Status";
            s_emp_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_emp_status.TitleWidth = 100;
            // 
            // frwk
            // 
            frwk.Appearance.Font = new Font("Tahoma", 9F);
            frwk.Appearance.Options.UseFont = true;
            frwk.ControlHeight = 21;
            frwk.ControlWidth = 200;
            frwk.FontColor = Color.Black;
            frwk.FontFace = "Tahoma";
            frwk.FontSize = 9F;
            frwk.FormatStr = "";
            frwk.Location = new Point(5, 48);
            frwk.Name = "frwk";
            frwk.Size = new Size(200, 21);
            frwk.TabIndex = 1;
            frwk.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            frwk.Title = "Week";
            frwk.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            frwk.TitleWidth = 100;
            // 
            // frmdt
            // 
            frmdt.ControlHeight = 21;
            frmdt.ControlWidth = 200;
            frmdt.Font = new Font("Tahoma", 9F);
            frmdt.FontColor = Color.Black;
            frmdt.FontFace = "Tahoma";
            frmdt.FontSize = 9F;
            frmdt.FormatStr = "";
            frmdt.Location = new Point(5, 26);
            frmdt.Name = "frmdt";
            frmdt.Size = new Size(200, 21);
            frmdt.TabIndex = 0;
            frmdt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            frmdt.Title = "Month";
            frmdt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            frmdt.TitleWidth = 100;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1414, 480);
            g10.TabIndex = 0;
            // 
            // HT100
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HT100";
            Size = new Size(1414, 553);
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
        private Ctrls.UCCodeBox s_emp_status;
        private Ctrls.UCTextBox frwk;
        private Ctrls.UCDateBox frmdt;
        private Ctrls.UCGridSet g10;
    }
}
