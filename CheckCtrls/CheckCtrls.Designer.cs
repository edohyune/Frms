namespace EpicV004.Frms
{
    partial class CheckCtrls
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
            ucTextBox1 = new Ctrls.UCTextBox();
            ucTextBox2 = new Ctrls.UCTextBox();
            ucSplit1 = new Ctrls.UCSplit();
            u1GridSet1 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            SuspendLayout();
            // 
            // ucTextBox1
            // 
            ucTextBox1.ButtonVisiable = false;
            ucTextBox1.ControlHeight = 20;
            ucTextBox1.ControlWidth = 200;
            ucTextBox1.FontColor = Color.FromArgb(40, 40, 40);
            ucTextBox1.FontFace = "Tahoma";
            ucTextBox1.FontSize = 9F;
            ucTextBox1.FormatStr = "";
            ucTextBox1.Location = new Point(22, 10);
            ucTextBox1.Name = "ucTextBox1";
            ucTextBox1.Size = new Size(200, 20);
            ucTextBox1.TabIndex = 0;
            ucTextBox1.Text = "<$gRegId>";
            ucTextBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox1.Title = "User Id";
            ucTextBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            ucTextBox1.TitleWidth = 80;
            // 
            // ucTextBox2
            // 
            ucTextBox2.ButtonVisiable = false;
            ucTextBox2.ControlHeight = 20;
            ucTextBox2.ControlWidth = 200;
            ucTextBox2.FontColor = Color.FromArgb(40, 40, 40);
            ucTextBox2.FontFace = "Tahoma";
            ucTextBox2.FontSize = 9F;
            ucTextBox2.FormatStr = "";
            ucTextBox2.Location = new Point(228, 10);
            ucTextBox2.Name = "ucTextBox2";
            ucTextBox2.Size = new Size(200, 20);
            ucTextBox2.TabIndex = 1;
            ucTextBox2.Text = "<$gFrameWorkId>";
            ucTextBox2.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox2.Title = "FrameWork#";
            ucTextBox2.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            ucTextBox2.TitleWidth = 80;
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
            ucSplit1.Panel1.Controls.Add(ucTextBox2);
            ucSplit1.Panel1.Controls.Add(ucTextBox1);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(u1GridSet1);
            ucSplit1.Size = new Size(800, 450);
            ucSplit1.SplitterDistance = 37;
            ucSplit1.TabIndex = 2;
            ucSplit1.TitleWidth = 121;
            // 
            // u1GridSet1
            // 
            u1GridSet1.Dock = DockStyle.Fill;
            u1GridSet1.Location = new Point(0, 0);
            u1GridSet1.Name = "u1GridSet1";
            u1GridSet1.Size = new Size(800, 409);
            u1GridSet1.TabIndex = 0;
            // 
            // CheckCtrls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "CheckCtrls";
            Size = new Size(800, 450);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private EpicV004.Ctrls.UCTextBox ucTextBox1;
        private Ctrls.UCTextBox ucTextBox2;
        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCGridSet u1GridSet1;
    }
}
