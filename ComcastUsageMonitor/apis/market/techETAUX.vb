Imports Newtonsoft.Json

Namespace apis.market

    Public Class techETAUX

        <JsonProperty("techETAUX")>
        Public Property TechETAUX As Boolean

        <JsonProperty("techETANotifications")>
        Public Property TechETANotifications As Boolean

        <JsonProperty("pnm")>
        Public Property Pnm As Boolean

        <JsonProperty("cancelService")>
        Public Property CancelService As Boolean

        <JsonProperty("virtualAssistant")>
        Public Property VirtualAssistant As Boolean

        <JsonProperty("cancelServiceV2")>
        Public Property CancelServiceV2 As Boolean

        <JsonProperty("npsSurvey")>
        Public Property NpsSurvey As Boolean

        <JsonProperty("techETAUX_3_1")>
        Public Property TechETAUX31 As Boolean

        <JsonProperty("ttsOutageService")>
        Public Property TtsOutageService As Boolean

        <JsonProperty("2FA")>
        Public Property twofa As Boolean
    End Class

End Namespace