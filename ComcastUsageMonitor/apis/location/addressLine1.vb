Imports Newtonsoft.Json

Namespace apis.location

    Public Class GeoCoordinates

        <JsonProperty("latitude")>
        Public Property Latitude As String

        <JsonProperty("longitude")>
        Public Property Longitude As String

        <JsonProperty("matchMethod")>
        Public Property MatchMethod As String

        <JsonProperty("geocodingPointLocation")>
        Public Property GeocodingPointLocation As String
    End Class

    Public Class Market

        <JsonProperty("system")>
        Public Property System As String

        <JsonProperty("prin")>
        Public Property Prin As String

        <JsonProperty("agent")>
        Public Property Agent As String

        <JsonProperty("corp")>
        Public Property Corp As Object

        <JsonProperty("fta")>
        Public Property Fta As Object

        <JsonProperty("region")>
        Public Property Region As String
    End Class

    Public Class addressLine1

        <JsonProperty("addressLine1")>
        Public Property AddressLine1 As String

        <JsonProperty("addressLine2")>
        Public Property AddressLine2 As Object

        <JsonProperty("city")>
        Public Property City As String

        <JsonProperty("state")>
        Public Property State As String

        <JsonProperty("zip")>
        Public Property Zip As String

        <JsonProperty("zip4")>
        Public Property Zip4 As String

        <JsonProperty("geoCoordinates")>
        Public Property GeoCoordinates As GeoCoordinates

        <JsonProperty("market")>
        Public Property Market As Market
    End Class

End Namespace