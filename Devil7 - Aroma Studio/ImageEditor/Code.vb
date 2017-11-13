
'
' * Image Viewer component source
' * 
' * definations found in this file are
' * -ImageViewer class
' * -ZoomMode enumeration
' * -PreviewMode enumeration
' * -IZImage interface
' * 
' 


Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing

''' <summary>
''' this class extends from control
''' provides the capability of displaying images with enhaced features of previewing them
''' </summary>
Public Class ImageViewer
    Inherits Control
#Region "member fields"

    'the interface that isolates the required properties and methods from any object that implement it
    Private mainImage As IZImage
    'a private member that temporarly holds the image that is currently being displayed
    Private originalImage As Image
    'the amount by which the current image is zoomed
    Private mZoom As Double
    'this is the coordinate of the center of the image displayed on the control in reference to 
    'the coordinate system of the original image
    Private displayCenter As Point
    'a bitmap that is used to draw the requested portion of the image on to the display
    Private displayImage As Bitmap
    'determines how the mouse behaves on the image
    Private previewMode As PreviewMode

    'the base control that is used to to display the finalized version of the requested image
    Private pic As PictureBox

    'a private member that temporarly holds points in the process of manipulations
    Private tempCenter As Point

    'the following members are used to hold a certain number of values when ever the display
    'changes so that the hosting control can request the previously previewed portions of the image
    'A collection of double variables that holds a certain amount of zoom values
    Private zoomValues As List(Of Double)
    'A Collection of Point structures that holds a certain amount of displayed center values
    Private centerValues As List(Of Point)
    'a variable that limites the back tracking capacity of the history facility
    Const HISTORYCAPACITY As Integer = 5

#End Region

#Region "member properties"

    ''' <summary>
    ''' gets or sets how the mouse behaves on the image control display area
    ''' </summary>
    Public Property ImagePreviewMode() As PreviewMode
        Get
            Return previewMode
        End Get
        Set(ByVal value As PreviewMode)
            previewMode = Value
        End Set
    End Property

    ''' <summary>
    ''' get the original image that is currently being diplayed
    ''' the entire image even though it is not fully displayed
    ''' </summary>
    Public ReadOnly Property CurrentImage() As Image
        Get
            Return originalImage
        End Get
    End Property

    ''' <summary>
    ''' returns the image that is displayed on the screen
    ''' </summary>
    Public ReadOnly Property CurrentDisplayedImage() As Image
        Get
            Return displayImage
        End Get
    End Property

#End Region

#Region "member methods"

    ''' <summary>
    ''' this method draws the image with the image mode specified
    ''' </summary>
    ''' <param name="md">describes how the original image will appear in the control</param>
    Public Sub ZoomImage(ByVal md As ZoomMode)
        '
        '             * what this function basically does is retrieve the zoom mode requested
        '             * then compute the center and zoom values that are appropriate to correctly display
        '             * the image in the requested mode
        '             

        Select Case md
            Case ZoomMode.ACTUALSIZE
                mZoom = 1
                displayCenter = New Point(originalImage.Width / 2, originalImage.Height / 2)
                Exit Select
            Case ZoomMode.FITHEIGHT
                mZoom = CDbl(Me.Height) / originalImage.Height
                displayCenter = New Point(originalImage.Width / 2, originalImage.Height / 2)
                Exit Select
            Case ZoomMode.FITPAGE
                mZoom = CDbl(Me.Height) / originalImage.Height
                If CDbl(Me.Width) / originalImage.Width < mZoom Then
                    mZoom = Me.Width / originalImage.Width
                End If
                displayCenter = New Point(originalImage.Width / 2, originalImage.Height / 2)
                Exit Select
            Case ZoomMode.FITWIDTH
                mZoom = CDbl(Me.Width) / originalImage.Width
                displayCenter = New Point(originalImage.Width / 2, originalImage.Height / 2)
                Exit Select
            Case Else
                Throw New Exception("Invalid zoom request!!")
        End Select
        'once the values have been calculated call the zoomimage function to redraw the image
        'with the new parameters 
        ZoomImage()
    End Sub

    ''' <summary>
    ''' this method draws the image with the zoom amount as well as the center of the image specified
    ''' </summary>
    ''' <param name="z">the value by how much the image will be zoomed</param>
    ''' <param name="pt">the center coordinate of the image in reference to the original coordinate system</param>
    Public Sub ZoomImage(ByVal z As Double, ByVal pt As Point)
        'provided both the center and the zoom value 
        mZoom = z

        'build the source rectangle extracted from the original image
        Dim rect As New Rectangle(pt.X - CInt(Me.Width / (2 * z)), pt.Y - CInt(Me.Height / (2 * z)), CInt(Me.Width / z), CInt(Me.Height / z))

        'call the drawImage method to draw the selected image in the rectangle
        DrawImage(rect)
    End Sub

    ''' <summary>
    ''' this is an overload that retains the center of the image and zooms the image with the value specified
    ''' </summary>
    ''' <param name="z">the value by how much the image will be zooomed</param>
    Public Sub ZoomImage(ByVal z As Double)
        'by chaning the zoom value and retaining the center value 
        'redraw the image
        mZoom = z
        ZoomImage()
    End Sub

    ''' <summary>
    ''' this is an over load that retains both the center of the image as well as the zoom value 
    ''' mostly used to redraw the image, in cases like resizing the control
    ''' </summary>
    Public Sub ZoomImage()
        'using the private members zoomvalue and display center 
        'compute the source rectangel from the original image
        Dim rect As New Rectangle(displayCenter.X - CInt(Me.Width / (2 * mZoom)), displayCenter.Y - CInt(Me.Height / (2 * mZoom)), CInt(CDbl(Me.Width) / mZoom), CInt(CDbl(Me.Height) / mZoom))

        'call the drawimage function to extract the selected rectangel
        DrawImage(rect)
    End Sub

    ''' <summary>
    ''' a method used by the class to draw the final region of the the original image 
    ''' </summary>
    ''' <param name="rect">the requested region of the image</param>
    Private Sub DrawImage(ByVal rect As Rectangle)
        '
        '             * this is the main function that actually does the drawing of the image
        '             * It takes the source rectangle which is to be displayed to the control
        '             * and draws this image on the displayedimage bitmap pbject
        '             

        Dim gr As Graphics = Graphics.FromImage(displayImage)

        'first draw a white back ground to clear all the drawings performed earlier
        gr.FillRectangle(Brushes.White, New Rectangle(0, 0, displayImage.Width, displayImage.Height))
        'draw the selected rectangel on to the displayedimage bitmap

        gr.DrawImage(originalImage, New Rectangle(0, 0, displayImage.Width, displayImage.Height), rect, GraphicsUnit.Pixel)

        'assign this bitmap to the picture control for display
        pic.Image = displayImage

        'save the values to history
        AddDisplayLog()
    End Sub

    ''' <summary>
    ''' a method that requests the next available image from the source image
    ''' </summary>
    Public Sub MoveToNextImage()
        'check to see if the current index does not go out of bound
        If mainImage.CurrentIndex < mainImage.ImageCount Then
            'retrieve the next image from the image source
            originalImage = mainImage.GetNextImage()
            'diplay the image to fit the display screen
            ZoomImage(ZoomMode.FITPAGE)
        End If
    End Sub

    ''' <summary>
    ''' a method that requests the previous image from the source image
    ''' </summary>
    Public Sub MoveToPreviousImage()
        'check if the current index does not go out of bound
        If mainImage.CurrentIndex > 0 Then
            'retrieve the previous image from the image source object
            originalImage = mainImage.GetPreviousImage()
            'displaye the image to fit the diplay screen
            ZoomImage(ZoomMode.FITPAGE)
        End If
    End Sub

    ''' <summary>
    ''' this method sets the source of the image collections that will be displayed:
    ''' it could be any object that implements IZImage interface
    ''' </summary>
    ''' <param name="img">source object that implement IZImage</param>
    Public Sub SetImageSource(ByVal img As IZImage)
        'sets the image source object
        mainImage = img
        'displays the first image in the source
        MoveToNextImage()
    End Sub

    ''' <summary>
    ''' this method rotated the image 
    ''' </summary>
    ''' <param name="ClockWise">specifies if its clockwise or the other</param>
    Public Sub RotateImage(ByVal ClockWise As Boolean)
        If originalImage IsNot Nothing Then
            originalImage.RotateFlip(RotateFlipType.Rotate90FlipXY)
            ZoomImage(ZoomMode.FITPAGE)
        End If
    End Sub

    ''' <summary>
    ''' this is a private method that initializes the collections used to log preview values
    ''' </summary>
    Private Sub InitializeHistory()
        'instantiate the collections used to store the zoom and center values
        zoomValues = New List(Of Double)()
        centerValues = New List(Of Point)()
    End Sub

    ''' <summary>
    ''' a private method that logs the current display values into the collection
    ''' its bahaves as:
    ''' it inserts the current value and removes the final one if the capacity is full
    ''' </summary>
    Private Sub AddDisplayLog()
        'insert the last action performed to the first index of the list
        centerValues.Insert(0, displayCenter)
        zoomValues.Insert(0, mZoom)

        'if the list has exceeded its capacity then remove the last item from each of the collections
        If centerValues.Count > HISTORYCAPACITY Then
            centerValues.RemoveAt(HISTORYCAPACITY)
            zoomValues.RemoveAt(HISTORYCAPACITY)
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.pic = New System.Windows.Forms.PictureBox()
        DirectCast(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' pic
        ' 
        Me.pic.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic.Location = New System.Drawing.Point(0, 0)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(50, 50)
        Me.pic.TabIndex = 0
        Me.pic.TabStop = False
        AddHandler Me.pic.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.pic_MouseMove)
        AddHandler Me.pic.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.pic_MouseDown)
        AddHandler Me.pic.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.pic_MouseUp)
        AddHandler Me.pic.SizeChanged, New System.EventHandler(AddressOf Me.pic_SizeChanged)
        ' 
        ' ImageViewer
        ' 
        Me.Controls.Add(Me.pic)
        Me.Size = New System.Drawing.Size(50, 50)
        DirectCast(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Constructors"

    ''' <summary>
    ''' initialilzes the default values of the control
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        mZoom = 1
        previewMode = previewMode.NONE
        displayImage = New Bitmap(Me.Width, Me.Height)
        InitializeHistory()
    End Sub

    ''' <summary>
    ''' initilizes the image control object with the source provided
    ''' </summary>
    ''' <param name="img">source image</param>
    Public Sub New(ByVal img As IZImage)
        Me.New()
        SetImageSource(img)
    End Sub

#End Region

#Region "event handlers"

    Private Sub pic_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
        'when the size of the image is changed then the size of the bitmap 
        'used to draw the selected image will change 
        displayImage = New Bitmap(Me.Width, Me.Height)

        'redraw the image if there exists the image
        If originalImage IsNot Nothing Then
            ZoomImage(mZoom, displayCenter)
        End If
    End Sub

    Private Sub pic_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        'in cases where the display mode is pan or region select
        'there is a need to retain the first point of the mouse
        'this coordinate is then stored in the temporary variable 
        Select Case previewMode
            Case previewMode.REGIONSELECTION, previewMode.PAN
                tempCenter = e.Location
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub pic_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        'when a mouse is down and moving 
        'panning and region selection are posibilities
        Select Case previewMode
            Case previewMode.REGIONSELECTION
                If e.Button = MouseButtons.Left Then
                    'display a rectangular region to the selected region 
                    'to notify the user what he is selecting
                    Dim w As Integer = Math.Abs(tempCenter.X - e.X), h As Integer = Math.Abs(tempCenter.Y - e.Y)
                    If w > 1 OrElse h > 1 Then
                        Me.Refresh()
                        Dim gr As Graphics = pic.CreateGraphics()
                        gr.DrawString("(" + (tempCenter.X + e.X) / 2 + "," + (tempCenter.Y + e.Y) / 2 + ")", Me.Font, Brushes.Khaki, New PointF((tempCenter.X + e.X) / 2, (tempCenter.Y + e.Y) / 2))
                        gr.DrawRectangle(Pens.Red, New Rectangle((tempCenter.X + e.X - w) / 2, (tempCenter.Y + e.Y - h) / 2, w, h))
                        gr.Dispose()
                    End If
                End If
                Exit Select
            Case previewMode.PAN
                If e.Button = MouseButtons.Left AndAlso (tempCenter.X <> e.X OrElse tempCenter.Y <> e.Y) Then
                    displayCenter = New Point(displayCenter.X + CInt((tempCenter.X - e.X) / mZoom), displayCenter.Y + CInt((tempCenter.Y - e.Y) / mZoom))
                    ZoomImage()
                    tempCenter = e.Location
                End If
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub pic_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        'when the mouse is up its when most of the previews are commited
        Select Case previewMode
            Case previewMode.REGIONSELECTION
                displayCenter = New Point(displayCenter.X + CInt((CDbl(tempCenter.X + e.X - Me.Width) / 2) / mZoom), displayCenter.Y + CInt((CDbl(tempCenter.Y + e.Y - Me.Height) / 2) / mZoom))

                Dim z As Double = mZoom * pic.Width / Math.Abs(tempCenter.X - e.X)
                If mZoom * pic.Height / Math.Abs(tempCenter.Y - e.Y) < z Then
                    z = mZoom * pic.Height / Math.Abs(tempCenter.Y - e.Y)
                End If
                mZoom = z
                ZoomImage()
                Exit Select
            Case previewMode.ZOOMIN
                'when zoom in the zoom value is simply multiplied by two
                displayCenter = New Point(displayCenter.X + CInt((e.X - Me.Width / 2) / mZoom), displayCenter.Y + CInt((e.Y - Me.Height / 2) / mZoom))
                mZoom *= 2
                'redraw the image with the new zoom value
                ZoomImage()
                Exit Select
            Case previewMode.ZOOMOUT
                'when zoom out the zoom value is simply divided by two
                displayCenter = New Point(displayCenter.X + CInt((e.X - Me.Width / 2) / mZoom), displayCenter.Y + CInt((e.Y - Me.Height / 2) / mZoom))
                mZoom /= 2
                'redraw the image with the new zoom value
                ZoomImage()
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub

#End Region
End Class

''' <summary>
''' enumerations that specifies the zoom modes available when ever an image is on display
''' </summary>
Public Enum ZoomMode
    FITPAGE
    'displays the entire image in the diplay region
    FITWIDTH
    'fits the image in the width of the control
    FITHEIGHT
    'fits the image in the height of the control
    ACTUALSIZE
    'displays the acutal size of the image
End Enum

''' <summary>
''' enumerations that specifies how the mouse behaves over the control
''' </summary>
Public Enum PreviewMode
    REGIONSELECTION
    'enables the user to select a region to zoom
    ZOOMIN
    'enables the user to zoom in to a point
    ZOOMOUT
    'anables the user to zoom out to a point
    PAN
    'anables the user to grab and pan the image
    NONE
End Enum

''' <summary>
''' a signiture interface that when implemented by any object
''' enables it to utilize the image viewer component
''' </summary>
Public Interface IZImage
    'gets the number of images that are available for display
    ReadOnly Property ImageCount() As Integer
    'gets the current index of the image that is being displayed
    ReadOnly Property CurrentIndex() As Integer
    'retreives the next available image
    Function GetNextImage() As Image
    'retrieves the previously displayed image
    Function GetPreviousImage() As Image
End Interface
