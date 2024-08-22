﻿namespace EpicV004.Frms
{
    partial class HR470
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
            btn_copy = new Ctrls.UCButton();
            f_to_year = new Ctrls.UCDateBox();
            f_year = new Ctrls.UCDateBox();
            ucSplit2 = new Ctrls.UCSplit();
            g10 = new Ctrls.UCPanel();
            g20 = new Ctrls.UCPanel();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit2).BeginInit();
            ucSplit2.Panel1.SuspendLayout();
            ucSplit2.Panel2.SuspendLayout();
            ucSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)g10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)g20).BeginInit();
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
            ucSplit1.Panel2.Controls.Add(ucSplit2);
            ucSplit1.Size = new Size(1284, 671);
            ucSplit1.SplitterDistance = 70;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(btn_copy);
            ucPanel1.Controls.Add(f_to_year);
            ucPanel1.Controls.Add(f_year);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(1284, 70);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // btn_copy
            // 
            btn_copy.Appearance.Font = new Font("Tahoma", 9F);
            btn_copy.Appearance.Options.UseFont = true;
            btn_copy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_copy.ControlHeight = 33;
            btn_copy.ControlWidth = 123;
            btn_copy.FontBold = FontStyle.Regular;
            btn_copy.FontFace = "Tahoma";
            btn_copy.FontSize = 9F;
            btn_copy.Location = new Point(579, 32);
            btn_copy.Name = "btn_copy";
            btn_copy.Size = new Size(123, 33);
            btn_copy.TabIndex = 1;
            btn_copy.Title = "Copy";
            btn_copy.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // f_to_year
            // 
            f_to_year.ControlHeight = 19;
            f_to_year.ControlWidth = 186;
            f_to_year.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_to_year.FontColor = Color.Black;
            f_to_year.FontFace = "Tahoma";
            f_to_year.FontSize = 9F;
            f_to_year.FormatStr = "";
            f_to_year.Location = new Point(238, 40);
            f_to_year.Name = "f_to_year";
            f_to_year.Size = new Size(186, 19);
            f_to_year.TabIndex = 0;
            f_to_year.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_to_year.Title = ">";
            f_to_year.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_to_year.TitleWidth = 50;
            // 
            // f_year
            // 
            f_year.ControlHeight = 19;
            f_year.ControlWidth = 186;
            f_year.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_year.FontColor = Color.Black;
            f_year.FontFace = "Tahoma";
            f_year.FontSize = 9F;
            f_year.FormatStr = "";
            f_year.Location = new Point(5, 40);
            f_year.Name = "f_year";
            f_year.Size = new Size(186, 19);
            f_year.TabIndex = 0;
            f_year.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_year.Title = "Year";
            f_year.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_year.TitleWidth = 50;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.FixedPanel = FixedPanel.Panel1;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(g10);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(g20);
            ucSplit2.Size = new Size(1284, 597);
            ucSplit2.SplitterDistance = 643;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(643, 597);
            g10.TabIndex = 0;
            g10.Text = "From";
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(637, 597);
            g20.TabIndex = 0;
            g20.Text = "To (Edit)";
            // 
            // HR470
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR470";
            Size = new Size(1284, 671);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ucSplit2.Panel1.ResumeLayout(false);
            ucSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit2).EndInit();
            ucSplit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)g10).EndInit();
            ((System.ComponentModel.ISupportInitialize)g20).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private EpicV004.Ctrls.UCSplit ucSplit1;
        private EpicV004.Ctrls.UCPanel ucPanel1;
        private EpicV004.Ctrls.UCButton btn_copy;
        private EpicV004.Ctrls.UCDateBox f_to_year;
        private EpicV004.Ctrls.UCDateBox f_year;
        private EpicV004.Ctrls.UCSplit ucSplit2;
        private EpicV004.Ctrls.UCPanel g10;
        private EpicV004.Ctrls.UCPanel g20;
    }
}