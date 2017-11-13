<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.ToolboxControl1 = New DevExpress.XtraToolbox.ToolboxControl()
        Me.Designer = New DevExpress.XtraTab.XtraTabControl()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.SplitterControl2 = New DevExpress.XtraEditors.SplitterControl()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.menu_SolutionExplorer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenInFileExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SIDEBAR_RIGHT = New System.Windows.Forms.Panel()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.SplitterControl3 = New DevExpress.XtraEditors.SplitterControl()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Designer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu_SolutionExplorer.SuspendLayout()
        Me.SIDEBAR_RIGHT.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(896, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(896, 31)
        '
        'ToolboxControl1
        '
        Me.ToolboxControl1.Caption = ""
        Me.ToolboxControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolboxControl1.Location = New System.Drawing.Point(0, 143)
        Me.ToolboxControl1.Name = "ToolboxControl1"
        Me.ToolboxControl1.Size = New System.Drawing.Size(259, 275)
        Me.ToolboxControl1.TabIndex = 2
        '
        'Designer
        '
        Me.Designer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Designer.HeaderButtons = CType((((DevExpress.XtraTab.TabButtons.Prev Or DevExpress.XtraTab.TabButtons.[Next]) _
                    Or DevExpress.XtraTab.TabButtons.Close) _
                    Or DevExpress.XtraTab.TabButtons.[Default]), DevExpress.XtraTab.TabButtons)
        Me.Designer.Location = New System.Drawing.Point(264, 143)
        Me.Designer.Name = "Designer"
        Me.Designer.Size = New System.Drawing.Size(338, 275)
        Me.Designer.TabIndex = 4
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(259, 143)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(5, 275)
        Me.SplitterControl1.TabIndex = 5
        Me.SplitterControl1.TabStop = False
        '
        'SplitterControl2
        '
        Me.SplitterControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitterControl2.Location = New System.Drawing.Point(602, 143)
        Me.SplitterControl2.Name = "SplitterControl2"
        Me.SplitterControl2.Size = New System.Drawing.Size(5, 275)
        Me.SplitterControl2.TabIndex = 6
        Me.SplitterControl2.TabStop = False
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.menu_SolutionExplorer
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(289, 197)
        Me.TreeView1.TabIndex = 2
        '
        'menu_SolutionExplorer
        '
        Me.menu_SolutionExplorer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenInFileExplorerToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.menu_SolutionExplorer.Name = "menu_SolutionExplorer"
        Me.menu_SolutionExplorer.Size = New System.Drawing.Size(183, 70)
        '
        'OpenInFileExplorerToolStripMenuItem
        '
        Me.OpenInFileExplorerToolStripMenuItem.Name = "OpenInFileExplorerToolStripMenuItem"
        Me.OpenInFileExplorerToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.OpenInFileExplorerToolStripMenuItem.Text = "Open In File Explorer"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "code")
        Me.ImageList1.Images.SetKeyName(1, "folder")
        Me.ImageList1.Images.SetKeyName(2, "img")
        Me.ImageList1.Images.SetKeyName(3, "project")
        Me.ImageList1.Images.SetKeyName(4, "theme")
        Me.ImageList1.Images.SetKeyName(5, "zip")
        '
        'SIDEBAR_RIGHT
        '
        Me.SIDEBAR_RIGHT.Controls.Add(Me.PropertyGrid1)
        Me.SIDEBAR_RIGHT.Controls.Add(Me.SplitterControl3)
        Me.SIDEBAR_RIGHT.Controls.Add(Me.TreeView1)
        Me.SIDEBAR_RIGHT.Dock = System.Windows.Forms.DockStyle.Right
        Me.SIDEBAR_RIGHT.Location = New System.Drawing.Point(607, 143)
        Me.SIDEBAR_RIGHT.Name = "SIDEBAR_RIGHT"
        Me.SIDEBAR_RIGHT.Size = New System.Drawing.Size(289, 275)
        Me.SIDEBAR_RIGHT.TabIndex = 9
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid1.Location = New System.Drawing.Point(0, 202)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(289, 73)
        Me.PropertyGrid1.TabIndex = 3
        '
        'SplitterControl3
        '
        Me.SplitterControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl3.Location = New System.Drawing.Point(0, 197)
        Me.SplitterControl3.Name = "SplitterControl3"
        Me.SplitterControl3.Size = New System.Drawing.Size(289, 5)
        Me.SplitterControl3.TabIndex = 4
        Me.SplitterControl3.TabStop = False
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 449)
        Me.Controls.Add(Me.Designer)
        Me.Controls.Add(Me.SplitterControl2)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.ToolboxControl1)
        Me.Controls.Add(Me.SIDEBAR_RIGHT)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "frm_Main"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Designer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu_SolutionExplorer.ResumeLayout(False)
        Me.SIDEBAR_RIGHT.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents ToolboxControl1 As DevExpress.XtraToolbox.ToolboxControl
    Friend WithEvents Designer As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents SplitterControl2 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SIDEBAR_RIGHT As System.Windows.Forms.Panel
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents SplitterControl3 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents menu_SolutionExplorer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenInFileExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem


End Class
