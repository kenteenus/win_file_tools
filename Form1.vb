Public Class Form1
    Dim stat As Boolean = False
    Dim opa As Single = 1.0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "select Fordacnot short cut>"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            Console.WriteLine(fbd.SelectedPath)
        End If
        trViewSet(fbd.SelectedPath, TreeView1.Nodes.Add(fbd.SelectedPath))

    End Sub

    Private Sub trViewSet(ByVal path As String, ByVal node As TreeNode)
        Dim folder As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(path)
        Dim subfolders() As System.IO.DirectoryInfo = folder.GetDirectories()
        Dim subfolder As System.IO.DirectoryInfo
        For Each subfolder In subfolders
            Dim subnode As TreeNode = node.Nodes.Add(subfolder.Name)
            trViewSet(subfolder.FullName, subnode)

        Next
        Dim files() As System.IO.FileInfo = folder.GetFiles()
        Dim file As System.IO.FileInfo
        For Each file In files
            node.Nodes.Add(file.Name)
        Next
    End Sub
    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim result As DialogResult = MessageBox.Show(e.Node.FullPath & vbCrLf & "copy?", "ok", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Clipboard.SetText(e.Node.FullPath)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TreeView1.ExpandAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TreeView1.CollapseAll()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        stat = Not stat
        Me.TopMost = stat
        If stat = True Then
            Button4.BackColor = Color.Aqua
        Else
            Button4.BackColor = Color.DarkGray
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        opa = opa - 0.1
        If opa < 0.5 Then
            opa = 1.0
        End If

        Me.Opacity = opa
    End Sub
End Class


