Imports Newtonsoft.Json

Namespace apis.xfinity.services.xfinity.internet.tier

    Public Class Tier2

        <JsonProperty("uploadSpeed")>
        Public Property UploadSpeed As Double

        <JsonProperty("downloadSpeed")>
        Public Property DownloadSpeed As Double

        <JsonProperty("productNumber")>
        Public Property ProductNumber As String

        <JsonProperty("tierOfService")>
        Public Property TierOfService As String
    End Class

    Public Class tier

        <JsonProperty("tier")>
        Public Property Tier As Tier2
    End Class

End Namespace