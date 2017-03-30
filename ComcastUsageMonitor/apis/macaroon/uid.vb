Imports Newtonsoft.Json

Namespace apis.macaroon

    Partial Public Class ServiceLocation

        <JsonProperty("addressLine1")>
        Public Property AddressLine1 As String

        <JsonProperty("city")>
        Public Property City As String

        <JsonProperty("state")>
        Public Property State As String

        <JsonProperty("zip")>
        Public Property Zip As String

        <JsonProperty("zip4")>
        Public Property Zip4 As String
    End Class

    Partial Public Class Account

        <JsonProperty("accountNumber")>
        Public Property AccountNumber As String

        <JsonProperty("accountCreateDate")>
        Public Property AccountCreateDate As String

        <JsonProperty("cspToken")>
        Public Property CspToken As String

        <JsonProperty("cspTokenExpiresAt")>
        Public Property CspTokenExpiresAt As DateTime

        <JsonProperty("guid")>
        Public Property Guid As String

        <JsonProperty("firstName")>
        Public Property FirstName As String

        <JsonProperty("lastName")>
        Public Property LastName As String

        <JsonProperty("phones")>
        Public Property Phones As String()

        <JsonProperty("serviceLocation")>
        Public Property ServiceLocation As ServiceLocation
    End Class

    Public Class uid

        <JsonProperty("uid")>
        Public Property Uid As String

        <JsonProperty("guid")>
        Public Property Guid As String

        <JsonProperty("firstName")>
        Public Property FirstName As String

        <JsonProperty("lastName")>
        Public Property LastName As String

        <JsonProperty("displayName")>
        Public Property DisplayName As String

        <JsonProperty("emailForLife")>
        Public Property EmailForLife As Boolean

        <JsonProperty("mobileNumber")>
        Public Property MobileNumber As String

        <JsonProperty("mainAccountNumber")>
        Public Property MainAccountNumber As String

        <JsonProperty("mainAccountRoles")>
        Public Property MainAccountRoles As String()

        <JsonProperty("preferredEmail")>
        Public Property PreferredEmail As String

        <JsonProperty("alternateEmail")>
        Public Property AlternateEmail As String

        <JsonProperty("accounts")>
        Public Property Accounts As Account()
    End Class

End Namespace