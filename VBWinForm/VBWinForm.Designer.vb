Imports EpicV004
Imports EpicV004.Ctrls
Imports System.Windows.Forms

Namespace EpicV004
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class VBWinForm
        Inherits FrmBase

        'UserControl1 overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            UcSplit1 = New UCSplit()
            UcSplit2 = New UCSplit()
            CType(UcSplit1, System.ComponentModel.ISupportInitialize).BeginInit()
            UcSplit1.Panel2.SuspendLayout()
            UcSplit1.SuspendLayout()
            CType(UcSplit2, System.ComponentModel.ISupportInitialize).BeginInit()
            UcSplit2.SuspendLayout()
            SuspendLayout()
            ' 
            ' UcSplit1
            ' 
            UcSplit1.Dock = DockStyle.Fill
            UcSplit1.Location = New Point(0, 0)
            UcSplit1.Name = "UcSplit1"
            ' 
            ' UcSplit1.Panel2
            ' 
            UcSplit1.Panel2.Controls.Add(UcSplit2)
            UcSplit1.Size = New Size(800, 450)
            UcSplit1.SplitterDistance = 266
            UcSplit1.TabIndex = 0
            UcSplit1.TitleWidth = 50
            ' 
            ' UcSplit2
            ' 
            UcSplit2.Dock = DockStyle.Fill
            UcSplit2.Location = New Point(0, 0)
            UcSplit2.Name = "UcSplit2"
            UcSplit2.Orientation = Orientation.Horizontal
            UcSplit2.Size = New Size(530, 450)
            UcSplit2.SplitterDistance = 176
            UcSplit2.TabIndex = 0
            UcSplit2.TitleWidth = 50
            ' 
            ' VBWinForm
            ' 
            AutoScaleDimensions = New SizeF(7.0F, 15.0F)
            AutoScaleMode = AutoScaleMode.Font
            Controls.Add(UcSplit1)
            Name = "VBWinForm"
            Size = New Size(800, 450)
            UcSplit1.Panel2.ResumeLayout(False)
            CType(UcSplit1, System.ComponentModel.ISupportInitialize).EndInit()
            UcSplit1.ResumeLayout(False)
            CType(UcSplit2, System.ComponentModel.ISupportInitialize).EndInit()
            UcSplit2.ResumeLayout(False)
            ResumeLayout(False)
        End Sub

        Friend WithEvents UcSplit1 As UCSplit
        Friend WithEvents UcSplit2 As UCSplit

    End Class
End Namespace
