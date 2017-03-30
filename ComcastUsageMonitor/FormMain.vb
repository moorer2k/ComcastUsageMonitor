Imports System.Globalization
Imports System.Windows.Media
Imports ComcastUsageMonitor.apis.xfinity.services.xfinity.internet.usage
Imports MetroFramework

Public Class FormMain
    Private WithEvents _cclient As New Client
    Private Async Sub _cclient_Authentication(success As Boolean) Handles _cclient.Authentication
        If success Then
            Dim f As courtesyUsed = Await _cclient.GetUsage()
            Dim thisMOnth As UsageMonth = f.UsageMonths.Last()
            MetroProgressBar1.Maximum = thisMOnth.AllowableUsage
            MetroGrid1.DataSource = f.UsageMonths
            labelCurrent.Text = thisMOnth.HomeUsage & " GB"
            labelMax.Text = thisMOnth.AllowableUsage & " GB"
            If thisMOnth.AllowableUsage < thisMOnth.HomeUsage Then
                tileStatus.Text = "OVER"
                tileStatus.Style = MetroColorStyle.Red
                labelOverUsed.Text = thisMOnth.OverageUsed & "GB"
                MetroProgressBar1.Value = thisMOnth.AllowableUsage
            Else
                tileStatus.Text = "GOOD"
                tileStatus.Style = MetroColorStyle.Green
                MetroProgressBar1.Value = thisMOnth.HomeUsage
            End If
            waitControl.Stop("Continue to next tab!", True, True)

        Else
            waitControl.Stop("Invalid login credentials!", False, True)
        End If
    End Sub
    Public Shared Function HexToColor(ByVal hexColor As String) As Color
        If hexColor.IndexOf("#"c) <> -1 Then
            hexColor = hexColor.Replace("#", "")
        End If
        Dim red As Integer = 0
        Dim green As Integer = 0
        Dim blue As Integer = 0
        If hexColor.Length = 6 Then
            red = Integer.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier)
            green = Integer.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier)
            blue = Integer.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier)
        ElseIf hexColor.Length = 3 Then
            red = Integer.Parse(hexColor(0).ToString() + hexColor(0).ToString(), NumberStyles.AllowHexSpecifier)
            green = Integer.Parse(hexColor(1).ToString() + hexColor(1).ToString(), NumberStyles.AllowHexSpecifier)
            blue = Integer.Parse(hexColor(2).ToString() + hexColor(2).ToString(), NumberStyles.AllowHexSpecifier)
        End If
        Return Color.FromRgb(red, green, blue)
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.StyleManager = MetroStyleManager1

        If My.Settings.remember Then
            textEmail.Text = My.Settings.email
            textPass.Text = My.Settings.password
            checkRemember.Checked = My.Settings.remember
        End If
        comboStyle.Items.AddRange([Enum].GetNames(MetroStyleManager1.Theme.GetType))
        comboStyle.SelectedIndex = 0
        comboColor.Items.AddRange([Enum].GetNames(MetroStyleManager1.Style.GetType()))
        comboColor.SelectedIndex = 0

        If My.Settings.color <> "" AndAlso My.Settings.theme <> "" Then
            MetroStyleManager1.Theme = [Enum].Parse(GetType(MetroThemeStyle), My.Settings.theme)
            MetroStyleManager1.Style = [Enum].Parse(GetType(MetroColorStyle), My.Settings.color)
            comboColor.SelectedItem = My.Settings.color
            comboStyle.SelectedItem = My.Settings.theme
        End If

    End Sub
    Private waitControl As UserControl1
    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click

        If checkRemember.Checked Then
            My.Settings.remember = True
            My.Settings.email = textEmail.Text
            My.Settings.password = textPass.Text
            My.Settings.Save()
        End If
        If textEmail.Text <> "" AndAlso textPass.Text <> "" Then
            waitControl = New UserControl1()
            waitControl.Start("Attempting to sign in.... Please wait..")
            MetroTabControl1.TabPages(0).Controls.Add(waitControl)
            waitControl.BringToFront()
            _cclient.Login(textEmail.Text, textPass.Text)
        End If

    End Sub
    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged

        If MetroTabControl1.SelectedIndex = 2 Then
            Me.Resizable = True
            Me.Refresh()
        Else
            Me.Resizable = False
            Me.Size = New Size(453, 240)
            Me.Refresh()
        End If

    End Sub
    Private Sub buttonTest_Click(sender As Object, e As EventArgs) Handles buttonTest.Click
        MetroStyleManager1.Theme = [Enum].Parse(GetType(MetroThemeStyle), comboStyle.Text)
        MetroStyleManager1.Style = [Enum].Parse(GetType(MetroColorStyle), comboColor.Text)
    End Sub
    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        My.Settings.theme = comboStyle.Text
        My.Settings.color = comboColor.Text
        My.Settings.Save()
    End Sub
End Class