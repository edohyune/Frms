namespace EpicV004.Frms
{
    partial class FA700
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
            s_year = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            s_month = new Ctrls.UCDateBox();
            ucGridSet1 = new Ctrls.UCGridSet();
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
            ucSplit1.Size = new Size(1351, 723);
            ucSplit1.SplitterDistance = 51;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_year);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1351, 51);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // s_year
            // 
            s_year.ControlHeight = 21;
            s_year.ControlWidth = 200;
            s_year.FontColor = Color.Black;
            s_year.FontFace = "Tahoma";
            s_year.FontSize = 9F;
            s_year.FormatStr = "";
            s_year.Location = new Point(5, 27);
            s_year.Name = "s_year";
            s_year.Size = new Size(200, 21);
            s_year.TabIndex = 0;
            s_year.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.Title = "Year";
            s_year.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.TitleWidth = 100;
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
            ucSplit2.Size = new Size(1351, 668);
            ucSplit2.SplitterDistance = 218;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(218, 668);
            g10.TabIndex = 0;
            // 
            // ucSplit3
            // 
            ucSplit3.Dock = DockStyle.Fill;
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
            ucSplit3.Panel2.Controls.Add(ucGridSet1);
            ucSplit3.Size = new Size(1129, 668);
            ucSplit3.SplitterDistance = 51;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(s_month);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1129, 51);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Allocate for Manpower";
            // 
            // s_month
            // 
            s_month.ControlHeight = 21;
            s_month.ControlWidth = 200;
            s_month.FontColor = Color.Black;
            s_month.FontFace = "Tahoma";
            s_month.FontSize = 9F;
            s_month.FormatStr = "";
            s_month.Location = new Point(5, 26);
            s_month.Name = "s_month";
            s_month.Size = new Size(200, 21);
            s_month.TabIndex = 0;
            s_month.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_month.Title = "Month";
            s_month.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_month.TitleWidth = 100;
            // 
            // ucGridSet1
            // 
            ucGridSet1.Dock = DockStyle.Fill;
            ucGridSet1.Location = new Point(0, 0);
            ucGridSet1.Name = "ucGridSet1";
            ucGridSet1.Size = new Size(1129, 613);
            ucGridSet1.TabIndex = 0;
            // 
            // FA700
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "FA700";
            Size = new Size(1351, 723);
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
        private Ctrls.UCDateBox s_year;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCDateBox s_month;
        private Ctrls.UCGridSet ucGridSet1;
    }
}
