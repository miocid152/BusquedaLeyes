Imports BusquedaLeyes.WebReference

Public Class DesactivacionWeb
    Private estatus As String = "ENPROCESO"
    Private llave As String = ""
    Private edoConsumido As String = ""
    Dim jws As New WebReference.BusquedaLeyes
    Public existeArchiv As Boolean = False
    Private archivoSW As String = "rsw.rsw"
    Private ipSW As String

    Public Sub New()
        Dim exists As Boolean
        exists = System.IO.File.Exists(archivoSW)
        If exists Then
            ipSW = "http://" & My.Computer.FileSystem.ReadAllText(archivoSW) + "/BusquedaLeyes/php/servicioSOAP.php?wsdl"
            jws.Url = ipSW
            Me.existeArchiv = True
        End If

    End Sub

    Public Sub consultar(llave As String)
        Me.llave = llave

        estatus = jws.consultarLicencia(Me.llave)

    End Sub

    Public Sub desConsumir(llave As String)
        edoConsumido = jws.cancelarLicencia(llave)
    End Sub

    Public Sub consumir()
        edoConsumido = jws.consumirLicencia(Me.llave)
    End Sub

    Public Property GetLlave() As String
        Get
            Return Me.llave
        End Get
        Set(ByVal value As String)
            Me.llave = value
        End Set
    End Property

    Public Property Getestatus() As String
        Get
            Return Me.estatus
        End Get
        Set(ByVal value As String)
            Me.estatus = value
        End Set
    End Property

    Public Property GetEdoConsumidos() As String
        Get
            Return Me.edoConsumido
        End Get
        Set(ByVal value As String)
            Me.edoConsumido = value
        End Set
    End Property
End Class
