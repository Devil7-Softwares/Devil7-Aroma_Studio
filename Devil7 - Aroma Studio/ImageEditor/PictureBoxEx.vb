
'
' * This a sample implementation of Image Viewer
' * It contains two class definations 
' *      1-PictureBoxEx
' *      2-ImageFile
' * 
' * PictureBoxEx: its acts like a picture box. its an implementation of Imageviewer control where its is
' * modified to only accept a file name and display the image much like a picture box but with the
' * enhanced capabilities
' * 
' * ImageFile: its a sample implemetation of the IZImage inorder to provide a source object
' * for the PictureBoxEx class,with an implementation provided that it accepts one file name
' * 
' 


Imports System.Collections.Generic
Imports System.Text


''' <summary>
''' this is a default implementation of the image viewer control
''' that directly accepts the path of the image file
''' and could be used for only one picture by passing the path of the image file
''' </summary>
Public Class PictureBoxEx
    Inherits ImageControl
#Region "member fields"

    Private m_FileName As String

#End Region

#Region "member properties"

    Public Property FilePath() As String
        Get
            Return m_FileName
        End Get
        Set(ByVal value As String)
            m_FileName = Value
            If Not String.IsNullOrEmpty(m_FileName) Then
                Me.SetImageSource(New ImageFile(m_FileName))
            End If
        End Set
    End Property

#End Region

#Region "Constructors"

    Public Sub New(ByVal FileName As String)
        m_FileName = FileName
        Me.SetImageSource(New ImageFile(FileName))
    End Sub

#End Region
End Class

''' <summary>
''' this a default implementation of the IZImage interface
''' in order to use the image viewer to display a single file image
''' </summary>
Public Class ImageFile
    Implements IZImage

#Region "member fields"

    'holds the file name of the image
    Private m_FileName As String

#End Region

    Public Sub New()
        m_FileName = ""
    End Sub

    Public Sub New(ByVal str As String)
        m_FileName = str
    End Sub

#Region "IZImage Members"

    Public ReadOnly Property ImageCount() As Integer Implements IZImage.ImageCount
        Get
            Return If(String.IsNullOrEmpty(m_FileName), 0, 1)
        End Get
    End Property

    Public ReadOnly Property CurrentIndex() As Integer Implements IZImage.CurrentIndex
        Get
            Return 0
        End Get
    End Property

    Public Function GetNextImage() As System.Drawing.Image Implements IZImage.GetNextImage
        Return System.Drawing.Image.FromFile(m_FileName)
    End Function

    Public Function GetPreviousImage() As System.Drawing.Image Implements IZImage.GetPreviousImage
        Return System.Drawing.Image.FromFile(m_FileName)
    End Function

#End Region

End Class
