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
        UserB = New TabPage()
        AliceMenuPanel = New Panel()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Panel1 = New Panel()
        AliceAddChoreBtn = New Button()
        AliceBobTodoPanel = New Panel()
        AliceMeTodoboxPanel = New Panel()
        AliceBobLabel = New Label()
        Label2 = New Label()
        AliceHouseLabel = New Label()
        AliceDateLabel = New Label()
        AddHouseholdBtn = New Button()
        AddHouseholdPanel = New Panel()
        CompletedAlicePerspective = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        CompletedBobLabel1 = New Label()
        CompletedAliceLabel1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CompletedBobPerspective = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        CompletedAliceLabel2 = New Label()
        CompletedBobLabel2 = New Label()
        Button7 = New Button()
        Label8 = New Label()
        Label9 = New Label()
        TabControl1.SuspendLayout()
        Bob.SuspendLayout()
        TodoViewPanel.SuspendLayout()
        MenuPanel.SuspendLayout()
        UserB.SuspendLayout()
        AliceMenuPanel.SuspendLayout()
        Panel1.SuspendLayout()
        AddHouseholdPanel.SuspendLayout()
        CompletedAlicePerspective.SuspendLayout()
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
        TodoViewPanel.Size = New Size(330, 526)
        TodoViewPanel.TabIndex = 4
        ' 
        ' User2ChoreCheckboxPanel
        ' 
        User2ChoreCheckboxPanel.AutoScroll = True
        User2ChoreCheckboxPanel.Location = New Point(12, 283)
        User2ChoreCheckboxPanel.Name = "User2ChoreCheckboxPanel"
        User2ChoreCheckboxPanel.Size = New Size(302, 240)
        User2ChoreCheckboxPanel.TabIndex = 8
        ' 
        ' User1ChoreCheckboxPanel
        ' 
        User1ChoreCheckboxPanel.AutoScroll = True
        User1ChoreCheckboxPanel.Location = New Point(12, 81)
        User1ChoreCheckboxPanel.Name = "User1ChoreCheckboxPanel"
        User1ChoreCheckboxPanel.Size = New Size(302, 172)
        User1ChoreCheckboxPanel.TabIndex = 8
        ' 
        ' Alice
        ' 
        Alice.AutoSize = True
        Alice.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Alice.Location = New Point(12, 262)
        Alice.Name = "Alice"
        Alice.Size = New Size(43, 18)
        Alice.TabIndex = 7
        Alice.Text = "Alice"
        ' 
        ' Roommate1
        ' 
        Roommate1.AutoSize = True
        Roommate1.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Roommate1.Location = New Point(14, 122)
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
        AddChoreBtn.Location = New Point(246, 9)
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
        HouseholdName.Location = New Point(14, 58)
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
        DateLabel.Location = New Point(12, 24)
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
        ExpensesBtn.Size = New Size(87, 62)
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
        CompletedBtn.Location = New Point(76, 3)
        CompletedBtn.Margin = New Padding(0)
        CompletedBtn.Name = "CompletedBtn"
        CompletedBtn.Padding = New Padding(1)
        CompletedBtn.Size = New Size(89, 62)
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
        TodoBtn.Size = New Size(76, 62)
        TodoBtn.TabIndex = 5
        TodoBtn.UseVisualStyleBackColor = False
        ' 
        ' UserB
        ' 
        UserB.BackColor = Color.Silver
        UserB.BackgroundImage = My.Resources.Resources.iphone5
        UserB.BackgroundImageLayout = ImageLayout.Zoom
        UserB.Controls.Add(AliceMenuPanel)
        UserB.Controls.Add(Panel1)
        UserB.ForeColor = Color.Black
        UserB.Location = New Point(4, 27)
        UserB.Name = "UserB"
        UserB.Padding = New Padding(3)
        UserB.Size = New Size(576, 767)
        UserB.TabIndex = 1
        UserB.Text = "Alice"
        ' 
        ' AliceMenuPanel
        ' 
        AliceMenuPanel.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        AliceMenuPanel.Controls.Add(Button2)
        AliceMenuPanel.Controls.Add(Button3)
        AliceMenuPanel.Controls.Add(Button4)
        AliceMenuPanel.Controls.Add(Button5)
        AliceMenuPanel.Location = New Point(123, 615)
        AliceMenuPanel.Name = "AliceMenuPanel"
        AliceMenuPanel.Size = New Size(330, 65)
        AliceMenuPanel.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        Button2.BackgroundImage = My.Resources.Resources.expense_summary_icon
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(237, 3)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(1)
        Button2.Size = New Size(93, 62)
        Button2.TabIndex = 7
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        Button3.BackgroundImage = My.Resources.Resources.expenses_icon
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(165, 3)
        Button3.Margin = New Padding(0)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(1)
        Button3.Size = New Size(87, 62)
        Button3.TabIndex = 7
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.None
        Button4.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        Button4.BackgroundImage = My.Resources.Resources.completed_icon
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(76, 3)
        Button4.Margin = New Padding(0)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(1)
        Button4.Size = New Size(89, 62)
        Button4.TabIndex = 6
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.None
        Button5.BackColor = Color.FromArgb(CByte(89), CByte(121), CByte(87))
        Button5.BackgroundImage = My.Resources.Resources.to_do_icon
        Button5.BackgroundImageLayout = ImageLayout.Zoom
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(0, 3)
        Button5.Margin = New Padding(0)
        Button5.Name = "Button5"
        Button5.Padding = New Padding(1)
        Button5.Size = New Size(76, 62)
        Button5.TabIndex = 5
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(AliceAddChoreBtn)
        Panel1.Controls.Add(AliceBobTodoPanel)
        Panel1.Controls.Add(AliceMeTodoboxPanel)
        Panel1.Controls.Add(AliceBobLabel)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(AliceHouseLabel)
        Panel1.Controls.Add(AliceDateLabel)
        Panel1.Location = New Point(122, 91)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(330, 526)
        Panel1.TabIndex = 5
        ' 
        ' AliceAddChoreBtn
        ' 
        AliceAddChoreBtn.Anchor = AnchorStyles.None
        AliceAddChoreBtn.BackColor = Color.Transparent
        AliceAddChoreBtn.FlatAppearance.BorderSize = 0
        AliceAddChoreBtn.FlatStyle = FlatStyle.Flat
        AliceAddChoreBtn.Font = New Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        AliceAddChoreBtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AliceAddChoreBtn.Location = New Point(246, 9)
        AliceAddChoreBtn.Name = "AliceAddChoreBtn"
        AliceAddChoreBtn.Size = New Size(41, 47)
        AliceAddChoreBtn.TabIndex = 9
        AliceAddChoreBtn.Text = "+"
        AliceAddChoreBtn.UseVisualStyleBackColor = False
        ' 
        ' AliceBobTodoPanel
        ' 
        AliceBobTodoPanel.AutoScroll = True
        AliceBobTodoPanel.Location = New Point(16, 350)
        AliceBobTodoPanel.Name = "AliceBobTodoPanel"
        AliceBobTodoPanel.Size = New Size(302, 172)
        AliceBobTodoPanel.TabIndex = 8
        ' 
        ' AliceMeTodoboxPanel
        ' 
        AliceMeTodoboxPanel.AutoScroll = True
        AliceMeTodoboxPanel.Location = New Point(16, 79)
        AliceMeTodoboxPanel.Name = "AliceMeTodoboxPanel"
        AliceMeTodoboxPanel.Size = New Size(302, 240)
        AliceMeTodoboxPanel.TabIndex = 8
        ' 
        ' AliceBobLabel
        ' 
        AliceBobLabel.AutoSize = True
        AliceBobLabel.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        AliceBobLabel.Location = New Point(14, 312)
        AliceBobLabel.Name = "AliceBobLabel"
        AliceBobLabel.Size = New Size(37, 18)
        AliceBobLabel.TabIndex = 7
        AliceBobLabel.Text = "Bob"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(14, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 18)
        Label2.TabIndex = 7
        Label2.Text = "Me:"
        ' 
        ' AliceHouseLabel
        ' 
        AliceHouseLabel.AutoSize = True
        AliceHouseLabel.Font = New Font("Arial", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        AliceHouseLabel.Location = New Point(14, 58)
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
        AliceDateLabel.Location = New Point(12, 24)
        AliceDateLabel.Margin = New Padding(0)
        AliceDateLabel.Name = "AliceDateLabel"
        AliceDateLabel.Size = New Size(179, 24)
        AliceDateLabel.TabIndex = 0
        AliceDateLabel.Text = "Today: Tue, Nov 7"
        AliceDateLabel.TextAlign = ContentAlignment.MiddleLeft
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
        AddHouseholdPanel.Location = New Point(611, 105)
        AddHouseholdPanel.Margin = New Padding(0)
        AddHouseholdPanel.Name = "AddHouseholdPanel"
        AddHouseholdPanel.Size = New Size(345, 507)
        AddHouseholdPanel.TabIndex = 5
        AddHouseholdPanel.Visible = False
        ' 
        ' CompletedAlicePerspective
        ' 
        CompletedAlicePerspective.BackColor = Color.Transparent
        CompletedAlicePerspective.Controls.Add(Panel3)
        CompletedAlicePerspective.Controls.Add(Panel4)
        CompletedAlicePerspective.Controls.Add(CompletedBobLabel1)
        CompletedAlicePerspective.Controls.Add(CompletedAliceLabel1)
        CompletedAlicePerspective.Controls.Add(Label4)
        CompletedAlicePerspective.Controls.Add(Label5)
        CompletedAlicePerspective.Location = New Point(1046, 105)
        CompletedAlicePerspective.Margin = New Padding(0)
        CompletedAlicePerspective.Name = "CompletedAlicePerspective"
        CompletedAlicePerspective.Size = New Size(330, 526)
        CompletedAlicePerspective.TabIndex = 6
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(14, 333)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(302, 160)
        Panel3.TabIndex = 8
        ' 
        ' Panel4
        ' 
        Panel4.Location = New Point(14, 143)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(302, 160)
        Panel4.TabIndex = 8
        ' 
        ' CompletedBobLabel1
        ' 
        CompletedBobLabel1.AutoSize = True
        CompletedBobLabel1.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedBobLabel1.Location = New Point(14, 312)
        CompletedBobLabel1.Name = "CompletedBobLabel1"
        CompletedBobLabel1.Size = New Size(37, 18)
        CompletedBobLabel1.TabIndex = 7
        CompletedBobLabel1.Text = "Bob"
        ' 
        ' CompletedAliceLabel1
        ' 
        CompletedAliceLabel1.AutoSize = True
        CompletedAliceLabel1.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedAliceLabel1.Location = New Point(14, 122)
        CompletedAliceLabel1.Name = "CompletedAliceLabel1"
        CompletedAliceLabel1.Size = New Size(34, 18)
        CompletedAliceLabel1.TabIndex = 7
        CompletedAliceLabel1.Text = "Me:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(14, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 5
        Label4.Text = "LeSpot"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(14, 74)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(179, 24)
        Label5.TabIndex = 0
        Label5.Text = "Today: Tue, Nov 7"
        Label5.TextAlign = ContentAlignment.MiddleLeft
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
        CompletedBobPerspective.Controls.Add(Label9)
        CompletedBobPerspective.Location = New Point(1464, 105)
        CompletedBobPerspective.Margin = New Padding(0)
        CompletedBobPerspective.Name = "CompletedBobPerspective"
        CompletedBobPerspective.Size = New Size(330, 526)
        CompletedBobPerspective.TabIndex = 7
        ' 
        ' Panel6
        ' 
        Panel6.Location = New Point(14, 333)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(302, 160)
        Panel6.TabIndex = 8
        ' 
        ' Panel7
        ' 
        Panel7.Location = New Point(14, 143)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(302, 160)
        Panel7.TabIndex = 8
        ' 
        ' CompletedAliceLabel2
        ' 
        CompletedAliceLabel2.AutoSize = True
        CompletedAliceLabel2.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedAliceLabel2.Location = New Point(14, 312)
        CompletedAliceLabel2.Name = "CompletedAliceLabel2"
        CompletedAliceLabel2.Size = New Size(43, 18)
        CompletedAliceLabel2.TabIndex = 7
        CompletedAliceLabel2.Text = "Alice"
        ' 
        ' CompletedBobLabel2
        ' 
        CompletedBobLabel2.AutoSize = True
        CompletedBobLabel2.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedBobLabel2.Location = New Point(14, 122)
        CompletedBobLabel2.Name = "CompletedBobLabel2"
        CompletedBobLabel2.Size = New Size(34, 18)
        CompletedBobLabel2.TabIndex = 7
        CompletedBobLabel2.Text = "Me:"
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.None
        Button7.BackColor = Color.Transparent
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button7.Location = New Point(378, 485)
        Button7.Name = "Button7"
        Button7.Size = New Size(41, 47)
        Button7.TabIndex = 6
        Button7.Text = "+"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(14, 58)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 15)
        Label8.TabIndex = 5
        Label8.Text = "LeSpot"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(14, 74)
        Label9.Margin = New Padding(0)
        Label9.Name = "Label9"
        Label9.Size = New Size(179, 24)
        Label9.TabIndex = 0
        Label9.Text = "Today: Tue, Nov 7"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Roomies
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(2335, 1061)
        Controls.Add(CompletedBobPerspective)
        Controls.Add(CompletedAlicePerspective)
        Controls.Add(AddHouseholdPanel)
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
        UserB.ResumeLayout(False)
        AliceMenuPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        AddHouseholdPanel.ResumeLayout(False)
        CompletedAlicePerspective.ResumeLayout(False)
        CompletedAlicePerspective.PerformLayout()
        CompletedBobPerspective.ResumeLayout(False)
        CompletedBobPerspective.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AliceBobTodoPanel As Panel
    Friend WithEvents AliceMeTodoboxPanel As Panel
    Friend WithEvents AliceBobLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AliceHouseLabel As Label
    Friend WithEvents AliceDateLabel As Label
    Friend WithEvents AliceMenuPanel As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents AliceAddChoreBtn As Button
    Friend WithEvents CompletedAlicePerspective As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CompletedBobLabel1 As Label
    Friend WithEvents CompletedAliceLabel1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CompletedBobPerspective As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents CompletedAliceLabel2 As Label
    Friend WithEvents CompletedBobLabel2 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
