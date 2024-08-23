namespace EpicV004.Frms
{
    partial class HS600
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
            deleted = new Ctrls.UCCodeBox();
            active = new Ctrls.UCCodeBox();
            id_no = new Ctrls.UCTextBox();
            g10 = new Ctrls.UCGridSet();
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
            ucSplit1.Size = new Size(1131, 589);
            ucSplit1.SplitterDistance = 55;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(deleted);
            ucPanel1.Controls.Add(active);
            ucPanel1.Controls.Add(id_no);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1131, 55);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // deleted
            // 
            deleted.ControlHeight = 21;
            deleted.ControlWidth = 167;
            deleted.FldTy = null;
            deleted.FontColor = Color.Black;
            deleted.FontFace = "Tahoma";
            deleted.FontSize = 9F;
            deleted.Location = new Point(423, 28);
            deleted.Name = "deleted";
            deleted.Size = new Size(167, 21);
            deleted.TabIndex = 2;
            deleted.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            deleted.Title = "Deleted";
            deleted.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            deleted.TitleWidth = 50;
            // 
            // active
            // 
            active.ControlHeight = 21;
            active.ControlWidth = 166;
            active.FldTy = null;
            active.FontColor = Color.Black;
            active.FontFace = "Tahoma";
            active.FontSize = 9F;
            active.Location = new Point(251, 28);
            active.Name = "active";
            active.Size = new Size(166, 21);
            active.TabIndex = 1;
            active.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            active.Title = "Active";
            active.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            active.TitleWidth = 50;
            // 
            // id_no
            // 
            id_no.ControlHeight = 21;
            id_no.ControlWidth = 235;
            id_no.FontColor = Color.Black;
            id_no.FontFace = "Tahoma";
            id_no.FontSize = 9F;
            id_no.FormatStr = "";
            id_no.Location = new Point(5, 28);
            id_no.Name = "id_no";
            id_no.Size = new Size(235, 21);
            id_no.TabIndex = 0;
            id_no.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            id_no.Title = "ID No";
            id_no.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            id_no.TitleWidth = 50;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(1131, 530);
            g10.TabIndex = 0;
            // 
            // HS600
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HS600";
            Size = new Size(1131, 589);
            Load += HS600_Load;
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
        private Ctrls.UCCodeBox deleted;
        private Ctrls.UCCodeBox active;
        private Ctrls.UCTextBox id_no;
        private Ctrls.UCGridSet g10;
    }
}
