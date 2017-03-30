Imports MetroFramework

Public Class UserControl1

    Public Sub Start(ByVal statusmsg As String)
        MetroProgressSpinner1.Enabled = True
        MetroLabel1.Text = statusmsg
    End Sub
    Public Sub [Stop](ByVal stopmsg As String, ByVal isValid As Boolean, Optional ByVal showTile As Boolean = False)

        If showTile Then
            MetroTile1.Visible = True
        End If
        If isValid Then
            MetroTile1.Text = "Authenticated"
            MetroTile1.Style = MetroColorStyle.Green
        Else
            MetroTile1.Text = "INVALID"
            MetroTile1.Style = MetroColorStyle.Red
            buttonTry.Visible = True
            MetroLabel1.Visible = False
        End If

        MetroProgressSpinner1.Visible = False
        MetroLabel1.Text = stopmsg
    End Sub

    Private Sub buttonTry_Click(sender As Object, e As EventArgs) Handles buttonTry.Click
        Me.Dispose()
    End Sub
End Class