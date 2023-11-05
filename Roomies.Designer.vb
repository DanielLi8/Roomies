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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Roomies))
        Name = New Label()
        SuspendLayout()
        ' 
        ' Name
        ' 
        resources.ApplyResources(Name, "Name")
        Name.Name = "Name"
        ' 
        ' Roomies
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Name)
        Name = "Roomies"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Name As Label
End Class
