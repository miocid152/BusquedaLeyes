Imports System.IO
Imports System.Text

Public Class ValidarLicencia
    Private rutaArchivo As String = "bqales.db1"
    Private rutaRegEdit As String = "HKEY_CURRENT_USER\BusqLey"
    Private archivoRegedit As String = "llave"
    Private nombreEquipo As String = ""
    Private regedit As String
    Private archivo As String
    Public estado As String = "LICENCIAR"

    '----------------------------------------------------------------
    'Inicio
    '----------------------------------------------------------------
    Public Sub buscarLincenciamieno()
        Dim conversion As String
        Me.regedit = leerRegEdit()
        Me.archivo = leerArchivo()

        If Me.regedit.Equals("N/A") Or Me.archivo.Equals("N/A") Then
            Me.estado = "LICENCIAR"
        Else
            If Me.archivo.Equals("DIFERENTEEQUIPO") Then
                Me.estado = "DIFERENTEEQUIPO"
            Else
                conversion = convertir(Me.archivo)
                'MsgBox(conversion & " " & Me.regedit)
                If Me.regedit.Equals(conversion) Then
                    Me.estado = "OK"
                Else
                    Me.estado = "ERROR"

                End If
            End If
        End If

    End Sub
    '----------------------------------------------------------------
    'Convercion de cadena
    '----------------------------------------------------------------
    Private Function convertir(cadena As String) As String
        Dim retorno As String = ""
        Dim list As IList(Of String) = New List(Of String)(cadena.Split(New String() {"|"}, StringSplitOptions.None))
        Dim contador As Integer

        For Each element As String In list
            contador += 1
            retorno = retorno & New String(element.OrderBy(Function(c) c).ToArray())
            If contador < 5 Then
                retorno = retorno & "|"
            End If
        Next

        Return retorno
    End Function
    '----------------------------------------------------------------
    'Lectura de archivos
    '----------------------------------------------------------------
    Private Function leerRegEdit() As String
        Dim retorno As String = "N/A"
        Dim readValue = My.Computer.Registry.GetValue(Me.rutaRegEdit, Me.archivoRegedit, Nothing)

        If readValue Is Nothing Then
            retorno = "N/A"
        Else
            retorno = readValue
        End If

        Return retorno
    End Function

    Private Function leerArchivo() As String
        Dim retorno As String = "N/A"
        Dim exists As Boolean
        Me.nombreEquipo = System.Environment.MachineName

        exists = System.IO.File.Exists(Me.rutaArchivo)
        If exists Then
            retorno = My.Computer.FileSystem.ReadAllText(Me.rutaArchivo, System.Text.Encoding.UTF8)
            Dim list As IList(Of String) = New List(Of String)(retorno.Split(New String() {"|"}, StringSplitOptions.None))
            If list.Count > 5 Then
                If Not Me.nombreEquipo.Equals(list.Item(5).ToString) Then
                    retorno = "DIFERENTEEQUIPO"
                End If
            End If
        Else
            retorno = "N/A"
        End If

        Return retorno
    End Function
    '----------------------------------------------------------------
    'Getter y setter
    Public Property GetRutaArchivo() As String
        Get
            Return Me.rutaArchivo
        End Get
        Set(ByVal value As String)
            Me.rutaArchivo = value
        End Set
    End Property
    Public Property GetArchivoRegedito() As String
        Get
            Return Me.archivoRegedit
        End Get
        Set(ByVal value As String)
            Me.archivoRegedit = value
        End Set
    End Property
    Public Property GetRutaRegEdit() As String
        Get
            Return Me.rutaRegEdit
        End Get
        Set(ByVal value As String)
            Me.rutaRegEdit = value
        End Set
    End Property
    Public Property GetNombreEquipo() As String
        Get
            Return Me.nombreEquipo
        End Get
        Set(ByVal value As String)
            Me.nombreEquipo = value
        End Set
    End Property


    Public Property GetArchivo() As String
        Get
            Return Me.archivo
        End Get
        Set(ByVal value As String)
            Me.archivo = value
        End Set
    End Property
End Class
