<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TreeView1 = New TreeView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' TreeView1
        ' 
        TreeView1.BorderStyle = BorderStyle.None
        TreeView1.Dock = DockStyle.Fill
        TreeView1.Font = New Font("游ゴシック", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        TreeView1.Indent = 35
        TreeView1.ItemHeight = 25
        TreeView1.LineColor = Color.Blue
        TreeView1.Location = New Point(0, 0)
        TreeView1.Margin = New Padding(0)
        TreeView1.Name = "TreeView1"
        TreeView1.Size = New Size(464, 601)
        TreeView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(296, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(35, 25)
        Button1.TabIndex = 1
        Button1.Text = "展+"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(334, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(35, 25)
        Button2.TabIndex = 2
        Button2.Text = "閉-"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlDark
        Button3.Location = New Point(372, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(38, 25)
        Button3.TabIndex = 3
        Button3.Text = "透け"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkGray
        Button4.Location = New Point(413, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(38, 25)
        Button4.TabIndex = 4
        Button4.Text = "Top"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AcceptButton = Button1
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Button2
        ClientSize = New Size(464, 601)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TreeView1)
        Name = "Form1"
        Text = "Treeeen"
        ResumeLayout(False)
    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class
