<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Completedcheckboxvb
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        DoneByLabel = New Label()
        CompletedCheckbox = New CheckBox()
        SuspendLayout()
        ' 
        ' DoneByLabel
        ' 
        DoneByLabel.AutoSize = True
        DoneByLabel.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DoneByLabel.Location = New Point(18, 28)
        DoneByLabel.Name = "DoneByLabel"
        DoneByLabel.Size = New Size(61, 16)
        DoneByLabel.TabIndex = 15
        DoneByLabel.Text = "Done By:"
        ' 
        ' CompletedCheckbox
        ' 
        CompletedCheckbox.AutoSize = True
        CompletedCheckbox.BackColor = Color.Transparent
        CompletedCheckbox.Checked = True
        CompletedCheckbox.CheckState = CheckState.Checked
        CompletedCheckbox.Enabled = False
        CompletedCheckbox.FlatAppearance.MouseOverBackColor = Color.IndianRed
        CompletedCheckbox.FlatStyle = FlatStyle.Flat
        CompletedCheckbox.Font = New Font("Arial", 12F, FontStyle.Strikeout, GraphicsUnit.Point)
        CompletedCheckbox.Location = New Point(3, 3)
        CompletedCheckbox.Name = "CompletedCheckbox"
        CompletedCheckbox.Size = New Size(76, 22)
        CompletedCheckbox.TabIndex = 14
        CompletedCheckbox.Text = "Chore1"
        CompletedCheckbox.UseVisualStyleBackColor = False
        ' 
        ' Completedcheckboxvb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DoneByLabel)
        Controls.Add(CompletedCheckbox)
        Name = "Completedcheckboxvb"
        Size = New Size(183, 49)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DoneByLabel As Label
    Friend WithEvents CompletedCheckbox As CheckBox
End Class
