﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tctr
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tctr))
        Me.webbrowser = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'webbrowser
        '
        Me.webbrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webbrowser.Location = New System.Drawing.Point(0, 0)
        Me.webbrowser.Name = "webbrowser"
        Me.webbrowser.Size = New System.Drawing.Size(816, 451)
        Me.webbrowser.TabIndex = 0
        '
        'tctr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 451)
        Me.Controls.Add(Me.webbrowser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tctr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trinity Core Ticket Reader"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webbrowser As Panel
End Class
