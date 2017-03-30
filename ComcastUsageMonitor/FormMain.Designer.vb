Imports MetroFramework.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.buttonLogin = New MetroFramework.Controls.MetroButton()
        Me.textPass = New MetroFramework.Controls.MetroTextBox()
        Me.textEmail = New MetroFramework.Controls.MetroTextBox()
        Me.checkRemember = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.tileStatus = New MetroFramework.Controls.MetroTile()
        Me.labelOverUsed = New MetroFramework.Controls.MetroLabel()
        Me.labelOverBandwidth = New MetroFramework.Controls.MetroLabel()
        Me.labelMax = New MetroFramework.Controls.MetroLabel()
        Me.labelMaxBandwidth = New MetroFramework.Controls.MetroLabel()
        Me.labelCurrent = New MetroFramework.Controls.MetroLabel()
        Me.labelCurrBandwidth = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.PolicyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomeUsageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllowableUsageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitOfMeasureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalBlocksUsedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalCostPerBlockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalUnitsPerBlockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalIncludedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalUsedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalPercentUsedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalRemainingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillableOverageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverageChargesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverageUsedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentCreditAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxCreditAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolicyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsageMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.comboColor = New MetroFramework.Controls.MetroComboBox()
        Me.buttonSave = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.buttonTest = New MetroFramework.Controls.MetroButton()
        Me.comboStyle = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        CType(Me.MetroStyleManager1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.MetroTabControl1.SuspendLayout
        Me.MetroTabPage1.SuspendLayout
        Me.MetroTabPage2.SuspendLayout
        Me.MetroTabPage3.SuspendLayout
        CType(Me.MetroGrid1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UsageMonthBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.MetroTabPage4.SuspendLayout
        Me.MetroPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Location = New System.Drawing.Point(245, 95)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.MetroProgressBar1.Size = New System.Drawing.Size(157, 19)
        Me.MetroProgressBar1.TabIndex = 4
        Me.MetroProgressBar1.Value = 1
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.MetroTabControl1.Multiline = true
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(413, 160)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = true
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.buttonLogin)
        Me.MetroTabPage1.Controls.Add(Me.textPass)
        Me.MetroTabPage1.Controls.Add(Me.textEmail)
        Me.MetroTabPage1.Controls.Add(Me.checkRemember)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = true
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.MetroTabPage1.Size = New System.Drawing.Size(405, 118)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Comcast Login"
        Me.MetroTabPage1.VerticalScrollbarBarColor = true
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = false
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'buttonLogin
        '
        Me.buttonLogin.Location = New System.Drawing.Point(300, 85)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(97, 30)
        Me.buttonLogin.TabIndex = 3
        Me.buttonLogin.Text = "Login"
        Me.buttonLogin.UseSelectable = true
        '
        'textPass
        '
        '
        '
        '
        Me.textPass.CustomButton.Image = Nothing
        Me.textPass.CustomButton.Location = New System.Drawing.Point(225, 1)
        Me.textPass.CustomButton.Name = ""
        Me.textPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.textPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textPass.CustomButton.TabIndex = 1
        Me.textPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textPass.CustomButton.UseSelectable = true
        Me.textPass.CustomButton.Visible = false
        Me.textPass.Lines = New String(-1) {}
        Me.textPass.Location = New System.Drawing.Point(150, 44)
        Me.textPass.MaxLength = 32767
        Me.textPass.Name = "textPass"
        Me.textPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textPass.SelectedText = ""
        Me.textPass.SelectionLength = 0
        Me.textPass.SelectionStart = 0
        Me.textPass.ShortcutsEnabled = true
        Me.textPass.Size = New System.Drawing.Size(247, 23)
        Me.textPass.TabIndex = 1
        Me.textPass.UseSelectable = true
        Me.textPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.textPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'textEmail
        '
        '
        '
        '
        Me.textEmail.CustomButton.Image = Nothing
        Me.textEmail.CustomButton.Location = New System.Drawing.Point(225, 1)
        Me.textEmail.CustomButton.Name = ""
        Me.textEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.textEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textEmail.CustomButton.TabIndex = 1
        Me.textEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textEmail.CustomButton.UseSelectable = true
        Me.textEmail.CustomButton.Visible = false
        Me.textEmail.Lines = New String(-1) {}
        Me.textEmail.Location = New System.Drawing.Point(150, 15)
        Me.textEmail.MaxLength = 32767
        Me.textEmail.Name = "textEmail"
        Me.textEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textEmail.SelectedText = ""
        Me.textEmail.SelectionLength = 0
        Me.textEmail.SelectionStart = 0
        Me.textEmail.ShortcutsEnabled = true
        Me.textEmail.Size = New System.Drawing.Size(247, 23)
        Me.textEmail.TabIndex = 0
        Me.textEmail.UseSelectable = true
        Me.textEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.textEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'checkRemember
        '
        Me.checkRemember.AutoSize = true
        Me.checkRemember.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.checkRemember.Location = New System.Drawing.Point(150, 85)
        Me.checkRemember.Name = "checkRemember"
        Me.checkRemember.Size = New System.Drawing.Size(98, 15)
        Me.checkRemember.TabIndex = 2
        Me.checkRemember.Text = "Remember me"
        Me.checkRemember.UseSelectable = true
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = true
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 47)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Comcast Password:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 15)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(141, 23)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Comcast Username:"
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.tileStatus)
        Me.MetroTabPage2.Controls.Add(Me.labelOverUsed)
        Me.MetroTabPage2.Controls.Add(Me.labelOverBandwidth)
        Me.MetroTabPage2.Controls.Add(Me.labelMax)
        Me.MetroTabPage2.Controls.Add(Me.labelMaxBandwidth)
        Me.MetroTabPage2.Controls.Add(Me.labelCurrent)
        Me.MetroTabPage2.Controls.Add(Me.labelCurrBandwidth)
        Me.MetroTabPage2.Controls.Add(Me.MetroProgressBar1)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = true
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.MetroTabPage2.Size = New System.Drawing.Size(405, 118)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Bandwidth Usage"
        Me.MetroTabPage2.VerticalScrollbarBarColor = true
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = false
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'tileStatus
        '
        Me.tileStatus.ActiveControl = Nothing
        Me.tileStatus.Location = New System.Drawing.Point(245, 16)
        Me.tileStatus.Name = "tileStatus"
        Me.tileStatus.Size = New System.Drawing.Size(157, 73)
        Me.tileStatus.TabIndex = 6
        Me.tileStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tileStatus.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tileStatus.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.tileStatus.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.tileStatus.UseSelectable = true
        '
        'labelOverUsed
        '
        Me.labelOverUsed.AutoSize = true
        Me.labelOverUsed.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelOverUsed.Location = New System.Drawing.Point(163, 95)
        Me.labelOverUsed.Name = "labelOverUsed"
        Me.labelOverUsed.Size = New System.Drawing.Size(40, 19)
        Me.labelOverUsed.TabIndex = 5
        Me.labelOverUsed.Text = "0 GB"
        '
        'labelOverBandwidth
        '
        Me.labelOverBandwidth.AutoSize = true
        Me.labelOverBandwidth.Location = New System.Drawing.Point(4, 95)
        Me.labelOverBandwidth.Name = "labelOverBandwidth"
        Me.labelOverBandwidth.Size = New System.Drawing.Size(133, 19)
        Me.labelOverBandwidth.TabIndex = 5
        Me.labelOverBandwidth.Text = "Overused Bandwidth:"
        '
        'labelMax
        '
        Me.labelMax.AutoSize = true
        Me.labelMax.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelMax.Location = New System.Drawing.Point(163, 55)
        Me.labelMax.Name = "labelMax"
        Me.labelMax.Size = New System.Drawing.Size(17, 19)
        Me.labelMax.TabIndex = 5
        Me.labelMax.Text = "0"
        '
        'labelMaxBandwidth
        '
        Me.labelMaxBandwidth.AutoSize = true
        Me.labelMaxBandwidth.Location = New System.Drawing.Point(4, 55)
        Me.labelMaxBandwidth.Name = "labelMaxBandwidth"
        Me.labelMaxBandwidth.Size = New System.Drawing.Size(153, 19)
        Me.labelMaxBandwidth.TabIndex = 5
        Me.labelMaxBandwidth.Text = "Max Allowed Bandwidth:"
        '
        'labelCurrent
        '
        Me.labelCurrent.AutoSize = true
        Me.labelCurrent.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelCurrent.Location = New System.Drawing.Point(163, 15)
        Me.labelCurrent.Name = "labelCurrent"
        Me.labelCurrent.Size = New System.Drawing.Size(17, 19)
        Me.labelCurrent.TabIndex = 5
        Me.labelCurrent.Text = "0"
        '
        'labelCurrBandwidth
        '
        Me.labelCurrBandwidth.AutoSize = true
        Me.labelCurrBandwidth.Location = New System.Drawing.Point(4, 15)
        Me.labelCurrBandwidth.Name = "labelCurrBandwidth"
        Me.labelCurrBandwidth.Size = New System.Drawing.Size(154, 19)
        Me.labelCurrBandwidth.TabIndex = 5
        Me.labelCurrBandwidth.Text = "Current Used Bandwidth:"
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.MetroGrid1)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = true
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.MetroTabPage3.Size = New System.Drawing.Size(405, 118)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Usage History"
        Me.MetroTabPage3.VerticalScrollbarBarColor = true
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = false
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = false
        Me.MetroGrid1.AutoGenerateColumns = false
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PolicyNameDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn, Me.HomeUsageDataGridViewTextBoxColumn, Me.AllowableUsageDataGridViewTextBoxColumn, Me.UnitOfMeasureDataGridViewTextBoxColumn, Me.AdditionalBlocksUsedDataGridViewTextBoxColumn, Me.AdditionalCostPerBlockDataGridViewTextBoxColumn, Me.AdditionalUnitsPerBlockDataGridViewTextBoxColumn, Me.AdditionalIncludedDataGridViewTextBoxColumn, Me.AdditionalUsedDataGridViewTextBoxColumn, Me.AdditionalPercentUsedDataGridViewTextBoxColumn, Me.AdditionalRemainingDataGridViewTextBoxColumn, Me.BillableOverageDataGridViewTextBoxColumn, Me.OverageChargesDataGridViewTextBoxColumn, Me.OverageUsedDataGridViewTextBoxColumn, Me.CurrentCreditAmountDataGridViewTextBoxColumn, Me.MaxCreditAmountDataGridViewTextBoxColumn, Me.PolicyDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.UsageMonthBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid1.EnableHeadersVisualStyles = false
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(0, 0)
        Me.MetroGrid1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(400, 118)
        Me.MetroGrid1.TabIndex = 2
        '
        'PolicyNameDataGridViewTextBoxColumn
        '
        Me.PolicyNameDataGridViewTextBoxColumn.DataPropertyName = "PolicyName"
        Me.PolicyNameDataGridViewTextBoxColumn.HeaderText = "PolicyName"
        Me.PolicyNameDataGridViewTextBoxColumn.Name = "PolicyNameDataGridViewTextBoxColumn"
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate"
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "StartDate"
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        '
        'EndDateDataGridViewTextBoxColumn
        '
        Me.EndDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate"
        Me.EndDateDataGridViewTextBoxColumn.HeaderText = "EndDate"
        Me.EndDateDataGridViewTextBoxColumn.Name = "EndDateDataGridViewTextBoxColumn"
        '
        'HomeUsageDataGridViewTextBoxColumn
        '
        Me.HomeUsageDataGridViewTextBoxColumn.DataPropertyName = "HomeUsage"
        Me.HomeUsageDataGridViewTextBoxColumn.HeaderText = "HomeUsage"
        Me.HomeUsageDataGridViewTextBoxColumn.Name = "HomeUsageDataGridViewTextBoxColumn"
        '
        'AllowableUsageDataGridViewTextBoxColumn
        '
        Me.AllowableUsageDataGridViewTextBoxColumn.DataPropertyName = "AllowableUsage"
        Me.AllowableUsageDataGridViewTextBoxColumn.HeaderText = "AllowableUsage"
        Me.AllowableUsageDataGridViewTextBoxColumn.Name = "AllowableUsageDataGridViewTextBoxColumn"
        '
        'UnitOfMeasureDataGridViewTextBoxColumn
        '
        Me.UnitOfMeasureDataGridViewTextBoxColumn.DataPropertyName = "UnitOfMeasure"
        Me.UnitOfMeasureDataGridViewTextBoxColumn.HeaderText = "UnitOfMeasure"
        Me.UnitOfMeasureDataGridViewTextBoxColumn.Name = "UnitOfMeasureDataGridViewTextBoxColumn"
        '
        'AdditionalBlocksUsedDataGridViewTextBoxColumn
        '
        Me.AdditionalBlocksUsedDataGridViewTextBoxColumn.DataPropertyName = "AdditionalBlocksUsed"
        Me.AdditionalBlocksUsedDataGridViewTextBoxColumn.HeaderText = "AdditionalBlocksUsed"
        Me.AdditionalBlocksUsedDataGridViewTextBoxColumn.Name = "AdditionalBlocksUsedDataGridViewTextBoxColumn"
        '
        'AdditionalCostPerBlockDataGridViewTextBoxColumn
        '
        Me.AdditionalCostPerBlockDataGridViewTextBoxColumn.DataPropertyName = "AdditionalCostPerBlock"
        Me.AdditionalCostPerBlockDataGridViewTextBoxColumn.HeaderText = "AdditionalCostPerBlock"
        Me.AdditionalCostPerBlockDataGridViewTextBoxColumn.Name = "AdditionalCostPerBlockDataGridViewTextBoxColumn"
        '
        'AdditionalUnitsPerBlockDataGridViewTextBoxColumn
        '
        Me.AdditionalUnitsPerBlockDataGridViewTextBoxColumn.DataPropertyName = "AdditionalUnitsPerBlock"
        Me.AdditionalUnitsPerBlockDataGridViewTextBoxColumn.HeaderText = "AdditionalUnitsPerBlock"
        Me.AdditionalUnitsPerBlockDataGridViewTextBoxColumn.Name = "AdditionalUnitsPerBlockDataGridViewTextBoxColumn"
        '
        'AdditionalIncludedDataGridViewTextBoxColumn
        '
        Me.AdditionalIncludedDataGridViewTextBoxColumn.DataPropertyName = "AdditionalIncluded"
        Me.AdditionalIncludedDataGridViewTextBoxColumn.HeaderText = "AdditionalIncluded"
        Me.AdditionalIncludedDataGridViewTextBoxColumn.Name = "AdditionalIncludedDataGridViewTextBoxColumn"
        '
        'AdditionalUsedDataGridViewTextBoxColumn
        '
        Me.AdditionalUsedDataGridViewTextBoxColumn.DataPropertyName = "AdditionalUsed"
        Me.AdditionalUsedDataGridViewTextBoxColumn.HeaderText = "AdditionalUsed"
        Me.AdditionalUsedDataGridViewTextBoxColumn.Name = "AdditionalUsedDataGridViewTextBoxColumn"
        '
        'AdditionalPercentUsedDataGridViewTextBoxColumn
        '
        Me.AdditionalPercentUsedDataGridViewTextBoxColumn.DataPropertyName = "AdditionalPercentUsed"
        Me.AdditionalPercentUsedDataGridViewTextBoxColumn.HeaderText = "AdditionalPercentUsed"
        Me.AdditionalPercentUsedDataGridViewTextBoxColumn.Name = "AdditionalPercentUsedDataGridViewTextBoxColumn"
        '
        'AdditionalRemainingDataGridViewTextBoxColumn
        '
        Me.AdditionalRemainingDataGridViewTextBoxColumn.DataPropertyName = "AdditionalRemaining"
        Me.AdditionalRemainingDataGridViewTextBoxColumn.HeaderText = "AdditionalRemaining"
        Me.AdditionalRemainingDataGridViewTextBoxColumn.Name = "AdditionalRemainingDataGridViewTextBoxColumn"
        '
        'BillableOverageDataGridViewTextBoxColumn
        '
        Me.BillableOverageDataGridViewTextBoxColumn.DataPropertyName = "BillableOverage"
        Me.BillableOverageDataGridViewTextBoxColumn.HeaderText = "BillableOverage"
        Me.BillableOverageDataGridViewTextBoxColumn.Name = "BillableOverageDataGridViewTextBoxColumn"
        '
        'OverageChargesDataGridViewTextBoxColumn
        '
        Me.OverageChargesDataGridViewTextBoxColumn.DataPropertyName = "OverageCharges"
        Me.OverageChargesDataGridViewTextBoxColumn.HeaderText = "OverageCharges"
        Me.OverageChargesDataGridViewTextBoxColumn.Name = "OverageChargesDataGridViewTextBoxColumn"
        '
        'OverageUsedDataGridViewTextBoxColumn
        '
        Me.OverageUsedDataGridViewTextBoxColumn.DataPropertyName = "OverageUsed"
        Me.OverageUsedDataGridViewTextBoxColumn.HeaderText = "OverageUsed"
        Me.OverageUsedDataGridViewTextBoxColumn.Name = "OverageUsedDataGridViewTextBoxColumn"
        '
        'CurrentCreditAmountDataGridViewTextBoxColumn
        '
        Me.CurrentCreditAmountDataGridViewTextBoxColumn.DataPropertyName = "CurrentCreditAmount"
        Me.CurrentCreditAmountDataGridViewTextBoxColumn.HeaderText = "CurrentCreditAmount"
        Me.CurrentCreditAmountDataGridViewTextBoxColumn.Name = "CurrentCreditAmountDataGridViewTextBoxColumn"
        '
        'MaxCreditAmountDataGridViewTextBoxColumn
        '
        Me.MaxCreditAmountDataGridViewTextBoxColumn.DataPropertyName = "MaxCreditAmount"
        Me.MaxCreditAmountDataGridViewTextBoxColumn.HeaderText = "MaxCreditAmount"
        Me.MaxCreditAmountDataGridViewTextBoxColumn.Name = "MaxCreditAmountDataGridViewTextBoxColumn"
        '
        'PolicyDataGridViewTextBoxColumn
        '
        Me.PolicyDataGridViewTextBoxColumn.DataPropertyName = "Policy"
        Me.PolicyDataGridViewTextBoxColumn.HeaderText = "Policy"
        Me.PolicyDataGridViewTextBoxColumn.Name = "PolicyDataGridViewTextBoxColumn"
        '
        'UsageMonthBindingSource
        '
        Me.UsageMonthBindingSource.DataSource = GetType(ComcastUsageMonitor.apis.xfinity.services.xfinity.internet.usage.UsageMonth)
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.Controls.Add(Me.MetroPanel1)
        Me.MetroTabPage4.HorizontalScrollbarBarColor = true
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.MetroTabPage4.Size = New System.Drawing.Size(405, 118)
        Me.MetroTabPage4.TabIndex = 3
        Me.MetroTabPage4.Text = "Settings"
        Me.MetroTabPage4.VerticalScrollbarBarColor = true
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = false
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.comboColor)
        Me.MetroPanel1.Controls.Add(Me.buttonSave)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.buttonTest)
        Me.MetroPanel1.Controls.Add(Me.comboStyle)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.HorizontalScrollbarBarColor = true
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 10)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(236, 105)
        Me.MetroPanel1.TabIndex = 5
        Me.MetroPanel1.VerticalScrollbarBarColor = true
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = false
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'comboColor
        '
        Me.comboColor.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.comboColor.FormattingEnabled = true
        Me.comboColor.ItemHeight = 19
        Me.comboColor.Location = New System.Drawing.Point(104, 39)
        Me.comboColor.Name = "comboColor"
        Me.comboColor.Size = New System.Drawing.Size(124, 25)
        Me.comboColor.TabIndex = 1
        Me.comboColor.UseSelectable = true
        '
        'buttonSave
        '
        Me.buttonSave.Location = New System.Drawing.Point(169, 71)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(59, 23)
        Me.buttonSave.TabIndex = 4
        Me.buttonSave.Text = "Save"
        Me.buttonSave.UseSelectable = true
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = true
        Me.MetroLabel5.Location = New System.Drawing.Point(9, 8)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel5.TabIndex = 2
        Me.MetroLabel5.Text = "Theme Style:"
        '
        'buttonTest
        '
        Me.buttonTest.Location = New System.Drawing.Point(104, 71)
        Me.buttonTest.Name = "buttonTest"
        Me.buttonTest.Size = New System.Drawing.Size(59, 23)
        Me.buttonTest.TabIndex = 3
        Me.buttonTest.Text = "Test"
        Me.buttonTest.UseSelectable = true
        '
        'comboStyle
        '
        Me.comboStyle.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.comboStyle.FormattingEnabled = true
        Me.comboStyle.ItemHeight = 19
        Me.comboStyle.Location = New System.Drawing.Point(104, 8)
        Me.comboStyle.Name = "comboStyle"
        Me.comboStyle.Size = New System.Drawing.Size(124, 25)
        Me.comboStyle.TabIndex = 1
        Me.comboStyle.UseSelectable = true
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = true
        Me.MetroLabel3.Location = New System.Drawing.Point(9, 46)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Theme Color:"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 240)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.HelpButton = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(453, 240)
        Me.Name = "FormMain"
        Me.Resizable = false
        Me.Text = "XFINITY BANDWIDTH MONITOR"
        CType(Me.MetroStyleManager1,System.ComponentModel.ISupportInitialize).EndInit
        Me.MetroTabControl1.ResumeLayout(false)
        Me.MetroTabPage1.ResumeLayout(false)
        Me.MetroTabPage1.PerformLayout
        Me.MetroTabPage2.ResumeLayout(false)
        Me.MetroTabPage2.PerformLayout
        Me.MetroTabPage3.ResumeLayout(false)
        CType(Me.MetroGrid1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UsageMonthBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.MetroTabPage4.ResumeLayout(false)
        Me.MetroPanel1.ResumeLayout(false)
        Me.MetroPanel1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents textPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents textEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents checkRemember As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents buttonLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents PolicyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HomeUsageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AllowableUsageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitOfMeasureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalBlocksUsedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalCostPerBlockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalUnitsPerBlockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalIncludedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalUsedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalPercentUsedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalRemainingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BillableOverageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OverageChargesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OverageUsedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentCreditAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaxCreditAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PolicyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsageMonthBindingSource As BindingSource
    Friend WithEvents labelCurrBandwidth As MetroFramework.Controls.MetroLabel
    Friend WithEvents comboStyle As MetroFramework.Controls.MetroComboBox
    Friend WithEvents labelMax As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelCurrent As MetroFramework.Controls.MetroLabel
    Friend WithEvents tileStatus As MetroFramework.Controls.MetroTile
    Friend WithEvents labelOverUsed As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelOverBandwidth As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents comboColor As MetroFramework.Controls.MetroComboBox
    Private WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents buttonTest As MetroFramework.Controls.MetroButton
    Friend WithEvents buttonSave As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Public WithEvents labelMaxBandwidth As MetroFramework.Controls.MetroLabel
End Class
