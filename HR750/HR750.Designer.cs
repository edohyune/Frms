namespace EpicV004.Frms
{
    partial class HR750
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
            f_status = new Ctrls.UCCodeBox();
            f_emp = new Ctrls.UCTextBox();
            f_dept = new Ctrls.UCTextBox();
            s_to_dt = new Ctrls.UCDateBox();
            s_fr_dt = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            ucButton1 = new Ctrls.UCButton();
            ucTextBox5 = new Ctrls.UCTextBox();
            ucCodeBox1 = new Ctrls.UCCodeBox();
            ucDateBox3 = new Ctrls.UCDateBox();
            ucTextBox1 = new Ctrls.UCTextBox();
            ucTextBox3 = new Ctrls.UCTextBox();
            ucSplit4 = new Ctrls.UCSplit();
            g20 = new Ctrls.UCGridSet();
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
            ((System.ComponentModel.ISupportInitialize)ucSplit3).BeginInit();
            ucSplit3.Panel1.SuspendLayout();
            ucSplit3.Panel2.SuspendLayout();
            ucSplit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit4).BeginInit();
            ucSplit4.Panel1.SuspendLayout();
            ucSplit4.Panel2.SuspendLayout();
            ucSplit4.SuspendLayout();
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
            ucSplit1.Size = new Size(1321, 707);
            ucSplit1.SplitterDistance = 82;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(f_status);
            ucPanel1.Controls.Add(f_emp);
            ucPanel1.Controls.Add(f_dept);
            ucPanel1.Controls.Add(s_to_dt);
            ucPanel1.Controls.Add(s_fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1321, 82);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Termination";
            // 
            // f_status
            // 
            f_status.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_status.Appearance.Options.UseFont = true;
            f_status.ControlHeight = 21;
            f_status.ControlWidth = 200;
            f_status.FldTy = null;
            f_status.FontColor = Color.Black;
            f_status.FontFace = "Tahoma";
            f_status.FontSize = 9F;
            f_status.Location = new Point(414, 26);
            f_status.Name = "f_status";
            f_status.Size = new Size(200, 21);
            f_status.TabIndex = 7;
            f_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_status.Title = "Status";
            f_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_status.TitleWidth = 93;
            // 
            // f_emp
            // 
            f_emp.Appearance.Font = new Font("Tahoma", 9F);
            f_emp.Appearance.Options.UseFont = true;
            f_emp.ControlHeight = 21;
            f_emp.ControlWidth = 200;
            f_emp.FontColor = Color.Black;
            f_emp.FontFace = "Tahoma";
            f_emp.FontSize = 9F;
            f_emp.FormatStr = "";
            f_emp.Location = new Point(208, 49);
            f_emp.Name = "f_emp";
            f_emp.Size = new Size(200, 21);
            f_emp.TabIndex = 5;
            f_emp.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_emp.Title = "Employee";
            f_emp.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_emp.TitleWidth = 93;
            // 
            // f_dept
            // 
            f_dept.Appearance.Font = new Font("Tahoma", 9F);
            f_dept.Appearance.Options.UseFont = true;
            f_dept.ControlHeight = 21;
            f_dept.ControlWidth = 200;
            f_dept.FontColor = Color.Black;
            f_dept.FontFace = "Tahoma";
            f_dept.FontSize = 9F;
            f_dept.FormatStr = "";
            f_dept.Location = new Point(208, 26);
            f_dept.Name = "f_dept";
            f_dept.Size = new Size(200, 21);
            f_dept.TabIndex = 6;
            f_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_dept.Title = "Dept";
            f_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_dept.TitleWidth = 93;
            // 
            // s_to_dt
            // 
            s_to_dt.ControlHeight = 21;
            s_to_dt.ControlWidth = 200;
            s_to_dt.Font = new Font("Tahoma", 9F);
            s_to_dt.FontColor = Color.Black;
            s_to_dt.FontFace = "Tahoma";
            s_to_dt.FontSize = 9F;
            s_to_dt.FormatStr = "";
            s_to_dt.Location = new Point(2, 49);
            s_to_dt.Name = "s_to_dt";
            s_to_dt.Size = new Size(200, 21);
            s_to_dt.TabIndex = 3;
            s_to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_to_dt.Title = "~";
            s_to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_to_dt.TitleWidth = 80;
            // 
            // s_fr_dt
            // 
            s_fr_dt.ControlHeight = 21;
            s_fr_dt.ControlWidth = 200;
            s_fr_dt.Font = new Font("Tahoma", 9F);
            s_fr_dt.FontColor = Color.Black;
            s_fr_dt.FontFace = "Tahoma";
            s_fr_dt.FontSize = 9F;
            s_fr_dt.FormatStr = "";
            s_fr_dt.Location = new Point(2, 26);
            s_fr_dt.Name = "s_fr_dt";
            s_fr_dt.Size = new Size(200, 21);
            s_fr_dt.TabIndex = 4;
            s_fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_fr_dt.Title = "Resign Date";
            s_fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_fr_dt.TitleWidth = 80;
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
            ucSplit2.Size = new Size(1321, 621);
            ucSplit2.SplitterDistance = 288;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(288, 621);
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
            ucSplit3.Panel2.Controls.Add(ucSplit4);
            ucSplit3.Size = new Size(1029, 621);
            ucSplit3.SplitterDistance = 124;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(ucButton1);
            ucPanel2.Controls.Add(ucTextBox5);
            ucPanel2.Controls.Add(ucCodeBox1);
            ucPanel2.Controls.Add(ucDateBox3);
            ucPanel2.Controls.Add(ucTextBox1);
            ucPanel2.Controls.Add(ucTextBox3);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1029, 124);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Termination Ifo.";
            // 
            // ucButton1
            // 
            ucButton1.Appearance.Font = new Font("Tahoma", 9F);
            ucButton1.Appearance.Options.UseFont = true;
            ucButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton1.ControlHeight = 48;
            ucButton1.ControlWidth = 190;
            ucButton1.FontBold = FontStyle.Regular;
            ucButton1.FontFace = "Tahoma";
            ucButton1.FontSize = 9F;
            ucButton1.Location = new Point(522, 26);
            ucButton1.Name = "ucButton1";
            ucButton1.Size = new Size(190, 48);
            ucButton1.TabIndex = 10;
            ucButton1.Title = "Submit (ERP)";
            ucButton1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // ucTextBox5
            // 
            ucTextBox5.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox5.Appearance.Options.UseFont = true;
            ucTextBox5.ControlHeight = 21;
            ucTextBox5.ControlWidth = 249;
            ucTextBox5.FontColor = Color.Black;
            ucTextBox5.FontFace = "Tahoma";
            ucTextBox5.FontSize = 9F;
            ucTextBox5.FormatStr = "";
            ucTextBox5.Location = new Point(260, 53);
            ucTextBox5.Name = "ucTextBox5";
            ucTextBox5.Size = new Size(249, 21);
            ucTextBox5.TabIndex = 9;
            ucTextBox5.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox5.Title = "Dept";
            ucTextBox5.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox5.TitleWidth = 100;
            // 
            // ucCodeBox1
            // 
            ucCodeBox1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucCodeBox1.Appearance.Options.UseFont = true;
            ucCodeBox1.ControlHeight = 21;
            ucCodeBox1.ControlWidth = 249;
            ucCodeBox1.FldTy = null;
            ucCodeBox1.FontColor = Color.Black;
            ucCodeBox1.FontFace = "Tahoma";
            ucCodeBox1.FontSize = 9F;
            ucCodeBox1.Location = new Point(260, 26);
            ucCodeBox1.Name = "ucCodeBox1";
            ucCodeBox1.Size = new Size(249, 21);
            ucCodeBox1.TabIndex = 8;
            ucCodeBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox1.Title = "Status";
            ucCodeBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox1.TitleWidth = 100;
            // 
            // ucDateBox3
            // 
            ucDateBox3.ControlHeight = 21;
            ucDateBox3.ControlWidth = 248;
            ucDateBox3.Font = new Font("Tahoma", 9F);
            ucDateBox3.FontColor = Color.Black;
            ucDateBox3.FontFace = "Tahoma";
            ucDateBox3.FontSize = 9F;
            ucDateBox3.FormatStr = "";
            ucDateBox3.Location = new Point(5, 53);
            ucDateBox3.Name = "ucDateBox3";
            ucDateBox3.Size = new Size(248, 21);
            ucDateBox3.TabIndex = 5;
            ucDateBox3.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox3.Title = "Termination Date";
            ucDateBox3.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox3.TitleWidth = 100;
            // 
            // ucTextBox1
            // 
            ucTextBox1.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox1.Appearance.Options.UseFont = true;
            ucTextBox1.ControlHeight = 21;
            ucTextBox1.ControlWidth = 504;
            ucTextBox1.FontColor = Color.Black;
            ucTextBox1.FontFace = "Tahoma";
            ucTextBox1.FontSize = 9F;
            ucTextBox1.FormatStr = "";
            ucTextBox1.Location = new Point(5, 80);
            ucTextBox1.Name = "ucTextBox1";
            ucTextBox1.Size = new Size(504, 21);
            ucTextBox1.TabIndex = 1;
            ucTextBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox1.Title = "Memo";
            ucTextBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox1.TitleWidth = 100;
            // 
            // ucTextBox3
            // 
            ucTextBox3.Appearance.Font = new Font("Tahoma", 9F);
            ucTextBox3.Appearance.Options.UseFont = true;
            ucTextBox3.ControlHeight = 21;
            ucTextBox3.ControlWidth = 249;
            ucTextBox3.FontColor = Color.Black;
            ucTextBox3.FontFace = "Tahoma";
            ucTextBox3.FontSize = 9F;
            ucTextBox3.FormatStr = "";
            ucTextBox3.Location = new Point(5, 26);
            ucTextBox3.Name = "ucTextBox3";
            ucTextBox3.Size = new Size(249, 21);
            ucTextBox3.TabIndex = 1;
            ucTextBox3.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox3.Title = "DOC No";
            ucTextBox3.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox3.TitleWidth = 100;
            // 
            // ucSplit4
            // 
            ucSplit4.Dock = DockStyle.Fill;
            ucSplit4.FixedPanel = FixedPanel.Panel1;
            ucSplit4.Location = new Point(0, 0);
            ucSplit4.Name = "ucSplit4";
            // 
            // ucSplit4.Panel1
            // 
            ucSplit4.Panel1.Controls.Add(g20);
            // 
            // ucSplit4.Panel2
            // 
            ucSplit4.Panel2.Controls.Add(g30);
            ucSplit4.Size = new Size(1029, 493);
            ucSplit4.SplitterDistance = 622;
            ucSplit4.TabIndex = 0;
            ucSplit4.TitleWidth = 121;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(622, 493);
            g20.TabIndex = 0;
            // 
            // g30
            // 
            g30.Dock = DockStyle.Fill;
            g30.Location = new Point(0, 0);
            g30.Name = "g30";
            g30.Size = new Size(403, 493);
            g30.TabIndex = 0;
            // 
            // HR750
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR750";
            Size = new Size(1321, 707);
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
            ucSplit4.Panel1.ResumeLayout(false);
            ucSplit4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit4).EndInit();
            ucSplit4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCSplit ucSplit4;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCGridSet g30;
        private Ctrls.UCCodeBox f_status;
        private Ctrls.UCTextBox f_emp;
        private Ctrls.UCTextBox f_dept;
        private Ctrls.UCDateBox s_to_dt;
        private Ctrls.UCDateBox s_fr_dt;
        private Ctrls.UCTextBox ucTextBox3;
        private Ctrls.UCCodeBox ucCodeBox1;
        private Ctrls.UCDateBox ucDateBox3;
        private Ctrls.UCTextBox ucTextBox1;
        private Ctrls.UCButton ucButton1;
        private Ctrls.UCTextBox ucTextBox5;
    }
}
