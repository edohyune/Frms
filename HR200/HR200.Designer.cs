﻿namespace EpicV004.Frms
{
    partial class HR200
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
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            memo = new Ctrls.UCTextBox();
            status = new Ctrls.UCCodeBox();
            doc_no = new Ctrls.UCTextBox();
            order_date = new Ctrls.UCDateBox();
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
            ((System.ComponentModel.ISupportInitialize)ucSplit3).BeginInit();
            ucSplit3.Panel1.SuspendLayout();
            ucSplit3.Panel2.SuspendLayout();
            ucSplit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
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
            ucSplit1.Size = new Size(1183, 597);
            ucSplit1.SplitterDistance = 51;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1183, 51);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Batch Order";
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 135;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(211, 26);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(135, 21);
            to_dt.TabIndex = 1;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 30;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 200;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 26);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(200, 21);
            fr_dt.TabIndex = 0;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Promotion Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 100;
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
            ucSplit2.Size = new Size(1183, 542);
            ucSplit2.SplitterDistance = 260;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(260, 542);
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
            ucSplit3.Panel2.Controls.Add(g20);
            ucSplit3.Size = new Size(919, 542);
            ucSplit3.SplitterDistance = 99;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(memo);
            ucPanel2.Controls.Add(status);
            ucPanel2.Controls.Add(doc_no);
            ucPanel2.Controls.Add(order_date);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(919, 99);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Batch Order List";
            // 
            // memo
            // 
            memo.ControlHeight = 21;
            memo.ControlWidth = 465;
            memo.FontColor = Color.Black;
            memo.FontFace = "Tahoma";
            memo.FontSize = 9F;
            memo.FormatStr = "";
            memo.Location = new Point(5, 72);
            memo.Name = "memo";
            memo.Size = new Size(465, 21);
            memo.TabIndex = 3;
            memo.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            memo.Title = "Memo";
            memo.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            memo.TitleWidth = 100;
            // 
            // status
            // 
            status.ControlHeight = 21;
            status.ControlWidth = 174;
            status.FldTy = null;
            status.FontColor = Color.Black;
            status.FontFace = "Tahoma";
            status.FontSize = 9F;
            status.Location = new Point(296, 26);
            status.Name = "status";
            status.Size = new Size(174, 21);
            status.TabIndex = 2;
            status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.Title = "Status";
            status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.TitleWidth = 50;
            // 
            // doc_no
            // 
            doc_no.ControlHeight = 21;
            doc_no.ControlWidth = 261;
            doc_no.FontColor = Color.Black;
            doc_no.FontFace = "Tahoma";
            doc_no.FontSize = 9F;
            doc_no.FormatStr = "";
            doc_no.Location = new Point(5, 48);
            doc_no.Name = "doc_no";
            doc_no.Size = new Size(261, 21);
            doc_no.TabIndex = 1;
            doc_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            doc_no.Title = "DocNo";
            doc_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            doc_no.TitleWidth = 100;
            // 
            // order_date
            // 
            order_date.ControlHeight = 21;
            order_date.ControlWidth = 261;
            order_date.FontColor = Color.Black;
            order_date.FontFace = "Tahoma";
            order_date.FontSize = 9F;
            order_date.FormatStr = "";
            order_date.Location = new Point(5, 26);
            order_date.Name = "order_date";
            order_date.Size = new Size(261, 21);
            order_date.TabIndex = 0;
            order_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            order_date.Title = "Order Date";
            order_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            order_date.TitleWidth = 100;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(919, 439);
            g20.TabIndex = 0;
            // 
            // HR200
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR200";
            Size = new Size(1183, 597);
            Load += HR200_Load;
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
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCDateBox to_dt;
        private Ctrls.UCDateBox fr_dt;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCTextBox memo;
        private Ctrls.UCCodeBox status;
        private Ctrls.UCTextBox doc_no;
        private Ctrls.UCDateBox order_date;
    }
}