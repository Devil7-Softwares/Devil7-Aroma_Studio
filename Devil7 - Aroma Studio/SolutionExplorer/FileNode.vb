Public Class FileNode
    Inherits TreeNode
    Property Path As String
    Sub New(ByVal Path As String)
        Me.Path = Path
        Me.ImageKey = (GetImageKey(GetFileType(Path)))
        Me.Text = IO.Path.GetFileName(Path)
    End Sub

End Class
