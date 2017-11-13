Public Class ctl_CodeEditor
    Dim owner As DevExpress.XtraTab.XtraTabPage
    Dim _file As File
    Property File As File
        Get
            Return _file
        End Get
        Set(ByVal value As File)
            _file = value

        End Set
    End Property
    Property Edited As Boolean
        Get
            Return TextEditor.IsChanged
        End Get
        Set(ByVal value As Boolean)
            TextEditor.IsChanged = value
        End Set
    End Property

    Private Sub TextEditor_TextChanged(ByVal sender As Object, ByVal e As FastColoredTextBoxNS.TextChangedEventArgs) Handles TextEditor.TextChanged
        Try
            If Me.owner IsNot Nothing Then
                If owner.Text.EndsWith("*") = False Then
                    owner.Text = If(File IsNot Nothing, File.Name, "") & "*"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ctl_CodeEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim own = Me.Parent
        If TypeOf (own) Is DevExpress.XtraTab.XtraTabPage Then
            Me.owner = own
            Me.Dock = DockStyle.Fill
            Try
                If Me.owner IsNot Nothing Then
                    If owner.Text.EndsWith("*") = False Then
                        owner.Text = If(_file IsNot Nothing, _file.Name, "") & "*"
                    End If
                End If
            Catch ex As Exception

            End Try
        End If  End Sub
End Class
