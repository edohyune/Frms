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
            s_txt = new Ctrls.UCTextBox();
            ucPanel2 = new Ctrls.UCPanel();
            ucGridSet1 = new Ctrls.UCGridSet();
            s_enable = new Ctrls.UCTextBox();
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
            ucSplit1.Panel2.Controls.Add(ucPanel2);
            ucSplit1.Size = new Size(1112, 605);
            ucSplit1.SplitterDistance = 145;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_enable);
            ucPanel1.Controls.Add(s_txt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1112, 145);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "ucPanel1";
            // 
            // s_txt
            // 
            s_txt.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_txt.Appearance.Options.UseFont = true;
            s_txt.ControlHeight = 29;
            s_txt.ControlWidth = 307;
            s_txt.FontColor = Color.Black;
            s_txt.FontFace = "Tahoma";
            s_txt.FontSize = 9F;
            s_txt.FormatStr = "";
            s_txt.Location = new Point(39, 72);
            s_txt.Margin = new Padding(5, 3, 5, 3);
            s_txt.Name = "s_txt";
            s_txt.Size = new Size(307, 29);
            s_txt.TabIndex = 0;
            s_txt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_txt.Title = "Search";
            s_txt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_txt.TitleWidth = 60;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(ucGridSet1);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1112, 456);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "ucPanel2";
            // 
            // ucGridSet1
            // 
            ucGridSet1.Dock = DockStyle.Fill;
            ucGridSet1.Location = new Point(2, 28);
            ucGridSet1.Margin = new Padding(3, 4, 3, 4);
            ucGridSet1.Name = "ucGridSet1";
            ucGridSet1.Size = new Size(1108, 426);
            ucGridSet1.TabIndex = 0;
            // 
            // s_enable
            // 
            s_enable.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_enable.Appearance.Options.UseFont = true;
            s_enable.ControlHeight = 29;
            s_enable.ControlWidth = 286;
            s_enable.FontColor = Color.Black;
            s_enable.FontFace = "Tahoma";
            s_enable.FontSize = 9F;
            s_enable.FormatStr = "";
            s_enable.Location = new Point(367, 72);
            s_enable.Margin = new Padding(5, 3, 5, 3);
            s_enable.Name = "s_enable";
            s_enable.Size = new Size(286, 29);
            s_enable.TabIndex = 1;
            s_enable.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_enable.Title = "Enable";
            s_enable.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_enable.TitleWidth = 50;
            // 
            // HR502
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR502";
            Size = new Size(1112, 605);
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
        private Ctrls.UCGridSet ucGridSet1;
        private Ctrls.UCTextBox s_enable;
    }
}
