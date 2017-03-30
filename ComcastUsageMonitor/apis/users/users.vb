Imports Newtonsoft.Json

Namespace apis.users

    Public Class User

        <JsonProperty("firstName")>
        Public Property FirstName As String

        <JsonProperty("lastName")>
        Public Property LastName As String

        <JsonProperty("displayName")>
        Public Property DisplayName As String

        <JsonProperty("email")>
        Public Property Email As String

        <JsonProperty("alternateEmail")>
        Public Property AlternateEmail As String

        <JsonProperty("uid")>
        Public Property Uid As String

        <JsonProperty("guid")>
        Public Property Guid As String

        <JsonProperty("loggedInUser")>
        Public Property LoggedInUser As Boolean

        <JsonProperty("roles")>
        Public Property Roles As String()

        <JsonProperty("preferredEmail")>
        Public Property PreferredEmail As String

        <JsonProperty("status")>
        Public Property Status As String

        <JsonProperty("mobilePhone")>
        Public Property MobilePhone As String
    End Class

    Public Class users

        <JsonProperty("users")>
        Public Property Users As User()
    End Class

End Namespace