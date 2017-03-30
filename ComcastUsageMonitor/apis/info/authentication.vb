Imports Newtonsoft.Json

Namespace apis.info

    Public Class authentication

        <JsonProperty("authentication")>
        Public Property Authentication As String

        <JsonProperty("release")>
        Public Property Release As String

        <JsonProperty("server")>
        Public Property Server As String
    End Class

End Namespace