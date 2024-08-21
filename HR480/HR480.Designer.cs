namespace EpicV004.Frms
{
    partial class HR480
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
            stt_type = new Ctrls.UCChkCodeBox();
            stt_enabled = new Ctrls.UCTextBox();
            stt_key = new Ctrls.UCTextBox();
            ucPanel2 = new Ctrls.UCPanel();
            g10 = new Ctrls.UCGridSet();
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
            ucSplit1.Panel2.Controls.Add(ucPanel2);
            ucSplit1.Size = new Size(1317, 684);
            ucSplit1.SplitterDistance = 74;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(stt_type);
            ucPanel1.Controls.Add(stt_enabled);
            ucPanel1.Controls.Add(stt_key);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1317, 74);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Condition";
            // 
            // stt_type
            // 
            stt_type.ControlHeight = 18;
            stt_type.ControlWidth = 271;
            stt_type.FontFace = "Tahoma";
            stt_type.FontSize = 9F;
            stt_type.Location = new Point(282, 36);
            stt_type.Name = "stt_type";
            stt_type.Size = new Size(271, 18);
            stt_type.TabIndex = 1;
            stt_type.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            stt_type.Title = "Stt Type";
            stt_type.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            stt_type.TitleWidth = 100;
            // 
            // stt_enabled
            // 
            stt_enabled.ControlHeight = 18;
            stt_enabled.ControlWidth = 271;
            stt_enabled.FontColor = Color.Black;
            stt_enabled.FontFace = "Tahoma";
            stt_enabled.FontSize = 9F;
            stt_enabled.FormatStr = "";
            stt_enabled.Location = new Point(559, 36);
            stt_enabled.Name = "stt_enabled";
            stt_enabled.Size = new Size(271, 18);
            stt_enabled.TabIndex = 0;
            stt_enabled.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            stt_enabled.Title = "Enabled";
            stt_enabled.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            stt_enabled.TitleWidth = 100;
            // 
            // stt_key
            // 
            stt_key.ControlHeight = 18;
            stt_key.ControlWidth = 271;
            stt_key.FontColor = Color.Black;
            stt_key.FontFace = "Tahoma";
            stt_key.FontSize = 9F;
            stt_key.FormatStr = "";
            stt_key.Location = new Point(5, 36);
            stt_key.Name = "stt_key";
            stt_key.Size = new Size(271, 18);
            stt_key.TabIndex = 0;
            stt_key.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            stt_key.Title = "Sttkey";
            stt_key.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            stt_key.TitleWidth = 100;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(g10);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(1317, 606);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "HA710";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(2, 23);
            g10.Name = "g10";
            g10.Size = new Size(1313, 581);
            g10.TabIndex = 0;
            // 
            // HR480
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR480";
            Size = new Size(1317, 684);
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

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCChkCodeBox stt_type;
        private Ctrls.UCTextBox stt_enabled;
        private Ctrls.UCTextBox stt_key;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCGridSet g10;
    }
}
