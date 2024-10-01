namespace EpicV004.Frms
{
    partial class SP110
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
            s_class_bc = new Ctrls.UCCodeBox();
            s_category = new Ctrls.UCCodeBox();
            project_name = new Ctrls.UCTextBox();
            project_manager = new Ctrls.UCTextBox();
            s_project = new Ctrls.UCTextBox();
            g10 = new Ctrls.UCGridSet();
            s_status = new Ctrls.UCChkCodeBox();
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
            ucSplit1.Size = new Size(1137, 712);
            ucSplit1.SplitterDistance = 80;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_status);
            ucPanel1.Controls.Add(s_class_bc);
            ucPanel1.Controls.Add(s_category);
            ucPanel1.Controls.Add(project_name);
            ucPanel1.Controls.Add(project_manager);
            ucPanel1.Controls.Add(s_project);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1137, 80);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // s_class_bc
            // 
            s_class_bc.ControlHeight = 21;
            s_class_bc.ControlWidth = 248;
            s_class_bc.FldTy = null;
            s_class_bc.FontColor = Color.Black;
            s_class_bc.FontFace = "Tahoma";
            s_class_bc.FontSize = 9F;
            s_class_bc.Location = new Point(3, 53);
            s_class_bc.Name = "s_class_bc";
            s_class_bc.Size = new Size(248, 21);
            s_class_bc.TabIndex = 41;
            s_class_bc.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_class_bc.Title = "Class";
            s_class_bc.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_class_bc.TitleWidth = 100;
            // 
            // s_category
            // 
            s_category.ControlHeight = 21;
            s_category.ControlWidth = 248;
            s_category.FldTy = null;
            s_category.FontColor = Color.Black;
            s_category.FontFace = "Tahoma";
            s_category.FontSize = 9F;
            s_category.Location = new Point(3, 26);
            s_category.Name = "s_category";
            s_category.Size = new Size(248, 21);
            s_category.TabIndex = 41;
            s_category.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_category.Title = "Category";
            s_category.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_category.TitleWidth = 100;
            // 
            // project_name
            // 
            project_name.ControlHeight = 21;
            project_name.ControlWidth = 248;
            project_name.FontColor = Color.Black;
            project_name.FontFace = "Tahoma";
            project_name.FontSize = 9F;
            project_name.FormatStr = "";
            project_name.Location = new Point(511, 53);
            project_name.Name = "project_name";
            project_name.Size = new Size(248, 21);
            project_name.TabIndex = 15;
            project_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_name.Title = "Project Name";
            project_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_name.TitleWidth = 100;
            // 
            // project_manager
            // 
            project_manager.ControlHeight = 21;
            project_manager.ControlWidth = 248;
            project_manager.FontColor = Color.Black;
            project_manager.FontFace = "Tahoma";
            project_manager.FontSize = 9F;
            project_manager.FormatStr = "";
            project_manager.Location = new Point(511, 26);
            project_manager.Name = "project_manager";
            project_manager.Size = new Size(248, 21);
            project_manager.TabIndex = 15;
            project_manager.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_manager.Title = "Project Manager";
            project_manager.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            project_manager.TitleWidth = 100;
            // 
            // s_project
            // 
            s_project.ControlHeight = 21;
            s_project.ControlWidth = 248;
            s_project.FontColor = Color.Black;
            s_project.FontFace = "Tahoma";
            s_project.FontSize = 9F;
            s_project.FormatStr = "";
            s_project.Location = new Point(257, 26);
            s_project.Name = "s_project";
            s_project.Size = new Size(248, 21);
            s_project.TabIndex = 15;
            s_project.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.Title = "Project";
            s_project.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_project.TitleWidth = 100;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1137, 628);
            g10.TabIndex = 0;
            // 
            // s_status
            // 
            s_status.ControlHeight = 21;
            s_status.ControlWidth = 250;
            s_status.FontFace = "Tahoma";
            s_status.FontSize = 9F;
            s_status.Location = new Point(255, 53);
            s_status.Name = "s_status";
            s_status.Size = new Size(250, 21);
            s_status.TabIndex = 42;
            s_status.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_status.Title = "Status";
            s_status.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            s_status.TitleWidth = 100;
            // 
            // SP110
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SP110";
            Size = new Size(1137, 712);
            Load += SP110_Load;
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCTextBox s_project;
        private Ctrls.UCCodeBox s_class_bc;
        private Ctrls.UCCodeBox s_category;
        private Ctrls.UCTextBox project_name;
        private Ctrls.UCTextBox project_manager;
        private Ctrls.UCChkCodeBox s_status;
    }
}
