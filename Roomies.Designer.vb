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
        AddHouseholdBtn = New Button()
        DateLabel = New Label()
        BottomToolStripPanel = New ToolStripPanel()
        TopToolStripPanel = New ToolStripPanel()
        RightToolStripPanel = New ToolStripPanel()
        LeftToolStripPanel = New ToolStripPanel()
        ContentPanel = New ToolStripContentPanel()
        TabControl1 = New TabControl()
        UserA = New TabPage()
        ExpensesAddbtn = New Button()
        ChoreAddbtn = New Button()
        UserB = New TabPage()
        TabControl1.SuspendLayout()
        UserA.SuspendLayout()
        SuspendLayout()
        ' 
        ' AddHouseholdBtn
        ' 
        AddHouseholdBtn.BackColor = Color.FromArgb(CByte(222), CByte(213), CByte(188))
        AddHouseholdBtn.BackgroundImage = My.Resources.Resources.House
        AddHouseholdBtn.BackgroundImageLayout = ImageLayout.Zoom
        AddHouseholdBtn.FlatAppearance.BorderColor = Color.Black
        AddHouseholdBtn.FlatAppearance.BorderSize = 3
        AddHouseholdBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(183), CByte(158))
        AddHouseholdBtn.FlatStyle = FlatStyle.Flat
        AddHouseholdBtn.Location = New Point(211, 315)
        AddHouseholdBtn.Name = "AddHouseholdBtn"
        AddHouseholdBtn.Size = New Size(58, 51)
        AddHouseholdBtn.TabIndex = 1
        AddHouseholdBtn.TextImageRelation = TextImageRelation.ImageAboveText
        AddHouseholdBtn.UseVisualStyleBackColor = False
        ' 
        ' DateLabel
        ' 
        DateLabel.BackColor = Color.FromArgb(CByte(177), CByte(171), CByte(148))
        DateLabel.Dock = DockStyle.Top
        DateLabel.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        DateLabel.ForeColor = Color.Black
        DateLabel.Location = New Point(3, 3)
        DateLabel.Margin = New Padding(0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New Size(483, 48)
        DateLabel.TabIndex = 0
        DateLabel.Text = "Today: Tue, Nov 7"
        DateLabel.TextAlign = ContentAlignment.MiddleLeft
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
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Margin = New Padding(0)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(0, 0)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(497, 575)
        TabControl1.TabIndex = 2
        ' 
        ' UserA
        ' 
        UserA.BackColor = Color.FromArgb(CByte(222), CByte(213), CByte(188))
        UserA.Controls.Add(ExpensesAddbtn)
        UserA.Controls.Add(ChoreAddbtn)
        UserA.Controls.Add(AddHouseholdBtn)
        UserA.Controls.Add(DateLabel)
        UserA.ForeColor = Color.Black
        UserA.Location = New Point(4, 27)
        UserA.Name = "UserA"
        UserA.Padding = New Padding(3)
        UserA.Size = New Size(489, 544)
        UserA.TabIndex = 0
        UserA.Text = "User A"
        ' 
        ' ExpensesAddbtn
        ' 
        ExpensesAddbtn.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ExpensesAddbtn.BackColor = Color.FromArgb(CByte(222), CByte(213), CByte(188))
        ExpensesAddbtn.FlatAppearance.BorderSize = 3
        ExpensesAddbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(183), CByte(158))
        ExpensesAddbtn.FlatStyle = FlatStyle.Flat
        ExpensesAddbtn.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ExpensesAddbtn.ForeColor = Color.Black
        ExpensesAddbtn.Location = New Point(281, 443)
        ExpensesAddbtn.Name = "ExpensesAddbtn"
        ExpensesAddbtn.Size = New Size(118, 54)
        ExpensesAddbtn.TabIndex = 3
        ExpensesAddbtn.Text = "Expenses"
        ExpensesAddbtn.UseVisualStyleBackColor = False
        ' 
        ' ChoreAddbtn
        ' 
        ChoreAddbtn.BackColor = Color.FromArgb(CByte(222), CByte(213), CByte(188))
        ChoreAddbtn.FlatAppearance.BorderSize = 3
        ChoreAddbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(183), CByte(158))
        ChoreAddbtn.FlatStyle = FlatStyle.Flat
        ChoreAddbtn.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ChoreAddbtn.ForeColor = Color.Black
        ChoreAddbtn.Location = New Point(93, 443)
        ChoreAddbtn.Name = "ChoreAddbtn"
        ChoreAddbtn.Size = New Size(118, 54)
        ChoreAddbtn.TabIndex = 2
        ChoreAddbtn.Text = "Chore"
        ChoreAddbtn.UseVisualStyleBackColor = False
        ' 
        ' UserB
        ' 
        UserB.BackColor = Color.FromArgb(CByte(222), CByte(213), CByte(188))
        UserB.ForeColor = Color.FromArgb(CByte(222), CByte(213), CByte(188))
        UserB.Location = New Point(4, 27)
        UserB.Name = "UserB"
        UserB.Padding = New Padding(3)
        UserB.Size = New Size(489, 544)
        UserB.TabIndex = 1
        UserB.Text = "User B"
        ' 
        ' Roomies
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(222), CByte(213), CByte(188))
        ClientSize = New Size(497, 575)
        Controls.Add(TabControl1)
        Cursor = Cursors.Cross
        Name = "Roomies"
        Text = "Roomies"
        TabControl1.ResumeLayout(False)
        UserA.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents AddHouseholdBtn As Button
    Friend WithEvents DateLabel As Label
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents UserA As TabPage
    Friend WithEvents UserB As TabPage
    Friend WithEvents ExpensesAddbtn As Button
    Friend WithEvents ChoreAddbtn As Button
End Class
