﻿namespace EpicV004.Frms
{
 partial class TST101
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
   search = new Ctrls.UCTextBox();
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
   ucSplit1.Size = new Size(894, 586);
   ucSplit1.SplitterDistance = 56;
   ucSplit1.TabIndex = 0;
   ucSplit1.TitleWidth = 121;
   // 
   // ucPanel1
   // 
   ucPanel1.Controls.Add(search);
   ucPanel1.Dock = DockStyle.Fill;
   ucPanel1.Location = new Point(0, 0);
   ucPanel1.Name = "ucPanel1";
   ucPanel1.Size = new Size(894, 56);
   ucPanel1.TabIndex = 0;
   ucPanel1.Text = "Search";
   // 
   // search
   // 
   search.ButtonVisiable = false;
   search.ControlHeight = 21;
   search.ControlWidth = 277;
   search.FontColor = Color.Black;
   search.FontFace = "Tahoma";
   search.FontSize = 9F;
   search.FormatStr = "";
   search.Location = new Point(19, 30);
   search.Name = "search";
   search.Size = new Size(277, 21);
   search.TabIndex = 0;
   search.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
   search.Title = "Search";
   search.TitleAlignment = DevExpress.Utils.HorzAlignment.Default;
   search.TitleWidth = 100;
   // 
   // ucPanel2
   // 
   ucPanel2.Controls.Add(g10);
   ucPanel2.Dock = DockStyle.Fill;
   ucPanel2.Location = new Point(0, 0);
   ucPanel2.Name = "ucPanel2";
   ucPanel2.Size = new Size(894, 526);
   ucPanel2.TabIndex = 0;
   ucPanel2.Text = "Controller List";
   // 
   // g10
   // 
   g10.Dock = DockStyle.Fill;
   g10.Location = new Point(2, 23);
   g10.Name = "g10";
   g10.Size = new Size(890, 501);
   g10.TabIndex = 0;
   // 
   // TST101
   // 
   AutoScaleDimensions = new SizeF(7F, 15F);
   AutoScaleMode = AutoScaleMode.Font;
   Controls.Add(ucSplit1);
   Name = "TST101";
   Size = new Size(894, 586);
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
  private EpicV004.Ctrls.UCTextBox search;
  private Ctrls.UCPanel ucPanel2;
  private Ctrls.UCGridSet g10;
 }
}
