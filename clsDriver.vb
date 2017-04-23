Public Class Driver

    Private driverName As String = ""
    Private driverID As String = ""

    Property ID() As String
        Get
            Return driverID
        End Get
        Set(ByVal value As String)
            driverID = value
        End Set
    End Property

    Property Name() As String
        Get
            Return driverName
        End Get
        Set(ByVal value As String)
            driverName = value
        End Set
    End Property

    Sub New()
        driverName = ""
    End Sub
End Class
