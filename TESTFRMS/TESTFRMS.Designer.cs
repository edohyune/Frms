namespace EpicV004.Frms
{
    partial class TESTFRMS
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
            ucSplit2 = new Ctrls.UCSplit();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel1 = new Ctrls.UCPanel();
            ucPanel2 = new Ctrls.UCPanel();
            ucPanel3 = new Ctrls.UCPanel();
            ucPanel4 = new Ctrls.UCPanel();
            g10 = new Ctrls.UCGridSet();
            g20 = new Ctrls.UCGridSet();
            id = new Ctrls.UCTextBox();
            first_name = new Ctrls.UCTextBox();
            last_name = new Ctrls.UCTextBox();
            addr = new Ctrls.UCTextBox();
            s_txt = new Ctrls.UCTextBox();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit2).BeginInit();
            ucSplit2.Panel1.SuspendLayout();
            ucSplit2.Panel2.SuspendLayout();
            ucSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit3).BeginInit();
            ucSplit3.Panel1.SuspendLayout();
            ucSplit3.Panel2.SuspendLayout();
            ucSplit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel2).BeginInit();
            ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel3).BeginInit();
            ucPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel4).BeginInit();
            ucPanel4.SuspendLayout();
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
            ucSplit1.Panel2.Controls.Add(ucSplit2);
            ucSplit1.Size = new Size(1033, 603);
            ucSplit1.SplitterDistance = 89;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(ucPanel2);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(ucSplit3);
            ucSplit2.Size = new Size(1033, 510);
            ucSplit2.SplitterDistance = 344;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucSplit3
            // 
            ucSplit3.Dock = DockStyle.Fill;
            ucSplit3.FixedPanel = FixedPanel.Panel1;
            ucSplit3.Location = new Point(0, 0);
            ucSplit3.Name = "ucSplit3";
            ucSplit3.Orientation = Orientation.Horizontal;
            // 
            // ucSplit3.Panel1
            // 
            ucSplit3.Panel1.Controls.Add(ucPanel3);
            // 
            // ucSplit3.Panel2
            // 
            ucSplit3.Panel2.Controls.Add(ucPanel4);
            ucSplit3.Size = new Size(685, 510);
            ucSplit3.SplitterDistance = 156;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_txt);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1033, 89);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "ucPanel1";
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(g10);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(344, 510);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "ucPanel2";
            // 
            // ucPanel3
            // 
            ucPanel3.Controls.Add(addr);
            ucPanel3.Controls.Add(last_name);
            ucPanel3.Controls.Add(first_name);
            ucPanel3.Controls.Add(id);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(0, 0);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(685, 156);
            ucPanel3.TabIndex = 1;
            ucPanel3.Text = "ucPanel3";
            // 
            // ucPanel4
            // 
            ucPanel4.Controls.Add(g20);
            ucPanel4.Dock = DockStyle.Fill;
            ucPanel4.Location = new Point(0, 0);
            ucPanel4.Name = "ucPanel4";
            ucPanel4.Size = new Size(685, 350);
            ucPanel4.TabIndex = 1;
            ucPanel4.Text = "ucPanel3";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(340, 485);
            g10.TabIndex = 0;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(2, 23);
            g20.Name = "g20";
            g20.Size = new Size(681, 325);
            g20.TabIndex = 0;
            // 
            // id
            // 
            id.ButtonVisiable = false;
            id.ControlHeight = 21;
            id.ControlWidth = 541;
            id.FontColor = Color.Black;
            id.FontFace = "Tahoma";
            id.FontSize = 9F;
            id.FormatStr = "";
            id.Location = new Point(5, 26);
            id.Name = "id";
            id.Size = new Size(541, 21);
            id.TabIndex = 0;
            id.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            id.Title = "ID";
            id.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            id.TitleWidth = 100;
            // 
            // first_name
            // 
            first_name.ButtonVisiable = false;
            first_name.ControlHeight = 21;
            first_name.ControlWidth = 541;
            first_name.FontColor = Color.Black;
            first_name.FontFace = "Tahoma";
            first_name.FontSize = 9F;
            first_name.FormatStr = "";
            first_name.Location = new Point(5, 53);
            first_name.Name = "first_name";
            first_name.Size = new Size(541, 21);
            first_name.TabIndex = 1;
            first_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            first_name.Title = "First Name";
            first_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            first_name.TitleWidth = 100;
            // 
            // last_name
            // 
            last_name.ButtonVisiable = false;
            last_name.ControlHeight = 21;
            last_name.ControlWidth = 541;
            last_name.FontColor = Color.Black;
            last_name.FontFace = "Tahoma";
            last_name.FontSize = 9F;
            last_name.FormatStr = "";
            last_name.Location = new Point(5, 80);
            last_name.Name = "last_name";
            last_name.Size = new Size(541, 21);
            last_name.TabIndex = 2;
            last_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            last_name.Title = "Last Name";
            last_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            last_name.TitleWidth = 100;
            // 
            // addr
            // 
            addr.ButtonVisiable = false;
            addr.ControlHeight = 21;
            addr.ControlWidth = 541;
            addr.FontColor = Color.Black;
            addr.FontFace = "Tahoma";
            addr.FontSize = 9F;
            addr.FormatStr = "";
            addr.Location = new Point(5, 107);
            addr.Name = "addr";
            addr.Size = new Size(541, 21);
            addr.TabIndex = 3;
            addr.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            addr.Title = "Address";
            addr.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            addr.TitleWidth = 100;
            // 
            // s_txt
            // 
            s_txt.ButtonVisiable = false;
            s_txt.ControlHeight = 21;
            s_txt.ControlWidth = 368;
            s_txt.FontColor = Color.Black;
            s_txt.FontFace = "Tahoma";
            s_txt.FontSize = 9F;
            s_txt.FormatStr = "";
            s_txt.Location = new Point(5, 39);
            s_txt.Name = "s_txt";
            s_txt.Size = new Size(368, 21);
            s_txt.TabIndex = 0;
            s_txt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_txt.Title = "Search";
            s_txt.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_txt.TitleWidth = 100;
            // 
            // TESTFRMS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "TESTFRMS";
            Size = new Size(1033, 603);
            Load += UserControl1_Load;
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ucSplit2.Panel1.ResumeLayout(false);
            ucSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit2).EndInit();
            ucSplit2.ResumeLayout(false);
            ucSplit3.Panel1.ResumeLayout(false);
            ucSplit3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit3).EndInit();
            ucSplit3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel3).EndInit();
            ucPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel4).EndInit();
            ucPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCTextBox s_txt;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCPanel ucPanel3;
        private Ctrls.UCTextBox addr;
        private Ctrls.UCTextBox last_name;
        private Ctrls.UCTextBox first_name;
        private Ctrls.UCTextBox id;
        private Ctrls.UCPanel ucPanel4;
        private Ctrls.UCGridSet g20;
    }
}
