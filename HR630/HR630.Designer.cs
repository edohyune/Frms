namespace EpicV004.Frms
{
    partial class HR630
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
            g10 = new Ctrls.UCGridSet();
            g20 = new Ctrls.UCGridSet();
            s_year = new Ctrls.UCDateBox();
            s_pay_date = new Ctrls.UCDateBox();
            s_pay_ty = new Ctrls.UCCodeBox();
            btn_salary = new Ctrls.UCButton();
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
            SuspendLayout();
            // 
            // ucSplit1
            // 
            ucSplit1.Dock = DockStyle.Fill;
            ucSplit1.Location = new Point(0, 0);
            ucSplit1.Name = "ucSplit1";
            // 
            // ucSplit1.Panel1
            // 
            ucSplit1.Panel1.Controls.Add(ucSplit3);
            // 
            // ucSplit1.Panel2
            // 
            ucSplit1.Panel2.Controls.Add(ucSplit2);
            ucSplit1.Size = new Size(800, 450);
            ucSplit1.SplitterDistance = 266;
            ucSplit1.TabIndex = 0;
            ucSplit1.TitleWidth = 121;
            // 
            // ucSplit2
            // 
            ucSplit2.Dock = DockStyle.Fill;
            ucSplit2.Location = new Point(0, 0);
            ucSplit2.Name = "ucSplit2";
            ucSplit2.Orientation = Orientation.Horizontal;
            // 
            // ucSplit2.Panel1
            // 
            ucSplit2.Panel1.Controls.Add(ucPanel2);
            // 
            // ucSplit2.Panel2
            // 
            ucSplit2.Panel2.Controls.Add(g20);
            ucSplit2.Size = new Size(530, 450);
            ucSplit2.SplitterDistance = 88;
            ucSplit2.TabIndex = 0;
            ucSplit2.TitleWidth = 121;
            // 
            // ucSplit3
            // 
            ucSplit3.Dock = DockStyle.Fill;
            ucSplit3.Location = new Point(0, 0);
            ucSplit3.Name = "ucSplit3";
            ucSplit3.Orientation = Orientation.Horizontal;
            // 
            // ucSplit3.Panel1
            // 
            ucSplit3.Panel1.Controls.Add(ucPanel1);
            // 
            // ucSplit3.Panel2
            // 
            ucSplit3.Panel2.Controls.Add(g10);
            ucSplit3.Size = new Size(266, 450);
            ucSplit3.SplitterDistance = 88;
            ucSplit3.TabIndex = 0;
            ucSplit3.TitleWidth = 121;
            // 
            // ucPanel1
            // 
            ucPanel1.Controls.Add(s_year);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(266, 88);
            ucPanel1.TabIndex = 0;
            ucPanel1.Text = "Search";
            // 
            // ucPanel2
            // 
            ucPanel2.Controls.Add(btn_salary);
            ucPanel2.Controls.Add(s_pay_ty);
            ucPanel2.Controls.Add(s_pay_date);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(0, 0);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(530, 88);
            ucPanel2.TabIndex = 0;
            ucPanel2.Text = "Salary Staff";
            // 
            // g10
            // 
            g10.Dock = DockStyle.Fill;
            g10.Location = new Point(0, 0);
            g10.Name = "g10";
            g10.Size = new Size(266, 358);
            g10.TabIndex = 0;
            // 
            // g20
            // 
            g20.Dock = DockStyle.Fill;
            g20.Location = new Point(0, 0);
            g20.Name = "g20";
            g20.Size = new Size(530, 358);
            g20.TabIndex = 0;
            // 
            // s_year
            // 
            s_year.ControlHeight = 21;
            s_year.ControlWidth = 200;
            s_year.FontColor = Color.Black;
            s_year.FontFace = "Tahoma";
            s_year.FontSize = 9F;
            s_year.FormatStr = "";
            s_year.Location = new Point(5, 45);
            s_year.Name = "s_year";
            s_year.Size = new Size(200, 21);
            s_year.TabIndex = 0;
            s_year.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.Title = "Year";
            s_year.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_year.TitleWidth = 100;
            // 
            // s_pay_date
            // 
            s_pay_date.ControlHeight = 21;
            s_pay_date.ControlWidth = 280;
            s_pay_date.FontColor = Color.Black;
            s_pay_date.FontFace = "Tahoma";
            s_pay_date.FontSize = 9F;
            s_pay_date.FormatStr = "";
            s_pay_date.Location = new Point(5, 27);
            s_pay_date.Name = "s_pay_date";
            s_pay_date.Size = new Size(280, 21);
            s_pay_date.TabIndex = 0;
            s_pay_date.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_pay_date.Title = "Pay Date";
            s_pay_date.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_pay_date.TitleWidth = 100;
            // 
            // s_pay_ty
            // 
            s_pay_ty.ControlHeight = 21;
            s_pay_ty.ControlWidth = 280;
            s_pay_ty.FldTy = null;
            s_pay_ty.FontColor = Color.Black;
            s_pay_ty.FontFace = "Tahoma";
            s_pay_ty.FontSize = 9F;
            s_pay_ty.Location = new Point(5, 51);
            s_pay_ty.Name = "s_pay_ty";
            s_pay_ty.Size = new Size(280, 21);
            s_pay_ty.TabIndex = 1;
            s_pay_ty.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_pay_ty.Title = "Pay Type";
            s_pay_ty.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            s_pay_ty.TitleWidth = 100;
            // 
            // btn_salary
            // 
            btn_salary.Appearance.Font = new Font("Tahoma", 9F);
            btn_salary.Appearance.Options.UseFont = true;
            btn_salary.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btn_salary.ControlHeight = 46;
            btn_salary.ControlWidth = 137;
            btn_salary.FontBold = FontStyle.Regular;
            btn_salary.FontFace = "Tahoma";
            btn_salary.FontSize = 9F;
            btn_salary.Location = new Point(291, 26);
            btn_salary.Name = "btn_salary";
            btn_salary.Size = new Size(137, 46);
            btn_salary.TabIndex = 2;
            btn_salary.Title = "Make Salary Staff";
            btn_salary.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
            // 
            // HR630
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucSplit1);
            Name = "HR630";
            Size = new Size(800, 450);
            Load += HR630_Load;
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
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCSplit ucSplit1;
        private Ctrls.UCSplit ucSplit3;
        private Ctrls.UCPanel ucPanel1;
        private Ctrls.UCDateBox s_year;
        private Ctrls.UCGridSet g10;
        private Ctrls.UCSplit ucSplit2;
        private Ctrls.UCPanel ucPanel2;
        private Ctrls.UCCodeBox s_pay_ty;
        private Ctrls.UCDateBox s_pay_date;
        private Ctrls.UCGridSet g20;
        private Ctrls.UCButton btn_salary;
    }
}
