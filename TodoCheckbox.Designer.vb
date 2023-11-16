<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodoCheckbox
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
        EditBtn = New Button()
        RecurringLabel = New Label()
        ChoreCheckbox = New CheckBox()
        EffortIcon = New Label()
        EffortLabel = New Label()
        SuspendLayout()
        ' 
        ' EditBtn
        ' 
        EditBtn.BackgroundImage = My.Resources.Resources.EditPic
        EditBtn.BackgroundImageLayout = ImageLayout.Center
        EditBtn.FlatAppearance.BorderSize = 0
        EditBtn.FlatStyle = FlatStyle.Flat
        EditBtn.Location = New Point(228, 3)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(42, 40)
        EditBtn.TabIndex = 14
        EditBtn.UseVisualStyleBackColor = True
        ' 
        ' RecurringLabel
        ' 
        RecurringLabel.AutoSize = True
        RecurringLabel.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        RecurringLabel.Location = New Point(31, 33)
        RecurringLabel.Name = "RecurringLabel"
        RecurringLabel.Size = New Size(66, 16)
        RecurringLabel.TabIndex = 13
        RecurringLabel.Text = "Recurring:"
        ' 
        ' ChoreCheckbox
        ' 
        ChoreCheckbox.AutoSize = True
        ChoreCheckbox.BackColor = Color.Transparent
        ChoreCheckbox.FlatAppearance.MouseOverBackColor = Color.IndianRed
        ChoreCheckbox.FlatStyle = FlatStyle.Flat
        ChoreCheckbox.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChoreCheckbox.Location = New Point(17, 3)
        ChoreCheckbox.Name = "ChoreCheckbox"
        ChoreCheckbox.Size = New Size(76, 22)
        ChoreCheckbox.TabIndex = 12
        ChoreCheckbox.Text = "Chore1"
        ChoreCheckbox.UseVisualStyleBackColor = False
        ' 
        ' EffortIcon
        ' 
        EffortIcon.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        EffortIcon.Image = My.Resources.Resources.Effortpic
        EffortIcon.Location = New Point(156, 33)
        EffortIcon.Name = "EffortIcon"
        EffortIcon.Size = New Size(18, 15)
        EffortIcon.TabIndex = 15
        ' 
        ' EffortLabel
        ' 
        EffortLabel.AutoSize = True
        EffortLabel.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        EffortLabel.Location = New Point(180, 33)
        EffortLabel.Name = "EffortLabel"
        EffortLabel.Size = New Size(14, 16)
        EffortLabel.TabIndex = 16
        EffortLabel.Text = "1"
        ' 
        ' TodoCheckbox
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(EffortLabel)
        Controls.Add(EffortIcon)
        Controls.Add(EditBtn)
        Controls.Add(RecurringLabel)
        Controls.Add(ChoreCheckbox)
        Margin = New Padding(0)
        Name = "TodoCheckbox"
        Size = New Size(277, 49)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EditBtn As Button
    Friend WithEvents RecurringLabel As Label
    Friend WithEvents ChoreCheckbox As CheckBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents EffortIcon As Label
    Friend WithEvents EffortLabel As Label
End Class
