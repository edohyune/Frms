namespace EpicV004.Frms
{
    partial class NTESTDVP
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
            S1 = new Ctrls.UCCodeBox();
            G_10 = new Ctrls.UCGridSet();
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
            ucSplit1.Panel2.Controls.Add(G_10);
            ucSplit1.Size = new Size(1251, 635);
            ucSplit1.SplitterDistance = 105;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(S1);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1251, 105);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "ucPanel1";
            // 
            // S1
            // 
            S1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            S1.Appearance.Options.UseFont = true;
            S1.ControlHeight = 21;
            S1.ControlWidth = 25;
            S1.FontColor = Color.FromArgb(40, 40, 40);
            S1.FontFace = "Tahoma";
            S1.FontSize = 9F;
            S1.Location = new Point(6, 53);
            S1.Margin = new Padding(4, 3, 4, 3);
            S1.Name = "S1";
            S1.Size = new Size(238, 20);
            S1.TabIndex = 0;
            S1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            S1.Title = "Search";
            S1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            S1.TitleWidth = 50;
            // 
            // G_10
            // 
            G_10.Dock = DockStyle.Fill;
            G_10.Location = new Point(0, 0);
            G_10.Name = "G_10";
            G_10.Size = new Size(1251, 526);
            G_10.TabIndex = 0;
            // 
            // NTESTDVP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "NTESTDVP";
            Size = new Size(1251, 635);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCCodeBox S1;
        private EpicV004.Ctrls.UCGridSet G_10;
    }
}
