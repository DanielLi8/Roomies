<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HouseholdDetails
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
        HouseholdName = New Label()
        HouseholdNameInput = New TextBox()
        RoomateSelectionLabel = New Label()
        InviteLabel = New Label()
        CreateBtn = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        GroupBox1 = New GroupBox()
        CancelBtn = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' HouseholdName
        ' 
        HouseholdName.AutoSize = True
        HouseholdName.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        HouseholdName.Location = New Point(85, 26)
        HouseholdName.Name = "HouseholdName"
        HouseholdName.Size = New Size(161, 22)
        HouseholdName.TabIndex = 0
        HouseholdName.Text = "Household Name:"
        ' 
        ' HouseholdNameInput
        ' 
        HouseholdNameInput.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        HouseholdNameInput.Location = New Point(252, 23)
        HouseholdNameInput.Name = "HouseholdNameInput"
        HouseholdNameInput.Size = New Size(145, 29)
        HouseholdNameInput.TabIndex = 1
        ' 
        ' RoomateSelectionLabel
        ' 
        RoomateSelectionLabel.AutoSize = True
        RoomateSelectionLabel.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        RoomateSelectionLabel.Location = New Point(85, 65)
        RoomateSelectionLabel.Name = "RoomateSelectionLabel"
        RoomateSelectionLabel.Size = New Size(300, 22)
        RoomateSelectionLabel.TabIndex = 2
        RoomateSelectionLabel.Text = "How many roomates do you have?"
        ' 
        ' InviteLabel
        ' 
        InviteLabel.AutoSize = True
        InviteLabel.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        InviteLabel.Location = New Point(85, 146)
        InviteLabel.Name = "InviteLabel"
        InviteLabel.Size = New Size(326, 22)
        InviteLabel.TabIndex = 3
        InviteLabel.Text = "Send them an invite to the household!"
        ' 
        ' CreateBtn
        ' 
        CreateBtn.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        CreateBtn.Location = New Point(90, 582)
        CreateBtn.Name = "CreateBtn"
        CreateBtn.Size = New Size(132, 35)
        CreateBtn.TabIndex = 7
        CreateBtn.Text = "Create!"
        CreateBtn.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(19, 1)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(51, 24)
        RadioButton1.TabIndex = 8
        RadioButton1.TabStop = True
        RadioButton1.Text = "1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.Location = New Point(80, 1)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(51, 24)
        RadioButton2.TabIndex = 9
        RadioButton2.TabStop = True
        RadioButton2.Text = "2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton3.Location = New Point(141, 1)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(51, 24)
        RadioButton3.TabIndex = 10
        RadioButton3.TabStop = True
        RadioButton3.Text = "3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton4.Location = New Point(202, 1)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(51, 24)
        RadioButton4.TabIndex = 11
        RadioButton4.TabStop = True
        RadioButton4.Text = "4"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImageLayout = ImageLayout.None
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(90, 90)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(265, 33)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        ' 
        ' CancelBtn
        ' 
        CancelBtn.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        CancelBtn.Location = New Point(265, 582)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(132, 35)
        CancelBtn.TabIndex = 15
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = True
        ' 
        ' HouseholdDetails
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.FromArgb(CByte(222), CByte(213), CByte(188))
        ClientSize = New Size(509, 629)
        Controls.Add(CancelBtn)
        Controls.Add(GroupBox1)
        Controls.Add(CreateBtn)
        Controls.Add(InviteLabel)
        Controls.Add(RoomateSelectionLabel)
        Controls.Add(HouseholdNameInput)
        Controls.Add(HouseholdName)
        ForeColor = Color.Black
        Name = "HouseholdDetails"
        StartPosition = FormStartPosition.Manual
        Text = " "
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HouseholdName As Label
    Friend WithEvents HouseholdNameInput As TextBox
    Friend WithEvents RoomateSelectionLabel As Label
    Friend WithEvents InviteLabel As Label
    Friend WithEvents CreateBtn As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CancelBtn As Button
End Class
