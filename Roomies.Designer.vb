<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Roomies
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        BottomToolStripPanel = New ToolStripPanel()
        TopToolStripPanel = New ToolStripPanel()
        RightToolStripPanel = New ToolStripPanel()
        LeftToolStripPanel = New ToolStripPanel()
        ContentPanel = New ToolStripContentPanel()
        TabControl1 = New TabControl()
        Bob = New TabPage()
        TodoViewPanel = New Panel()
        User2ChoreCheckboxPanel = New Panel()
        User1ChoreCheckboxPanel = New Panel()
        Alice = New Label()
        Roommate1 = New Label()
        AddChoreBtn = New Button()
        HouseholdName = New Label()
        DateLabel = New Label()
        MenuPanel = New Panel()
        ExpenseSummaryBtn = New Button()
        ExpensesBtn = New Button()
        CompletedBtn = New Button()
        TodoBtn = New Button()
        AddHouseholdPanel = New Panel()
        AddHouseholdBtn = New Button()
        UserB = New TabPage()
        ToDoViewPanelAlice = New Panel()
        AliceAddChoreBtn = New Button()
        AliceBobTodoPanel = New Panel()
        AliceMeTodoboxPanel = New Panel()
        AliceBobLabel = New Label()
        Label2 = New Label()
        AliceHouseLabel = New Label()
        AliceDateLabel = New Label()
        AliceMenuPanel = New Panel()
        SummaryBtnAlice = New Button()
        ExpenseBtnAlice = New Button()
        CompletedBtnAlice = New Button()
        ToDoBtnAlice = New Button()
        CompletedPerspective = New Panel()
        CompletedChoreBobPanel = New Panel()
        CompletedLabel1 = New Label()
        Label4 = New Label()
        CompletedDateLabelBob = New Label()
        CompletedPerspective2 = New Panel()
        CompletedChoreAlicePanel = New Panel()
        Label1 = New Label()
        Label3 = New Label()
        CompletedDateLabelAlice = New Label()
        CompletedChoreAliceDate = New Label()
        CompletedBobPerspective = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        CompletedAliceLabel2 = New Label()
        CompletedBobLabel2 = New Label()
        Button7 = New Button()
        Label8 = New Label()
        CompletedChoreBobDate = New Label()
        Label6 = New Label()
        TabControl1.SuspendLayout()
        Bob.SuspendLayout()
        TodoViewPanel.SuspendLayout()
        MenuPanel.SuspendLayout()
        AddHouseholdPanel.SuspendLayout()
        UserB.SuspendLayout()
        ToDoViewPanelAlice.SuspendLayout()
        AliceMenuPanel.SuspendLayout()
        CompletedPerspective.SuspendLayout()
        CompletedPerspective2.SuspendLayout()
        CompletedBobPerspective.SuspendLayout()
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
        TabControl1.Controls.Add(Bob)
        TabControl1.Controls.Add(UserB)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Margin = New Padding(0)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(0, 0)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(584, 798)
        TabControl1.TabIndex = 2
        ' 
        ' Bob
        ' 
        Bob.BackColor = Color.Silver
        Bob.BackgroundImage = My.Resources.Resources.iphone5
        Bob.BackgroundImageLayout = ImageLayout.Zoom
        Bob.Controls.Add(TodoViewPanel)
        Bob.Controls.Add(MenuPanel)
        Bob.Controls.Add(AddHouseholdPanel)
        Bob.ForeColor = Color.Black
        Bob.Location = New Point(4, 27)
        Bob.Name = "Bob"
        Bob.Padding = New Padding(3)
        Bob.Size = New Size(576, 767)
        Bob.TabIndex = 0
        Bob.Text = "Bob"
        ' 
        ' TodoViewPanel
        ' 
        TodoViewPanel.BackColor = Color.Transparent
        TodoViewPanel.Controls.Add(User2ChoreCheckboxPanel)
        TodoViewPanel.Controls.Add(User1ChoreCheckboxPanel)
        TodoViewPanel.Controls.Add(Alice)
        TodoViewPanel.Controls.Add(Roommate1)
        TodoViewPanel.Controls.Add(AddChoreBtn)
        TodoViewPanel.Controls.Add(HouseholdName)
        TodoViewPanel.Controls.Add(DateLabel)
        TodoViewPanel.Location = New Point(123, 92)
        TodoViewPanel.Margin = New Padding(0)
        TodoViewPanel.Name = "TodoViewPanel"
        TodoViewPanel.Size = New Size(330, 520)
        TodoViewPanel.TabIndex = 4
        ' 
        ' User2ChoreCheckboxPanel
        ' 
        User2ChoreCheckboxPanel.AutoScroll = True
        User2ChoreCheckboxPanel.Location = New Point(12, 234)
        User2ChoreCheckboxPanel.Margin = New Padding(3, 2, 3, 2)
        User2ChoreCheckboxPanel.Name = "User2ChoreCheckboxPanel"
        User2ChoreCheckboxPanel.Size = New Size(288, 268)
        User2ChoreCheckboxPanel.TabIndex = 8
        ' 
        ' User1ChoreCheckboxPanel
        ' 
        User1ChoreCheckboxPanel.AutoScroll = True
        User1ChoreCheckboxPanel.Location = New Point(12, 81)
        User1ChoreCheckboxPanel.Margin = New Padding(3, 2, 3, 2)
        User1ChoreCheckboxPanel.Name = "User1ChoreCheckboxPanel"
        User1ChoreCheckboxPanel.Size = New Size(288, 129)
        User1ChoreCheckboxPanel.TabIndex = 8
        ' 
        ' Alice
        ' 
        Alice.AutoSize = True
        Alice.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Alice.Location = New Point(12, 214)
        Alice.Name = "Alice"
        Alice.Size = New Size(43, 18)
        Alice.TabIndex = 7
        Alice.Text = "Alice"
        ' 
        ' Roommate1
        ' 
        Roommate1.AutoSize = True
        Roommate1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Roommate1.Location = New Point(12, 65)
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
        AddChoreBtn.Location = New Point(213, 6)
        AddChoreBtn.Margin = New Padding(3, 2, 3, 2)
        AddChoreBtn.Name = "AddChoreBtn"
        AddChoreBtn.Size = New Size(41, 47)
        AddChoreBtn.TabIndex = 6
        AddChoreBtn.Text = "+"
        AddChoreBtn.UseVisualStyleBackColor = False
        ' 
        ' HouseholdName
        ' 
        HouseholdName.AutoSize = True
        HouseholdName.Font = New Font("Arial", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        HouseholdName.Location = New Point(12, 44)
        HouseholdName.Name = "HouseholdName"
        HouseholdName.Size = New Size(46, 15)
        HouseholdName.TabIndex = 5
        HouseholdName.Text = "LeSpot"
        ' 
        ' DateLabel
        ' 
        DateLabel.AutoSize = True
        DateLabel.BackColor = Color.Transparent
        DateLabel.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        DateLabel.ForeColor = Color.Black
        DateLabel.Location = New Point(10, 18)
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
        MenuPanel.Location = New Point(123, 615)
        MenuPanel.Name = "MenuPanel"
        MenuPanel.Size = New Size(330, 65)
        MenuPanel.TabIndex = 4
        ' 
        ' ExpenseSummaryBtn
        ' 
        ExpenseSummaryBtn.Anchor = AnchorStyles.None
        ExpenseSummaryBtn.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        ExpenseSummaryBtn.BackgroundImage = My.Resources.Resources.expense_summary_icon
        ExpenseSummaryBtn.BackgroundImageLayout = ImageLayout.Zoom
        ExpenseSummaryBtn.FlatAppearance.BorderSize = 0
        ExpenseSummaryBtn.FlatStyle = FlatStyle.Flat
        ExpenseSummaryBtn.Location = New Point(237, 3)
        ExpenseSummaryBtn.Margin = New Padding(0)
        ExpenseSummaryBtn.Name = "ExpenseSummaryBtn"
        ExpenseSummaryBtn.Padding = New Padding(1)
        ExpenseSummaryBtn.Size = New Size(93, 62)
        ExpenseSummaryBtn.TabIndex = 7
        ExpenseSummaryBtn.UseVisualStyleBackColor = False
        ' 
        ' ExpensesBtn
        ' 
        ExpensesBtn.Anchor = AnchorStyles.None
        ExpensesBtn.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        ExpensesBtn.BackgroundImage = My.Resources.Resources.expenses_icon
        ExpensesBtn.BackgroundImageLayout = ImageLayout.Zoom
        ExpensesBtn.FlatAppearance.BorderSize = 0
        ExpensesBtn.FlatStyle = FlatStyle.Flat
        ExpensesBtn.Location = New Point(165, 3)
        ExpensesBtn.Margin = New Padding(0)
        ExpensesBtn.Name = "ExpensesBtn"
        ExpensesBtn.Padding = New Padding(1)
        ExpensesBtn.Size = New Size(80, 62)
        ExpensesBtn.TabIndex = 7
        ExpensesBtn.UseVisualStyleBackColor = False
        ' 
        ' CompletedBtn
        ' 
        CompletedBtn.Anchor = AnchorStyles.None
        CompletedBtn.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        CompletedBtn.BackgroundImage = My.Resources.Resources.completed_icon
        CompletedBtn.BackgroundImageLayout = ImageLayout.Zoom
        CompletedBtn.FlatAppearance.BorderSize = 0
        CompletedBtn.FlatStyle = FlatStyle.Flat
        CompletedBtn.Location = New Point(76, 0)
        CompletedBtn.Margin = New Padding(0)
        CompletedBtn.Name = "CompletedBtn"
        CompletedBtn.Padding = New Padding(1)
        CompletedBtn.Size = New Size(80, 65)
        CompletedBtn.TabIndex = 6
        CompletedBtn.UseVisualStyleBackColor = False
        ' 
        ' TodoBtn
        ' 
        TodoBtn.Anchor = AnchorStyles.None
        TodoBtn.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        TodoBtn.BackgroundImage = My.Resources.Resources.to_do_icon
        TodoBtn.BackgroundImageLayout = ImageLayout.Zoom
        TodoBtn.FlatAppearance.BorderSize = 0
        TodoBtn.FlatStyle = FlatStyle.Flat
        TodoBtn.Location = New Point(0, 3)
        TodoBtn.Margin = New Padding(0)
        TodoBtn.Name = "TodoBtn"
        TodoBtn.Padding = New Padding(1)
        TodoBtn.Size = New Size(80, 62)
        TodoBtn.TabIndex = 5
        TodoBtn.UseVisualStyleBackColor = False
        ' 
        ' AddHouseholdPanel
        ' 
        AddHouseholdPanel.BackColor = Color.Transparent
        AddHouseholdPanel.Controls.Add(AddHouseholdBtn)
        AddHouseholdPanel.Location = New Point(123, 92)
        AddHouseholdPanel.Margin = New Padding(0)
        AddHouseholdPanel.Name = "AddHouseholdPanel"
        AddHouseholdPanel.Size = New Size(171, 340)
        AddHouseholdPanel.TabIndex = 5
        AddHouseholdPanel.Visible = False
        ' 
        ' AddHouseholdBtn
        ' 
        AddHouseholdBtn.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        AddHouseholdBtn.BackgroundImage = My.Resources.Resources.icons8_home_100
        AddHouseholdBtn.BackgroundImageLayout = ImageLayout.Zoom
        AddHouseholdBtn.FlatAppearance.BorderColor = Color.Black
        AddHouseholdBtn.FlatAppearance.BorderSize = 0
        AddHouseholdBtn.FlatStyle = FlatStyle.Flat
        AddHouseholdBtn.Location = New Point(95, 161)
        AddHouseholdBtn.Margin = New Padding(3, 2, 3, 2)
        AddHouseholdBtn.Name = "AddHouseholdBtn"
        AddHouseholdBtn.Size = New Size(90, 66)
        AddHouseholdBtn.TabIndex = 1
        AddHouseholdBtn.TextImageRelation = TextImageRelation.ImageAboveText
        AddHouseholdBtn.UseVisualStyleBackColor = False
        ' 
        ' UserB
        ' 
        UserB.BackColor = Color.Silver
        UserB.BackgroundImage = My.Resources.Resources.iphone5
        UserB.BackgroundImageLayout = ImageLayout.Zoom
        UserB.Controls.Add(ToDoViewPanelAlice)
        UserB.Controls.Add(AliceMenuPanel)
        UserB.ForeColor = Color.Black
        UserB.Location = New Point(4, 27)
        UserB.Name = "UserB"
        UserB.Padding = New Padding(3)
        UserB.Size = New Size(576, 767)
        UserB.TabIndex = 1
        UserB.Text = "Alice"
        ' 
        ' ToDoViewPanelAlice
        ' 
        ToDoViewPanelAlice.BackColor = Color.Transparent
        ToDoViewPanelAlice.Controls.Add(AliceAddChoreBtn)
        ToDoViewPanelAlice.Controls.Add(AliceBobTodoPanel)
        ToDoViewPanelAlice.Controls.Add(AliceMeTodoboxPanel)
        ToDoViewPanelAlice.Controls.Add(AliceBobLabel)
        ToDoViewPanelAlice.Controls.Add(Label2)
        ToDoViewPanelAlice.Controls.Add(AliceHouseLabel)
        ToDoViewPanelAlice.Controls.Add(AliceDateLabel)
        ToDoViewPanelAlice.Location = New Point(123, 88)
        ToDoViewPanelAlice.Margin = New Padding(0)
        ToDoViewPanelAlice.Name = "ToDoViewPanelAlice"
        ToDoViewPanelAlice.Size = New Size(330, 525)
        ToDoViewPanelAlice.TabIndex = 5
        ' 
        ' AliceAddChoreBtn
        ' 
        AliceAddChoreBtn.Anchor = AnchorStyles.None
        AliceAddChoreBtn.BackColor = Color.Transparent
        AliceAddChoreBtn.FlatAppearance.BorderSize = 0
        AliceAddChoreBtn.FlatStyle = FlatStyle.Flat
        AliceAddChoreBtn.Font = New Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        AliceAddChoreBtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AliceAddChoreBtn.Location = New Point(223, 11)
        AliceAddChoreBtn.Margin = New Padding(3, 2, 3, 2)
        AliceAddChoreBtn.Name = "AliceAddChoreBtn"
        AliceAddChoreBtn.Size = New Size(41, 47)
        AliceAddChoreBtn.TabIndex = 9
        AliceAddChoreBtn.Text = "+"
        AliceAddChoreBtn.UseVisualStyleBackColor = False
        ' 
        ' AliceBobTodoPanel
        ' 
        AliceBobTodoPanel.AutoScroll = True
        AliceBobTodoPanel.Location = New Point(14, 293)
        AliceBobTodoPanel.Margin = New Padding(3, 2, 3, 2)
        AliceBobTodoPanel.Name = "AliceBobTodoPanel"
        AliceBobTodoPanel.Size = New Size(287, 213)
        AliceBobTodoPanel.TabIndex = 8
        ' 
        ' AliceMeTodoboxPanel
        ' 
        AliceMeTodoboxPanel.AutoScroll = True
        AliceMeTodoboxPanel.Location = New Point(12, 77)
        AliceMeTodoboxPanel.Margin = New Padding(3, 2, 3, 2)
        AliceMeTodoboxPanel.Name = "AliceMeTodoboxPanel"
        AliceMeTodoboxPanel.Size = New Size(289, 194)
        AliceMeTodoboxPanel.TabIndex = 8
        ' 
        ' AliceBobLabel
        ' 
        AliceBobLabel.AutoSize = True
        AliceBobLabel.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        AliceBobLabel.Location = New Point(14, 273)
        AliceBobLabel.Name = "AliceBobLabel"
        AliceBobLabel.Size = New Size(37, 18)
        AliceBobLabel.TabIndex = 7
        AliceBobLabel.Text = "Bob"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(10, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 18)
        Label2.TabIndex = 7
        Label2.Text = "Me:"
        ' 
        ' AliceHouseLabel
        ' 
        AliceHouseLabel.AutoSize = True
        AliceHouseLabel.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AliceHouseLabel.Location = New Point(14, 42)
        AliceHouseLabel.Name = "AliceHouseLabel"
        AliceHouseLabel.Size = New Size(46, 15)
        AliceHouseLabel.TabIndex = 5
        AliceHouseLabel.Text = "LeSpot"
        ' 
        ' AliceDateLabel
        ' 
        AliceDateLabel.AutoSize = True
        AliceDateLabel.BackColor = Color.Transparent
        AliceDateLabel.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        AliceDateLabel.ForeColor = Color.Black
        AliceDateLabel.Location = New Point(10, 18)
        AliceDateLabel.Margin = New Padding(0)
        AliceDateLabel.Name = "AliceDateLabel"
        AliceDateLabel.Size = New Size(179, 24)
        AliceDateLabel.TabIndex = 0
        AliceDateLabel.Text = "Today: Tue, Nov 7"
        AliceDateLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' AliceMenuPanel
        ' 
        AliceMenuPanel.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        AliceMenuPanel.Controls.Add(SummaryBtnAlice)
        AliceMenuPanel.Controls.Add(ExpenseBtnAlice)
        AliceMenuPanel.Controls.Add(CompletedBtnAlice)
        AliceMenuPanel.Controls.Add(ToDoBtnAlice)
        AliceMenuPanel.Location = New Point(123, 615)
        AliceMenuPanel.Margin = New Padding(3, 2, 3, 2)
        AliceMenuPanel.Name = "AliceMenuPanel"
        AliceMenuPanel.Size = New Size(330, 65)
        AliceMenuPanel.TabIndex = 6
        ' 
        ' SummaryBtnAlice
        ' 
        SummaryBtnAlice.Anchor = AnchorStyles.None
        SummaryBtnAlice.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        SummaryBtnAlice.BackgroundImage = My.Resources.Resources.expense_summary_icon
        SummaryBtnAlice.BackgroundImageLayout = ImageLayout.Zoom
        SummaryBtnAlice.FlatAppearance.BorderSize = 0
        SummaryBtnAlice.FlatStyle = FlatStyle.Flat
        SummaryBtnAlice.Location = New Point(237, 3)
        SummaryBtnAlice.Margin = New Padding(0)
        SummaryBtnAlice.Name = "SummaryBtnAlice"
        SummaryBtnAlice.Padding = New Padding(1)
        SummaryBtnAlice.Size = New Size(93, 62)
        SummaryBtnAlice.TabIndex = 7
        SummaryBtnAlice.UseVisualStyleBackColor = False
        ' 
        ' ExpenseBtnAlice
        ' 
        ExpenseBtnAlice.Anchor = AnchorStyles.None
        ExpenseBtnAlice.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        ExpenseBtnAlice.BackgroundImage = My.Resources.Resources.expenses_icon
        ExpenseBtnAlice.BackgroundImageLayout = ImageLayout.Zoom
        ExpenseBtnAlice.FlatAppearance.BorderSize = 0
        ExpenseBtnAlice.FlatStyle = FlatStyle.Flat
        ExpenseBtnAlice.Location = New Point(165, 3)
        ExpenseBtnAlice.Margin = New Padding(0)
        ExpenseBtnAlice.Name = "ExpenseBtnAlice"
        ExpenseBtnAlice.Padding = New Padding(1)
        ExpenseBtnAlice.Size = New Size(80, 62)
        ExpenseBtnAlice.TabIndex = 7
        ExpenseBtnAlice.UseVisualStyleBackColor = False
        ' 
        ' CompletedBtnAlice
        ' 
        CompletedBtnAlice.Anchor = AnchorStyles.None
        CompletedBtnAlice.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        CompletedBtnAlice.BackgroundImage = My.Resources.Resources.completed_icon
        CompletedBtnAlice.BackgroundImageLayout = ImageLayout.Zoom
        CompletedBtnAlice.FlatAppearance.BorderSize = 0
        CompletedBtnAlice.FlatStyle = FlatStyle.Flat
        CompletedBtnAlice.Location = New Point(76, 0)
        CompletedBtnAlice.Margin = New Padding(0)
        CompletedBtnAlice.Name = "CompletedBtnAlice"
        CompletedBtnAlice.Padding = New Padding(1)
        CompletedBtnAlice.Size = New Size(80, 65)
        CompletedBtnAlice.TabIndex = 6
        CompletedBtnAlice.UseVisualStyleBackColor = False
        ' 
        ' ToDoBtnAlice
        ' 
        ToDoBtnAlice.Anchor = AnchorStyles.None
        ToDoBtnAlice.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        ToDoBtnAlice.BackgroundImage = My.Resources.Resources.to_do_icon
        ToDoBtnAlice.BackgroundImageLayout = ImageLayout.Zoom
        ToDoBtnAlice.FlatAppearance.BorderSize = 0
        ToDoBtnAlice.FlatStyle = FlatStyle.Flat
        ToDoBtnAlice.Location = New Point(0, 3)
        ToDoBtnAlice.Margin = New Padding(0)
        ToDoBtnAlice.Name = "ToDoBtnAlice"
        ToDoBtnAlice.Padding = New Padding(1)
        ToDoBtnAlice.Size = New Size(80, 62)
        ToDoBtnAlice.TabIndex = 5
        ToDoBtnAlice.UseVisualStyleBackColor = False
        ' 
        ' CompletedPerspective
        ' 
        CompletedPerspective.BackColor = Color.Transparent
        CompletedPerspective.Controls.Add(CompletedChoreBobPanel)
        CompletedPerspective.Controls.Add(CompletedLabel1)
        CompletedPerspective.Controls.Add(Label4)
        CompletedPerspective.Controls.Add(CompletedDateLabelBob)
        CompletedPerspective.Location = New Point(1024, 95)
        CompletedPerspective.Margin = New Padding(0)
        CompletedPerspective.Name = "CompletedPerspective"
        CompletedPerspective.Size = New Size(330, 526)
        CompletedPerspective.TabIndex = 6
        ' 
        ' CompletedChoreBobPanel
        ' 
        CompletedChoreBobPanel.Enabled = False
        CompletedChoreBobPanel.Location = New Point(12, 118)
        CompletedChoreBobPanel.Margin = New Padding(3, 2, 3, 2)
        CompletedChoreBobPanel.Name = "CompletedChoreBobPanel"
        CompletedChoreBobPanel.Size = New Size(264, 262)
        CompletedChoreBobPanel.TabIndex = 8
        ' 
        ' CompletedLabel1
        ' 
        CompletedLabel1.AutoSize = True
        CompletedLabel1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedLabel1.Location = New Point(10, 100)
        CompletedLabel1.Name = "CompletedLabel1"
        CompletedLabel1.Size = New Size(144, 18)
        CompletedLabel1.TabIndex = 7
        CompletedLabel1.Text = "Completed Chores:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(10, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 5
        Label4.Text = "LeSpot"
        ' 
        ' CompletedDateLabelBob
        ' 
        CompletedDateLabelBob.AutoSize = True
        CompletedDateLabelBob.BackColor = Color.Transparent
        CompletedDateLabelBob.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedDateLabelBob.ForeColor = Color.Black
        CompletedDateLabelBob.Location = New Point(10, 72)
        CompletedDateLabelBob.Margin = New Padding(0)
        CompletedDateLabelBob.Name = "CompletedDateLabelBob"
        CompletedDateLabelBob.Size = New Size(179, 24)
        CompletedDateLabelBob.TabIndex = 0
        CompletedDateLabelBob.Text = "Today: Tue, Nov 7"
        CompletedDateLabelBob.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CompletedPerspective2
        ' 
        CompletedPerspective2.BackColor = Color.Transparent
        CompletedPerspective2.Controls.Add(CompletedChoreAlicePanel)
        CompletedPerspective2.Controls.Add(Label1)
        CompletedPerspective2.Controls.Add(Label3)
        CompletedPerspective2.Controls.Add(CompletedDateLabelAlice)
        CompletedPerspective2.Location = New Point(673, 95)
        CompletedPerspective2.Margin = New Padding(0)
        CompletedPerspective2.Name = "CompletedPerspective2"
        CompletedPerspective2.Size = New Size(306, 484)
        CompletedPerspective2.TabIndex = 7
        ' 
        ' CompletedChoreAlicePanel
        ' 
        CompletedChoreAlicePanel.Enabled = False
        CompletedChoreAlicePanel.Location = New Point(12, 110)
        CompletedChoreAlicePanel.Margin = New Padding(3, 2, 3, 2)
        CompletedChoreAlicePanel.Name = "CompletedChoreAlicePanel"
        CompletedChoreAlicePanel.Size = New Size(264, 270)
        CompletedChoreAlicePanel.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(11, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 18)
        Label1.TabIndex = 7
        Label1.Text = "Completed Chores:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(10, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 5
        Label3.Text = "LeSpot"
        ' 
        ' CompletedDateLabelAlice
        ' 
        CompletedDateLabelAlice.AutoSize = True
        CompletedDateLabelAlice.BackColor = Color.Transparent
        CompletedDateLabelAlice.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedDateLabelAlice.ForeColor = Color.Black
        CompletedDateLabelAlice.Location = New Point(10, 64)
        CompletedDateLabelAlice.Margin = New Padding(0)
        CompletedDateLabelAlice.Name = "CompletedDateLabelAlice"
        CompletedDateLabelAlice.Size = New Size(179, 24)
        CompletedDateLabelAlice.TabIndex = 0
        CompletedDateLabelAlice.Text = "Today: Tue, Nov 7"
        CompletedDateLabelAlice.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CompletedChoreAliceDate
        ' 
        CompletedChoreAliceDate.AutoSize = True
        CompletedChoreAliceDate.BackColor = Color.Transparent
        CompletedChoreAliceDate.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedChoreAliceDate.ForeColor = Color.Black
        CompletedChoreAliceDate.Location = New Point(14, 74)
        CompletedChoreAliceDate.Margin = New Padding(0)
        CompletedChoreAliceDate.Name = "CompletedChoreAliceDate"
        CompletedChoreAliceDate.Size = New Size(179, 24)
        CompletedChoreAliceDate.TabIndex = 0
        CompletedChoreAliceDate.Text = "Today: Tue, Nov 7"
        CompletedChoreAliceDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CompletedBobPerspective
        ' 
        CompletedBobPerspective.BackColor = Color.Transparent
        CompletedBobPerspective.Controls.Add(Panel6)
        CompletedBobPerspective.Controls.Add(Panel7)
        CompletedBobPerspective.Controls.Add(CompletedAliceLabel2)
        CompletedBobPerspective.Controls.Add(CompletedBobLabel2)
        CompletedBobPerspective.Controls.Add(Button7)
        CompletedBobPerspective.Controls.Add(Label8)
        CompletedBobPerspective.Controls.Add(CompletedChoreBobDate)
        CompletedBobPerspective.Location = New Point(1464, 105)
        CompletedBobPerspective.Margin = New Padding(0)
        CompletedBobPerspective.Name = "CompletedBobPerspective"
        CompletedBobPerspective.Size = New Size(330, 526)
        CompletedBobPerspective.TabIndex = 7
        ' 
        ' Panel6
        ' 
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(200, 100)
        Panel6.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(200, 100)
        Panel7.TabIndex = 1
        ' 
        ' CompletedAliceLabel2
        ' 
        CompletedAliceLabel2.Location = New Point(0, 0)
        CompletedAliceLabel2.Name = "CompletedAliceLabel2"
        CompletedAliceLabel2.Size = New Size(100, 23)
        CompletedAliceLabel2.TabIndex = 2
        ' 
        ' CompletedBobLabel2
        ' 
        CompletedBobLabel2.Location = New Point(0, 0)
        CompletedBobLabel2.Name = "CompletedBobLabel2"
        CompletedBobLabel2.Size = New Size(100, 23)
        CompletedBobLabel2.TabIndex = 3
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(0, 0)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 23)
        Button7.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 5
        ' 
        ' CompletedChoreBobDate
        ' 
        CompletedChoreBobDate.AutoSize = True
        CompletedChoreBobDate.BackColor = Color.Transparent
        CompletedChoreBobDate.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedChoreBobDate.ForeColor = Color.Black
        CompletedChoreBobDate.Location = New Point(16, 99)
        CompletedChoreBobDate.Margin = New Padding(0)
        CompletedChoreBobDate.Name = "CompletedChoreBobDate"
        CompletedChoreBobDate.Size = New Size(179, 24)
        CompletedChoreBobDate.TabIndex = 0
        CompletedChoreBobDate.Text = "Today: Tue, Nov 7"
        CompletedChoreBobDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(673, 69)
        Label6.Name = "Label6"
        Label6.RightToLeft = RightToLeft.No
        Label6.Size = New Size(33, 15)
        Label6.TabIndex = 8
        Label6.Text = "Alice"
        ' 
        ' Roomies
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1416, 820)
        Controls.Add(Label6)
        Controls.Add(CompletedPerspective2)
        Controls.Add(CompletedPerspective)
        Controls.Add(TabControl1)
        DoubleBuffered = True
        Name = "Roomies"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Roomies"
        TabControl1.ResumeLayout(False)
        Bob.ResumeLayout(False)
        TodoViewPanel.ResumeLayout(False)
        TodoViewPanel.PerformLayout()
        MenuPanel.ResumeLayout(False)
        AddHouseholdPanel.ResumeLayout(False)
        UserB.ResumeLayout(False)
        ToDoViewPanelAlice.ResumeLayout(False)
        ToDoViewPanelAlice.PerformLayout()
        AliceMenuPanel.ResumeLayout(False)
        CompletedPerspective.ResumeLayout(False)
        CompletedPerspective.PerformLayout()
        CompletedPerspective2.ResumeLayout(False)
        CompletedPerspective2.PerformLayout()
        CompletedBobPerspective.ResumeLayout(False)
        CompletedBobPerspective.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Bob As TabPage
    Friend WithEvents TodoViewPanel As Panel
    Friend WithEvents DateLabel As Label
    Friend WithEvents AddHouseholdBtn As Button
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents TodoBtn As Button
    Friend WithEvents ExpenseSummaryBtn As Button
    Friend WithEvents ExpensesBtn As Button
    Friend WithEvents CompletedBtn As Button
    Friend WithEvents AddChoreBtn As Button
    Friend WithEvents HouseholdName As Label
    Friend WithEvents Roommate1 As Label
    Friend WithEvents AddHouseholdPanel As Panel
    Friend WithEvents User1ChoreCheckboxPanel As Panel
    Friend WithEvents Alice As Label
    Friend WithEvents User2ChoreCheckboxPanel As Panel
    Friend WithEvents UserB As TabPage
    Friend WithEvents ToDoViewPanelAlice As Panel
    Friend WithEvents AliceBobTodoPanel As Panel
    Friend WithEvents AliceMeTodoboxPanel As Panel
    Friend WithEvents AliceBobLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AliceHouseLabel As Label
    Friend WithEvents AliceDateLabel As Label
    Friend WithEvents AliceMenuPanel As Panel
    Friend WithEvents SummaryBtnAlice As Button
    Friend WithEvents ExpenseBtnAlice As Button
    Friend WithEvents CompletedBtnAlice As Button
    Friend WithEvents ToDoBtnAlice As Button
    Friend WithEvents AliceAddChoreBtn As Button
    Friend WithEvents CompletedPerspective As Panel
    Friend WithEvents CompletedChoreBobPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CompletedBobPerspective As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents CompletedAliceLabel2 As Label
    Friend WithEvents CompletedBobLabel2 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents CompletedChoreBobDate As Label
    Friend WithEvents CompletedDateLabelBob As Label
    Friend WithEvents CompletedLabel1 As Label
    Friend WithEvents CompletedPerspective2 As Panel
    Friend WithEvents CompletedChoreAlicePanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CompletedDateLabelAlice As Label
    Friend WithEvents CompletedChoreAliceDate As Label
    Friend WithEvents Label6 As Label
End Class
