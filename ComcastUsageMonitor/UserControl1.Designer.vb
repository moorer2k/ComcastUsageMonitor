Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits MetroUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.buttonTry = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.Enabled = false
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(150, 3)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(105, 75)
        Me.MetroProgressSpinner1.TabIndex = 0
        Me.MetroProgressSpinner1.UseSelectable = true
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Location = New System.Drawing.Point(93, 101)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(218, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Continue to next tab!"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(141, 34)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(122, 64)
        Me.MetroTile1.TabIndex = 2
        Me.MetroTile1.Text = "Authenticated"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroTile1.UseSelectable = true
        Me.MetroTile1.Visible = false
        '
        'buttonTry
        '
        Me.buttonTry.Location = New System.Drawing.Point(141, 104)
        Me.buttonTry.Name = "buttonTry"
        Me.buttonTry.Size = New System.Drawing.Size(122, 23)
        Me.buttonTry.TabIndex = 3
        Me.buttonTry.Text = "Try again.."
        Me.buttonTry.UseSelectable = true
        Me.buttonTry.Visible = false
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.buttonTry)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroProgressSpinner1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(405, 133)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents MetroProgressSpinner1 As MetroProgressSpinner
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents MetroTile1 As MetroTile
    Friend WithEvents buttonTry As MetroButton
End Class
