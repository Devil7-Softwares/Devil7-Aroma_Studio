Public Class File
    Sub New(ByVal FilePath As String)
        Me.Filename = FilePath
    End Sub
    Function Name() As String
        Return IO.Path.GetFileName(Filename)
    End Function
    Property Filename As String
    Function FileType() As FileType
        Dim Ext As String = IO.Path.GetExtension(Filename).ToLower
        If Ext = "edify" Then
            Return FileType.Code
        End If
        Return FileType.Unknown
    End Function
End Class