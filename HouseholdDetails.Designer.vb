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
        CancelBtn = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' HouseholdName
        ' 
        HouseholdName.AutoSize = True
        HouseholdName.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        HouseholdName.Location = New Point(39, 25)
        HouseholdName.Name = "HouseholdName"
        HouseholdName.Size = New Size(128, 18)
        HouseholdName.TabIndex = 0
        HouseholdName.Text = "Household Name:"
        ' 
        ' HouseholdNameInput
        ' 
        HouseholdNameInput.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        HouseholdNameInput.Location = New Point(169, 25)
        HouseholdNameInput.Name = "HouseholdNameInput"
        HouseholdNameInput.Size = New Size(128, 24)
        HouseholdNameInput.TabIndex = 1
        ' 
        ' RoomateSelectionLabel
        ' 
        RoomateSelectionLabel.AutoSize = True
        RoomateSelectionLabel.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RoomateSelectionLabel.Location = New Point(44, 59)
        RoomateSelectionLabel.Name = "RoomateSelectionLabel"
        RoomateSelectionLabel.Size = New Size(239, 18)
        RoomateSelectionLabel.TabIndex = 2
        RoomateSelectionLabel.Text = "How many roomates do you have?"
        ' 
        ' InviteLabel
        ' 
        InviteLabel.AutoSize = True
        InviteLabel.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        InviteLabel.Location = New Point(44, 125)
        InviteLabel.Name = "InviteLabel"
        InviteLabel.Size = New Size(253, 18)
        InviteLabel.TabIndex = 3
        InviteLabel.Text = "Send them an invite to the household!"
        ' 
        ' CreateBtn
        ' 
        CreateBtn.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CreateBtn.Location = New Point(71, 500)
        CreateBtn.Name = "CreateBtn"
        CreateBtn.Size = New Size(69, 30)
        CreateBtn.TabIndex = 7
        CreateBtn.Text = "Create!"
        CreateBtn.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(11, 3)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(51, 24)
        RadioButton1.TabIndex = 8
        RadioButton1.TabStop = True
        RadioButton1.Text = "1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.Location = New Point(92, 3)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(51, 24)
        RadioButton2.TabIndex = 9
        RadioButton2.TabStop = True
        RadioButton2.Text = "2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton3.Location = New Point(173, 3)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(51, 24)
        RadioButton3.TabIndex = 10
        RadioButton3.TabStop = True
        RadioButton3.Text = "3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' CancelBtn
        ' 
        CancelBtn.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CancelBtn.Location = New Point(208, 500)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(69, 30)
        CancelBtn.TabIndex = 15
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton3)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Location = New Point(53, 88)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(229, 28)
        Panel1.TabIndex = 16
        ' 
        ' HouseholdDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(222), CByte(213), CByte(188))
        ClientSize = New Size(349, 556)
        Controls.Add(Panel1)
        Controls.Add(InviteLabel)
        Controls.Add(CancelBtn)
        Controls.Add(CreateBtn)
        Controls.Add(RoomateSelectionLabel)
        Controls.Add(HouseholdNameInput)
        Controls.Add(HouseholdName)
        ForeColor = Color.Black
        Name = "HouseholdDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel1.ResumeLayout(False)
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
    Friend WithEvents CancelBtn As Button
    Friend WithEvents Panel1 As Panel
End Class
