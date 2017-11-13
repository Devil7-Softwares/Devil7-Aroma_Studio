Public Class ThemeNode
    Inherits TreeNode
    Property Path As String
    WithEvents Watcher As New IO.FileSystemWatcher
    Sub New(ByVal Path As String)
        Me.Path = Path
        Me.ImageKey = "theme"
        Me.SelectedImageKey = "theme"
        Me.Text = My.Computer.FileSystem.GetDirectoryInfo(Path).Name
        Me.Watcher.Path = Path
        Me.Watcher.IncludeSubdirectories = False
        Me.Watcher.EnableRaisingEvents = True
    End Sub

    Sub Refresh()
        For Each i As String In My.Computer.FileSystem.GetDirectories(Me.Path, FileIO.SearchOption.SearchTopLevelOnly, "*")
            'Try
            Dim node = New ResourcesNode(i)
            If NodeExits(Me.Nodes, Me.FullPath, node) = False Then
                Me.Nodes.Add(node)
            End If
            'Catch ex As Exception
            'MsgBox(ex.Message)
            'End Try
        Next
        For Each i As String In My.Computer.FileSystem.GetFiles(Me.Path, FileIO.SearchOption.SearchTopLevelOnly, "*")
            'Try
            Dim node = New FileNode(i)
            If NodeExits(Me.Nodes, Me.FullPath, node) = False Then
                Me.Nodes.Add(node)
            End If
            'Catch ex As Exception
            'MsgBox(ex.Message)
            'End Try
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
