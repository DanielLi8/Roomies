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
        components = New ComponentModel.Container()
        BottomToolStripPanel = New ToolStripPanel()
        TopToolStripPanel = New ToolStripPanel()
        RightToolStripPanel = New ToolStripPanel()
        LeftToolStripPanel = New ToolStripPanel()
        ContentPanel = New ToolStripContentPanel()
        TabControl1 = New TabControl()
        Bob = New TabPage()
        TodoViewPanel = New Panel()
        CompletedPerspective = New Panel()
        CompletedChoreBobPanel = New Panel()
        CompletedLabel1 = New Label()
        Label4 = New Label()
        CompletedDateLabelBob = New Label()
        User2ChoreCheckboxPanel = New Panel()
        User1ChoreCheckboxPanel = New Panel()
        Alice = New Label()
        Roommate1 = New Label()
        AddChoreBtn = New Button()
        HouseholdName = New Label()
        DateLabel = New Label()
        BobMasterPanel = New Panel()
        MenuPanel = New Panel()
        ExpenseSummaryBtn = New Button()
        ExpensesBtn = New Button()
        CompletedBtn = New Button()
        TodoBtn = New Button()
        AddHouseholdPanel = New Panel()
        AddHouseholdBtn = New Button()
        UserB = New TabPage()
        ToDoViewPanelAlice = New Panel()
        CompletedPerspective2 = New Panel()
        CompletedChoreAlicePanel = New Panel()
        Label1 = New Label()
        Label3 = New Label()
        CompletedDateLabelAlice = New Label()
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
        AliceMasterPanel = New Panel()
        ExpensesPanel = New Panel()
        ESummaryLabel = New Label()
        EPersonalExpensesPanel = New Panel()
        EPersonalLabel = New Label()
        ESharedExpensesPanel = New Panel()
        ESharedExpenseLabel = New Label()
        EButton = New Button()
        EFamilyLabel = New Label()
        ETitleLabel = New Label()
        CompletedChoreAliceDate = New Label()
        CompletedBobPerspective = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        CompletedAliceLabel2 = New Label()
        CompletedBobLabel2 = New Label()
        Button7 = New Button()
        Label8 = New Label()
        CompletedChoreBobDate = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ExpensesComponent1 = New ExpensesComponent()
        Panel2 = New Panel()
        TabControl1.SuspendLayout()
        Bob.SuspendLayout()
        TodoViewPanel.SuspendLayout()
        CompletedPerspective.SuspendLayout()
        BobMasterPanel.SuspendLayout()
        MenuPanel.SuspendLayout()
        AddHouseholdPanel.SuspendLayout()
        UserB.SuspendLayout()
        ToDoViewPanelAlice.SuspendLayout()
        CompletedPerspective2.SuspendLayout()
        AliceMenuPanel.SuspendLayout()
        ExpensesPanel.SuspendLayout()
        CompletedBobPerspective.SuspendLayout()
        Panel2.SuspendLayout()
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
        TabControl1.Size = New Size(667, 1064)
        TabControl1.TabIndex = 2
        ' 
        ' Bob
        ' 
        Bob.BackColor = Color.Silver
        Bob.BackgroundImage = My.Resources.Resources.iphone5
        Bob.BackgroundImageLayout = ImageLayout.Zoom
        Bob.Controls.Add(TodoViewPanel)
        Bob.Controls.Add(BobMasterPanel)
        Bob.Controls.Add(AddHouseholdPanel)
        Bob.ForeColor = Color.Black
        Bob.Location = New Point(4, 32)
        Bob.Margin = New Padding(3, 4, 3, 4)
        Bob.Name = "Bob"
        Bob.Padding = New Padding(3, 4, 3, 4)
        Bob.Size = New Size(659, 1028)
        Bob.TabIndex = 0
        Bob.Text = "Bob"
        ' 
        ' TodoViewPanel
        ' 
        TodoViewPanel.BackColor = Color.Transparent
        TodoViewPanel.Controls.Add(CompletedPerspective)
        TodoViewPanel.Controls.Add(User2ChoreCheckboxPanel)
        TodoViewPanel.Controls.Add(User1ChoreCheckboxPanel)
        TodoViewPanel.Controls.Add(Alice)
        TodoViewPanel.Controls.Add(Roommate1)
        TodoViewPanel.Controls.Add(AddChoreBtn)
        TodoViewPanel.Controls.Add(HouseholdName)
        TodoViewPanel.Controls.Add(DateLabel)
        TodoViewPanel.Location = New Point(141, 119)
        TodoViewPanel.Margin = New Padding(0)
        TodoViewPanel.Name = "TodoViewPanel"
        TodoViewPanel.Size = New Size(377, 695)
        TodoViewPanel.TabIndex = 4
        ' 
        ' CompletedPerspective
        ' 
        CompletedPerspective.BackColor = Color.Transparent
        CompletedPerspective.Controls.Add(CompletedChoreBobPanel)
        CompletedPerspective.Controls.Add(CompletedLabel1)
        CompletedPerspective.Controls.Add(Label4)
        CompletedPerspective.Controls.Add(CompletedDateLabelBob)
        CompletedPerspective.Location = New Point(1, 3)
        CompletedPerspective.Margin = New Padding(0)
        CompletedPerspective.Name = "CompletedPerspective"
        CompletedPerspective.Size = New Size(377, 692)
        CompletedPerspective.TabIndex = 6
        CompletedPerspective.Visible = False
        ' 
        ' CompletedChoreBobPanel
        ' 
        CompletedChoreBobPanel.Enabled = False
        CompletedChoreBobPanel.Location = New Point(14, 113)
        CompletedChoreBobPanel.Name = "CompletedChoreBobPanel"
        CompletedChoreBobPanel.Size = New Size(335, 556)
        CompletedChoreBobPanel.TabIndex = 8
        ' 
        ' CompletedLabel1
        ' 
        CompletedLabel1.AutoSize = True
        CompletedLabel1.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedLabel1.Location = New Point(14, 87)
        CompletedLabel1.Name = "CompletedLabel1"
        CompletedLabel1.Size = New Size(180, 23)
        CompletedLabel1.TabIndex = 7
        CompletedLabel1.Text = "Completed Chores:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(14, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 17)
        Label4.TabIndex = 5
        Label4.Text = "LeSpot"
        ' 
        ' CompletedDateLabelBob
        ' 
        CompletedDateLabelBob.AutoSize = True
        CompletedDateLabelBob.BackColor = Color.Transparent
        CompletedDateLabelBob.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedDateLabelBob.ForeColor = Color.Black
        CompletedDateLabelBob.Location = New Point(14, 39)
        CompletedDateLabelBob.Margin = New Padding(0)
        CompletedDateLabelBob.Name = "CompletedDateLabelBob"
        CompletedDateLabelBob.Size = New Size(233, 32)
        CompletedDateLabelBob.TabIndex = 0
        CompletedDateLabelBob.Text = "Today: Tue, Nov 7"
        CompletedDateLabelBob.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' User2ChoreCheckboxPanel
        ' 
        User2ChoreCheckboxPanel.AutoScroll = True
        User2ChoreCheckboxPanel.Location = New Point(14, 387)
        User2ChoreCheckboxPanel.Name = "User2ChoreCheckboxPanel"
        User2ChoreCheckboxPanel.Size = New Size(329, 283)
        User2ChoreCheckboxPanel.TabIndex = 8
        ' 
        ' User1ChoreCheckboxPanel
        ' 
        User1ChoreCheckboxPanel.AutoScroll = True
        User1ChoreCheckboxPanel.Location = New Point(14, 108)
        User1ChoreCheckboxPanel.Name = "User1ChoreCheckboxPanel"
        User1ChoreCheckboxPanel.Size = New Size(329, 249)
        User1ChoreCheckboxPanel.TabIndex = 8
        ' 
        ' Alice
        ' 
        Alice.AutoSize = True
        Alice.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Alice.Location = New Point(14, 360)
        Alice.Name = "Alice"
        Alice.Size = New Size(52, 23)
        Alice.TabIndex = 7
        Alice.Text = "Alice"
        ' 
        ' Roommate1
        ' 
        Roommate1.AutoSize = True
        Roommate1.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Roommate1.Location = New Point(14, 87)
        Roommate1.Name = "Roommate1"
        Roommate1.Size = New Size(44, 23)
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
        AddChoreBtn.Location = New Point(255, 11)
        AddChoreBtn.Name = "AddChoreBtn"
        AddChoreBtn.Size = New Size(47, 63)
        AddChoreBtn.TabIndex = 6
        AddChoreBtn.Text = "+"
        AddChoreBtn.UseVisualStyleBackColor = False
        ' 
        ' HouseholdName
        ' 
        HouseholdName.AutoSize = True
        HouseholdName.Font = New Font("Arial", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        HouseholdName.Location = New Point(14, 59)
        HouseholdName.Name = "HouseholdName"
        HouseholdName.Size = New Size(54, 17)
        HouseholdName.TabIndex = 5
        HouseholdName.Text = "LeSpot"
        ' 
        ' DateLabel
        ' 
        DateLabel.AutoSize = True
        DateLabel.BackColor = Color.Transparent
        DateLabel.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        DateLabel.ForeColor = Color.Black
        DateLabel.Location = New Point(11, 24)
        DateLabel.Margin = New Padding(0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New Size(233, 32)
        DateLabel.TabIndex = 0
        DateLabel.Text = "Today: Tue, Nov 7"
        DateLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BobMasterPanel
        ' 
        BobMasterPanel.Controls.Add(MenuPanel)
        BobMasterPanel.Location = New Point(141, 119)
        BobMasterPanel.Margin = New Padding(3, 4, 3, 4)
        BobMasterPanel.Name = "BobMasterPanel"
        BobMasterPanel.Size = New Size(381, 781)
        BobMasterPanel.TabIndex = 0
        ' 
        ' MenuPanel
        ' 
        MenuPanel.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        MenuPanel.Controls.Add(ExpenseSummaryBtn)
        MenuPanel.Controls.Add(ExpensesBtn)
        MenuPanel.Controls.Add(CompletedBtn)
        MenuPanel.Controls.Add(TodoBtn)
        MenuPanel.Location = New Point(0, 695)
        MenuPanel.Margin = New Padding(3, 4, 3, 4)
        MenuPanel.Name = "MenuPanel"
        MenuPanel.Size = New Size(379, 87)
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
        ExpenseSummaryBtn.Location = New Point(272, 4)
        ExpenseSummaryBtn.Margin = New Padding(0)
        ExpenseSummaryBtn.Name = "ExpenseSummaryBtn"
        ExpenseSummaryBtn.Padding = New Padding(1)
        ExpenseSummaryBtn.Size = New Size(106, 83)
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
        ExpensesBtn.Location = New Point(190, 0)
        ExpensesBtn.Margin = New Padding(0)
        ExpensesBtn.Name = "ExpensesBtn"
        ExpensesBtn.Padding = New Padding(1)
        ExpensesBtn.Size = New Size(91, 87)
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
        CompletedBtn.Location = New Point(88, 0)
        CompletedBtn.Margin = New Padding(0)
        CompletedBtn.Name = "CompletedBtn"
        CompletedBtn.Padding = New Padding(1)
        CompletedBtn.Size = New Size(91, 87)
        CompletedBtn.TabIndex = 6
        CompletedBtn.UseVisualStyleBackColor = False
        ' 
        ' TodoBtn
        ' 
        TodoBtn.Anchor = AnchorStyles.None
        TodoBtn.BackColor = Color.FromArgb(CByte(62), CByte(90), CByte(60))
        TodoBtn.BackgroundImage = My.Resources.Resources.to_do_icon
        TodoBtn.BackgroundImageLayout = ImageLayout.Zoom
        TodoBtn.FlatAppearance.BorderSize = 0
        TodoBtn.FlatStyle = FlatStyle.Flat
        TodoBtn.Location = New Point(0, -4)
        TodoBtn.Margin = New Padding(0)
        TodoBtn.Name = "TodoBtn"
        TodoBtn.Padding = New Padding(1)
        TodoBtn.Size = New Size(93, 91)
        TodoBtn.TabIndex = 5
        TodoBtn.UseVisualStyleBackColor = False
        ' 
        ' AddHouseholdPanel
        ' 
        AddHouseholdPanel.BackColor = Color.Transparent
        AddHouseholdPanel.Controls.Add(AddHouseholdBtn)
        AddHouseholdPanel.Location = New Point(126, 183)
        AddHouseholdPanel.Margin = New Padding(0)
        AddHouseholdPanel.Name = "AddHouseholdPanel"
        AddHouseholdPanel.Size = New Size(195, 453)
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
        AddHouseholdBtn.Location = New Point(109, 215)
        AddHouseholdBtn.Name = "AddHouseholdBtn"
        AddHouseholdBtn.Size = New Size(103, 88)
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
        UserB.Controls.Add(AliceMasterPanel)
        UserB.ForeColor = Color.Black
        UserB.Location = New Point(4, 32)
        UserB.Margin = New Padding(3, 4, 3, 4)
        UserB.Name = "UserB"
        UserB.Padding = New Padding(3, 4, 3, 4)
        UserB.Size = New Size(659, 1028)
        UserB.TabIndex = 1
        UserB.Text = "Alice"
        ' 
        ' ToDoViewPanelAlice
        ' 
        ToDoViewPanelAlice.BackColor = Color.Transparent
        ToDoViewPanelAlice.Controls.Add(CompletedPerspective2)
        ToDoViewPanelAlice.Controls.Add(AliceAddChoreBtn)
        ToDoViewPanelAlice.Controls.Add(AliceBobTodoPanel)
        ToDoViewPanelAlice.Controls.Add(AliceMeTodoboxPanel)
        ToDoViewPanelAlice.Controls.Add(AliceBobLabel)
        ToDoViewPanelAlice.Controls.Add(Label2)
        ToDoViewPanelAlice.Controls.Add(AliceHouseLabel)
        ToDoViewPanelAlice.Controls.Add(AliceDateLabel)
        ToDoViewPanelAlice.Location = New Point(138, 119)
        ToDoViewPanelAlice.Margin = New Padding(0)
        ToDoViewPanelAlice.Name = "ToDoViewPanelAlice"
        ToDoViewPanelAlice.Size = New Size(377, 693)
        ToDoViewPanelAlice.TabIndex = 5
        ' 
        ' CompletedPerspective2
        ' 
        CompletedPerspective2.BackColor = Color.Transparent
        CompletedPerspective2.Controls.Add(CompletedChoreAlicePanel)
        CompletedPerspective2.Controls.Add(Label1)
        CompletedPerspective2.Controls.Add(Label3)
        CompletedPerspective2.Controls.Add(CompletedDateLabelAlice)
        CompletedPerspective2.Location = New Point(1, 0)
        CompletedPerspective2.Margin = New Padding(0)
        CompletedPerspective2.Name = "CompletedPerspective2"
        CompletedPerspective2.Size = New Size(377, 693)
        CompletedPerspective2.TabIndex = 7
        ' 
        ' CompletedChoreAlicePanel
        ' 
        CompletedChoreAlicePanel.Enabled = False
        CompletedChoreAlicePanel.Location = New Point(14, 113)
        CompletedChoreAlicePanel.Name = "CompletedChoreAlicePanel"
        CompletedChoreAlicePanel.Size = New Size(335, 556)
        CompletedChoreAlicePanel.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(14, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 23)
        Label1.TabIndex = 7
        Label1.Text = "Completed Chores:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(14, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 17)
        Label3.TabIndex = 5
        Label3.Text = "LeSpot"
        ' 
        ' CompletedDateLabelAlice
        ' 
        CompletedDateLabelAlice.AutoSize = True
        CompletedDateLabelAlice.BackColor = Color.Transparent
        CompletedDateLabelAlice.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedDateLabelAlice.ForeColor = Color.Black
        CompletedDateLabelAlice.Location = New Point(14, 39)
        CompletedDateLabelAlice.Margin = New Padding(0)
        CompletedDateLabelAlice.Name = "CompletedDateLabelAlice"
        CompletedDateLabelAlice.Size = New Size(233, 32)
        CompletedDateLabelAlice.TabIndex = 0
        CompletedDateLabelAlice.Text = "Today: Tue, Nov 7"
        CompletedDateLabelAlice.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' AliceAddChoreBtn
        ' 
        AliceAddChoreBtn.Anchor = AnchorStyles.None
        AliceAddChoreBtn.BackColor = Color.Transparent
        AliceAddChoreBtn.FlatAppearance.BorderSize = 0
        AliceAddChoreBtn.FlatStyle = FlatStyle.Flat
        AliceAddChoreBtn.Font = New Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        AliceAddChoreBtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AliceAddChoreBtn.Location = New Point(255, 12)
        AliceAddChoreBtn.Name = "AliceAddChoreBtn"
        AliceAddChoreBtn.Size = New Size(47, 63)
        AliceAddChoreBtn.TabIndex = 9
        AliceAddChoreBtn.Text = "+"
        AliceAddChoreBtn.UseVisualStyleBackColor = False
        ' 
        ' AliceBobTodoPanel
        ' 
        AliceBobTodoPanel.AutoScroll = True
        AliceBobTodoPanel.Location = New Point(14, 387)
        AliceBobTodoPanel.Name = "AliceBobTodoPanel"
        AliceBobTodoPanel.Size = New Size(329, 283)
        AliceBobTodoPanel.TabIndex = 8
        ' 
        ' AliceMeTodoboxPanel
        ' 
        AliceMeTodoboxPanel.AutoScroll = True
        AliceMeTodoboxPanel.Location = New Point(14, 108)
        AliceMeTodoboxPanel.Name = "AliceMeTodoboxPanel"
        AliceMeTodoboxPanel.Size = New Size(329, 249)
        AliceMeTodoboxPanel.TabIndex = 8
        ' 
        ' AliceBobLabel
        ' 
        AliceBobLabel.AutoSize = True
        AliceBobLabel.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        AliceBobLabel.Location = New Point(14, 360)
        AliceBobLabel.Name = "AliceBobLabel"
        AliceBobLabel.Size = New Size(45, 23)
        AliceBobLabel.TabIndex = 7
        AliceBobLabel.Text = "Bob"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(14, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 23)
        Label2.TabIndex = 7
        Label2.Text = "Me:"
        ' 
        ' AliceHouseLabel
        ' 
        AliceHouseLabel.AutoSize = True
        AliceHouseLabel.Font = New Font("Arial", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        AliceHouseLabel.Location = New Point(14, 59)
        AliceHouseLabel.Name = "AliceHouseLabel"
        AliceHouseLabel.Size = New Size(54, 17)
        AliceHouseLabel.TabIndex = 5
        AliceHouseLabel.Text = "LeSpot"
        ' 
        ' AliceDateLabel
        ' 
        AliceDateLabel.AutoSize = True
        AliceDateLabel.BackColor = Color.Transparent
        AliceDateLabel.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        AliceDateLabel.ForeColor = Color.Black
        AliceDateLabel.Location = New Point(11, 24)
        AliceDateLabel.Margin = New Padding(0)
        AliceDateLabel.Name = "AliceDateLabel"
        AliceDateLabel.Size = New Size(233, 32)
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
        AliceMenuPanel.Location = New Point(138, 812)
        AliceMenuPanel.Name = "AliceMenuPanel"
        AliceMenuPanel.Size = New Size(381, 87)
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
        SummaryBtnAlice.Location = New Point(272, 4)
        SummaryBtnAlice.Margin = New Padding(0)
        SummaryBtnAlice.Name = "SummaryBtnAlice"
        SummaryBtnAlice.Padding = New Padding(1)
        SummaryBtnAlice.Size = New Size(106, 83)
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
        ExpenseBtnAlice.Location = New Point(190, 4)
        ExpenseBtnAlice.Margin = New Padding(0)
        ExpenseBtnAlice.Name = "ExpenseBtnAlice"
        ExpenseBtnAlice.Padding = New Padding(1)
        ExpenseBtnAlice.Size = New Size(91, 83)
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
        CompletedBtnAlice.Location = New Point(88, 0)
        CompletedBtnAlice.Margin = New Padding(0)
        CompletedBtnAlice.Name = "CompletedBtnAlice"
        CompletedBtnAlice.Padding = New Padding(1)
        CompletedBtnAlice.Size = New Size(91, 87)
        CompletedBtnAlice.TabIndex = 6
        CompletedBtnAlice.UseVisualStyleBackColor = False
        ' 
        ' ToDoBtnAlice
        ' 
        ToDoBtnAlice.Anchor = AnchorStyles.None
        ToDoBtnAlice.BackColor = Color.FromArgb(CByte(62), CByte(90), CByte(60))
        ToDoBtnAlice.BackgroundImage = My.Resources.Resources.to_do_icon
        ToDoBtnAlice.BackgroundImageLayout = ImageLayout.Zoom
        ToDoBtnAlice.FlatAppearance.BorderSize = 0
        ToDoBtnAlice.FlatStyle = FlatStyle.Flat
        ToDoBtnAlice.Location = New Point(0, 0)
        ToDoBtnAlice.Margin = New Padding(0)
        ToDoBtnAlice.Name = "ToDoBtnAlice"
        ToDoBtnAlice.Padding = New Padding(1)
        ToDoBtnAlice.Size = New Size(93, 87)
        ToDoBtnAlice.TabIndex = 5
        ToDoBtnAlice.UseVisualStyleBackColor = False
        ' 
        ' AliceMasterPanel
        ' 
        AliceMasterPanel.Location = New Point(138, 119)
        AliceMasterPanel.Margin = New Padding(3, 4, 3, 4)
        AliceMasterPanel.Name = "AliceMasterPanel"
        AliceMasterPanel.Size = New Size(381, 780)
        AliceMasterPanel.TabIndex = 0
        ' 
        ' ExpensesPanel
        ' 
        ExpensesPanel.Controls.Add(ESummaryLabel)
        ExpensesPanel.Controls.Add(EPersonalExpensesPanel)
        ExpensesPanel.Controls.Add(EPersonalLabel)
        ExpensesPanel.Controls.Add(ESharedExpensesPanel)
        ExpensesPanel.Controls.Add(ESharedExpenseLabel)
        ExpensesPanel.Controls.Add(EButton)
        ExpensesPanel.Controls.Add(EFamilyLabel)
        ExpensesPanel.Controls.Add(ETitleLabel)
        ExpensesPanel.Location = New Point(770, 130)
        ExpensesPanel.Name = "ExpensesPanel"
        ExpensesPanel.Size = New Size(377, 693)
        ExpensesPanel.TabIndex = 9
        ' 
        ' ESummaryLabel
        ' 
        ESummaryLabel.AutoSize = True
        ESummaryLabel.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ESummaryLabel.Location = New Point(3, 621)
        ESummaryLabel.Name = "ESummaryLabel"
        ESummaryLabel.Size = New Size(58, 23)
        ESummaryLabel.TabIndex = 11
        ESummaryLabel.Text = "Total:"
        ' 
        ' EPersonalExpensesPanel
        ' 
        EPersonalExpensesPanel.Enabled = False
        EPersonalExpensesPanel.Location = New Point(37, 425)
        EPersonalExpensesPanel.Name = "EPersonalExpensesPanel"
        EPersonalExpensesPanel.Size = New Size(302, 152)
        EPersonalExpensesPanel.TabIndex = 10
        ' 
        ' EPersonalLabel
        ' 
        EPersonalLabel.AutoSize = True
        EPersonalLabel.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        EPersonalLabel.Location = New Point(3, 375)
        EPersonalLabel.Name = "EPersonalLabel"
        EPersonalLabel.Size = New Size(44, 23)
        EPersonalLabel.TabIndex = 10
        EPersonalLabel.Text = "Me:"
        ' 
        ' ESharedExpensesPanel
        ' 
        ESharedExpensesPanel.Enabled = False
        ESharedExpensesPanel.Location = New Point(37, 172)
        ESharedExpensesPanel.Name = "ESharedExpensesPanel"
        ESharedExpensesPanel.Size = New Size(302, 152)
        ESharedExpensesPanel.TabIndex = 9
        ' 
        ' ESharedExpenseLabel
        ' 
        ESharedExpenseLabel.AutoSize = True
        ESharedExpenseLabel.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ESharedExpenseLabel.Location = New Point(3, 133)
        ESharedExpenseLabel.Name = "ESharedExpenseLabel"
        ESharedExpenseLabel.Size = New Size(170, 23)
        ESharedExpenseLabel.TabIndex = 8
        ESharedExpenseLabel.Text = "Shared Expenses:"
        ' 
        ' EButton
        ' 
        EButton.Anchor = AnchorStyles.None
        EButton.BackColor = Color.Transparent
        EButton.FlatAppearance.BorderSize = 0
        EButton.FlatStyle = FlatStyle.Flat
        EButton.Font = New Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        EButton.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        EButton.Location = New Point(271, 80)
        EButton.Name = "EButton"
        EButton.Size = New Size(47, 63)
        EButton.TabIndex = 7
        EButton.Text = "+"
        EButton.UseVisualStyleBackColor = False
        ' 
        ' EFamilyLabel
        ' 
        EFamilyLabel.AutoSize = True
        EFamilyLabel.Font = New Font("Arial", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        EFamilyLabel.Location = New Point(18, 80)
        EFamilyLabel.Name = "EFamilyLabel"
        EFamilyLabel.Size = New Size(54, 17)
        EFamilyLabel.TabIndex = 6
        EFamilyLabel.Text = "LeSpot"
        ' 
        ' ETitleLabel
        ' 
        ETitleLabel.AutoSize = True
        ETitleLabel.BackColor = Color.Transparent
        ETitleLabel.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        ETitleLabel.ForeColor = Color.Black
        ETitleLabel.Location = New Point(18, 96)
        ETitleLabel.Margin = New Padding(0)
        ETitleLabel.Name = "ETitleLabel"
        ETitleLabel.Size = New Size(64, 32)
        ETitleLabel.TabIndex = 1
        ETitleLabel.Text = "Title"
        ETitleLabel.TextAlign = ContentAlignment.MiddleLeft
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
        CompletedChoreBobDate.Size = New Size(233, 32)
        CompletedChoreBobDate.TabIndex = 0
        CompletedChoreBobDate.Text = "Today: Tue, Nov 7"
        CompletedChoreBobDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ExpensesComponent1
        ' 
        ExpensesComponent1.Location = New Point(19, 27)
        ExpensesComponent1.Name = "ExpensesComponent1"
        ExpensesComponent1.Size = New Size(471, 656)
        ExpensesComponent1.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ExpensesComponent1)
        Panel2.Location = New Point(1192, 127)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(636, 719)
        Panel2.TabIndex = 11
        ' 
        ' Roomies
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1684, 1020)
        Controls.Add(Panel2)
        Controls.Add(ExpensesPanel)
        Controls.Add(TabControl1)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "Roomies"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "Roomies"
        TabControl1.ResumeLayout(False)
        Bob.ResumeLayout(False)
        TodoViewPanel.ResumeLayout(False)
        TodoViewPanel.PerformLayout()
        CompletedPerspective.ResumeLayout(False)
        CompletedPerspective.PerformLayout()
        BobMasterPanel.ResumeLayout(False)
        MenuPanel.ResumeLayout(False)
        AddHouseholdPanel.ResumeLayout(False)
        UserB.ResumeLayout(False)
        ToDoViewPanelAlice.ResumeLayout(False)
        ToDoViewPanelAlice.PerformLayout()
        CompletedPerspective2.ResumeLayout(False)
        CompletedPerspective2.PerformLayout()
        AliceMenuPanel.ResumeLayout(False)
        ExpensesPanel.ResumeLayout(False)
        ExpensesPanel.PerformLayout()
        CompletedBobPerspective.ResumeLayout(False)
        CompletedBobPerspective.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
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
    Friend WithEvents ExpensesPanel As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ETitleLabel As Label
    Friend WithEvents EFamilyLabel As Label
    Friend WithEvents ESummaryLabel As Label
    Friend WithEvents EPersonalExpensesPanel As Panel
    Friend WithEvents EPersonalLabel As Label
    Friend WithEvents ESharedExpensesPanel As Panel
    Friend WithEvents ESharedExpenseLabel As Label
    Friend WithEvents EButton As Button
    Friend WithEvents BobMasterPanel As Panel
    Friend WithEvents AliceMasterPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExpensesComponent1 As ExpensesComponent
    Friend WithEvents Panel2 As Panel

End Class
