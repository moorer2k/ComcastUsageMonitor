Imports Newtonsoft.Json

Namespace apis.devices

    Public Class DeviceStatus

        <JsonProperty("statusTime")>
        Public Property StatusTime As DateTime

        <JsonProperty("status")>
        Public Property Status As String

        <JsonProperty("statusTimeInMillis")>
        Public Property StatusTimeInMillis As Object
    End Class

    Public Class Device

        <JsonProperty("model")>
        Public Property Model As String

        <JsonProperty("mac")>
        Public Property Mac As String

        <JsonProperty("serialNumber")>
        Public Property SerialNumber As String

        <JsonProperty("make")>
        Public Property Make As String

        <JsonProperty("deviceStatus")>
        Public Property DeviceStatus As DeviceStatus
    End Class

    Public Class devices

        <JsonProperty("devices")>
        Public Property Devices As Device()
    End Class

End Namespace