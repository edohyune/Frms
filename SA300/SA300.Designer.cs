namespace EpicV004.Frms
{
    partial class SA300
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
            ucPanel1 = new Ctrls.UCPanel();
            f_yn_delete = new Ctrls.UCChkCodeBox();
            f_temp_cd = new Ctrls.UCTextBox();
            f_category = new Ctrls.UCCodeBox();
            g10 = new Ctrls.UCGridSet();
            ucSplit3 = new Ctrls.UCSplit();
            ucPanel2 = new Ctrls.UCPanel();
            memo = new Ctrls.UCRichText();
            yn_deleted = new Ctrls.UCCheckBox();
            temp_name = new Ctrls.UCTextBox();
            category = new Ctrls.UCCodeBox();
            temp_cd = new Ctrls.UCTextBox();
            g20 = new Ctrls.UCGridSet();
            ((System.ComponentModel.ISupportInitialize)ucSplit1).BeginInit();
            ucSplit1.Panel1.SuspendLayout();
            ucSplit1.Panel2.SuspendLayout();
            ucSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit2).BeginInit();
            ucSplit2.Panel1.SuspendLayout();
            ucSplit2.Panel2.SuspendLayout();
            ucSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucPanel1).BeginInit();
            ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucSplit3).BeginInit();
            ucSplit3.Panel1.SuspendLayout();
            ucSplit3.Panel2.SuspendLayout();
            ucSplit3.SuspendLayout();
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
            // 
            // ucSplit1.Panel1
            // 
            ucSplit1.Panel1.Controls.Add(ucSplit2);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucSplit3);
            ucSplit1.Size = new Size(1316, 844);
            ucSplit1.SplitterDistance = 345;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.FixedPanel = FixedPanel.Panel1;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            ucSplit2.Orientation = Orientation.Horizontal;
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(g10);
            ucSplit2.Size = new Size(345, 844);
            ucSplit2.SplitterDistance = 136;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(f_yn_delete);
            ucPanel1.Controls.Add(f_temp_cd);
            ucPanel1.Controls.Add(f_category);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(345, 136);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // f_yn_delete
            // 
            f_yn_delete.Appearance.Font = new Font("Tahoma", 9F);
            f_yn_delete.Appearance.Options.UseFont = true;
            f_yn_delete.ControlHeight = 21;
            f_yn_delete.ControlWidth = 228;
            f_yn_delete.FontFace = "Tahoma";
            f_yn_delete.FontSize = 9F;
            f_yn_delete.Location = new Point(5, 80);
            f_yn_delete.Name = "f_yn_delete";
            f_yn_delete.Size = new Size(228, 21);
            f_yn_delete.TabIndex = 2;
            f_yn_delete.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_yn_delete.Title = "Deleted";
            f_yn_delete.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            f_yn_delete.TitleWidth = 100;
            // 
            // f_temp_cd
            // 
            f_temp_cd.Appearance.Font = new Font("Tahoma", 9F);
            f_temp_cd.Appearance.Options.UseFont = true;
            f_temp_cd.ControlHeight = 21;
            f_temp_cd.ControlWidth = 228;
            f_temp_cd.FontColor = Color.Black;
            f_temp_cd.FontFace = "Tahoma";
            f_temp_cd.FontSize = 9F;
            f_temp_cd.FormatStr = "";
            f_temp_cd.Location = new Point(5, 53);
            f_temp_cd.Name = "f_temp_cd";
            f_temp_cd.Size = new Size(228, 21);
            f_temp_cd.TabIndex = 1;
            f_temp_cd.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_temp_cd.Title = "Template";
            f_temp_cd.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_temp_cd.TitleWidth = 100;
            // 
            // f_category
            // 
            f_category.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f_category.Appearance.Options.UseFont = true;
            f_category.ControlHeight = 21;
            f_category.ControlWidth = 228;
            f_category.FldTy = null;
            f_category.FontColor = Color.Black;
            f_category.FontFace = "Tahoma";
            f_category.FontSize = 9F;
            f_category.Location = new Point(5, 26);
            f_category.Name = "f_category";
            f_category.Size = new Size(228, 21);
            f_category.TabIndex = 0;
            f_category.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_category.Title = "Category";
            f_category.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            f_category.TitleWidth = 100;
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(345, 704);
            g10.TabIndex = 0;
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
            ucSplit3.Panel1.Controls.Add(ucPanel2);
            // 
            // ucSplit3.Panel2
            // 
            ucSplit3.Panel2.Controls.Add(g20);
            ucSplit3.Size = new Size(967, 844);
            ucSplit3.SplitterDistance = 135;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(memo);
            ucPanel2.Controls.Add(yn_deleted);
            ucPanel2.Controls.Add(temp_name);
            ucPanel2.Controls.Add(category);
            ucPanel2.Controls.Add(temp_cd);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(967, 135);
            ucPanel2.TabIndex = 1;
            ucPanel2.Text = "Template Info";
            // 
            // memo
            // 
            memo.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            memo.Appearance.Text.Font = new Font("Cascadia Code Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memo.Appearance.Text.Options.UseFont = true;
            memo.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            memo.Location = new Point(122, 80);
            memo.Modified = true;
            memo.Name = "memo";
            memo.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            memo.Options.DocumentSaveOptions.DefaultFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            memo.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            memo.Options.Search.RegExResultMaxGuaranteedLength = 1000;
            memo.Padding = new Padding(50, 0, 0, 0);
            memo.Size = new Size(482, 50);
            memo.TabIndex = 3;
            memo.Views.SimpleView.AllowDisplayLineNumbers = true;
            // 
            // yn_deleted
            // 
            yn_deleted.Checked = false;
            yn_deleted.ControlHeight = 21;
            yn_deleted.ControlWidth = 131;
            yn_deleted.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yn_deleted.FontColor = Color.Black;
            yn_deleted.FontFace = "Tahoma";
            yn_deleted.FontSize = 9F;
            yn_deleted.Location = new Point(239, 26);
            yn_deleted.Name = "yn_deleted";
            yn_deleted.Size = new Size(131, 21);
            yn_deleted.TabIndex = 2;
            yn_deleted.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            yn_deleted.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // temp_name
            // 
            temp_name.Appearance.Font = new Font("Tahoma", 9F);
            temp_name.Appearance.Options.UseFont = true;
            temp_name.ControlHeight = 21;
            temp_name.ControlWidth = 599;
            temp_name.FontColor = Color.Black;
            temp_name.FontFace = "Tahoma";
            temp_name.FontSize = 9F;
            temp_name.FormatStr = "";
            temp_name.Location = new Point(5, 53);
            temp_name.Name = "temp_name";
            temp_name.Size = new Size(599, 21);
            temp_name.TabIndex = 1;
            temp_name.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            temp_name.Title = "Template Name";
            temp_name.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            temp_name.TitleWidth = 117;
            // 
            // category
            // 
            category.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category.Appearance.Options.UseFont = true;
            category.ControlHeight = 21;
            category.ControlWidth = 228;
            category.FldTy = null;
            category.FontColor = Color.Black;
            category.FontFace = "Tahoma";
            category.FontSize = 9F;
            category.Location = new Point(376, 26);
            category.Name = "category";
            category.Size = new Size(228, 21);
            category.TabIndex = 0;
            category.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            category.Title = "Category";
            category.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            category.TitleWidth = 100;
            // 
            // temp_cd
            // 
            temp_cd.Appearance.Font = new Font("Tahoma", 9F);
            temp_cd.Appearance.Options.UseFont = true;
            temp_cd.ControlHeight = 21;
            temp_cd.ControlWidth = 228;
            temp_cd.FontColor = Color.Black;
            temp_cd.FontFace = "Tahoma";
            temp_cd.FontSize = 9F;
            temp_cd.FormatStr = "";
            temp_cd.Location = new Point(5, 26);
            temp_cd.Name = "temp_cd";
            temp_cd.Size = new Size(228, 21);
            temp_cd.TabIndex = 1;
            temp_cd.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            temp_cd.Title = "Template";
            temp_cd.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            temp_cd.TitleWidth = 117;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(967, 705);
            g20.TabIndex = 1;
            // 
            // SA300
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "SA300";
            Size = new Size(1316, 844);
            ucSplit1.Panel1.ResumeLayout(false);
            ucSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit1).EndInit();
            ucSplit1.ResumeLayout(false);
            ucSplit2.Panel1.ResumeLayout(false);
            ucSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit2).EndInit();
            ucSplit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel1).EndInit();
            ucPanel1.ResumeLayout(false);
            ucSplit3.Panel1.ResumeLayout(false);
            ucSplit3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucSplit3).EndInit();
            ucSplit3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucPanel2).EndInit();
            ucPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCChkCodeBox f_yn_delete;
        private Ctrls.UCTextBox f_temp_cd;
        private Ctrls.UCCodeBox f_category;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCRichText memo;
        private Ctrls.UCCheckBox yn_deleted;
        private Ctrls.UCTextBox temp_name;
        private Ctrls.UCCodeBox category;
        private Ctrls.UCTextBox temp_cd;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCGridSet g20;
    }
}
