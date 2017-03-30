Imports Newtonsoft.Json

Namespace apis.xfinity.bill.current

    Public Class Summary2

        <JsonProperty("billDateInMillis")>
        Public Property BillDateInMillis As Long

        <JsonProperty("billDate")>
        Public Property BillDate As DateTime

        <JsonProperty("dueDateInMillis")>
        Public Property DueDateInMillis As Long

        <JsonProperty("dueDate")>
        Public Property DueDate As DateTime

        <JsonProperty("autoPayDateInMillis")>
        Public Property AutoPayDateInMillis As Long

        <JsonProperty("autoPayDate")>
        Public Property AutoPayDate As DateTime

        <JsonProperty("autopayUnenrolledCause")>
        Public Property AutopayUnenrolledCause As Object

        <JsonProperty("autopayUnenrolledDate")>
        Public Property AutopayUnenrolledDate As Object

        <JsonProperty("promiseToPayDateInMillis")>
        Public Property PromiseToPayDateInMillis As Object

        <JsonProperty("promiseToPayDate")>
        Public Property PromiseToPayDate As Object

        <JsonProperty("softDisconnected")>
        Public Property SoftDisconnected As Boolean

        <JsonProperty("statementAvailable")>
        Public Property StatementAvailable As Boolean

        <JsonProperty("maxPaymentAmountErrorLimit")>
        Public Property MaxPaymentAmountErrorLimit As Double

        <JsonProperty("maxPaymentAmountWarningLimit")>
        Public Property MaxPaymentAmountWarningLimit As Double

        <JsonProperty("previousBalance")>
        Public Property PreviousBalance As Double

        <JsonProperty("pastDueBalance")>
        Public Property PastDueBalance As Double

        <JsonProperty("pastDueBalanceRemaining")>
        Public Property PastDueBalanceRemaining As Double

        <JsonProperty("paymentReceived")>
        Public Property PaymentReceived As Double

        <JsonProperty("newCharges")>
        Public Property NewCharges As Double

        <JsonProperty("statementBalance")>
        Public Property StatementBalance As Double

        <JsonProperty("recentPayments")>
        Public Property RecentPayments As Double

        <JsonProperty("pendingPayments")>
        Public Property PendingPayments As Integer

        <JsonProperty("balanceDue")>
        Public Property BalanceDue As Double

        <JsonProperty("status")>
        Public Property Status As String

        <JsonProperty("customerGuaranteeCreditIssued")>
        Public Property CustomerGuaranteeCreditIssued As Boolean

        <JsonProperty("firstBillPending")>
        Public Property FirstBillPending As Boolean

        <JsonProperty("billType")>
        Public Property BillType As String

        <JsonProperty("autoPayEnabled")>
        Public Property AutoPayEnabled As Boolean

        <JsonProperty("autoPayValid")>
        Public Property AutoPayValid As Boolean
    End Class

    Public Class LineItem

        <JsonProperty("description")>
        Public Property Description As String

        <JsonProperty("extendedDescription")>
        Public Property ExtendedDescription As Object

        <JsonProperty("messageDescription")>
        Public Property MessageDescription As String

        <JsonProperty("period")>
        Public Property Period As Object

        <JsonProperty("amount")>
        Public Property Amount As Double?
    End Class

    Public Class LineItemGroup

        <JsonProperty("description")>
        Public Property Description As String

        <JsonProperty("lineItems")>
        Public Property LineItems As LineItem()
    End Class

    Public Class Itemization

        <JsonProperty("description")>
        Public Property Description As String

        <JsonProperty("netAmount")>
        Public Property NetAmount As Double

        <JsonProperty("lineItemGroup")>
        Public Property LineItemGroup As LineItemGroup()
    End Class

    Public Class LineItem2

        <JsonProperty("description")>
        Public Property Description As String

        <JsonProperty("extendedDescription")>
        Public Property ExtendedDescription As Object

        <JsonProperty("messageDescription")>
        Public Property MessageDescription As String

        <JsonProperty("period")>
        Public Property Period As DateTime

        <JsonProperty("amount")>
        Public Property Amount As Double
    End Class

    Public Class LineItemGroup2

        <JsonProperty("description")>
        Public Property Description As String

        <JsonProperty("lineItems")>
        Public Property LineItems As LineItem2()
    End Class

    Public Class Unbilled

        <JsonProperty("description")>
        Public Property Description As String

        <JsonProperty("netAmount")>
        Public Property NetAmount As Double

        <JsonProperty("lineItemGroup")>
        Public Property LineItemGroup As LineItemGroup2()
    End Class

    Public Class BillingAddress

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

        <JsonProperty("type")>
        Public Property Type As String

        <JsonProperty("careOf")>
        Public Property CareOf As String
    End Class

    Public Class Delinquency

        <JsonProperty("delinquencyStatus")>
        Public Property DelinquencyStatus As String
    End Class

    Public Class EcoBillDeliveryMethod

        <JsonProperty("deliveryMethod")>
        Public Property DeliveryMethod As String
    End Class

    Public Class summary

        <JsonProperty("summary")>
        Public Property Summary As Summary2

        <JsonProperty("itemization")>
        Public Property Itemization As Itemization()

        <JsonProperty("unbilled")>
        Public Property Unbilled As Unbilled()

        <JsonProperty("billingAddress")>
        Public Property BillingAddress As BillingAddress

        <JsonProperty("delinquency")>
        Public Property Delinquency As Delinquency

        <JsonProperty("ecoBillDeliveryMethod")>
        Public Property EcoBillDeliveryMethod As EcoBillDeliveryMethod
    End Class

End Namespace