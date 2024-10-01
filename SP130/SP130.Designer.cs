namespace EpicV004.Frms
{
    partial class SP130
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
            g10 = new Ctrls.UCGridSet();
            ucSplit1 = new Ctrls.UCSplit();
            ucPanel1 = new Ctrls.UCPanel();
            s_status = new Ctrls.UCChkCodeBox();
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
            s_project = new Ctrls.UCTextBox();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1357, 692);
            g10.TabIndex = 0;
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
            ucSplit1.Panel2.Controls.Add(g10);
            ucSplit1.Size = new Size(1357, 780);
            ucSplit1.SplitterDistance = 84;
            ucSplit1.TabIndex = 1;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_status);
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Controls.Add(s_project);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1357, 84);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // s_status
            // 
            s_status.ControlHeight = 21;
            s_status.ControlWidth = 248;
            s_status.FontFace = "Tahoma";
            s_status.FontSize = 9F;
            s_status.Location = new Point(261, 53);
            s_status.Name = "s_status";
            s_status.Size = new Size(248, 21);
            s_status.TabIndex = 16;
            s_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_status.Title = "Status";
            s_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_status.TitleWidth = 100;
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 250;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(5, 53);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(250, 21);
            to_dt.TabIndex = 11;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 94;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 250;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 26);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(250, 21);
            fr_dt.TabIndex = 12;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 94;
            // 
            // s_project
            // 
            s_project.ControlHeight = 21;
            s_project.ControlWidth = 248;
            s_project.FontColor = Color.Black;
            s_project.FontFace = "Tahoma";
            s_project.FontSize = 9F;
            s_project.FormatStr = "";
            s_project.Location = new Point(261, 26);
            s_project.Name = "s_project";
            s_project.Size = new Size(248, 21);
            s_project.TabIndex = 15;
            s_project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.Title = "Project";
            s_project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.TitleWidth = 100;
            // 
            // SP130
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SP130";
            Size = new Size(1357, 780);
            Load += SP130_Load;
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCGridSet g10;
        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCCodeBox s_class_bc;
        private Ctrls.UCCodeBox s_category;
        private Ctrls.UCTextBox project_name;
        private Ctrls.UCTextBox s_project;
        private Ctrls.UCDateBox to_dt;
        private Ctrls.UCDateBox fr_dt;
        private Ctrls.UCChkCodeBox s_status;
    }
}
