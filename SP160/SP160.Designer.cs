namespace EpicV004.Frms
{
    partial class SP160
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
            s_wh = new Ctrls.UCChkCodeBox();
            to_dt = new Ctrls.UCDateBox();
            fr_dt = new Ctrls.UCDateBox();
            s_item = new Ctrls.UCTextBox();
            f_project = new Ctrls.UCTextBox();
            f_dept = new Ctrls.UCTextBox();
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
            g10.Size = new Size(1206, 635);
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
            ucSplit1.Size = new Size(1206, 704);
            ucSplit1.SplitterDistance = 65;
            ucSplit1.TabIndex = 3;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_wh);
            ucPanel1.Controls.Add(to_dt);
            ucPanel1.Controls.Add(fr_dt);
            ucPanel1.Controls.Add(f_dept);
            ucPanel1.Controls.Add(f_project);
            ucPanel1.Controls.Add(s_item);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1206, 65);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // s_wh
            // 
            s_wh.ControlHeight = 21;
            s_wh.ControlWidth = 185;
            s_wh.FontFace = "Tahoma";
            s_wh.FontSize = 9F;
            s_wh.Location = new Point(961, 32);
            s_wh.Name = "s_wh";
            s_wh.Size = new Size(185, 21);
            s_wh.TabIndex = 16;
            s_wh.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_wh.Title = "WH";
            s_wh.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_wh.TitleWidth = 80;
            // 
            // to_dt
            // 
            to_dt.ControlHeight = 21;
            to_dt.ControlWidth = 185;
            to_dt.FontColor = Color.Black;
            to_dt.FontFace = "Tahoma";
            to_dt.FontSize = 9F;
            to_dt.FormatStr = "";
            to_dt.Location = new Point(197, 32);
            to_dt.Name = "to_dt";
            to_dt.Size = new Size(185, 21);
            to_dt.TabIndex = 11;
            to_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.Title = "~";
            to_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            to_dt.TitleWidth = 80;
            // 
            // fr_dt
            // 
            fr_dt.ControlHeight = 21;
            fr_dt.ControlWidth = 186;
            fr_dt.FontColor = Color.Black;
            fr_dt.FontFace = "Tahoma";
            fr_dt.FontSize = 9F;
            fr_dt.FormatStr = "";
            fr_dt.Location = new Point(5, 32);
            fr_dt.Name = "fr_dt";
            fr_dt.Size = new Size(186, 21);
            fr_dt.TabIndex = 12;
            fr_dt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.Title = "Date";
            fr_dt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            fr_dt.TitleWidth = 80;
            // 
            // s_item
            // 
            s_item.ControlHeight = 21;
            s_item.ControlWidth = 185;
            s_item.FontColor = Color.Black;
            s_item.FontFace = "Tahoma";
            s_item.FontSize = 9F;
            s_item.FormatStr = "";
            s_item.Location = new Point(388, 32);
            s_item.Name = "s_item";
            s_item.Size = new Size(185, 21);
            s_item.TabIndex = 15;
            s_item.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_item.Title = "Item";
            s_item.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_item.TitleWidth = 80;
            // 
            // f_project
            // 
            f_project.ControlHeight = 21;
            f_project.ControlWidth = 185;
            f_project.FontColor = Color.Black;
            f_project.FontFace = "Tahoma";
            f_project.FontSize = 9F;
            f_project.FormatStr = "";
            f_project.Location = new Point(579, 32);
            f_project.Name = "f_project";
            f_project.Size = new Size(185, 21);
            f_project.TabIndex = 15;
            f_project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project.Title = "Project";
            f_project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_project.TitleWidth = 80;
            // 
            // f_dept
            // 
            f_dept.ControlHeight = 21;
            f_dept.ControlWidth = 185;
            f_dept.FontColor = Color.Black;
            f_dept.FontFace = "Tahoma";
            f_dept.FontSize = 9F;
            f_dept.FormatStr = "";
            f_dept.Location = new Point(770, 32);
            f_dept.Name = "f_dept";
            f_dept.Size = new Size(185, 21);
            f_dept.TabIndex = 15;
            f_dept.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_dept.Title = "Dept";
            f_dept.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_dept.TitleWidth = 80;
            // 
            // SP160
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SP160";
            Size = new Size(1206, 704);
            Load += SP160_Load;
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
        private Ctrls.UCChkCodeBox s_status;
        private Ctrls.UCChkCodeBox s_wh;
        private Ctrls.UCDateBox to_dt;
        private Ctrls.UCDateBox fr_dt;
        private Ctrls.UCTextBox ucTextBox2;
        private Ctrls.UCTextBox ucTextBox1;
        private Ctrls.UCTextBox s_item;
        private Ctrls.UCTextBox f_dept;
        private Ctrls.UCTextBox f_project;
    }
}
