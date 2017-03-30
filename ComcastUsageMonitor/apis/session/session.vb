Imports Newtonsoft.Json

Namespace apis.session

    Public Class Session2

        <JsonProperty("auth_time")>
        Public Property AuthTime As Integer

        <JsonProperty("time_left")>
        Public Property TimeLeft As String
    End Class

    Public Class session

        <JsonProperty("session")>
        Public Property Session As Session2
    End Class

End Namespace