namespace EpicV004.Frms
{
    partial class HR502
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
            s_enable = new Ctrls.UCTextBox();
            s_txt = new Ctrls.UCTextBox();
            ucPanel2 = new Ctrls.UCPanel();
            g10 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // ucSplit1
            // 
            ucSplit1.Dock = DockStyle.Fill;
            ucSplit1.FixedPanel = FixedPanel.Panel1;
            ucSplit1.Location = new Point(0, 0);
            ucSplit1.Margin = new Padding(3, 2, 3, 2);
            ucSplit1.Name = "ucSplit1";
            ucSplit1.Orientation = Orientation.Horizontal;
            // 
            // ucSplit1.Panel1
            // 
            ucSplit1.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucPanel2);
            ucSplit1.Size = new Size(973, 454);
            ucSplit1.SplitterDistance = 63;
            ucSplit1.SplitterWidth = 3;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_enable);
            ucPanel1.Controls.Add(s_txt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Margin = new Padding(3, 2, 3, 2);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(973, 63);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Shift(Work Schedule)";
            // 
            // s_enable
            // 
            s_enable.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_enable.Appearance.Options.UseFont = true;
            s_enable.ControlHeight = 22;
            s_enable.ControlWidth = 250;
            s_enable.FontColor = Color.Black;
            s_enable.FontFace = "Tahoma";
            s_enable.FontSize = 9F;
            s_enable.FormatStr = "";
            s_enable.Location = new Point(283, 35);
            s_enable.Margin = new Padding(4, 2, 4, 2);
            s_enable.Name = "s_enable";
            s_enable.Size = new Size(250, 22);
            s_enable.TabIndex = 1;
            s_enable.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_enable.Title = "Enable";
            s_enable.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_enable.TitleWidth = 50;
            // 
            // s_txt
            // 
            s_txt.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_txt.Appearance.Options.UseFont = true;
            s_txt.ControlHeight = 22;
            s_txt.ControlWidth = 269;
            s_txt.FontColor = Color.Black;
            s_txt.FontFace = "Tahoma";
            s_txt.FontSize = 9F;
            s_txt.FormatStr = "";
            s_txt.Location = new Point(6, 35);
            s_txt.Margin = new Padding(4, 2, 4, 2);
            s_txt.Name = "s_txt";
            s_txt.Size = new Size(269, 22);
            s_txt.TabIndex = 0;
            s_txt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_txt.Title = "Search";
            s_txt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_txt.TitleWidth = 60;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(g10);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Margin = new Padding(3, 2, 3, 2);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(973, 388);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Shift for Staff";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(969, 363);
            g10.TabIndex = 0;
            // 
            // HR502
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HR502";
            Size = new Size(973, 454);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCTextBox s_txt;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCTextBox s_enable;
    }
}
