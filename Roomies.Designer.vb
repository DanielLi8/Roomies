<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Roomies
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
        BottomToolStripPanel = New ToolStripPanel()
        TopToolStripPanel = New ToolStripPanel()
        RightToolStripPanel = New ToolStripPanel()
        LeftToolStripPanel = New ToolStripPanel()
        ContentPanel = New ToolStripContentPanel()
        TabControl1 = New TabControl()
        UserA = New TabPage()
        Label1 = New Label()
        TodoViewPanel = New Panel()
        Panel1 = New Panel()
        ChoreCheckboxPanel = New Panel()
        Label2 = New Label()
        Roommate1 = New Label()
        AddChoreBtn = New Button()
        HouseholdName = New Label()
        DateLabel = New Label()
        MenuPanel = New Panel()
        ExpenseSummaryBtn = New Button()
        ExpensesBtn = New Button()
        CompletedBtn = New Button()
        TodoBtn = New Button()
        UserB = New TabPage()
        AddHouseholdBtn = New Button()
        AddHouseholdPanel = New Panel()
        TabControl1.SuspendLayout()
        UserA.SuspendLayout()
        TodoViewPanel.SuspendLayout()
        MenuPanel.SuspendLayout()
        AddHouseholdPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' BottomToolStripPanel
        ' 
        BottomToolStripPanel.Location = New Point(0, 0)
        BottomToolStripPanel.Name = "BottomToolStripPanel"
        BottomToolStripPanel.Orientation = Orientation.Horizontal
        BottomToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
        BottomToolStripPanel.Size = New Size(0, 0)
        ' 
        ' TopToolStripPanel
        ' 
        TopToolStripPanel.Location = New Point(0, 0)
        TopToolStripPanel.Name = "TopToolStripPanel"
        TopToolStripPanel.Orientation = Orientation.Horizontal
        TopToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
        TopToolStripPanel.Size = New Size(0, 0)
        ' 
        ' RightToolStripPanel
        ' 
        RightToolStripPanel.Location = New Point(0, 0)
        RightToolStripPanel.Name = "RightToolStripPanel"
        RightToolStripPanel.Orientation = Orientation.Horizontal
        RightToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
        RightToolStripPanel.Size = New Size(0, 0)
        ' 
        ' LeftToolStripPanel
        ' 
        LeftToolStripPanel.Location = New Point(0, 0)
        LeftToolStripPanel.Name = "LeftToolStripPanel"
        LeftToolStripPanel.Orientation = Orientation.Horizontal
        LeftToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
        LeftToolStripPanel.Size = New Size(0, 0)
        ' 
        ' ContentPanel
        ' 
        ContentPanel.Size = New Size(150, 150)
        ' 
        ' TabControl1
        ' 
        TabControl1.Appearance = TabAppearance.Buttons
        TabControl1.Controls.Add(UserA)
        TabControl1.Controls.Add(UserB)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Margin = New Padding(0)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(0, 0)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(553, 729)
        TabControl1.TabIndex = 2
        ' 
        ' UserA
        ' 
        UserA.BackColor = Color.Silver
        UserA.BackgroundImage = My.Resources.Resources.phone_template
        UserA.BackgroundImageLayout = ImageLayout.Stretch
        UserA.Controls.Add(Label1)
        UserA.Controls.Add(TodoViewPanel)
        UserA.Controls.Add(MenuPanel)
        UserA.ForeColor = Color.Black
        UserA.Location = New Point(4, 27)
        UserA.Name = "UserA"
        UserA.Padding = New Padding(3)
        UserA.Size = New Size(545, 698)
        UserA.TabIndex = 0
        UserA.Text = "User A"
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(8, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 5
        Label1.Text = "JASLLLO"
        ' 
        ' TodoViewPanel
        ' 
        TodoViewPanel.BackColor = Color.Transparent
        TodoViewPanel.Controls.Add(Panel1)
        TodoViewPanel.Controls.Add(ChoreCheckboxPanel)
        TodoViewPanel.Controls.Add(Label2)
        TodoViewPanel.Controls.Add(Roommate1)
        TodoViewPanel.Controls.Add(AddChoreBtn)
        TodoViewPanel.Controls.Add(HouseholdName)
        TodoViewPanel.Controls.Add(DateLabel)
        TodoViewPanel.Location = New Point(102, 42)
        TodoViewPanel.Margin = New Padding(0)
        TodoViewPanel.Name = "TodoViewPanel"
        TodoViewPanel.Size = New Size(345, 507)
        TodoViewPanel.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(21, 333)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(287, 152)
        Panel1.TabIndex = 8
        ' 
        ' ChoreCheckboxPanel
        ' 
        ChoreCheckboxPanel.Location = New Point(21, 143)
        ChoreCheckboxPanel.Name = "ChoreCheckboxPanel"
        ChoreCheckboxPanel.Size = New Size(287, 158)
        ChoreCheckboxPanel.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(21, 312)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 18)
        Label2.TabIndex = 7
        Label2.Text = "User B:"
        ' 
        ' Roommate1
        ' 
        Roommate1.AutoSize = True
        Roommate1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Roommate1.Location = New Point(21, 122)
        Roommate1.Name = "Roommate1"
        Roommate1.Size = New Size(34, 18)
        Roommate1.TabIndex = 7
        Roommate1.Text = "Me:"
        ' 
        ' AddChoreBtn
        ' 
        AddChoreBtn.Anchor = AnchorStyles.None
        AddChoreBtn.BackColor = Color.Transparent
        AddChoreBtn.FlatAppearance.BorderSize = 0
        AddChoreBtn.FlatStyle = FlatStyle.Flat
        AddChoreBtn.Font = New Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        AddChoreBtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AddChoreBtn.Location = New Point(270, 82)
        AddChoreBtn.Name = "AddChoreBtn"
        AddChoreBtn.Size = New Size(38, 40)
        AddChoreBtn.TabIndex = 6
        AddChoreBtn.Text = "+"
        AddChoreBtn.UseVisualStyleBackColor = False
        ' 
        ' HouseholdName
        ' 
        HouseholdName.AutoSize = True
        HouseholdName.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        HouseholdName.Location = New Point(21, 66)
        HouseholdName.Name = "HouseholdName"
        HouseholdName.Size = New Size(78, 15)
        HouseholdName.TabIndex = 5
        HouseholdName.Text = "HouseName"
        ' 
        ' DateLabel
        ' 
        DateLabel.AutoSize = True
        DateLabel.BackColor = Color.Transparent
        DateLabel.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        DateLabel.ForeColor = Color.Black
        DateLabel.Location = New Point(21, 82)
        DateLabel.Margin = New Padding(0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New Size(179, 24)
        DateLabel.TabIndex = 0
        DateLabel.Text = "Today: Tue, Nov 7"
        DateLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' MenuPanel
        ' 
        MenuPanel.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        MenuPanel.Controls.Add(ExpenseSummaryBtn)
        MenuPanel.Controls.Add(ExpensesBtn)
        MenuPanel.Controls.Add(CompletedBtn)
        MenuPanel.Controls.Add(TodoBtn)
        MenuPanel.Location = New Point(102, 549)
        MenuPanel.Name = "MenuPanel"
        MenuPanel.Size = New Size(345, 65)
        MenuPanel.TabIndex = 4
        ' 
        ' ExpenseSummaryBtn
        ' 
        ExpenseSummaryBtn.Anchor = AnchorStyles.None
        ExpenseSummaryBtn.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        ExpenseSummaryBtn.BackgroundImage = My.Resources.Resources.expense_summary_icon
        ExpenseSummaryBtn.BackgroundImageLayout = ImageLayout.Zoom
        ExpenseSummaryBtn.Enabled = False
        ExpenseSummaryBtn.FlatAppearance.BorderSize = 0
        ExpenseSummaryBtn.FlatStyle = FlatStyle.Flat
        ExpenseSummaryBtn.Location = New Point(244, 0)
        ExpenseSummaryBtn.Margin = New Padding(0)
        ExpenseSummaryBtn.Name = "ExpenseSummaryBtn"
        ExpenseSummaryBtn.Padding = New Padding(1)
        ExpenseSummaryBtn.Size = New Size(101, 65)
        ExpenseSummaryBtn.TabIndex = 7
        ExpenseSummaryBtn.UseVisualStyleBackColor = False
        ' 
        ' ExpensesBtn
        ' 
        ExpensesBtn.Anchor = AnchorStyles.None
        ExpensesBtn.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        ExpensesBtn.BackgroundImage = My.Resources.Resources.expenses_icon
        ExpensesBtn.BackgroundImageLayout = ImageLayout.Zoom
        ExpensesBtn.Enabled = False
        ExpensesBtn.FlatAppearance.BorderSize = 0
        ExpensesBtn.FlatStyle = FlatStyle.Flat
        ExpensesBtn.Location = New Point(172, 0)
        ExpensesBtn.Margin = New Padding(0)
        ExpensesBtn.Name = "ExpensesBtn"
        ExpensesBtn.Padding = New Padding(1)
        ExpensesBtn.Size = New Size(89, 65)
        ExpensesBtn.TabIndex = 7
        ExpensesBtn.UseVisualStyleBackColor = False
        ' 
        ' CompletedBtn
        ' 
        CompletedBtn.Anchor = AnchorStyles.None
        CompletedBtn.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        CompletedBtn.BackgroundImage = My.Resources.Resources.completed_icon
        CompletedBtn.BackgroundImageLayout = ImageLayout.Zoom
        CompletedBtn.Enabled = False
        CompletedBtn.FlatAppearance.BorderSize = 0
        CompletedBtn.FlatStyle = FlatStyle.Flat
        CompletedBtn.Location = New Point(83, 0)
        CompletedBtn.Margin = New Padding(0)
        CompletedBtn.Name = "CompletedBtn"
        CompletedBtn.Padding = New Padding(1)
        CompletedBtn.Size = New Size(89, 65)
        CompletedBtn.TabIndex = 6
        CompletedBtn.UseVisualStyleBackColor = False
        ' 
        ' TodoBtn
        ' 
        TodoBtn.Anchor = AnchorStyles.None
        TodoBtn.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        TodoBtn.BackgroundImage = My.Resources.Resources.to_do_icon
        TodoBtn.BackgroundImageLayout = ImageLayout.Zoom
        TodoBtn.Enabled = False
        TodoBtn.FlatAppearance.BorderSize = 0
        TodoBtn.FlatStyle = FlatStyle.Flat
        TodoBtn.Location = New Point(0, 0)
        TodoBtn.Margin = New Padding(0)
        TodoBtn.Name = "TodoBtn"
        TodoBtn.Padding = New Padding(1)
        TodoBtn.Size = New Size(83, 65)
        TodoBtn.TabIndex = 5
        TodoBtn.UseVisualStyleBackColor = False
        ' 
        ' UserB
        ' 
        UserB.BackColor = Color.White
        UserB.ForeColor = Color.Black
        UserB.Location = New Point(4, 27)
        UserB.Name = "UserB"
        UserB.Padding = New Padding(3)
        UserB.Size = New Size(545, 698)
        UserB.TabIndex = 1
        UserB.Text = "User B"
        ' 
        ' AddHouseholdBtn
        ' 
        AddHouseholdBtn.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        AddHouseholdBtn.BackgroundImage = My.Resources.Resources.icons8_home_100
        AddHouseholdBtn.BackgroundImageLayout = ImageLayout.Zoom
        AddHouseholdBtn.FlatAppearance.BorderColor = Color.Black
        AddHouseholdBtn.FlatAppearance.BorderSize = 0
        AddHouseholdBtn.FlatStyle = FlatStyle.Flat
        AddHouseholdBtn.Location = New Point(109, 215)
        AddHouseholdBtn.Name = "AddHouseholdBtn"
        AddHouseholdBtn.Size = New Size(103, 88)
        AddHouseholdBtn.TabIndex = 1
        AddHouseholdBtn.TextImageRelation = TextImageRelation.ImageAboveText
        AddHouseholdBtn.UseVisualStyleBackColor = False
        ' 
        ' AddHouseholdPanel
        ' 
        AddHouseholdPanel.BackColor = Color.Transparent
        AddHouseholdPanel.Controls.Add(AddHouseholdBtn)
        AddHouseholdPanel.Location = New Point(567, 78)
        AddHouseholdPanel.Margin = New Padding(0)
        AddHouseholdPanel.Name = "AddHouseholdPanel"
        AddHouseholdPanel.Size = New Size(345, 507)
        AddHouseholdPanel.TabIndex = 5
        ' 
        ' Roomies
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1080, 781)
        Controls.Add(AddHouseholdPanel)
        Controls.Add(TabControl1)
        DoubleBuffered = True
        Name = "Roomies"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Roomies"
        TabControl1.ResumeLayout(False)
        UserA.ResumeLayout(False)
        TodoViewPanel.ResumeLayout(False)
        TodoViewPanel.PerformLayout()
        MenuPanel.ResumeLayout(False)
        AddHouseholdPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents UserA As TabPage
    Friend WithEvents TodoViewPanel As Panel
    Friend WithEvents DateLabel As Label
    Friend WithEvents AddHouseholdBtn As Button
    Friend WithEvents UserB As TabPage
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents TodoBtn As Button
    Friend WithEvents ExpenseSummaryBtn As Button
    Friend WithEvents ExpensesBtn As Button
    Friend WithEvents CompletedBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AddChoreBtn As Button
    Friend WithEvents HouseholdName As Label
    Friend WithEvents Roommate1 As Label
    Friend WithEvents AddHouseholdPanel As Panel
    Friend WithEvents ChoreCheckboxPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
