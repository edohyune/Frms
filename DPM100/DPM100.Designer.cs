namespace EpicV004.Frms
{
    partial class DPM100
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
            ucPanel2 = new EpicV004.Ctrls.UCPanel();
            department_code = new EpicV004.Ctrls.UCTextBox();
            department_name = new EpicV004.Ctrls.UCTextBox();
            g10 = new EpicV004.Ctrls.UCGridSet();
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
            ucSplit1.SplitterDistance = 110;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(department_name);
            ucPanel1.Controls.Add(department_code);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(800, 110);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "ucPanel1";
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(g10);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(800, 336);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "ucPanel2";
            // 
            // department_code
            // 
            department_code.ButtonVisiable = false;
            department_code.ControlHeight = 26;
            department_code.ControlWidth = 325;
            department_code.FontColor = Color.Black;
            department_code.FontFace = "Tahoma";
            department_code.FontSize = 9F;
            department_code.FormatStr = "";
            department_code.Location = new Point(16, 55);
            department_code.Margin = new Padding(4, 3, 4, 3);
            department_code.Name = "department_code";
            department_code.Size = new Size(325, 26);
            department_code.TabIndex = 0;
            department_code.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            department_code.Title = "Department Code";
            department_code.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            department_code.TitleWidth = 120;
            // 
            // department_name
            // 
            department_name.ButtonVisiable = false;
            department_name.ControlHeight = 26;
            department_name.ControlWidth = 325;
            department_name.FontColor = Color.Black;
            department_name.FontFace = "Tahoma";
            department_name.FontSize = 9F;
            department_name.FormatStr = "";
            department_name.Location = new Point(358, 55);
            department_name.Margin = new Padding(4, 3, 4, 3);
            department_name.Name = "department_name";
            department_name.Size = new Size(325, 26);
            department_name.TabIndex = 1;
            department_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            department_name.Title = "Department Name";
            department_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            department_name.TitleWidth = 140;
            //department_name.UCEditValueChanged += this.ucTextBox1_UCEditValueChanged;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 28);
            g10.Margin = new Padding(3, 4, 3, 4);
            g10.Name = "g10";
            g10.Size = new Size(796, 306);
            g10.TabIndex = 0;
            // 
            // DPM100
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "DPM100";
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
        private EpicV004.Ctrls.UCTextBox department_code;
        private EpicV004.Ctrls.UCPanel ucPanel2;
        private EpicV004.Ctrls.UCTextBox department_name;
        private EpicV004.Ctrls.UCGridSet g10;
    }
}
