namespace EpicV004.Frms
{
    partial class TST104
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
            ucButton2 = new Ctrls.UCButton();
            s_txt = new Ctrls.UCTextBox();
            ucSplit2 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel3 = new Ctrls.UCPanel();
            txtChangedFlag = new Ctrls.UCTextBox();
            gend = new Ctrls.UCCodeBox();
            dept_name = new Ctrls.UCTextBox();
            dept = new Ctrls.UCTextBox();
            tell = new Ctrls.UCTextBox();
            addr = new Ctrls.UCTextBox();
            eng_name = new Ctrls.UCTextBox();
            last_name = new Ctrls.UCTextBox();
            first_name = new Ctrls.UCTextBox();
            id = new Ctrls.UCTextBox();
            ucPanel4 = new Ctrls.UCPanel();
            g20 = new Ctrls.UCGridSet();
            s_dept = new Ctrls.UCTextBox();
            s_dept_name = new Ctrls.UCTextBox();
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
            ucSplit1.Size = new Size(1165, 641);
            ucSplit1.SplitterDistance = 74;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_dept_name);
            ucPanel1.Controls.Add(s_dept);
            ucPanel1.Controls.Add(ucButton2);
            ucPanel1.Controls.Add(s_txt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1165, 74);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // ucButton2
            // 
            ucButton2.Appearance.BackColor = Color.Gray;
            ucButton2.Appearance.Font = new Font("Tahoma", 9F);
            ucButton2.Appearance.Options.UseBackColor = true;
            ucButton2.Appearance.Options.UseFont = true;
            ucButton2.AppearancePressed.BackColor = Color.DodgerBlue;
            ucButton2.AppearancePressed.Options.UseBackColor = true;
            ucButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton2.ControlHeight = 35;
            ucButton2.ControlWidth = 100;
            ucButton2.FontBold = FontStyle.Regular;
            ucButton2.FontFace = "Tahoma";
            ucButton2.FontSize = 9F;
            ucButton2.Location = new Point(860, 26);
            ucButton2.Name = "ucButton2";
            ucButton2.Size = new Size(100, 35);
            ucButton2.TabIndex = 1;
            ucButton2.Title = "Print";
            ucButton2.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            ucButton2.Click += ucButton2_Click;
            // 
            // s_txt
            // 
            s_txt.ControlHeight = 21;
            s_txt.ControlWidth = 305;
            s_txt.FontColor = Color.Black;
            s_txt.FontFace = "Tahoma";
            s_txt.FontSize = 9F;
            s_txt.FormatStr = "";
            s_txt.Location = new Point(6, 32);
            s_txt.Margin = new Padding(4, 3, 4, 3);
            s_txt.Name = "s_txt";
            s_txt.Size = new Size(305, 21);
            s_txt.TabIndex = 0;
            s_txt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_txt.Title = "Search";
            s_txt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_txt.TitleWidth = 100;
           
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(ucPanel2);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(ucSplit3);
            ucSplit2.Size = new Size(1165, 563);
            ucSplit2.SplitterDistance = 387;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(g10);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(387, 563);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "List Data";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(383, 538);
            g10.TabIndex = 0;
            g10.UCAfterFocusedRow += g10_UCAfterFocusedRow;
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
            ucSplit3.Size = new Size(774, 563);
            ucSplit3.SplitterDistance = 200;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(txtChangedFlag);
            ucPanel3.Controls.Add(gend);
            ucPanel3.Controls.Add(dept_name);
            ucPanel3.Controls.Add(dept);
            ucPanel3.Controls.Add(tell);
            ucPanel3.Controls.Add(addr);
            ucPanel3.Controls.Add(eng_name);
            ucPanel3.Controls.Add(last_name);
            ucPanel3.Controls.Add(first_name);
            ucPanel3.Controls.Add(id);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(0, 0);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(774, 200);
            ucPanel3.TabIndex = 0;
            ucPanel3.Text = "Master Data";
            // 
            // txtChangedFlag
            // 
            txtChangedFlag.ControlHeight = 21;
            txtChangedFlag.ControlWidth = 110;
            txtChangedFlag.FontColor = Color.Black;
            txtChangedFlag.FontFace = "Tahoma";
            txtChangedFlag.FontSize = 9F;
            txtChangedFlag.FormatStr = "";
            txtChangedFlag.Location = new Point(573, 174);
            txtChangedFlag.Margin = new Padding(4, 3, 4, 3);
            txtChangedFlag.Name = "txtChangedFlag";
            txtChangedFlag.Size = new Size(110, 21);
            txtChangedFlag.TabIndex = 16;
            txtChangedFlag.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            txtChangedFlag.Title = "";
            txtChangedFlag.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            txtChangedFlag.TitleWidth = 0;
            // 
            // gend
            // 
            gend.ControlHeight = 21;
            gend.ControlWidth = 327;
            gend.FldTy = null;
            gend.FontColor = Color.Black;
            gend.FontFace = "Tahoma";
            gend.FontSize = 9F;
            gend.Location = new Point(356, 38);
            gend.Margin = new Padding(4, 3, 4, 3);
            gend.Name = "gend";
            gend.Size = new Size(327, 21);
            gend.TabIndex = 15;
            gend.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            gend.Title = "Gender";
            gend.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            gend.TitleWidth = 100;
            // 
            // dept_name
            // 
            dept_name.ControlHeight = 21;
            dept_name.ControlWidth = 327;
            dept_name.FontColor = Color.Black;
            dept_name.FontFace = "Tahoma";
            dept_name.FontSize = 9F;
            dept_name.FormatStr = "";
            dept_name.Location = new Point(356, 119);
            dept_name.Margin = new Padding(4, 3, 4, 3);
            dept_name.Name = "dept_name";
            dept_name.Size = new Size(327, 21);
            dept_name.TabIndex = 14;
            dept_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.Title = "Dept Name";
            dept_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept_name.TitleWidth = 100;
            // 
            // dept
            // 
            dept.ControlHeight = 21;
            dept.ControlWidth = 327;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(356, 92);
            dept.Margin = new Padding(4, 3, 4, 3);
            dept.Name = "dept";
            dept.Size = new Size(327, 21);
            dept.TabIndex = 14;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Dept";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 100;
            // 
            // tell
            // 
            tell.ControlHeight = 21;
            tell.ControlWidth = 327;
            tell.FontColor = Color.Black;
            tell.FontFace = "Tahoma";
            tell.FontSize = 9F;
            tell.FormatStr = "";
            tell.Location = new Point(356, 65);
            tell.Margin = new Padding(4, 3, 4, 3);
            tell.Name = "tell";
            tell.Size = new Size(327, 21);
            tell.TabIndex = 12;
            tell.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            tell.Title = "Telephone";
            tell.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            tell.TitleWidth = 100;
            // 
            // addr
            // 
            addr.ControlHeight = 21;
            addr.ControlWidth = 678;
            addr.FontColor = Color.Black;
            addr.FontFace = "Tahoma";
            addr.FontSize = 9F;
            addr.FormatStr = "";
            addr.Location = new Point(5, 147);
            addr.Margin = new Padding(4, 3, 4, 3);
            addr.Name = "addr";
            addr.Size = new Size(678, 21);
            addr.TabIndex = 11;
            addr.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            addr.Title = "Address";
            addr.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            addr.TitleWidth = 100;
            // 
            // eng_name
            // 
            eng_name.ControlHeight = 21;
            eng_name.ControlWidth = 321;
            eng_name.FontColor = Color.Black;
            eng_name.FontFace = "Tahoma";
            eng_name.FontSize = 9F;
            eng_name.FormatStr = "";
            eng_name.Location = new Point(5, 119);
            eng_name.Margin = new Padding(4, 3, 4, 3);
            eng_name.Name = "eng_name";
            eng_name.Size = new Size(321, 21);
            eng_name.TabIndex = 10;
            eng_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            eng_name.Title = "English";
            eng_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            eng_name.TitleWidth = 100;
            // 
            // last_name
            // 
            last_name.ControlHeight = 21;
            last_name.ControlWidth = 321;
            last_name.FontColor = Color.Black;
            last_name.FontFace = "Tahoma";
            last_name.FontSize = 9F;
            last_name.FormatStr = "";
            last_name.Location = new Point(5, 92);
            last_name.Margin = new Padding(4, 3, 4, 3);
            last_name.Name = "last_name";
            last_name.Size = new Size(321, 21);
            last_name.TabIndex = 9;
            last_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            last_name.Title = "Last Name";
            last_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            last_name.TitleWidth = 100;
            // 
            // first_name
            // 
            first_name.ControlHeight = 21;
            first_name.ControlWidth = 321;
            first_name.FontColor = Color.Black;
            first_name.FontFace = "Tahoma";
            first_name.FontSize = 9F;
            first_name.FormatStr = "";
            first_name.Location = new Point(5, 65);
            first_name.Margin = new Padding(4, 3, 4, 3);
            first_name.Name = "first_name";
            first_name.Size = new Size(321, 21);
            first_name.TabIndex = 8;
            first_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            first_name.Title = "First Name";
            first_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            first_name.TitleWidth = 100;
            // 
            // id
            // 
            id.ControlHeight = 21;
            id.ControlWidth = 321;
            id.FontColor = Color.Black;
            id.FontFace = "Tahoma";
            id.FontSize = 9F;
            id.FormatStr = "";
            id.Location = new Point(5, 38);
            id.Margin = new Padding(4, 3, 4, 3);
            id.Name = "id";
            id.Size = new Size(321, 21);
            id.TabIndex = 7;
            id.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            id.Title = "Cust ID";
            id.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            id.TitleWidth = 100;
            // 
            // ucPanel4
            // 
            ucPanel4.Controls.Add(g20);
            ucPanel4.Dock = DockStyle.Fill;
            ucPanel4.Location = new Point(0, 0);
            ucPanel4.Name = "ucPanel4";
            ucPanel4.Size = new Size(774, 359);
            ucPanel4.TabIndex = 0;
            ucPanel4.Text = "Detail Data";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(2, 23);
            g20.Name = "g20";
            g20.Size = new Size(770, 334);
            g20.TabIndex = 0;
            // 
            // s_dept
            // 
            s_dept.ControlHeight = 21;
            s_dept.ControlWidth = 244;
            s_dept.FontColor = Color.Black;
            s_dept.FontFace = "Tahoma";
            s_dept.FontSize = 9F;
            s_dept.FormatStr = "";
            s_dept.Location = new Point(318, 32);
            s_dept.Name = "s_dept";
            s_dept.Size = new Size(244, 21);
            s_dept.TabIndex = 4;
            s_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.Title = "Dept";
            s_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.TitleWidth = 100;
            // 
            // s_dept_name
            // 
            s_dept_name.ControlHeight = 21;
            s_dept_name.ControlWidth = 246;
            s_dept_name.FontColor = Color.Black;
            s_dept_name.FontFace = "Tahoma";
            s_dept_name.FontSize = 9F;
            s_dept_name.FormatStr = "";
            s_dept_name.Location = new Point(568, 32);
            s_dept_name.Name = "s_dept_name";
            s_dept_name.Size = new Size(246, 21);
            s_dept_name.TabIndex = 5;
            s_dept_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept_name.Title = "Name";
            s_dept_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept_name.TitleWidth = 100;
            // 
            // TST104
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "TST104";
            Size = new Size(1165, 641);
            Load += TST104_Load;
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

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCSplit ucSplit2;
        private EpicV004.Ctrls.UCSplit ucSplit3;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private EpicV004.Ctrls.UCGridSet g10;
        private EpicV004.Ctrls.UCPanel ucPanel3;
        private EpicV004.Ctrls.UCPanel ucPanel4;
        private Ctrls.UCGridSet ucGridSet1;
        private Ctrls.UCTextBox ucTextBox2;
 
        private Ctrls.UCTextBox eng_name;
        private Ctrls.UCTextBox last_name;
        private Ctrls.UCTextBox first_name;
        private Ctrls.UCTextBox id;
        private Ctrls.UCTextBox addr;
        private Ctrls.UCTextBox tell;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCTextBox dept;
        private Ctrls.UCTextBox s_txt;
        private Ctrls.UCButton ucButton2;
        private Ctrls.UCCodeBox gend;
        private Ctrls.UCTextBox dept_name;
        private Ctrls.UCTextBox txtChangedFlag;
        private Ctrls.UCButton ucButton3;
        private Ctrls.UCTextBox s_dept_name;
        private Ctrls.UCTextBox s_dept;
    }
}
