Public Class ProjectNode
    Inherits TreeNode
    Dim Random As New Random
    Property Path As String
    WithEvents Watcher As New IO.FileSystemWatcher
    Sub New()
        Dim path As String = DirPath(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "UntitledProject-" & Random.Next(10000, 99999)))
        Me.Path = path
        Me.ImageKey = "project"
        Me.SelectedImageKey = "project"
        Me.Nodes.Add(New ThemeNode(DirPath(path & "\Theme")))
        Me.Nodes.Add(New ResourcesNode(DirPath(path & "\Resources")))
        Me.Text = My.Computer.FileSystem.GetDirectoryInfo(path).Name
        Me.Watcher.Path = path
        Me.Watcher.IncludeSubdirectories = False
        Me.Watcher.EnableRaisingEvents = True
    End Sub

    Sub Refresh()
        For Each i As String In My.Computer.FileSystem.GetDirectories(Me.Path, FileIO.SearchOption.SearchTopLevelOnly, "*")
            Try
                Dim node = New ResourcesNode(i)
                If NodeExits(Me.Nodes, Me.FullPath, node) = False Then
                    Me.Nodes.Add(node)
                End If
            Catch ex As Exception

            End Try
        Next
        For Each i As String In My.Computer.FileSystem.GetFiles(Me.Path, FileIO.SearchOption.SearchTopLevelOnly, "*")
            Try
                Dim node = New FileNode(i)
                If NodeExits(Me.Nodes, Me.FullPath, node) = False Then
                    Me.Nodes.Add(node)
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub
    Private Sub Watcher_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles Watcher.Created
        Try
            If My.Computer.FileSystem.DirectoryExists(e.FullPath) = True Then
                Try
                    Dim node = New ResourcesNode(e.FullPath)
                    If NodeExits(Me.Nodes, Me.FullPath, node) = False Then
                        Me.TreeView.FindForm.Invoke(Sub()
                                                        Me.Nodes.Add(node)
                                                    End Sub)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf My.Computer.FileSystem.FileExists(e.FullPath) = True Then
                Try
                    Dim node = New FileNode(e.FullPath)
                    If NodeExits(Me.Nodes, Me.FullPath, node) = False Then
                        Me.TreeView.FindForm.Invoke(Sub()
                                                        Me.Nodes.Add(node)
                                                    End Sub)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
