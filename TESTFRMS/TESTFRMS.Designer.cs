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
            ucGridSet1 = new Ctrls.UCGridSet();
            ucTextBox1 = new Ctrls.UCTextBox();
            ucCodeBox1 = new Ctrls.UCCodeBox();
            ucDateBox1 = new Ctrls.UCDateBox();
            SuspendLayout();
            // 
            // ucGridSet1
            // 
            ucGridSet1.Location = new Point(351, 35);
            ucGridSet1.Name = "ucGridSet1";
            ucGridSet1.Size = new Size(390, 367);
            ucGridSet1.TabIndex = 0;
            // 
            // ucTextBox1
            // 
            ucTextBox1.ButtonVisiable = false;
            ucTextBox1.ControlHeight = 21;
            ucTextBox1.ControlWidth = 200;
            ucTextBox1.FontColor = Color.Black;
            ucTextBox1.FontFace = "Tahoma";
            ucTextBox1.FontSize = 9F;
            ucTextBox1.FormatStr = "";
            ucTextBox1.Location = new Point(53, 60);
            ucTextBox1.Margin = new Padding(4, 3, 4, 3);
            ucTextBox1.Name = "ucTextBox1";
            ucTextBox1.Size = new Size(200, 21);
            ucTextBox1.TabIndex = 1;
            ucTextBox1.Text = "ucTextBox1";
            ucTextBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox1.Title = "UCTextBox";
            ucTextBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucTextBox1.TitleWidth = 100;
            // 
            // ucCodeBox1
            // 
            ucCodeBox1.ControlHeight = 21;
            ucCodeBox1.ControlWidth = 200;
            ucCodeBox1.FldTy = null;
            ucCodeBox1.FontColor = Color.Black;
            ucCodeBox1.FontFace = "Tahoma";
            ucCodeBox1.FontSize = 9F;
            ucCodeBox1.Location = new Point(53, 87);
            ucCodeBox1.Margin = new Padding(4, 3, 4, 3);
            ucCodeBox1.Name = "ucCodeBox1";
            ucCodeBox1.Size = new Size(210, 23);
            ucCodeBox1.TabIndex = 2;
            ucCodeBox1.Text = "ucCodeBox1";
            ucCodeBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox1.Title = "Code";
            ucCodeBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucCodeBox1.TitleWidth = 100;
            // 
            // ucDateBox1
            // 
            ucDateBox1.ControlHeight = 21;
            ucDateBox1.ControlWidth = 200;
            ucDateBox1.FontColor = Color.Black;
            ucDateBox1.FontFace = "Tahoma";
            ucDateBox1.FontSize = 9F;
            ucDateBox1.FormatStr = "";
            ucDateBox1.Location = new Point(53, 116);
            ucDateBox1.Name = "ucDateBox1";
            ucDateBox1.Size = new Size(200, 21);
            ucDateBox1.TabIndex = 3;
            ucDateBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox1.Title = "UCTextBox";
            ucDateBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Near;
            ucDateBox1.TitleWidth = 100;
            // 
            // TESTFRMS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucDateBox1);
            Controls.Add(ucCodeBox1);
            Controls.Add(ucTextBox1);
            Controls.Add(ucGridSet1);
            Name = "TESTFRMS";
            Size = new Size(800, 450);
            Load += UserControl1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Ctrls.UCGridSet ucGridSet1;
        private Ctrls.UCTextBox ucTextBox1;
        private Ctrls.UCCodeBox ucCodeBox1;
        private Ctrls.UCDateBox ucDateBox1;
    }
}
