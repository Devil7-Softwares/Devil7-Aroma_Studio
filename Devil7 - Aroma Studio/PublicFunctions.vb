Module PublicFunctions
    Public Function GetFileType(ByVal Filename As String) As FileType
        Dim ext As String = IO.Path.GetExtension(Filename).ToLower

        Select Case ext
            Case ".zip"
                Return FileType.ZIP
            Case ".png"
                Return FileType.IMG
            Case ".sh", ".edify"
                Return FileType.Code
            Case Else
                Return FileType.Unknown
        End Select
    End Function
    Public Function GetImageKey(ByVal FileType As FileType) As String
        Select Case FileType
            Case FileType.ZIP
                Return "zip"
            Case FileType.IMG
                Return "img"
            Case Else
                Return "code"
        End Select
    End Function
    Public Function DirPath(ByVal Path As String)
        If My.Computer.FileSystem.DirectoryExists(Path) = False Then
            My.Computer.FileSystem.CreateDirectory(Path)
        End If
        Return Path
    End Function
    Public Function NodeExits(ByVal Nodes As TreeNodeCollection, ByVal Treepath As String, ByVal Node As TreeNode) As Boolean
        Dim NodeExist As Boolean = False
        For Each i As TreeNode In Nodes
            If i.FullPath = Treepath & "\" & Node.Text Then
                NodeExist = True
                Exit For
            End If
        Next
        Return NodeExist
    End Function
    Public Function FindNode(ByVal Nodes As TreeNodeCollection, ByVal Treepath As String, ByVal Node As String) As TreeNode
        Dim RNode As TreeNode = Nothing
        For Each i As TreeNode In Nodes
            If i.FullPath = Treepath & "\" & Node Then
                RNode = i
                Exit For
            End If
        Next
        Return RNode
    End Function
End Module
