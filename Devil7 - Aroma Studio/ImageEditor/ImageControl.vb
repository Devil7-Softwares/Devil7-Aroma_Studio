
'
' * This is a sample implementation of the ImageViewer control 
' * 
' * In this example the image viewer control is hosted in a user control
' * a toolbad containing commands to manipulate an image displayed in the viewer control is 
' * placed so that they could be easily accessed
' * 
' * By Samqty
' 


Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Partial Public Class ImageControl
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' this member method is used to set the source of an image and is exposed to any 
    ''' consuming code, like windows implementing them
    ''' </summary>
    ''' <param name="im">image source object that implement IZImage interface</param>
    Public Sub SetImageSource(ByVal im As IZImage)
        img.SetImageSource(im)
    End Sub

    Private Sub btn_PAN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_PAN.ItemClick
        img.ImagePreviewMode = DirectCast([Enum].Parse(GetType(PreviewMode), DirectCast(sender, ToolStripButton).Tag.ToString()), PreviewMode)
        btn_PAN.Checked = img.ImagePreviewMode = PreviewMode.PAN
        btn_RegionZoom.Checked = img.ImagePreviewMode = PreviewMode.REGIONSELECTION
        btn_ZoomIn.Checked = img.ImagePreviewMode = PreviewMode.ZOOMIN
        btn_ZoomOut.Checked = img.ImagePreviewMode = PreviewMode.ZOOMOUT
        Select Case img.ImagePreviewMode
            Case PreviewMode.PAN
                Me.Cursor = Cursors.Hand
                Exit Select
            Case PreviewMode.REGIONSELECTION
                Me.Cursor = Cursors.Cross
                Exit Select
            Case Else
                Me.Cursor = Cursors.[Default]
                Exit Select

        End Select
    End Sub

    Private Sub cmbZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmb_Zoom_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Zoom.EditValueChanged
        If cmb_Zoom.EditValue.IndexOf("%"c) <> -1 Then
            img.ZoomImage(Double.Parse(cmb_Zoom.EditValue.Trim("%"c)) / 100.0)
        Else
            img.ZoomImage(DirectCast([Enum].Parse(GetType(ZoomMode), cmb_Zoom.EditValue, True), ZoomMode))
        End If
    End Sub
End Class
