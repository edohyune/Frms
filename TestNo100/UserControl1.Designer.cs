namespace TestNo100
{
    partial class UserControl1
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
            ucSplit1 = new EpicV004.Ctrls.UCSplit();
            ucPanel1 = new EpicV004.Ctrls.UCPanel();
            ucCodeBox1 = new EpicV004.Ctrls.UCCodeBox();
            ucGridSet1 = new EpicV004.Ctrls.UCGridSet();
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
            ucSplit1.Panel2.Controls.Add(ucGridSet1);
            ucSplit1.Size = new Size(800, 450);
            ucSplit1.SplitterDistance = 118;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(ucCodeBox1);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(800, 118);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "ucPanel1";
            // 
            // ucCodeBox1
            // 
            ucCodeBox1.ControlHeight = 21;
            ucCodeBox1.ControlWidth = 200;
            ucCodeBox1.FontColor = Color.FromArgb(40, 40, 40);
            ucCodeBox1.FontFace = "Tahoma";
            ucCodeBox1.FontSize = 9F;
            ucCodeBox1.ImeMode = ImeMode.NoControl;
            ucCodeBox1.Location = new Point(5, 46);
            ucCodeBox1.Name = "ucCodeBox1";
            ucCodeBox1.Size = new Size(200, 20);
            ucCodeBox1.TabIndex = 0;
            ucCodeBox1.Text = "ucCodeBox1";
            ucCodeBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox1.Title = "Search";
            ucCodeBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            ucCodeBox1.TitleWidth = 100;
            // 
            // ucGridSet1
            // 
            ucGridSet1.Dock = DockStyle.Fill;
            ucGridSet1.Location = new Point(0, 0);
            ucGridSet1.Name = "ucGridSet1";
            ucGridSet1.Size = new Size(800, 328);
            ucGridSet1.TabIndex = 0;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "UserControl1";
            Size = new Size(800, 450);
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
        private EpicV004.Ctrls.UCCodeBox ucCodeBox1;
        private EpicV004.Ctrls.UCGridSet ucGridSet1;
    }
}
