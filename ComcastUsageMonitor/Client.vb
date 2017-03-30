Imports ComcastUsageMonitor.apis.xfinity.services.xfinity.internet.usage
Imports Flurl.Http
Imports Newtonsoft.Json
Public Class Client
    Public Event Authentication(ByVal success As Boolean)
    Private ReadOnly _wClient As FlurlClient
    Public Sub New()
        _wClient = New FlurlClient()
        _wClient.Settings.CookiesEnabled = True
        _wClient.Settings.AllowedHttpStatusRange = "100-500"
        _wClient.WithHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.110 Safari/537.36")
        Net.ServicePointManager.Expect100Continue = False
    End Sub
    Public Async Function GetUsage() As Task(Of courtesyUsed)
        Dim resp = Await "https://customer.xfinity.com/apis/services/internet/usage".WithClient(_wClient).GetStringAsync()
        Return JsonConvert.DeserializeObject(Of courtesyUsed)(resp)
    End Function
    Public Async Sub Login(ByVal username As String, ByVal password As String)
        Dim loginUrl = Await "https://login.comcast.net/login".WithClient(_wClient).PostUrlEncodedAsync("user=" + username + "&passwd=" + password + "&r=comcast.net&s=oauth&deviceAuthn=false&continue=https%3A%2F%2Flogin.comcast.net%2Foauth%2Fauthorize%3Fclient_id%3Dmy-account-web%26redirect_uri%3Dhttps%253A%252F%252Fcustomer.xfinity.com%252Foauth%252Fcallback%26response_type%3Dcode%26state%3D%2523%252F%26response%3D1&ipAddrAuthn=false&forceAuthn=0&lang=en&passive=false&client_id=my-account-web&reqId=b353be3a-524f-40a6-90eb-e5444967b6e8")
        Dim resp = Await loginUrl.Content.ReadAsStringAsync()
        RaiseEvent Authentication(resp.Contains("My Account"))
    End Sub
End Class