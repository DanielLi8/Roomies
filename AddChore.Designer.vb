<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddChore
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
        Chore = New Label()
        PictureBox1 = New PictureBox()
        ChoreInput = New TextBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        RecurringNone = New RadioButton()
        RecurringDaily = New RadioButton()
        RecurringWeekly = New RadioButton()
        RecurringMonthly = New RadioButton()
        PictureBox3 = New PictureBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Effort1 = New RadioButton()
        Effort2 = New RadioButton()
        Effort3 = New RadioButton()
        Effort4 = New RadioButton()
        Effort5 = New RadioButton()
        Panel2 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox4 = New PictureBox()
        AssignToLabel = New Label()
        Assignee = New ComboBox()
        CreateButton = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        RadioButtonRandom = New RadioButton()
        RadioButtonOptimal = New RadioButton()
        RadioButtonManual = New RadioButton()
        ExcludeRadioBtn = New RadioButton()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Chore
        ' 
        Chore.AutoSize = True
        Chore.Location = New Point(59, 105)
        Chore.Name = "Chore"
        Chore.Size = New Size(42, 15)
        Chore.TabIndex = 0
        Chore.Text = "Chore:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.broom_dark
        PictureBox1.Location = New Point(27, 95)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(26, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' ChoreInput
        ' 
        ChoreInput.Location = New Point(107, 105)
        ChoreInput.Name = "ChoreInput"
        ChoreInput.Size = New Size(188, 23)
        ChoreInput.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.recurring_dark
        PictureBox2.Location = New Point(27, 140)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(26, 32)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 4
        Label1.Text = "Recurring:"
        ' 
        ' RecurringNone
        ' 
        RecurringNone.AutoSize = True
        RecurringNone.Location = New Point(3, 3)
        RecurringNone.Name = "RecurringNone"
        RecurringNone.Size = New Size(54, 19)
        RecurringNone.TabIndex = 5
        RecurringNone.TabStop = True
        RecurringNone.Text = "None"
        RecurringNone.UseVisualStyleBackColor = True
        ' 
        ' RecurringDaily
        ' 
        RecurringDaily.AutoSize = True
        RecurringDaily.Location = New Point(66, 3)
        RecurringDaily.Name = "RecurringDaily"
        RecurringDaily.Size = New Size(51, 19)
        RecurringDaily.TabIndex = 6
        RecurringDaily.TabStop = True
        RecurringDaily.Text = "Daily"
        RecurringDaily.UseVisualStyleBackColor = True
        ' 
        ' RecurringWeekly
        ' 
        RecurringWeekly.AutoSize = True
        RecurringWeekly.Location = New Point(126, 3)
        RecurringWeekly.Name = "RecurringWeekly"
        RecurringWeekly.Size = New Size(63, 19)
        RecurringWeekly.TabIndex = 7
        RecurringWeekly.TabStop = True
        RecurringWeekly.Text = "Weekly"
        RecurringWeekly.UseVisualStyleBackColor = True
        ' 
        ' RecurringMonthly
        ' 
        RecurringMonthly.AutoSize = True
        RecurringMonthly.Location = New Point(198, 3)
        RecurringMonthly.Name = "RecurringMonthly"
        RecurringMonthly.Size = New Size(70, 19)
        RecurringMonthly.TabIndex = 8
        RecurringMonthly.TabStop = True
        RecurringMonthly.Text = "Monthly"
        RecurringMonthly.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.bicep_dark
        PictureBox3.Location = New Point(27, 222)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(26, 32)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 231)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 4
        Label2.Text = "Effort rating:"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(RecurringMonthly)
        Panel1.Controls.Add(RecurringNone)
        Panel1.Controls.Add(RecurringWeekly)
        Panel1.Controls.Add(RecurringDaily)
        Panel1.Location = New Point(58, 178)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(271, 31)
        Panel1.TabIndex = 9
        ' 
        ' Effort1
        ' 
        Effort1.AutoSize = True
        Effort1.Location = New Point(3, 3)
        Effort1.Name = "Effort1"
        Effort1.Size = New Size(31, 19)
        Effort1.TabIndex = 10
        Effort1.TabStop = True
        Effort1.Text = "1"
        Effort1.UseVisualStyleBackColor = True
        ' 
        ' Effort2
        ' 
        Effort2.AutoSize = True
        Effort2.Location = New Point(62, 3)
        Effort2.Name = "Effort2"
        Effort2.Size = New Size(31, 19)
        Effort2.TabIndex = 10
        Effort2.TabStop = True
        Effort2.Text = "2"
        Effort2.UseVisualStyleBackColor = True
        ' 
        ' Effort3
        ' 
        Effort3.AutoSize = True
        Effort3.Location = New Point(121, 3)
        Effort3.Name = "Effort3"
        Effort3.Size = New Size(31, 19)
        Effort3.TabIndex = 10
        Effort3.TabStop = True
        Effort3.Text = "3"
        Effort3.UseVisualStyleBackColor = True
        ' 
        ' Effort4
        ' 
        Effort4.AutoSize = True
        Effort4.Location = New Point(180, 3)
        Effort4.Name = "Effort4"
        Effort4.Size = New Size(31, 19)
        Effort4.TabIndex = 10
        Effort4.TabStop = True
        Effort4.Text = "4"
        Effort4.UseVisualStyleBackColor = True
        ' 
        ' Effort5
        ' 
        Effort5.AutoSize = True
        Effort5.Location = New Point(239, 3)
        Effort5.Name = "Effort5"
        Effort5.Size = New Size(31, 19)
        Effort5.TabIndex = 10
        Effort5.TabStop = True
        Effort5.Text = "5"
        Effort5.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Effort5)
        Panel2.Controls.Add(Effort1)
        Panel2.Controls.Add(Effort4)
        Panel2.Controls.Add(Effort2)
        Panel2.Controls.Add(Effort3)
        Panel2.Location = New Point(59, 252)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(271, 31)
        Panel2.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(58, 277)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 12
        Label3.Text = "Easy"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(280, 277)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 13
        Label4.Text = "Difficult"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.dude_dark1
        PictureBox4.Location = New Point(27, 306)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(26, 32)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' AssignToLabel
        ' 
        AssignToLabel.AutoSize = True
        AssignToLabel.Location = New Point(59, 315)
        AssignToLabel.Name = "AssignToLabel"
        AssignToLabel.Size = New Size(59, 15)
        AssignToLabel.TabIndex = 14
        AssignToLabel.Text = "Assign to:"
        ' 
        ' Assignee
        ' 
        Assignee.FormattingEnabled = True
        Assignee.Location = New Point(126, 372)
        Assignee.Name = "Assignee"
        Assignee.Size = New Size(121, 23)
        Assignee.TabIndex = 15
        Assignee.Visible = False
        ' 
        ' CreateButton
        ' 
        CreateButton.Location = New Point(210, 502)
        CreateButton.Name = "CreateButton"
        CreateButton.Size = New Size(75, 23)
        CreateButton.TabIndex = 16
        CreateButton.Text = "Create"
        CreateButton.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(62, 502)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 16
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(RadioButtonRandom)
        Panel3.Controls.Add(RadioButtonOptimal)
        Panel3.Controls.Add(RadioButtonManual)
        Panel3.Location = New Point(59, 335)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(271, 31)
        Panel3.TabIndex = 17
        ' 
        ' RadioButtonRandom
        ' 
        RadioButtonRandom.AutoSize = True
        RadioButtonRandom.Location = New Point(3, 3)
        RadioButtonRandom.Name = "RadioButtonRandom"
        RadioButtonRandom.Size = New Size(70, 19)
        RadioButtonRandom.TabIndex = 10
        RadioButtonRandom.TabStop = True
        RadioButtonRandom.Text = "Random"
        RadioButtonRandom.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonOptimal
        ' 
        RadioButtonOptimal.AutoSize = True
        RadioButtonOptimal.Location = New Point(90, 3)
        RadioButtonOptimal.Name = "RadioButtonOptimal"
        RadioButtonOptimal.Size = New Size(68, 19)
        RadioButtonOptimal.TabIndex = 10
        RadioButtonOptimal.TabStop = True
        RadioButtonOptimal.Text = "Optimal"
        RadioButtonOptimal.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonManual
        ' 
        RadioButtonManual.AutoSize = True
        RadioButtonManual.Location = New Point(180, 3)
        RadioButtonManual.Name = "RadioButtonManual"
        RadioButtonManual.Size = New Size(65, 19)
        RadioButtonManual.TabIndex = 10
        RadioButtonManual.TabStop = True
        RadioButtonManual.Text = "Manual"
        RadioButtonManual.UseVisualStyleBackColor = True
        ' 
        ' ExcludeRadioBtn
        ' 
        ExcludeRadioBtn.AutoSize = True
        ExcludeRadioBtn.Location = New Point(176, 412)
        ExcludeRadioBtn.Name = "ExcludeRadioBtn"
        ExcludeRadioBtn.Size = New Size(42, 19)
        ExcludeRadioBtn.TabIndex = 18
        ExcludeRadioBtn.TabStop = True
        ExcludeRadioBtn.Text = "Yes"
        ExcludeRadioBtn.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(58, 412)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 15)
        Label5.TabIndex = 19
        Label5.Text = "Exclude from chore:"
        ' 
        ' AddChore
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(218), CByte(207))
        ClientSize = New Size(349, 556)
        Controls.Add(ExcludeRadioBtn)
        Controls.Add(Label5)
        Controls.Add(Panel3)
        Controls.Add(Button1)
        Controls.Add(CreateButton)
        Controls.Add(Assignee)
        Controls.Add(AssignToLabel)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(ChoreInput)
        Controls.Add(PictureBox1)
        Controls.Add(Chore)
        Name = "AddChore"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Chore As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ChoreInput As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RecurringNone As RadioButton
    Friend WithEvents RecurringDaily As RadioButton
    Friend WithEvents RecurringWeekly As RadioButton
    Friend WithEvents RecurringMonthly As RadioButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Effort1 As RadioButton
    Friend WithEvents Effort2 As RadioButton
    Friend WithEvents Effort3 As RadioButton
    Friend WithEvents Effort4 As RadioButton
    Friend WithEvents Effort5 As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents AssignToLabel As Label
    Friend WithEvents Assignee As ComboBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadioButtonRandom As RadioButton
    Friend WithEvents RadioButtonOptimal As RadioButton
    Friend WithEvents RadioButtonManual As RadioButton
    Friend WithEvents ExcludeRadioBtn As RadioButton
    Friend WithEvents Label5 As Label
End Class
