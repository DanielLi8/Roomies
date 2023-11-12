<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoommateAddLayout
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
        Emaillnput = New TextBox()
        NameInput = New TextBox()
        Email = New Label()
        RoommateName = New Label()
        nameLabel = New Label()
        SuspendLayout()
        ' 
        ' Emaillnput
        ' 
        Emaillnput.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Emaillnput.Location = New Point(89, 69)
        Emaillnput.Name = "Emaillnput"
        Emaillnput.Size = New Size(173, 25)
        Emaillnput.TabIndex = 18
        ' 
        ' NameInput
        ' 
        NameInput.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        NameInput.Location = New Point(89, 30)
        NameInput.Name = "NameInput"
        NameInput.Size = New Size(173, 25)
        NameInput.TabIndex = 17
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Email.Location = New Point(12, 72)
        Email.Name = "Email"
        Email.Size = New Size(49, 17)
        Email.TabIndex = 16
        Email.Text = "Email:"
        ' 
        ' RoommateName
        ' 
        RoommateName.AutoSize = True
        RoommateName.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RoommateName.Location = New Point(12, 33)
        RoommateName.Name = "RoommateName"
        RoommateName.Size = New Size(55, 17)
        RoommateName.TabIndex = 15
        RoommateName.Text = "Name: "
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nameLabel.Location = New Point(12, 0)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(93, 17)
        nameLabel.TabIndex = 14
        nameLabel.Text = "Roommate 1"
        ' 
        ' RoommateAddLayout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(222), CByte(213), CByte(188))
        Controls.Add(Emaillnput)
        Controls.Add(NameInput)
        Controls.Add(Email)
        Controls.Add(RoommateName)
        Controls.Add(nameLabel)
        Margin = New Padding(0)
        Name = "RoommateAddLayout"
        Size = New Size(311, 102)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Emaillnput As TextBox
    Friend WithEvents NameInput As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents RoommateName As Label
    Friend WithEvents nameLabel As Label
End Class
