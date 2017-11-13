

Partial Class ImageControl
    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.img = New Devil7___Aroma_Studio.ImageViewer()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btn_PAN = New DevExpress.XtraBars.BarCheckItem()
        Me.btn_RegionZoom = New DevExpress.XtraBars.BarCheckItem()
        Me.btn_ZoomIn = New DevExpress.XtraBars.BarCheckItem()
        Me.btn_ZoomOut = New DevExpress.XtraBars.BarCheckItem()
        Me.cmb_Zoom = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img
        '
        Me.img.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img.ImagePreviewMode = Devil7___Aroma_Studio.PreviewMode.NONE
        Me.img.Location = New System.Drawing.Point(0, 31)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(351, 234)
        Me.img.TabIndex = 1
        Me.img.Text = "img"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_PAN, Me.btn_RegionZoom, Me.btn_ZoomIn, Me.btn_ZoomOut, Me.cmb_Zoom})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemComboBox1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(365, 133)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_PAN), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_RegionZoom), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_ZoomIn), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_ZoomOut), New DevExpress.XtraBars.LinkPersistInfo(Me.cmb_Zoom)})
        Me.Bar1.Offset = 3
        Me.Bar1.Text = "Tools"
        '
        'btn_PAN
        '
        Me.btn_PAN.Caption = "PAN"
        Me.btn_PAN.Id = 0
        Me.btn_PAN.ImageOptions.Image = Global.Devil7___Aroma_Studio.My.Resources.Resources.icon_hand
        Me.btn_PAN.Name = "btn_PAN"
        '
        'btn_RegionZoom
        '
        Me.btn_RegionZoom.Caption = "Region Zoom"
        Me.btn_RegionZoom.Id = 1
        Me.btn_RegionZoom.ImageOptions.Image = Global.Devil7___Aroma_Studio.My.Resources.Resources.region_zoom
        Me.btn_RegionZoom.Name = "btn_RegionZoom"
        '
        'btn_ZoomIn
        '
        Me.btn_ZoomIn.Caption = "Zoom In"
        Me.btn_ZoomIn.Id = 2
        Me.btn_ZoomIn.ImageOptions.Image = Global.Devil7___Aroma_Studio.My.Resources.Resources.zoom_in
        Me.btn_ZoomIn.Name = "btn_ZoomIn"
        '
        'btn_ZoomOut
        '
        Me.btn_ZoomOut.Caption = "Zoom Out"
        Me.btn_ZoomOut.Id = 3
        Me.btn_ZoomOut.ImageOptions.Image = Global.Devil7___Aroma_Studio.My.Resources.Resources.zoom_out
        Me.btn_ZoomOut.Name = "btn_ZoomOut"
        '
        'cmb_Zoom
        '
        Me.cmb_Zoom.Caption = "Zoom"
        Me.cmb_Zoom.Edit = Me.RepositoryItemComboBox1
        Me.cmb_Zoom.Id = 5
        Me.cmb_Zoom.Name = "cmb_Zoom"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"10%", "25%", "66%", "100%", "200%", "400%", "FITPAGE", "FITWIDTH", "FITHEIGHT", "ACTUALSIZE"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(351, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 265)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(351, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 234)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(351, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 234)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'ImageControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.img)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ImageControl"
        Me.Size = New System.Drawing.Size(351, 265)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents img As ImageViewer
    Private WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_PAN As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_RegionZoom As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btn_ZoomIn As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btn_ZoomOut As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents cmb_Zoom As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
