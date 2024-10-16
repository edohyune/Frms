namespace EpicV004.Frms
{
    partial class HC100
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
            g20 = new Ctrls.UCGridSet();
            ucSplit1 = new Ctrls.UCSplit();
            ucPanel1 = new Ctrls.UCPanel();
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            status = new Ctrls.UCCodeBox();
            doc_no = new Ctrls.UCTextBox();
            order_date = new Ctrls.UCDateBox();
            memo = new Ctrls.UCNote();
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
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(888, 454);
            g20.TabIndex = 0;
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
            ucSplit1.Size = new Size(1173, 616);
            ucSplit1.SplitterDistance = 56;
            ucSplit1.TabIndex = 1;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1173, 56);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Batch Promotion Salary";
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 138;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(220, 26);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(138, 21);
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
            ucSplit2.Size = new Size(1173, 556);
            ucSplit2.SplitterDistance = 281;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(281, 556);
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
            ucSplit3.Size = new Size(888, 556);
            ucSplit3.SplitterDistance = 98;
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
            ucPanel2.Size = new Size(888, 98);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Batch Promotion Salary";
            // 
            // status
            // 
            status.ControlHeight = 21;
            status.ControlWidth = 177;
            status.FldTy = null;
            status.FontColor = Color.Black;
            status.FontFace = "Tahoma";
            status.FontSize = 9F;
            status.Location = new Point(261, 27);
            status.Name = "status";
            status.Size = new Size(177, 21);
            status.TabIndex = 3;
            status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.Title = "Status";
            status.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            status.TitleWidth = 50;
            // 
            // doc_no
            // 
            doc_no.ControlHeight = 21;
            doc_no.ControlWidth = 248;
            doc_no.FontColor = Color.Black;
            doc_no.FontFace = "Tahoma";
            doc_no.FontSize = 9F;
            doc_no.FormatStr = "";
            doc_no.Location = new Point(5, 50);
            doc_no.Name = "doc_no";
            doc_no.Size = new Size(248, 21);
            doc_no.TabIndex = 1;
            doc_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            doc_no.Title = "Doc No";
            doc_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            doc_no.TitleWidth = 100;
            // 
            // order_date
            // 
            order_date.ControlHeight = 21;
            order_date.ControlWidth = 248;
            order_date.FontColor = Color.Black;
            order_date.FontFace = "Tahoma";
            order_date.FontSize = 9F;
            order_date.FormatStr = "";
            order_date.Location = new Point(5, 26);
            order_date.Name = "order_date";
            order_date.Size = new Size(248, 21);
            order_date.TabIndex = 0;
            order_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            order_date.Title = "Apply Date";
            order_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            order_date.TitleWidth = 100;
            // 
            // memo
            // 
            memo.ControlHeight = 21;
            memo.ControlWidth = 433;
            memo.FontColor = Color.Black;
            memo.FontFace = "Tahoma";
            memo.FontSize = 9F;
            memo.Location = new Point(5, 75);
            memo.Name = "memo";
            memo.Size = new Size(433, 21);
            memo.TabIndex = 4;
            memo.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            memo.Title = "Memo";
            memo.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            memo.TitleWidth = 97;
            // 
            // HC100
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HC100";
            Size = new Size(1173, 616);
            Load += HC100_Load;
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

        private EpicV004.Ctrls.UCGridSet g20;
        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCDateBox to_dt;
        private EpicV004.Ctrls.UCDateBox fr_dt;
        private EpicV004.Ctrls.UCSplit ucSplit2;
        private EpicV004.Ctrls.UCGridSet g10;
        private EpicV004.Ctrls.UCSplit ucSplit3;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private EpicV004.Ctrls.UCCodeBox status;
        private EpicV004.Ctrls.UCTextBox doc_no;
        private EpicV004.Ctrls.UCDateBox order_date;
        private Ctrls.UCNote memo;
    }
}
