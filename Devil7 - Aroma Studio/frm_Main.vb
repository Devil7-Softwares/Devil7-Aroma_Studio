Imports DevExpress.XtraTreeList.Nodes

Public Class frm_Main
    Dim Random As New Random

    Private Sub Designer_CloseButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Designer.CloseButtonClick
        If Designer.SelectedTabPage IsNot Nothing Then
            Designer.TabPages.Remove(Designer.SelectedTabPage)
        End If
    End Sub

    Private Sub frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim t As DevExpress.XtraTab.XtraTabPage = Designer.TabPages.Add
        Dim ce = New ctl_CodeEditor()
        ce.File = New File(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "Untitled-1.edify"))
        t.Controls.Add(ce)
        t.Refresh()
        Designer.SelectedTabPage = t
        Designer.Refresh()
        NewProject()
    End Sub
    Sub NewProject()
        TreeView1.Nodes.Clear()
        Try
            Dim Project As ProjectNode = (New ProjectNode())
            TreeView1.Nodes.Add(Project)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub RibbonControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl.Click

    End Sub

    Private Sub SolutionExplorer_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)

    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            ' MsgBox(e.Node.FullPath)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenInFileExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenInFileExplorerToolStripMenuItem.Click
        Try
            Dim SNode = TreeView1.SelectedNode
            If TypeOf SNode Is ResourcesNode Then
                Process.Start(CType(SNode, ResourcesNode).Path)
            ElseIf TypeOf SNode Is ThemeNode Then
                Process.Start(CType(SNode, ThemeNode).Path)
            ElseIf TypeOf SNode Is ProjectNode Then
                Process.Start(CType(SNode, ProjectNode).Path)
            ElseIf TypeOf SNode Is FileNode Then
                Process.Start(My.Computer.FileSystem.GetFileInfo(CType(SNode, FileNode).Path).Directory.FullName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Try
            CType(TreeView1.SelectedNode, Object).Refresh()
        Catch ex As Exception

        End Try
    End Sub
End Class