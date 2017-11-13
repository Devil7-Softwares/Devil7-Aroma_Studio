
Imports System.Collections.Generic
Imports System.Text
Imports System.IO

'
' * This is a sample implementation of the IZImage interface
' * 
' * The main purpose of the Directory Images is to list out all the image files found in the
' * designated directory, this class can have other purposes and definations included.
' * 
' * what I wish to demonistrate here is by implementing IZImage interface you can preveiw the images
' * one by one using the viewer control
' * 
' * By Samqty
' 



Public Class DirectoryImages
    Implements IZImage
#Region "member fields"

    'path of the directory
    Private m_DirectoryName As String
    'number of the image files that are found
    Private m_ImageFilesCount As Integer

    Private m_CurrentIndex As Integer = -1
    Private ImageFiles As String()

#End Region

#Region "Constructor"

    Public Sub New(ByVal str As String)
        m_DirectoryName = str
        ImageFiles = Directory.GetFiles(str, "*.jpg")
        m_ImageFilesCount = ImageFiles.Length
    End Sub

#End Region

#Region "IZImage Members"

    Public ReadOnly Property ImageCount() As Integer Implements IZImage.ImageCount
        Get
            Return m_ImageFilesCount
        End Get
    End Property

    Public ReadOnly Property CurrentIndex() As Integer Implements IZImage.CurrentIndex
        Get
            Return m_CurrentIndex
        End Get
    End Property

    Public Function GetNextImage() As System.Drawing.Image Implements IZImage.GetNextImage
        m_CurrentIndex += 1
        If m_CurrentIndex >= m_ImageFilesCount Then
            Throw New Exception("No More Images")
        End If
        Return System.Drawing.Image.FromFile(ImageFiles(m_CurrentIndex))
    End Function

    Public Function GetPreviousImage() As System.Drawing.Image Implements IZImage.GetPreviousImage
        m_CurrentIndex -= 1
        If m_CurrentIndex <= 0 Then
            Throw New Exception("No More Images")
        End If
        Return System.Drawing.Image.FromFile(ImageFiles(m_CurrentIndex))
    End Function

#End Region
End Class
