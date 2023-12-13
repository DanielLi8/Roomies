<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReminderView
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
        components = New ComponentModel.Container()
        ReminderHeader = New Label()
        ReminderPanel = New Panel()
        Timer1 = New Timer(components)
        CloseBtn = New Button()
        SuspendLayout()
        ' 
        ' ReminderHeader
        ' 
        ReminderHeader.AutoSize = True
        ReminderHeader.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ReminderHeader.Location = New Point(12, 36)
        ReminderHeader.Name = "ReminderHeader"
        ReminderHeader.Size = New Size(275, 22)
        ReminderHeader.TabIndex = 0
        ReminderHeader.Text = "Name Task Left to Complete:"
        ' 
        ' ReminderPanel
        ' 
        ReminderPanel.Location = New Point(12, 82)
        ReminderPanel.Name = "ReminderPanel"
        ReminderPanel.Size = New Size(311, 355)
        ReminderPanel.TabIndex = 1
        ' 
        ' CloseBtn
        ' 
        CloseBtn.BackColor = Color.FromArgb(CByte(224), CByte(218), CByte(207))
        CloseBtn.FlatAppearance.BorderColor = Color.Black
        CloseBtn.FlatAppearance.BorderSize = 3
        CloseBtn.FlatStyle = FlatStyle.Flat
        CloseBtn.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        CloseBtn.Location = New Point(69, 494)
        CloseBtn.Name = "CloseBtn"
        CloseBtn.Size = New Size(194, 38)
        CloseBtn.TabIndex = 2
        CloseBtn.Text = "Close"
        CloseBtn.UseVisualStyleBackColor = False
        ' 
        ' ReminderView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(218), CByte(207))
        ClientSize = New Size(349, 556)
        Controls.Add(CloseBtn)
        Controls.Add(ReminderPanel)
        Controls.Add(ReminderHeader)
        Name = "ReminderView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReminderView"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ReminderHeader As Label
    Friend WithEvents ReminderPanel As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CloseBtn As Button
End Class
