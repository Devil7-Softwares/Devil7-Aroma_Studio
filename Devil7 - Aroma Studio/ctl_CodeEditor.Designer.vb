<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctl_CodeEditor
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TextEditor = New FastColoredTextBoxNS.FastColoredTextBox()
        CType(Me.TextEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextEditor
        '
        Me.TextEditor.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.TextEditor.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*(case|default)\s*[^:]" & _
            "*(?<range>:)\s*(?<range>[^;]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextEditor.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.TextEditor.BackBrush = Nothing
        Me.TextEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2
        Me.TextEditor.CharHeight = 14
        Me.TextEditor.CharWidth = 8
        Me.TextEditor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextEditor.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TextEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextEditor.IsReplaceMode = False
        Me.TextEditor.Language = FastColoredTextBoxNS.Language.CSharp
        Me.TextEditor.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.TextEditor.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(123)
        Me.TextEditor.Location = New System.Drawing.Point(0, 0)
        Me.TextEditor.Name = "TextEditor"
        Me.TextEditor.Paddings = New System.Windows.Forms.Padding(0)
        Me.TextEditor.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.TextEditor.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(125)
        Me.TextEditor.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEditor.Size = New System.Drawing.Size(306, 150)
        Me.TextEditor.TabIndex = 0
        Me.TextEditor.Zoom = 100
        '
        'ctl_CodeEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextEditor)
        Me.Name = "ctl_CodeEditor"
        Me.Size = New System.Drawing.Size(306, 150)
        CType(Me.TextEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextEditor As FastColoredTextBoxNS.FastColoredTextBox

End Class
