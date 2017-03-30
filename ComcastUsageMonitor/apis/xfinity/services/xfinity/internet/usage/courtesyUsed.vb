Imports Newtonsoft.Json

Namespace apis.xfinity.services.xfinity.internet.usage

    Public Class Device

        <JsonProperty("id")>
        Public Property Id As String

        <JsonProperty("usage")>
        Public Property Usage As Double
    End Class

    Public Class UsageMonth

        <JsonProperty("policyName")>
        Public Property PolicyName As String

        <JsonProperty("startDate")>
        Public Property StartDate As String

        <JsonProperty("endDate")>
        Public Property EndDate As String

        <JsonProperty("homeUsage")>
        Public Property HomeUsage As Double

        <JsonProperty("allowableUsage")>
        Public Property AllowableUsage As Double

        <JsonProperty("unitOfMeasure")>
        Public Property UnitOfMeasure As String

        <JsonProperty("devices")>
        Public Property Devices As Device()

        <JsonProperty("additionalBlocksUsed")>
        Public Property AdditionalBlocksUsed As Double

        <JsonProperty("additionalCostPerBlock")>
        Public Property AdditionalCostPerBlock As Double

        <JsonProperty("additionalUnitsPerBlock")>
        Public Property AdditionalUnitsPerBlock As Double?

        <JsonProperty("additionalIncluded")>
        Public Property AdditionalIncluded As Double

        <JsonProperty("additionalUsed")>
        Public Property AdditionalUsed As Double

        <JsonProperty("additionalPercentUsed")>
        Public Property AdditionalPercentUsed As Double

        <JsonProperty("additionalRemaining")>
        Public Property AdditionalRemaining As Double

        <JsonProperty("billableOverage")>
        Public Property BillableOverage As Double

        <JsonProperty("overageCharges")>
        Public Property OverageCharges As Double

        <JsonProperty("overageUsed")>
        Public Property OverageUsed As Double

        <JsonProperty("currentCreditAmount")>
        Public Property CurrentCreditAmount As Integer

        <JsonProperty("maxCreditAmount")>
        Public Property MaxCreditAmount As Integer

        <JsonProperty("policy")>
        Public Property Policy As String
    End Class

    Public Class courtesyUsed

        <JsonProperty("courtesyUsed")>
        Public Property CourtesyUsed As Integer

        <JsonProperty("courtesyRemaining")>
        Public Property CourtesyRemaining As Integer

        <JsonProperty("courtesyAllowed")>
        Public Property CourtesyAllowed As Integer

        <JsonProperty("inPaidOverage")>
        Public Property InPaidOverage As Boolean

        <JsonProperty("usageMonths")>
        Public Property UsageMonths As UsageMonth()
    End Class

End Namespace