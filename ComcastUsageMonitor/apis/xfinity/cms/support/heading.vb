Imports Newtonsoft.Json

Namespace apis.xfinity.cms.support

    Public Class Link

        <JsonProperty("url")>
        Public Property Url As String

        <JsonProperty("label")>
        Public Property Label As String
    End Class

    Public Class Heading2

        <JsonProperty("label")>
        Public Property Label As String

        <JsonProperty("link")>
        Public Property Link As Link
    End Class

    Public Class Link2

        <JsonProperty("behavior")>
        Public Property Behavior As String

        <JsonProperty("label")>
        Public Property Label As String

        <JsonProperty("url")>
        Public Property Url As String

        <JsonProperty("heading")>
        Public Property Heading As String
    End Class

    Public Class LinkWrap

        <JsonProperty("links")>
        Public Property Links As Link2()
    End Class

    Public Class Column

        <JsonProperty("link_wrap")>
        Public Property LinkWrap As LinkWrap

        <JsonProperty("title")>
        Public Property Title As String

        <JsonProperty("section")>
        Public Property Section As String

        <JsonProperty("shared")>
        Public Property [Shared] As Boolean?
    End Class

    Public Class heading

        <JsonProperty("heading")>
        Public Property Heading As Heading2

        <JsonProperty("columns")>
        Public Property Columns As Column()
    End Class

End Namespace