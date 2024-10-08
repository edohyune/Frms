﻿namespace EPIC01
{
    partial class EPIC01
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
            ucTextBox1 = new EpicV004.Ctrls.UCTextBox();
            ucPanel2 = new EpicV004.Ctrls.UCPanel();
            ucGridSet1 = new EpicV004.Ctrls.UCGridSet();
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
            ucSplit1.Size = new Size(800, 450);
            ucSplit1.SplitterDistance = 79;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(ucTextBox1);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(800, 79);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "ucPanel1";
            // 
            // ucTextBox1
            // 
            ucTextBox1.ButtonVisiable = false;
            ucTextBox1.ControlHeight = 21;
            ucTextBox1.ControlWidth = 200;
            ucTextBox1.FontColor = Color.Black;
            ucTextBox1.FontFace = "Tahoma";
            ucTextBox1.FontSize = 9F;
            ucTextBox1.FormatStr = "";
            ucTextBox1.Location = new Point(3, 35);
            ucTextBox1.Name = "ucTextBox1";
            ucTextBox1.Size = new Size(200, 21);
            ucTextBox1.TabIndex = 0;
            ucTextBox1.Text = "ucTextBox1";
            ucTextBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox1.Title = "UCTextBox";
            ucTextBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox1.TitleWidth = 100;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(ucGridSet1);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(800, 367);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "ucPanel2";
            // 
            // ucGridSet1
            // 
            ucGridSet1.Dock = DockStyle.Fill;
            ucGridSet1.Location = new Point(2, 23);
            ucGridSet1.Name = "ucGridSet1";
            ucGridSet1.Size = new Size(796, 342);
            ucGridSet1.TabIndex = 0;
            // 
            // EPIC01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "EPIC01";
            Size = new Size(800, 450);
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

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCTextBox ucTextBox1;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private EpicV004.Ctrls.UCGridSet ucGridSet1;
    }
}
