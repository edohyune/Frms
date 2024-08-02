﻿namespace EpicV004.Frms
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
            s_dept = new Ctrls.UCTextBox();
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
            ucButton1 = new Ctrls.UCButton();
            s_gend = new Ctrls.UCCodeBox();
            s_eng_name = new Ctrls.UCTextBox();
            s_cust = new Ctrls.UCTextBox();
            ucSplit2 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel3 = new Ctrls.UCPanel();
            gend = new Ctrls.UCCodeBox();
            dept = new Ctrls.UCTextBox();
            date = new Ctrls.UCDateBox();
            tell = new Ctrls.UCTextBox();
            addr = new Ctrls.UCTextBox();
            eng_name = new Ctrls.UCTextBox();
            last_name = new Ctrls.UCTextBox();
            first_name = new Ctrls.UCTextBox();
            id = new Ctrls.UCTextBox();
            ucPanel4 = new Ctrls.UCPanel();
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
            ucSplit1.SplitterDistance = 95;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_dept);
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Controls.Add(ucButton1);
            ucPanel1.Controls.Add(s_gend);
            ucPanel1.Controls.Add(s_eng_name);
            ucPanel1.Controls.Add(s_cust);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1165, 95);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // s_dept
            // 
            s_dept.ButtonVisiable = false;
            s_dept.ControlHeight = 21;
            s_dept.ControlWidth = 281;
            s_dept.FontColor = Color.Black;
            s_dept.FontFace = "Tahoma";
            s_dept.FontSize = 9F;
            s_dept.FormatStr = "";
            s_dept.Location = new Point(528, 26);
            s_dept.Name = "s_dept";
            s_dept.Size = new Size(281, 21);
            s_dept.TabIndex = 7;
            s_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.Title = "Depts";
            s_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_dept.TitleWidth = 100;
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 253;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(2, 53);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(253, 21);
            to_dt.TabIndex = 6;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 83;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 18;
            fr_dt.ControlWidth = 255;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(0, 26);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(255, 18);
            fr_dt.TabIndex = 6;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 86;
            // 
            // ucButton1
            // 
            ucButton1.Appearance.BackColor = Color.DarkGray;
            ucButton1.Appearance.Font = new Font("Tahoma", 9F);
            ucButton1.Appearance.Options.UseBackColor = true;
            ucButton1.Appearance.Options.UseFont = true;
            ucButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ucButton1.ControlHeight = 48;
            ucButton1.ControlWidth = 120;
            ucButton1.FontBold = FontStyle.Regular;
            ucButton1.FontFace = "Tahoma";
            ucButton1.FontSize = 9F;
            ucButton1.Location = new Point(815, 26);
            ucButton1.Name = "ucButton1";
            ucButton1.Size = new Size(120, 48);
            ucButton1.TabIndex = 5;
            ucButton1.Title = "Printing";
            ucButton1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            ucButton1.Click += ucButton1_Click;
            // 
            // s_gend
            // 
            s_gend.ControlHeight = 21;
            s_gend.ControlWidth = 200;
            s_gend.FldTy = null;
            s_gend.FontColor = Color.Black;
            s_gend.FontFace = "Tahoma";
            s_gend.FontSize = 9F;
            s_gend.Location = new Point(277, 53);
            s_gend.Name = "s_gend";
            s_gend.Size = new Size(236, 21);
            s_gend.TabIndex = 2;
            s_gend.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_gend.Title = "Gender";
            s_gend.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_gend.TitleWidth = 100;
            // 
            // s_eng_name
            // 
            s_eng_name.ButtonVisiable = false;
            s_eng_name.ControlHeight = 21;
            s_eng_name.ControlWidth = 281;
            s_eng_name.FontColor = Color.Black;
            s_eng_name.FontFace = "Tahoma";
            s_eng_name.FontSize = 9F;
            s_eng_name.FormatStr = "";
            s_eng_name.Location = new Point(528, 53);
            s_eng_name.Name = "s_eng_name";
            s_eng_name.Size = new Size(281, 21);
            s_eng_name.TabIndex = 1;
            s_eng_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_eng_name.Title = "English";
            s_eng_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_eng_name.TitleWidth = 100;
            // 
            // s_cust
            // 
            s_cust.ButtonVisiable = false;
            s_cust.ControlHeight = 21;
            s_cust.ControlWidth = 236;
            s_cust.FontColor = Color.Black;
            s_cust.FontFace = "Tahoma";
            s_cust.FontSize = 9F;
            s_cust.FormatStr = "";
            s_cust.Location = new Point(277, 26);
            s_cust.Name = "s_cust";
            s_cust.Size = new Size(236, 21);
            s_cust.TabIndex = 1;
            s_cust.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_cust.Title = "Customer";
            s_cust.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_cust.TitleWidth = 100;
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
            ucSplit2.Size = new Size(1165, 542);
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
            ucPanel2.Size = new Size(387, 542);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "List Data";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(383, 517);
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
            ucSplit3.Size = new Size(774, 542);
            ucSplit3.SplitterDistance = 200;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(gend);
            ucPanel3.Controls.Add(dept);
            ucPanel3.Controls.Add(date);
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
            // gend
            // 
            gend.ControlHeight = 21;
            gend.ControlWidth = 200;
            gend.FldTy = null;
            gend.FontColor = Color.Black;
            gend.FontFace = "Tahoma";
            gend.FontSize = 9F;
            gend.Location = new Point(356, 38);
            gend.Name = "gend";
            gend.Size = new Size(327, 21);
            gend.TabIndex = 15;
            gend.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            gend.Title = "Gender";
            gend.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            gend.TitleWidth = 100;
            // 
            // dept
            // 
            dept.ButtonVisiable = false;
            dept.ControlHeight = 21;
            dept.ControlWidth = 327;
            dept.FontColor = Color.Black;
            dept.FontFace = "Tahoma";
            dept.FontSize = 9F;
            dept.FormatStr = "";
            dept.Location = new Point(356, 92);
            dept.Name = "dept";
            dept.Size = new Size(327, 21);
            dept.TabIndex = 14;
            dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.Title = "Department";
            dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            dept.TitleWidth = 100;
            // 
            // date
            // 
            date.ControlHeight = 21;
            date.ControlWidth = 327;
            date.FontColor = Color.Black;
            date.FontFace = "Tahoma";
            date.FontSize = 9F;
            date.FormatStr = "";
            date.Location = new Point(356, 119);
            date.Name = "date";
            date.Size = new Size(327, 21);
            date.TabIndex = 13;
            date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            date.Title = "Birtdate";
            date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            date.TitleWidth = 100;
            // 
            // tell
            // 
            tell.ButtonVisiable = false;
            tell.ControlHeight = 21;
            tell.ControlWidth = 327;
            tell.FontColor = Color.Black;
            tell.FontFace = "Tahoma";
            tell.FontSize = 9F;
            tell.FormatStr = "";
            tell.Location = new Point(356, 65);
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
            addr.ButtonVisiable = false;
            addr.ControlHeight = 21;
            addr.ControlWidth = 678;
            addr.FontColor = Color.Black;
            addr.FontFace = "Tahoma";
            addr.FontSize = 9F;
            addr.FormatStr = "";
            addr.Location = new Point(5, 147);
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
            eng_name.ButtonVisiable = false;
            eng_name.ControlHeight = 21;
            eng_name.ControlWidth = 321;
            eng_name.FontColor = Color.Black;
            eng_name.FontFace = "Tahoma";
            eng_name.FontSize = 9F;
            eng_name.FormatStr = "";
            eng_name.Location = new Point(5, 119);
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
            last_name.ButtonVisiable = false;
            last_name.ControlHeight = 21;
            last_name.ControlWidth = 321;
            last_name.FontColor = Color.Black;
            last_name.FontFace = "Tahoma";
            last_name.FontSize = 9F;
            last_name.FormatStr = "";
            last_name.Location = new Point(5, 92);
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
            first_name.ButtonVisiable = false;
            first_name.ControlHeight = 21;
            first_name.ControlWidth = 321;
            first_name.FontColor = Color.Black;
            first_name.FontFace = "Tahoma";
            first_name.FontSize = 9F;
            first_name.FormatStr = "";
            first_name.Location = new Point(5, 65);
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
            id.ButtonVisiable = false;
            id.ControlHeight = 21;
            id.ControlWidth = 321;
            id.FontColor = Color.Black;
            id.FontFace = "Tahoma";
            id.FontSize = 9F;
            id.FormatStr = "";
            id.Location = new Point(5, 38);
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
            ucPanel4.Size = new Size(774, 338);
            ucPanel4.TabIndex = 0;
            ucPanel4.Text = "Detail Data";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(2, 23);
            g20.Name = "g20";
            g20.Size = new Size(770, 313);
            g20.TabIndex = 0;
            // 
            // TST104
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "TST104";
            Size = new Size(1165, 641);
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
        private Ctrls.UCButton ucButton1;
        private Ctrls.UCTextBox ucTextBox2;
        private Ctrls.UCCodeBox s_gend;
        private Ctrls.UCTextBox s_cust;
        private Ctrls.UCDateBox ucDateBox2;
        private Ctrls.UCDateBox ucDateBox1;
        private Ctrls.UCTextBox eng_name;
        private Ctrls.UCTextBox last_name;
        private Ctrls.UCTextBox first_name;
        private Ctrls.UCTextBox id;
        private Ctrls.UCTextBox addr;
        private Ctrls.UCTextBox tell;
        private Ctrls.UCDateBox date;
        private Ctrls.UCTextBox s_eng_name;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCTextBox dept;
        private Ctrls.UCTextBox s_dept;
        private Ctrls.UCCodeBox gend;
        private Ctrls.UCDateBox to_dt;
        private Ctrls.UCDateBox fr_dt;
    }
}