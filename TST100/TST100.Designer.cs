﻿namespace EpicV004.Frms
{
 partial class TST100
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
   s_txt = new Ctrls.UCTextBox();
   ucPanel2 = new Ctrls.UCPanel();
   g10 = new Ctrls.UCGridSet();
   ucCodeBox1 = new Ctrls.UCCodeBox();
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
   ucSplit1.Size = new Size(800, 450);
   ucSplit1.SplitterDistance = 69;
   ucSplit1.TabIndex = 0;
   ucSplit1.TitleWidth = 121;
   // 
   // ucPanel1
   // 
   ucPanel1.Controls.Add(ucCodeBox1);
   ucPanel1.Controls.Add(s_txt);
   ucPanel1.Dock = DockStyle.Fill;
   ucPanel1.Location = new Point(0, 0);
   ucPanel1.Name = "ucPanel1";
   ucPanel1.Size = new Size(800, 69);
   ucPanel1.TabIndex = 0;
   ucPanel1.Text = "ucPanel1";
   // 
   // s_txt
   // 
   s_txt.ButtonVisiable = true;
   s_txt.ControlHeight = 21;
   s_txt.ControlWidth = 200;
   s_txt.FontColor = Color.Black;
   s_txt.FontFace = "Tahoma";
   s_txt.FontSize = 9F;
   s_txt.FormatStr = "";
   s_txt.Location = new Point(5, 26);
   s_txt.Name = "s_txt";
   s_txt.Size = new Size(200, 21);
   s_txt.TabIndex = 0;
   s_txt.Text = "ucTextBox1";
   s_txt.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
   s_txt.Title = "Search";
   s_txt.TitleAlignment = DevExpress.Utils.HorzAlignment.Far;
   s_txt.TitleWidth = 100;
   // 
   // ucPanel2
   // 
   ucPanel2.Controls.Add(g10);
   ucPanel2.Dock = DockStyle.Fill;
   ucPanel2.Location = new Point(0, 0);
   ucPanel2.Name = "ucPanel2";
   ucPanel2.Size = new Size(800, 377);
   ucPanel2.TabIndex = 1;
   ucPanel2.Text = "ucPanel2";
   // 
   // g10
   // 
   g10.Dock = DockStyle.Fill;
   g10.Location = new Point(2, 23);
   g10.Name = "g10";
   g10.Size = new Size(796, 352);
   g10.TabIndex = 0;
   // 
   // ucCodeBox1
   // 
   ucCodeBox1.ControlHeight = 21;
   ucCodeBox1.ControlWidth = 200;
   ucCodeBox1.FontColor = Color.FromArgb(40, 40, 40);
   ucCodeBox1.FontFace = "Tahoma";
   ucCodeBox1.FontSize = 9F;
   ucCodeBox1.Location = new Point(244, 26);
   ucCodeBox1.Name = "ucCodeBox1";
   ucCodeBox1.Size = new Size(180, 21);
   ucCodeBox1.TabIndex = 1;
   ucCodeBox1.Text = "ucCodeBox1";
   ucCodeBox1.TextAlignment = DevExpress.Utils.HorzAlignment.Near;
   ucCodeBox1.Title = "UCCodeBox";
   ucCodeBox1.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
   ucCodeBox1.TitleWidth = 100;
   // 
   // TST100
   // 
   AutoScaleDimensions = new SizeF(7F, 15F);
   AutoScaleMode = AutoScaleMode.Font;
   Controls.Add(ucSplit1);
   Name = "TST100";
   Size = new Size(800, 450);
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

  private EpicV004.Ctrls.UCSplit ucSplit1;
  private EpicV004.Ctrls.UCPanel ucPanel1;
  private EpicV004.Ctrls.UCTextBox s_txt;
  private EpicV004.Ctrls.UCPanel ucPanel2;
  private EpicV004.Ctrls.UCGridSet g10;
  private Ctrls.UCCodeBox ucCodeBox1;
 }
}
